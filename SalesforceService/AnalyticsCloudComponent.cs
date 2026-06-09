// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.AnalyticsCloudComponent
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
  public class AnalyticsCloudComponent : DescribeLayoutComponent
  {
    private string errorField;
    private string filterField;
    private string heightField;
    private bool hideOnErrorField;
    private bool showSharingField;
    private bool showTitleField;
    private string widthField;

    public string error
    {
      get => this.errorField;
      set => this.errorField = value;
    }

    public string filter
    {
      get => this.filterField;
      set => this.filterField = value;
    }

    public string height
    {
      get => this.heightField;
      set => this.heightField = value;
    }

    public bool hideOnError
    {
      get => this.hideOnErrorField;
      set => this.hideOnErrorField = value;
    }

    public bool showSharing
    {
      get => this.showSharingField;
      set => this.showSharingField = value;
    }

    public bool showTitle
    {
      get => this.showTitleField;
      set => this.showTitleField = value;
    }

    public string width
    {
      get => this.widthField;
      set => this.widthField = value;
    }
  }
}
