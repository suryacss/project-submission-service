// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.AsyncApexJob
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
  public class AsyncApexJob : sObject
  {
    private ApexClass apexClassField;
    private string apexClassIdField;
    private QueryResult asyncApexField;
    private DateTime? completedDateField;
    private bool completedDateFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string extendedStatusField;
    private int? jobItemsProcessedField;
    private bool jobItemsProcessedFieldSpecified;
    private string jobTypeField;
    private string lastProcessedField;
    private int? lastProcessedOffsetField;
    private bool lastProcessedOffsetFieldSpecified;
    private string methodNameField;
    private int? numberOfErrorsField;
    private bool numberOfErrorsFieldSpecified;
    private string parentJobIdField;
    private string statusField;
    private int? totalJobItemsField;
    private bool totalJobItemsFieldSpecified;

    [XmlElement(IsNullable = true)]
    public ApexClass ApexClass
    {
      get => this.apexClassField;
      set => this.apexClassField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApexClassId
    {
      get => this.apexClassIdField;
      set => this.apexClassIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AsyncApex
    {
      get => this.asyncApexField;
      set => this.asyncApexField = value;
    }

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
    public string ExtendedStatus
    {
      get => this.extendedStatusField;
      set => this.extendedStatusField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? JobItemsProcessed
    {
      get => this.jobItemsProcessedField;
      set => this.jobItemsProcessedField = value;
    }

    [XmlIgnore]
    public bool JobItemsProcessedSpecified
    {
      get => this.jobItemsProcessedFieldSpecified;
      set => this.jobItemsProcessedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string JobType
    {
      get => this.jobTypeField;
      set => this.jobTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastProcessed
    {
      get => this.lastProcessedField;
      set => this.lastProcessedField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? LastProcessedOffset
    {
      get => this.lastProcessedOffsetField;
      set => this.lastProcessedOffsetField = value;
    }

    [XmlIgnore]
    public bool LastProcessedOffsetSpecified
    {
      get => this.lastProcessedOffsetFieldSpecified;
      set => this.lastProcessedOffsetFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MethodName
    {
      get => this.methodNameField;
      set => this.methodNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfErrors
    {
      get => this.numberOfErrorsField;
      set => this.numberOfErrorsField = value;
    }

    [XmlIgnore]
    public bool NumberOfErrorsSpecified
    {
      get => this.numberOfErrorsFieldSpecified;
      set => this.numberOfErrorsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentJobId
    {
      get => this.parentJobIdField;
      set => this.parentJobIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? TotalJobItems
    {
      get => this.totalJobItemsField;
      set => this.totalJobItemsField = value;
    }

    [XmlIgnore]
    public bool TotalJobItemsSpecified
    {
      get => this.totalJobItemsFieldSpecified;
      set => this.totalJobItemsFieldSpecified = value;
    }
  }
}
