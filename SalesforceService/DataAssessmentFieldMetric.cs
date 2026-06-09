// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DataAssessmentFieldMetric
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class DataAssessmentFieldMetric : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private DataAssessmentMetric dataAssessmentMetricField;
    private string dataAssessmentMetricIdField;
    private QueryResult dataAssessmentValueMetricsField;
    private string fieldNameField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string nameField;
    private int? numMatchedBlanksField;
    private bool numMatchedBlanksFieldSpecified;
    private int? numMatchedDifferentField;
    private bool numMatchedDifferentFieldSpecified;
    private int? numMatchedInSyncField;
    private bool numMatchedInSyncFieldSpecified;
    private int? numUnmatchedBlanksField;
    private bool numUnmatchedBlanksFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private UserRecordAccess userRecordAccessField;

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
    public DataAssessmentMetric DataAssessmentMetric
    {
      get => this.dataAssessmentMetricField;
      set => this.dataAssessmentMetricField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DataAssessmentMetricId
    {
      get => this.dataAssessmentMetricIdField;
      set => this.dataAssessmentMetricIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DataAssessmentValueMetrics
    {
      get => this.dataAssessmentValueMetricsField;
      set => this.dataAssessmentValueMetricsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FieldName
    {
      get => this.fieldNameField;
      set => this.fieldNameField = value;
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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumMatchedBlanks
    {
      get => this.numMatchedBlanksField;
      set => this.numMatchedBlanksField = value;
    }

    [XmlIgnore]
    public bool NumMatchedBlanksSpecified
    {
      get => this.numMatchedBlanksFieldSpecified;
      set => this.numMatchedBlanksFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumMatchedDifferent
    {
      get => this.numMatchedDifferentField;
      set => this.numMatchedDifferentField = value;
    }

    [XmlIgnore]
    public bool NumMatchedDifferentSpecified
    {
      get => this.numMatchedDifferentFieldSpecified;
      set => this.numMatchedDifferentFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumMatchedInSync
    {
      get => this.numMatchedInSyncField;
      set => this.numMatchedInSyncField = value;
    }

    [XmlIgnore]
    public bool NumMatchedInSyncSpecified
    {
      get => this.numMatchedInSyncFieldSpecified;
      set => this.numMatchedInSyncFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumUnmatchedBlanks
    {
      get => this.numUnmatchedBlanksField;
      set => this.numUnmatchedBlanksField = value;
    }

    [XmlIgnore]
    public bool NumUnmatchedBlanksSpecified
    {
      get => this.numUnmatchedBlanksFieldSpecified;
      set => this.numUnmatchedBlanksFieldSpecified = value;
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
