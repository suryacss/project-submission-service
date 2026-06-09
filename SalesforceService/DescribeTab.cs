// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeTab
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
  public class DescribeTab
  {
    private DescribeColor[] colorsField;
    private bool customField;
    private string iconUrlField;
    private DescribeIcon[] iconsField;
    private string labelField;
    private string miniIconUrlField;
    private string nameField;
    private string sobjectNameField;
    private string urlField;

    [XmlElement("colors")]
    public DescribeColor[] colors
    {
      get => this.colorsField;
      set => this.colorsField = value;
    }

    public bool custom
    {
      get => this.customField;
      set => this.customField = value;
    }

    public string iconUrl
    {
      get => this.iconUrlField;
      set => this.iconUrlField = value;
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

    public string miniIconUrl
    {
      get => this.miniIconUrlField;
      set => this.miniIconUrlField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string sobjectName
    {
      get => this.sobjectNameField;
      set => this.sobjectNameField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }
  }
}
