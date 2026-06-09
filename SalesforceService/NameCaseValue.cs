// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.NameCaseValue
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class NameCaseValue
  {
    private Article? articleField;
    private CaseType? caseTypeField;
    private GrammaticalNumber? numberField;
    private Possessive? possessiveField;
    private string valueField;

    [XmlElement(IsNullable = true)]
    public Article? article
    {
      get => this.articleField;
      set => this.articleField = value;
    }

    [XmlElement(IsNullable = true)]
    public CaseType? caseType
    {
      get => this.caseTypeField;
      set => this.caseTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public GrammaticalNumber? number
    {
      get => this.numberField;
      set => this.numberField = value;
    }

    [XmlElement(IsNullable = true)]
    public Possessive? possessive
    {
      get => this.possessiveField;
      set => this.possessiveField = value;
    }

    public string value
    {
      get => this.valueField;
      set => this.valueField = value;
    }
  }
}
