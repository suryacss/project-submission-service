// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeLayoutComponent
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
  [XmlInclude(typeof (FieldComponent))]
  [XmlInclude(typeof (Canvas))]
  [XmlInclude(typeof (VisualforcePage))]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [XmlInclude(typeof (CustomLinkComponent))]
  [XmlInclude(typeof (AnalyticsCloudComponent))]
  [XmlInclude(typeof (ReportChartComponent))]
  [XmlInclude(typeof (FieldLayoutComponent))]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class DescribeLayoutComponent
  {
    private int displayLinesField;
    private int tabOrderField;
    private layoutComponentType typeField;
    private string valueField;

    public int displayLines
    {
      get => this.displayLinesField;
      set => this.displayLinesField = value;
    }

    public int tabOrder
    {
      get => this.tabOrderField;
      set => this.tabOrderField = value;
    }

    public layoutComponentType type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string value
    {
      get => this.valueField;
      set => this.valueField = value;
    }
  }
}
