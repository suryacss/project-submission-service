// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Event
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
  public class Event : sObject
  {
    private string[] acceptedEventInviteeIdsField;
    private QueryResult acceptedEventRelationsField;
    private Account accountField;
    private string accountIdField;
    private DateTime? activityDateField;
    private bool activityDateFieldSpecified;
    private DateTime? activityDateTimeField;
    private bool activityDateTimeFieldSpecified;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string[] declinedEventInviteeIdsField;
    private QueryResult declinedEventRelationsField;
    private string descriptionField;
    private int? durationInMinutesField;
    private bool durationInMinutesFieldSpecified;
    private DateTime? endDateTimeField;
    private bool endDateTimeFieldSpecified;
    private QueryResult eventRelationsField;
    private string eventSubtypeField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private string groupEventTypeField;
    private bool? isAllDayEventField;
    private bool isAllDayEventFieldSpecified;
    private bool? isArchivedField;
    private bool isArchivedFieldSpecified;
    private bool? isChildField;
    private bool isChildFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isGroupEventField;
    private bool isGroupEventFieldSpecified;
    private bool? isPrivateField;
    private bool isPrivateFieldSpecified;
    private bool? isRecurrenceField;
    private bool isRecurrenceFieldSpecified;
    private bool? isReminderSetField;
    private bool isReminderSetFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string locationField;
    private Name ownerField;
    private string ownerIdField;
    private string recurrenceActivityIdField;
    private int? recurrenceDayOfMonthField;
    private bool recurrenceDayOfMonthFieldSpecified;
    private int? recurrenceDayOfWeekMaskField;
    private bool recurrenceDayOfWeekMaskFieldSpecified;
    private DateTime? recurrenceEndDateOnlyField;
    private bool recurrenceEndDateOnlyFieldSpecified;
    private string recurrenceInstanceField;
    private int? recurrenceIntervalField;
    private bool recurrenceIntervalFieldSpecified;
    private string recurrenceMonthOfYearField;
    private DateTime? recurrenceStartDateTimeField;
    private bool recurrenceStartDateTimeFieldSpecified;
    private string recurrenceTimeZoneSidKeyField;
    private string recurrenceTypeField;
    private QueryResult recurringEventsField;
    private DateTime? reminderDateTimeField;
    private bool reminderDateTimeFieldSpecified;
    private string showAsField;
    private DateTime? startDateTimeField;
    private bool startDateTimeFieldSpecified;
    private string subjectField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult topicAssignmentsField;
    private string[] undecidedEventInviteeIdsField;
    private QueryResult undecidedEventRelationsField;
    private Name whatField;
    private string whatIdField;
    private Name whoField;
    private string whoIdField;

    [XmlElement("AcceptedEventInviteeIds", IsNullable = true)]
    public string[] AcceptedEventInviteeIds
    {
      get => this.acceptedEventInviteeIdsField;
      set => this.acceptedEventInviteeIdsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AcceptedEventRelations
    {
      get => this.acceptedEventRelationsField;
      set => this.acceptedEventRelationsField = value;
    }

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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ActivityDate
    {
      get => this.activityDateField;
      set => this.activityDateField = value;
    }

    [XmlIgnore]
    public bool ActivityDateSpecified
    {
      get => this.activityDateFieldSpecified;
      set => this.activityDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ActivityDateTime
    {
      get => this.activityDateTimeField;
      set => this.activityDateTimeField = value;
    }

    [XmlIgnore]
    public bool ActivityDateTimeSpecified
    {
      get => this.activityDateTimeFieldSpecified;
      set => this.activityDateTimeFieldSpecified = value;
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

    [XmlElement("DeclinedEventInviteeIds", IsNullable = true)]
    public string[] DeclinedEventInviteeIds
    {
      get => this.declinedEventInviteeIdsField;
      set => this.declinedEventInviteeIdsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DeclinedEventRelations
    {
      get => this.declinedEventRelationsField;
      set => this.declinedEventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? DurationInMinutes
    {
      get => this.durationInMinutesField;
      set => this.durationInMinutesField = value;
    }

    [XmlIgnore]
    public bool DurationInMinutesSpecified
    {
      get => this.durationInMinutesFieldSpecified;
      set => this.durationInMinutesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? EndDateTime
    {
      get => this.endDateTimeField;
      set => this.endDateTimeField = value;
    }

    [XmlIgnore]
    public bool EndDateTimeSpecified
    {
      get => this.endDateTimeFieldSpecified;
      set => this.endDateTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult EventRelations
    {
      get => this.eventRelationsField;
      set => this.eventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EventSubtype
    {
      get => this.eventSubtypeField;
      set => this.eventSubtypeField = value;
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
    public string GroupEventType
    {
      get => this.groupEventTypeField;
      set => this.groupEventTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsAllDayEvent
    {
      get => this.isAllDayEventField;
      set => this.isAllDayEventField = value;
    }

    [XmlIgnore]
    public bool IsAllDayEventSpecified
    {
      get => this.isAllDayEventFieldSpecified;
      set => this.isAllDayEventFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsArchived
    {
      get => this.isArchivedField;
      set => this.isArchivedField = value;
    }

    [XmlIgnore]
    public bool IsArchivedSpecified
    {
      get => this.isArchivedFieldSpecified;
      set => this.isArchivedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsChild
    {
      get => this.isChildField;
      set => this.isChildField = value;
    }

    [XmlIgnore]
    public bool IsChildSpecified
    {
      get => this.isChildFieldSpecified;
      set => this.isChildFieldSpecified = value;
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
    public bool? IsGroupEvent
    {
      get => this.isGroupEventField;
      set => this.isGroupEventField = value;
    }

    [XmlIgnore]
    public bool IsGroupEventSpecified
    {
      get => this.isGroupEventFieldSpecified;
      set => this.isGroupEventFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsPrivate
    {
      get => this.isPrivateField;
      set => this.isPrivateField = value;
    }

    [XmlIgnore]
    public bool IsPrivateSpecified
    {
      get => this.isPrivateFieldSpecified;
      set => this.isPrivateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsRecurrence
    {
      get => this.isRecurrenceField;
      set => this.isRecurrenceField = value;
    }

    [XmlIgnore]
    public bool IsRecurrenceSpecified
    {
      get => this.isRecurrenceFieldSpecified;
      set => this.isRecurrenceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsReminderSet
    {
      get => this.isReminderSetField;
      set => this.isReminderSetField = value;
    }

    [XmlIgnore]
    public bool IsReminderSetSpecified
    {
      get => this.isReminderSetFieldSpecified;
      set => this.isReminderSetFieldSpecified = value;
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
    public string Location
    {
      get => this.locationField;
      set => this.locationField = value;
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
    public string RecurrenceActivityId
    {
      get => this.recurrenceActivityIdField;
      set => this.recurrenceActivityIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RecurrenceDayOfMonth
    {
      get => this.recurrenceDayOfMonthField;
      set => this.recurrenceDayOfMonthField = value;
    }

    [XmlIgnore]
    public bool RecurrenceDayOfMonthSpecified
    {
      get => this.recurrenceDayOfMonthFieldSpecified;
      set => this.recurrenceDayOfMonthFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RecurrenceDayOfWeekMask
    {
      get => this.recurrenceDayOfWeekMaskField;
      set => this.recurrenceDayOfWeekMaskField = value;
    }

    [XmlIgnore]
    public bool RecurrenceDayOfWeekMaskSpecified
    {
      get => this.recurrenceDayOfWeekMaskFieldSpecified;
      set => this.recurrenceDayOfWeekMaskFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RecurrenceEndDateOnly
    {
      get => this.recurrenceEndDateOnlyField;
      set => this.recurrenceEndDateOnlyField = value;
    }

    [XmlIgnore]
    public bool RecurrenceEndDateOnlySpecified
    {
      get => this.recurrenceEndDateOnlyFieldSpecified;
      set => this.recurrenceEndDateOnlyFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecurrenceInstance
    {
      get => this.recurrenceInstanceField;
      set => this.recurrenceInstanceField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RecurrenceInterval
    {
      get => this.recurrenceIntervalField;
      set => this.recurrenceIntervalField = value;
    }

    [XmlIgnore]
    public bool RecurrenceIntervalSpecified
    {
      get => this.recurrenceIntervalFieldSpecified;
      set => this.recurrenceIntervalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecurrenceMonthOfYear
    {
      get => this.recurrenceMonthOfYearField;
      set => this.recurrenceMonthOfYearField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? RecurrenceStartDateTime
    {
      get => this.recurrenceStartDateTimeField;
      set => this.recurrenceStartDateTimeField = value;
    }

    [XmlIgnore]
    public bool RecurrenceStartDateTimeSpecified
    {
      get => this.recurrenceStartDateTimeFieldSpecified;
      set => this.recurrenceStartDateTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecurrenceTimeZoneSidKey
    {
      get => this.recurrenceTimeZoneSidKeyField;
      set => this.recurrenceTimeZoneSidKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecurrenceType
    {
      get => this.recurrenceTypeField;
      set => this.recurrenceTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecurringEvents
    {
      get => this.recurringEventsField;
      set => this.recurringEventsField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ReminderDateTime
    {
      get => this.reminderDateTimeField;
      set => this.reminderDateTimeField = value;
    }

    [XmlIgnore]
    public bool ReminderDateTimeSpecified
    {
      get => this.reminderDateTimeFieldSpecified;
      set => this.reminderDateTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ShowAs
    {
      get => this.showAsField;
      set => this.showAsField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? StartDateTime
    {
      get => this.startDateTimeField;
      set => this.startDateTimeField = value;
    }

    [XmlIgnore]
    public bool StartDateTimeSpecified
    {
      get => this.startDateTimeFieldSpecified;
      set => this.startDateTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Subject
    {
      get => this.subjectField;
      set => this.subjectField = value;
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

    [XmlElement("UndecidedEventInviteeIds", IsNullable = true)]
    public string[] UndecidedEventInviteeIds
    {
      get => this.undecidedEventInviteeIdsField;
      set => this.undecidedEventInviteeIdsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult UndecidedEventRelations
    {
      get => this.undecidedEventRelationsField;
      set => this.undecidedEventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name What
    {
      get => this.whatField;
      set => this.whatField = value;
    }

    [XmlElement(IsNullable = true)]
    public string WhatId
    {
      get => this.whatIdField;
      set => this.whatIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name Who
    {
      get => this.whoField;
      set => this.whoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string WhoId
    {
      get => this.whoIdField;
      set => this.whoIdField = value;
    }
  }
}
