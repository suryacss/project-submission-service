// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeCompactLayout
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class DescribeCompactLayout
  {
    private DescribeLayoutButton[] actionsField;
    private DescribeLayoutItem[] fieldItemsField;
    private string idField;
    private DescribeLayoutItem[] imageItemsField;
    private string labelField;
    private string nameField;
    private string objectTypeField;

    [XmlElement("actions")]
    public DescribeLayoutButton[] actions
    {
      get => this.actionsField;
      set => this.actionsField = value;
    }

    [XmlElement("fieldItems")]
    public DescribeLayoutItem[] fieldItems
    {
      get => this.fieldItemsField;
      set => this.fieldItemsField = value;
    }

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [XmlElement("imageItems")]
    public DescribeLayoutItem[] imageItems
    {
      get => this.imageItemsField;
      set => this.imageItemsField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string objectType
    {
      get => this.objectTypeField;
      set => this.objectTypeField = value;
    }
  }
}
