// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Organization
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class Organization : sObject
  {
    private address addressField;
    private QueryResult attachedContentDocumentsField;
    private string cityField;
    private QueryResult combinedAttachmentsField;
    private string complianceBccEmailField;
    private QueryResult contentDocumentLinksField;
    private string countryField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult customBrandsField;
    private string defaultAccountAccessField;
    private string defaultCalendarAccessField;
    private string defaultCampaignAccessField;
    private string defaultCaseAccessField;
    private string defaultContactAccessField;
    private string defaultLeadAccessField;
    private string defaultLocaleSidKeyField;
    private string defaultOpportunityAccessField;
    private string defaultPricebookAccessField;
    private string divisionField;
    private string faxField;
    private int? fiscalYearStartMonthField;
    private bool fiscalYearStartMonthFieldSpecified;
    private string geocodeAccuracyField;
    private string instanceNameField;
    private bool? isReadOnlyField;
    private bool isReadOnlyFieldSpecified;
    private bool? isSandboxField;
    private bool isSandboxFieldSpecified;
    private string languageLocaleKeyField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private double? latitudeField;
    private bool latitudeFieldSpecified;
    private double? longitudeField;
    private bool longitudeFieldSpecified;
    private int? monthlyPageViewsEntitlementField;
    private bool monthlyPageViewsEntitlementFieldSpecified;
    private int? monthlyPageViewsUsedField;
    private bool monthlyPageViewsUsedFieldSpecified;
    private string nameField;
    private string namespacePrefixField;
    private string organizationTypeField;
    private string phoneField;
    private string postalCodeField;
    private bool? preferencesActivityAnalyticsEnabledField;
    private bool preferencesActivityAnalyticsEnabledFieldSpecified;
    private bool? preferencesRequireOpportunityProductsField;
    private bool preferencesRequireOpportunityProductsFieldSpecified;
    private string primaryContactField;
    private bool? receivesAdminInfoEmailsField;
    private bool receivesAdminInfoEmailsFieldSpecified;
    private bool? receivesInfoEmailsField;
    private bool receivesInfoEmailsFieldSpecified;
    private string signupCountryIsoCodeField;
    private string stateField;
    private string streetField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private DateTime? trialExpirationDateField;
    private bool trialExpirationDateFieldSpecified;
    private string uiSkinField;
    private bool? usesStartDateAsFiscalYearNameField;
    private bool usesStartDateAsFiscalYearNameFieldSpecified;
    private string webToCaseDefaultOriginField;

    [XmlElement(IsNullable = true)]
    public address Address
    {
      get => this.addressField;
      set => this.addressField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string City
    {
      get => this.cityField;
      set => this.cityField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ComplianceBccEmail
    {
      get => this.complianceBccEmailField;
      set => this.complianceBccEmailField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Country
    {
      get => this.countryField;
      set => this.countryField = value;
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
    public QueryResult CustomBrands
    {
      get => this.customBrandsField;
      set => this.customBrandsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultAccountAccess
    {
      get => this.defaultAccountAccessField;
      set => this.defaultAccountAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultCalendarAccess
    {
      get => this.defaultCalendarAccessField;
      set => this.defaultCalendarAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultCampaignAccess
    {
      get => this.defaultCampaignAccessField;
      set => this.defaultCampaignAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultCaseAccess
    {
      get => this.defaultCaseAccessField;
      set => this.defaultCaseAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultContactAccess
    {
      get => this.defaultContactAccessField;
      set => this.defaultContactAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultLeadAccess
    {
      get => this.defaultLeadAccessField;
      set => this.defaultLeadAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultLocaleSidKey
    {
      get => this.defaultLocaleSidKeyField;
      set => this.defaultLocaleSidKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultOpportunityAccess
    {
      get => this.defaultOpportunityAccessField;
      set => this.defaultOpportunityAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultPricebookAccess
    {
      get => this.defaultPricebookAccessField;
      set => this.defaultPricebookAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Division
    {
      get => this.divisionField;
      set => this.divisionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Fax
    {
      get => this.faxField;
      set => this.faxField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? FiscalYearStartMonth
    {
      get => this.fiscalYearStartMonthField;
      set => this.fiscalYearStartMonthField = value;
    }

    [XmlIgnore]
    public bool FiscalYearStartMonthSpecified
    {
      get => this.fiscalYearStartMonthFieldSpecified;
      set => this.fiscalYearStartMonthFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string GeocodeAccuracy
    {
      get => this.geocodeAccuracyField;
      set => this.geocodeAccuracyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string InstanceName
    {
      get => this.instanceNameField;
      set => this.instanceNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsReadOnly
    {
      get => this.isReadOnlyField;
      set => this.isReadOnlyField = value;
    }

    [XmlIgnore]
    public bool IsReadOnlySpecified
    {
      get => this.isReadOnlyFieldSpecified;
      set => this.isReadOnlyFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsSandbox
    {
      get => this.isSandboxField;
      set => this.isSandboxField = value;
    }

    [XmlIgnore]
    public bool IsSandboxSpecified
    {
      get => this.isSandboxFieldSpecified;
      set => this.isSandboxFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LanguageLocaleKey
    {
      get => this.languageLocaleKeyField;
      set => this.languageLocaleKeyField = value;
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
    public double? Latitude
    {
      get => this.latitudeField;
      set => this.latitudeField = value;
    }

    [XmlIgnore]
    public bool LatitudeSpecified
    {
      get => this.latitudeFieldSpecified;
      set => this.latitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Longitude
    {
      get => this.longitudeField;
      set => this.longitudeField = value;
    }

    [XmlIgnore]
    public bool LongitudeSpecified
    {
      get => this.longitudeFieldSpecified;
      set => this.longitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? MonthlyPageViewsEntitlement
    {
      get => this.monthlyPageViewsEntitlementField;
      set => this.monthlyPageViewsEntitlementField = value;
    }

    [XmlIgnore]
    public bool MonthlyPageViewsEntitlementSpecified
    {
      get => this.monthlyPageViewsEntitlementFieldSpecified;
      set => this.monthlyPageViewsEntitlementFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? MonthlyPageViewsUsed
    {
      get => this.monthlyPageViewsUsedField;
      set => this.monthlyPageViewsUsedField = value;
    }

    [XmlIgnore]
    public bool MonthlyPageViewsUsedSpecified
    {
      get => this.monthlyPageViewsUsedFieldSpecified;
      set => this.monthlyPageViewsUsedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OrganizationType
    {
      get => this.organizationTypeField;
      set => this.organizationTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Phone
    {
      get => this.phoneField;
      set => this.phoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PostalCode
    {
      get => this.postalCodeField;
      set => this.postalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesActivityAnalyticsEnabled
    {
      get => this.preferencesActivityAnalyticsEnabledField;
      set => this.preferencesActivityAnalyticsEnabledField = value;
    }

    [XmlIgnore]
    public bool PreferencesActivityAnalyticsEnabledSpecified
    {
      get => this.preferencesActivityAnalyticsEnabledFieldSpecified;
      set => this.preferencesActivityAnalyticsEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PreferencesRequireOpportunityProducts
    {
      get => this.preferencesRequireOpportunityProductsField;
      set => this.preferencesRequireOpportunityProductsField = value;
    }

    [XmlIgnore]
    public bool PreferencesRequireOpportunityProductsSpecified
    {
      get => this.preferencesRequireOpportunityProductsFieldSpecified;
      set => this.preferencesRequireOpportunityProductsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PrimaryContact
    {
      get => this.primaryContactField;
      set => this.primaryContactField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ReceivesAdminInfoEmails
    {
      get => this.receivesAdminInfoEmailsField;
      set => this.receivesAdminInfoEmailsField = value;
    }

    [XmlIgnore]
    public bool ReceivesAdminInfoEmailsSpecified
    {
      get => this.receivesAdminInfoEmailsFieldSpecified;
      set => this.receivesAdminInfoEmailsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ReceivesInfoEmails
    {
      get => this.receivesInfoEmailsField;
      set => this.receivesInfoEmailsField = value;
    }

    [XmlIgnore]
    public bool ReceivesInfoEmailsSpecified
    {
      get => this.receivesInfoEmailsFieldSpecified;
      set => this.receivesInfoEmailsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SignupCountryIsoCode
    {
      get => this.signupCountryIsoCodeField;
      set => this.signupCountryIsoCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string State
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Street
    {
      get => this.streetField;
      set => this.streetField = value;
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
    public DateTime? TrialExpirationDate
    {
      get => this.trialExpirationDateField;
      set => this.trialExpirationDateField = value;
    }

    [XmlIgnore]
    public bool TrialExpirationDateSpecified
    {
      get => this.trialExpirationDateFieldSpecified;
      set => this.trialExpirationDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string UiSkin
    {
      get => this.uiSkinField;
      set => this.uiSkinField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsesStartDateAsFiscalYearName
    {
      get => this.usesStartDateAsFiscalYearNameField;
      set => this.usesStartDateAsFiscalYearNameField = value;
    }

    [XmlIgnore]
    public bool UsesStartDateAsFiscalYearNameSpecified
    {
      get => this.usesStartDateAsFiscalYearNameFieldSpecified;
      set => this.usesStartDateAsFiscalYearNameFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string WebToCaseDefaultOrigin
    {
      get => this.webToCaseDefaultOriginField;
      set => this.webToCaseDefaultOriginField = value;
    }
  }
}
