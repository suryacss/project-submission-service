// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ProcessInstanceNode
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
  public class ProcessInstanceNode : sObject
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
    private string nodeStatusField;
    private ProcessInstance processInstanceField;
    private string processInstanceIdField;
    private ProcessNode processNodeField;
    private string processNodeIdField;
    private string processNodeNameField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private UserRecordAccess userRecordAccessField;

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
    public string NodeStatus
    {
      get => this.nodeStatusField;
      set => this.nodeStatusField = value;
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
    public string ProcessNodeName
    {
      get => this.processNodeNameField;
      set => this.processNodeNameField = value;
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
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
