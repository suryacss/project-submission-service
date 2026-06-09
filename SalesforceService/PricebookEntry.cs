// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PricebookEntry
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
  public class PricebookEntry : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string nameField;
    private QueryResult opportunityLineItemsField;
    private QueryResult orderItemsField;
    private Pricebook2 pricebook2Field;
    private string pricebook2IdField;
    private Product2 product2Field;
    private string product2IdField;
    private string productCodeField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private double? unitPriceField;
    private bool unitPriceFieldSpecified;
    private bool? useStandardPriceField;
    private bool useStandardPriceFieldSpecified;

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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpportunityLineItems
    {
      get => this.opportunityLineItemsField;
      set => this.opportunityLineItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OrderItems
    {
      get => this.orderItemsField;
      set => this.orderItemsField = value;
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
    public string ProductCode
    {
      get => this.productCodeField;
      set => this.productCodeField = value;
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
    public bool? UseStandardPrice
    {
      get => this.useStandardPriceField;
      set => this.useStandardPriceField = value;
    }

    [XmlIgnore]
    public bool UseStandardPriceSpecified
    {
      get => this.useStandardPriceFieldSpecified;
      set => this.useStandardPriceFieldSpecified = value;
    }
  }
}
