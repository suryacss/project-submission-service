// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ProcessInstanceHistory
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class ProcessInstanceHistory : sObject
  {
    private Name actorField;
    private string actorIdField;
    private string commentsField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private double? elapsedTimeInDaysField;
    private bool elapsedTimeInDaysFieldSpecified;
    private double? elapsedTimeInHoursField;
    private bool elapsedTimeInHoursFieldSpecified;
    private double? elapsedTimeInMinutesField;
    private bool elapsedTimeInMinutesFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isPendingField;
    private bool isPendingFieldSpecified;
    private Name originalActorField;
    private string originalActorIdField;
    private ProcessInstance processInstanceField;
    private string processInstanceIdField;
    private ProcessNode processNodeField;
    private string processNodeIdField;
    private int? remindersSentField;
    private bool remindersSentFieldSpecified;
    private string stepStatusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private Name targetObjectField;
    private string targetObjectIdField;

    [XmlElement(IsNullable = true)]
    public Name Actor
    {
      get => this.actorField;
      set => this.actorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ActorId
    {
      get => this.actorIdField;
      set => this.actorIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Comments
    {
      get => this.commentsField;
      set => this.commentsField = value;
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
    public double? ElapsedTimeInDays
    {
      get => this.elapsedTimeInDaysField;
      set => this.elapsedTimeInDaysField = value;
    }

    [XmlIgnore]
    public bool ElapsedTimeInDaysSpecified
    {
      get => this.elapsedTimeInDaysFieldSpecified;
      set => this.elapsedTimeInDaysFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ElapsedTimeInHours
    {
      get => this.elapsedTimeInHoursField;
      set => this.elapsedTimeInHoursField = value;
    }

    [XmlIgnore]
    public bool ElapsedTimeInHoursSpecified
    {
      get => this.elapsedTimeInHoursFieldSpecified;
      set => this.elapsedTimeInHoursFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ElapsedTimeInMinutes
    {
      get => this.elapsedTimeInMinutesField;
      set => this.elapsedTimeInMinutesField = value;
    }

    [XmlIgnore]
    public bool ElapsedTimeInMinutesSpecified
    {
      get => this.elapsedTimeInMinutesFieldSpecified;
      set => this.elapsedTimeInMinutesFieldSpecified = value;
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
    public bool? IsPending
    {
      get => this.isPendingField;
      set => this.isPendingField = value;
    }

    [XmlIgnore]
    public bool IsPendingSpecified
    {
      get => this.isPendingFieldSpecified;
      set => this.isPendingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public Name OriginalActor
    {
      get => this.originalActorField;
      set => this.originalActorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OriginalActorId
    {
      get => this.originalActorIdField;
      set => this.originalActorIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProcessInstance ProcessInstance
    {
      get => this.processInstanceField;
      set => this.processInstanceField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProcessInstanceId
    {
      get => this.processInstanceIdField;
      set => this.processInstanceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProcessNode ProcessNode
    {
      get => this.processNodeField;
      set => this.processNodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProcessNodeId
    {
      get => this.processNodeIdField;
      set => this.processNodeIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RemindersSent
    {
      get => this.remindersSentField;
      set => this.remindersSentField = value;
    }

    [XmlIgnore]
    public bool RemindersSentSpecified
    {
      get => this.remindersSentFieldSpecified;
      set => this.remindersSentFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string StepStatus
    {
      get => this.stepStatusField;
      set => this.stepStatusField = value;
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
    public Name TargetObject
    {
      get => this.targetObjectField;
      set => this.targetObjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TargetObjectId
    {
      get => this.targetObjectIdField;
      set => this.targetObjectIdField = value;
    }
  }
}
