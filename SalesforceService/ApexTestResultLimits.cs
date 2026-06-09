// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApexTestResultLimits
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
  public class ApexTestResultLimits : sObject
  {
    private ApexTestResult apexTestResultField;
    private string apexTestResultIdField;
    private int? asyncCallsField;
    private bool asyncCallsFieldSpecified;
    private int? calloutsField;
    private bool calloutsFieldSpecified;
    private int? cpuField;
    private bool cpuFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private int? dmlField;
    private bool dmlFieldSpecified;
    private int? dmlRowsField;
    private bool dmlRowsFieldSpecified;
    private int? emailField;
    private bool emailFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string limitContextField;
    private string limitExceptionsField;
    private int? mobilePushField;
    private bool mobilePushFieldSpecified;
    private int? queryRowsField;
    private bool queryRowsFieldSpecified;
    private int? soqlField;
    private bool soqlFieldSpecified;
    private int? soslField;
    private bool soslFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public ApexTestResult ApexTestResult
    {
      get => this.apexTestResultField;
      set => this.apexTestResultField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApexTestResultId
    {
      get => this.apexTestResultIdField;
      set => this.apexTestResultIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? AsyncCalls
    {
      get => this.asyncCallsField;
      set => this.asyncCallsField = value;
    }

    [XmlIgnore]
    public bool AsyncCallsSpecified
    {
      get => this.asyncCallsFieldSpecified;
      set => this.asyncCallsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Callouts
    {
      get => this.calloutsField;
      set => this.calloutsField = value;
    }

    [XmlIgnore]
    public bool CalloutsSpecified
    {
      get => this.calloutsFieldSpecified;
      set => this.calloutsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Cpu
    {
      get => this.cpuField;
      set => this.cpuField = value;
    }

    [XmlIgnore]
    public bool CpuSpecified
    {
      get => this.cpuFieldSpecified;
      set => this.cpuFieldSpecified = value;
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
    public int? Dml
    {
      get => this.dmlField;
      set => this.dmlField = value;
    }

    [XmlIgnore]
    public bool DmlSpecified
    {
      get => this.dmlFieldSpecified;
      set => this.dmlFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? DmlRows
    {
      get => this.dmlRowsField;
      set => this.dmlRowsField = value;
    }

    [XmlIgnore]
    public bool DmlRowsSpecified
    {
      get => this.dmlRowsFieldSpecified;
      set => this.dmlRowsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Email
    {
      get => this.emailField;
      set => this.emailField = value;
    }

    [XmlIgnore]
    public bool EmailSpecified
    {
      get => this.emailFieldSpecified;
      set => this.emailFieldSpecified = value;
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
    public string LimitContext
    {
      get => this.limitContextField;
      set => this.limitContextField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LimitExceptions
    {
      get => this.limitExceptionsField;
      set => this.limitExceptionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? MobilePush
    {
      get => this.mobilePushField;
      set => this.mobilePushField = value;
    }

    [XmlIgnore]
    public bool MobilePushSpecified
    {
      get => this.mobilePushFieldSpecified;
      set => this.mobilePushFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? QueryRows
    {
      get => this.queryRowsField;
      set => this.queryRowsField = value;
    }

    [XmlIgnore]
    public bool QueryRowsSpecified
    {
      get => this.queryRowsFieldSpecified;
      set => this.queryRowsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Soql
    {
      get => this.soqlField;
      set => this.soqlField = value;
    }

    [XmlIgnore]
    public bool SoqlSpecified
    {
      get => this.soqlFieldSpecified;
      set => this.soqlFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Sosl
    {
      get => this.soslField;
      set => this.soslField = value;
    }

    [XmlIgnore]
    public bool SoslSpecified
    {
      get => this.soslFieldSpecified;
      set => this.soslFieldSpecified = value;
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
