// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Canvas
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class Canvas : DescribeLayoutComponent
  {
    private string displayLocationField;
    private string referenceIdField;
    private bool showLabelField;
    private bool showScrollbarsField;
    private string suggestedHeightField;
    private string suggestedWidthField;

    public string displayLocation
    {
      get => this.displayLocationField;
      set => this.displayLocationField = value;
    }

    public string referenceId
    {
      get => this.referenceIdField;
      set => this.referenceIdField = value;
    }

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
  }
}
