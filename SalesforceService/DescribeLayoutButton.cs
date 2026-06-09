// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeLayoutButton
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class DescribeLayoutButton
  {
    private WebLinkWindowType? behaviorField;
    private bool behaviorFieldSpecified;
    private DescribeColor[] colorsField;
    private string contentField;
    private WebLinkType? contentSourceField;
    private bool contentSourceFieldSpecified;
    private bool customField;
    private string encodingField;
    private int? heightField;
    private bool heightFieldSpecified;
    private DescribeIcon[] iconsField;
    private string labelField;
    private bool? menubarField;
    private string nameField;
    private bool overriddenField;
    private bool? resizeableField;
    private bool? scrollbarsField;
    private bool? showsLocationField;
    private bool? showsStatusField;
    private bool? toolbarField;
    private string urlField;
    private int? widthField;
    private bool widthFieldSpecified;
    private WebLinkPosition? windowPositionField;
    private bool windowPositionFieldSpecified;

    [XmlElement(IsNullable = true)]
    public WebLinkWindowType? behavior
    {
      get => this.behaviorField;
      set => this.behaviorField = value;
    }

    [XmlIgnore]
    public bool behaviorSpecified
    {
      get => this.behaviorFieldSpecified;
      set => this.behaviorFieldSpecified = value;
    }

    [XmlElement("colors")]
    public DescribeColor[] colors
    {
      get => this.colorsField;
      set => this.colorsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string content
    {
      get => this.contentField;
      set => this.contentField = value;
    }

    [XmlElement(IsNullable = true)]
    public WebLinkType? contentSource
    {
      get => this.contentSourceField;
      set => this.contentSourceField = value;
    }

    [XmlIgnore]
    public bool contentSourceSpecified
    {
      get => this.contentSourceFieldSpecified;
      set => this.contentSourceFieldSpecified = value;
    }

    public bool custom
    {
      get => this.customField;
      set => this.customField = value;
    }

    [XmlElement(IsNullable = true)]
    public string encoding
    {
      get => this.encodingField;
      set => this.encodingField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? height
    {
      get => this.heightField;
      set => this.heightField = value;
    }

    [XmlIgnore]
    public bool heightSpecified
    {
      get => this.heightFieldSpecified;
      set => this.heightFieldSpecified = value;
    }

    [XmlElement("icons")]
    public DescribeIcon[] icons
    {
      get => this.iconsField;
      set => this.iconsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? menubar
    {
      get => this.menubarField;
      set => this.menubarField = value;
    }

    [XmlElement(IsNullable = true)]
    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public bool overridden
    {
      get => this.overriddenField;
      set => this.overriddenField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? resizeable
    {
      get => this.resizeableField;
      set => this.resizeableField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? scrollbars
    {
      get => this.scrollbarsField;
      set => this.scrollbarsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? showsLocation
    {
      get => this.showsLocationField;
      set => this.showsLocationField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? showsStatus
    {
      get => this.showsStatusField;
      set => this.showsStatusField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? toolbar
    {
      get => this.toolbarField;
      set => this.toolbarField = value;
    }

    [XmlElement(IsNullable = true)]
    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? width
    {
      get => this.widthField;
      set => this.widthField = value;
    }

    [XmlIgnore]
    public bool widthSpecified
    {
      get => this.widthFieldSpecified;
      set => this.widthFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public WebLinkPosition? windowPosition
    {
      get => this.windowPositionField;
      set => this.windowPositionField = value;
    }

    [XmlIgnore]
    public bool windowPositionSpecified
    {
      get => this.windowPositionFieldSpecified;
      set => this.windowPositionFieldSpecified = value;
    }
  }
}
