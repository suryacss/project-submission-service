// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DataAssessmentMetric
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
  public class DataAssessmentMetric : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult dataAssessmentMetricsField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string nameField;
    private int? numDuplicatesField;
    private bool numDuplicatesFieldSpecified;
    private int? numMatchedField;
    private bool numMatchedFieldSpecified;
    private int? numMatchedDifferentField;
    private bool numMatchedDifferentFieldSpecified;
    private int? numProcessedField;
    private bool numProcessedFieldSpecified;
    private int? numTotalField;
    private bool numTotalFieldSpecified;
    private int? numUnmatchedField;
    private bool numUnmatchedFieldSpecified;
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
    public QueryResult DataAssessmentMetrics
    {
      get => this.dataAssessmentMetricsField;
      set => this.dataAssessmentMetricsField = value;
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
    public int? NumDuplicates
    {
      get => this.numDuplicatesField;
      set => this.numDuplicatesField = value;
    }

    [XmlIgnore]
    public bool NumDuplicatesSpecified
    {
      get => this.numDuplicatesFieldSpecified;
      set => this.numDuplicatesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumMatched
    {
      get => this.numMatchedField;
      set => this.numMatchedField = value;
    }

    [XmlIgnore]
    public bool NumMatchedSpecified
    {
      get => this.numMatchedFieldSpecified;
      set => this.numMatchedFieldSpecified = value;
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
    public int? NumProcessed
    {
      get => this.numProcessedField;
      set => this.numProcessedField = value;
    }

    [XmlIgnore]
    public bool NumProcessedSpecified
    {
      get => this.numProcessedFieldSpecified;
      set => this.numProcessedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumTotal
    {
      get => this.numTotalField;
      set => this.numTotalField = value;
    }

    [XmlIgnore]
    public bool NumTotalSpecified
    {
      get => this.numTotalFieldSpecified;
      set => this.numTotalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumUnmatched
    {
      get => this.numUnmatchedField;
      set => this.numUnmatchedField = value;
    }

    [XmlIgnore]
    public bool NumUnmatchedSpecified
    {
      get => this.numUnmatchedFieldSpecified;
      set => this.numUnmatchedFieldSpecified = value;
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
