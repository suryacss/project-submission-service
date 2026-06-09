// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Publisher
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
  public class Publisher : sObject
  {
    private string durableIdField;
    private QueryResult installedEntityDefinitionsField;
    private QueryResult installedFieldDefinitionsField;
    private bool? isSalesforceField;
    private bool isSalesforceFieldSpecified;
    private int? majorVersionField;
    private bool majorVersionFieldSpecified;
    private int? minorVersionField;
    private bool minorVersionFieldSpecified;
    private string nameField;
    private string namespacePrefixField;

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult InstalledEntityDefinitions
    {
      get => this.installedEntityDefinitionsField;
      set => this.installedEntityDefinitionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult InstalledFieldDefinitions
    {
      get => this.installedFieldDefinitionsField;
      set => this.installedFieldDefinitionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsSalesforce
    {
      get => this.isSalesforceField;
      set => this.isSalesforceField = value;
    }

    [XmlIgnore]
    public bool IsSalesforceSpecified
    {
      get => this.isSalesforceFieldSpecified;
      set => this.isSalesforceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? MajorVersion
    {
      get => this.majorVersionField;
      set => this.majorVersionField = value;
    }

    [XmlIgnore]
    public bool MajorVersionSpecified
    {
      get => this.majorVersionFieldSpecified;
      set => this.majorVersionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? MinorVersion
    {
      get => this.minorVersionField;
      set => this.minorVersionField = value;
    }

    [XmlIgnore]
    public bool MinorVersionSpecified
    {
      get => this.minorVersionFieldSpecified;
      set => this.minorVersionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }
  }
}
