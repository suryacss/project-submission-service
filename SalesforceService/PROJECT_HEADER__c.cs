// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PROJECT_HEADER__c
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class PROJECT_HEADER__c : sObject
  {
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string cUT_LEVEL_STATE__cField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private double? created_Days_Ago__cField;
    private bool created_Days_Ago__cFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private QueryResult eCCKTs__rField;
    private string eVOLUTION_ID__cField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private string groom_Project_Status__cField;
    private string grooms_Order_Number__cField;
    private QueryResult historiesField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string l3_GATEWAY_ERROR__cField;
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
    private double? maxSubGo__cField;
    private bool maxSubGo__cFieldSpecified;
    private DateTime? minimumSubProjectSubmitDate__cField;
    private bool minimumSubProjectSubmitDate__cFieldSpecified;
    private double? nON_PLANNING_MRC_SAVINGS__cField;
    private bool nON_PLANNING_MRC_SAVINGS__cFieldSpecified;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private double? number_of_Sub_Projects__cField;
    private bool number_of_Sub_Projects__cFieldSpecified;
    private QueryResult openActivitiesField;
    private QueryResult opportunities__rField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private double? pAYBACK_IN_MONTHS__cField;
    private bool pAYBACK_IN_MONTHS__cFieldSpecified;
    private string pLANNER__cField;
    private User pLANNER__rField;
    private DateTime? pROJECT_DUE_DATE__cField;
    private bool pROJECT_DUE_DATE__cFieldSpecified;
    private DateTime? pROJECT_INITIAL_SUBMIT_DATE__cField;
    private bool pROJECT_INITIAL_SUBMIT_DATE__cFieldSpecified;
    private DateTime? pROJECT_INITIATION_DATE__cField;
    private bool pROJECT_INITIATION_DATE__cFieldSpecified;
    private string pROJECT_SCOPE__cField;
    private string pROJECT_TYPE__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string program_Name__cField;
    private double? project_ECCKT_Count__cField;
    private bool project_ECCKT_Count__cFieldSpecified;
    private string project_ID__cField;
    private QueryResult project_Items__rField;
    private DateTime? project_Submit_Date__cField;
    private bool project_Submit_Date__cFieldSpecified;
    private string rFA_ID_FOR_TL_APPROVAL__cField;
    private string rFA_INSTALL_NUMBER__cField;
    private QueryResult recordAssociatedGroupsField;
    private bool? sUPPRESS_SUBMISSION__cField;
    private bool sUPPRESS_SUBMISSION__cFieldSpecified;
    private QueryResult subProjects__rField;
    private double? sub_Project_Status__cField;
    private bool sub_Project_Status__cFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private double? tOTAL_NRC__cField;
    private bool tOTAL_NRC__cFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private double? total_MRC_Existing__cField;
    private bool total_MRC_Existing__cFieldSpecified;
    private double? total_MRC_New__cField;
    private bool total_MRC_New__cFieldSpecified;
    private double? total_MRC_Savings__cField;
    private bool total_MRC_Savings__cFieldSpecified;
    private double? total_New_NRC__cField;
    private bool total_New_NRC__cFieldSpecified;
    private double? total_Term_Liability__cField;
    private bool total_Term_Liability__cFieldSpecified;
    private UserRecordAccess userRecordAccessField;

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
    public string CUT_LEVEL_STATE__c
    {
      get => this.cUT_LEVEL_STATE__cField;
      set => this.cUT_LEVEL_STATE__cField = value;
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
    public double? Created_Days_Ago__c
    {
      get => this.created_Days_Ago__cField;
      set => this.created_Days_Ago__cField = value;
    }

    [XmlIgnore]
    public bool Created_Days_Ago__cSpecified
    {
      get => this.created_Days_Ago__cFieldSpecified;
      set => this.created_Days_Ago__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTs__r
    {
      get => this.eCCKTs__rField;
      set => this.eCCKTs__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EVOLUTION_ID__c
    {
      get => this.eVOLUTION_ID__cField;
      set => this.eVOLUTION_ID__cField = value;
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
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Groom_Project_Status__c
    {
      get => this.groom_Project_Status__cField;
      set => this.groom_Project_Status__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Grooms_Order_Number__c
    {
      get => this.grooms_Order_Number__cField;
      set => this.grooms_Order_Number__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
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
    public string L3_GATEWAY_ERROR__c
    {
      get => this.l3_GATEWAY_ERROR__cField;
      set => this.l3_GATEWAY_ERROR__cField = value;
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
    public double? MaxSubGo__c
    {
      get => this.maxSubGo__cField;
      set => this.maxSubGo__cField = value;
    }

    [XmlIgnore]
    public bool MaxSubGo__cSpecified
    {
      get => this.maxSubGo__cFieldSpecified;
      set => this.maxSubGo__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? MinimumSubProjectSubmitDate__c
    {
      get => this.minimumSubProjectSubmitDate__cField;
      set => this.minimumSubProjectSubmitDate__cField = value;
    }

    [XmlIgnore]
    public bool MinimumSubProjectSubmitDate__cSpecified
    {
      get => this.minimumSubProjectSubmitDate__cFieldSpecified;
      set => this.minimumSubProjectSubmitDate__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NON_PLANNING_MRC_SAVINGS__c
    {
      get => this.nON_PLANNING_MRC_SAVINGS__cField;
      set => this.nON_PLANNING_MRC_SAVINGS__cField = value;
    }

    [XmlIgnore]
    public bool NON_PLANNING_MRC_SAVINGS__cSpecified
    {
      get => this.nON_PLANNING_MRC_SAVINGS__cFieldSpecified;
      set => this.nON_PLANNING_MRC_SAVINGS__cFieldSpecified = value;
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
    public double? Number_of_Sub_Projects__c
    {
      get => this.number_of_Sub_Projects__cField;
      set => this.number_of_Sub_Projects__cField = value;
    }

    [XmlIgnore]
    public bool Number_of_Sub_Projects__cSpecified
    {
      get => this.number_of_Sub_Projects__cFieldSpecified;
      set => this.number_of_Sub_Projects__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Opportunities__r
    {
      get => this.opportunities__rField;
      set => this.opportunities__rField = value;
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

    [XmlElement(IsNullable = true)]
    public double? PAYBACK_IN_MONTHS__c
    {
      get => this.pAYBACK_IN_MONTHS__cField;
      set => this.pAYBACK_IN_MONTHS__cField = value;
    }

    [XmlIgnore]
    public bool PAYBACK_IN_MONTHS__cSpecified
    {
      get => this.pAYBACK_IN_MONTHS__cFieldSpecified;
      set => this.pAYBACK_IN_MONTHS__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PLANNER__c
    {
      get => this.pLANNER__cField;
      set => this.pLANNER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public User PLANNER__r
    {
      get => this.pLANNER__rField;
      set => this.pLANNER__rField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? PROJECT_DUE_DATE__c
    {
      get => this.pROJECT_DUE_DATE__cField;
      set => this.pROJECT_DUE_DATE__cField = value;
    }

    [XmlIgnore]
    public bool PROJECT_DUE_DATE__cSpecified
    {
      get => this.pROJECT_DUE_DATE__cFieldSpecified;
      set => this.pROJECT_DUE_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? PROJECT_INITIAL_SUBMIT_DATE__c
    {
      get => this.pROJECT_INITIAL_SUBMIT_DATE__cField;
      set => this.pROJECT_INITIAL_SUBMIT_DATE__cField = value;
    }

    [XmlIgnore]
    public bool PROJECT_INITIAL_SUBMIT_DATE__cSpecified
    {
      get => this.pROJECT_INITIAL_SUBMIT_DATE__cFieldSpecified;
      set => this.pROJECT_INITIAL_SUBMIT_DATE__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? PROJECT_INITIATION_DATE__c
    {
      get => this.pROJECT_INITIATION_DATE__cField;
      set => this.pROJECT_INITIATION_DATE__cField = value;
    }

    [XmlIgnore]
    public bool PROJECT_INITIATION_DATE__cSpecified
    {
      get => this.pROJECT_INITIATION_DATE__cFieldSpecified;
      set => this.pROJECT_INITIATION_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECT_SCOPE__c
    {
      get => this.pROJECT_SCOPE__cField;
      set => this.pROJECT_SCOPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECT_TYPE__c
    {
      get => this.pROJECT_TYPE__cField;
      set => this.pROJECT_TYPE__cField = value;
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
    public string Program_Name__c
    {
      get => this.program_Name__cField;
      set => this.program_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Project_ECCKT_Count__c
    {
      get => this.project_ECCKT_Count__cField;
      set => this.project_ECCKT_Count__cField = value;
    }

    [XmlIgnore]
    public bool Project_ECCKT_Count__cSpecified
    {
      get => this.project_ECCKT_Count__cFieldSpecified;
      set => this.project_ECCKT_Count__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Project_ID__c
    {
      get => this.project_ID__cField;
      set => this.project_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Project_Items__r
    {
      get => this.project_Items__rField;
      set => this.project_Items__rField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Project_Submit_Date__c
    {
      get => this.project_Submit_Date__cField;
      set => this.project_Submit_Date__cField = value;
    }

    [XmlIgnore]
    public bool Project_Submit_Date__cSpecified
    {
      get => this.project_Submit_Date__cFieldSpecified;
      set => this.project_Submit_Date__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFA_ID_FOR_TL_APPROVAL__c
    {
      get => this.rFA_ID_FOR_TL_APPROVAL__cField;
      set => this.rFA_ID_FOR_TL_APPROVAL__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFA_INSTALL_NUMBER__c
    {
      get => this.rFA_INSTALL_NUMBER__cField;
      set => this.rFA_INSTALL_NUMBER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? SUPPRESS_SUBMISSION__c
    {
      get => this.sUPPRESS_SUBMISSION__cField;
      set => this.sUPPRESS_SUBMISSION__cField = value;
    }

    [XmlIgnore]
    public bool SUPPRESS_SUBMISSION__cSpecified
    {
      get => this.sUPPRESS_SUBMISSION__cFieldSpecified;
      set => this.sUPPRESS_SUBMISSION__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SubProjects__r
    {
      get => this.subProjects__rField;
      set => this.subProjects__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Sub_Project_Status__c
    {
      get => this.sub_Project_Status__cField;
      set => this.sub_Project_Status__cField = value;
    }

    [XmlIgnore]
    public bool Sub_Project_Status__cSpecified
    {
      get => this.sub_Project_Status__cFieldSpecified;
      set => this.sub_Project_Status__cFieldSpecified = value;
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
    public double? TOTAL_NRC__c
    {
      get => this.tOTAL_NRC__cField;
      set => this.tOTAL_NRC__cField = value;
    }

    [XmlIgnore]
    public bool TOTAL_NRC__cSpecified
    {
      get => this.tOTAL_NRC__cFieldSpecified;
      set => this.tOTAL_NRC__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Tasks
    {
      get => this.tasksField;
      set => this.tasksField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Total_MRC_Existing__c
    {
      get => this.total_MRC_Existing__cField;
      set => this.total_MRC_Existing__cField = value;
    }

    [XmlIgnore]
    public bool Total_MRC_Existing__cSpecified
    {
      get => this.total_MRC_Existing__cFieldSpecified;
      set => this.total_MRC_Existing__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Total_MRC_New__c
    {
      get => this.total_MRC_New__cField;
      set => this.total_MRC_New__cField = value;
    }

    [XmlIgnore]
    public bool Total_MRC_New__cSpecified
    {
      get => this.total_MRC_New__cFieldSpecified;
      set => this.total_MRC_New__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Total_MRC_Savings__c
    {
      get => this.total_MRC_Savings__cField;
      set => this.total_MRC_Savings__cField = value;
    }

    [XmlIgnore]
    public bool Total_MRC_Savings__cSpecified
    {
      get => this.total_MRC_Savings__cFieldSpecified;
      set => this.total_MRC_Savings__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Total_New_NRC__c
    {
      get => this.total_New_NRC__cField;
      set => this.total_New_NRC__cField = value;
    }

    [XmlIgnore]
    public bool Total_New_NRC__cSpecified
    {
      get => this.total_New_NRC__cFieldSpecified;
      set => this.total_New_NRC__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Total_Term_Liability__c
    {
      get => this.total_Term_Liability__cField;
      set => this.total_Term_Liability__cField = value;
    }

    [XmlIgnore]
    public bool Total_Term_Liability__cSpecified
    {
      get => this.total_Term_Liability__cFieldSpecified;
      set => this.total_Term_Liability__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
