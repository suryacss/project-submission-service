// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApexTestRunResult
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
  public class ApexTestRunResult : sObject
  {
    private AsyncApexJob asyncApexJobField;
    private string asyncApexJobIdField;
    private int? classesCompletedField;
    private bool classesCompletedFieldSpecified;
    private int? classesEnqueuedField;
    private bool classesEnqueuedFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private DateTime? endTimeField;
    private bool endTimeFieldSpecified;
    private bool? isAllTestsField;
    private bool isAllTestsFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string jobNameField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private int? methodsCompletedField;
    private bool methodsCompletedFieldSpecified;
    private int? methodsEnqueuedField;
    private bool methodsEnqueuedFieldSpecified;
    private int? methodsFailedField;
    private bool methodsFailedFieldSpecified;
    private string sourceField;
    private DateTime? startTimeField;
    private bool startTimeFieldSpecified;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private int? testTimeField;
    private bool testTimeFieldSpecified;
    private User userField;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public AsyncApexJob AsyncApexJob
    {
      get => this.asyncApexJobField;
      set => this.asyncApexJobField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AsyncApexJobId
    {
      get => this.asyncApexJobIdField;
      set => this.asyncApexJobIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? ClassesCompleted
    {
      get => this.classesCompletedField;
      set => this.classesCompletedField = value;
    }

    [XmlIgnore]
    public bool ClassesCompletedSpecified
    {
      get => this.classesCompletedFieldSpecified;
      set => this.classesCompletedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? ClassesEnqueued
    {
      get => this.classesEnqueuedField;
      set => this.classesEnqueuedField = value;
    }

    [XmlIgnore]
    public bool ClassesEnqueuedSpecified
    {
      get => this.classesEnqueuedFieldSpecified;
      set => this.classesEnqueuedFieldSpecified = value;
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
    public bool? IsAllTests
    {
      get => this.isAllTestsField;
      set => this.isAllTestsField = value;
    }

    [XmlIgnore]
    public bool IsAllTestsSpecified
    {
      get => this.isAllTestsFieldSpecified;
      set => this.isAllTestsFieldSpecified = value;
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
    public string JobName
    {
      get => this.jobNameField;
      set => this.jobNameField = value;
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
    public int? MethodsCompleted
    {
      get => this.methodsCompletedField;
      set => this.methodsCompletedField = value;
    }

    [XmlIgnore]
    public bool MethodsCompletedSpecified
    {
      get => this.methodsCompletedFieldSpecified;
      set => this.methodsCompletedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? MethodsEnqueued
    {
      get => this.methodsEnqueuedField;
      set => this.methodsEnqueuedField = value;
    }

    [XmlIgnore]
    public bool MethodsEnqueuedSpecified
    {
      get => this.methodsEnqueuedFieldSpecified;
      set => this.methodsEnqueuedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? MethodsFailed
    {
      get => this.methodsFailedField;
      set => this.methodsFailedField = value;
    }

    [XmlIgnore]
    public bool MethodsFailedSpecified
    {
      get => this.methodsFailedFieldSpecified;
      set => this.methodsFailedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Source
    {
      get => this.sourceField;
      set => this.sourceField = value;
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
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
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
    public int? TestTime
    {
      get => this.testTimeField;
      set => this.testTimeField = value;
    }

    [XmlIgnore]
    public bool TestTimeSpecified
    {
      get => this.testTimeFieldSpecified;
      set => this.testTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User User
    {
      get => this.userField;
      set => this.userField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }
  }
}
