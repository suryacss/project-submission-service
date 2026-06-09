// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeThemeItem
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class DescribeThemeItem
  {
    private DescribeColor[] colorsField;
    private DescribeIcon[] iconsField;
    private string nameField;

    [XmlElement("colors")]
    public DescribeColor[] colors
    {
      get => this.colorsField;
      set => this.colorsField = value;
    }

    [XmlElement("icons")]
    public DescribeIcon[] icons
    {
      get => this.iconsField;
      set => this.iconsField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }
  }
}
