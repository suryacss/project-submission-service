// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Solution
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
  public class Solution : sObject
  {
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private QueryResult caseSolutionsField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private QueryResult historiesField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isHtmlField;
    private bool isHtmlFieldSpecified;
    private bool? isPublishedField;
    private bool isPublishedFieldSpecified;
    private bool? isPublishedInPublicKbField;
    private bool isPublishedInPublicKbFieldSpecified;
    private bool? isReviewedField;
    private bool isReviewedFieldSpecified;
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
    private User ownerField;
    private string ownerIdField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string solutionNameField;
    private string solutionNoteField;
    private string solutionNumberField;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private int? timesUsedField;
    private bool timesUsedFieldSpecified;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;
    private QueryResult votesField;

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
    public QueryResult CaseSolutions
    {
      get => this.caseSolutionsField;
      set => this.caseSolutionsField = value;
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
    public bool? IsHtml
    {
      get => this.isHtmlField;
      set => this.isHtmlField = value;
    }

    [XmlIgnore]
    public bool IsHtmlSpecified
    {
      get => this.isHtmlFieldSpecified;
      set => this.isHtmlFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsPublished
    {
      get => this.isPublishedField;
      set => this.isPublishedField = value;
    }

    [XmlIgnore]
    public bool IsPublishedSpecified
    {
      get => this.isPublishedFieldSpecified;
      set => this.isPublishedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsPublishedInPublicKb
    {
      get => this.isPublishedInPublicKbField;
      set => this.isPublishedInPublicKbField = value;
    }

    [XmlIgnore]
    public bool IsPublishedInPublicKbSpecified
    {
      get => this.isPublishedInPublicKbFieldSpecified;
      set => this.isPublishedInPublicKbFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsReviewed
    {
      get => this.isReviewedField;
      set => this.isReviewedField = value;
    }

    [XmlIgnore]
    public bool IsReviewedSpecified
    {
      get => this.isReviewedFieldSpecified;
      set => this.isReviewedFieldSpecified = value;
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
    public User Owner
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
    public string SolutionName
    {
      get => this.solutionNameField;
      set => this.solutionNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SolutionNote
    {
      get => this.solutionNoteField;
      set => this.solutionNoteField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SolutionNumber
    {
      get => this.solutionNumberField;
      set => this.solutionNumberField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
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
    public int? TimesUsed
    {
      get => this.timesUsedField;
      set => this.timesUsedField = value;
    }

    [XmlIgnore]
    public bool TimesUsedSpecified
    {
      get => this.timesUsedFieldSpecified;
      set => this.timesUsedFieldSpecified = value;
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
    public QueryResult Votes
    {
      get => this.votesField;
      set => this.votesField = value;
    }
  }
}
