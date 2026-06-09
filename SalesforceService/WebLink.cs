// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.WebLink
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class WebLink : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private string displayTypeField;
    private string encodingKeyField;
    private bool? hasMenubarField;
    private bool hasMenubarFieldSpecified;
    private bool? hasScrollbarsField;
    private bool hasScrollbarsFieldSpecified;
    private bool? hasToolbarField;
    private bool hasToolbarFieldSpecified;
    private int? heightField;
    private bool heightFieldSpecified;
    private bool? isProtectedField;
    private bool isProtectedFieldSpecified;
    private bool? isResizableField;
    private bool isResizableFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string linkTypeField;
    private string masterLabelField;
    private string nameField;
    private string namespacePrefixField;
    private string openTypeField;
    private string pageOrSobjectTypeField;
    private string positionField;
    private bool? requireRowSelectionField;
    private bool requireRowSelectionFieldSpecified;
    private string scontrolIdField;
    private bool? showsLocationField;
    private bool showsLocationFieldSpecified;
    private bool? showsStatusField;
    private bool showsStatusFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string urlField;
    private int? widthField;
    private bool widthFieldSpecified;

    [XmlElement(IsNullable = true)]
    public User CreatedBy
    {
      get => this.createdByField;
      set => this.createdByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CreatedById
    {
      get => this.createdByIdField;
      set => this.createdByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? CreatedDate
    {
      get => this.createdDateField;
      set => this.createdDateField = value;
    }

    [XmlIgnore]
    public bool CreatedDateSpecified
    {
      get => this.createdDateFieldSpecified;
      set => this.createdDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DisplayType
    {
      get => this.displayTypeField;
      set => this.displayTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EncodingKey
    {
      get => this.encodingKeyField;
      set => this.encodingKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasMenubar
    {
      get => this.hasMenubarField;
      set => this.hasMenubarField = value;
    }

    [XmlIgnore]
    public bool HasMenubarSpecified
    {
      get => this.hasMenubarFieldSpecified;
      set => this.hasMenubarFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasScrollbars
    {
      get => this.hasScrollbarsField;
      set => this.hasScrollbarsField = value;
    }

    [XmlIgnore]
    public bool HasScrollbarsSpecified
    {
      get => this.hasScrollbarsFieldSpecified;
      set => this.hasScrollbarsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasToolbar
    {
      get => this.hasToolbarField;
      set => this.hasToolbarField = value;
    }

    [XmlIgnore]
    public bool HasToolbarSpecified
    {
      get => this.hasToolbarFieldSpecified;
      set => this.hasToolbarFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Height
    {
      get => this.heightField;
      set => this.heightField = value;
    }

    [XmlIgnore]
    public bool HeightSpecified
    {
      get => this.heightFieldSpecified;
      set => this.heightFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsProtected
    {
      get => this.isProtectedField;
      set => this.isProtectedField = value;
    }

    [XmlIgnore]
    public bool IsProtectedSpecified
    {
      get => this.isProtectedFieldSpecified;
      set => this.isProtectedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsResizable
    {
      get => this.isResizableField;
      set => this.isResizableField = value;
    }

    [XmlIgnore]
    public bool IsResizableSpecified
    {
      get => this.isResizableFieldSpecified;
      set => this.isResizableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User LastModifiedBy
    {
      get => this.lastModifiedByField;
      set => this.lastModifiedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastModifiedById
    {
      get => this.lastModifiedByIdField;
      set => this.lastModifiedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastModifiedDate
    {
      get => this.lastModifiedDateField;
      set => this.lastModifiedDateField = value;
    }

    [XmlIgnore]
    public bool LastModifiedDateSpecified
    {
      get => this.lastModifiedDateFieldSpecified;
      set => this.lastModifiedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LinkType
    {
      get => this.linkTypeField;
      set => this.linkTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MasterLabel
    {
      get => this.masterLabelField;
      set => this.masterLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OpenType
    {
      get => this.openTypeField;
      set => this.openTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PageOrSobjectType
    {
      get => this.pageOrSobjectTypeField;
      set => this.pageOrSobjectTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Position
    {
      get => this.positionField;
      set => this.positionField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? RequireRowSelection
    {
      get => this.requireRowSelectionField;
      set => this.requireRowSelectionField = value;
    }

    [XmlIgnore]
    public bool RequireRowSelectionSpecified
    {
      get => this.requireRowSelectionFieldSpecified;
      set => this.requireRowSelectionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ScontrolId
    {
      get => this.scontrolIdField;
      set => this.scontrolIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ShowsLocation
    {
      get => this.showsLocationField;
      set => this.showsLocationField = value;
    }

    [XmlIgnore]
    public bool ShowsLocationSpecified
    {
      get => this.showsLocationFieldSpecified;
      set => this.showsLocationFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ShowsStatus
    {
      get => this.showsStatusField;
      set => this.showsStatusField = value;
    }

    [XmlIgnore]
    public bool ShowsStatusSpecified
    {
      get => this.showsStatusFieldSpecified;
      set => this.showsStatusFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SystemModstamp
    {
      get => this.systemModstampField;
      set => this.systemModstampField = value;
    }

    [XmlIgnore]
    public bool SystemModstampSpecified
    {
      get => this.systemModstampFieldSpecified;
      set => this.systemModstampFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Width
    {
      get => this.widthField;
      set => this.widthField = value;
    }

    [XmlIgnore]
    public bool WidthSpecified
    {
      get => this.widthFieldSpecified;
      set => this.widthFieldSpecified = value;
    }
  }
}
