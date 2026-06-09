// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.VisualforcePage
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class VisualforcePage : DescribeLayoutComponent
  {
    private bool showLabelField;
    private bool showScrollbarsField;
    private string suggestedHeightField;
    private string suggestedWidthField;
    private string urlField;

    public bool showLabel
    {
      get => this.showLabelField;
      set => this.showLabelField = value;
    }

    public bool showScrollbars
    {
      get => this.showScrollbarsField;
      set => this.showScrollbarsField = value;
    }

    public string suggestedHeight
    {
      get => this.suggestedHeightField;
      set => this.suggestedHeightField = value;
    }

    public string suggestedWidth
    {
      get => this.suggestedWidthField;
      set => this.suggestedWidthField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }
  }
}
