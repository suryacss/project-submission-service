// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.ProjectSubmissionsWorker
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using ProjectSubmissionsSvcLib.ExternalServices;
using ProjectSubmissionsSvcLib.NetBuildOrderService;
using ProjectSubmissionsSvcLib.SalesforceService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Web.Services.Protocols;

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public class ProjectSubmissionsWorker : MQWorkerThread
  {
    private string dbConnectionString;
    private string processName;
    private string fileNameSuffix;
    private SforceService salesforceService;

    public ProjectSubmissionsWorker(
      string queuePath,
      long msgLookUpId,
      string id,
      string logDir,
      string dbConnectionString,
      string processName)
      : base(queuePath, msgLookUpId, id)
    {
      this.dbConnectionString = dbConnectionString;
      this.processName = processName;
    }

    public override void doActualWork(string msgString)
    {
      SortedList sortedList = new SortedList();
      string str1 = string.Empty;
      try
      {
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Message read from MSMQ:ProjectSubmissionsQ");
        dynamic obj1 = JsonConvert.DeserializeObject(msgString);
        if (obj1 != null)
        {
          foreach (dynamic obj3 in obj1)
          {
            str1 = (string)obj3["networkOrderDetail"]["networkOrder"]["networkOrderProject"]["projectIdentifier"].ToString();
            string projectSfdcId = (string)obj3["networkOrderDetail"]["networkOrder"]["projectSalesforceId"].ToString();
            string subProjectSfdcId = (string)obj3["networkOrderDetail"]["networkOrder"]["subProjectSalesforceId"].ToString();
            string subProjectIdentifier = (string)obj3["networkOrderDetail"]["networkOrder"]["subProjectIdentifier"].ToString();
            int subPrjSubmissionSequence = Convert.ToInt32(obj3["networkOrderDetail"]["networkOrder"]["subProjectSubmissionSequence"].ToString());
            string str2 = string.Empty;
            if (obj3["networkOrderDetail"]["networkOrder"]["orderIdentifier"] != null)
            {
              str2 = (string)obj3["networkOrderDetail"]["networkOrder"]["orderIdentifier"]["orderNumber"].ToString();
            }
            createNetworkOrder createNetworkOrder = JsonConvert.DeserializeObject<createNetworkOrder>((string)obj3.ToString());
            SubProject subProject1 = new SubProject();
            subProject1.projectSfdcId = projectSfdcId;
            subProject1.projectIdentifier = str1;
            subProject1.subProjectSfdcId = subProjectSfdcId;
            subProject1.subProjectIdentifier = subProjectIdentifier;
            subProject1.subPrjSubmissionSequence = subPrjSubmissionSequence;
            subProject1.subPrjJsonMsg = (string)obj3.ToString();
            subProject1.subPrjRequest = createNetworkOrder;
            subProject1.subProjectGroomsOrderNumber = str2;
            sortedList.Add(subPrjSubmissionSequence, subProject1);
          }
          this.fileNameSuffix = str1;
          string fileNameSuffix = this.fileNameSuffix;
          Logger.WriteLog(Logger.LogLevel.DEBUG, "Project_ID: " + str1, fileNameSuffix: fileNameSuffix);
          if (sortedList.Count > 0 && !string.IsNullOrEmpty(str1))
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Message de-serialization completed successfully. Sub-Projects count: " + (object) sortedList.Count, fileNameSuffix: this.fileNameSuffix);
          else
            Logger.WriteLog(Logger.LogLevel.DEBUG, "No Sub-Projects found.", fileNameSuffix: this.fileNameSuffix);
          Logger.WriteLog(Logger.LogLevel.DEBUG, "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", fileNameSuffix: this.fileNameSuffix);
        }
        for (int index1 = 0; index1 < sortedList.Count; ++index1)
        {
          SubProject byIndex1 = (SubProject) sortedList.GetByIndex(index1);
          Hashtable dbLogHash = new Hashtable()
          {
            {
              (object) "NetBuild_Submission_Status",
              (object) "F"
            },
            {
              (object) "Prime_Update_Status",
              (object) "F"
            },
            {
              (object) "Timestamp",
              (object) DateTime.Now
            },
            {
              (object) "Prime_Request",
              (object) msgString
            }
          };
          bool isLastSubProject = index1 + 1 == sortedList.Count;
          bool flag = this.SubmitSubProject(byIndex1, dbLogHash, isLastSubProject);
          if (!isLastSubProject && string.IsNullOrEmpty(byIndex1.subProjectGroomsOrderNumber) && !flag)
          {
            List<string> subProjectSfdcIdList = new List<string>();
            for (int index2 = index1 + 1; index2 < sortedList.Count; ++index2)
            {
              SubProject byIndex2 = (SubProject) sortedList.GetByIndex(index2);
              subProjectSfdcIdList.Add(byIndex2.subProjectSfdcId);
            }
            this.UpdateSalesforceWithProjectSuppressFlagAndSubProjectStatus(byIndex1.projectSfdcId, subProjectSfdcIdList);
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Project submission interrupted.", fileNameSuffix: this.fileNameSuffix);
            break;
          }
          if (isLastSubProject)
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Project submission completed.", fileNameSuffix: this.fileNameSuffix);
        }
      }
      catch (Exception ex)
      {
        string fileNameSuffix1 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "Error => " + ex.Message, fileNameSuffix: fileNameSuffix1);
        string fileNameSuffix2 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "StackTrace => " + ex.StackTrace, fileNameSuffix: fileNameSuffix2);
        Misc.Email(this.processName + ": Fail to process Project Submission", "Exception Error => {" + ex.Message + "}\n\nException StackTrace => {" + ex.StackTrace + "}\n\nProject Message => {\n" + msgString + "}");
      }
    }

    private bool SubmitSubProject(SubProject subPrj, Hashtable dbLogHash, bool isLastSubProject)
    {
      bool flag = true;
      DataAccess dataAccess = new DataAccess(this.dbConnectionString);
      Hashtable subPrjSfdcHash = new Hashtable();
      string empty = string.Empty;
      try
      {
        dbLogHash.Add((object) "Project_Id", (object) subPrj.projectIdentifier);
        dbLogHash.Add((object) "Sub_Project", (object) subPrj.subProjectIdentifier);
        dbLogHash.Add((object) "Sub_Project_Request", (object) subPrj.subPrjJsonMsg);
        string fileNameSuffix1 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Sub-Project: " + subPrj.subProjectIdentifier, fileNameSuffix: fileNameSuffix1);
        if (subPrj.subPrjRequest != null && subPrj.subPrjRequest.networkOrderDetail != null && subPrj.subPrjRequest.networkOrderDetail.networkOrder != null)
        {
          if (!string.IsNullOrEmpty(subPrj.subPrjRequest.networkOrderDetail.networkOrder.networkOrderCreatedBy))
          {
            dbLogHash.Add((object) "Planner", (object) subPrj.subPrjRequest.networkOrderDetail.networkOrder.networkOrderCreatedBy);
            string fileNameSuffix2 = this.fileNameSuffix;
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Planner: " + subPrj.subPrjRequest.networkOrderDetail.networkOrder.networkOrderCreatedBy, fileNameSuffix: fileNameSuffix2);
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Deserialized message has data to proceed.", fileNameSuffix: this.fileNameSuffix);
            OrderBindingClient buildOrderService = ServiceHelper.GetNetBuildOrderService(true);
            string fileNameSuffix3 = this.fileNameSuffix;
            Logger.WriteLog(Logger.LogLevel.DEBUG, "NetBuild service instance created and endpoint is " + (object) buildOrderService.Endpoint.ListenUri, fileNameSuffix: fileNameSuffix3);
            createNetworkOrder subPrjRequest = subPrj.subPrjRequest;
            if (this.OverrideDesignWidgetData(ref subPrjRequest, ref dbLogHash, ref subPrjSfdcHash, buildOrderService))
            {
              this.SubmitProjectToNetBuild(ref subPrjRequest, ref dbLogHash, ref subPrjSfdcHash, buildOrderService);
              if (!dbLogHash.ContainsKey((object) "Received_GOID"))
                flag = false;
            }
            else
              flag = false;
          }
          else
          {
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Planner is empty", fileNameSuffix: this.fileNameSuffix);
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Sub-Project submission is stopped.", fileNameSuffix: this.fileNameSuffix);
            flag = false;
          }
        }
        else
        {
          Logger.WriteLog(Logger.LogLevel.DEBUG, "Deserialized message has NO data to proceed.", fileNameSuffix: this.fileNameSuffix);
          flag = false;
        }
      }
      catch (Exception ex)
      {
        flag = false;
        string fileNameSuffix4 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "Error => " + ex.Message, fileNameSuffix: fileNameSuffix4);
        string fileNameSuffix5 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "StackTrace => " + ex.StackTrace, fileNameSuffix: fileNameSuffix5);
        Misc.Email(this.processName + ": Fail to process Project Submission", "Exception Error => {" + ex.Message + "}\n\nException StackTrace => {" + ex.StackTrace + "}\n\nProject Message => {\n" + subPrj.subPrjJsonMsg + "}");
        subPrjSfdcHash.Add((object) "GROOM_SUBMISSION_DETAIL__c", ex.Message.Length > (int) byte.MaxValue ? (object) ex.Message.Substring(0, (int) byte.MaxValue) : (object) ex.Message);
      }
      try
      {
        if (!string.IsNullOrEmpty(subPrj.projectSfdcId))
        {
          if (!string.IsNullOrEmpty(subPrj.subProjectSfdcId))
          {
            if (subPrjSfdcHash.Count > 0)
              this.UpdateSalesforceWithSubProjectSubmissionStatus(subPrj.projectSfdcId, subPrj.subProjectSfdcId, subPrjSfdcHash, ref dbLogHash, isLastSubProject);
          }
        }
      }
      catch (Exception ex)
      {
        string str = string.Empty;
        foreach (object key in (IEnumerable) dbLogHash.Keys)
          str = str + key + ": " + dbLogHash[key] + Environment.NewLine;
        string fileNameSuffix6 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "Salesforce status update Error => " + ex.Message, fileNameSuffix: fileNameSuffix6);
        string fileNameSuffix7 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "Salesforce status update StackTrace => " + ex.StackTrace, fileNameSuffix: fileNameSuffix7);
        string fileNameSuffix8 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "Salesforce status data => " + str, fileNameSuffix: fileNameSuffix8);
        Misc.Email(this.processName + ": Fail to Update Status back to Prime for Project Submission", "Exception Error => {" + ex.Message + "}\n\nException StackTrace => {" + ex.StackTrace + "}\n\nProject Message => {\n" + str + "}");
      }
      try
      {
        if (dbLogHash.Count > 0)
        {
          int num = dataAccess.Insert("Prime_Project_Logger", dbLogHash);
          string fileNameSuffix = this.fileNameSuffix;
          Logger.WriteLog(Logger.LogLevel.DEBUG, num == 1 ? "DB Logging is completed." : "DB Logging is failed for some reason.", fileNameSuffix: fileNameSuffix);
        }
      }
      catch (Exception ex)
      {
        string str = string.Empty;
        foreach (object key in (IEnumerable) dbLogHash.Keys)
          str = str + key + ": " + dbLogHash[key] + Environment.NewLine;
        string fileNameSuffix9 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "Logging Data Persistance Error => " + ex.Message, fileNameSuffix: fileNameSuffix9);
        string fileNameSuffix10 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "Logging Data Persistance Error. StackTrace => " + ex.StackTrace, fileNameSuffix: fileNameSuffix10);
        string fileNameSuffix11 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.INFO, "Logging Data => " + str, fileNameSuffix: fileNameSuffix11);
        Misc.Email(this.processName + ": Fail to persist Log data for Project Submission", "Exception Error => {" + ex.Message + "}\n\nException StackTrace => {" + ex.StackTrace + "}\n\nLogging Data => {\n" + str + "}");
      }
      Logger.WriteLog(Logger.LogLevel.DEBUG, "Sub-Project submission completed.", fileNameSuffix: this.fileNameSuffix);
      Logger.WriteLog(Logger.LogLevel.DEBUG, "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", fileNameSuffix: this.fileNameSuffix);
      return flag;
    }

    private bool OverrideDesignWidgetData(
      ref createNetworkOrder createNetworkOrderRequest,
      ref Hashtable dbLogHash,
      ref Hashtable subPrjSfdcHash,
      OrderBindingClient netBuildOrderService)
    {
      if (createNetworkOrderRequest != null && createNetworkOrderRequest.networkOrderDetail != null && createNetworkOrderRequest.networkOrderDetail.networkOrder != null)
      {
        if (createNetworkOrderRequest.networkOrderDetail.networkOrder.orderIdentifier != null && !string.IsNullOrEmpty(createNetworkOrderRequest.networkOrderDetail.networkOrder.orderIdentifier.orderNumber) && !string.IsNullOrEmpty(createNetworkOrderRequest.networkOrderDetail.networkOrder.orderIdentifier.orderVersion))
        {
          string orderNumber = createNetworkOrderRequest.networkOrderDetail.networkOrder.orderIdentifier.orderNumber;
          string orderVersion = createNetworkOrderRequest.networkOrderDetail.networkOrder.orderIdentifier.orderVersion;
          Logger.WriteLog(Logger.LogLevel.DEBUG, "This is an EXISTING project re-submission.", fileNameSuffix: this.fileNameSuffix);
          string fileNameSuffix1 = this.fileNameSuffix;
          Logger.WriteLog(Logger.LogLevel.DEBUG, "NetBuild Existing OrderNumber: " + orderNumber, fileNameSuffix: fileNameSuffix1);
          string fileNameSuffix2 = this.fileNameSuffix;
          Logger.WriteLog(Logger.LogLevel.DEBUG, "NetBuild Existing OrderVersion: " + orderVersion, fileNameSuffix: fileNameSuffix2);
          dbLogHash.Add((object) "Submitted_GOID", (object) orderNumber);
          OrderIdentifier orderIdentifier = new OrderIdentifier()
          {
            orderNumber = orderNumber,
            orderVersion = orderVersion
          };
          Logger.WriteLog(Logger.LogLevel.DEBUG, "Initiating NetBuild service call for getNetworkOrder.", fileNameSuffix: this.fileNameSuffix);
          getNetworkOrder getNetworkOrder = new getNetworkOrder();
          getNetworkOrder.context = new Context()
          {
            source = "PRIME",
            performer = createNetworkOrderRequest.networkOrderDetail.networkOrder.networkOrderSubmittedBy,
            correlationId = Guid.NewGuid().ToString()
          };
          getNetworkOrder.networkOrderIdentifier = orderIdentifier;
          getNetworkOrder getNetworkOrder1 = getNetworkOrder;
          dbLogHash.Add((object) "Netbuild_Get_Request", (object) Misc.getSerializeData((object) getNetworkOrder1));
          getNetworkOrderResponse networkOrder = netBuildOrderService.getNetworkOrder(getNetworkOrder1);
          Logger.WriteLog(Logger.LogLevel.DEBUG, "Completed NetBuild service call for getNetworkOrder.", fileNameSuffix: this.fileNameSuffix);
          dbLogHash.Add((object) "Netbuild_Get_Response", (object) Misc.getSerializeData((object) networkOrder));
          if (networkOrder.isError)
          {
            string fileNameSuffix3 = this.fileNameSuffix;
            Logger.WriteLog(Logger.LogLevel.DEBUG, "There was an error from NetBuild getNetworkOrder service call. The error returned was: " + networkOrder.exception.message, fileNameSuffix: fileNameSuffix3);
            Logger.WriteLog(Logger.LogLevel.DEBUG, "More details from error :", fileNameSuffix: this.fileNameSuffix);
            string fileNameSuffix4 = this.fileNameSuffix;
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Exception detail: " + networkOrder.exception.detail, fileNameSuffix: fileNameSuffix4);
            string fileNameSuffix5 = this.fileNameSuffix;
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Sub exception: " + (object) networkOrder.exception.subException, fileNameSuffix: fileNameSuffix5);
            subPrjSfdcHash.Add((object) "SUB_PROJECT_STATUS__c", (object) "Submit Failed");
            subPrjSfdcHash.Add((object) "GROOM_SUBMISSION_DETAIL__c", networkOrder.exception.message.Length > (int) byte.MaxValue ? (object) networkOrder.exception.message.Substring(0, (int) byte.MaxValue) : (object) networkOrder.exception.message);
            return false;
          }
          Dictionary<string, GroomsCircuit> netBuildData = new Dictionary<string, GroomsCircuit>();
          foreach (GroomsCircuit groomsCircuit in ((IEnumerable<NetworkOrderItemDetail>) networkOrder.networkOrderDetail.networkOrderItems).SelectMany((Func<NetworkOrderItemDetail, IEnumerable<NetworkOrderItemComponent>>) (networkOrderItem => (IEnumerable<NetworkOrderItemComponent>) networkOrderItem.networkOrderItemComponents)).Select(component => component.networkOrderItemComponentResource.groomsCircuit).Where<GroomsCircuit>((Func<GroomsCircuit, bool>) (groomsCircuit => groomsCircuit != null)).Where<GroomsCircuit>((Func<GroomsCircuit, bool>) (groomsCircuit => netBuildData != null && !netBuildData.ContainsKey(groomsCircuit.ECCKT))))
            netBuildData.Add(groomsCircuit.ECCKT, groomsCircuit);
          if (netBuildData.Count > 0)
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Got circuit data from NetBuild getNetworkOrder service call.", fileNameSuffix: this.fileNameSuffix);
          Logger.WriteLog(Logger.LogLevel.DEBUG, "Design Widget data ovverride start.", fileNameSuffix: this.fileNameSuffix);
          foreach (NetworkOrderItemDetail networkOrderItem in createNetworkOrderRequest.networkOrderDetail.networkOrderItems)
          {
            if (networkOrderItem != null && netBuildData.ContainsKey(networkOrderItem.networkOrderItemComponents[0].networkOrderItemComponentResource.groomsCircuit.ECCKT))
            {
              GroomsCircuit groomsCircuit = netBuildData[networkOrderItem.networkOrderItemComponents[0].networkOrderItemComponentResource.groomsCircuit.ECCKT];
              string fileNameSuffix6 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "Design Widget data ovverride for ECCKT: " + groomsCircuit.ECCKT, fileNameSuffix: fileNameSuffix6);
              string fileNameSuffix7 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "cutPointDetails: " + groomsCircuit.cutPointDetails, fileNameSuffix: fileNameSuffix7);
              networkOrderItem.networkOrderItemComponents[0].networkOrderItemComponentResource.groomsCircuit.cutPointDetails = groomsCircuit.cutPointDetails;
              string fileNameSuffix8 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "DCSCrossConnect: " + groomsCircuit.DCSCrossConnect, fileNameSuffix: fileNameSuffix8);
              networkOrderItem.networkOrderItemComponents[0].networkOrderItemComponentResource.groomsCircuit.DCSCrossConnect = groomsCircuit.DCSCrossConnect;
              string fileNameSuffix9 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "eccktACLLI: " + groomsCircuit.eccktACLLI, fileNameSuffix: fileNameSuffix9);
              networkOrderItem.networkOrderItemComponents[0].networkOrderItemComponentResource.groomsCircuit.eccktACLLI = groomsCircuit.eccktACLLI;
              string fileNameSuffix10 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "eccktZCLLI: " + groomsCircuit.eccktZCLLI, fileNameSuffix: fileNameSuffix10);
              networkOrderItem.networkOrderItemComponents[0].networkOrderItemComponentResource.groomsCircuit.eccktZCLLI = groomsCircuit.eccktZCLLI;
              string fileNameSuffix11 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "router: " + groomsCircuit.router, fileNameSuffix: fileNameSuffix11);
              networkOrderItem.networkOrderItemComponents[0].networkOrderItemComponentResource.groomsCircuit.router = groomsCircuit.router;
            }
          }
          Logger.WriteLog(Logger.LogLevel.DEBUG, "Design Widget data ovverride completed.", fileNameSuffix: this.fileNameSuffix);
        }
        else
          Logger.WriteLog(Logger.LogLevel.DEBUG, "This is a NEW project submission.", fileNameSuffix: this.fileNameSuffix);
      }
      return true;
    }

    private void SubmitProjectToNetBuild(
      ref createNetworkOrder createNetworkOrderRequest,
      ref Hashtable dbLogHash,
      ref Hashtable subPrjSfdcHash,
      OrderBindingClient netBuildOrderService)
    {
      createNetworkOrderRequest.context = new Context()
      {
        source = "PRIME",
        performer = createNetworkOrderRequest.networkOrderDetail.networkOrder.networkOrderSubmittedBy,
        correlationId = Guid.NewGuid().ToString()
      };
      Logger.WriteLog(Logger.LogLevel.DEBUG, "Initiating NetBuild service call for createNetworkOrder.", fileNameSuffix: this.fileNameSuffix);
      dbLogHash.Add((object) "NetBuild_Create_Request", (object) Misc.getSerializeData((object) createNetworkOrderRequest));
      createNetworkOrderResponse networkOrder = netBuildOrderService.createNetworkOrder(createNetworkOrderRequest);
      Logger.WriteLog(Logger.LogLevel.DEBUG, "Response recieved from NetBuild service call for createNetworkOrder.", fileNameSuffix: this.fileNameSuffix);
      dbLogHash.Add((object) "NetBuild_Create_Response", (object) Misc.getSerializeData((object) networkOrder));
      if (!networkOrder.isError)
      {
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Project submitted successfully.", fileNameSuffix: this.fileNameSuffix);
        string fileNameSuffix1 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "NetBuild OrderNumber:" + networkOrder.networkOrderIdentifier.orderNumber, fileNameSuffix: fileNameSuffix1);
        string fileNameSuffix2 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "NetBuild OrderVersion:" + networkOrder.networkOrderIdentifier.orderVersion, fileNameSuffix: fileNameSuffix2);
        dbLogHash[(object) "NetBuild_Submission_Status"] = (object) "S";
        dbLogHash[(object) "Received_GOID"] = (object) networkOrder.networkOrderIdentifier.orderNumber;
        subPrjSfdcHash.Add((object) "GROOMS_ORDER_NUMBER__c", (object) networkOrder.networkOrderIdentifier.orderNumber);
        subPrjSfdcHash.Add((object) "SUB_PROJECT_SUBMIT_DATE__cSpecified", (object) true);
        if (dbLogHash.ContainsKey((object) "Submitted_GOID"))
        {
          subPrjSfdcHash.Add((object) "SUB_PROJECT_STATUS__c", (object) "Revision Submitted");
          subPrjSfdcHash.Add((object) "GROOM_SUBMISSION_DETAIL__c", (object) "Revision submission successful.");
        }
        else
        {
          subPrjSfdcHash.Add((object) "SUB_PROJECT_STATUS__c", (object) "Submitted");
          subPrjSfdcHash.Add((object) "GROOM_SUBMISSION_DETAIL__c", (object) "Submission successful.");
        }
      }
      else
      {
        string fileNameSuffix3 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "There was an error from Project submission to NetBuild. The error returned was: " + networkOrder.exception.message, fileNameSuffix: fileNameSuffix3);
        Logger.WriteLog(Logger.LogLevel.DEBUG, "More details from error :", fileNameSuffix: this.fileNameSuffix);
        string fileNameSuffix4 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Exception detail: " + networkOrder.exception.detail, fileNameSuffix: fileNameSuffix4);
        string fileNameSuffix5 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Sub exception: " + (object) networkOrder.exception.subException, fileNameSuffix: fileNameSuffix5);
        subPrjSfdcHash.Add((object) "SUB_PROJECT_STATUS__c", dbLogHash.ContainsKey((object) "Submitted_GOID") ? (object) "Resubmit Failed" : (object) "Submit Failed");
        subPrjSfdcHash.Add((object) "GROOM_SUBMISSION_DETAIL__c", (object) networkOrder.exception.detail);
      }
    }

    private void UpdateSalesforceWithSubProjectSubmissionStatus(
      string projectSfdcId,
      string subProjectSfdcId,
      Hashtable subPrjSfdcHash,
      ref Hashtable dbLogHash,
      bool unlockProject)
    {
      Logger.WriteLog(Logger.LogLevel.DEBUG, "Update Salesforce with Sub-Project submission status", fileNameSuffix: this.fileNameSuffix);
      foreach (object key in (IEnumerable) subPrjSfdcHash.Keys)
      {
        string fileNameSuffix = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, key.ToString() + ": " + subPrjSfdcHash[key], fileNameSuffix: fileNameSuffix);
      }
      if (this.salesforceService == null)
      {
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Salesforce endpoint not found, instantiating endpoint...", fileNameSuffix: this.fileNameSuffix);
        this.salesforceService = ServiceHelper.GetSalesforceService();
      }
      else
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Salesforce endpoint is already instantiated.", fileNameSuffix: this.fileNameSuffix);
      Logger.WriteLog(Logger.LogLevel.DEBUG, "Salesforce service instance created and endpoint is " + this.salesforceService.Url, fileNameSuffix: this.fileNameSuffix);
      Logger.WriteLog(Logger.LogLevel.DEBUG, "Update SUB_PROJECT_HEADER__c on salesforce. ", fileNameSuffix: this.fileNameSuffix);
      List<sObject> sObjectList = new List<sObject>();
      try
      {
        SUB_PROJECT_HEADER__c subProjectHeaderC1 = new SUB_PROJECT_HEADER__c();
        subProjectHeaderC1.Id = subProjectSfdcId;
        SUB_PROJECT_HEADER__c subProjectHeaderC2 = subProjectHeaderC1;
        if (subPrjSfdcHash.ContainsKey((object) "GROOMS_ORDER_NUMBER__c"))
        {
          subProjectHeaderC2.GROOMS_ORDER_NUMBER__c = subPrjSfdcHash[(object) "GROOMS_ORDER_NUMBER__c"].ToString();
          subProjectHeaderC2.SUB_PROJECT_SUBMIT_DATE__cSpecified = true;
          subProjectHeaderC2.SUB_PROJECT_SUBMIT_DATE__c = new DateTime?(DateTime.UtcNow.Date);
        }
        subProjectHeaderC2.SUB_PROJECT_STATUS__c = subPrjSfdcHash[(object) "SUB_PROJECT_STATUS__c"].ToString();
        subProjectHeaderC2.GROOM_SUBMISSION_DETAIL__c = subPrjSfdcHash[(object) "GROOM_SUBMISSION_DETAIL__c"].ToString();
        if (!dbLogHash.ContainsKey((object) "Submitted_GOID"))
        {
          Logger.WriteLog(Logger.LogLevel.DEBUG, "Since this is NEW submission, updating Initial Submit Date", fileNameSuffix: this.fileNameSuffix);
          subProjectHeaderC2.SUB_PROJECT_INITIAL_SUBMIT_DATE__cSpecified = true;
          subProjectHeaderC2.SUB_PROJECT_INITIAL_SUBMIT_DATE__c = new DateTime?(DateTime.UtcNow);
          Logger.WriteLog(Logger.LogLevel.DEBUG, "SUB_PROJECT_INITIAL_SUBMIT_DATE__cSpecified: True", fileNameSuffix: this.fileNameSuffix);
          Logger.WriteLog(Logger.LogLevel.DEBUG, "SUB_PROJECT_INITIAL_SUBMIT_DATE__c: " + (object) DateTime.UtcNow, fileNameSuffix: this.fileNameSuffix);
        }
        if (unlockProject)
        {
          PROJECT_HEADER__c projectHeaderC1 = new PROJECT_HEADER__c();
          projectHeaderC1.Id = projectSfdcId;
          projectHeaderC1.SUPPRESS_SUBMISSION__cSpecified = true;
          projectHeaderC1.SUPPRESS_SUBMISSION__c = new bool?(false);
          PROJECT_HEADER__c projectHeaderC2 = projectHeaderC1;
          sObjectList.Add((sObject) projectHeaderC2);
        }
        sObjectList.Add((sObject) subProjectHeaderC2);
        SaveResult[] saveResultArray = this.salesforceService.update(sObjectList.ToArray());
        bool flag = true;
        string str = string.Empty;
        foreach (SaveResult saveResult in saveResultArray)
        {
          if (saveResult.success)
          {
            string fileNameSuffix = this.fileNameSuffix;
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Successfully updated Salesforce ID: " + saveResult.id, fileNameSuffix: fileNameSuffix);
          }
          else
          {
            flag = false;
            ProjectSubmissionsSvcLib.SalesforceService.Error[] errors = saveResult.errors;
            if (errors.Length > 0)
            {
              str = str + Environment.NewLine + "Error: could not update Salesforce ID " + saveResult.id + "." + "\tThe error reported was: (" + (object) errors[0].statusCode + ") " + errors[0].message + ".";
              string fileNameSuffix1 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "Error: could not update Salesforce ID " + saveResult.id + ".", fileNameSuffix: fileNameSuffix1);
              string fileNameSuffix2 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "\tThe error reported was: (" + (object) errors[0].statusCode + ") " + errors[0].message + ".", fileNameSuffix: fileNameSuffix2);
            }
          }
        }
        if (flag)
          dbLogHash[(object) "Prime_Update_Status"] = (object) "S";
        else
          Misc.Email(this.processName + ": Failure to Update Status back to Prime for Project Submission", "Failure to Update Status back to Prime for Project Submission for one or more records(PROJECT_HEADER__c Or SUB_PROJECT_HEADER__c), please check below mentioned Salesforce Id's to check their record types." + Environment.NewLine + str);
      }
      catch (SoapException ex)
      {
        string fileNameSuffix = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "An unexpected error has occurred: " + ex.Message + "\n" + ex.StackTrace, fileNameSuffix: fileNameSuffix);
      }
    }

    private void UpdateSalesforceWithProjectSuppressFlagAndSubProjectStatus(
      string projectSfdcId,
      List<string> subProjectSfdcIdList)
    {
      Logger.WriteLog(Logger.LogLevel.DEBUG, "Update Salesforce Project suppress submission flag and the status for sub-projects which are pending for submission to  interrupted", fileNameSuffix: this.fileNameSuffix);
      if (this.salesforceService == null)
      {
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Instantiating Salesforce endpoint...", fileNameSuffix: this.fileNameSuffix);
        this.salesforceService = ServiceHelper.GetSalesforceService();
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Salesforce service instance created and endpoint is " + this.salesforceService.Url, fileNameSuffix: this.fileNameSuffix);
      }
      List<sObject> sObjectList = new List<sObject>();
      try
      {
        string fileNameSuffix1 = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "Update PROJECT_HEADER__c for " + projectSfdcId, fileNameSuffix: fileNameSuffix1);
        PROJECT_HEADER__c projectHeaderC1 = new PROJECT_HEADER__c();
        projectHeaderC1.Id = projectSfdcId;
        projectHeaderC1.SUPPRESS_SUBMISSION__cSpecified = true;
        projectHeaderC1.SUPPRESS_SUBMISSION__c = new bool?(false);
        PROJECT_HEADER__c projectHeaderC2 = projectHeaderC1;
        sObjectList.Add((sObject) projectHeaderC2);
        foreach (string subProjectSfdcId in subProjectSfdcIdList)
        {
          SUB_PROJECT_HEADER__c subProjectHeaderC1 = new SUB_PROJECT_HEADER__c();
          subProjectHeaderC1.Id = subProjectSfdcId;
          subProjectHeaderC1.SUB_PROJECT_STATUS__c = "Interrupted";
          subProjectHeaderC1.GROOM_SUBMISSION_DETAIL__c = "Submission interrupted due to failure sub-project submission in the sequence.";
          SUB_PROJECT_HEADER__c subProjectHeaderC2 = subProjectHeaderC1;
          sObjectList.Add((sObject) subProjectHeaderC2);
        }
        SaveResult[] saveResultArray = this.salesforceService.update(sObjectList.ToArray());
        bool flag = true;
        string str = string.Empty;
        foreach (SaveResult saveResult in saveResultArray)
        {
          if (saveResult.success)
          {
            string fileNameSuffix2 = this.fileNameSuffix;
            Logger.WriteLog(Logger.LogLevel.DEBUG, "Successfully updated Salesforce ID: " + saveResult.id, fileNameSuffix: fileNameSuffix2);
          }
          else
          {
            flag = false;
            ProjectSubmissionsSvcLib.SalesforceService.Error[] errors = saveResult.errors;
            if (errors.Length > 0)
            {
              str = str + Environment.NewLine + "Error: could not update Salesforce ID " + saveResult.id + "." + "\tThe error reported was: (" + (object) errors[0].statusCode + ") " + errors[0].message + ".";
              string fileNameSuffix3 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "Error: could not update Salesforce ID " + saveResult.id + ".", fileNameSuffix: fileNameSuffix3);
              string fileNameSuffix4 = this.fileNameSuffix;
              Logger.WriteLog(Logger.LogLevel.DEBUG, "\tThe error reported was: (" + (object) errors[0].statusCode + ") " + errors[0].message + ".", fileNameSuffix: fileNameSuffix4);
            }
          }
        }
        if (flag)
          return;
        Misc.Email(this.processName + ": Failure to unlock Project (PROJECT_HEADER__c) or update status for Sub-project (SUB_PROJECT_HEADER__c) on Prime", "Failure to Update Status back to Prime for Project Submission for one or more records(PROJECT_HEADER__c Or SUB_PROJECT_HEADER__c), please check below mentioned Salesforce Id's to check their record types." + Environment.NewLine + str);
      }
      catch (SoapException ex)
      {
        string fileNameSuffix = this.fileNameSuffix;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "An unexpected error has occurred: " + ex.Message + "\n" + ex.StackTrace, fileNameSuffix: fileNameSuffix);
      }
    }
  }
}
