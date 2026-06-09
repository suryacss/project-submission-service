// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Asset
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class Asset : sObject
  {
    private Account accountField;
    private string accountIdField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private QueryResult casesField;
    private QueryResult childAssetsField;
    private QueryResult combinedAttachmentsField;
    private Contact contactField;
    private string contactIdField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private QueryResult historiesField;
    private DateTime? installDateField;
    private bool installDateFieldSpecified;
    private bool? isCompetitorProductField;
    private bool isCompetitorProductFieldSpecified;
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
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private QueryResult openActivitiesField;
    private Asset parentField;
    private string parentIdField;
    private double? priceField;
    private bool priceFieldSpecified;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private Product2 product2Field;
    private string product2IdField;
    private DateTime? purchaseDateField;
    private bool purchaseDateFieldSpecified;
    private double? quantityField;
    private bool quantityFieldSpecified;
    private Asset rootAssetField;
    private string rootAssetIdField;
    private string serialNumberField;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private DateTime? usageEndDateField;
    private bool usageEndDateFieldSpecified;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public Account Account
    {
      get => this.accountField;
      set => this.accountField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AccountId
    {
      get => this.accountIdField;
      set => this.accountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
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
    public QueryResult Cases
    {
      get => this.casesField;
      set => this.casesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ChildAssets
    {
      get => this.childAssetsField;
      set => this.childAssetsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Contact Contact
    {
      get => this.contactField;
      set => this.contactField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContactId
    {
      get => this.contactIdField;
      set => this.contactIdField = value;
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
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Events
    {
      get => this.eventsField;
      set => this.eventsField = value;
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
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? InstallDate
    {
      get => this.installDateField;
      set => this.installDateField = value;
    }

    [XmlIgnore]
    public bool InstallDateSpecified
    {
      get => this.installDateFieldSpecified;
      set => this.installDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsCompetitorProduct
    {
      get => this.isCompetitorProductField;
      set => this.isCompetitorProductField = value;
    }

    [XmlIgnore]
    public bool IsCompetitorProductSpecified
    {
      get => this.isCompetitorProductFieldSpecified;
      set => this.isCompetitorProductFieldSpecified = value;
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
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Notes
    {
      get => this.notesField;
      set => this.notesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult NotesAndAttachments
    {
      get => this.notesAndAttachmentsField;
      set => this.notesAndAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public Asset Parent
    {
      get => this.parentField;
      set => this.parentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentId
    {
      get => this.parentIdField;
      set => this.parentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Price
    {
      get => this.priceField;
      set => this.priceField = value;
    }

    [XmlIgnore]
    public bool PriceSpecified
    {
      get => this.priceFieldSpecified;
      set => this.priceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessInstances
    {
      get => this.processInstancesField;
      set => this.processInstancesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessSteps
    {
      get => this.processStepsField;
      set => this.processStepsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Product2 Product2
    {
      get => this.product2Field;
      set => this.product2Field = value;
    }

    [XmlElement(IsNullable = true)]
    public string Product2Id
    {
      get => this.product2IdField;
      set => this.product2IdField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? PurchaseDate
    {
      get => this.purchaseDateField;
      set => this.purchaseDateField = value;
    }

    [XmlIgnore]
    public bool PurchaseDateSpecified
    {
      get => this.purchaseDateFieldSpecified;
      set => this.purchaseDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Quantity
    {
      get => this.quantityField;
      set => this.quantityField = value;
    }

    [XmlIgnore]
    public bool QuantitySpecified
    {
      get => this.quantityFieldSpecified;
      set => this.quantityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public Asset RootAsset
    {
      get => this.rootAssetField;
      set => this.rootAssetField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RootAssetId
    {
      get => this.rootAssetIdField;
      set => this.rootAssetIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SerialNumber
    {
      get => this.serialNumberField;
      set => this.serialNumberField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
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
    public QueryResult Tasks
    {
      get => this.tasksField;
      set => this.tasksField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? UsageEndDate
    {
      get => this.usageEndDateField;
      set => this.usageEndDateField = value;
    }

    [XmlIgnore]
    public bool UsageEndDateSpecified
    {
      get => this.usageEndDateFieldSpecified;
      set => this.usageEndDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
