// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EmailTemplate
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class EmailTemplate : sObject
  {
    private double? apiVersionField;
    private bool apiVersionFieldSpecified;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bodyField;
    private string brandTemplateIdField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private string developerNameField;
    private string encodingField;
    private Folder folderField;
    private string folderIdField;
    private string htmlValueField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastUsedDateField;
    private bool lastUsedDateFieldSpecified;
    private string markupField;
    private string nameField;
    private string namespacePrefixField;
    private User ownerField;
    private string ownerIdField;
    private string relatedEntityTypeField;
    private string subjectField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string templateStyleField;
    private string templateTypeField;
    private int? timesUsedField;
    private bool timesUsedFieldSpecified;
    private string uiTypeField;

    [XmlElement(IsNullable = true)]
    public double? ApiVersion
    {
      get => this.apiVersionField;
      set => this.apiVersionField = value;
    }

    [XmlIgnore]
    public bool ApiVersionSpecified
    {
      get => this.apiVersionFieldSpecified;
      set => this.apiVersionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Attachments
    {
      get => this.attachmentsField;
      set => this.attachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Body
    {
      get => this.bodyField;
      set => this.bodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BrandTemplateId
    {
      get => this.brandTemplateIdField;
      set => this.brandTemplateIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
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
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Encoding
    {
      get => this.encodingField;
      set => this.encodingField = value;
    }

    [XmlElement(IsNullable = true)]
    public Folder Folder
    {
      get => this.folderField;
      set => this.folderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FolderId
    {
      get => this.folderIdField;
      set => this.folderIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string HtmlValue
    {
      get => this.htmlValueField;
      set => this.htmlValueField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsActive
    {
      get => this.isActiveField;
      set => this.isActiveField = value;
    }

    [XmlIgnore]
    public bool IsActiveSpecified
    {
      get => this.isActiveFieldSpecified;
      set => this.isActiveFieldSpecified = value;
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
    public DateTime? LastUsedDate
    {
      get => this.lastUsedDateField;
      set => this.lastUsedDateField = value;
    }

    [XmlIgnore]
    public bool LastUsedDateSpecified
    {
      get => this.lastUsedDateFieldSpecified;
      set => this.lastUsedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Markup
    {
      get => this.markupField;
      set => this.markupField = value;
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
    public User Owner
    {
      get => this.ownerField;
      set => this.ownerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OwnerId
    {
      get => this.ownerIdField;
      set => this.ownerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelatedEntityType
    {
      get => this.relatedEntityTypeField;
      set => this.relatedEntityTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Subject
    {
      get => this.subjectField;
      set => this.subjectField = value;
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
    public string TemplateStyle
    {
      get => this.templateStyleField;
      set => this.templateStyleField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TemplateType
    {
      get => this.templateTypeField;
      set => this.templateTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? TimesUsed
    {
      get => this.timesUsedField;
      set => this.timesUsedField = value;
    }

    [XmlIgnore]
    public bool TimesUsedSpecified
    {
      get => this.timesUsedFieldSpecified;
      set => this.timesUsedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string UiType
    {
      get => this.uiTypeField;
      set => this.uiTypeField = value;
    }
  }
}
