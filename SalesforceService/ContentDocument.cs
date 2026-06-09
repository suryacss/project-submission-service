// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ContentDocument
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class ContentDocument : sObject
  {
    private string archivedByIdField;
    private DateTime? archivedDateField;
    private bool archivedDateFieldSpecified;
    private ContentAsset contentAssetField;
    private string contentAssetIdField;
    private QueryResult contentDistributionsField;
    private QueryResult contentDocumentLinksField;
    private DateTime? contentModifiedDateField;
    private bool contentModifiedDateFieldSpecified;
    private int? contentSizeField;
    private bool contentSizeFieldSpecified;
    private QueryResult contentVersionsField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private string fileExtensionField;
    private string fileTypeField;
    private QueryResult historiesField;
    private bool? isArchivedField;
    private bool isArchivedFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private ContentVersion latestPublishedVersionField;
    private string latestPublishedVersionIdField;
    private User ownerField;
    private string ownerIdField;
    private string publishStatusField;
    private string sharingOptionField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string titleField;
    private QueryResult topicAssignmentsField;

    [XmlElement(IsNullable = true)]
    public string ArchivedById
    {
      get => this.archivedByIdField;
      set => this.archivedByIdField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ArchivedDate
    {
      get => this.archivedDateField;
      set => this.archivedDateField = value;
    }

    [XmlIgnore]
    public bool ArchivedDateSpecified
    {
      get => this.archivedDateFieldSpecified;
      set => this.archivedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public ContentAsset ContentAsset
    {
      get => this.contentAssetField;
      set => this.contentAssetField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContentAssetId
    {
      get => this.contentAssetIdField;
      set => this.contentAssetIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDistributions
    {
      get => this.contentDistributionsField;
      set => this.contentDistributionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ContentModifiedDate
    {
      get => this.contentModifiedDateField;
      set => this.contentModifiedDateField = value;
    }

    [XmlIgnore]
    public bool ContentModifiedDateSpecified
    {
      get => this.contentModifiedDateFieldSpecified;
      set => this.contentModifiedDateFieldSpecified = value;
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
    public QueryResult ContentVersions
    {
      get => this.contentVersionsField;
      set => this.contentVersionsField = value;
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
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Feeds
    {
      get => this.feedsField;
      set => this.feedsField = value;
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
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsArchived
    {
      get => this.isArchivedField;
      set => this.isArchivedField = value;
    }

    [XmlIgnore]
    public bool IsArchivedSpecified
    {
      get => this.isArchivedFieldSpecified;
      set => this.isArchivedFieldSpecified = value;
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
    public ContentVersion LatestPublishedVersion
    {
      get => this.latestPublishedVersionField;
      set => this.latestPublishedVersionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LatestPublishedVersionId
    {
      get => this.latestPublishedVersionIdField;
      set => this.latestPublishedVersionIdField = value;
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
    public string PublishStatus
    {
      get => this.publishStatusField;
      set => this.publishStatusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SharingOption
    {
      get => this.sharingOptionField;
      set => this.sharingOptionField = value;
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
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }
  }
}
