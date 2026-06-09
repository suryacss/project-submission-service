// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ProcessInstance
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
  public class ProcessInstance : sObject
  {
    private DateTime? completedDateField;
    private bool completedDateFieldSpecified;
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
    private User lastActorField;
    private string lastActorIdField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private QueryResult nodesField;
    private ProcessDefinition processDefinitionField;
    private string processDefinitionIdField;
    private string statusField;
    private QueryResult stepsField;
    private QueryResult stepsAndWorkitemsField;
    private User submittedByField;
    private string submittedByIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private Name targetObjectField;
    private string targetObjectIdField;
    private QueryResult workitemsField;

    [XmlElement(IsNullable = true)]
    public DateTime? CompletedDate
    {
      get => this.completedDateField;
      set => this.completedDateField = value;
    }

    [XmlIgnore]
    public bool CompletedDateSpecified
    {
      get => this.completedDateFieldSpecified;
      set => this.completedDateFieldSpecified = value;
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
    public User LastActor
    {
      get => this.lastActorField;
      set => this.lastActorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastActorId
    {
      get => this.lastActorIdField;
      set => this.lastActorIdField = value;
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
    public QueryResult Nodes
    {
      get => this.nodesField;
      set => this.nodesField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProcessDefinition ProcessDefinition
    {
      get => this.processDefinitionField;
      set => this.processDefinitionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProcessDefinitionId
    {
      get => this.processDefinitionIdField;
      set => this.processDefinitionIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Steps
    {
      get => this.stepsField;
      set => this.stepsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult StepsAndWorkitems
    {
      get => this.stepsAndWorkitemsField;
      set => this.stepsAndWorkitemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public User SubmittedBy
    {
      get => this.submittedByField;
      set => this.submittedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SubmittedById
    {
      get => this.submittedByIdField;
      set => this.submittedByIdField = value;
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

    [XmlElement(IsNullable = true)]
    public QueryResult Workitems
    {
      get => this.workitemsField;
      set => this.workitemsField = value;
    }
  }
}
