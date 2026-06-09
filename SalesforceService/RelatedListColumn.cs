// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RelatedListColumn
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class RelatedListColumn
  {
    private string fieldField;
    private string fieldApiNameField;
    private string formatField;
    private string labelField;
    private string lookupIdField;
    private string nameField;

    [XmlElement(IsNullable = true)]
    public string field
    {
      get => this.fieldField;
      set => this.fieldField = value;
    }

    public string fieldApiName
    {
      get => this.fieldApiNameField;
      set => this.fieldApiNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string format
    {
      get => this.formatField;
      set => this.formatField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string lookupId
    {
      get => this.lookupIdField;
      set => this.lookupIdField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }
  }
}
