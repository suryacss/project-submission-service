// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApexLog
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
  public class ApexLog : sObject
  {
    private string applicationField;
    private int? durationMillisecondsField;
    private bool durationMillisecondsFieldSpecified;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string locationField;
    private int? logLengthField;
    private bool logLengthFieldSpecified;
    private Name logUserField;
    private string logUserIdField;
    private string operationField;
    private string requestField;
    private DateTime? startTimeField;
    private bool startTimeFieldSpecified;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string Application
    {
      get => this.applicationField;
      set => this.applicationField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? DurationMilliseconds
    {
      get => this.durationMillisecondsField;
      set => this.durationMillisecondsField = value;
    }

    [XmlIgnore]
    public bool DurationMillisecondsSpecified
    {
      get => this.durationMillisecondsFieldSpecified;
      set => this.durationMillisecondsFieldSpecified = value;
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
    public string Location
    {
      get => this.locationField;
      set => this.locationField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? LogLength
    {
      get => this.logLengthField;
      set => this.logLengthField = value;
    }

    [XmlIgnore]
    public bool LogLengthSpecified
    {
      get => this.logLengthFieldSpecified;
      set => this.logLengthFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public Name LogUser
    {
      get => this.logUserField;
      set => this.logUserField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LogUserId
    {
      get => this.logUserIdField;
      set => this.logUserIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Operation
    {
      get => this.operationField;
      set => this.operationField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Request
    {
      get => this.requestField;
      set => this.requestField = value;
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
  }
}
