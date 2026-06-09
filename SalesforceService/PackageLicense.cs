// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PackageLicense
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
  public class PackageLicense : sObject
  {
    private int? allowedLicensesField;
    private bool allowedLicensesFieldSpecified;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private DateTime? expirationDateField;
    private bool expirationDateFieldSpecified;
    private bool? isProvisionedField;
    private bool isProvisionedFieldSpecified;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string namespacePrefixField;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private int? usedLicensesField;
    private bool usedLicensesFieldSpecified;

    [XmlElement(IsNullable = true)]
    public int? AllowedLicenses
    {
      get => this.allowedLicensesField;
      set => this.allowedLicensesField = value;
    }

    [XmlIgnore]
    public bool AllowedLicensesSpecified
    {
      get => this.allowedLicensesFieldSpecified;
      set => this.allowedLicensesFieldSpecified = value;
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
    public DateTime? ExpirationDate
    {
      get => this.expirationDateField;
      set => this.expirationDateField = value;
    }

    [XmlIgnore]
    public bool ExpirationDateSpecified
    {
      get => this.expirationDateFieldSpecified;
      set => this.expirationDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsProvisioned
    {
      get => this.isProvisionedField;
      set => this.isProvisionedField = value;
    }

    [XmlIgnore]
    public bool IsProvisionedSpecified
    {
      get => this.isProvisionedFieldSpecified;
      set => this.isProvisionedFieldSpecified = value;
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
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
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
    public int? UsedLicenses
    {
      get => this.usedLicensesField;
      set => this.usedLicensesField = value;
    }

    [XmlIgnore]
    public bool UsedLicensesSpecified
    {
      get => this.usedLicensesFieldSpecified;
      set => this.usedLicensesFieldSpecified = value;
    }
  }
}
