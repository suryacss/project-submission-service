// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ACC_CAR_BUYING_PLAN__c
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
  public class ACC_CAR_BUYING_PLAN__c : sObject
  {
    private string aCTIVE_IND__cField;
    private string access_Carrier_Vendor__cField;
    private Account access_Carrier_Vendor__rField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bUYING_PLAN_DESCRIPTION__cField;
    private string bUYING_PLAN_ID__cField;
    private DateTime? bUYING_PLAN_TERM_END_DATE__cField;
    private bool bUYING_PLAN_TERM_END_DATE__cFieldSpecified;
    private double? bUYING_PLAN_TERM_LENGTH__cField;
    private bool bUYING_PLAN_TERM_LENGTH__cFieldSpecified;
    private DateTime? bUYING_PLAN_TERM_START_DATE__cField;
    private bool bUYING_PLAN_TERM_START_DATE__cFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private DateTime? dEACT_DATE__cField;
    private bool dEACT_DATE__cFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private QueryResult eCCKTS__rField;
    private QueryResult eCCKT_SUPPLEMENTAL__rField;
    private DateTime? eFFECT_DATE__cField;
    private bool eFFECT_DATE__cFieldSpecified;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult historiesField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private DateTime? lAST_MODIFY_DATE__cField;
    private bool lAST_MODIFY_DATE__cFieldSpecified;
    private string lAST_MODIFY_REQUEST_BY__cField;
    private string lAST_MODIFY_USERID__cField;
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
    private string nEG_COMPANY_NAME__cField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private bool? oDM_TERM_DATE_AUTO_POPULATION__cField;
    private bool oDM_TERM_DATE_AUTO_POPULATION__cFieldSpecified;
    private QueryResult openActivitiesField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tLE_Rules__rField;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private QueryResult uSOC_SUMMARIES__rField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public string ACTIVE_IND__c
    {
      get => this.aCTIVE_IND__cField;
      set => this.aCTIVE_IND__cField = value;
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
    public string BUYING_PLAN_DESCRIPTION__c
    {
      get => this.bUYING_PLAN_DESCRIPTION__cField;
      set => this.bUYING_PLAN_DESCRIPTION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BUYING_PLAN_ID__c
    {
      get => this.bUYING_PLAN_ID__cField;
      set => this.bUYING_PLAN_ID__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? BUYING_PLAN_TERM_END_DATE__c
    {
      get => this.bUYING_PLAN_TERM_END_DATE__cField;
      set => this.bUYING_PLAN_TERM_END_DATE__cField = value;
    }

    [XmlIgnore]
    public bool BUYING_PLAN_TERM_END_DATE__cSpecified
    {
      get => this.bUYING_PLAN_TERM_END_DATE__cFieldSpecified;
      set => this.bUYING_PLAN_TERM_END_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? BUYING_PLAN_TERM_LENGTH__c
    {
      get => this.bUYING_PLAN_TERM_LENGTH__cField;
      set => this.bUYING_PLAN_TERM_LENGTH__cField = value;
    }

    [XmlIgnore]
    public bool BUYING_PLAN_TERM_LENGTH__cSpecified
    {
      get => this.bUYING_PLAN_TERM_LENGTH__cFieldSpecified;
      set => this.bUYING_PLAN_TERM_LENGTH__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? BUYING_PLAN_TERM_START_DATE__c
    {
      get => this.bUYING_PLAN_TERM_START_DATE__cField;
      set => this.bUYING_PLAN_TERM_START_DATE__cField = value;
    }

    [XmlIgnore]
    public bool BUYING_PLAN_TERM_START_DATE__cSpecified
    {
      get => this.bUYING_PLAN_TERM_START_DATE__cFieldSpecified;
      set => this.bUYING_PLAN_TERM_START_DATE__cFieldSpecified = value;
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
    public DateTime? DEACT_DATE__c
    {
      get => this.dEACT_DATE__cField;
      set => this.dEACT_DATE__cField = value;
    }

    [XmlIgnore]
    public bool DEACT_DATE__cSpecified
    {
      get => this.dEACT_DATE__cFieldSpecified;
      set => this.dEACT_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS__r
    {
      get => this.eCCKTS__rField;
      set => this.eCCKTS__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKT_SUPPLEMENTAL__r
    {
      get => this.eCCKT_SUPPLEMENTAL__rField;
      set => this.eCCKT_SUPPLEMENTAL__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? EFFECT_DATE__c
    {
      get => this.eFFECT_DATE__cField;
      set => this.eFFECT_DATE__cField = value;
    }

    [XmlIgnore]
    public bool EFFECT_DATE__cSpecified
    {
      get => this.eFFECT_DATE__cFieldSpecified;
      set => this.eFFECT_DATE__cFieldSpecified = value;
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
    public string NEG_COMPANY_NAME__c
    {
      get => this.nEG_COMPANY_NAME__cField;
      set => this.nEG_COMPANY_NAME__cField = value;
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
    public bool? ODM_TERM_DATE_AUTO_POPULATION__c
    {
      get => this.oDM_TERM_DATE_AUTO_POPULATION__cField;
      set => this.oDM_TERM_DATE_AUTO_POPULATION__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_DATE_AUTO_POPULATION__cSpecified
    {
      get => this.oDM_TERM_DATE_AUTO_POPULATION__cFieldSpecified;
      set => this.oDM_TERM_DATE_AUTO_POPULATION__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
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
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
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
    public QueryResult TLE_Rules__r
    {
      get => this.tLE_Rules__rField;
      set => this.tLE_Rules__rField = value;
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
    public QueryResult USOC_SUMMARIES__r
    {
      get => this.uSOC_SUMMARIES__rField;
      set => this.uSOC_SUMMARIES__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
