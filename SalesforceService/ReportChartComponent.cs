// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ReportChartComponent
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
  public class ReportChartComponent : DescribeLayoutComponent
  {
    private bool cacheDataField;
    private string contextFilterableFieldField;
    private string errorField;
    private bool hideOnErrorField;
    private bool includeContextField;
    private bool showTitleField;
    private ReportChartSize sizeField;

    public bool cacheData
    {
      get => this.cacheDataField;
      set => this.cacheDataField = value;
    }

    public string contextFilterableField
    {
      get => this.contextFilterableFieldField;
      set => this.contextFilterableFieldField = value;
    }

    public string error
    {
      get => this.errorField;
      set => this.errorField = value;
    }

    public bool hideOnError
    {
      get => this.hideOnErrorField;
      set => this.hideOnErrorField = value;
    }

    public bool includeContext
    {
      get => this.includeContextField;
      set => this.includeContextField = value;
    }

    public bool showTitle
    {
      get => this.showTitleField;
      set => this.showTitleField = value;
    }

    public ReportChartSize size
    {
      get => this.sizeField;
      set => this.sizeField = value;
    }
  }
}
