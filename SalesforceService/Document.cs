// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Document
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class Document : sObject
  {
    private User authorField;
    private string authorIdField;
    private byte[] bodyField;
    private int? bodyLengthField;
    private bool bodyLengthFieldSpecified;
    private string contentTypeField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private string developerNameField;
    private Folder folderField;
    private string folderIdField;
    private bool? isBodySearchableField;
    private bool isBodySearchableFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isInternalUseOnlyField;
    private bool isInternalUseOnlyFieldSpecified;
    private bool? isPublicField;
    private bool isPublicFieldSpecified;
    private string keywordsField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private string nameField;
    private string namespacePrefixField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string typeField;
    private string urlField;

    [XmlElement(IsNullable = true)]
    public User Author
    {
      get => this.authorField;
      set => this.authorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AuthorId
    {
      get => this.authorIdField;
      set => this.authorIdField = value;
    }

    [XmlElement(DataType = "base64Binary", IsNullable = true)]
    public byte[] Body
    {
      get => this.bodyField;
      set => this.bodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? BodyLength
    {
      get => this.bodyLengthField;
      set => this.bodyLengthField = value;
    }

    [XmlIgnore]
    public bool BodyLengthSpecified
    {
      get => this.bodyLengthFieldSpecified;
      set => this.bodyLengthFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContentType
    {
      get => this.contentTypeField;
      set => this.contentTypeField = value;
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
    public bool? IsBodySearchable
    {
      get => this.isBodySearchableField;
      set => this.isBodySearchableField = value;
    }

    [XmlIgnore]
    public bool IsBodySearchableSpecified
    {
      get => this.isBodySearchableFieldSpecified;
      set => this.isBodySearchableFieldSpecified = value;
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
    public bool? IsInternalUseOnly
    {
      get => this.isInternalUseOnlyField;
      set => this.isInternalUseOnlyField = value;
    }

    [XmlIgnore]
    public bool IsInternalUseOnlySpecified
    {
      get => this.isInternalUseOnlyFieldSpecified;
      set => this.isInternalUseOnlyFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsPublic
    {
      get => this.isPublicField;
      set => this.isPublicField = value;
    }

    [XmlIgnore]
    public bool IsPublicSpecified
    {
      get => this.isPublicFieldSpecified;
      set => this.isPublicFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Keywords
    {
      get => this.keywordsField;
      set => this.keywordsField = value;
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
    public DateTime? LastReferencedDate
    {
      get => this.lastReferencedDateField;
      set => this.lastReferencedDateField = value;
    }

    [XmlIgnore]
    public bool LastReferencedDateSpecified
    {
      get => this.lastReferencedDateFieldSpecified;
      set => this.lastReferencedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastViewedDate
    {
      get => this.lastViewedDateField;
      set => this.lastViewedDateField = value;
    }

    [XmlIgnore]
    public bool LastViewedDateSpecified
    {
      get => this.lastViewedDateFieldSpecified;
      set => this.lastViewedDateFieldSpecified = value;
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
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Url
    {
      get => this.urlField;
      set => this.urlField = value;
    }
  }
}
