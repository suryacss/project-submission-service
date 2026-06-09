// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeAppMenuItem
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
  public class DescribeAppMenuItem
  {
    private DescribeColor[] colorsField;
    private string contentField;
    private DescribeIcon[] iconsField;
    private string labelField;
    private string nameField;
    private string typeField;
    private string urlField;

    [XmlElement("colors")]
    public DescribeColor[] colors
    {
      get => this.colorsField;
      set => this.colorsField = value;
    }

    public string content
    {
      get => this.contentField;
      set => this.contentField = value;
    }

    [XmlElement("icons")]
    public DescribeIcon[] icons
    {
      get => this.iconsField;
      set => this.iconsField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }
  }
}
