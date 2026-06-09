// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserLicense
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
  public class UserLicense : sObject
  {
    private string licenseDefinitionKeyField;
    private string nameField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult userlicensesField;

    [XmlElement(IsNullable = true)]
    public string LicenseDefinitionKey
    {
      get => this.licenseDefinitionKeyField;
      set => this.licenseDefinitionKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
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
    public QueryResult userlicenses
    {
      get => this.userlicensesField;
      set => this.userlicensesField = value;
    }
  }
}
