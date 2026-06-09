// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ExecuteListViewRequest
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class ExecuteListViewRequest
  {
    private string developerNameOrIdField;
    private int? limitField;
    private int? offsetField;
    private ListViewOrderBy[] orderByField;
    private string sobjectTypeField;

    public string developerNameOrId
    {
      get => this.developerNameOrIdField;
      set => this.developerNameOrIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? limit
    {
      get => this.limitField;
      set => this.limitField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? offset
    {
      get => this.offsetField;
      set => this.offsetField = value;
    }

    [XmlElement("orderBy")]
    public ListViewOrderBy[] orderBy
    {
      get => this.orderByField;
      set => this.orderByField = value;
    }

    public string sobjectType
    {
      get => this.sobjectTypeField;
      set => this.sobjectTypeField = value;
    }
  }
}
