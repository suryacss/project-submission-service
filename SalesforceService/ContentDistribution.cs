// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ContentDistribution
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
  public class ContentDistribution : sObject
  {
    private QueryResult contentDistributionViewsField;
    private string contentDocumentIdField;
    private ContentVersion contentVersionField;
    private string contentVersionIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string distributionPublicUrlField;
    private DateTime? expiryDateField;
    private bool expiryDateFieldSpecified;
    private DateTime? firstViewDateField;
    private bool firstViewDateFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastViewDateField;
    private bool lastViewDateFieldSpecified;
    private string nameField;
    private User ownerField;
    private string ownerIdField;
    private string passwordField;
    private bool? preferencesAllowOriginalDownloadField;
    private bool preferencesAllowOriginalDownloadFieldSpecified;
    private bool? preferencesAllowPDFDownloadField;
    private bool preferencesAllowPDFDownloadFieldSpecified;
    private bool? preferencesAllowViewInBrowserField;
    private bool preferencesAllowViewInBrowserFieldSpecified;
    private bool? preferencesExpiresField;
    private bool preferencesExpiresFieldSpecified;
    private bool? preferencesLinkLatestVersionField;
    private bool preferencesLinkLatestVersionFieldSpecified;
    private bool? preferencesNotifyOnVisitField;
    private bool preferencesNotifyOnVisitFieldSpecified;
    private bool? preferencesNotifyRndtnCompleteField;
    private bool preferencesNotifyRndtnCompleteFieldSpecified;
    private bool? preferencesPasswordRequiredField;
    private bool preferencesPasswordRequiredFieldSpecified;
    private ProjectSubmissionsSvcLib.SalesforceService.Name relatedRecordField;
    private string relatedRecordIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private int? viewCountField;
    private bool viewCountFieldSpecified;

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDistributionViews
    {
      get => this.contentDistributionViewsField;
      set => this.contentDistributionViewsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContentDocumentId
    {
      get => this.contentDocumentIdField;
      set => this.contentDocumentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ContentVersion ContentVersion
    {
      get => this.contentVersionField;
      set => this.contentVersionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContentVersionId
    {
      get => this.contentVersionIdField;
      set => this.contentVersionIdField = value;
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
    public string DistributionPublicUrl
    {
      get => this.distributionPublicUrlField;
      set => this.distributionPublicUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ExpiryDate
    {
      get => this.expiryDateField;
      set => this.expiryDateField = value;
    }

    [XmlIgnore]
    public bool ExpiryDateSpecified
    {
      get => this.expiryDateFieldSpecified;
      set => this.expiryDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? FirstViewDate
    {
      get => this.firstViewDateField;
      set => this.firstViewDateField = value;
    }

    [XmlIgnore]
    public bool FirstViewDateSpecified
    {
      get => this.firstViewDateFieldSpecified;
      set => this.firstViewDateFieldSpecified = value;
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
    public DateTime? LastViewDate
    {
      get => this.lastViewDateField;
      set => this.lastViewDateField = value;
    }

    [XmlIgnore]
    public bool LastViewDateSpecified
    {
      get => this.lastViewDateFieldSpecified;
      set => this.lastViewDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
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
    public string Password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesAllowOriginalDownload
    {
      get => this.preferencesAllowOriginalDownloadField;
      set => this.preferencesAllowOriginalDownloadField = value;
    }

    [XmlIgnore]
    public bool PreferencesAllowOriginalDownloadSpecified
    {
      get => this.preferencesAllowOriginalDownloadFieldSpecified;
      set => this.preferencesAllowOriginalDownloadFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesAllowPDFDownload
    {
      get => this.preferencesAllowPDFDownloadField;
      set => this.preferencesAllowPDFDownloadField = value;
    }

    [XmlIgnore]
    public bool PreferencesAllowPDFDownloadSpecified
    {
      get => this.preferencesAllowPDFDownloadFieldSpecified;
      set => this.preferencesAllowPDFDownloadFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesAllowViewInBrowser
    {
      get => this.preferencesAllowViewInBrowserField;
      set => this.preferencesAllowViewInBrowserField = value;
    }

    [XmlIgnore]
    public bool PreferencesAllowViewInBrowserSpecified
    {
      get => this.preferencesAllowViewInBrowserFieldSpecified;
      set => this.preferencesAllowViewInBrowserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesExpires
    {
      get => this.preferencesExpiresField;
      set => this.preferencesExpiresField = value;
    }

    [XmlIgnore]
    public bool PreferencesExpiresSpecified
    {
      get => this.preferencesExpiresFieldSpecified;
      set => this.preferencesExpiresFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesLinkLatestVersion
    {
      get => this.preferencesLinkLatestVersionField;
      set => this.preferencesLinkLatestVersionField = value;
    }

    [XmlIgnore]
    public bool PreferencesLinkLatestVersionSpecified
    {
      get => this.preferencesLinkLatestVersionFieldSpecified;
      set => this.preferencesLinkLatestVersionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesNotifyOnVisit
    {
      get => this.preferencesNotifyOnVisitField;
      set => this.preferencesNotifyOnVisitField = value;
    }

    [XmlIgnore]
    public bool PreferencesNotifyOnVisitSpecified
    {
      get => this.preferencesNotifyOnVisitFieldSpecified;
      set => this.preferencesNotifyOnVisitFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesNotifyRndtnComplete
    {
      get => this.preferencesNotifyRndtnCompleteField;
      set => this.preferencesNotifyRndtnCompleteField = value;
    }

    [XmlIgnore]
    public bool PreferencesNotifyRndtnCompleteSpecified
    {
      get => this.preferencesNotifyRndtnCompleteFieldSpecified;
      set => this.preferencesNotifyRndtnCompleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesPasswordRequired
    {
      get => this.preferencesPasswordRequiredField;
      set => this.preferencesPasswordRequiredField = value;
    }

    [XmlIgnore]
    public bool PreferencesPasswordRequiredSpecified
    {
      get => this.preferencesPasswordRequiredFieldSpecified;
      set => this.preferencesPasswordRequiredFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name RelatedRecord
    {
      get => this.relatedRecordField;
      set => this.relatedRecordField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelatedRecordId
    {
      get => this.relatedRecordIdField;
      set => this.relatedRecordIdField = value;
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
    public int? ViewCount
    {
      get => this.viewCountField;
      set => this.viewCountField = value;
    }

    [XmlIgnore]
    public bool ViewCountSpecified
    {
      get => this.viewCountFieldSpecified;
      set => this.viewCountFieldSpecified = value;
    }
  }
}
