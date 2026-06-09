// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ActionLinkTemplate
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ActionLinkTemplate : sObject
  {
    private ActionLinkGroupTemplate actionLinkGroupTemplateField;
    private string actionLinkGroupTemplateIdField;
    private string actionUrlField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string headersField;
    private bool? isConfirmationRequiredField;
    private bool isConfirmationRequiredFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isGroupDefaultField;
    private bool isGroupDefaultFieldSpecified;
    private string labelField;
    private string labelKeyField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string linkTypeField;
    private string methodField;
    private int? positionField;
    private bool positionFieldSpecified;
    private string requestBodyField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string userAliasField;
    private string userVisibilityField;

    [XmlElement(IsNullable = true)]
    public ActionLinkGroupTemplate ActionLinkGroupTemplate
    {
      get => this.actionLinkGroupTemplateField;
      set => this.actionLinkGroupTemplateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ActionLinkGroupTemplateId
    {
      get => this.actionLinkGroupTemplateIdField;
      set => this.actionLinkGroupTemplateIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ActionUrl
    {
      get => this.actionUrlField;
      set => this.actionUrlField = value;
    }

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
    public string Headers
    {
      get => this.headersField;
      set => this.headersField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsConfirmationRequired
    {
      get => this.isConfirmationRequiredField;
      set => this.isConfirmationRequiredField = value;
    }

    [XmlIgnore]
    public bool IsConfirmationRequiredSpecified
    {
      get => this.isConfirmationRequiredFieldSpecified;
      set => this.isConfirmationRequiredFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeleted
    {
      get => this.isDeletedField;
      set => this.isDeletedField = value;
    }

    [XmlIgnore]
    public bool IsDeletedSpecified
    {
      get => this.isDeletedFieldSpecified;
      set => this.isDeletedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsGroupDefault
    {
      get => this.isGroupDefaultField;
      set => this.isGroupDefaultField = value;
    }

    [XmlIgnore]
    public bool IsGroupDefaultSpecified
    {
      get => this.isGroupDefaultFieldSpecified;
      set => this.isGroupDefaultFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LabelKey
    {
      get => this.labelKeyField;
      set => this.labelKeyField = value;
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
    public string Method
    {
      get => this.methodField;
      set => this.methodField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Position
    {
      get => this.positionField;
      set => this.positionField = value;
    }

    [XmlIgnore]
    public bool PositionSpecified
    {
      get => this.positionFieldSpecified;
      set => this.positionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RequestBody
    {
      get => this.requestBodyField;
      set => this.requestBodyField = value;
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
    public string UserAlias
    {
      get => this.userAliasField;
      set => this.userAliasField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserVisibility
    {
      get => this.userVisibilityField;
      set => this.userVisibilityField = value;
    }
  }
}
