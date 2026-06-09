// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PlatformAction
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class PlatformAction : sObject
  {
    private string actionListContextField;
    private string actionTargetField;
    private string actionTargetTypeField;
    private string apiNameField;
    private string categoryField;
    private string confirmationMessageField;
    private string deviceFormatField;
    private string externalIdField;
    private string groupIdField;
    private string iconContentTypeField;
    private int? iconHeightField;
    private bool iconHeightFieldSpecified;
    private string iconUrlField;
    private int? iconWidthField;
    private bool iconWidthFieldSpecified;
    private string invocationStatusField;
    private User invokedByUserField;
    private string invokedByUserIdField;
    private bool? isGroupDefaultField;
    private bool isGroupDefaultFieldSpecified;
    private bool? isMassActionField;
    private bool isMassActionFieldSpecified;
    private string labelField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string primaryColorField;
    private string relatedListRecordIdField;
    private string relatedSourceEntityField;
    private string sectionField;
    private string sourceEntityField;
    private string subtypeField;
    private string typeField;

    [XmlElement(IsNullable = true)]
    public string ActionListContext
    {
      get => this.actionListContextField;
      set => this.actionListContextField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ActionTarget
    {
      get => this.actionTargetField;
      set => this.actionTargetField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ActionTargetType
    {
      get => this.actionTargetTypeField;
      set => this.actionTargetTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApiName
    {
      get => this.apiNameField;
      set => this.apiNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Category
    {
      get => this.categoryField;
      set => this.categoryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConfirmationMessage
    {
      get => this.confirmationMessageField;
      set => this.confirmationMessageField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeviceFormat
    {
      get => this.deviceFormatField;
      set => this.deviceFormatField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalId
    {
      get => this.externalIdField;
      set => this.externalIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GroupId
    {
      get => this.groupIdField;
      set => this.groupIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IconContentType
    {
      get => this.iconContentTypeField;
      set => this.iconContentTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? IconHeight
    {
      get => this.iconHeightField;
      set => this.iconHeightField = value;
    }

    [XmlIgnore]
    public bool IconHeightSpecified
    {
      get => this.iconHeightFieldSpecified;
      set => this.iconHeightFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string IconUrl
    {
      get => this.iconUrlField;
      set => this.iconUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? IconWidth
    {
      get => this.iconWidthField;
      set => this.iconWidthField = value;
    }

    [XmlIgnore]
    public bool IconWidthSpecified
    {
      get => this.iconWidthFieldSpecified;
      set => this.iconWidthFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string InvocationStatus
    {
      get => this.invocationStatusField;
      set => this.invocationStatusField = value;
    }

    [XmlElement(IsNullable = true)]
    public User InvokedByUser
    {
      get => this.invokedByUserField;
      set => this.invokedByUserField = value;
    }

    [XmlElement(IsNullable = true)]
    public string InvokedByUserId
    {
      get => this.invokedByUserIdField;
      set => this.invokedByUserIdField = value;
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
    public bool? IsMassAction
    {
      get => this.isMassActionField;
      set => this.isMassActionField = value;
    }

    [XmlIgnore]
    public bool IsMassActionSpecified
    {
      get => this.isMassActionFieldSpecified;
      set => this.isMassActionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Label
    {
      get => this.labelField;
      set => this.labelField = value;
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
    public string PrimaryColor
    {
      get => this.primaryColorField;
      set => this.primaryColorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelatedListRecordId
    {
      get => this.relatedListRecordIdField;
      set => this.relatedListRecordIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelatedSourceEntity
    {
      get => this.relatedSourceEntityField;
      set => this.relatedSourceEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Section
    {
      get => this.sectionField;
      set => this.sectionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceEntity
    {
      get => this.sourceEntityField;
      set => this.sourceEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Subtype
    {
      get => this.subtypeField;
      set => this.subtypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }
  }
}
