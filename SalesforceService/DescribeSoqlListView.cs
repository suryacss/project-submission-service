// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeSoqlListView
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class DescribeSoqlListView
  {
    private ListViewColumn[] columnsField;
    private string idField;
    private ListViewOrderBy[] orderByField;
    private string queryField;
    private string scopeField;
    private string sobjectTypeField;
    private SoqlWhereCondition whereConditionField;

    [XmlElement("columns")]
    public ListViewColumn[] columns
    {
      get => this.columnsField;
      set => this.columnsField = value;
    }

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [XmlElement("orderBy")]
    public ListViewOrderBy[] orderBy
    {
      get => this.orderByField;
      set => this.orderByField = value;
    }

    public string query
    {
      get => this.queryField;
      set => this.queryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string scope
    {
      get => this.scopeField;
      set => this.scopeField = value;
    }

    public string sobjectType
    {
      get => this.sobjectTypeField;
      set => this.sobjectTypeField = value;
    }

    public SoqlWhereCondition whereCondition
    {
      get => this.whereConditionField;
      set => this.whereConditionField = value;
    }
  }
}
