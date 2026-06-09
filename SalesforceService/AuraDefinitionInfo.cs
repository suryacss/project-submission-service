// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.AuraDefinitionInfo
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
  public class AuraDefinitionInfo : sObject
  {
    private AuraDefinitionBundleInfo auraDefinitionBundleInfoField;
    private string auraDefinitionBundleInfoIdField;
    private string auraDefinitionIdField;
    private string defTypeField;
    private string developerNameField;
    private string durableIdField;
    private string formatField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string namespacePrefixField;
    private string sourceField;

    [XmlElement(IsNullable = true)]
    public AuraDefinitionBundleInfo AuraDefinitionBundleInfo
    {
      get => this.auraDefinitionBundleInfoField;
      set => this.auraDefinitionBundleInfoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AuraDefinitionBundleInfoId
    {
      get => this.auraDefinitionBundleInfoIdField;
      set => this.auraDefinitionBundleInfoIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AuraDefinitionId
    {
      get => this.auraDefinitionIdField;
      set => this.auraDefinitionIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefType
    {
      get => this.defTypeField;
      set => this.defTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Format
    {
      get => this.formatField;
      set => this.formatField = value;
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
    public string Source
    {
      get => this.sourceField;
      set => this.sourceField = value;
    }
  }
}
