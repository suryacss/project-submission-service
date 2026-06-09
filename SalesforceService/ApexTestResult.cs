// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApexTestResult
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
  public class ApexTestResult : sObject
  {
    private ApexClass apexClassField;
    private string apexClassIdField;
    private ApexLog apexLogField;
    private string apexLogIdField;
    private QueryResult apexTestResultsField;
    private ApexTestRunResult apexTestRunResultField;
    private string apexTestRunResultIdField;
    private AsyncApexJob asyncApexJobField;
    private string asyncApexJobIdField;
    private string messageField;
    private string methodNameField;
    private string outcomeField;
    private ApexTestQueueItem queueItemField;
    private string queueItemIdField;
    private int? runTimeField;
    private bool runTimeFieldSpecified;
    private string stackTraceField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private DateTime? testTimestampField;
    private bool testTimestampFieldSpecified;

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
    public ApexLog ApexLog
    {
      get => this.apexLogField;
      set => this.apexLogField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApexLogId
    {
      get => this.apexLogIdField;
      set => this.apexLogIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ApexTestResults
    {
      get => this.apexTestResultsField;
      set => this.apexTestResultsField = value;
    }

    [XmlElement(IsNullable = true)]
    public ApexTestRunResult ApexTestRunResult
    {
      get => this.apexTestRunResultField;
      set => this.apexTestRunResultField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApexTestRunResultId
    {
      get => this.apexTestRunResultIdField;
      set => this.apexTestRunResultIdField = value;
    }

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
    public string Message
    {
      get => this.messageField;
      set => this.messageField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MethodName
    {
      get => this.methodNameField;
      set => this.methodNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Outcome
    {
      get => this.outcomeField;
      set => this.outcomeField = value;
    }

    [XmlElement(IsNullable = true)]
    public ApexTestQueueItem QueueItem
    {
      get => this.queueItemField;
      set => this.queueItemField = value;
    }

    [XmlElement(IsNullable = true)]
    public string QueueItemId
    {
      get => this.queueItemIdField;
      set => this.queueItemIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RunTime
    {
      get => this.runTimeField;
      set => this.runTimeField = value;
    }

    [XmlIgnore]
    public bool RunTimeSpecified
    {
      get => this.runTimeFieldSpecified;
      set => this.runTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string StackTrace
    {
      get => this.stackTraceField;
      set => this.stackTraceField = value;
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
    public DateTime? TestTimestamp
    {
      get => this.testTimestampField;
      set => this.testTimestampField = value;
    }

    [XmlIgnore]
    public bool TestTimestampSpecified
    {
      get => this.testTimestampFieldSpecified;
      set => this.testTimestampFieldSpecified = value;
    }
  }
}
