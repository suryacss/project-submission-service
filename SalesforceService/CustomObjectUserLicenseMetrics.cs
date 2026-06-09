// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.CustomObjectUserLicenseMetrics
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class CustomObjectUserLicenseMetrics : sObject
  {
    private string customObjectIdField;
    private string customObjectNameField;
    private string customObjectTypeField;
    private DateTime? metricsDateField;
    private bool metricsDateFieldSpecified;
    private int? objectCountField;
    private bool objectCountFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private UserLicense userLicenseField;
    private string userLicenseIdField;

    [XmlElement(IsNullable = true)]
    public string CustomObjectId
    {
      get => this.customObjectIdField;
      set => this.customObjectIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CustomObjectName
    {
      get => this.customObjectNameField;
      set => this.customObjectNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CustomObjectType
    {
      get => this.customObjectTypeField;
      set => this.customObjectTypeField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? MetricsDate
    {
      get => this.metricsDateField;
      set => this.metricsDateField = value;
    }

    [XmlIgnore]
    public bool MetricsDateSpecified
    {
      get => this.metricsDateFieldSpecified;
      set => this.metricsDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? ObjectCount
    {
      get => this.objectCountField;
      set => this.objectCountField = value;
    }

    [XmlIgnore]
    public bool ObjectCountSpecified
    {
      get => this.objectCountFieldSpecified;
      set => this.objectCountFieldSpecified = value;
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
    public UserLicense UserLicense
    {
      get => this.userLicenseField;
      set => this.userLicenseField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserLicenseId
    {
      get => this.userLicenseIdField;
      set => this.userLicenseIdField = value;
    }
  }
}
