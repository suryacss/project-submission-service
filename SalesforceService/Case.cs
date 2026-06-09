// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Case
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class Case : sObject
  {
    private Account accountField;
    private string accountIdField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private QueryResult caseCommentsField;
    private QueryResult caseContactRolesField;
    private string caseNumberField;
    private QueryResult caseSolutionsField;
    private QueryResult casesField;
    private DateTime? closedDateField;
    private bool closedDateFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private Contact contactField;
    private string contactEmailField;
    private string contactFaxField;
    private string contactIdField;
    private string contactMobileField;
    private string contactPhoneField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private QueryResult emailMessagesField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private QueryResult historiesField;
    private bool? isClosedField;
    private bool isClosedFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isEscalatedField;
    private bool isEscalatedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private QueryResult openActivitiesField;
    private string originField;
    private Name ownerField;
    private string ownerIdField;
    private Case parentField;
    private string parentIdField;
    private QueryResult postsField;
    private string priorityField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string reasonField;
    private QueryResult recordAssociatedGroupsField;
    private QueryResult sharesField;
    private QueryResult solutionsField;
    private Name sourceField;
    private string sourceIdField;
    private string statusField;
    private string subjectField;
    private string suppliedCompanyField;
    private string suppliedEmailField;
    private string suppliedNameField;
    private string suppliedPhoneField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult teamMembersField;
    private QueryResult teamTemplateRecordsField;
    private QueryResult topicAssignmentsField;
    private string typeField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public Account Account
    {
      get => this.accountField;
      set => this.accountField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AccountId
    {
      get => this.accountIdField;
      set => this.accountIdField = value;
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
    public QueryResult CaseComments
    {
      get => this.caseCommentsField;
      set => this.caseCommentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CaseContactRoles
    {
      get => this.caseContactRolesField;
      set => this.caseContactRolesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CaseNumber
    {
      get => this.caseNumberField;
      set => this.caseNumberField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CaseSolutions
    {
      get => this.caseSolutionsField;
      set => this.caseSolutionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Cases
    {
      get => this.casesField;
      set => this.casesField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ClosedDate
    {
      get => this.closedDateField;
      set => this.closedDateField = value;
    }

    [XmlIgnore]
    public bool ClosedDateSpecified
    {
      get => this.closedDateFieldSpecified;
      set => this.closedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Contact Contact
    {
      get => this.contactField;
      set => this.contactField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContactEmail
    {
      get => this.contactEmailField;
      set => this.contactEmailField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContactFax
    {
      get => this.contactFaxField;
      set => this.contactFaxField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContactId
    {
      get => this.contactIdField;
      set => this.contactIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContactMobile
    {
      get => this.contactMobileField;
      set => this.contactMobileField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContactPhone
    {
      get => this.contactPhoneField;
      set => this.contactPhoneField = value;
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
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult EmailMessages
    {
      get => this.emailMessagesField;
      set => this.emailMessagesField = value;
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
    public QueryResult Feeds
    {
      get => this.feedsField;
      set => this.feedsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsClosed
    {
      get => this.isClosedField;
      set => this.isClosedField = value;
    }

    [XmlIgnore]
    public bool IsClosedSpecified
    {
      get => this.isClosedFieldSpecified;
      set => this.isClosedFieldSpecified = value;
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
    public bool? IsEscalated
    {
      get => this.isEscalatedField;
      set => this.isEscalatedField = value;
    }

    [XmlIgnore]
    public bool IsEscalatedSpecified
    {
      get => this.isEscalatedFieldSpecified;
      set => this.isEscalatedFieldSpecified = value;
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
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Origin
    {
      get => this.originField;
      set => this.originField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name Owner
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
    public Case Parent
    {
      get => this.parentField;
      set => this.parentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentId
    {
      get => this.parentIdField;
      set => this.parentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Posts
    {
      get => this.postsField;
      set => this.postsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
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
    public string Reason
    {
      get => this.reasonField;
      set => this.reasonField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Shares
    {
      get => this.sharesField;
      set => this.sharesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Solutions
    {
      get => this.solutionsField;
      set => this.solutionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name Source
    {
      get => this.sourceField;
      set => this.sourceField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceId
    {
      get => this.sourceIdField;
      set => this.sourceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Subject
    {
      get => this.subjectField;
      set => this.subjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SuppliedCompany
    {
      get => this.suppliedCompanyField;
      set => this.suppliedCompanyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SuppliedEmail
    {
      get => this.suppliedEmailField;
      set => this.suppliedEmailField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SuppliedName
    {
      get => this.suppliedNameField;
      set => this.suppliedNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SuppliedPhone
    {
      get => this.suppliedPhoneField;
      set => this.suppliedPhoneField = value;
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
    public QueryResult Tasks
    {
      get => this.tasksField;
      set => this.tasksField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TeamMembers
    {
      get => this.teamMembersField;
      set => this.teamMembersField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TeamTemplateRecords
    {
      get => this.teamTemplateRecordsField;
      set => this.teamTemplateRecordsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
