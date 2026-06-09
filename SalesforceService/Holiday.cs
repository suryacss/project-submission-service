// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Holiday
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class Holiday : sObject
  {
    private DateTime? activityDateField;
    private bool activityDateFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private int? endTimeInMinutesField;
    private bool endTimeInMinutesFieldSpecified;
    private bool? isAllDayField;
    private bool isAllDayFieldSpecified;
    private bool? isRecurrenceField;
    private bool isRecurrenceFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string nameField;
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
    private DateTime? recurrenceStartDateField;
    private bool recurrenceStartDateFieldSpecified;
    private string recurrenceTypeField;
    private int? startTimeInMinutesField;
    private bool startTimeInMinutesFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

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
    public int? EndTimeInMinutes
    {
      get => this.endTimeInMinutesField;
      set => this.endTimeInMinutesField = value;
    }

    [XmlIgnore]
    public bool EndTimeInMinutesSpecified
    {
      get => this.endTimeInMinutesFieldSpecified;
      set => this.endTimeInMinutesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsAllDay
    {
      get => this.isAllDayField;
      set => this.isAllDayField = value;
    }

    [XmlIgnore]
    public bool IsAllDaySpecified
    {
      get => this.isAllDayFieldSpecified;
      set => this.isAllDayFieldSpecified = value;
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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RecurrenceStartDate
    {
      get => this.recurrenceStartDateField;
      set => this.recurrenceStartDateField = value;
    }

    [XmlIgnore]
    public bool RecurrenceStartDateSpecified
    {
      get => this.recurrenceStartDateFieldSpecified;
      set => this.recurrenceStartDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecurrenceType
    {
      get => this.recurrenceTypeField;
      set => this.recurrenceTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? StartTimeInMinutes
    {
      get => this.startTimeInMinutesField;
      set => this.startTimeInMinutesField = value;
    }

    [XmlIgnore]
    public bool StartTimeInMinutesSpecified
    {
      get => this.startTimeInMinutesFieldSpecified;
      set => this.startTimeInMinutesFieldSpecified = value;
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
  }
}
