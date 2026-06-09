// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OwnedContentDocument
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class OwnedContentDocument : sObject
  {
    private ContentDocument contentDocumentField;
    private string contentDocumentIdField;
    private int? contentSizeField;
    private bool contentSizeFieldSpecified;
    private string contentUrlField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string externalDataSourceNameField;
    private string externalDataSourceTypeField;
    private string fileExtensionField;
    private string fileTypeField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private User ownerField;
    private string ownerIdField;
    private string titleField;

    [XmlElement(IsNullable = true)]
    public ContentDocument ContentDocument
    {
      get => this.contentDocumentField;
      set => this.contentDocumentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContentDocumentId
    {
      get => this.contentDocumentIdField;
      set => this.contentDocumentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? ContentSize
    {
      get => this.contentSizeField;
      set => this.contentSizeField = value;
    }

    [XmlIgnore]
    public bool ContentSizeSpecified
    {
      get => this.contentSizeFieldSpecified;
      set => this.contentSizeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContentUrl
    {
      get => this.contentUrlField;
      set => this.contentUrlField = value;
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
    public string ExternalDataSourceName
    {
      get => this.externalDataSourceNameField;
      set => this.externalDataSourceNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalDataSourceType
    {
      get => this.externalDataSourceTypeField;
      set => this.externalDataSourceTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FileExtension
    {
      get => this.fileExtensionField;
      set => this.fileExtensionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FileType
    {
      get => this.fileTypeField;
      set => this.fileTypeField = value;
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
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }
  }
}
