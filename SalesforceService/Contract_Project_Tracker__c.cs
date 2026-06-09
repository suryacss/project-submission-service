// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Contract_Project_Tracker__c
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class Contract_Project_Tracker__c : sObject
  {
    private DateTime? access_Planning_Team_Notified__cField;
    private bool access_Planning_Team_Notified__cFieldSpecified;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string automated_Quoting__cField;
    private DateTime? bB_Qustionnaire_Completd_Saved_to_LDrive__cField;
    private bool bB_Qustionnaire_Completd_Saved_to_LDrive__cFieldSpecified;
    private string broadband_Questionnaire_File_Path__cField;
    private DateTime? broadband_Questionnaire_Sent_to_Vendor__cField;
    private bool broadband_Questionnaire_Sent_to_Vendor__cFieldSpecified;
    private DateTime? building_Lists_Posted_to_SharePoint__cField;
    private bool building_Lists_Posted_to_SharePoint__cFieldSpecified;
    private DateTime? cRM_Approvals_Received_Saved_to_LDrive__cField;
    private bool cRM_Approvals_Received_Saved_to_LDrive__cFieldSpecified;
    private DateTime? cRM_Management_Approvals_Date__cField;
    private bool cRM_Management_Approvals_Date__cFieldSpecified;
    private string cRM__cField;
    private string cancel_Reason__cField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private DateTime? contract_Effective_Date__cField;
    private bool contract_Effective_Date__cFieldSpecified;
    private DateTime? contract_Expiration_Date__cField;
    private bool contract_Expiration_Date__cFieldSpecified;
    private DateTime? contract_Summary_Created_Updated__cField;
    private bool contract_Summary_Created_Updated__cFieldSpecified;
    private DateTime? contract_Template_Amendment_Sent_to_Vend__cField;
    private bool contract_Template_Amendment_Sent_to_Vend__cFieldSpecified;
    private double? contract_Term__cField;
    private bool contract_Term__cFieldSpecified;
    private string contract_Title__cField;
    private string contract_Type__cField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private DateTime? date_Executed_by_Level_3__cField;
    private bool date_Executed_by_Level_3__cFieldSpecified;
    private DateTime? date_Executed_by_Vendor__cField;
    private bool date_Executed_by_Vendor__cFieldSpecified;
    private DateTime? date_Routed_for_Signature__cField;
    private bool date_Routed_for_Signature__cFieldSpecified;
    private double? days_Since_Project_Start__cField;
    private bool days_Since_Project_Start__cFieldSpecified;
    private double? days_Since_Status_Change__cField;
    private bool days_Since_Status_Change__cFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private QueryResult emailsField;
    private string entity_Legacy_Company__cField;
    private DateTime? escalation_List_Posted_to_SharePoint__cField;
    private bool escalation_List_Posted_to_SharePoint__cFieldSpecified;
    private bool? evergreen_Contract__cField;
    private bool evergreen_Contract__cFieldSpecified;
    private DateTime? executed_Contract_Emailed_to_Documentum__cField;
    private bool executed_Contract_Emailed_to_Documentum__cFieldSpecified;
    private string executed_Contract_File_Path__cField;
    private DateTime? executed_Contract_Saved_to_LDrive__cField;
    private bool executed_Contract_Saved_to_LDrive__cFieldSpecified;
    private DateTime? executed_Original_Contract_sent_to_Legal__cField;
    private bool executed_Original_Contract_sent_to_Legal__cFieldSpecified;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult historiesField;
    private string internal_Requesting_Org_Contact_Person__cField;
    private string internal_Requesting_Org_Contact_Phone__cField;
    private string internal_Requesting_Organization__cField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string issues__cField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private DateTime? legal_Approvals_Date__cField;
    private bool legal_Approvals_Date__cFieldSpecified;
    private DateTime? legal_Approvals_Rcvd_Saved_to_LDrive__cField;
    private bool legal_Approvals_Rcvd_Saved_to_LDrive__cFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private string manual_COG_Quoting__cField;
    private string markets__cField;
    private DateTime? nDA_Executed_Saved_to_Ldrive__cField;
    private bool nDA_Executed_Saved_to_Ldrive__cFieldSpecified;
    private string nDA_File_Path__cField;
    private string nORMALIZED_VENDOR_NAME__cField;
    private Account nORMALIZED_VENDOR_NAME__rField;
    private string nVR_Descrip_Priority_Reason_Timeframe__cField;
    private string nameField;
    private DateTime? netEx_Team_Notified__cField;
    private bool netEx_Team_Notified__cFieldSpecified;
    private DateTime? new_Vendor_Request_Submit_Date__cField;
    private bool new_Vendor_Request_Submit_Date__cFieldSpecified;
    private string new_Vendor_Risk_Assessment_Completed__cField;
    private DateTime? new_Vendor_Set_Up_Packet_Sent_to_Vendor__cField;
    private bool new_Vendor_Set_Up_Packet_Sent_to_Vendor__cFieldSpecified;
    private DateTime? new_Vendor_Set_Up_Request_to_Vndr_Mngmt__cField;
    private bool new_Vendor_Set_Up_Request_to_Vndr_Mngmt__cFieldSpecified;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string notes_Comments__cField;
    private DateTime? obtained_Vendor_Mngmt_Billing_Forms_from__cField;
    private bool obtained_Vendor_Mngmt_Billing_Forms_from__cFieldSpecified;
    private DateTime? order_Form_Posted_to_SharePoint__cField;
    private bool order_Form_Posted_to_SharePoint__cFieldSpecified;
    private DateTime? order_Form_eBonding_Process_Posted_to_Sh__cField;
    private bool order_Form_eBonding_Process_Posted_to_Sh__cFieldSpecified;
    private string order_Intervals_DLR__cField;
    private string other_Requesting_Organization__cField;
    private string other_Service_Type__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private DateTime? pIP_Completed_Saved_to_LDrive__cField;
    private bool pIP_Completed_Saved_to_LDrive__cFieldSpecified;
    private string perform_Pricing_Cost_Analysis__cField;
    private double? potential_Buildings__cField;
    private bool potential_Buildings__cFieldSpecified;
    private string priority__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private double? project_Age__cField;
    private bool project_Age__cFieldSpecified;
    private string project_Contract_Description__cField;
    private DateTime? project_Start_Date__cField;
    private bool project_Start_Date__cFieldSpecified;
    private DateTime? project_Status_Change_Date__cField;
    private bool project_Status_Change_Date__cFieldSpecified;
    private string project_Status__cField;
    private string project_Title__cField;
    private string provider_Info_Packet_File_Path__cField;
    private DateTime? provider_Info_Packet_PIP_Sent_to_Vendor__cField;
    private bool provider_Info_Packet_PIP_Sent_to_Vendor__cFieldSpecified;
    private DateTime? provisioning_Team_Notified__cField;
    private bool provisioning_Team_Notified__cFieldSpecified;
    private QueryResult recordAssociatedGroupsField;
    private string service_Types__cField;
    private string standard_Installation_Intervals__cField;
    private string submitted_By__cField;
    private string summary_of_Price_Cost_Analysis__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string template_Paper__cField;
    private QueryResult topicAssignmentsField;
    private DateTime? update_VTA_Tool_Notify_Drew_Berke__cField;
    private bool update_VTA_Tool_Notify_Drew_Berke__cFieldSpecified;
    private UserRecordAccess userRecordAccessField;
    private string vENDOR__cField;
    private DateTime? vendor_Comm_Ops_Team_Notified__cField;
    private bool vendor_Comm_Ops_Team_Notified__cFieldSpecified;
    private string vendor_Contact_Email__cField;
    private string vendor_Contact_Name__cField;
    private string vendor_Contact_Phone__cField;
    private string vendor_Market_Footprint__cField;
    private string vendor_Normalized_Name_Mirror__cField;
    private DateTime? vendor_Onboarding_Team_Notified__cField;
    private bool vendor_Onboarding_Team_Notified__cFieldSpecified;
    private string vendor_Website__cField;
    private string test_mirror_field__cField;

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Access_Planning_Team_Notified__c
    {
      get => this.access_Planning_Team_Notified__cField;
      set => this.access_Planning_Team_Notified__cField = value;
    }

    [XmlIgnore]
    public bool Access_Planning_Team_Notified__cSpecified
    {
      get => this.access_Planning_Team_Notified__cFieldSpecified;
      set => this.access_Planning_Team_Notified__cFieldSpecified = value;
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
    public string Automated_Quoting__c
    {
      get => this.automated_Quoting__cField;
      set => this.automated_Quoting__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? BB_Qustionnaire_Completd_Saved_to_LDrive__c
    {
      get => this.bB_Qustionnaire_Completd_Saved_to_LDrive__cField;
      set => this.bB_Qustionnaire_Completd_Saved_to_LDrive__cField = value;
    }

    [XmlIgnore]
    public bool BB_Qustionnaire_Completd_Saved_to_LDrive__cSpecified
    {
      get => this.bB_Qustionnaire_Completd_Saved_to_LDrive__cFieldSpecified;
      set => this.bB_Qustionnaire_Completd_Saved_to_LDrive__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Broadband_Questionnaire_File_Path__c
    {
      get => this.broadband_Questionnaire_File_Path__cField;
      set => this.broadband_Questionnaire_File_Path__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Broadband_Questionnaire_Sent_to_Vendor__c
    {
      get => this.broadband_Questionnaire_Sent_to_Vendor__cField;
      set => this.broadband_Questionnaire_Sent_to_Vendor__cField = value;
    }

    [XmlIgnore]
    public bool Broadband_Questionnaire_Sent_to_Vendor__cSpecified
    {
      get => this.broadband_Questionnaire_Sent_to_Vendor__cFieldSpecified;
      set => this.broadband_Questionnaire_Sent_to_Vendor__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Building_Lists_Posted_to_SharePoint__c
    {
      get => this.building_Lists_Posted_to_SharePoint__cField;
      set => this.building_Lists_Posted_to_SharePoint__cField = value;
    }

    [XmlIgnore]
    public bool Building_Lists_Posted_to_SharePoint__cSpecified
    {
      get => this.building_Lists_Posted_to_SharePoint__cFieldSpecified;
      set => this.building_Lists_Posted_to_SharePoint__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? CRM_Approvals_Received_Saved_to_LDrive__c
    {
      get => this.cRM_Approvals_Received_Saved_to_LDrive__cField;
      set => this.cRM_Approvals_Received_Saved_to_LDrive__cField = value;
    }

    [XmlIgnore]
    public bool CRM_Approvals_Received_Saved_to_LDrive__cSpecified
    {
      get => this.cRM_Approvals_Received_Saved_to_LDrive__cFieldSpecified;
      set => this.cRM_Approvals_Received_Saved_to_LDrive__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? CRM_Management_Approvals_Date__c
    {
      get => this.cRM_Management_Approvals_Date__cField;
      set => this.cRM_Management_Approvals_Date__cField = value;
    }

    [XmlIgnore]
    public bool CRM_Management_Approvals_Date__cSpecified
    {
      get => this.cRM_Management_Approvals_Date__cFieldSpecified;
      set => this.cRM_Management_Approvals_Date__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CRM__c
    {
      get => this.cRM__cField;
      set => this.cRM__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Cancel_Reason__c
    {
      get => this.cancel_Reason__cField;
      set => this.cancel_Reason__cField = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Contract_Effective_Date__c
    {
      get => this.contract_Effective_Date__cField;
      set => this.contract_Effective_Date__cField = value;
    }

    [XmlIgnore]
    public bool Contract_Effective_Date__cSpecified
    {
      get => this.contract_Effective_Date__cFieldSpecified;
      set => this.contract_Effective_Date__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Contract_Expiration_Date__c
    {
      get => this.contract_Expiration_Date__cField;
      set => this.contract_Expiration_Date__cField = value;
    }

    [XmlIgnore]
    public bool Contract_Expiration_Date__cSpecified
    {
      get => this.contract_Expiration_Date__cFieldSpecified;
      set => this.contract_Expiration_Date__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Contract_Summary_Created_Updated__c
    {
      get => this.contract_Summary_Created_Updated__cField;
      set => this.contract_Summary_Created_Updated__cField = value;
    }

    [XmlIgnore]
    public bool Contract_Summary_Created_Updated__cSpecified
    {
      get => this.contract_Summary_Created_Updated__cFieldSpecified;
      set => this.contract_Summary_Created_Updated__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Contract_Template_Amendment_Sent_to_Vend__c
    {
      get => this.contract_Template_Amendment_Sent_to_Vend__cField;
      set => this.contract_Template_Amendment_Sent_to_Vend__cField = value;
    }

    [XmlIgnore]
    public bool Contract_Template_Amendment_Sent_to_Vend__cSpecified
    {
      get => this.contract_Template_Amendment_Sent_to_Vend__cFieldSpecified;
      set => this.contract_Template_Amendment_Sent_to_Vend__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Contract_Term__c
    {
      get => this.contract_Term__cField;
      set => this.contract_Term__cField = value;
    }

    [XmlIgnore]
    public bool Contract_Term__cSpecified
    {
      get => this.contract_Term__cFieldSpecified;
      set => this.contract_Term__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Contract_Title__c
    {
      get => this.contract_Title__cField;
      set => this.contract_Title__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Contract_Type__c
    {
      get => this.contract_Type__cField;
      set => this.contract_Type__cField = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Date_Executed_by_Level_3__c
    {
      get => this.date_Executed_by_Level_3__cField;
      set => this.date_Executed_by_Level_3__cField = value;
    }

    [XmlIgnore]
    public bool Date_Executed_by_Level_3__cSpecified
    {
      get => this.date_Executed_by_Level_3__cFieldSpecified;
      set => this.date_Executed_by_Level_3__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Date_Executed_by_Vendor__c
    {
      get => this.date_Executed_by_Vendor__cField;
      set => this.date_Executed_by_Vendor__cField = value;
    }

    [XmlIgnore]
    public bool Date_Executed_by_Vendor__cSpecified
    {
      get => this.date_Executed_by_Vendor__cFieldSpecified;
      set => this.date_Executed_by_Vendor__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Date_Routed_for_Signature__c
    {
      get => this.date_Routed_for_Signature__cField;
      set => this.date_Routed_for_Signature__cField = value;
    }

    [XmlIgnore]
    public bool Date_Routed_for_Signature__cSpecified
    {
      get => this.date_Routed_for_Signature__cFieldSpecified;
      set => this.date_Routed_for_Signature__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Days_Since_Project_Start__c
    {
      get => this.days_Since_Project_Start__cField;
      set => this.days_Since_Project_Start__cField = value;
    }

    [XmlIgnore]
    public bool Days_Since_Project_Start__cSpecified
    {
      get => this.days_Since_Project_Start__cFieldSpecified;
      set => this.days_Since_Project_Start__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Days_Since_Status_Change__c
    {
      get => this.days_Since_Status_Change__cField;
      set => this.days_Since_Status_Change__cField = value;
    }

    [XmlIgnore]
    public bool Days_Since_Status_Change__cSpecified
    {
      get => this.days_Since_Status_Change__cFieldSpecified;
      set => this.days_Since_Status_Change__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Entity_Legacy_Company__c
    {
      get => this.entity_Legacy_Company__cField;
      set => this.entity_Legacy_Company__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Escalation_List_Posted_to_SharePoint__c
    {
      get => this.escalation_List_Posted_to_SharePoint__cField;
      set => this.escalation_List_Posted_to_SharePoint__cField = value;
    }

    [XmlIgnore]
    public bool Escalation_List_Posted_to_SharePoint__cSpecified
    {
      get => this.escalation_List_Posted_to_SharePoint__cFieldSpecified;
      set => this.escalation_List_Posted_to_SharePoint__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Evergreen_Contract__c
    {
      get => this.evergreen_Contract__cField;
      set => this.evergreen_Contract__cField = value;
    }

    [XmlIgnore]
    public bool Evergreen_Contract__cSpecified
    {
      get => this.evergreen_Contract__cFieldSpecified;
      set => this.evergreen_Contract__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Executed_Contract_Emailed_to_Documentum__c
    {
      get => this.executed_Contract_Emailed_to_Documentum__cField;
      set => this.executed_Contract_Emailed_to_Documentum__cField = value;
    }

    [XmlIgnore]
    public bool Executed_Contract_Emailed_to_Documentum__cSpecified
    {
      get => this.executed_Contract_Emailed_to_Documentum__cFieldSpecified;
      set => this.executed_Contract_Emailed_to_Documentum__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Executed_Contract_File_Path__c
    {
      get => this.executed_Contract_File_Path__cField;
      set => this.executed_Contract_File_Path__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Executed_Contract_Saved_to_LDrive__c
    {
      get => this.executed_Contract_Saved_to_LDrive__cField;
      set => this.executed_Contract_Saved_to_LDrive__cField = value;
    }

    [XmlIgnore]
    public bool Executed_Contract_Saved_to_LDrive__cSpecified
    {
      get => this.executed_Contract_Saved_to_LDrive__cFieldSpecified;
      set => this.executed_Contract_Saved_to_LDrive__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Executed_Original_Contract_sent_to_Legal__c
    {
      get => this.executed_Original_Contract_sent_to_Legal__cField;
      set => this.executed_Original_Contract_sent_to_Legal__cField = value;
    }

    [XmlIgnore]
    public bool Executed_Original_Contract_sent_to_Legal__cSpecified
    {
      get => this.executed_Original_Contract_sent_to_Legal__cFieldSpecified;
      set => this.executed_Original_Contract_sent_to_Legal__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Internal_Requesting_Org_Contact_Person__c
    {
      get => this.internal_Requesting_Org_Contact_Person__cField;
      set => this.internal_Requesting_Org_Contact_Person__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Internal_Requesting_Org_Contact_Phone__c
    {
      get => this.internal_Requesting_Org_Contact_Phone__cField;
      set => this.internal_Requesting_Org_Contact_Phone__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Internal_Requesting_Organization__c
    {
      get => this.internal_Requesting_Organization__cField;
      set => this.internal_Requesting_Organization__cField = value;
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
    public string Issues__c
    {
      get => this.issues__cField;
      set => this.issues__cField = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Legal_Approvals_Date__c
    {
      get => this.legal_Approvals_Date__cField;
      set => this.legal_Approvals_Date__cField = value;
    }

    [XmlIgnore]
    public bool Legal_Approvals_Date__cSpecified
    {
      get => this.legal_Approvals_Date__cFieldSpecified;
      set => this.legal_Approvals_Date__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Legal_Approvals_Rcvd_Saved_to_LDrive__c
    {
      get => this.legal_Approvals_Rcvd_Saved_to_LDrive__cField;
      set => this.legal_Approvals_Rcvd_Saved_to_LDrive__cField = value;
    }

    [XmlIgnore]
    public bool Legal_Approvals_Rcvd_Saved_to_LDrive__cSpecified
    {
      get => this.legal_Approvals_Rcvd_Saved_to_LDrive__cFieldSpecified;
      set => this.legal_Approvals_Rcvd_Saved_to_LDrive__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Manual_COG_Quoting__c
    {
      get => this.manual_COG_Quoting__cField;
      set => this.manual_COG_Quoting__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Markets__c
    {
      get => this.markets__cField;
      set => this.markets__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? NDA_Executed_Saved_to_Ldrive__c
    {
      get => this.nDA_Executed_Saved_to_Ldrive__cField;
      set => this.nDA_Executed_Saved_to_Ldrive__cField = value;
    }

    [XmlIgnore]
    public bool NDA_Executed_Saved_to_Ldrive__cSpecified
    {
      get => this.nDA_Executed_Saved_to_Ldrive__cFieldSpecified;
      set => this.nDA_Executed_Saved_to_Ldrive__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string NDA_File_Path__c
    {
      get => this.nDA_File_Path__cField;
      set => this.nDA_File_Path__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NORMALIZED_VENDOR_NAME__c
    {
      get => this.nORMALIZED_VENDOR_NAME__cField;
      set => this.nORMALIZED_VENDOR_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account NORMALIZED_VENDOR_NAME__r
    {
      get => this.nORMALIZED_VENDOR_NAME__rField;
      set => this.nORMALIZED_VENDOR_NAME__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NVR_Descrip_Priority_Reason_Timeframe__c
    {
      get => this.nVR_Descrip_Priority_Reason_Timeframe__cField;
      set => this.nVR_Descrip_Priority_Reason_Timeframe__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? NetEx_Team_Notified__c
    {
      get => this.netEx_Team_Notified__cField;
      set => this.netEx_Team_Notified__cField = value;
    }

    [XmlIgnore]
    public bool NetEx_Team_Notified__cSpecified
    {
      get => this.netEx_Team_Notified__cFieldSpecified;
      set => this.netEx_Team_Notified__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? New_Vendor_Request_Submit_Date__c
    {
      get => this.new_Vendor_Request_Submit_Date__cField;
      set => this.new_Vendor_Request_Submit_Date__cField = value;
    }

    [XmlIgnore]
    public bool New_Vendor_Request_Submit_Date__cSpecified
    {
      get => this.new_Vendor_Request_Submit_Date__cFieldSpecified;
      set => this.new_Vendor_Request_Submit_Date__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string New_Vendor_Risk_Assessment_Completed__c
    {
      get => this.new_Vendor_Risk_Assessment_Completed__cField;
      set => this.new_Vendor_Risk_Assessment_Completed__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? New_Vendor_Set_Up_Packet_Sent_to_Vendor__c
    {
      get => this.new_Vendor_Set_Up_Packet_Sent_to_Vendor__cField;
      set => this.new_Vendor_Set_Up_Packet_Sent_to_Vendor__cField = value;
    }

    [XmlIgnore]
    public bool New_Vendor_Set_Up_Packet_Sent_to_Vendor__cSpecified
    {
      get => this.new_Vendor_Set_Up_Packet_Sent_to_Vendor__cFieldSpecified;
      set => this.new_Vendor_Set_Up_Packet_Sent_to_Vendor__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? New_Vendor_Set_Up_Request_to_Vndr_Mngmt__c
    {
      get => this.new_Vendor_Set_Up_Request_to_Vndr_Mngmt__cField;
      set => this.new_Vendor_Set_Up_Request_to_Vndr_Mngmt__cField = value;
    }

    [XmlIgnore]
    public bool New_Vendor_Set_Up_Request_to_Vndr_Mngmt__cSpecified
    {
      get => this.new_Vendor_Set_Up_Request_to_Vndr_Mngmt__cFieldSpecified;
      set => this.new_Vendor_Set_Up_Request_to_Vndr_Mngmt__cFieldSpecified = value;
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
    public string Notes_Comments__c
    {
      get => this.notes_Comments__cField;
      set => this.notes_Comments__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Obtained_Vendor_Mngmt_Billing_Forms_from__c
    {
      get => this.obtained_Vendor_Mngmt_Billing_Forms_from__cField;
      set => this.obtained_Vendor_Mngmt_Billing_Forms_from__cField = value;
    }

    [XmlIgnore]
    public bool Obtained_Vendor_Mngmt_Billing_Forms_from__cSpecified
    {
      get => this.obtained_Vendor_Mngmt_Billing_Forms_from__cFieldSpecified;
      set => this.obtained_Vendor_Mngmt_Billing_Forms_from__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Order_Form_Posted_to_SharePoint__c
    {
      get => this.order_Form_Posted_to_SharePoint__cField;
      set => this.order_Form_Posted_to_SharePoint__cField = value;
    }

    [XmlIgnore]
    public bool Order_Form_Posted_to_SharePoint__cSpecified
    {
      get => this.order_Form_Posted_to_SharePoint__cFieldSpecified;
      set => this.order_Form_Posted_to_SharePoint__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Order_Form_eBonding_Process_Posted_to_Sh__c
    {
      get => this.order_Form_eBonding_Process_Posted_to_Sh__cField;
      set => this.order_Form_eBonding_Process_Posted_to_Sh__cField = value;
    }

    [XmlIgnore]
    public bool Order_Form_eBonding_Process_Posted_to_Sh__cSpecified
    {
      get => this.order_Form_eBonding_Process_Posted_to_Sh__cFieldSpecified;
      set => this.order_Form_eBonding_Process_Posted_to_Sh__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Order_Intervals_DLR__c
    {
      get => this.order_Intervals_DLR__cField;
      set => this.order_Intervals_DLR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Other_Requesting_Organization__c
    {
      get => this.other_Requesting_Organization__cField;
      set => this.other_Requesting_Organization__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Other_Service_Type__c
    {
      get => this.other_Service_Type__cField;
      set => this.other_Service_Type__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name Owner
    {
      get => this.ownerField;
      set => this.ownerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OwnerId
    {
      get => this.ownerIdField;
      set => this.ownerIdField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? PIP_Completed_Saved_to_LDrive__c
    {
      get => this.pIP_Completed_Saved_to_LDrive__cField;
      set => this.pIP_Completed_Saved_to_LDrive__cField = value;
    }

    [XmlIgnore]
    public bool PIP_Completed_Saved_to_LDrive__cSpecified
    {
      get => this.pIP_Completed_Saved_to_LDrive__cFieldSpecified;
      set => this.pIP_Completed_Saved_to_LDrive__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Perform_Pricing_Cost_Analysis__c
    {
      get => this.perform_Pricing_Cost_Analysis__cField;
      set => this.perform_Pricing_Cost_Analysis__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Potential_Buildings__c
    {
      get => this.potential_Buildings__cField;
      set => this.potential_Buildings__cField = value;
    }

    [XmlIgnore]
    public bool Potential_Buildings__cSpecified
    {
      get => this.potential_Buildings__cFieldSpecified;
      set => this.potential_Buildings__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Priority__c
    {
      get => this.priority__cField;
      set => this.priority__cField = value;
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
    public double? Project_Age__c
    {
      get => this.project_Age__cField;
      set => this.project_Age__cField = value;
    }

    [XmlIgnore]
    public bool Project_Age__cSpecified
    {
      get => this.project_Age__cFieldSpecified;
      set => this.project_Age__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Project_Contract_Description__c
    {
      get => this.project_Contract_Description__cField;
      set => this.project_Contract_Description__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Project_Start_Date__c
    {
      get => this.project_Start_Date__cField;
      set => this.project_Start_Date__cField = value;
    }

    [XmlIgnore]
    public bool Project_Start_Date__cSpecified
    {
      get => this.project_Start_Date__cFieldSpecified;
      set => this.project_Start_Date__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Project_Status_Change_Date__c
    {
      get => this.project_Status_Change_Date__cField;
      set => this.project_Status_Change_Date__cField = value;
    }

    [XmlIgnore]
    public bool Project_Status_Change_Date__cSpecified
    {
      get => this.project_Status_Change_Date__cFieldSpecified;
      set => this.project_Status_Change_Date__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Project_Status__c
    {
      get => this.project_Status__cField;
      set => this.project_Status__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Project_Title__c
    {
      get => this.project_Title__cField;
      set => this.project_Title__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Provider_Info_Packet_File_Path__c
    {
      get => this.provider_Info_Packet_File_Path__cField;
      set => this.provider_Info_Packet_File_Path__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Provider_Info_Packet_PIP_Sent_to_Vendor__c
    {
      get => this.provider_Info_Packet_PIP_Sent_to_Vendor__cField;
      set => this.provider_Info_Packet_PIP_Sent_to_Vendor__cField = value;
    }

    [XmlIgnore]
    public bool Provider_Info_Packet_PIP_Sent_to_Vendor__cSpecified
    {
      get => this.provider_Info_Packet_PIP_Sent_to_Vendor__cFieldSpecified;
      set => this.provider_Info_Packet_PIP_Sent_to_Vendor__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Provisioning_Team_Notified__c
    {
      get => this.provisioning_Team_Notified__cField;
      set => this.provisioning_Team_Notified__cField = value;
    }

    [XmlIgnore]
    public bool Provisioning_Team_Notified__cSpecified
    {
      get => this.provisioning_Team_Notified__cFieldSpecified;
      set => this.provisioning_Team_Notified__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Service_Types__c
    {
      get => this.service_Types__cField;
      set => this.service_Types__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Standard_Installation_Intervals__c
    {
      get => this.standard_Installation_Intervals__cField;
      set => this.standard_Installation_Intervals__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Submitted_By__c
    {
      get => this.submitted_By__cField;
      set => this.submitted_By__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Summary_of_Price_Cost_Analysis__c
    {
      get => this.summary_of_Price_Cost_Analysis__cField;
      set => this.summary_of_Price_Cost_Analysis__cField = value;
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
    public string Template_Paper__c
    {
      get => this.template_Paper__cField;
      set => this.template_Paper__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Update_VTA_Tool_Notify_Drew_Berke__c
    {
      get => this.update_VTA_Tool_Notify_Drew_Berke__cField;
      set => this.update_VTA_Tool_Notify_Drew_Berke__cField = value;
    }

    [XmlIgnore]
    public bool Update_VTA_Tool_Notify_Drew_Berke__cSpecified
    {
      get => this.update_VTA_Tool_Notify_Drew_Berke__cFieldSpecified;
      set => this.update_VTA_Tool_Notify_Drew_Berke__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR__c
    {
      get => this.vENDOR__cField;
      set => this.vENDOR__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Vendor_Comm_Ops_Team_Notified__c
    {
      get => this.vendor_Comm_Ops_Team_Notified__cField;
      set => this.vendor_Comm_Ops_Team_Notified__cField = value;
    }

    [XmlIgnore]
    public bool Vendor_Comm_Ops_Team_Notified__cSpecified
    {
      get => this.vendor_Comm_Ops_Team_Notified__cFieldSpecified;
      set => this.vendor_Comm_Ops_Team_Notified__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor_Contact_Email__c
    {
      get => this.vendor_Contact_Email__cField;
      set => this.vendor_Contact_Email__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor_Contact_Name__c
    {
      get => this.vendor_Contact_Name__cField;
      set => this.vendor_Contact_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor_Contact_Phone__c
    {
      get => this.vendor_Contact_Phone__cField;
      set => this.vendor_Contact_Phone__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor_Market_Footprint__c
    {
      get => this.vendor_Market_Footprint__cField;
      set => this.vendor_Market_Footprint__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor_Normalized_Name_Mirror__c
    {
      get => this.vendor_Normalized_Name_Mirror__cField;
      set => this.vendor_Normalized_Name_Mirror__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Vendor_Onboarding_Team_Notified__c
    {
      get => this.vendor_Onboarding_Team_Notified__cField;
      set => this.vendor_Onboarding_Team_Notified__cField = value;
    }

    [XmlIgnore]
    public bool Vendor_Onboarding_Team_Notified__cSpecified
    {
      get => this.vendor_Onboarding_Team_Notified__cFieldSpecified;
      set => this.vendor_Onboarding_Team_Notified__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor_Website__c
    {
      get => this.vendor_Website__cField;
      set => this.vendor_Website__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string test_mirror_field__c
    {
      get => this.test_mirror_field__cField;
      set => this.test_mirror_field__cField = value;
    }
  }
}
