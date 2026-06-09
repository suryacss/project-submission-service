// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Account
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class Account : sObject
  {
    private QueryResult aCC_CAR_BUYING_PLANS__rField;
    private string aCC_CAR_ID__cField;
    private string aCC_CAR_TIER__cField;
    private string aCC_CAR_TYPE__cField;
    private string aCC_ORDER_RULE__cField;
    private string aCTIVE_IND__cField;
    private string aGREEMENT_TYPE__cField;
    private string aPPROVED_VENDOR__cField;
    private string aUTOMATED_QUOTING_PRODUCTS__cField;
    private QueryResult accountContactRolesField;
    private string accountNumberField;
    private QueryResult accountPartnersFromField;
    private QueryResult accountPartnersToField;
    private string accountSourceField;
    private QueryResult activityHistoriesField;
    private double? annualRevenueField;
    private bool annualRevenueFieldSpecified;
    private QueryResult assetsField;
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
    private string building_List_URL__cField;
    private bool? building_List_Verified__cField;
    private bool building_List_Verified__cFieldSpecified;
    private string cARRIER_DIVISION__cField;
    private string cARRIER_RELATIONS_DIRECTOR__cField;
    private string cARRIER_RELATIONS_MANAGER__cField;
    private string cARRIER_RELATIONS_TEAM_LEAD__cField;
    private string cOMMERCIALLY_COVERED_PRODUCTS__cField;
    private string cOUNTRY_CODE__cField;
    private QueryResult casesField;
    private QueryResult childAccountsField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contactsField;
    private QueryResult contentDocumentLinksField;
    private QueryResult contract_Summaries__rField;
    private bool? contract_Summary_Entered__cField;
    private bool contract_Summary_Entered__cFieldSpecified;
    private bool? contract_Summary_Verified__cField;
    private bool contract_Summary_Verified__cFieldSpecified;
    private QueryResult contractsField;
    private QueryResult contracts__rField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private DateTime? dEACT_DATE__cField;
    private bool dEACT_DATE__cFieldSpecified;
    private string descriptionField;
    private QueryResult duplicateRecordItemsField;
    private QueryResult eCCKTS__rField;
    private QueryResult eCCKT_SUPPLEMENTAL__rField;
    private DateTime? eFFECT_DATE__cField;
    private bool eFFECT_DATE__cFieldSpecified;
    private bool? eTL_Defined__cField;
    private bool eTL_Defined__cFieldSpecified;
    private bool? eTL_Verified__cField;
    private bool eTL_Verified__cFieldSpecified;
    private QueryResult emailsField;
    private string escalation_List_URL__cField;
    private bool? escalation_List_Verified__cField;
    private bool escalation_List_Verified__cFieldSpecified;
    private QueryResult eventsField;
    private string faxField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private QueryResult historiesField;
    private string industryField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string jigsawField;
    private string jigsawCompanyIdField;
    private DateTime? lAST_MODIFY_DATE__cField;
    private bool lAST_MODIFY_DATE__cFieldSpecified;
    private string lAST_MODIFY_REQUEST_BY__cField;
    private string lAST_MODIFY_USERID__cField;
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
    private QueryResult lookedUpFromActivitiesField;
    private string mODIFY_REASON__cField;
    private Account masterRecordField;
    private string masterRecordIdField;
    private DateTime? maxContractSummaryDate__cField;
    private bool maxContractSummaryDate__cFieldSpecified;
    private DateTime? maxTleCreateDate__cField;
    private bool maxTleCreateDate__cFieldSpecified;
    private DateTime? maxVerifiedContractDate__cField;
    private bool maxVerifiedContractDate__cFieldSpecified;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private int? numberOfEmployeesField;
    private bool numberOfEmployeesFieldSpecified;
    private QueryResult openActivitiesField;
    private QueryResult opportunitiesField;
    private QueryResult opportunities__rField;
    private QueryResult opportunityPartnersToField;
    private QueryResult ordersField;
    private User ownerField;
    private string ownerIdField;
    private string ownershipField;
    private string pENALTY_RULE__cField;
    private Account parentField;
    private string parentIdField;
    private QueryResult partnersFromField;
    private QueryResult partnersToField;
    private QueryResult personasField;
    private string phoneField;
    private string photoUrlField;
    private QueryResult postsField;
    private QueryResult pricing_Structures__rField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult project_Items1__rField;
    private QueryResult project_Items__rField;
    private string rEGION__cField;
    private string rFP_Quote__cField;
    private REQUEST_FOR_PROPOSAL__c rFP_Quote__rField;
    private QueryResult rFP_s__rField;
    private DateTime? rFT_Decision_Tree_Rule_Modified_Date__cField;
    private bool rFT_Decision_Tree_Rule_Modified_Date__cFieldSpecified;
    private string rFT_Decision_Tree_Rule__cField;
    private string ratingField;
    private QueryResult recordAssociatedGroupsField;
    private string sERVICE_GROUP__cField;
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
    private string sicField;
    private string sicDescField;
    private string siteField;
    private bool? skip_Validation__cField;
    private bool skip_Validation__cFieldSpecified;
    private bool? skip_Workflow__cField;
    private bool skip_Workflow__cFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tEST_ASRS__rField;
    private QueryResult tasksField;
    private string tickerSymbolField;
    private QueryResult topicAssignmentsField;
    private string typeField;
    private UserRecordAccess userRecordAccessField;
    private string vENDOR_TYPE__cField;
    private string websiteField;
    private string win_Rate_Report__cField;

    [XmlElement(IsNullable = true)]
    public QueryResult ACC_CAR_BUYING_PLANS__r
    {
      get => this.aCC_CAR_BUYING_PLANS__rField;
      set => this.aCC_CAR_BUYING_PLANS__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACC_CAR_ID__c
    {
      get => this.aCC_CAR_ID__cField;
      set => this.aCC_CAR_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACC_CAR_TIER__c
    {
      get => this.aCC_CAR_TIER__cField;
      set => this.aCC_CAR_TIER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACC_CAR_TYPE__c
    {
      get => this.aCC_CAR_TYPE__cField;
      set => this.aCC_CAR_TYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACC_ORDER_RULE__c
    {
      get => this.aCC_ORDER_RULE__cField;
      set => this.aCC_ORDER_RULE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACTIVE_IND__c
    {
      get => this.aCTIVE_IND__cField;
      set => this.aCTIVE_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AGREEMENT_TYPE__c
    {
      get => this.aGREEMENT_TYPE__cField;
      set => this.aGREEMENT_TYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string APPROVED_VENDOR__c
    {
      get => this.aPPROVED_VENDOR__cField;
      set => this.aPPROVED_VENDOR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AUTOMATED_QUOTING_PRODUCTS__c
    {
      get => this.aUTOMATED_QUOTING_PRODUCTS__cField;
      set => this.aUTOMATED_QUOTING_PRODUCTS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AccountContactRoles
    {
      get => this.accountContactRolesField;
      set => this.accountContactRolesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AccountNumber
    {
      get => this.accountNumberField;
      set => this.accountNumberField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AccountPartnersFrom
    {
      get => this.accountPartnersFromField;
      set => this.accountPartnersFromField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AccountPartnersTo
    {
      get => this.accountPartnersToField;
      set => this.accountPartnersToField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AccountSource
    {
      get => this.accountSourceField;
      set => this.accountSourceField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AnnualRevenue
    {
      get => this.annualRevenueField;
      set => this.annualRevenueField = value;
    }

    [XmlIgnore]
    public bool AnnualRevenueSpecified
    {
      get => this.annualRevenueFieldSpecified;
      set => this.annualRevenueFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Assets
    {
      get => this.assetsField;
      set => this.assetsField = value;
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
    public string Building_List_URL__c
    {
      get => this.building_List_URL__cField;
      set => this.building_List_URL__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Building_List_Verified__c
    {
      get => this.building_List_Verified__cField;
      set => this.building_List_Verified__cField = value;
    }

    [XmlIgnore]
    public bool Building_List_Verified__cSpecified
    {
      get => this.building_List_Verified__cFieldSpecified;
      set => this.building_List_Verified__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CARRIER_DIVISION__c
    {
      get => this.cARRIER_DIVISION__cField;
      set => this.cARRIER_DIVISION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CARRIER_RELATIONS_DIRECTOR__c
    {
      get => this.cARRIER_RELATIONS_DIRECTOR__cField;
      set => this.cARRIER_RELATIONS_DIRECTOR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CARRIER_RELATIONS_MANAGER__c
    {
      get => this.cARRIER_RELATIONS_MANAGER__cField;
      set => this.cARRIER_RELATIONS_MANAGER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CARRIER_RELATIONS_TEAM_LEAD__c
    {
      get => this.cARRIER_RELATIONS_TEAM_LEAD__cField;
      set => this.cARRIER_RELATIONS_TEAM_LEAD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string COMMERCIALLY_COVERED_PRODUCTS__c
    {
      get => this.cOMMERCIALLY_COVERED_PRODUCTS__cField;
      set => this.cOMMERCIALLY_COVERED_PRODUCTS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string COUNTRY_CODE__c
    {
      get => this.cOUNTRY_CODE__cField;
      set => this.cOUNTRY_CODE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Cases
    {
      get => this.casesField;
      set => this.casesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ChildAccounts
    {
      get => this.childAccountsField;
      set => this.childAccountsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Contacts
    {
      get => this.contactsField;
      set => this.contactsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Contract_Summaries__r
    {
      get => this.contract_Summaries__rField;
      set => this.contract_Summaries__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Contract_Summary_Entered__c
    {
      get => this.contract_Summary_Entered__cField;
      set => this.contract_Summary_Entered__cField = value;
    }

    [XmlIgnore]
    public bool Contract_Summary_Entered__cSpecified
    {
      get => this.contract_Summary_Entered__cFieldSpecified;
      set => this.contract_Summary_Entered__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Contract_Summary_Verified__c
    {
      get => this.contract_Summary_Verified__cField;
      set => this.contract_Summary_Verified__cField = value;
    }

    [XmlIgnore]
    public bool Contract_Summary_Verified__cSpecified
    {
      get => this.contract_Summary_Verified__cFieldSpecified;
      set => this.contract_Summary_Verified__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Contracts
    {
      get => this.contractsField;
      set => this.contractsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Contracts__r
    {
      get => this.contracts__rField;
      set => this.contracts__rField = value;
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
    public DateTime? DEACT_DATE__c
    {
      get => this.dEACT_DATE__cField;
      set => this.dEACT_DATE__cField = value;
    }

    [XmlIgnore]
    public bool DEACT_DATE__cSpecified
    {
      get => this.dEACT_DATE__cFieldSpecified;
      set => this.dEACT_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS__r
    {
      get => this.eCCKTS__rField;
      set => this.eCCKTS__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKT_SUPPLEMENTAL__r
    {
      get => this.eCCKT_SUPPLEMENTAL__rField;
      set => this.eCCKT_SUPPLEMENTAL__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? EFFECT_DATE__c
    {
      get => this.eFFECT_DATE__cField;
      set => this.eFFECT_DATE__cField = value;
    }

    [XmlIgnore]
    public bool EFFECT_DATE__cSpecified
    {
      get => this.eFFECT_DATE__cFieldSpecified;
      set => this.eFFECT_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ETL_Defined__c
    {
      get => this.eTL_Defined__cField;
      set => this.eTL_Defined__cField = value;
    }

    [XmlIgnore]
    public bool ETL_Defined__cSpecified
    {
      get => this.eTL_Defined__cFieldSpecified;
      set => this.eTL_Defined__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ETL_Verified__c
    {
      get => this.eTL_Verified__cField;
      set => this.eTL_Verified__cField = value;
    }

    [XmlIgnore]
    public bool ETL_Verified__cSpecified
    {
      get => this.eTL_Verified__cFieldSpecified;
      set => this.eTL_Verified__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Escalation_List_URL__c
    {
      get => this.escalation_List_URL__cField;
      set => this.escalation_List_URL__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Escalation_List_Verified__c
    {
      get => this.escalation_List_Verified__cField;
      set => this.escalation_List_Verified__cField = value;
    }

    [XmlIgnore]
    public bool Escalation_List_Verified__cSpecified
    {
      get => this.escalation_List_Verified__cFieldSpecified;
      set => this.escalation_List_Verified__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Events
    {
      get => this.eventsField;
      set => this.eventsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Fax
    {
      get => this.faxField;
      set => this.faxField = value;
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
    public string Industry
    {
      get => this.industryField;
      set => this.industryField = value;
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
    public string Jigsaw
    {
      get => this.jigsawField;
      set => this.jigsawField = value;
    }

    [XmlElement(IsNullable = true)]
    public string JigsawCompanyId
    {
      get => this.jigsawCompanyIdField;
      set => this.jigsawCompanyIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LAST_MODIFY_DATE__c
    {
      get => this.lAST_MODIFY_DATE__cField;
      set => this.lAST_MODIFY_DATE__cField = value;
    }

    [XmlIgnore]
    public bool LAST_MODIFY_DATE__cSpecified
    {
      get => this.lAST_MODIFY_DATE__cFieldSpecified;
      set => this.lAST_MODIFY_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LAST_MODIFY_REQUEST_BY__c
    {
      get => this.lAST_MODIFY_REQUEST_BY__cField;
      set => this.lAST_MODIFY_REQUEST_BY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LAST_MODIFY_USERID__c
    {
      get => this.lAST_MODIFY_USERID__cField;
      set => this.lAST_MODIFY_USERID__cField = value;
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
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MODIFY_REASON__c
    {
      get => this.mODIFY_REASON__cField;
      set => this.mODIFY_REASON__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account MasterRecord
    {
      get => this.masterRecordField;
      set => this.masterRecordField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MasterRecordId
    {
      get => this.masterRecordIdField;
      set => this.masterRecordIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? MaxContractSummaryDate__c
    {
      get => this.maxContractSummaryDate__cField;
      set => this.maxContractSummaryDate__cField = value;
    }

    [XmlIgnore]
    public bool MaxContractSummaryDate__cSpecified
    {
      get => this.maxContractSummaryDate__cFieldSpecified;
      set => this.maxContractSummaryDate__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? MaxTleCreateDate__c
    {
      get => this.maxTleCreateDate__cField;
      set => this.maxTleCreateDate__cField = value;
    }

    [XmlIgnore]
    public bool MaxTleCreateDate__cSpecified
    {
      get => this.maxTleCreateDate__cFieldSpecified;
      set => this.maxTleCreateDate__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? MaxVerifiedContractDate__c
    {
      get => this.maxVerifiedContractDate__cField;
      set => this.maxVerifiedContractDate__cField = value;
    }

    [XmlIgnore]
    public bool MaxVerifiedContractDate__cSpecified
    {
      get => this.maxVerifiedContractDate__cFieldSpecified;
      set => this.maxVerifiedContractDate__cFieldSpecified = value;
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
    public int? NumberOfEmployees
    {
      get => this.numberOfEmployeesField;
      set => this.numberOfEmployeesField = value;
    }

    [XmlIgnore]
    public bool NumberOfEmployeesSpecified
    {
      get => this.numberOfEmployeesFieldSpecified;
      set => this.numberOfEmployeesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Opportunities
    {
      get => this.opportunitiesField;
      set => this.opportunitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Opportunities__r
    {
      get => this.opportunities__rField;
      set => this.opportunities__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpportunityPartnersTo
    {
      get => this.opportunityPartnersToField;
      set => this.opportunityPartnersToField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Orders
    {
      get => this.ordersField;
      set => this.ordersField = value;
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
    public string Ownership
    {
      get => this.ownershipField;
      set => this.ownershipField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PENALTY_RULE__c
    {
      get => this.pENALTY_RULE__cField;
      set => this.pENALTY_RULE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account Parent
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
    public QueryResult PartnersFrom
    {
      get => this.partnersFromField;
      set => this.partnersFromField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult PartnersTo
    {
      get => this.partnersToField;
      set => this.partnersToField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Personas
    {
      get => this.personasField;
      set => this.personasField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Phone
    {
      get => this.phoneField;
      set => this.phoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PhotoUrl
    {
      get => this.photoUrlField;
      set => this.photoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Posts
    {
      get => this.postsField;
      set => this.postsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Pricing_Structures__r
    {
      get => this.pricing_Structures__rField;
      set => this.pricing_Structures__rField = value;
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
    public QueryResult Project_Items1__r
    {
      get => this.project_Items1__rField;
      set => this.project_Items1__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Project_Items__r
    {
      get => this.project_Items__rField;
      set => this.project_Items__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string REGION__c
    {
      get => this.rEGION__cField;
      set => this.rEGION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_Quote__c
    {
      get => this.rFP_Quote__cField;
      set => this.rFP_Quote__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public REQUEST_FOR_PROPOSAL__c RFP_Quote__r
    {
      get => this.rFP_Quote__rField;
      set => this.rFP_Quote__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RFP_s__r
    {
      get => this.rFP_s__rField;
      set => this.rFP_s__rField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFT_Decision_Tree_Rule_Modified_Date__c
    {
      get => this.rFT_Decision_Tree_Rule_Modified_Date__cField;
      set => this.rFT_Decision_Tree_Rule_Modified_Date__cField = value;
    }

    [XmlIgnore]
    public bool RFT_Decision_Tree_Rule_Modified_Date__cSpecified
    {
      get => this.rFT_Decision_Tree_Rule_Modified_Date__cFieldSpecified;
      set => this.rFT_Decision_Tree_Rule_Modified_Date__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_Decision_Tree_Rule__c
    {
      get => this.rFT_Decision_Tree_Rule__cField;
      set => this.rFT_Decision_Tree_Rule__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Rating
    {
      get => this.ratingField;
      set => this.ratingField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SERVICE_GROUP__c
    {
      get => this.sERVICE_GROUP__cField;
      set => this.sERVICE_GROUP__cField = value;
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
    public string Sic
    {
      get => this.sicField;
      set => this.sicField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SicDesc
    {
      get => this.sicDescField;
      set => this.sicDescField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Site
    {
      get => this.siteField;
      set => this.siteField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Skip_Validation__c
    {
      get => this.skip_Validation__cField;
      set => this.skip_Validation__cField = value;
    }

    [XmlIgnore]
    public bool Skip_Validation__cSpecified
    {
      get => this.skip_Validation__cFieldSpecified;
      set => this.skip_Validation__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Skip_Workflow__c
    {
      get => this.skip_Workflow__cField;
      set => this.skip_Workflow__cField = value;
    }

    [XmlIgnore]
    public bool Skip_Workflow__cSpecified
    {
      get => this.skip_Workflow__cFieldSpecified;
      set => this.skip_Workflow__cFieldSpecified = value;
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
    public QueryResult TEST_ASRS__r
    {
      get => this.tEST_ASRS__rField;
      set => this.tEST_ASRS__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Tasks
    {
      get => this.tasksField;
      set => this.tasksField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TickerSymbol
    {
      get => this.tickerSymbolField;
      set => this.tickerSymbolField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
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

    [XmlElement(IsNullable = true)]
    public string VENDOR_TYPE__c
    {
      get => this.vENDOR_TYPE__cField;
      set => this.vENDOR_TYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Website
    {
      get => this.websiteField;
      set => this.websiteField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Win_Rate_Report__c
    {
      get => this.win_Rate_Report__cField;
      set => this.win_Rate_Report__cField = value;
    }
  }
}
