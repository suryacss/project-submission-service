// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeLayoutSection
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
  public class DescribeLayoutSection
  {
    private bool collapsedField;
    private int columnsField;
    private string headingField;
    private DescribeLayoutRow[] layoutRowsField;
    private string layoutSectionIdField;
    private string parentLayoutIdField;
    private int rowsField;
    private TabOrderType tabOrderField;
    private bool useCollapsibleSectionField;
    private bool useHeadingField;

    public bool collapsed
    {
      get => this.collapsedField;
      set => this.collapsedField = value;
    }

    public int columns
    {
      get => this.columnsField;
      set => this.columnsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string heading
    {
      get => this.headingField;
      set => this.headingField = value;
    }

    [XmlElement("layoutRows")]
    public DescribeLayoutRow[] layoutRows
    {
      get => this.layoutRowsField;
      set => this.layoutRowsField = value;
    }

    public string layoutSectionId
    {
      get => this.layoutSectionIdField;
      set => this.layoutSectionIdField = value;
    }

    public string parentLayoutId
    {
      get => this.parentLayoutIdField;
      set => this.parentLayoutIdField = value;
    }

    public int rows
    {
      get => this.rowsField;
      set => this.rowsField = value;
    }

    public TabOrderType tabOrder
    {
      get => this.tabOrderField;
      set => this.tabOrderField = value;
    }

    public bool useCollapsibleSection
    {
      get => this.useCollapsibleSectionField;
      set => this.useCollapsibleSectionField = value;
    }

    public bool useHeading
    {
      get => this.useHeadingField;
      set => this.useHeadingField = value;
    }
  }
}
