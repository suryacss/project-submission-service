// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeSearchLayoutResult
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
  public class DescribeSearchLayoutResult
  {
    private string errorMsgField;
    private string labelField;
    private int? limitRowsField;
    private string objectTypeField;
    private DescribeColumn[] searchColumnsField;

    [XmlElement(IsNullable = true)]
    public string errorMsg
    {
      get => this.errorMsgField;
      set => this.errorMsgField = value;
    }

    [XmlElement(IsNullable = true)]
    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? limitRows
    {
      get => this.limitRowsField;
      set => this.limitRowsField = value;
    }

    public string objectType
    {
      get => this.objectTypeField;
      set => this.objectTypeField = value;
    }

    [XmlElement("searchColumns", IsNullable = true)]
    public DescribeColumn[] searchColumns
    {
      get => this.searchColumnsField;
      set => this.searchColumnsField = value;
    }
  }
}
