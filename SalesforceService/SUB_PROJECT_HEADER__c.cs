// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SUB_PROJECT_HEADER__c
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class SUB_PROJECT_HEADER__c : sObject
  {
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private double? cREATED_DAYS_AGO__cField;
    private bool cREATED_DAYS_AGO__cFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private QueryResult emailsField;
    private QueryResult feedSubscriptionsForEntityField;
    private string gROOMS_ORDER_NUMBER__cField;
    private string gROOM_SUBMISSION_DETAIL__cField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private double? numeric_GOID__cField;
    private bool numeric_GOID__cFieldSpecified;
    private double? numeric_Status__cField;
    private bool numeric_Status__cFieldSpecified;
    private string pLANNER__cField;
    private User pLANNER__rField;
    private string pROJECT_MANAGER__cField;
    private User pROJECT_MANAGER__rField;
    private string pROJECT__cField;
    private PROJECT_HEADER__c pROJECT__rField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult project_Items__rField;
    private QueryResult recordAssociatedGroupsField;
    private string sUB_PROJECT_CUT_LEVEL_STATE__cField;
    private DateTime? sUB_PROJECT_DUE_DATE__cField;
    private bool sUB_PROJECT_DUE_DATE__cFieldSpecified;
    private DateTime? sUB_PROJECT_INITIAL_SUBMIT_DATE__cField;
    private bool sUB_PROJECT_INITIAL_SUBMIT_DATE__cFieldSpecified;
    private string sUB_PROJECT_NAME__cField;
    private string sUB_PROJECT_OWNER__cField;
    private User sUB_PROJECT_OWNER__rField;
    private string sUB_PROJECT_PHASE__cField;
    private string sUB_PROJECT_SCOPE__cField;
    private string sUB_PROJECT_STATUS__cField;
    private DateTime? sUB_PROJECT_SUBMIT_DATE__cField;
    private bool sUB_PROJECT_SUBMIT_DATE__cFieldSpecified;
    private string sUB_PROJECT_TYPE__cField;
    private string sUB_TYPE__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult topicAssignmentsField;
    private double? total_MRC_Savings__cField;
    private bool total_MRC_Savings__cFieldSpecified;
    private UserRecordAccess userRecordAccessField;
    private string wORKFLOW_TYPE__cField;

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
    public double? CREATED_DAYS_AGO__c
    {
      get => this.cREATED_DAYS_AGO__cField;
      set => this.cREATED_DAYS_AGO__cField = value;
    }

    [XmlIgnore]
    public bool CREATED_DAYS_AGO__cSpecified
    {
      get => this.cREATED_DAYS_AGO__cFieldSpecified;
      set => this.cREATED_DAYS_AGO__cFieldSpecified = value;
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

    [XmlElement(IsNullable = true)]
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GROOMS_ORDER_NUMBER__c
    {
      get => this.gROOMS_ORDER_NUMBER__cField;
      set => this.gROOMS_ORDER_NUMBER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GROOM_SUBMISSION_DETAIL__c
    {
      get => this.gROOM_SUBMISSION_DETAIL__cField;
      set => this.gROOM_SUBMISSION_DETAIL__cField = value;
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
    public double? Numeric_GOID__c
    {
      get => this.numeric_GOID__cField;
      set => this.numeric_GOID__cField = value;
    }

    [XmlIgnore]
    public bool Numeric_GOID__cSpecified
    {
      get => this.numeric_GOID__cFieldSpecified;
      set => this.numeric_GOID__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Numeric_Status__c
    {
      get => this.numeric_Status__cField;
      set => this.numeric_Status__cField = value;
    }

    [XmlIgnore]
    public bool Numeric_Status__cSpecified
    {
      get => this.numeric_Status__cFieldSpecified;
      set => this.numeric_Status__cFieldSpecified = value;
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

    [XmlElement(IsNullable = true)]
    public string PROJECT_MANAGER__c
    {
      get => this.pROJECT_MANAGER__cField;
      set => this.pROJECT_MANAGER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public User PROJECT_MANAGER__r
    {
      get => this.pROJECT_MANAGER__rField;
      set => this.pROJECT_MANAGER__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECT__c
    {
      get => this.pROJECT__cField;
      set => this.pROJECT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public PROJECT_HEADER__c PROJECT__r
    {
      get => this.pROJECT__rField;
      set => this.pROJECT__rField = value;
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
    public QueryResult Project_Items__r
    {
      get => this.project_Items__rField;
      set => this.project_Items__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUB_PROJECT_CUT_LEVEL_STATE__c
    {
      get => this.sUB_PROJECT_CUT_LEVEL_STATE__cField;
      set => this.sUB_PROJECT_CUT_LEVEL_STATE__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? SUB_PROJECT_DUE_DATE__c
    {
      get => this.sUB_PROJECT_DUE_DATE__cField;
      set => this.sUB_PROJECT_DUE_DATE__cField = value;
    }

    [XmlIgnore]
    public bool SUB_PROJECT_DUE_DATE__cSpecified
    {
      get => this.sUB_PROJECT_DUE_DATE__cFieldSpecified;
      set => this.sUB_PROJECT_DUE_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SUB_PROJECT_INITIAL_SUBMIT_DATE__c
    {
      get => this.sUB_PROJECT_INITIAL_SUBMIT_DATE__cField;
      set => this.sUB_PROJECT_INITIAL_SUBMIT_DATE__cField = value;
    }

    [XmlIgnore]
    public bool SUB_PROJECT_INITIAL_SUBMIT_DATE__cSpecified
    {
      get => this.sUB_PROJECT_INITIAL_SUBMIT_DATE__cFieldSpecified;
      set => this.sUB_PROJECT_INITIAL_SUBMIT_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUB_PROJECT_NAME__c
    {
      get => this.sUB_PROJECT_NAME__cField;
      set => this.sUB_PROJECT_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUB_PROJECT_OWNER__c
    {
      get => this.sUB_PROJECT_OWNER__cField;
      set => this.sUB_PROJECT_OWNER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public User SUB_PROJECT_OWNER__r
    {
      get => this.sUB_PROJECT_OWNER__rField;
      set => this.sUB_PROJECT_OWNER__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUB_PROJECT_PHASE__c
    {
      get => this.sUB_PROJECT_PHASE__cField;
      set => this.sUB_PROJECT_PHASE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUB_PROJECT_SCOPE__c
    {
      get => this.sUB_PROJECT_SCOPE__cField;
      set => this.sUB_PROJECT_SCOPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUB_PROJECT_STATUS__c
    {
      get => this.sUB_PROJECT_STATUS__cField;
      set => this.sUB_PROJECT_STATUS__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? SUB_PROJECT_SUBMIT_DATE__c
    {
      get => this.sUB_PROJECT_SUBMIT_DATE__cField;
      set => this.sUB_PROJECT_SUBMIT_DATE__cField = value;
    }

    [XmlIgnore]
    public bool SUB_PROJECT_SUBMIT_DATE__cSpecified
    {
      get => this.sUB_PROJECT_SUBMIT_DATE__cFieldSpecified;
      set => this.sUB_PROJECT_SUBMIT_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUB_PROJECT_TYPE__c
    {
      get => this.sUB_PROJECT_TYPE__cField;
      set => this.sUB_PROJECT_TYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUB_TYPE__c
    {
      get => this.sUB_TYPE__cField;
      set => this.sUB_TYPE__cField = value;
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
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
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
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string WORKFLOW_TYPE__c
    {
      get => this.wORKFLOW_TYPE__cField;
      set => this.wORKFLOW_TYPE__cField = value;
    }
  }
}
