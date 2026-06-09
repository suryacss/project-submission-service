// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeLayoutItem
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class DescribeLayoutItem
  {
    private bool editableForNewField;
    private bool editableForUpdateField;
    private string labelField;
    private DescribeLayoutComponent[] layoutComponentsField;
    private bool placeholderField;
    private bool requiredField;

    public bool editableForNew
    {
      get => this.editableForNewField;
      set => this.editableForNewField = value;
    }

    public bool editableForUpdate
    {
      get => this.editableForUpdateField;
      set => this.editableForUpdateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement("layoutComponents")]
    public DescribeLayoutComponent[] layoutComponents
    {
      get => this.layoutComponentsField;
      set => this.layoutComponentsField = value;
    }

    public bool placeholder
    {
      get => this.placeholderField;
      set => this.placeholderField = value;
    }

    public bool required
    {
      get => this.requiredField;
      set => this.requiredField = value;
    }
  }
}
