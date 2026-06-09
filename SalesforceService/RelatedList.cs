// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RelatedList
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
  public class RelatedList
  {
    private ShareAccessLevel? accessLevelRequiredForCreateField;
    private DescribeLayoutButton[] buttonsField;
    private RelatedListColumn[] columnsField;
    private bool customField;
    private string fieldField;
    private string labelField;
    private int limitRowsField;
    private string nameField;
    private string sobjectField;
    private RelatedListSort[] sortField;

    [XmlElement(IsNullable = true)]
    public ShareAccessLevel? accessLevelRequiredForCreate
    {
      get => this.accessLevelRequiredForCreateField;
      set => this.accessLevelRequiredForCreateField = value;
    }

    [XmlElement("buttons", IsNullable = true)]
    public DescribeLayoutButton[] buttons
    {
      get => this.buttonsField;
      set => this.buttonsField = value;
    }

    [XmlElement("columns")]
    public RelatedListColumn[] columns
    {
      get => this.columnsField;
      set => this.columnsField = value;
    }

    public bool custom
    {
      get => this.customField;
      set => this.customField = value;
    }

    [XmlElement(IsNullable = true)]
    public string field
    {
      get => this.fieldField;
      set => this.fieldField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public int limitRows
    {
      get => this.limitRowsField;
      set => this.limitRowsField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string sobject
    {
      get => this.sobjectField;
      set => this.sobjectField = value;
    }

    [XmlElement("sort")]
    public RelatedListSort[] sort
    {
      get => this.sortField;
      set => this.sortField = value;
    }
  }
}
