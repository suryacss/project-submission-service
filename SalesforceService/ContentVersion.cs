// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ContentVersion
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
  public class ContentVersion : sObject
  {
    private string checksumField;
    private ContentDocument contentDocumentField;
    private string contentDocumentIdField;
    private string contentLocationField;
    private User contentModifiedByField;
    private string contentModifiedByIdField;
    private DateTime? contentModifiedDateField;
    private bool contentModifiedDateFieldSpecified;
    private int? contentSizeField;
    private bool contentSizeFieldSpecified;
    private string contentUrlField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private ExternalDataSource externalDataSourceField;
    private string externalDataSourceIdField;
    private string externalDocumentInfo1Field;
    private string externalDocumentInfo2Field;
    private int? featuredContentBoostField;
    private bool featuredContentBoostFieldSpecified;
    private DateTime? featuredContentDateField;
    private bool featuredContentDateFieldSpecified;
    private string fileExtensionField;
    private string fileTypeField;
    private Name firstPublishLocationField;
    private string firstPublishLocationIdField;
    private QueryResult historiesField;
    private bool? isAssetEnabledField;
    private bool isAssetEnabledFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isLatestField;
    private bool isLatestFieldSpecified;
    private bool? isMajorVersionField;
    private bool isMajorVersionFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private int? negativeRatingCountField;
    private bool negativeRatingCountFieldSpecified;
    private string originField;
    private User ownerField;
    private string ownerIdField;
    private string pathOnClientField;
    private int? positiveRatingCountField;
    private bool positiveRatingCountFieldSpecified;
    private string publishStatusField;
    private int? ratingCountField;
    private bool ratingCountFieldSpecified;
    private string reasonForChangeField;
    private string sharingOptionField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string tagCsvField;
    private string textPreviewField;
    private string titleField;
    private byte[] versionDataField;
    private string versionNumberField;

    [XmlElement(IsNullable = true)]
    public string Checksum
    {
      get => this.checksumField;
      set => this.checksumField = value;
    }

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
    public string ContentLocation
    {
      get => this.contentLocationField;
      set => this.contentLocationField = value;
    }

    [XmlElement(IsNullable = true)]
    public User ContentModifiedBy
    {
      get => this.contentModifiedByField;
      set => this.contentModifiedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContentModifiedById
    {
      get => this.contentModifiedByIdField;
      set => this.contentModifiedByIdField = value;
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
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public ExternalDataSource ExternalDataSource
    {
      get => this.externalDataSourceField;
      set => this.externalDataSourceField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalDataSourceId
    {
      get => this.externalDataSourceIdField;
      set => this.externalDataSourceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalDocumentInfo1
    {
      get => this.externalDocumentInfo1Field;
      set => this.externalDocumentInfo1Field = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalDocumentInfo2
    {
      get => this.externalDocumentInfo2Field;
      set => this.externalDocumentInfo2Field = value;
    }

    [XmlElement(IsNullable = true)]
    public int? FeaturedContentBoost
    {
      get => this.featuredContentBoostField;
      set => this.featuredContentBoostField = value;
    }

    [XmlIgnore]
    public bool FeaturedContentBoostSpecified
    {
      get => this.featuredContentBoostFieldSpecified;
      set => this.featuredContentBoostFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? FeaturedContentDate
    {
      get => this.featuredContentDateField;
      set => this.featuredContentDateField = value;
    }

    [XmlIgnore]
    public bool FeaturedContentDateSpecified
    {
      get => this.featuredContentDateFieldSpecified;
      set => this.featuredContentDateFieldSpecified = value;
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
    public Name FirstPublishLocation
    {
      get => this.firstPublishLocationField;
      set => this.firstPublishLocationField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FirstPublishLocationId
    {
      get => this.firstPublishLocationIdField;
      set => this.firstPublishLocationIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsAssetEnabled
    {
      get => this.isAssetEnabledField;
      set => this.isAssetEnabledField = value;
    }

    [XmlIgnore]
    public bool IsAssetEnabledSpecified
    {
      get => this.isAssetEnabledFieldSpecified;
      set => this.isAssetEnabledFieldSpecified = value;
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
    public bool? IsLatest
    {
      get => this.isLatestField;
      set => this.isLatestField = value;
    }

    [XmlIgnore]
    public bool IsLatestSpecified
    {
      get => this.isLatestFieldSpecified;
      set => this.isLatestFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsMajorVersion
    {
      get => this.isMajorVersionField;
      set => this.isMajorVersionField = value;
    }

    [XmlIgnore]
    public bool IsMajorVersionSpecified
    {
      get => this.isMajorVersionFieldSpecified;
      set => this.isMajorVersionFieldSpecified = value;
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
    public int? NegativeRatingCount
    {
      get => this.negativeRatingCountField;
      set => this.negativeRatingCountField = value;
    }

    [XmlIgnore]
    public bool NegativeRatingCountSpecified
    {
      get => this.negativeRatingCountFieldSpecified;
      set => this.negativeRatingCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Origin
    {
      get => this.originField;
      set => this.originField = value;
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
    public string PathOnClient
    {
      get => this.pathOnClientField;
      set => this.pathOnClientField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? PositiveRatingCount
    {
      get => this.positiveRatingCountField;
      set => this.positiveRatingCountField = value;
    }

    [XmlIgnore]
    public bool PositiveRatingCountSpecified
    {
      get => this.positiveRatingCountFieldSpecified;
      set => this.positiveRatingCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PublishStatus
    {
      get => this.publishStatusField;
      set => this.publishStatusField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RatingCount
    {
      get => this.ratingCountField;
      set => this.ratingCountField = value;
    }

    [XmlIgnore]
    public bool RatingCountSpecified
    {
      get => this.ratingCountFieldSpecified;
      set => this.ratingCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ReasonForChange
    {
      get => this.reasonForChangeField;
      set => this.reasonForChangeField = value;
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
    public string TagCsv
    {
      get => this.tagCsvField;
      set => this.tagCsvField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TextPreview
    {
      get => this.textPreviewField;
      set => this.textPreviewField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }

    [XmlElement(DataType = "base64Binary", IsNullable = true)]
    public byte[] VersionData
    {
      get => this.versionDataField;
      set => this.versionDataField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VersionNumber
    {
      get => this.versionNumberField;
      set => this.versionNumberField = value;
    }
  }
}
