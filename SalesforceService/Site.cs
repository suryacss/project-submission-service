// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Site
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
  public class Site : sObject
  {
    private User adminField;
    private string adminIdField;
    private string analyticsTrackingCodeField;
    private QueryResult attachedContentDocumentsField;
    private string clickjackProtectionLevelField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private int? dailyBandwidthLimitField;
    private bool dailyBandwidthLimitFieldSpecified;
    private int? dailyBandwidthUsedField;
    private bool dailyBandwidthUsedFieldSpecified;
    private int? dailyRequestTimeLimitField;
    private bool dailyRequestTimeLimitFieldSpecified;
    private int? dailyRequestTimeUsedField;
    private bool dailyRequestTimeUsedFieldSpecified;
    private string descriptionField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private User guestUserField;
    private string guestUserIdField;
    private QueryResult historiesField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string masterLabelField;
    private int? monthlyPageViewsEntitlementField;
    private bool monthlyPageViewsEntitlementFieldSpecified;
    private string nameField;
    private bool? optionsAllowGuestSupportApiField;
    private bool optionsAllowGuestSupportApiFieldSpecified;
    private bool? optionsAllowHomePageField;
    private bool optionsAllowHomePageFieldSpecified;
    private bool? optionsAllowStandardAnswersPagesField;
    private bool optionsAllowStandardAnswersPagesFieldSpecified;
    private bool? optionsAllowStandardIdeasPagesField;
    private bool optionsAllowStandardIdeasPagesFieldSpecified;
    private bool? optionsAllowStandardLookupsField;
    private bool optionsAllowStandardLookupsFieldSpecified;
    private bool? optionsAllowStandardPortalPagesField;
    private bool optionsAllowStandardPortalPagesFieldSpecified;
    private bool? optionsAllowStandardSearchField;
    private bool optionsAllowStandardSearchFieldSpecified;
    private bool? optionsEnableFeedsField;
    private bool optionsEnableFeedsFieldSpecified;
    private bool? optionsRequireHttpsField;
    private bool optionsRequireHttpsFieldSpecified;
    private QueryResult siteDomainPathsField;
    private string siteTypeField;
    private string statusField;
    private string subdomainField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string urlPathPrefixField;

    [XmlElement(IsNullable = true)]
    public User Admin
    {
      get => this.adminField;
      set => this.adminField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AdminId
    {
      get => this.adminIdField;
      set => this.adminIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AnalyticsTrackingCode
    {
      get => this.analyticsTrackingCodeField;
      set => this.analyticsTrackingCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ClickjackProtectionLevel
    {
      get => this.clickjackProtectionLevelField;
      set => this.clickjackProtectionLevelField = value;
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
    public int? DailyBandwidthLimit
    {
      get => this.dailyBandwidthLimitField;
      set => this.dailyBandwidthLimitField = value;
    }

    [XmlIgnore]
    public bool DailyBandwidthLimitSpecified
    {
      get => this.dailyBandwidthLimitFieldSpecified;
      set => this.dailyBandwidthLimitFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? DailyBandwidthUsed
    {
      get => this.dailyBandwidthUsedField;
      set => this.dailyBandwidthUsedField = value;
    }

    [XmlIgnore]
    public bool DailyBandwidthUsedSpecified
    {
      get => this.dailyBandwidthUsedFieldSpecified;
      set => this.dailyBandwidthUsedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? DailyRequestTimeLimit
    {
      get => this.dailyRequestTimeLimitField;
      set => this.dailyRequestTimeLimitField = value;
    }

    [XmlIgnore]
    public bool DailyRequestTimeLimitSpecified
    {
      get => this.dailyRequestTimeLimitFieldSpecified;
      set => this.dailyRequestTimeLimitFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? DailyRequestTimeUsed
    {
      get => this.dailyRequestTimeUsedField;
      set => this.dailyRequestTimeUsedField = value;
    }

    [XmlIgnore]
    public bool DailyRequestTimeUsedSpecified
    {
      get => this.dailyRequestTimeUsedFieldSpecified;
      set => this.dailyRequestTimeUsedFieldSpecified = value;
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
    public User GuestUser
    {
      get => this.guestUserField;
      set => this.guestUserField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GuestUserId
    {
      get => this.guestUserIdField;
      set => this.guestUserIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
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
    public string MasterLabel
    {
      get => this.masterLabelField;
      set => this.masterLabelField = value;
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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsAllowGuestSupportApi
    {
      get => this.optionsAllowGuestSupportApiField;
      set => this.optionsAllowGuestSupportApiField = value;
    }

    [XmlIgnore]
    public bool OptionsAllowGuestSupportApiSpecified
    {
      get => this.optionsAllowGuestSupportApiFieldSpecified;
      set => this.optionsAllowGuestSupportApiFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsAllowHomePage
    {
      get => this.optionsAllowHomePageField;
      set => this.optionsAllowHomePageField = value;
    }

    [XmlIgnore]
    public bool OptionsAllowHomePageSpecified
    {
      get => this.optionsAllowHomePageFieldSpecified;
      set => this.optionsAllowHomePageFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsAllowStandardAnswersPages
    {
      get => this.optionsAllowStandardAnswersPagesField;
      set => this.optionsAllowStandardAnswersPagesField = value;
    }

    [XmlIgnore]
    public bool OptionsAllowStandardAnswersPagesSpecified
    {
      get => this.optionsAllowStandardAnswersPagesFieldSpecified;
      set => this.optionsAllowStandardAnswersPagesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsAllowStandardIdeasPages
    {
      get => this.optionsAllowStandardIdeasPagesField;
      set => this.optionsAllowStandardIdeasPagesField = value;
    }

    [XmlIgnore]
    public bool OptionsAllowStandardIdeasPagesSpecified
    {
      get => this.optionsAllowStandardIdeasPagesFieldSpecified;
      set => this.optionsAllowStandardIdeasPagesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsAllowStandardLookups
    {
      get => this.optionsAllowStandardLookupsField;
      set => this.optionsAllowStandardLookupsField = value;
    }

    [XmlIgnore]
    public bool OptionsAllowStandardLookupsSpecified
    {
      get => this.optionsAllowStandardLookupsFieldSpecified;
      set => this.optionsAllowStandardLookupsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsAllowStandardPortalPages
    {
      get => this.optionsAllowStandardPortalPagesField;
      set => this.optionsAllowStandardPortalPagesField = value;
    }

    [XmlIgnore]
    public bool OptionsAllowStandardPortalPagesSpecified
    {
      get => this.optionsAllowStandardPortalPagesFieldSpecified;
      set => this.optionsAllowStandardPortalPagesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsAllowStandardSearch
    {
      get => this.optionsAllowStandardSearchField;
      set => this.optionsAllowStandardSearchField = value;
    }

    [XmlIgnore]
    public bool OptionsAllowStandardSearchSpecified
    {
      get => this.optionsAllowStandardSearchFieldSpecified;
      set => this.optionsAllowStandardSearchFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsEnableFeeds
    {
      get => this.optionsEnableFeedsField;
      set => this.optionsEnableFeedsField = value;
    }

    [XmlIgnore]
    public bool OptionsEnableFeedsSpecified
    {
      get => this.optionsEnableFeedsFieldSpecified;
      set => this.optionsEnableFeedsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsRequireHttps
    {
      get => this.optionsRequireHttpsField;
      set => this.optionsRequireHttpsField = value;
    }

    [XmlIgnore]
    public bool OptionsRequireHttpsSpecified
    {
      get => this.optionsRequireHttpsFieldSpecified;
      set => this.optionsRequireHttpsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SiteDomainPaths
    {
      get => this.siteDomainPathsField;
      set => this.siteDomainPathsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SiteType
    {
      get => this.siteTypeField;
      set => this.siteTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Subdomain
    {
      get => this.subdomainField;
      set => this.subdomainField = value;
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
    public string UrlPathPrefix
    {
      get => this.urlPathPrefixField;
      set => this.urlPathPrefixField = value;
    }
  }
}
