// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ExecuteListViewResult
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ExecuteListViewResult
  {
    private ListViewColumn[] columnsField;
    private string developerNameField;
    private bool doneField;
    private string idField;
    private string labelField;
    private ListViewRecordColumn[] recordsField;
    private int sizeField;

    [XmlElement("columns")]
    public ListViewColumn[] columns
    {
      get => this.columnsField;
      set => this.columnsField = value;
    }

    public string developerName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    public bool done
    {
      get => this.doneField;
      set => this.doneField = value;
    }

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlArrayItem("columns", typeof (ListViewRecordColumn), IsNullable = false)]
    public ListViewRecordColumn[] records
    {
      get => this.recordsField;
      set => this.recordsField = value;
    }

    public int size
    {
      get => this.sizeField;
      set => this.sizeField = value;
    }
  }
}
