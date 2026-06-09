// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.CronTrigger
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
  public class CronTrigger : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string cronExpressionField;
    private CronJobDetail cronJobDetailField;
    private string cronJobDetailIdField;
    private DateTime? endTimeField;
    private bool endTimeFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? nextFireTimeField;
    private bool nextFireTimeFieldSpecified;
    private string ownerIdField;
    private DateTime? previousFireTimeField;
    private bool previousFireTimeFieldSpecified;
    private DateTime? startTimeField;
    private bool startTimeFieldSpecified;
    private string stateField;
    private string timeZoneSidKeyField;
    private int? timesTriggeredField;
    private bool timesTriggeredFieldSpecified;

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
    public string CronExpression
    {
      get => this.cronExpressionField;
      set => this.cronExpressionField = value;
    }

    [XmlElement(IsNullable = true)]
    public CronJobDetail CronJobDetail
    {
      get => this.cronJobDetailField;
      set => this.cronJobDetailField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CronJobDetailId
    {
      get => this.cronJobDetailIdField;
      set => this.cronJobDetailIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? EndTime
    {
      get => this.endTimeField;
      set => this.endTimeField = value;
    }

    [XmlIgnore]
    public bool EndTimeSpecified
    {
      get => this.endTimeFieldSpecified;
      set => this.endTimeFieldSpecified = value;
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
    public DateTime? NextFireTime
    {
      get => this.nextFireTimeField;
      set => this.nextFireTimeField = value;
    }

    [XmlIgnore]
    public bool NextFireTimeSpecified
    {
      get => this.nextFireTimeFieldSpecified;
      set => this.nextFireTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string OwnerId
    {
      get => this.ownerIdField;
      set => this.ownerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? PreviousFireTime
    {
      get => this.previousFireTimeField;
      set => this.previousFireTimeField = value;
    }

    [XmlIgnore]
    public bool PreviousFireTimeSpecified
    {
      get => this.previousFireTimeFieldSpecified;
      set => this.previousFireTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? StartTime
    {
      get => this.startTimeField;
      set => this.startTimeField = value;
    }

    [XmlIgnore]
    public bool StartTimeSpecified
    {
      get => this.startTimeFieldSpecified;
      set => this.startTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string State
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TimeZoneSidKey
    {
      get => this.timeZoneSidKeyField;
      set => this.timeZoneSidKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? TimesTriggered
    {
      get => this.timesTriggeredField;
      set => this.timesTriggeredField = value;
    }

    [XmlIgnore]
    public bool TimesTriggeredSpecified
    {
      get => this.timesTriggeredFieldSpecified;
      set => this.timesTriggeredFieldSpecified = value;
    }
  }
}
