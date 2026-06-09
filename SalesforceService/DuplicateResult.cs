// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DuplicateResult
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
  public class DuplicateResult
  {
    private bool allowSaveField;
    private string duplicateRuleField;
    private string duplicateRuleEntityTypeField;
    private string errorMessageField;
    private MatchResult[] matchResultsField;

    public bool allowSave
    {
      get => this.allowSaveField;
      set => this.allowSaveField = value;
    }

    public string duplicateRule
    {
      get => this.duplicateRuleField;
      set => this.duplicateRuleField = value;
    }

    public string duplicateRuleEntityType
    {
      get => this.duplicateRuleEntityTypeField;
      set => this.duplicateRuleEntityTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string errorMessage
    {
      get => this.errorMessageField;
      set => this.errorMessageField = value;
    }

    [XmlElement("matchResults")]
    public MatchResult[] matchResults
    {
      get => this.matchResultsField;
      set => this.matchResultsField = value;
    }
  }
}
