// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ECCKT_SUPPLEMENTAL__c
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib.SalesforceService
{
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class ECCKT_SUPPLEMENTAL__c : sObject
  {
    private string aCCESS_PLANNING_STATUS__cField;
    private string aCTIONTYPEQUALIFIER__cField;
    private string aCTION__cField;
    private string aCTIVE_IND__cField;
    private string aML_ALT_BANDWIDTH_CD__cField;
    private string aML_ECCKT_STATUS_CD__cField;
    private double? aML_Last_Bill_Date_Days__cField;
    private bool aML_Last_Bill_Date_Days__cFieldSpecified;
    private DateTime? aML_NETEX_TERM_AGREE_END_DT__cField;
    private bool aML_NETEX_TERM_AGREE_END_DT__cFieldSpecified;
    private DateTime? aML_NETEX_TERM_AGREE_START_DT__cField;
    private bool aML_NETEX_TERM_AGREE_START_DT__cFieldSpecified;
    private double? aML_TOTAL_MRC_AMT__cField;
    private bool aML_TOTAL_MRC_AMT__cFieldSpecified;
    private string aSG__cField;
    private DateTime? aSR_SENT_DATE__cField;
    private bool aSR_SENT_DATE__cFieldSpecified;
    private string access_Carrier_Vendor__cField;
    private Account access_Carrier_Vendor__rField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private DateTime? bTP_TERM_END_DATE__cField;
    private bool bTP_TERM_END_DATE__cFieldSpecified;
    private bool? bTP_TERM_END_MATCH__cField;
    private bool bTP_TERM_END_MATCH__cFieldSpecified;
    private string bTP_TERM_LENGTH__cField;
    private DateTime? bTP_TERM_START_DATE__cField;
    private bool bTP_TERM_START_DATE__cFieldSpecified;
    private bool? bTP_TERM_START_MATCH__cField;
    private bool bTP_TERM_START_MATCH__cFieldSpecified;
    private string bUDGET__cField;
    private string bUYING_PLAN_ID__cField;
    private ACC_CAR_BUYING_PLAN__c bUYING_PLAN_ID__rField;
    private double? cEP_Booked_Savings__cField;
    private bool cEP_Booked_Savings__cFieldSpecified;
    private string cEP_INITIATIVE_DESCRIPTION__cField;
    private string cEP_INITIATIVE__cField;
    private string cEP_L_Drive_Location__cField;
    private string cEP_Status__cField;
    private DateTime? cEP_Submit_Date__cField;
    private bool cEP_Submit_Date__cFieldSpecified;
    private string cRM_PROJECT_ID__cField;
    private string cURRENT_TERM__cField;
    private DateTime? cUST_LAST_BILL_DATE__cField;
    private bool cUST_LAST_BILL_DATE__cFieldSpecified;
    private DateTime? cUST_TERM_END_DATE__cField;
    private bool cUST_TERM_END_DATE__cFieldSpecified;
    private double? cUST_TERM__cField;
    private bool cUST_TERM__cFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private DateTime? eBD_FOC_DATE__cField;
    private bool eBD_FOC_DATE__cFieldSpecified;
    private QueryResult eCCKTS__rField;
    private bool? eCCKT_AML_ID_MATCH__cField;
    private bool eCCKT_AML_ID_MATCH__cFieldSpecified;
    private string eCCKT_AML_ID__cField;
    private string eCCKT_STRIPPED_NAME__cField;
    private ECCKT__c eCCKT_STRIPPED_NAME__rField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private bool? fORCE_CALLOUT__cField;
    private bool fORCE_CALLOUT__cFieldSpecified;
    private QueryResult feedSubscriptionsForEntityField;
    private double? gROOM_NEW_MRC__cField;
    private bool gROOM_NEW_MRC__cFieldSpecified;
    private string gROOM_PHASE__cField;
    private QueryResult historiesField;
    private string iNGROOM__cField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private DateTime? lAST_MODIFY_DATE__cField;
    private bool lAST_MODIFY_DATE__cFieldSpecified;
    private string lAST_MODIFY_REQUEST_BY__cField;
    private string lAST_MODIFY_USERID__cField;
    private DateTime? lAST_UPDATE__cField;
    private bool lAST_UPDATE__cFieldSpecified;
    private DateTime? lastActivityDateField;
    private bool lastActivityDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private double? mANUAL_FIVE_YEAR__cField;
    private bool mANUAL_FIVE_YEAR__cFieldSpecified;
    private double? mANUAL_FOUR_YEAR__cField;
    private bool mANUAL_FOUR_YEAR__cFieldSpecified;
    private double? mANUAL_ONE_YEAR__cField;
    private bool mANUAL_ONE_YEAR__cFieldSpecified;
    private double? mANUAL_THREE_YEAR__cField;
    private bool mANUAL_THREE_YEAR__cFieldSpecified;
    private double? mANUAL_TWO_YEAR__cField;
    private bool mANUAL_TWO_YEAR__cFieldSpecified;
    private string mAX_NOTE__cField;
    private bool? mONTH_TO_MONTH_MANUAL__cField;
    private bool mONTH_TO_MONTH_MANUAL__cFieldSpecified;
    private string mOST_RECENT_PON__cField;
    private string nEGOTIATED_EBD__cField;
    private DateTime? nEGOTIATE_DATE__cField;
    private bool nEGOTIATE_DATE__cFieldSpecified;
    private string nETWORK_ORDER_NUMBER__cField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private double? oDM_DAYS_IN_STATUS__cField;
    private bool oDM_DAYS_IN_STATUS__cFieldSpecified;
    private double? oDM_LENGTH_OF_TERM__cField;
    private bool oDM_LENGTH_OF_TERM__cFieldSpecified;
    private string oDM_SOURCE_SYSTEM_ID__cField;
    private DateTime? oDM_TERM_AGREE_END_DATE__cField;
    private bool oDM_TERM_AGREE_END_DATE__cFieldSpecified;
    private DateTime? oDM_TERM_AGREE_START_DATE__cField;
    private bool oDM_TERM_AGREE_START_DATE__cFieldSpecified;
    private bool? oDM_TERM_END_DATE_MATCH__cField;
    private bool oDM_TERM_END_DATE_MATCH__cFieldSpecified;
    private bool? oDM_TERM_START_DATE_MATCH__cField;
    private bool oDM_TERM_START_DATE_MATCH__cFieldSpecified;
    private DateTime? oDM_TERM_STATUS_DATE__cField;
    private bool oDM_TERM_STATUS_DATE__cFieldSpecified;
    private bool? oDM_TERM_STATUS_MATCH__cField;
    private bool oDM_TERM_STATUS_MATCH__cFieldSpecified;
    private string oDM_TERM_STATUS__cField;
    private string oFF_TO_ONNET_NOTE__cField;
    private string oN_NET_ACTION__cField;
    private string oN_NET_CAPABLE__cField;
    private DateTime? oN_NET_FUTURE_REVIEW_DATE__cField;
    private bool oN_NET_FUTURE_REVIEW_DATE__cFieldSpecified;
    private QueryResult openActivitiesField;
    private DateTime? pLANNEDCOMPLETEDATE__cField;
    private bool pLANNEDCOMPLETEDATE__cFieldSpecified;
    private string pLANNER_REVIEW_NOTE__cField;
    private DateTime? pLANNING_FUTURE_REVIEW_DATE__cField;
    private bool pLANNING_FUTURE_REVIEW_DATE__cFieldSpecified;
    private string pROJECT_STATUS__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private double? rEQUESTED_NEW_TERM_LENGTH__cField;
    private bool rEQUESTED_NEW_TERM_LENGTH__cFieldSpecified;
    private double? rETERM_NEW_MRC__cField;
    private bool rETERM_NEW_MRC__cFieldSpecified;
    private DateTime? rEVISEDPLANCOMPLETEDATE__cField;
    private bool rEVISEDPLANCOMPLETEDATE__cFieldSpecified;
    private QueryResult recordAssociatedGroupsField;
    private string sYSTEM_ID__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private bool? system_Id_Match__cField;
    private bool system_Id_Match__cFieldSpecified;
    private string tERM_HISTORY__cField;
    private string tRACKER_DISPUTE_REASON__cField;
    private string tRACKER_NOTES__cField;
    private string tRACKER_STATUS__cField;
    private QueryResult tasksField;
    private double? term_Ending__cField;
    private bool term_Ending__cFieldSpecified;
    private double? term_Status_Automation_Trigger__cField;
    private bool term_Status_Automation_Trigger__cFieldSpecified;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;
    private string vENDOR_EBD_TYPE__cField;
    private string wIP_RECORD__cField;
    private WIP_Data__c wIP_RECORD__rField;

    [XmlElement(IsNullable = true)]
    public string ACCESS_PLANNING_STATUS__c
    {
      get => this.aCCESS_PLANNING_STATUS__cField;
      set => this.aCCESS_PLANNING_STATUS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACTIONTYPEQUALIFIER__c
    {
      get => this.aCTIONTYPEQUALIFIER__cField;
      set => this.aCTIONTYPEQUALIFIER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACTION__c
    {
      get => this.aCTION__cField;
      set => this.aCTION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACTIVE_IND__c
    {
      get => this.aCTIVE_IND__cField;
      set => this.aCTIVE_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AML_ALT_BANDWIDTH_CD__c
    {
      get => this.aML_ALT_BANDWIDTH_CD__cField;
      set => this.aML_ALT_BANDWIDTH_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AML_ECCKT_STATUS_CD__c
    {
      get => this.aML_ECCKT_STATUS_CD__cField;
      set => this.aML_ECCKT_STATUS_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AML_Last_Bill_Date_Days__c
    {
      get => this.aML_Last_Bill_Date_Days__cField;
      set => this.aML_Last_Bill_Date_Days__cField = value;
    }

    [XmlIgnore]
    public bool AML_Last_Bill_Date_Days__cSpecified
    {
      get => this.aML_Last_Bill_Date_Days__cFieldSpecified;
      set => this.aML_Last_Bill_Date_Days__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? AML_NETEX_TERM_AGREE_END_DT__c
    {
      get => this.aML_NETEX_TERM_AGREE_END_DT__cField;
      set => this.aML_NETEX_TERM_AGREE_END_DT__cField = value;
    }

    [XmlIgnore]
    public bool AML_NETEX_TERM_AGREE_END_DT__cSpecified
    {
      get => this.aML_NETEX_TERM_AGREE_END_DT__cFieldSpecified;
      set => this.aML_NETEX_TERM_AGREE_END_DT__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? AML_NETEX_TERM_AGREE_START_DT__c
    {
      get => this.aML_NETEX_TERM_AGREE_START_DT__cField;
      set => this.aML_NETEX_TERM_AGREE_START_DT__cField = value;
    }

    [XmlIgnore]
    public bool AML_NETEX_TERM_AGREE_START_DT__cSpecified
    {
      get => this.aML_NETEX_TERM_AGREE_START_DT__cFieldSpecified;
      set => this.aML_NETEX_TERM_AGREE_START_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AML_TOTAL_MRC_AMT__c
    {
      get => this.aML_TOTAL_MRC_AMT__cField;
      set => this.aML_TOTAL_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool AML_TOTAL_MRC_AMT__cSpecified
    {
      get => this.aML_TOTAL_MRC_AMT__cFieldSpecified;
      set => this.aML_TOTAL_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASG__c
    {
      get => this.aSG__cField;
      set => this.aSG__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ASR_SENT_DATE__c
    {
      get => this.aSR_SENT_DATE__cField;
      set => this.aSR_SENT_DATE__cField = value;
    }

    [XmlIgnore]
    public bool ASR_SENT_DATE__cSpecified
    {
      get => this.aSR_SENT_DATE__cFieldSpecified;
      set => this.aSR_SENT_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Access_Carrier_Vendor__c
    {
      get => this.access_Carrier_Vendor__cField;
      set => this.access_Carrier_Vendor__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account Access_Carrier_Vendor__r
    {
      get => this.access_Carrier_Vendor__rField;
      set => this.access_Carrier_Vendor__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Attachments
    {
      get => this.attachmentsField;
      set => this.attachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? BTP_TERM_END_DATE__c
    {
      get => this.bTP_TERM_END_DATE__cField;
      set => this.bTP_TERM_END_DATE__cField = value;
    }

    [XmlIgnore]
    public bool BTP_TERM_END_DATE__cSpecified
    {
      get => this.bTP_TERM_END_DATE__cFieldSpecified;
      set => this.bTP_TERM_END_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? BTP_TERM_END_MATCH__c
    {
      get => this.bTP_TERM_END_MATCH__cField;
      set => this.bTP_TERM_END_MATCH__cField = value;
    }

    [XmlIgnore]
    public bool BTP_TERM_END_MATCH__cSpecified
    {
      get => this.bTP_TERM_END_MATCH__cFieldSpecified;
      set => this.bTP_TERM_END_MATCH__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string BTP_TERM_LENGTH__c
    {
      get => this.bTP_TERM_LENGTH__cField;
      set => this.bTP_TERM_LENGTH__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? BTP_TERM_START_DATE__c
    {
      get => this.bTP_TERM_START_DATE__cField;
      set => this.bTP_TERM_START_DATE__cField = value;
    }

    [XmlIgnore]
    public bool BTP_TERM_START_DATE__cSpecified
    {
      get => this.bTP_TERM_START_DATE__cFieldSpecified;
      set => this.bTP_TERM_START_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? BTP_TERM_START_MATCH__c
    {
      get => this.bTP_TERM_START_MATCH__cField;
      set => this.bTP_TERM_START_MATCH__cField = value;
    }

    [XmlIgnore]
    public bool BTP_TERM_START_MATCH__cSpecified
    {
      get => this.bTP_TERM_START_MATCH__cFieldSpecified;
      set => this.bTP_TERM_START_MATCH__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string BUDGET__c
    {
      get => this.bUDGET__cField;
      set => this.bUDGET__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BUYING_PLAN_ID__c
    {
      get => this.bUYING_PLAN_ID__cField;
      set => this.bUYING_PLAN_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ACC_CAR_BUYING_PLAN__c BUYING_PLAN_ID__r
    {
      get => this.bUYING_PLAN_ID__rField;
      set => this.bUYING_PLAN_ID__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CEP_Booked_Savings__c
    {
      get => this.cEP_Booked_Savings__cField;
      set => this.cEP_Booked_Savings__cField = value;
    }

    [XmlIgnore]
    public bool CEP_Booked_Savings__cSpecified
    {
      get => this.cEP_Booked_Savings__cFieldSpecified;
      set => this.cEP_Booked_Savings__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CEP_INITIATIVE_DESCRIPTION__c
    {
      get => this.cEP_INITIATIVE_DESCRIPTION__cField;
      set => this.cEP_INITIATIVE_DESCRIPTION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CEP_INITIATIVE__c
    {
      get => this.cEP_INITIATIVE__cField;
      set => this.cEP_INITIATIVE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CEP_L_Drive_Location__c
    {
      get => this.cEP_L_Drive_Location__cField;
      set => this.cEP_L_Drive_Location__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CEP_Status__c
    {
      get => this.cEP_Status__cField;
      set => this.cEP_Status__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? CEP_Submit_Date__c
    {
      get => this.cEP_Submit_Date__cField;
      set => this.cEP_Submit_Date__cField = value;
    }

    [XmlIgnore]
    public bool CEP_Submit_Date__cSpecified
    {
      get => this.cEP_Submit_Date__cFieldSpecified;
      set => this.cEP_Submit_Date__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CRM_PROJECT_ID__c
    {
      get => this.cRM_PROJECT_ID__cField;
      set => this.cRM_PROJECT_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CURRENT_TERM__c
    {
      get => this.cURRENT_TERM__cField;
      set => this.cURRENT_TERM__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? CUST_LAST_BILL_DATE__c
    {
      get => this.cUST_LAST_BILL_DATE__cField;
      set => this.cUST_LAST_BILL_DATE__cField = value;
    }

    [XmlIgnore]
    public bool CUST_LAST_BILL_DATE__cSpecified
    {
      get => this.cUST_LAST_BILL_DATE__cFieldSpecified;
      set => this.cUST_LAST_BILL_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? CUST_TERM_END_DATE__c
    {
      get => this.cUST_TERM_END_DATE__cField;
      set => this.cUST_TERM_END_DATE__cField = value;
    }

    [XmlIgnore]
    public bool CUST_TERM_END_DATE__cSpecified
    {
      get => this.cUST_TERM_END_DATE__cFieldSpecified;
      set => this.cUST_TERM_END_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CUST_TERM__c
    {
      get => this.cUST_TERM__cField;
      set => this.cUST_TERM__cField = value;
    }

    [XmlIgnore]
    public bool CUST_TERM__cSpecified
    {
      get => this.cUST_TERM__cFieldSpecified;
      set => this.cUST_TERM__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
    }

    [XmlElement(IsNullable = true)]
    public User CreatedBy
    {
      get => this.createdByField;
      set => this.createdByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CreatedById
    {
      get => this.createdByIdField;
      set => this.createdByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? CreatedDate
    {
      get => this.createdDateField;
      set => this.createdDateField = value;
    }

    [XmlIgnore]
    public bool CreatedDateSpecified
    {
      get => this.createdDateFieldSpecified;
      set => this.createdDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? EBD_FOC_DATE__c
    {
      get => this.eBD_FOC_DATE__cField;
      set => this.eBD_FOC_DATE__cField = value;
    }

    [XmlIgnore]
    public bool EBD_FOC_DATE__cSpecified
    {
      get => this.eBD_FOC_DATE__cFieldSpecified;
      set => this.eBD_FOC_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS__r
    {
      get => this.eCCKTS__rField;
      set => this.eCCKTS__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ECCKT_AML_ID_MATCH__c
    {
      get => this.eCCKT_AML_ID_MATCH__cField;
      set => this.eCCKT_AML_ID_MATCH__cField = value;
    }

    [XmlIgnore]
    public bool ECCKT_AML_ID_MATCH__cSpecified
    {
      get => this.eCCKT_AML_ID_MATCH__cFieldSpecified;
      set => this.eCCKT_AML_ID_MATCH__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_AML_ID__c
    {
      get => this.eCCKT_AML_ID__cField;
      set => this.eCCKT_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_STRIPPED_NAME__c
    {
      get => this.eCCKT_STRIPPED_NAME__cField;
      set => this.eCCKT_STRIPPED_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ECCKT__c ECCKT_STRIPPED_NAME__r
    {
      get => this.eCCKT_STRIPPED_NAME__rField;
      set => this.eCCKT_STRIPPED_NAME__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Events
    {
      get => this.eventsField;
      set => this.eventsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? FORCE_CALLOUT__c
    {
      get => this.fORCE_CALLOUT__cField;
      set => this.fORCE_CALLOUT__cField = value;
    }

    [XmlIgnore]
    public bool FORCE_CALLOUT__cSpecified
    {
      get => this.fORCE_CALLOUT__cFieldSpecified;
      set => this.fORCE_CALLOUT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? GROOM_NEW_MRC__c
    {
      get => this.gROOM_NEW_MRC__cField;
      set => this.gROOM_NEW_MRC__cField = value;
    }

    [XmlIgnore]
    public bool GROOM_NEW_MRC__cSpecified
    {
      get => this.gROOM_NEW_MRC__cFieldSpecified;
      set => this.gROOM_NEW_MRC__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string GROOM_PHASE__c
    {
      get => this.gROOM_PHASE__cField;
      set => this.gROOM_PHASE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string INGROOM__c
    {
      get => this.iNGROOM__cField;
      set => this.iNGROOM__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeleted
    {
      get => this.isDeletedField;
      set => this.isDeletedField = value;
    }

    [XmlIgnore]
    public bool IsDeletedSpecified
    {
      get => this.isDeletedFieldSpecified;
      set => this.isDeletedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LAST_MODIFY_DATE__c
    {
      get => this.lAST_MODIFY_DATE__cField;
      set => this.lAST_MODIFY_DATE__cField = value;
    }

    [XmlIgnore]
    public bool LAST_MODIFY_DATE__cSpecified
    {
      get => this.lAST_MODIFY_DATE__cFieldSpecified;
      set => this.lAST_MODIFY_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LAST_MODIFY_REQUEST_BY__c
    {
      get => this.lAST_MODIFY_REQUEST_BY__cField;
      set => this.lAST_MODIFY_REQUEST_BY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LAST_MODIFY_USERID__c
    {
      get => this.lAST_MODIFY_USERID__cField;
      set => this.lAST_MODIFY_USERID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LAST_UPDATE__c
    {
      get => this.lAST_UPDATE__cField;
      set => this.lAST_UPDATE__cField = value;
    }

    [XmlIgnore]
    public bool LAST_UPDATE__cSpecified
    {
      get => this.lAST_UPDATE__cFieldSpecified;
      set => this.lAST_UPDATE__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? LastActivityDate
    {
      get => this.lastActivityDateField;
      set => this.lastActivityDateField = value;
    }

    [XmlIgnore]
    public bool LastActivityDateSpecified
    {
      get => this.lastActivityDateFieldSpecified;
      set => this.lastActivityDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User LastModifiedBy
    {
      get => this.lastModifiedByField;
      set => this.lastModifiedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastModifiedById
    {
      get => this.lastModifiedByIdField;
      set => this.lastModifiedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastModifiedDate
    {
      get => this.lastModifiedDateField;
      set => this.lastModifiedDateField = value;
    }

    [XmlIgnore]
    public bool LastModifiedDateSpecified
    {
      get => this.lastModifiedDateFieldSpecified;
      set => this.lastModifiedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastReferencedDate
    {
      get => this.lastReferencedDateField;
      set => this.lastReferencedDateField = value;
    }

    [XmlIgnore]
    public bool LastReferencedDateSpecified
    {
      get => this.lastReferencedDateFieldSpecified;
      set => this.lastReferencedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastViewedDate
    {
      get => this.lastViewedDateField;
      set => this.lastViewedDateField = value;
    }

    [XmlIgnore]
    public bool LastViewedDateSpecified
    {
      get => this.lastViewedDateFieldSpecified;
      set => this.lastViewedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MANUAL_FIVE_YEAR__c
    {
      get => this.mANUAL_FIVE_YEAR__cField;
      set => this.mANUAL_FIVE_YEAR__cField = value;
    }

    [XmlIgnore]
    public bool MANUAL_FIVE_YEAR__cSpecified
    {
      get => this.mANUAL_FIVE_YEAR__cFieldSpecified;
      set => this.mANUAL_FIVE_YEAR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MANUAL_FOUR_YEAR__c
    {
      get => this.mANUAL_FOUR_YEAR__cField;
      set => this.mANUAL_FOUR_YEAR__cField = value;
    }

    [XmlIgnore]
    public bool MANUAL_FOUR_YEAR__cSpecified
    {
      get => this.mANUAL_FOUR_YEAR__cFieldSpecified;
      set => this.mANUAL_FOUR_YEAR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MANUAL_ONE_YEAR__c
    {
      get => this.mANUAL_ONE_YEAR__cField;
      set => this.mANUAL_ONE_YEAR__cField = value;
    }

    [XmlIgnore]
    public bool MANUAL_ONE_YEAR__cSpecified
    {
      get => this.mANUAL_ONE_YEAR__cFieldSpecified;
      set => this.mANUAL_ONE_YEAR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MANUAL_THREE_YEAR__c
    {
      get => this.mANUAL_THREE_YEAR__cField;
      set => this.mANUAL_THREE_YEAR__cField = value;
    }

    [XmlIgnore]
    public bool MANUAL_THREE_YEAR__cSpecified
    {
      get => this.mANUAL_THREE_YEAR__cFieldSpecified;
      set => this.mANUAL_THREE_YEAR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MANUAL_TWO_YEAR__c
    {
      get => this.mANUAL_TWO_YEAR__cField;
      set => this.mANUAL_TWO_YEAR__cField = value;
    }

    [XmlIgnore]
    public bool MANUAL_TWO_YEAR__cSpecified
    {
      get => this.mANUAL_TWO_YEAR__cFieldSpecified;
      set => this.mANUAL_TWO_YEAR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MAX_NOTE__c
    {
      get => this.mAX_NOTE__cField;
      set => this.mAX_NOTE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MONTH_TO_MONTH_MANUAL__c
    {
      get => this.mONTH_TO_MONTH_MANUAL__cField;
      set => this.mONTH_TO_MONTH_MANUAL__cField = value;
    }

    [XmlIgnore]
    public bool MONTH_TO_MONTH_MANUAL__cSpecified
    {
      get => this.mONTH_TO_MONTH_MANUAL__cFieldSpecified;
      set => this.mONTH_TO_MONTH_MANUAL__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MOST_RECENT_PON__c
    {
      get => this.mOST_RECENT_PON__cField;
      set => this.mOST_RECENT_PON__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NEGOTIATED_EBD__c
    {
      get => this.nEGOTIATED_EBD__cField;
      set => this.nEGOTIATED_EBD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? NEGOTIATE_DATE__c
    {
      get => this.nEGOTIATE_DATE__cField;
      set => this.nEGOTIATE_DATE__cField = value;
    }

    [XmlIgnore]
    public bool NEGOTIATE_DATE__cSpecified
    {
      get => this.nEGOTIATE_DATE__cFieldSpecified;
      set => this.nEGOTIATE_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETWORK_ORDER_NUMBER__c
    {
      get => this.nETWORK_ORDER_NUMBER__cField;
      set => this.nETWORK_ORDER_NUMBER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Notes
    {
      get => this.notesField;
      set => this.notesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult NotesAndAttachments
    {
      get => this.notesAndAttachmentsField;
      set => this.notesAndAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ODM_DAYS_IN_STATUS__c
    {
      get => this.oDM_DAYS_IN_STATUS__cField;
      set => this.oDM_DAYS_IN_STATUS__cField = value;
    }

    [XmlIgnore]
    public bool ODM_DAYS_IN_STATUS__cSpecified
    {
      get => this.oDM_DAYS_IN_STATUS__cFieldSpecified;
      set => this.oDM_DAYS_IN_STATUS__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ODM_LENGTH_OF_TERM__c
    {
      get => this.oDM_LENGTH_OF_TERM__cField;
      set => this.oDM_LENGTH_OF_TERM__cField = value;
    }

    [XmlIgnore]
    public bool ODM_LENGTH_OF_TERM__cSpecified
    {
      get => this.oDM_LENGTH_OF_TERM__cFieldSpecified;
      set => this.oDM_LENGTH_OF_TERM__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_SOURCE_SYSTEM_ID__c
    {
      get => this.oDM_SOURCE_SYSTEM_ID__cField;
      set => this.oDM_SOURCE_SYSTEM_ID__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ODM_TERM_AGREE_END_DATE__c
    {
      get => this.oDM_TERM_AGREE_END_DATE__cField;
      set => this.oDM_TERM_AGREE_END_DATE__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_AGREE_END_DATE__cSpecified
    {
      get => this.oDM_TERM_AGREE_END_DATE__cFieldSpecified;
      set => this.oDM_TERM_AGREE_END_DATE__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ODM_TERM_AGREE_START_DATE__c
    {
      get => this.oDM_TERM_AGREE_START_DATE__cField;
      set => this.oDM_TERM_AGREE_START_DATE__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_AGREE_START_DATE__cSpecified
    {
      get => this.oDM_TERM_AGREE_START_DATE__cFieldSpecified;
      set => this.oDM_TERM_AGREE_START_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ODM_TERM_END_DATE_MATCH__c
    {
      get => this.oDM_TERM_END_DATE_MATCH__cField;
      set => this.oDM_TERM_END_DATE_MATCH__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_END_DATE_MATCH__cSpecified
    {
      get => this.oDM_TERM_END_DATE_MATCH__cFieldSpecified;
      set => this.oDM_TERM_END_DATE_MATCH__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ODM_TERM_START_DATE_MATCH__c
    {
      get => this.oDM_TERM_START_DATE_MATCH__cField;
      set => this.oDM_TERM_START_DATE_MATCH__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_START_DATE_MATCH__cSpecified
    {
      get => this.oDM_TERM_START_DATE_MATCH__cFieldSpecified;
      set => this.oDM_TERM_START_DATE_MATCH__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ODM_TERM_STATUS_DATE__c
    {
      get => this.oDM_TERM_STATUS_DATE__cField;
      set => this.oDM_TERM_STATUS_DATE__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_STATUS_DATE__cSpecified
    {
      get => this.oDM_TERM_STATUS_DATE__cFieldSpecified;
      set => this.oDM_TERM_STATUS_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ODM_TERM_STATUS_MATCH__c
    {
      get => this.oDM_TERM_STATUS_MATCH__cField;
      set => this.oDM_TERM_STATUS_MATCH__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_STATUS_MATCH__cSpecified
    {
      get => this.oDM_TERM_STATUS_MATCH__cFieldSpecified;
      set => this.oDM_TERM_STATUS_MATCH__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_TERM_STATUS__c
    {
      get => this.oDM_TERM_STATUS__cField;
      set => this.oDM_TERM_STATUS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OFF_TO_ONNET_NOTE__c
    {
      get => this.oFF_TO_ONNET_NOTE__cField;
      set => this.oFF_TO_ONNET_NOTE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ON_NET_ACTION__c
    {
      get => this.oN_NET_ACTION__cField;
      set => this.oN_NET_ACTION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ON_NET_CAPABLE__c
    {
      get => this.oN_NET_CAPABLE__cField;
      set => this.oN_NET_CAPABLE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ON_NET_FUTURE_REVIEW_DATE__c
    {
      get => this.oN_NET_FUTURE_REVIEW_DATE__cField;
      set => this.oN_NET_FUTURE_REVIEW_DATE__cField = value;
    }

    [XmlIgnore]
    public bool ON_NET_FUTURE_REVIEW_DATE__cSpecified
    {
      get => this.oN_NET_FUTURE_REVIEW_DATE__cFieldSpecified;
      set => this.oN_NET_FUTURE_REVIEW_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? PLANNEDCOMPLETEDATE__c
    {
      get => this.pLANNEDCOMPLETEDATE__cField;
      set => this.pLANNEDCOMPLETEDATE__cField = value;
    }

    [XmlIgnore]
    public bool PLANNEDCOMPLETEDATE__cSpecified
    {
      get => this.pLANNEDCOMPLETEDATE__cFieldSpecified;
      set => this.pLANNEDCOMPLETEDATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PLANNER_REVIEW_NOTE__c
    {
      get => this.pLANNER_REVIEW_NOTE__cField;
      set => this.pLANNER_REVIEW_NOTE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? PLANNING_FUTURE_REVIEW_DATE__c
    {
      get => this.pLANNING_FUTURE_REVIEW_DATE__cField;
      set => this.pLANNING_FUTURE_REVIEW_DATE__cField = value;
    }

    [XmlIgnore]
    public bool PLANNING_FUTURE_REVIEW_DATE__cSpecified
    {
      get => this.pLANNING_FUTURE_REVIEW_DATE__cFieldSpecified;
      set => this.pLANNING_FUTURE_REVIEW_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECT_STATUS__c
    {
      get => this.pROJECT_STATUS__cField;
      set => this.pROJECT_STATUS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessInstances
    {
      get => this.processInstancesField;
      set => this.processInstancesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessSteps
    {
      get => this.processStepsField;
      set => this.processStepsField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? REQUESTED_NEW_TERM_LENGTH__c
    {
      get => this.rEQUESTED_NEW_TERM_LENGTH__cField;
      set => this.rEQUESTED_NEW_TERM_LENGTH__cField = value;
    }

    [XmlIgnore]
    public bool REQUESTED_NEW_TERM_LENGTH__cSpecified
    {
      get => this.rEQUESTED_NEW_TERM_LENGTH__cFieldSpecified;
      set => this.rEQUESTED_NEW_TERM_LENGTH__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RETERM_NEW_MRC__c
    {
      get => this.rETERM_NEW_MRC__cField;
      set => this.rETERM_NEW_MRC__cField = value;
    }

    [XmlIgnore]
    public bool RETERM_NEW_MRC__cSpecified
    {
      get => this.rETERM_NEW_MRC__cFieldSpecified;
      set => this.rETERM_NEW_MRC__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? REVISEDPLANCOMPLETEDATE__c
    {
      get => this.rEVISEDPLANCOMPLETEDATE__cField;
      set => this.rEVISEDPLANCOMPLETEDATE__cField = value;
    }

    [XmlIgnore]
    public bool REVISEDPLANCOMPLETEDATE__cSpecified
    {
      get => this.rEVISEDPLANCOMPLETEDATE__cFieldSpecified;
      set => this.rEVISEDPLANCOMPLETEDATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SYSTEM_ID__c
    {
      get => this.sYSTEM_ID__cField;
      set => this.sYSTEM_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SystemModstamp
    {
      get => this.systemModstampField;
      set => this.systemModstampField = value;
    }

    [XmlIgnore]
    public bool SystemModstampSpecified
    {
      get => this.systemModstampFieldSpecified;
      set => this.systemModstampFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? System_Id_Match__c
    {
      get => this.system_Id_Match__cField;
      set => this.system_Id_Match__cField = value;
    }

    [XmlIgnore]
    public bool System_Id_Match__cSpecified
    {
      get => this.system_Id_Match__cFieldSpecified;
      set => this.system_Id_Match__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TERM_HISTORY__c
    {
      get => this.tERM_HISTORY__cField;
      set => this.tERM_HISTORY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TRACKER_DISPUTE_REASON__c
    {
      get => this.tRACKER_DISPUTE_REASON__cField;
      set => this.tRACKER_DISPUTE_REASON__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TRACKER_NOTES__c
    {
      get => this.tRACKER_NOTES__cField;
      set => this.tRACKER_NOTES__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TRACKER_STATUS__c
    {
      get => this.tRACKER_STATUS__cField;
      set => this.tRACKER_STATUS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Tasks
    {
      get => this.tasksField;
      set => this.tasksField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Term_Ending__c
    {
      get => this.term_Ending__cField;
      set => this.term_Ending__cField = value;
    }

    [XmlIgnore]
    public bool Term_Ending__cSpecified
    {
      get => this.term_Ending__cFieldSpecified;
      set => this.term_Ending__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Term_Status_Automation_Trigger__c
    {
      get => this.term_Status_Automation_Trigger__cField;
      set => this.term_Status_Automation_Trigger__cField = value;
    }

    [XmlIgnore]
    public bool Term_Status_Automation_Trigger__cSpecified
    {
      get => this.term_Status_Automation_Trigger__cFieldSpecified;
      set => this.term_Status_Automation_Trigger__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR_EBD_TYPE__c
    {
      get => this.vENDOR_EBD_TYPE__cField;
      set => this.vENDOR_EBD_TYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string WIP_RECORD__c
    {
      get => this.wIP_RECORD__cField;
      set => this.wIP_RECORD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public WIP_Data__c WIP_RECORD__r
    {
      get => this.wIP_RECORD__rField;
      set => this.wIP_RECORD__rField = value;
    }
  }
}
