// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.KnowledgeSettings
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class KnowledgeSettings
  {
    private string defaultLanguageField;
    private bool knowledgeEnabledField;
    private KnowledgeLanguageItem[] languagesField;

    public string defaultLanguage
    {
      get => this.defaultLanguageField;
      set => this.defaultLanguageField = value;
    }

    public bool knowledgeEnabled
    {
      get => this.knowledgeEnabledField;
      set => this.knowledgeEnabledField = value;
    }

    [XmlElement("languages")]
    public KnowledgeLanguageItem[] languages
    {
      get => this.languagesField;
      set => this.languagesField = value;
    }
  }
}
