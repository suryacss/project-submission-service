// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeQuickActionResult
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
  public class DescribeQuickActionResult
  {
    private ShareAccessLevel? accessLevelRequiredField;
    private string actionEnumOrIdField;
    private string canvasApplicationIdField;
    private string canvasApplicationNameField;
    private DescribeColor[] colorsField;
    private string contextSobjectTypeField;
    private DescribeQuickActionDefaultValue[] defaultValuesField;
    private int? heightField;
    private string iconNameField;
    private string iconUrlField;
    private DescribeIcon[] iconsField;
    private string labelField;
    private DescribeLayoutSection layoutField;
    private string lightningComponentBundleIdField;
    private string lightningComponentBundleNameField;
    private string lightningComponentQualifiedNameField;
    private string miniIconUrlField;
    private string nameField;
    private bool showQuickActionLcHeaderField;
    private bool showQuickActionVfHeaderField;
    private string targetParentFieldField;
    private string targetRecordTypeIdField;
    private string targetSobjectTypeField;
    private string typeField;
    private string visualforcePageNameField;
    private string visualforcePageUrlField;
    private int? widthField;

    [XmlElement(IsNullable = true)]
    public ShareAccessLevel? accessLevelRequired
    {
      get => this.accessLevelRequiredField;
      set => this.accessLevelRequiredField = value;
    }

    public string actionEnumOrId
    {
      get => this.actionEnumOrIdField;
      set => this.actionEnumOrIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string canvasApplicationId
    {
      get => this.canvasApplicationIdField;
      set => this.canvasApplicationIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string canvasApplicationName
    {
      get => this.canvasApplicationNameField;
      set => this.canvasApplicationNameField = value;
    }

    [XmlElement("colors")]
    public DescribeColor[] colors
    {
      get => this.colorsField;
      set => this.colorsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string contextSobjectType
    {
      get => this.contextSobjectTypeField;
      set => this.contextSobjectTypeField = value;
    }

    [XmlElement("defaultValues", IsNullable = true)]
    public DescribeQuickActionDefaultValue[] defaultValues
    {
      get => this.defaultValuesField;
      set => this.defaultValuesField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? height
    {
      get => this.heightField;
      set => this.heightField = value;
    }

    [XmlElement(IsNullable = true)]
    public string iconName
    {
      get => this.iconNameField;
      set => this.iconNameField = value;
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

    [XmlElement(IsNullable = true)]
    public DescribeLayoutSection layout
    {
      get => this.layoutField;
      set => this.layoutField = value;
    }

    [XmlElement(IsNullable = true)]
    public string lightningComponentBundleId
    {
      get => this.lightningComponentBundleIdField;
      set => this.lightningComponentBundleIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string lightningComponentBundleName
    {
      get => this.lightningComponentBundleNameField;
      set => this.lightningComponentBundleNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string lightningComponentQualifiedName
    {
      get => this.lightningComponentQualifiedNameField;
      set => this.lightningComponentQualifiedNameField = value;
    }

    [XmlElement(IsNullable = true)]
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

    public bool showQuickActionLcHeader
    {
      get => this.showQuickActionLcHeaderField;
      set => this.showQuickActionLcHeaderField = value;
    }

    public bool showQuickActionVfHeader
    {
      get => this.showQuickActionVfHeaderField;
      set => this.showQuickActionVfHeaderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string targetParentField
    {
      get => this.targetParentFieldField;
      set => this.targetParentFieldField = value;
    }

    [XmlElement(IsNullable = true)]
    public string targetRecordTypeId
    {
      get => this.targetRecordTypeIdField;
      set => this.targetRecordTypeIdField = value;
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

    [XmlElement(IsNullable = true)]
    public string visualforcePageName
    {
      get => this.visualforcePageNameField;
      set => this.visualforcePageNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string visualforcePageUrl
    {
      get => this.visualforcePageUrlField;
      set => this.visualforcePageUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? width
    {
      get => this.widthField;
      set => this.widthField = value;
    }
  }
}
