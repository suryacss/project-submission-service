// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.IFO_Win_Rate__c
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
  public class IFO_Win_Rate__c : sObject
  {
    private QueryResult activityHistoriesField;
    private string analyst__cField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bandwidthCapacity__cField;
    private string bandwidthDesc__cField;
    private string bandwidthEthernet__cField;
    private double? catalogBandwidthId__cField;
    private bool catalogBandwidthId__cFieldSpecified;
    private double? catalogProductId__cField;
    private bool catalogProductId__cFieldSpecified;
    private string channel__cField;
    private QueryResult combinedAttachmentsField;
    private string companyName__cField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string currencyCode__cField;
    private string currentStatus__cField;
    private double? discountedMrc__cField;
    private bool discountedMrc__cFieldSpecified;
    private double? discountedNrc__cField;
    private bool discountedNrc__cFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private QueryResult emailsField;
    private DateTime? entityLineItemCreateDate__cField;
    private bool entityLineItemCreateDate__cFieldSpecified;
    private double? entityLineItemId__cField;
    private bool entityLineItemId__cFieldSpecified;
    private DateTime? entityLineItemPriceCreateDate__cField;
    private bool entityLineItemPriceCreateDate__cFieldSpecified;
    private double? entityLineItemPriceId__cField;
    private bool entityLineItemPriceId__cFieldSpecified;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult historiesField;
    private double? incrementalMrCost__cField;
    private bool incrementalMrCost__cFieldSpecified;
    private double? incrementalNrCost__cField;
    private bool incrementalNrCost__cFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private double? isLineItemWin__cField;
    private bool isLineItemWin__cFieldSpecified;
    private double? isWin__cField;
    private bool isWin__cFieldSpecified;
    private DateTime? lastActivityDateField;
    private bool lastActivityDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private string lata__cField;
    private string lineItemType__cField;
    private string locationID__cField;
    private QueryResult lookedUpFromActivitiesField;
    private QueryResult mSO_PROPOSAL_XREFS__rField;
    private double? mrcUSD__cField;
    private bool mrcUSD__cFieldSpecified;
    private double? mrc__cField;
    private bool mrc__cFieldSpecified;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private double? nrcUSD__cField;
    private bool nrcUSD__cFieldSpecified;
    private double? nrc__cField;
    private bool nrc__cFieldSpecified;
    private QueryResult openActivitiesField;
    private double? orderQuoteId__cField;
    private bool orderQuoteId__cFieldSpecified;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private DateTime? priceDealCreateDate__cField;
    private bool priceDealCreateDate__cFieldSpecified;
    private string priceDealEntityLineItemId__cField;
    private double? priceDealId__cField;
    private bool priceDealId__cFieldSpecified;
    private string priceOriginDesc__cField;
    private double? priceOriginId__cField;
    private bool priceOriginId__cFieldSpecified;
    private string priceTermId__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string productDesc__cField;
    private DateTime? proposalSentDate__cField;
    private bool proposalSentDate__cFieldSpecified;
    private string quoteCreateDate__cField;
    private QueryResult recordAssociatedGroupsField;
    private string reportRegion__cField;
    private double? sI_aging__cField;
    private bool sI_aging__cFieldSpecified;
    private string sWC__cField;
    private string salesRep__cField;
    private string sfdcOpportunityId__cField;
    private string sfdcOpportunityStatus__cField;
    private string solutionId__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private double? trackingNumber__cField;
    private bool trackingNumber__cFieldSpecified;
    private UserRecordAccess userRecordAccessField;
    private string vendor_Type__cField;
    private string vendor__cField;
    private string zside_Address1__cField;
    private string zside_Address2__cField;
    private string zside_City__cField;
    private string zside_Country__cField;
    private string zside_Latitude__cField;
    private string zside_Longitude__cField;
    private string zside_PostalCode__cField;
    private string zside_Premise__cField;
    private string zside_State__cField;
    private string zside_Street__cField;

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Analyst__c
    {
      get => this.analyst__cField;
      set => this.analyst__cField = value;
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
    public string BandwidthCapacity__c
    {
      get => this.bandwidthCapacity__cField;
      set => this.bandwidthCapacity__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BandwidthDesc__c
    {
      get => this.bandwidthDesc__cField;
      set => this.bandwidthDesc__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BandwidthEthernet__c
    {
      get => this.bandwidthEthernet__cField;
      set => this.bandwidthEthernet__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CatalogBandwidthId__c
    {
      get => this.catalogBandwidthId__cField;
      set => this.catalogBandwidthId__cField = value;
    }

    [XmlIgnore]
    public bool CatalogBandwidthId__cSpecified
    {
      get => this.catalogBandwidthId__cFieldSpecified;
      set => this.catalogBandwidthId__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CatalogProductId__c
    {
      get => this.catalogProductId__cField;
      set => this.catalogProductId__cField = value;
    }

    [XmlIgnore]
    public bool CatalogProductId__cSpecified
    {
      get => this.catalogProductId__cFieldSpecified;
      set => this.catalogProductId__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Channel__c
    {
      get => this.channel__cField;
      set => this.channel__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CompanyName__c
    {
      get => this.companyName__cField;
      set => this.companyName__cField = value;
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
    public string CurrencyCode__c
    {
      get => this.currencyCode__cField;
      set => this.currencyCode__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CurrentStatus__c
    {
      get => this.currentStatus__cField;
      set => this.currentStatus__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? DiscountedMrc__c
    {
      get => this.discountedMrc__cField;
      set => this.discountedMrc__cField = value;
    }

    [XmlIgnore]
    public bool DiscountedMrc__cSpecified
    {
      get => this.discountedMrc__cFieldSpecified;
      set => this.discountedMrc__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? DiscountedNrc__c
    {
      get => this.discountedNrc__cField;
      set => this.discountedNrc__cField = value;
    }

    [XmlIgnore]
    public bool DiscountedNrc__cSpecified
    {
      get => this.discountedNrc__cFieldSpecified;
      set => this.discountedNrc__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? EntityLineItemCreateDate__c
    {
      get => this.entityLineItemCreateDate__cField;
      set => this.entityLineItemCreateDate__cField = value;
    }

    [XmlIgnore]
    public bool EntityLineItemCreateDate__cSpecified
    {
      get => this.entityLineItemCreateDate__cFieldSpecified;
      set => this.entityLineItemCreateDate__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? EntityLineItemId__c
    {
      get => this.entityLineItemId__cField;
      set => this.entityLineItemId__cField = value;
    }

    [XmlIgnore]
    public bool EntityLineItemId__cSpecified
    {
      get => this.entityLineItemId__cFieldSpecified;
      set => this.entityLineItemId__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? EntityLineItemPriceCreateDate__c
    {
      get => this.entityLineItemPriceCreateDate__cField;
      set => this.entityLineItemPriceCreateDate__cField = value;
    }

    [XmlIgnore]
    public bool EntityLineItemPriceCreateDate__cSpecified
    {
      get => this.entityLineItemPriceCreateDate__cFieldSpecified;
      set => this.entityLineItemPriceCreateDate__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? EntityLineItemPriceId__c
    {
      get => this.entityLineItemPriceId__cField;
      set => this.entityLineItemPriceId__cField = value;
    }

    [XmlIgnore]
    public bool EntityLineItemPriceId__cSpecified
    {
      get => this.entityLineItemPriceId__cFieldSpecified;
      set => this.entityLineItemPriceId__cFieldSpecified = value;
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
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? IncrementalMrCost__c
    {
      get => this.incrementalMrCost__cField;
      set => this.incrementalMrCost__cField = value;
    }

    [XmlIgnore]
    public bool IncrementalMrCost__cSpecified
    {
      get => this.incrementalMrCost__cFieldSpecified;
      set => this.incrementalMrCost__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? IncrementalNrCost__c
    {
      get => this.incrementalNrCost__cField;
      set => this.incrementalNrCost__cField = value;
    }

    [XmlIgnore]
    public bool IncrementalNrCost__cSpecified
    {
      get => this.incrementalNrCost__cFieldSpecified;
      set => this.incrementalNrCost__cFieldSpecified = value;
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
    public double? IsLineItemWin__c
    {
      get => this.isLineItemWin__cField;
      set => this.isLineItemWin__cField = value;
    }

    [XmlIgnore]
    public bool IsLineItemWin__cSpecified
    {
      get => this.isLineItemWin__cFieldSpecified;
      set => this.isLineItemWin__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? IsWin__c
    {
      get => this.isWin__cField;
      set => this.isWin__cField = value;
    }

    [XmlIgnore]
    public bool IsWin__cSpecified
    {
      get => this.isWin__cFieldSpecified;
      set => this.isWin__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? LastActivityDate
    {
      get => this.lastActivityDateField;
      set => this.lastActivityDateField = value;
    }

    [XmlIgnore]
    public bool LastActivityDateSpecified
    {
      get => this.lastActivityDateFieldSpecified;
      set => this.lastActivityDateFieldSpecified = value;
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
    public string Lata__c
    {
      get => this.lata__cField;
      set => this.lata__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LineItemType__c
    {
      get => this.lineItemType__cField;
      set => this.lineItemType__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LocationID__c
    {
      get => this.locationID__cField;
      set => this.locationID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult MSO_PROPOSAL_XREFS__r
    {
      get => this.mSO_PROPOSAL_XREFS__rField;
      set => this.mSO_PROPOSAL_XREFS__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MrcUSD__c
    {
      get => this.mrcUSD__cField;
      set => this.mrcUSD__cField = value;
    }

    [XmlIgnore]
    public bool MrcUSD__cSpecified
    {
      get => this.mrcUSD__cFieldSpecified;
      set => this.mrcUSD__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Mrc__c
    {
      get => this.mrc__cField;
      set => this.mrc__cField = value;
    }

    [XmlIgnore]
    public bool Mrc__cSpecified
    {
      get => this.mrc__cFieldSpecified;
      set => this.mrc__cFieldSpecified = value;
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
    public double? NrcUSD__c
    {
      get => this.nrcUSD__cField;
      set => this.nrcUSD__cField = value;
    }

    [XmlIgnore]
    public bool NrcUSD__cSpecified
    {
      get => this.nrcUSD__cFieldSpecified;
      set => this.nrcUSD__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Nrc__c
    {
      get => this.nrc__cField;
      set => this.nrc__cField = value;
    }

    [XmlIgnore]
    public bool Nrc__cSpecified
    {
      get => this.nrc__cFieldSpecified;
      set => this.nrc__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? OrderQuoteId__c
    {
      get => this.orderQuoteId__cField;
      set => this.orderQuoteId__cField = value;
    }

    [XmlIgnore]
    public bool OrderQuoteId__cSpecified
    {
      get => this.orderQuoteId__cFieldSpecified;
      set => this.orderQuoteId__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name Owner
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? PriceDealCreateDate__c
    {
      get => this.priceDealCreateDate__cField;
      set => this.priceDealCreateDate__cField = value;
    }

    [XmlIgnore]
    public bool PriceDealCreateDate__cSpecified
    {
      get => this.priceDealCreateDate__cFieldSpecified;
      set => this.priceDealCreateDate__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PriceDealEntityLineItemId__c
    {
      get => this.priceDealEntityLineItemId__cField;
      set => this.priceDealEntityLineItemId__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PriceDealId__c
    {
      get => this.priceDealId__cField;
      set => this.priceDealId__cField = value;
    }

    [XmlIgnore]
    public bool PriceDealId__cSpecified
    {
      get => this.priceDealId__cFieldSpecified;
      set => this.priceDealId__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PriceOriginDesc__c
    {
      get => this.priceOriginDesc__cField;
      set => this.priceOriginDesc__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PriceOriginId__c
    {
      get => this.priceOriginId__cField;
      set => this.priceOriginId__cField = value;
    }

    [XmlIgnore]
    public bool PriceOriginId__cSpecified
    {
      get => this.priceOriginId__cFieldSpecified;
      set => this.priceOriginId__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PriceTermId__c
    {
      get => this.priceTermId__cField;
      set => this.priceTermId__cField = value;
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
    public string ProductDesc__c
    {
      get => this.productDesc__cField;
      set => this.productDesc__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ProposalSentDate__c
    {
      get => this.proposalSentDate__cField;
      set => this.proposalSentDate__cField = value;
    }

    [XmlIgnore]
    public bool ProposalSentDate__cSpecified
    {
      get => this.proposalSentDate__cFieldSpecified;
      set => this.proposalSentDate__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string QuoteCreateDate__c
    {
      get => this.quoteCreateDate__cField;
      set => this.quoteCreateDate__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ReportRegion__c
    {
      get => this.reportRegion__cField;
      set => this.reportRegion__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SI_aging__c
    {
      get => this.sI_aging__cField;
      set => this.sI_aging__cField = value;
    }

    [XmlIgnore]
    public bool SI_aging__cSpecified
    {
      get => this.sI_aging__cFieldSpecified;
      set => this.sI_aging__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SWC__c
    {
      get => this.sWC__cField;
      set => this.sWC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SalesRep__c
    {
      get => this.salesRep__cField;
      set => this.salesRep__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SfdcOpportunityId__c
    {
      get => this.sfdcOpportunityId__cField;
      set => this.sfdcOpportunityId__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SfdcOpportunityStatus__c
    {
      get => this.sfdcOpportunityStatus__cField;
      set => this.sfdcOpportunityStatus__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SolutionId__c
    {
      get => this.solutionId__cField;
      set => this.solutionId__cField = value;
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
    public double? TrackingNumber__c
    {
      get => this.trackingNumber__cField;
      set => this.trackingNumber__cField = value;
    }

    [XmlIgnore]
    public bool TrackingNumber__cSpecified
    {
      get => this.trackingNumber__cFieldSpecified;
      set => this.trackingNumber__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor_Type__c
    {
      get => this.vendor_Type__cField;
      set => this.vendor_Type__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor__c
    {
      get => this.vendor__cField;
      set => this.vendor__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_Address1__c
    {
      get => this.zside_Address1__cField;
      set => this.zside_Address1__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_Address2__c
    {
      get => this.zside_Address2__cField;
      set => this.zside_Address2__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_City__c
    {
      get => this.zside_City__cField;
      set => this.zside_City__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_Country__c
    {
      get => this.zside_Country__cField;
      set => this.zside_Country__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_Latitude__c
    {
      get => this.zside_Latitude__cField;
      set => this.zside_Latitude__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_Longitude__c
    {
      get => this.zside_Longitude__cField;
      set => this.zside_Longitude__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_PostalCode__c
    {
      get => this.zside_PostalCode__cField;
      set => this.zside_PostalCode__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_Premise__c
    {
      get => this.zside_Premise__cField;
      set => this.zside_Premise__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_State__c
    {
      get => this.zside_State__cField;
      set => this.zside_State__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Zside_Street__c
    {
      get => this.zside_Street__cField;
      set => this.zside_Street__cField = value;
    }
  }
}
