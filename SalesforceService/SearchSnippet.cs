// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SearchSnippet
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class SearchSnippet
  {
    private string textField;
    private NameValuePair[] wholeFieldsField;

    [XmlElement(IsNullable = true)]
    public string text
    {
      get => this.textField;
      set => this.textField = value;
    }

    [XmlElement("wholeFields")]
    public NameValuePair[] wholeFields
    {
      get => this.wholeFieldsField;
      set => this.wholeFieldsField = value;
    }
  }
}
