// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LookedUpFromActivity
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class LookedUpFromActivity : sObject
  {
    private Account accountField;
    private string accountIdField;
    private DateTime? activityDateField;
    private bool activityDateFieldSpecified;
    private string activitySubtypeField;
    private string activityTypeField;
    private string callDispositionField;
    private int? callDurationInSecondsField;
    private bool callDurationInSecondsFieldSpecified;
    private string callObjectField;
    private string callTypeField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private int? durationInMinutesField;
    private bool durationInMinutesFieldSpecified;
    private DateTime? endDateTimeField;
    private bool endDateTimeFieldSpecified;
    private bool? isAllDayEventField;
    private bool isAllDayEventFieldSpecified;
    private bool? isClosedField;
    private bool isClosedFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isHighPriorityField;
    private bool isHighPriorityFieldSpecified;
    private bool? isReminderSetField;
    private bool isReminderSetFieldSpecified;
    private bool? isTaskField;
    private bool isTaskFieldSpecified;
    private bool? isVisibleInSelfServiceField;
    private bool isVisibleInSelfServiceFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string locationField;
    private Name ownerField;
    private string ownerIdField;
    private string priorityField;
    private DateTime? reminderDateTimeField;
    private bool reminderDateTimeFieldSpecified;
    private DateTime? startDateTimeField;
    private bool startDateTimeFieldSpecified;
    private string statusField;
    private string subjectField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private Name whatField;
    private string whatIdField;
    private Name whoField;
    private string whoIdField;

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
    public string ActivitySubtype
    {
      get => this.activitySubtypeField;
      set => this.activitySubtypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ActivityType
    {
      get => this.activityTypeField;
      set => this.activityTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CallDisposition
    {
      get => this.callDispositionField;
      set => this.callDispositionField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? CallDurationInSeconds
    {
      get => this.callDurationInSecondsField;
      set => this.callDurationInSecondsField = value;
    }

    [XmlIgnore]
    public bool CallDurationInSecondsSpecified
    {
      get => this.callDurationInSecondsFieldSpecified;
      set => this.callDurationInSecondsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CallObject
    {
      get => this.callObjectField;
      set => this.callObjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CallType
    {
      get => this.callTypeField;
      set => this.callTypeField = value;
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
    public bool? IsHighPriority
    {
      get => this.isHighPriorityField;
      set => this.isHighPriorityField = value;
    }

    [XmlIgnore]
    public bool IsHighPrioritySpecified
    {
      get => this.isHighPriorityFieldSpecified;
      set => this.isHighPriorityFieldSpecified = value;
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
    public bool? IsTask
    {
      get => this.isTaskField;
      set => this.isTaskField = value;
    }

    [XmlIgnore]
    public bool IsTaskSpecified
    {
      get => this.isTaskFieldSpecified;
      set => this.isTaskFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsVisibleInSelfService
    {
      get => this.isVisibleInSelfServiceField;
      set => this.isVisibleInSelfServiceField = value;
    }

    [XmlIgnore]
    public bool IsVisibleInSelfServiceSpecified
    {
      get => this.isVisibleInSelfServiceFieldSpecified;
      set => this.isVisibleInSelfServiceFieldSpecified = value;
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
    public string Priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
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
