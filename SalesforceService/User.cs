// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.User
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
  public class User : sObject
  {
    private string aboutMeField;
    private QueryResult acceptedEventRelationsField;
    private Account accountField;
    private string accountIdField;
    private address addressField;
    private string aliasField;
    private QueryResult attachedContentDocumentsField;
    private string badgeTextField;
    private string bannerPhotoUrlField;
    private QueryResult cLM_User_Preferences__rField;
    private string callCenterIdField;
    private string cityField;
    private QueryResult combinedAttachmentsField;
    private string communityNicknameField;
    private string companyNameField;
    private Contact contactField;
    private string contactIdField;
    private QueryResult contentDocumentLinksField;
    private QueryResult contractsSignedField;
    private string countryField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult declinedEventRelationsField;
    private string defaultGroupNotificationFrequencyField;
    private string delegatedApproverIdField;
    private QueryResult delegatedUsersField;
    private string departmentField;
    private string digestFrequencyField;
    private string divisionField;
    private string emailField;
    private string emailEncodingKeyField;
    private QueryResult emailMessageRelationsField;
    private bool? emailPreferencesAutoBccField;
    private bool emailPreferencesAutoBccFieldSpecified;
    private bool? emailPreferencesAutoBccStayInTouchField;
    private bool emailPreferencesAutoBccStayInTouchFieldSpecified;
    private bool? emailPreferencesStayInTouchReminderField;
    private bool emailPreferencesStayInTouchReminderFieldSpecified;
    private string employeeNumberField;
    private QueryResult eventRelationsField;
    private string extensionField;
    private QueryResult externalDataUserAuthsField;
    private string faxField;
    private string federationIdentifierField;
    private QueryResult feedSubscriptionsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private string firstNameField;
    private bool? forecastEnabledField;
    private bool forecastEnabledFieldSpecified;
    private string fullPhotoUrlField;
    private string geocodeAccuracyField;
    private QueryResult groupMembershipRequestsField;
    private QueryResult groupMembershipsField;
    private QueryResult installedMobileAppsField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isProfilePhotoActiveField;
    private bool isProfilePhotoActiveFieldSpecified;
    private string languageLocaleKeyField;
    private DateTime? lastLoginDateField;
    private bool lastLoginDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string lastNameField;
    private DateTime? lastPasswordChangeDateField;
    private bool lastPasswordChangeDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private double? latitudeField;
    private bool latitudeFieldSpecified;
    private string level_3_NT_Login_Name__cField;
    private double? license_Allocation__cField;
    private bool license_Allocation__cFieldSpecified;
    private string localeSidKeyField;
    private double? longitudeField;
    private bool longitudeFieldSpecified;
    private QueryResult managedUsersField;
    private User managerField;
    private string managerIdField;
    private string mediumBannerPhotoUrlField;
    private string mediumPhotoUrlField;
    private string mobilePhoneField;
    private string nameField;
    private DateTime? offlinePdaTrialExpirationDateField;
    private bool offlinePdaTrialExpirationDateFieldSpecified;
    private DateTime? offlineTrialExpirationDateField;
    private bool offlineTrialExpirationDateFieldSpecified;
    private QueryResult outgoingEmailRelationsField;
    private QueryResult ownedContentDocumentsField;
    private QueryResult permissionSetAssignmentsField;
    private QueryResult permissionSetLicenseAssignmentsField;
    private string phoneField;
    private string postalCodeField;
    private Profile profileField;
    private string profileIdField;
    private QueryResult projects__rField;
    private bool? receivesAdminInfoEmailsField;
    private bool receivesAdminInfoEmailsFieldSpecified;
    private bool? receivesInfoEmailsField;
    private bool receivesInfoEmailsFieldSpecified;
    private string senderEmailField;
    private string senderNameField;
    private QueryResult sharesField;
    private string signatureField;
    private string smallBannerPhotoUrlField;
    private string smallPhotoUrlField;
    private string stateField;
    private string stayInTouchNoteField;
    private string stayInTouchSignatureField;
    private string stayInTouchSubjectField;
    private string streetField;
    private QueryResult subProjects1__rField;
    private QueryResult subProjects2__rField;
    private QueryResult subProjects__rField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string team_Lead__cField;
    private string team_Name__cField;
    private string team_VP__cField;
    private string timeZoneSidKeyField;
    private string titleField;
    private QueryResult undecidedEventRelationsField;
    private QueryResult userEntityAccessRightsField;
    private QueryResult userFieldAccessRightsField;
    private bool? userPermissionsAvantgoUserField;
    private bool userPermissionsAvantgoUserFieldSpecified;
    private bool? userPermissionsCallCenterAutoLoginField;
    private bool userPermissionsCallCenterAutoLoginFieldSpecified;
    private bool? userPermissionsChatterAnswersUserField;
    private bool userPermissionsChatterAnswersUserFieldSpecified;
    private bool? userPermissionsInteractionUserField;
    private bool userPermissionsInteractionUserFieldSpecified;
    private bool? userPermissionsKnowledgeUserField;
    private bool userPermissionsKnowledgeUserFieldSpecified;
    private bool? userPermissionsMarketingUserField;
    private bool userPermissionsMarketingUserFieldSpecified;
    private bool? userPermissionsMobileUserField;
    private bool userPermissionsMobileUserFieldSpecified;
    private bool? userPermissionsOfflineUserField;
    private bool userPermissionsOfflineUserFieldSpecified;
    private bool? userPermissionsSFContentUserField;
    private bool userPermissionsSFContentUserFieldSpecified;
    private bool? userPermissionsSupportUserField;
    private bool userPermissionsSupportUserFieldSpecified;
    private bool? userPermissionsWorkDotComUserFeatureField;
    private bool userPermissionsWorkDotComUserFeatureFieldSpecified;
    private QueryResult userPreferencesField;
    private bool? userPreferencesActivityRemindersPopupField;
    private bool userPreferencesActivityRemindersPopupFieldSpecified;
    private bool? userPreferencesApexPagesDeveloperModeField;
    private bool userPreferencesApexPagesDeveloperModeFieldSpecified;
    private bool? userPreferencesCacheDiagnosticsField;
    private bool userPreferencesCacheDiagnosticsFieldSpecified;
    private bool? userPreferencesCreateLEXAppsWTShownField;
    private bool userPreferencesCreateLEXAppsWTShownFieldSpecified;
    private bool? userPreferencesDisCommentAfterLikeEmailField;
    private bool userPreferencesDisCommentAfterLikeEmailFieldSpecified;
    private bool? userPreferencesDisMentionsCommentEmailField;
    private bool userPreferencesDisMentionsCommentEmailFieldSpecified;
    private bool? userPreferencesDisProfPostCommentEmailField;
    private bool userPreferencesDisProfPostCommentEmailFieldSpecified;
    private bool? userPreferencesDisableAllFeedsEmailField;
    private bool userPreferencesDisableAllFeedsEmailFieldSpecified;
    private bool? userPreferencesDisableBookmarkEmailField;
    private bool userPreferencesDisableBookmarkEmailFieldSpecified;
    private bool? userPreferencesDisableChangeCommentEmailField;
    private bool userPreferencesDisableChangeCommentEmailFieldSpecified;
    private bool? userPreferencesDisableEndorsementEmailField;
    private bool userPreferencesDisableEndorsementEmailFieldSpecified;
    private bool? userPreferencesDisableFeedbackEmailField;
    private bool userPreferencesDisableFeedbackEmailFieldSpecified;
    private bool? userPreferencesDisableFileShareNotificationsForApiField;
    private bool userPreferencesDisableFileShareNotificationsForApiFieldSpecified;
    private bool? userPreferencesDisableFollowersEmailField;
    private bool userPreferencesDisableFollowersEmailFieldSpecified;
    private bool? userPreferencesDisableLaterCommentEmailField;
    private bool userPreferencesDisableLaterCommentEmailFieldSpecified;
    private bool? userPreferencesDisableLikeEmailField;
    private bool userPreferencesDisableLikeEmailFieldSpecified;
    private bool? userPreferencesDisableMentionsPostEmailField;
    private bool userPreferencesDisableMentionsPostEmailFieldSpecified;
    private bool? userPreferencesDisableMessageEmailField;
    private bool userPreferencesDisableMessageEmailFieldSpecified;
    private bool? userPreferencesDisableProfilePostEmailField;
    private bool userPreferencesDisableProfilePostEmailFieldSpecified;
    private bool? userPreferencesDisableSharePostEmailField;
    private bool userPreferencesDisableSharePostEmailFieldSpecified;
    private bool? userPreferencesDisableWorkEmailField;
    private bool userPreferencesDisableWorkEmailFieldSpecified;
    private bool? userPreferencesEnableAutoSubForFeedsField;
    private bool userPreferencesEnableAutoSubForFeedsFieldSpecified;
    private bool? userPreferencesEventRemindersCheckboxDefaultField;
    private bool userPreferencesEventRemindersCheckboxDefaultFieldSpecified;
    private bool? userPreferencesFavoritesWTShownField;
    private bool userPreferencesFavoritesWTShownFieldSpecified;
    private bool? userPreferencesGlobalNavBarWTShownField;
    private bool userPreferencesGlobalNavBarWTShownFieldSpecified;
    private bool? userPreferencesGlobalNavGridMenuWTShownField;
    private bool userPreferencesGlobalNavGridMenuWTShownFieldSpecified;
    private bool? userPreferencesHideBiggerPhotoCalloutField;
    private bool userPreferencesHideBiggerPhotoCalloutFieldSpecified;
    private bool? userPreferencesHideCSNDesktopTaskField;
    private bool userPreferencesHideCSNDesktopTaskFieldSpecified;
    private bool? userPreferencesHideCSNGetChatterMobileTaskField;
    private bool userPreferencesHideCSNGetChatterMobileTaskFieldSpecified;
    private bool? userPreferencesHideChatterOnboardingSplashField;
    private bool userPreferencesHideChatterOnboardingSplashFieldSpecified;
    private bool? userPreferencesHideEndUserOnboardingAssistantModalField;
    private bool userPreferencesHideEndUserOnboardingAssistantModalFieldSpecified;
    private bool? userPreferencesHideLightningMigrationModalField;
    private bool userPreferencesHideLightningMigrationModalFieldSpecified;
    private bool? userPreferencesHideS1BrowserUIField;
    private bool userPreferencesHideS1BrowserUIFieldSpecified;
    private bool? userPreferencesHideSecondChatterOnboardingSplashField;
    private bool userPreferencesHideSecondChatterOnboardingSplashFieldSpecified;
    private bool? userPreferencesHideSfxWelcomeMatField;
    private bool userPreferencesHideSfxWelcomeMatFieldSpecified;
    private bool? userPreferencesLightningExperiencePreferredField;
    private bool userPreferencesLightningExperiencePreferredFieldSpecified;
    private bool? userPreferencesPathAssistantCollapsedField;
    private bool userPreferencesPathAssistantCollapsedFieldSpecified;
    private bool? userPreferencesPreviewLightningField;
    private bool userPreferencesPreviewLightningFieldSpecified;
    private bool? userPreferencesReminderSoundOffField;
    private bool userPreferencesReminderSoundOffFieldSpecified;
    private bool? userPreferencesShowCityToExternalUsersField;
    private bool userPreferencesShowCityToExternalUsersFieldSpecified;
    private bool? userPreferencesShowCityToGuestUsersField;
    private bool userPreferencesShowCityToGuestUsersFieldSpecified;
    private bool? userPreferencesShowCountryToExternalUsersField;
    private bool userPreferencesShowCountryToExternalUsersFieldSpecified;
    private bool? userPreferencesShowCountryToGuestUsersField;
    private bool userPreferencesShowCountryToGuestUsersFieldSpecified;
    private bool? userPreferencesShowEmailToExternalUsersField;
    private bool userPreferencesShowEmailToExternalUsersFieldSpecified;
    private bool? userPreferencesShowEmailToGuestUsersField;
    private bool userPreferencesShowEmailToGuestUsersFieldSpecified;
    private bool? userPreferencesShowFaxToExternalUsersField;
    private bool userPreferencesShowFaxToExternalUsersFieldSpecified;
    private bool? userPreferencesShowFaxToGuestUsersField;
    private bool userPreferencesShowFaxToGuestUsersFieldSpecified;
    private bool? userPreferencesShowManagerToExternalUsersField;
    private bool userPreferencesShowManagerToExternalUsersFieldSpecified;
    private bool? userPreferencesShowManagerToGuestUsersField;
    private bool userPreferencesShowManagerToGuestUsersFieldSpecified;
    private bool? userPreferencesShowMobilePhoneToExternalUsersField;
    private bool userPreferencesShowMobilePhoneToExternalUsersFieldSpecified;
    private bool? userPreferencesShowMobilePhoneToGuestUsersField;
    private bool userPreferencesShowMobilePhoneToGuestUsersFieldSpecified;
    private bool? userPreferencesShowPostalCodeToExternalUsersField;
    private bool userPreferencesShowPostalCodeToExternalUsersFieldSpecified;
    private bool? userPreferencesShowPostalCodeToGuestUsersField;
    private bool userPreferencesShowPostalCodeToGuestUsersFieldSpecified;
    private bool? userPreferencesShowProfilePicToGuestUsersField;
    private bool userPreferencesShowProfilePicToGuestUsersFieldSpecified;
    private bool? userPreferencesShowStateToExternalUsersField;
    private bool userPreferencesShowStateToExternalUsersFieldSpecified;
    private bool? userPreferencesShowStateToGuestUsersField;
    private bool userPreferencesShowStateToGuestUsersFieldSpecified;
    private bool? userPreferencesShowStreetAddressToExternalUsersField;
    private bool userPreferencesShowStreetAddressToExternalUsersFieldSpecified;
    private bool? userPreferencesShowStreetAddressToGuestUsersField;
    private bool userPreferencesShowStreetAddressToGuestUsersFieldSpecified;
    private bool? userPreferencesShowTitleToExternalUsersField;
    private bool userPreferencesShowTitleToExternalUsersFieldSpecified;
    private bool? userPreferencesShowTitleToGuestUsersField;
    private bool userPreferencesShowTitleToGuestUsersFieldSpecified;
    private bool? userPreferencesShowWorkPhoneToExternalUsersField;
    private bool userPreferencesShowWorkPhoneToExternalUsersFieldSpecified;
    private bool? userPreferencesShowWorkPhoneToGuestUsersField;
    private bool userPreferencesShowWorkPhoneToGuestUsersFieldSpecified;
    private bool? userPreferencesSortFeedByCommentField;
    private bool userPreferencesSortFeedByCommentFieldSpecified;
    private bool? userPreferencesTaskRemindersCheckboxDefaultField;
    private bool userPreferencesTaskRemindersCheckboxDefaultFieldSpecified;
    private UserRole userRoleField;
    private string userRoleIdField;
    private QueryResult userSitesField;
    private string userTypeField;
    private string usernameField;

    [XmlElement(IsNullable = true)]
    public string AboutMe
    {
      get => this.aboutMeField;
      set => this.aboutMeField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AcceptedEventRelations
    {
      get => this.acceptedEventRelationsField;
      set => this.acceptedEventRelationsField = value;
    }

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
    public address Address
    {
      get => this.addressField;
      set => this.addressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Alias
    {
      get => this.aliasField;
      set => this.aliasField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BadgeText
    {
      get => this.badgeTextField;
      set => this.badgeTextField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BannerPhotoUrl
    {
      get => this.bannerPhotoUrlField;
      set => this.bannerPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CLM_User_Preferences__r
    {
      get => this.cLM_User_Preferences__rField;
      set => this.cLM_User_Preferences__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CallCenterId
    {
      get => this.callCenterIdField;
      set => this.callCenterIdField = value;
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
    public string CommunityNickname
    {
      get => this.communityNicknameField;
      set => this.communityNicknameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CompanyName
    {
      get => this.companyNameField;
      set => this.companyNameField = value;
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
    public QueryResult ContractsSigned
    {
      get => this.contractsSignedField;
      set => this.contractsSignedField = value;
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
    public QueryResult DeclinedEventRelations
    {
      get => this.declinedEventRelationsField;
      set => this.declinedEventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultGroupNotificationFrequency
    {
      get => this.defaultGroupNotificationFrequencyField;
      set => this.defaultGroupNotificationFrequencyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DelegatedApproverId
    {
      get => this.delegatedApproverIdField;
      set => this.delegatedApproverIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DelegatedUsers
    {
      get => this.delegatedUsersField;
      set => this.delegatedUsersField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Department
    {
      get => this.departmentField;
      set => this.departmentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DigestFrequency
    {
      get => this.digestFrequencyField;
      set => this.digestFrequencyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Division
    {
      get => this.divisionField;
      set => this.divisionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Email
    {
      get => this.emailField;
      set => this.emailField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EmailEncodingKey
    {
      get => this.emailEncodingKeyField;
      set => this.emailEncodingKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult EmailMessageRelations
    {
      get => this.emailMessageRelationsField;
      set => this.emailMessageRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? EmailPreferencesAutoBcc
    {
      get => this.emailPreferencesAutoBccField;
      set => this.emailPreferencesAutoBccField = value;
    }

    [XmlIgnore]
    public bool EmailPreferencesAutoBccSpecified
    {
      get => this.emailPreferencesAutoBccFieldSpecified;
      set => this.emailPreferencesAutoBccFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? EmailPreferencesAutoBccStayInTouch
    {
      get => this.emailPreferencesAutoBccStayInTouchField;
      set => this.emailPreferencesAutoBccStayInTouchField = value;
    }

    [XmlIgnore]
    public bool EmailPreferencesAutoBccStayInTouchSpecified
    {
      get => this.emailPreferencesAutoBccStayInTouchFieldSpecified;
      set => this.emailPreferencesAutoBccStayInTouchFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? EmailPreferencesStayInTouchReminder
    {
      get => this.emailPreferencesStayInTouchReminderField;
      set => this.emailPreferencesStayInTouchReminderField = value;
    }

    [XmlIgnore]
    public bool EmailPreferencesStayInTouchReminderSpecified
    {
      get => this.emailPreferencesStayInTouchReminderFieldSpecified;
      set => this.emailPreferencesStayInTouchReminderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string EmployeeNumber
    {
      get => this.employeeNumberField;
      set => this.employeeNumberField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult EventRelations
    {
      get => this.eventRelationsField;
      set => this.eventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Extension
    {
      get => this.extensionField;
      set => this.extensionField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ExternalDataUserAuths
    {
      get => this.externalDataUserAuthsField;
      set => this.externalDataUserAuthsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Fax
    {
      get => this.faxField;
      set => this.faxField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FederationIdentifier
    {
      get => this.federationIdentifierField;
      set => this.federationIdentifierField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptions
    {
      get => this.feedSubscriptionsField;
      set => this.feedSubscriptionsField = value;
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
    public string FirstName
    {
      get => this.firstNameField;
      set => this.firstNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ForecastEnabled
    {
      get => this.forecastEnabledField;
      set => this.forecastEnabledField = value;
    }

    [XmlIgnore]
    public bool ForecastEnabledSpecified
    {
      get => this.forecastEnabledFieldSpecified;
      set => this.forecastEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string FullPhotoUrl
    {
      get => this.fullPhotoUrlField;
      set => this.fullPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GeocodeAccuracy
    {
      get => this.geocodeAccuracyField;
      set => this.geocodeAccuracyField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult GroupMembershipRequests
    {
      get => this.groupMembershipRequestsField;
      set => this.groupMembershipRequestsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult GroupMemberships
    {
      get => this.groupMembershipsField;
      set => this.groupMembershipsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult InstalledMobileApps
    {
      get => this.installedMobileAppsField;
      set => this.installedMobileAppsField = value;
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
    public bool? IsProfilePhotoActive
    {
      get => this.isProfilePhotoActiveField;
      set => this.isProfilePhotoActiveField = value;
    }

    [XmlIgnore]
    public bool IsProfilePhotoActiveSpecified
    {
      get => this.isProfilePhotoActiveFieldSpecified;
      set => this.isProfilePhotoActiveFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LanguageLocaleKey
    {
      get => this.languageLocaleKeyField;
      set => this.languageLocaleKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastLoginDate
    {
      get => this.lastLoginDateField;
      set => this.lastLoginDateField = value;
    }

    [XmlIgnore]
    public bool LastLoginDateSpecified
    {
      get => this.lastLoginDateFieldSpecified;
      set => this.lastLoginDateFieldSpecified = value;
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
    public string LastName
    {
      get => this.lastNameField;
      set => this.lastNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastPasswordChangeDate
    {
      get => this.lastPasswordChangeDateField;
      set => this.lastPasswordChangeDateField = value;
    }

    [XmlIgnore]
    public bool LastPasswordChangeDateSpecified
    {
      get => this.lastPasswordChangeDateFieldSpecified;
      set => this.lastPasswordChangeDateFieldSpecified = value;
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
    public string Level_3_NT_Login_Name__c
    {
      get => this.level_3_NT_Login_Name__cField;
      set => this.level_3_NT_Login_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? License_Allocation__c
    {
      get => this.license_Allocation__cField;
      set => this.license_Allocation__cField = value;
    }

    [XmlIgnore]
    public bool License_Allocation__cSpecified
    {
      get => this.license_Allocation__cFieldSpecified;
      set => this.license_Allocation__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LocaleSidKey
    {
      get => this.localeSidKeyField;
      set => this.localeSidKeyField = value;
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
    public QueryResult ManagedUsers
    {
      get => this.managedUsersField;
      set => this.managedUsersField = value;
    }

    [XmlElement(IsNullable = true)]
    public User Manager
    {
      get => this.managerField;
      set => this.managerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ManagerId
    {
      get => this.managerIdField;
      set => this.managerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MediumBannerPhotoUrl
    {
      get => this.mediumBannerPhotoUrlField;
      set => this.mediumBannerPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MediumPhotoUrl
    {
      get => this.mediumPhotoUrlField;
      set => this.mediumPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobilePhone
    {
      get => this.mobilePhoneField;
      set => this.mobilePhoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? OfflinePdaTrialExpirationDate
    {
      get => this.offlinePdaTrialExpirationDateField;
      set => this.offlinePdaTrialExpirationDateField = value;
    }

    [XmlIgnore]
    public bool OfflinePdaTrialExpirationDateSpecified
    {
      get => this.offlinePdaTrialExpirationDateFieldSpecified;
      set => this.offlinePdaTrialExpirationDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? OfflineTrialExpirationDate
    {
      get => this.offlineTrialExpirationDateField;
      set => this.offlineTrialExpirationDateField = value;
    }

    [XmlIgnore]
    public bool OfflineTrialExpirationDateSpecified
    {
      get => this.offlineTrialExpirationDateFieldSpecified;
      set => this.offlineTrialExpirationDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OutgoingEmailRelations
    {
      get => this.outgoingEmailRelationsField;
      set => this.outgoingEmailRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OwnedContentDocuments
    {
      get => this.ownedContentDocumentsField;
      set => this.ownedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult PermissionSetAssignments
    {
      get => this.permissionSetAssignmentsField;
      set => this.permissionSetAssignmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult PermissionSetLicenseAssignments
    {
      get => this.permissionSetLicenseAssignmentsField;
      set => this.permissionSetLicenseAssignmentsField = value;
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
    public Profile Profile
    {
      get => this.profileField;
      set => this.profileField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProfileId
    {
      get => this.profileIdField;
      set => this.profileIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Projects__r
    {
      get => this.projects__rField;
      set => this.projects__rField = value;
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
    public string SenderEmail
    {
      get => this.senderEmailField;
      set => this.senderEmailField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SenderName
    {
      get => this.senderNameField;
      set => this.senderNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Shares
    {
      get => this.sharesField;
      set => this.sharesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Signature
    {
      get => this.signatureField;
      set => this.signatureField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SmallBannerPhotoUrl
    {
      get => this.smallBannerPhotoUrlField;
      set => this.smallBannerPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SmallPhotoUrl
    {
      get => this.smallPhotoUrlField;
      set => this.smallPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string State
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string StayInTouchNote
    {
      get => this.stayInTouchNoteField;
      set => this.stayInTouchNoteField = value;
    }

    [XmlElement(IsNullable = true)]
    public string StayInTouchSignature
    {
      get => this.stayInTouchSignatureField;
      set => this.stayInTouchSignatureField = value;
    }

    [XmlElement(IsNullable = true)]
    public string StayInTouchSubject
    {
      get => this.stayInTouchSubjectField;
      set => this.stayInTouchSubjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Street
    {
      get => this.streetField;
      set => this.streetField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SubProjects1__r
    {
      get => this.subProjects1__rField;
      set => this.subProjects1__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SubProjects2__r
    {
      get => this.subProjects2__rField;
      set => this.subProjects2__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SubProjects__r
    {
      get => this.subProjects__rField;
      set => this.subProjects__rField = value;
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
    public string Team_Lead__c
    {
      get => this.team_Lead__cField;
      set => this.team_Lead__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Team_Name__c
    {
      get => this.team_Name__cField;
      set => this.team_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Team_VP__c
    {
      get => this.team_VP__cField;
      set => this.team_VP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TimeZoneSidKey
    {
      get => this.timeZoneSidKeyField;
      set => this.timeZoneSidKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult UndecidedEventRelations
    {
      get => this.undecidedEventRelationsField;
      set => this.undecidedEventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult UserEntityAccessRights
    {
      get => this.userEntityAccessRightsField;
      set => this.userEntityAccessRightsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult UserFieldAccessRights
    {
      get => this.userFieldAccessRightsField;
      set => this.userFieldAccessRightsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsAvantgoUser
    {
      get => this.userPermissionsAvantgoUserField;
      set => this.userPermissionsAvantgoUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsAvantgoUserSpecified
    {
      get => this.userPermissionsAvantgoUserFieldSpecified;
      set => this.userPermissionsAvantgoUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsCallCenterAutoLogin
    {
      get => this.userPermissionsCallCenterAutoLoginField;
      set => this.userPermissionsCallCenterAutoLoginField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsCallCenterAutoLoginSpecified
    {
      get => this.userPermissionsCallCenterAutoLoginFieldSpecified;
      set => this.userPermissionsCallCenterAutoLoginFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsChatterAnswersUser
    {
      get => this.userPermissionsChatterAnswersUserField;
      set => this.userPermissionsChatterAnswersUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsChatterAnswersUserSpecified
    {
      get => this.userPermissionsChatterAnswersUserFieldSpecified;
      set => this.userPermissionsChatterAnswersUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsInteractionUser
    {
      get => this.userPermissionsInteractionUserField;
      set => this.userPermissionsInteractionUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsInteractionUserSpecified
    {
      get => this.userPermissionsInteractionUserFieldSpecified;
      set => this.userPermissionsInteractionUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsKnowledgeUser
    {
      get => this.userPermissionsKnowledgeUserField;
      set => this.userPermissionsKnowledgeUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsKnowledgeUserSpecified
    {
      get => this.userPermissionsKnowledgeUserFieldSpecified;
      set => this.userPermissionsKnowledgeUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsMarketingUser
    {
      get => this.userPermissionsMarketingUserField;
      set => this.userPermissionsMarketingUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsMarketingUserSpecified
    {
      get => this.userPermissionsMarketingUserFieldSpecified;
      set => this.userPermissionsMarketingUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsMobileUser
    {
      get => this.userPermissionsMobileUserField;
      set => this.userPermissionsMobileUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsMobileUserSpecified
    {
      get => this.userPermissionsMobileUserFieldSpecified;
      set => this.userPermissionsMobileUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsOfflineUser
    {
      get => this.userPermissionsOfflineUserField;
      set => this.userPermissionsOfflineUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsOfflineUserSpecified
    {
      get => this.userPermissionsOfflineUserFieldSpecified;
      set => this.userPermissionsOfflineUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsSFContentUser
    {
      get => this.userPermissionsSFContentUserField;
      set => this.userPermissionsSFContentUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsSFContentUserSpecified
    {
      get => this.userPermissionsSFContentUserFieldSpecified;
      set => this.userPermissionsSFContentUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsSupportUser
    {
      get => this.userPermissionsSupportUserField;
      set => this.userPermissionsSupportUserField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsSupportUserSpecified
    {
      get => this.userPermissionsSupportUserFieldSpecified;
      set => this.userPermissionsSupportUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPermissionsWorkDotComUserFeature
    {
      get => this.userPermissionsWorkDotComUserFeatureField;
      set => this.userPermissionsWorkDotComUserFeatureField = value;
    }

    [XmlIgnore]
    public bool UserPermissionsWorkDotComUserFeatureSpecified
    {
      get => this.userPermissionsWorkDotComUserFeatureFieldSpecified;
      set => this.userPermissionsWorkDotComUserFeatureFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult UserPreferences
    {
      get => this.userPreferencesField;
      set => this.userPreferencesField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesActivityRemindersPopup
    {
      get => this.userPreferencesActivityRemindersPopupField;
      set => this.userPreferencesActivityRemindersPopupField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesActivityRemindersPopupSpecified
    {
      get => this.userPreferencesActivityRemindersPopupFieldSpecified;
      set => this.userPreferencesActivityRemindersPopupFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesApexPagesDeveloperMode
    {
      get => this.userPreferencesApexPagesDeveloperModeField;
      set => this.userPreferencesApexPagesDeveloperModeField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesApexPagesDeveloperModeSpecified
    {
      get => this.userPreferencesApexPagesDeveloperModeFieldSpecified;
      set => this.userPreferencesApexPagesDeveloperModeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesCacheDiagnostics
    {
      get => this.userPreferencesCacheDiagnosticsField;
      set => this.userPreferencesCacheDiagnosticsField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesCacheDiagnosticsSpecified
    {
      get => this.userPreferencesCacheDiagnosticsFieldSpecified;
      set => this.userPreferencesCacheDiagnosticsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesCreateLEXAppsWTShown
    {
      get => this.userPreferencesCreateLEXAppsWTShownField;
      set => this.userPreferencesCreateLEXAppsWTShownField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesCreateLEXAppsWTShownSpecified
    {
      get => this.userPreferencesCreateLEXAppsWTShownFieldSpecified;
      set => this.userPreferencesCreateLEXAppsWTShownFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisCommentAfterLikeEmail
    {
      get => this.userPreferencesDisCommentAfterLikeEmailField;
      set => this.userPreferencesDisCommentAfterLikeEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisCommentAfterLikeEmailSpecified
    {
      get => this.userPreferencesDisCommentAfterLikeEmailFieldSpecified;
      set => this.userPreferencesDisCommentAfterLikeEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisMentionsCommentEmail
    {
      get => this.userPreferencesDisMentionsCommentEmailField;
      set => this.userPreferencesDisMentionsCommentEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisMentionsCommentEmailSpecified
    {
      get => this.userPreferencesDisMentionsCommentEmailFieldSpecified;
      set => this.userPreferencesDisMentionsCommentEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisProfPostCommentEmail
    {
      get => this.userPreferencesDisProfPostCommentEmailField;
      set => this.userPreferencesDisProfPostCommentEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisProfPostCommentEmailSpecified
    {
      get => this.userPreferencesDisProfPostCommentEmailFieldSpecified;
      set => this.userPreferencesDisProfPostCommentEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableAllFeedsEmail
    {
      get => this.userPreferencesDisableAllFeedsEmailField;
      set => this.userPreferencesDisableAllFeedsEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableAllFeedsEmailSpecified
    {
      get => this.userPreferencesDisableAllFeedsEmailFieldSpecified;
      set => this.userPreferencesDisableAllFeedsEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableBookmarkEmail
    {
      get => this.userPreferencesDisableBookmarkEmailField;
      set => this.userPreferencesDisableBookmarkEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableBookmarkEmailSpecified
    {
      get => this.userPreferencesDisableBookmarkEmailFieldSpecified;
      set => this.userPreferencesDisableBookmarkEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableChangeCommentEmail
    {
      get => this.userPreferencesDisableChangeCommentEmailField;
      set => this.userPreferencesDisableChangeCommentEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableChangeCommentEmailSpecified
    {
      get => this.userPreferencesDisableChangeCommentEmailFieldSpecified;
      set => this.userPreferencesDisableChangeCommentEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableEndorsementEmail
    {
      get => this.userPreferencesDisableEndorsementEmailField;
      set => this.userPreferencesDisableEndorsementEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableEndorsementEmailSpecified
    {
      get => this.userPreferencesDisableEndorsementEmailFieldSpecified;
      set => this.userPreferencesDisableEndorsementEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableFeedbackEmail
    {
      get => this.userPreferencesDisableFeedbackEmailField;
      set => this.userPreferencesDisableFeedbackEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableFeedbackEmailSpecified
    {
      get => this.userPreferencesDisableFeedbackEmailFieldSpecified;
      set => this.userPreferencesDisableFeedbackEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableFileShareNotificationsForApi
    {
      get => this.userPreferencesDisableFileShareNotificationsForApiField;
      set => this.userPreferencesDisableFileShareNotificationsForApiField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableFileShareNotificationsForApiSpecified
    {
      get => this.userPreferencesDisableFileShareNotificationsForApiFieldSpecified;
      set => this.userPreferencesDisableFileShareNotificationsForApiFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableFollowersEmail
    {
      get => this.userPreferencesDisableFollowersEmailField;
      set => this.userPreferencesDisableFollowersEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableFollowersEmailSpecified
    {
      get => this.userPreferencesDisableFollowersEmailFieldSpecified;
      set => this.userPreferencesDisableFollowersEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableLaterCommentEmail
    {
      get => this.userPreferencesDisableLaterCommentEmailField;
      set => this.userPreferencesDisableLaterCommentEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableLaterCommentEmailSpecified
    {
      get => this.userPreferencesDisableLaterCommentEmailFieldSpecified;
      set => this.userPreferencesDisableLaterCommentEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableLikeEmail
    {
      get => this.userPreferencesDisableLikeEmailField;
      set => this.userPreferencesDisableLikeEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableLikeEmailSpecified
    {
      get => this.userPreferencesDisableLikeEmailFieldSpecified;
      set => this.userPreferencesDisableLikeEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableMentionsPostEmail
    {
      get => this.userPreferencesDisableMentionsPostEmailField;
      set => this.userPreferencesDisableMentionsPostEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableMentionsPostEmailSpecified
    {
      get => this.userPreferencesDisableMentionsPostEmailFieldSpecified;
      set => this.userPreferencesDisableMentionsPostEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableMessageEmail
    {
      get => this.userPreferencesDisableMessageEmailField;
      set => this.userPreferencesDisableMessageEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableMessageEmailSpecified
    {
      get => this.userPreferencesDisableMessageEmailFieldSpecified;
      set => this.userPreferencesDisableMessageEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableProfilePostEmail
    {
      get => this.userPreferencesDisableProfilePostEmailField;
      set => this.userPreferencesDisableProfilePostEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableProfilePostEmailSpecified
    {
      get => this.userPreferencesDisableProfilePostEmailFieldSpecified;
      set => this.userPreferencesDisableProfilePostEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableSharePostEmail
    {
      get => this.userPreferencesDisableSharePostEmailField;
      set => this.userPreferencesDisableSharePostEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableSharePostEmailSpecified
    {
      get => this.userPreferencesDisableSharePostEmailFieldSpecified;
      set => this.userPreferencesDisableSharePostEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesDisableWorkEmail
    {
      get => this.userPreferencesDisableWorkEmailField;
      set => this.userPreferencesDisableWorkEmailField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesDisableWorkEmailSpecified
    {
      get => this.userPreferencesDisableWorkEmailFieldSpecified;
      set => this.userPreferencesDisableWorkEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesEnableAutoSubForFeeds
    {
      get => this.userPreferencesEnableAutoSubForFeedsField;
      set => this.userPreferencesEnableAutoSubForFeedsField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesEnableAutoSubForFeedsSpecified
    {
      get => this.userPreferencesEnableAutoSubForFeedsFieldSpecified;
      set => this.userPreferencesEnableAutoSubForFeedsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesEventRemindersCheckboxDefault
    {
      get => this.userPreferencesEventRemindersCheckboxDefaultField;
      set => this.userPreferencesEventRemindersCheckboxDefaultField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesEventRemindersCheckboxDefaultSpecified
    {
      get => this.userPreferencesEventRemindersCheckboxDefaultFieldSpecified;
      set => this.userPreferencesEventRemindersCheckboxDefaultFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesFavoritesWTShown
    {
      get => this.userPreferencesFavoritesWTShownField;
      set => this.userPreferencesFavoritesWTShownField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesFavoritesWTShownSpecified
    {
      get => this.userPreferencesFavoritesWTShownFieldSpecified;
      set => this.userPreferencesFavoritesWTShownFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesGlobalNavBarWTShown
    {
      get => this.userPreferencesGlobalNavBarWTShownField;
      set => this.userPreferencesGlobalNavBarWTShownField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesGlobalNavBarWTShownSpecified
    {
      get => this.userPreferencesGlobalNavBarWTShownFieldSpecified;
      set => this.userPreferencesGlobalNavBarWTShownFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesGlobalNavGridMenuWTShown
    {
      get => this.userPreferencesGlobalNavGridMenuWTShownField;
      set => this.userPreferencesGlobalNavGridMenuWTShownField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesGlobalNavGridMenuWTShownSpecified
    {
      get => this.userPreferencesGlobalNavGridMenuWTShownFieldSpecified;
      set => this.userPreferencesGlobalNavGridMenuWTShownFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideBiggerPhotoCallout
    {
      get => this.userPreferencesHideBiggerPhotoCalloutField;
      set => this.userPreferencesHideBiggerPhotoCalloutField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideBiggerPhotoCalloutSpecified
    {
      get => this.userPreferencesHideBiggerPhotoCalloutFieldSpecified;
      set => this.userPreferencesHideBiggerPhotoCalloutFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideCSNDesktopTask
    {
      get => this.userPreferencesHideCSNDesktopTaskField;
      set => this.userPreferencesHideCSNDesktopTaskField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideCSNDesktopTaskSpecified
    {
      get => this.userPreferencesHideCSNDesktopTaskFieldSpecified;
      set => this.userPreferencesHideCSNDesktopTaskFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideCSNGetChatterMobileTask
    {
      get => this.userPreferencesHideCSNGetChatterMobileTaskField;
      set => this.userPreferencesHideCSNGetChatterMobileTaskField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideCSNGetChatterMobileTaskSpecified
    {
      get => this.userPreferencesHideCSNGetChatterMobileTaskFieldSpecified;
      set => this.userPreferencesHideCSNGetChatterMobileTaskFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideChatterOnboardingSplash
    {
      get => this.userPreferencesHideChatterOnboardingSplashField;
      set => this.userPreferencesHideChatterOnboardingSplashField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideChatterOnboardingSplashSpecified
    {
      get => this.userPreferencesHideChatterOnboardingSplashFieldSpecified;
      set => this.userPreferencesHideChatterOnboardingSplashFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideEndUserOnboardingAssistantModal
    {
      get => this.userPreferencesHideEndUserOnboardingAssistantModalField;
      set => this.userPreferencesHideEndUserOnboardingAssistantModalField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideEndUserOnboardingAssistantModalSpecified
    {
      get => this.userPreferencesHideEndUserOnboardingAssistantModalFieldSpecified;
      set => this.userPreferencesHideEndUserOnboardingAssistantModalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideLightningMigrationModal
    {
      get => this.userPreferencesHideLightningMigrationModalField;
      set => this.userPreferencesHideLightningMigrationModalField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideLightningMigrationModalSpecified
    {
      get => this.userPreferencesHideLightningMigrationModalFieldSpecified;
      set => this.userPreferencesHideLightningMigrationModalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideS1BrowserUI
    {
      get => this.userPreferencesHideS1BrowserUIField;
      set => this.userPreferencesHideS1BrowserUIField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideS1BrowserUISpecified
    {
      get => this.userPreferencesHideS1BrowserUIFieldSpecified;
      set => this.userPreferencesHideS1BrowserUIFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideSecondChatterOnboardingSplash
    {
      get => this.userPreferencesHideSecondChatterOnboardingSplashField;
      set => this.userPreferencesHideSecondChatterOnboardingSplashField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideSecondChatterOnboardingSplashSpecified
    {
      get => this.userPreferencesHideSecondChatterOnboardingSplashFieldSpecified;
      set => this.userPreferencesHideSecondChatterOnboardingSplashFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesHideSfxWelcomeMat
    {
      get => this.userPreferencesHideSfxWelcomeMatField;
      set => this.userPreferencesHideSfxWelcomeMatField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesHideSfxWelcomeMatSpecified
    {
      get => this.userPreferencesHideSfxWelcomeMatFieldSpecified;
      set => this.userPreferencesHideSfxWelcomeMatFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesLightningExperiencePreferred
    {
      get => this.userPreferencesLightningExperiencePreferredField;
      set => this.userPreferencesLightningExperiencePreferredField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesLightningExperiencePreferredSpecified
    {
      get => this.userPreferencesLightningExperiencePreferredFieldSpecified;
      set => this.userPreferencesLightningExperiencePreferredFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesPathAssistantCollapsed
    {
      get => this.userPreferencesPathAssistantCollapsedField;
      set => this.userPreferencesPathAssistantCollapsedField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesPathAssistantCollapsedSpecified
    {
      get => this.userPreferencesPathAssistantCollapsedFieldSpecified;
      set => this.userPreferencesPathAssistantCollapsedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesPreviewLightning
    {
      get => this.userPreferencesPreviewLightningField;
      set => this.userPreferencesPreviewLightningField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesPreviewLightningSpecified
    {
      get => this.userPreferencesPreviewLightningFieldSpecified;
      set => this.userPreferencesPreviewLightningFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesReminderSoundOff
    {
      get => this.userPreferencesReminderSoundOffField;
      set => this.userPreferencesReminderSoundOffField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesReminderSoundOffSpecified
    {
      get => this.userPreferencesReminderSoundOffFieldSpecified;
      set => this.userPreferencesReminderSoundOffFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowCityToExternalUsers
    {
      get => this.userPreferencesShowCityToExternalUsersField;
      set => this.userPreferencesShowCityToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowCityToExternalUsersSpecified
    {
      get => this.userPreferencesShowCityToExternalUsersFieldSpecified;
      set => this.userPreferencesShowCityToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowCityToGuestUsers
    {
      get => this.userPreferencesShowCityToGuestUsersField;
      set => this.userPreferencesShowCityToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowCityToGuestUsersSpecified
    {
      get => this.userPreferencesShowCityToGuestUsersFieldSpecified;
      set => this.userPreferencesShowCityToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowCountryToExternalUsers
    {
      get => this.userPreferencesShowCountryToExternalUsersField;
      set => this.userPreferencesShowCountryToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowCountryToExternalUsersSpecified
    {
      get => this.userPreferencesShowCountryToExternalUsersFieldSpecified;
      set => this.userPreferencesShowCountryToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowCountryToGuestUsers
    {
      get => this.userPreferencesShowCountryToGuestUsersField;
      set => this.userPreferencesShowCountryToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowCountryToGuestUsersSpecified
    {
      get => this.userPreferencesShowCountryToGuestUsersFieldSpecified;
      set => this.userPreferencesShowCountryToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowEmailToExternalUsers
    {
      get => this.userPreferencesShowEmailToExternalUsersField;
      set => this.userPreferencesShowEmailToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowEmailToExternalUsersSpecified
    {
      get => this.userPreferencesShowEmailToExternalUsersFieldSpecified;
      set => this.userPreferencesShowEmailToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowEmailToGuestUsers
    {
      get => this.userPreferencesShowEmailToGuestUsersField;
      set => this.userPreferencesShowEmailToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowEmailToGuestUsersSpecified
    {
      get => this.userPreferencesShowEmailToGuestUsersFieldSpecified;
      set => this.userPreferencesShowEmailToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowFaxToExternalUsers
    {
      get => this.userPreferencesShowFaxToExternalUsersField;
      set => this.userPreferencesShowFaxToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowFaxToExternalUsersSpecified
    {
      get => this.userPreferencesShowFaxToExternalUsersFieldSpecified;
      set => this.userPreferencesShowFaxToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowFaxToGuestUsers
    {
      get => this.userPreferencesShowFaxToGuestUsersField;
      set => this.userPreferencesShowFaxToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowFaxToGuestUsersSpecified
    {
      get => this.userPreferencesShowFaxToGuestUsersFieldSpecified;
      set => this.userPreferencesShowFaxToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowManagerToExternalUsers
    {
      get => this.userPreferencesShowManagerToExternalUsersField;
      set => this.userPreferencesShowManagerToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowManagerToExternalUsersSpecified
    {
      get => this.userPreferencesShowManagerToExternalUsersFieldSpecified;
      set => this.userPreferencesShowManagerToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowManagerToGuestUsers
    {
      get => this.userPreferencesShowManagerToGuestUsersField;
      set => this.userPreferencesShowManagerToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowManagerToGuestUsersSpecified
    {
      get => this.userPreferencesShowManagerToGuestUsersFieldSpecified;
      set => this.userPreferencesShowManagerToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowMobilePhoneToExternalUsers
    {
      get => this.userPreferencesShowMobilePhoneToExternalUsersField;
      set => this.userPreferencesShowMobilePhoneToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowMobilePhoneToExternalUsersSpecified
    {
      get => this.userPreferencesShowMobilePhoneToExternalUsersFieldSpecified;
      set => this.userPreferencesShowMobilePhoneToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowMobilePhoneToGuestUsers
    {
      get => this.userPreferencesShowMobilePhoneToGuestUsersField;
      set => this.userPreferencesShowMobilePhoneToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowMobilePhoneToGuestUsersSpecified
    {
      get => this.userPreferencesShowMobilePhoneToGuestUsersFieldSpecified;
      set => this.userPreferencesShowMobilePhoneToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowPostalCodeToExternalUsers
    {
      get => this.userPreferencesShowPostalCodeToExternalUsersField;
      set => this.userPreferencesShowPostalCodeToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowPostalCodeToExternalUsersSpecified
    {
      get => this.userPreferencesShowPostalCodeToExternalUsersFieldSpecified;
      set => this.userPreferencesShowPostalCodeToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowPostalCodeToGuestUsers
    {
      get => this.userPreferencesShowPostalCodeToGuestUsersField;
      set => this.userPreferencesShowPostalCodeToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowPostalCodeToGuestUsersSpecified
    {
      get => this.userPreferencesShowPostalCodeToGuestUsersFieldSpecified;
      set => this.userPreferencesShowPostalCodeToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowProfilePicToGuestUsers
    {
      get => this.userPreferencesShowProfilePicToGuestUsersField;
      set => this.userPreferencesShowProfilePicToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowProfilePicToGuestUsersSpecified
    {
      get => this.userPreferencesShowProfilePicToGuestUsersFieldSpecified;
      set => this.userPreferencesShowProfilePicToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowStateToExternalUsers
    {
      get => this.userPreferencesShowStateToExternalUsersField;
      set => this.userPreferencesShowStateToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowStateToExternalUsersSpecified
    {
      get => this.userPreferencesShowStateToExternalUsersFieldSpecified;
      set => this.userPreferencesShowStateToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowStateToGuestUsers
    {
      get => this.userPreferencesShowStateToGuestUsersField;
      set => this.userPreferencesShowStateToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowStateToGuestUsersSpecified
    {
      get => this.userPreferencesShowStateToGuestUsersFieldSpecified;
      set => this.userPreferencesShowStateToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowStreetAddressToExternalUsers
    {
      get => this.userPreferencesShowStreetAddressToExternalUsersField;
      set => this.userPreferencesShowStreetAddressToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowStreetAddressToExternalUsersSpecified
    {
      get => this.userPreferencesShowStreetAddressToExternalUsersFieldSpecified;
      set => this.userPreferencesShowStreetAddressToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowStreetAddressToGuestUsers
    {
      get => this.userPreferencesShowStreetAddressToGuestUsersField;
      set => this.userPreferencesShowStreetAddressToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowStreetAddressToGuestUsersSpecified
    {
      get => this.userPreferencesShowStreetAddressToGuestUsersFieldSpecified;
      set => this.userPreferencesShowStreetAddressToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowTitleToExternalUsers
    {
      get => this.userPreferencesShowTitleToExternalUsersField;
      set => this.userPreferencesShowTitleToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowTitleToExternalUsersSpecified
    {
      get => this.userPreferencesShowTitleToExternalUsersFieldSpecified;
      set => this.userPreferencesShowTitleToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowTitleToGuestUsers
    {
      get => this.userPreferencesShowTitleToGuestUsersField;
      set => this.userPreferencesShowTitleToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowTitleToGuestUsersSpecified
    {
      get => this.userPreferencesShowTitleToGuestUsersFieldSpecified;
      set => this.userPreferencesShowTitleToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowWorkPhoneToExternalUsers
    {
      get => this.userPreferencesShowWorkPhoneToExternalUsersField;
      set => this.userPreferencesShowWorkPhoneToExternalUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowWorkPhoneToExternalUsersSpecified
    {
      get => this.userPreferencesShowWorkPhoneToExternalUsersFieldSpecified;
      set => this.userPreferencesShowWorkPhoneToExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesShowWorkPhoneToGuestUsers
    {
      get => this.userPreferencesShowWorkPhoneToGuestUsersField;
      set => this.userPreferencesShowWorkPhoneToGuestUsersField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesShowWorkPhoneToGuestUsersSpecified
    {
      get => this.userPreferencesShowWorkPhoneToGuestUsersFieldSpecified;
      set => this.userPreferencesShowWorkPhoneToGuestUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesSortFeedByComment
    {
      get => this.userPreferencesSortFeedByCommentField;
      set => this.userPreferencesSortFeedByCommentField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesSortFeedByCommentSpecified
    {
      get => this.userPreferencesSortFeedByCommentFieldSpecified;
      set => this.userPreferencesSortFeedByCommentFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UserPreferencesTaskRemindersCheckboxDefault
    {
      get => this.userPreferencesTaskRemindersCheckboxDefaultField;
      set => this.userPreferencesTaskRemindersCheckboxDefaultField = value;
    }

    [XmlIgnore]
    public bool UserPreferencesTaskRemindersCheckboxDefaultSpecified
    {
      get => this.userPreferencesTaskRemindersCheckboxDefaultFieldSpecified;
      set => this.userPreferencesTaskRemindersCheckboxDefaultFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRole UserRole
    {
      get => this.userRoleField;
      set => this.userRoleField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserRoleId
    {
      get => this.userRoleIdField;
      set => this.userRoleIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult UserSites
    {
      get => this.userSitesField;
      set => this.userSitesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserType
    {
      get => this.userTypeField;
      set => this.userTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }
  }
}
