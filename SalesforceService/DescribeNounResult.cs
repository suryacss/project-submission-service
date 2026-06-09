// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeNounResult
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class DescribeNounResult
  {
    private NameCaseValue[] caseValuesField;
    private string developerNameField;
    private Gender? genderField;
    private string nameField;
    private string pluralAliasField;
    private StartsWith? startsWithField;

    [XmlElement("caseValues")]
    public NameCaseValue[] caseValues
    {
      get => this.caseValuesField;
      set => this.caseValuesField = value;
    }

    public string developerName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public Gender? gender
    {
      get => this.genderField;
      set => this.genderField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string pluralAlias
    {
      get => this.pluralAliasField;
      set => this.pluralAliasField = value;
    }

    [XmlElement(IsNullable = true)]
    public StartsWith? startsWith
    {
      get => this.startsWithField;
      set => this.startsWithField = value;
    }
  }
}
