// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeQuickActionListItemResult
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class DescribeQuickActionListItemResult
  {
    private ShareAccessLevel? accessLevelRequiredField;
    private DescribeColor[] colorsField;
    private string iconUrlField;
    private DescribeIcon[] iconsField;
    private string labelField;
    private string miniIconUrlField;
    private string quickActionNameField;
    private string targetSobjectTypeField;
    private string typeField;

    [XmlElement(IsNullable = true)]
    public ShareAccessLevel? accessLevelRequired
    {
      get => this.accessLevelRequiredField;
      set => this.accessLevelRequiredField = value;
    }

    [XmlElement("colors")]
    public DescribeColor[] colors
    {
      get => this.colorsField;
      set => this.colorsField = value;
    }

    [XmlElement(IsNullable = true)]
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

    public string quickActionName
    {
      get => this.quickActionNameField;
      set => this.quickActionNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string targetSobjectType
    {
      get => this.targetSobjectTypeField;
      set => this.targetSobjectTypeField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }
  }
}
