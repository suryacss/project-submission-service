// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Order
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
  public class Order : sObject
  {
    private Account accountField;
    private string accountIdField;
    private User activatedByField;
    private string activatedByIdField;
    private DateTime? activatedDateField;
    private bool activatedDateFieldSpecified;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private address billingAddressField;
    private string billingCityField;
    private string billingCountryField;
    private string billingGeocodeAccuracyField;
    private double? billingLatitudeField;
    private bool billingLatitudeFieldSpecified;
    private double? billingLongitudeField;
    private bool billingLongitudeFieldSpecified;
    private string billingPostalCodeField;
    private string billingStateField;
    private string billingStreetField;
    private QueryResult combinedAttachmentsField;
    private User companyAuthorizedByField;
    private string companyAuthorizedByIdField;
    private QueryResult contentDocumentLinksField;
    private Contract contractField;
    private string contractIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private Contact customerAuthorizedByField;
    private string customerAuthorizedByIdField;
    private string descriptionField;
    private DateTime? effectiveDateField;
    private bool effectiveDateFieldSpecified;
    private QueryResult emailsField;
    private DateTime? endDateField;
    private bool endDateFieldSpecified;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private QueryResult historiesField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isReductionOrderField;
    private bool isReductionOrderFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private QueryResult openActivitiesField;
    private QueryResult orderItemsField;
    private string orderNumberField;
    private QueryResult ordersField;
    private Order originalOrderField;
    private string originalOrderIdField;
    private Name ownerField;
    private string ownerIdField;
    private Pricebook2 pricebook2Field;
    private string pricebook2IdField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult sharesField;
    private address shippingAddressField;
    private string shippingCityField;
    private string shippingCountryField;
    private string shippingGeocodeAccuracyField;
    private double? shippingLatitudeField;
    private bool shippingLatitudeFieldSpecified;
    private double? shippingLongitudeField;
    private bool shippingLongitudeFieldSpecified;
    private string shippingPostalCodeField;
    private string shippingStateField;
    private string shippingStreetField;
    private string statusField;
    private string statusCodeField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private double? totalAmountField;
    private bool totalAmountFieldSpecified;
    private string typeField;
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
    public User ActivatedBy
    {
      get => this.activatedByField;
      set => this.activatedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ActivatedById
    {
      get => this.activatedByIdField;
      set => this.activatedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ActivatedDate
    {
      get => this.activatedDateField;
      set => this.activatedDateField = value;
    }

    [XmlIgnore]
    public bool ActivatedDateSpecified
    {
      get => this.activatedDateFieldSpecified;
      set => this.activatedDateFieldSpecified = value;
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
    public address BillingAddress
    {
      get => this.billingAddressField;
      set => this.billingAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BillingCity
    {
      get => this.billingCityField;
      set => this.billingCityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BillingCountry
    {
      get => this.billingCountryField;
      set => this.billingCountryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BillingGeocodeAccuracy
    {
      get => this.billingGeocodeAccuracyField;
      set => this.billingGeocodeAccuracyField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? BillingLatitude
    {
      get => this.billingLatitudeField;
      set => this.billingLatitudeField = value;
    }

    [XmlIgnore]
    public bool BillingLatitudeSpecified
    {
      get => this.billingLatitudeFieldSpecified;
      set => this.billingLatitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? BillingLongitude
    {
      get => this.billingLongitudeField;
      set => this.billingLongitudeField = value;
    }

    [XmlIgnore]
    public bool BillingLongitudeSpecified
    {
      get => this.billingLongitudeFieldSpecified;
      set => this.billingLongitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string BillingPostalCode
    {
      get => this.billingPostalCodeField;
      set => this.billingPostalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BillingState
    {
      get => this.billingStateField;
      set => this.billingStateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BillingStreet
    {
      get => this.billingStreetField;
      set => this.billingStreetField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public User CompanyAuthorizedBy
    {
      get => this.companyAuthorizedByField;
      set => this.companyAuthorizedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CompanyAuthorizedById
    {
      get => this.companyAuthorizedByIdField;
      set => this.companyAuthorizedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
    }

    [XmlElement(IsNullable = true)]
    public Contract Contract
    {
      get => this.contractField;
      set => this.contractField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContractId
    {
      get => this.contractIdField;
      set => this.contractIdField = value;
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
    public Contact CustomerAuthorizedBy
    {
      get => this.customerAuthorizedByField;
      set => this.customerAuthorizedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CustomerAuthorizedById
    {
      get => this.customerAuthorizedByIdField;
      set => this.customerAuthorizedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? EffectiveDate
    {
      get => this.effectiveDateField;
      set => this.effectiveDateField = value;
    }

    [XmlIgnore]
    public bool EffectiveDateSpecified
    {
      get => this.effectiveDateFieldSpecified;
      set => this.effectiveDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? EndDate
    {
      get => this.endDateField;
      set => this.endDateField = value;
    }

    [XmlIgnore]
    public bool EndDateSpecified
    {
      get => this.endDateFieldSpecified;
      set => this.endDateFieldSpecified = value;
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
    public bool? IsReductionOrder
    {
      get => this.isReductionOrderField;
      set => this.isReductionOrderField = value;
    }

    [XmlIgnore]
    public bool IsReductionOrderSpecified
    {
      get => this.isReductionOrderFieldSpecified;
      set => this.isReductionOrderFieldSpecified = value;
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
    public QueryResult OrderItems
    {
      get => this.orderItemsField;
      set => this.orderItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OrderNumber
    {
      get => this.orderNumberField;
      set => this.orderNumberField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Orders
    {
      get => this.ordersField;
      set => this.ordersField = value;
    }

    [XmlElement(IsNullable = true)]
    public Order OriginalOrder
    {
      get => this.originalOrderField;
      set => this.originalOrderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OriginalOrderId
    {
      get => this.originalOrderIdField;
      set => this.originalOrderIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name Owner
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
    public Pricebook2 Pricebook2
    {
      get => this.pricebook2Field;
      set => this.pricebook2Field = value;
    }

    [XmlElement(IsNullable = true)]
    public string Pricebook2Id
    {
      get => this.pricebook2IdField;
      set => this.pricebook2IdField = value;
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
    public QueryResult Shares
    {
      get => this.sharesField;
      set => this.sharesField = value;
    }

    [XmlElement(IsNullable = true)]
    public address ShippingAddress
    {
      get => this.shippingAddressField;
      set => this.shippingAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ShippingCity
    {
      get => this.shippingCityField;
      set => this.shippingCityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ShippingCountry
    {
      get => this.shippingCountryField;
      set => this.shippingCountryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ShippingGeocodeAccuracy
    {
      get => this.shippingGeocodeAccuracyField;
      set => this.shippingGeocodeAccuracyField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ShippingLatitude
    {
      get => this.shippingLatitudeField;
      set => this.shippingLatitudeField = value;
    }

    [XmlIgnore]
    public bool ShippingLatitudeSpecified
    {
      get => this.shippingLatitudeFieldSpecified;
      set => this.shippingLatitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ShippingLongitude
    {
      get => this.shippingLongitudeField;
      set => this.shippingLongitudeField = value;
    }

    [XmlIgnore]
    public bool ShippingLongitudeSpecified
    {
      get => this.shippingLongitudeFieldSpecified;
      set => this.shippingLongitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ShippingPostalCode
    {
      get => this.shippingPostalCodeField;
      set => this.shippingPostalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ShippingState
    {
      get => this.shippingStateField;
      set => this.shippingStateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ShippingStreet
    {
      get => this.shippingStreetField;
      set => this.shippingStreetField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string StatusCode
    {
      get => this.statusCodeField;
      set => this.statusCodeField = value;
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

    [XmlElement(IsNullable = true)]
    public double? TotalAmount
    {
      get => this.totalAmountField;
      set => this.totalAmountField = value;
    }

    [XmlIgnore]
    public bool TotalAmountSpecified
    {
      get => this.totalAmountFieldSpecified;
      set => this.totalAmountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
