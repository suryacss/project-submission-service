// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OrderItem
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class OrderItem : sObject
  {
    private QueryResult attachedContentDocumentsField;
    private double? availableQuantityField;
    private bool availableQuantityFieldSpecified;
    private QueryResult childOrderItemsField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private QueryResult historiesField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private double? listPriceField;
    private bool listPriceFieldSpecified;
    private Order orderField;
    private string orderIdField;
    private string orderItemNumberField;
    private OrderItem originalOrderItemField;
    private string originalOrderItemIdField;
    private PricebookEntry pricebookEntryField;
    private string pricebookEntryIdField;
    private Product2 product2Field;
    private string product2IdField;
    private double? quantityField;
    private bool quantityFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private double? unitPriceField;
    private bool unitPriceFieldSpecified;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AvailableQuantity
    {
      get => this.availableQuantityField;
      set => this.availableQuantityField = value;
    }

    [XmlIgnore]
    public bool AvailableQuantitySpecified
    {
      get => this.availableQuantityFieldSpecified;
      set => this.availableQuantityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ChildOrderItems
    {
      get => this.childOrderItemsField;
      set => this.childOrderItemsField = value;
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
    public double? ListPrice
    {
      get => this.listPriceField;
      set => this.listPriceField = value;
    }

    [XmlIgnore]
    public bool ListPriceSpecified
    {
      get => this.listPriceFieldSpecified;
      set => this.listPriceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public Order Order
    {
      get => this.orderField;
      set => this.orderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OrderId
    {
      get => this.orderIdField;
      set => this.orderIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OrderItemNumber
    {
      get => this.orderItemNumberField;
      set => this.orderItemNumberField = value;
    }

    [XmlElement(IsNullable = true)]
    public OrderItem OriginalOrderItem
    {
      get => this.originalOrderItemField;
      set => this.originalOrderItemField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OriginalOrderItemId
    {
      get => this.originalOrderItemIdField;
      set => this.originalOrderItemIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public PricebookEntry PricebookEntry
    {
      get => this.pricebookEntryField;
      set => this.pricebookEntryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PricebookEntryId
    {
      get => this.pricebookEntryIdField;
      set => this.pricebookEntryIdField = value;
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
    public double? UnitPrice
    {
      get => this.unitPriceField;
      set => this.unitPriceField = value;
    }

    [XmlIgnore]
    public bool UnitPriceSpecified
    {
      get => this.unitPriceFieldSpecified;
      set => this.unitPriceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
