// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ListViewColumn
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class ListViewColumn
  {
    private string ascendingLabelField;
    private string descendingLabelField;
    private string fieldNameOrPathField;
    private bool hiddenField;
    private string labelField;
    private string selectListItemField;
    private orderByDirection? sortDirectionField;
    private int? sortIndexField;
    private bool sortableField;
    private fieldType typeField;

    [XmlElement(IsNullable = true)]
    public string ascendingLabel
    {
      get => this.ascendingLabelField;
      set => this.ascendingLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string descendingLabel
    {
      get => this.descendingLabelField;
      set => this.descendingLabelField = value;
    }

    public string fieldNameOrPath
    {
      get => this.fieldNameOrPathField;
      set => this.fieldNameOrPathField = value;
    }

    public bool hidden
    {
      get => this.hiddenField;
      set => this.hiddenField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public string selectListItem
    {
      get => this.selectListItemField;
      set => this.selectListItemField = value;
    }

    [XmlElement(IsNullable = true)]
    public orderByDirection? sortDirection
    {
      get => this.sortDirectionField;
      set => this.sortDirectionField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? sortIndex
    {
      get => this.sortIndexField;
      set => this.sortIndexField = value;
    }

    public bool sortable
    {
      get => this.sortableField;
      set => this.sortableField = value;
    }

    public fieldType type
    {
      get => this.typeField;
      set => this.typeField = value;
    }
  }
}
