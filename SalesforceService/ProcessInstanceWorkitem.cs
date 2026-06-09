// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ProcessInstanceWorkitem
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
  public class ProcessInstanceWorkitem : sObject
  {
    private Name actorField;
    private string actorIdField;
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
    private Name originalActorField;
    private string originalActorIdField;
    private ProcessInstance processInstanceField;
    private string processInstanceIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

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
