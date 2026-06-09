// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PermissionSetLicense
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class PermissionSetLicense : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string developerNameField;
    private DateTime? expirationDateField;
    private bool expirationDateFieldSpecified;
    private QueryResult grantedByLicensesField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string languageField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string masterLabelField;
    private bool? maximumPermissionsActivateContractField;
    private bool maximumPermissionsActivateContractFieldSpecified;
    private bool? maximumPermissionsActivateOrderField;
    private bool maximumPermissionsActivateOrderFieldSpecified;
    private bool? maximumPermissionsAllowEmailICField;
    private bool maximumPermissionsAllowEmailICFieldSpecified;
    private bool? maximumPermissionsAllowUniversalSearchField;
    private bool maximumPermissionsAllowUniversalSearchFieldSpecified;
    private bool? maximumPermissionsAllowViewEditConvertedLeadsField;
    private bool maximumPermissionsAllowViewEditConvertedLeadsFieldSpecified;
    private bool? maximumPermissionsAllowViewKnowledgeField;
    private bool maximumPermissionsAllowViewKnowledgeFieldSpecified;
    private bool? maximumPermissionsApiEnabledField;
    private bool maximumPermissionsApiEnabledFieldSpecified;
    private bool? maximumPermissionsApiUserOnlyField;
    private bool maximumPermissionsApiUserOnlyFieldSpecified;
    private bool? maximumPermissionsAssignPermissionSetsField;
    private bool maximumPermissionsAssignPermissionSetsFieldSpecified;
    private bool? maximumPermissionsAssignTopicsField;
    private bool maximumPermissionsAssignTopicsFieldSpecified;
    private bool? maximumPermissionsAuthorApexField;
    private bool maximumPermissionsAuthorApexFieldSpecified;
    private bool? maximumPermissionsBulkApiHardDeleteField;
    private bool maximumPermissionsBulkApiHardDeleteFieldSpecified;
    private bool? maximumPermissionsBulkMacrosAllowedField;
    private bool maximumPermissionsBulkMacrosAllowedFieldSpecified;
    private bool? maximumPermissionsCampaignInfluence2Field;
    private bool maximumPermissionsCampaignInfluence2FieldSpecified;
    private bool? maximumPermissionsCanApproveFeedPostField;
    private bool maximumPermissionsCanApproveFeedPostFieldSpecified;
    private bool? maximumPermissionsCanInsertFeedSystemFieldsField;
    private bool maximumPermissionsCanInsertFeedSystemFieldsFieldSpecified;
    private bool? maximumPermissionsCanUseNewDashboardBuilderField;
    private bool maximumPermissionsCanUseNewDashboardBuilderFieldSpecified;
    private bool? maximumPermissionsChatterComposeUiCodesnippetField;
    private bool maximumPermissionsChatterComposeUiCodesnippetFieldSpecified;
    private bool? maximumPermissionsChatterEditOwnPostField;
    private bool maximumPermissionsChatterEditOwnPostFieldSpecified;
    private bool? maximumPermissionsChatterEditOwnRecordPostField;
    private bool maximumPermissionsChatterEditOwnRecordPostFieldSpecified;
    private bool? maximumPermissionsChatterFileLinkField;
    private bool maximumPermissionsChatterFileLinkFieldSpecified;
    private bool? maximumPermissionsChatterInternalUserField;
    private bool maximumPermissionsChatterInternalUserFieldSpecified;
    private bool? maximumPermissionsChatterInviteExternalUsersField;
    private bool maximumPermissionsChatterInviteExternalUsersFieldSpecified;
    private bool? maximumPermissionsChatterOwnGroupsField;
    private bool maximumPermissionsChatterOwnGroupsFieldSpecified;
    private bool? maximumPermissionsConfigCustomRecsField;
    private bool maximumPermissionsConfigCustomRecsFieldSpecified;
    private bool? maximumPermissionsConnectOrgToEnvironmentHubField;
    private bool maximumPermissionsConnectOrgToEnvironmentHubFieldSpecified;
    private bool? maximumPermissionsContentAdministratorField;
    private bool maximumPermissionsContentAdministratorFieldSpecified;
    private bool? maximumPermissionsConvertLeadsField;
    private bool maximumPermissionsConvertLeadsFieldSpecified;
    private bool? maximumPermissionsCreateCustomizeDashboardsField;
    private bool maximumPermissionsCreateCustomizeDashboardsFieldSpecified;
    private bool? maximumPermissionsCreateCustomizeFiltersField;
    private bool maximumPermissionsCreateCustomizeFiltersFieldSpecified;
    private bool? maximumPermissionsCreateCustomizeReportsField;
    private bool maximumPermissionsCreateCustomizeReportsFieldSpecified;
    private bool? maximumPermissionsCreateDashboardFoldersField;
    private bool maximumPermissionsCreateDashboardFoldersFieldSpecified;
    private bool? maximumPermissionsCreatePackagingField;
    private bool maximumPermissionsCreatePackagingFieldSpecified;
    private bool? maximumPermissionsCreateReportFoldersField;
    private bool maximumPermissionsCreateReportFoldersFieldSpecified;
    private bool? maximumPermissionsCreateTopicsField;
    private bool maximumPermissionsCreateTopicsFieldSpecified;
    private bool? maximumPermissionsCreateWorkspacesField;
    private bool maximumPermissionsCreateWorkspacesFieldSpecified;
    private bool? maximumPermissionsCustomMobileAppsAccessField;
    private bool maximumPermissionsCustomMobileAppsAccessFieldSpecified;
    private bool? maximumPermissionsCustomSidebarOnAllPagesField;
    private bool maximumPermissionsCustomSidebarOnAllPagesFieldSpecified;
    private bool? maximumPermissionsCustomizeApplicationField;
    private bool maximumPermissionsCustomizeApplicationFieldSpecified;
    private bool? maximumPermissionsDataExportField;
    private bool maximumPermissionsDataExportFieldSpecified;
    private bool? maximumPermissionsDelegatedTwoFactorField;
    private bool maximumPermissionsDelegatedTwoFactorFieldSpecified;
    private bool? maximumPermissionsDeleteActivatedContractField;
    private bool maximumPermissionsDeleteActivatedContractFieldSpecified;
    private bool? maximumPermissionsDeleteTopicsField;
    private bool maximumPermissionsDeleteTopicsFieldSpecified;
    private bool? maximumPermissionsDistributeFromPersWkspField;
    private bool maximumPermissionsDistributeFromPersWkspFieldSpecified;
    private bool? maximumPermissionsEditActivatedOrdersField;
    private bool maximumPermissionsEditActivatedOrdersFieldSpecified;
    private bool? maximumPermissionsEditBrandTemplatesField;
    private bool maximumPermissionsEditBrandTemplatesFieldSpecified;
    private bool? maximumPermissionsEditCaseCommentsField;
    private bool maximumPermissionsEditCaseCommentsFieldSpecified;
    private bool? maximumPermissionsEditEventField;
    private bool maximumPermissionsEditEventFieldSpecified;
    private bool? maximumPermissionsEditHtmlTemplatesField;
    private bool maximumPermissionsEditHtmlTemplatesFieldSpecified;
    private bool? maximumPermissionsEditKnowledgeField;
    private bool maximumPermissionsEditKnowledgeFieldSpecified;
    private bool? maximumPermissionsEditMyDashboardsField;
    private bool maximumPermissionsEditMyDashboardsFieldSpecified;
    private bool? maximumPermissionsEditMyReportsField;
    private bool maximumPermissionsEditMyReportsFieldSpecified;
    private bool? maximumPermissionsEditOppLineItemUnitPriceField;
    private bool maximumPermissionsEditOppLineItemUnitPriceFieldSpecified;
    private bool? maximumPermissionsEditPublicDocumentsField;
    private bool maximumPermissionsEditPublicDocumentsFieldSpecified;
    private bool? maximumPermissionsEditPublicTemplatesField;
    private bool maximumPermissionsEditPublicTemplatesFieldSpecified;
    private bool? maximumPermissionsEditReadonlyFieldsField;
    private bool maximumPermissionsEditReadonlyFieldsFieldSpecified;
    private bool? maximumPermissionsEditTaskField;
    private bool maximumPermissionsEditTaskFieldSpecified;
    private bool? maximumPermissionsEditTopicsField;
    private bool maximumPermissionsEditTopicsFieldSpecified;
    private bool? maximumPermissionsEmailAdministrationField;
    private bool maximumPermissionsEmailAdministrationFieldSpecified;
    private bool? maximumPermissionsEmailMassField;
    private bool maximumPermissionsEmailMassFieldSpecified;
    private bool? maximumPermissionsEmailSingleField;
    private bool maximumPermissionsEmailSingleFieldSpecified;
    private bool? maximumPermissionsEmailTemplateManagementField;
    private bool maximumPermissionsEmailTemplateManagementFieldSpecified;
    private bool? maximumPermissionsEnableNotificationsField;
    private bool maximumPermissionsEnableNotificationsFieldSpecified;
    private bool? maximumPermissionsExportReportField;
    private bool maximumPermissionsExportReportFieldSpecified;
    private bool? maximumPermissionsFlowUFLRequiredField;
    private bool maximumPermissionsFlowUFLRequiredFieldSpecified;
    private bool? maximumPermissionsForceTwoFactorField;
    private bool maximumPermissionsForceTwoFactorFieldSpecified;
    private bool? maximumPermissionsIdentityConnectField;
    private bool maximumPermissionsIdentityConnectFieldSpecified;
    private bool? maximumPermissionsIdentityEnabledField;
    private bool maximumPermissionsIdentityEnabledFieldSpecified;
    private bool? maximumPermissionsImportCustomObjectsField;
    private bool maximumPermissionsImportCustomObjectsFieldSpecified;
    private bool? maximumPermissionsImportLeadsField;
    private bool maximumPermissionsImportLeadsFieldSpecified;
    private bool? maximumPermissionsImportPersonalField;
    private bool maximumPermissionsImportPersonalFieldSpecified;
    private bool? maximumPermissionsInboundMigrationToolsUserField;
    private bool maximumPermissionsInboundMigrationToolsUserFieldSpecified;
    private bool? maximumPermissionsInstallPackagingField;
    private bool maximumPermissionsInstallPackagingFieldSpecified;
    private bool? maximumPermissionsLightningExperienceUserField;
    private bool maximumPermissionsLightningExperienceUserFieldSpecified;
    private bool? maximumPermissionsManageAnalyticSnapshotsField;
    private bool maximumPermissionsManageAnalyticSnapshotsFieldSpecified;
    private bool? maximumPermissionsManageAuthProvidersField;
    private bool maximumPermissionsManageAuthProvidersFieldSpecified;
    private bool? maximumPermissionsManageBusinessHourHolidaysField;
    private bool maximumPermissionsManageBusinessHourHolidaysFieldSpecified;
    private bool? maximumPermissionsManageCallCentersField;
    private bool maximumPermissionsManageCallCentersFieldSpecified;
    private bool? maximumPermissionsManageCasesField;
    private bool maximumPermissionsManageCasesFieldSpecified;
    private bool? maximumPermissionsManageCategoriesField;
    private bool maximumPermissionsManageCategoriesFieldSpecified;
    private bool? maximumPermissionsManageChatterMessagesField;
    private bool maximumPermissionsManageChatterMessagesFieldSpecified;
    private bool? maximumPermissionsManageContentPermissionsField;
    private bool maximumPermissionsManageContentPermissionsFieldSpecified;
    private bool? maximumPermissionsManageContentPropertiesField;
    private bool maximumPermissionsManageContentPropertiesFieldSpecified;
    private bool? maximumPermissionsManageContentTypesField;
    private bool maximumPermissionsManageContentTypesFieldSpecified;
    private bool? maximumPermissionsManageCustomPermissionsField;
    private bool maximumPermissionsManageCustomPermissionsFieldSpecified;
    private bool? maximumPermissionsManageCustomReportTypesField;
    private bool maximumPermissionsManageCustomReportTypesFieldSpecified;
    private bool? maximumPermissionsManageDashbdsInPubFoldersField;
    private bool maximumPermissionsManageDashbdsInPubFoldersFieldSpecified;
    private bool? maximumPermissionsManageDataCategoriesField;
    private bool maximumPermissionsManageDataCategoriesFieldSpecified;
    private bool? maximumPermissionsManageDataIntegrationsField;
    private bool maximumPermissionsManageDataIntegrationsFieldSpecified;
    private bool? maximumPermissionsManageDynamicDashboardsField;
    private bool maximumPermissionsManageDynamicDashboardsFieldSpecified;
    private bool? maximumPermissionsManageEmailClientConfigField;
    private bool maximumPermissionsManageEmailClientConfigFieldSpecified;
    private bool? maximumPermissionsManageExchangeConfigField;
    private bool maximumPermissionsManageExchangeConfigFieldSpecified;
    private bool? maximumPermissionsManageHealthCheckField;
    private bool maximumPermissionsManageHealthCheckFieldSpecified;
    private bool? maximumPermissionsManageInteractionField;
    private bool maximumPermissionsManageInteractionFieldSpecified;
    private bool? maximumPermissionsManageInternalUsersField;
    private bool maximumPermissionsManageInternalUsersFieldSpecified;
    private bool? maximumPermissionsManageIpAddressesField;
    private bool maximumPermissionsManageIpAddressesFieldSpecified;
    private bool? maximumPermissionsManageKnowledgeField;
    private bool maximumPermissionsManageKnowledgeFieldSpecified;
    private bool? maximumPermissionsManageKnowledgeImportExportField;
    private bool maximumPermissionsManageKnowledgeImportExportFieldSpecified;
    private bool? maximumPermissionsManageLeadsField;
    private bool maximumPermissionsManageLeadsFieldSpecified;
    private bool? maximumPermissionsManageLoginAccessPoliciesField;
    private bool maximumPermissionsManageLoginAccessPoliciesFieldSpecified;
    private bool? maximumPermissionsManageMobileField;
    private bool maximumPermissionsManageMobileFieldSpecified;
    private bool? maximumPermissionsManagePasswordPoliciesField;
    private bool maximumPermissionsManagePasswordPoliciesFieldSpecified;
    private bool? maximumPermissionsManageProfilesPermissionsetsField;
    private bool maximumPermissionsManageProfilesPermissionsetsFieldSpecified;
    private bool? maximumPermissionsManagePvtRptsAndDashbdsField;
    private bool maximumPermissionsManagePvtRptsAndDashbdsFieldSpecified;
    private bool? maximumPermissionsManageRemoteAccessField;
    private bool maximumPermissionsManageRemoteAccessFieldSpecified;
    private bool? maximumPermissionsManageReportsInPubFoldersField;
    private bool maximumPermissionsManageReportsInPubFoldersFieldSpecified;
    private bool? maximumPermissionsManageRolesField;
    private bool maximumPermissionsManageRolesFieldSpecified;
    private bool? maximumPermissionsManageSearchPromotionRulesField;
    private bool maximumPermissionsManageSearchPromotionRulesFieldSpecified;
    private bool? maximumPermissionsManageSharingField;
    private bool maximumPermissionsManageSharingFieldSpecified;
    private bool? maximumPermissionsManageSolutionsField;
    private bool maximumPermissionsManageSolutionsFieldSpecified;
    private bool? maximumPermissionsManageSynonymsField;
    private bool maximumPermissionsManageSynonymsFieldSpecified;
    private bool? maximumPermissionsManageTwoFactorField;
    private bool maximumPermissionsManageTwoFactorFieldSpecified;
    private bool? maximumPermissionsManageUnlistedGroupsField;
    private bool maximumPermissionsManageUnlistedGroupsFieldSpecified;
    private bool? maximumPermissionsManageUsersField;
    private bool maximumPermissionsManageUsersFieldSpecified;
    private bool? maximumPermissionsMassInlineEditField;
    private bool maximumPermissionsMassInlineEditFieldSpecified;
    private bool? maximumPermissionsMergeTopicsField;
    private bool maximumPermissionsMergeTopicsFieldSpecified;
    private bool? maximumPermissionsModerateChatterField;
    private bool maximumPermissionsModerateChatterFieldSpecified;
    private bool? maximumPermissionsModifyAllDataField;
    private bool maximumPermissionsModifyAllDataFieldSpecified;
    private bool? maximumPermissionsNewReportBuilderField;
    private bool maximumPermissionsNewReportBuilderFieldSpecified;
    private bool? maximumPermissionsOutboundMigrationToolsUserField;
    private bool maximumPermissionsOutboundMigrationToolsUserFieldSpecified;
    private bool? maximumPermissionsPasswordNeverExpiresField;
    private bool maximumPermissionsPasswordNeverExpiresFieldSpecified;
    private bool? maximumPermissionsPublishPackagingField;
    private bool maximumPermissionsPublishPackagingFieldSpecified;
    private bool? maximumPermissionsResetPasswordsField;
    private bool maximumPermissionsResetPasswordsFieldSpecified;
    private bool? maximumPermissionsRunFlowField;
    private bool maximumPermissionsRunFlowFieldSpecified;
    private bool? maximumPermissionsRunReportsField;
    private bool maximumPermissionsRunReportsFieldSpecified;
    private bool? maximumPermissionsSalesConsoleField;
    private bool maximumPermissionsSalesConsoleFieldSpecified;
    private bool? maximumPermissionsScheduleJobField;
    private bool maximumPermissionsScheduleJobFieldSpecified;
    private bool? maximumPermissionsScheduleReportsField;
    private bool maximumPermissionsScheduleReportsFieldSpecified;
    private bool? maximumPermissionsSelectFilesFromSalesforceField;
    private bool maximumPermissionsSelectFilesFromSalesforceFieldSpecified;
    private bool? maximumPermissionsSendAnnouncementEmailsField;
    private bool maximumPermissionsSendAnnouncementEmailsFieldSpecified;
    private bool? maximumPermissionsSendSitRequestsField;
    private bool maximumPermissionsSendSitRequestsFieldSpecified;
    private bool? maximumPermissionsShareInternalArticlesField;
    private bool maximumPermissionsShareInternalArticlesFieldSpecified;
    private bool? maximumPermissionsShowCompanyNameAsUserBadgeField;
    private bool maximumPermissionsShowCompanyNameAsUserBadgeFieldSpecified;
    private bool? maximumPermissionsSolutionImportField;
    private bool maximumPermissionsSolutionImportFieldSpecified;
    private bool? maximumPermissionsSubmitMacrosAllowedField;
    private bool maximumPermissionsSubmitMacrosAllowedFieldSpecified;
    private bool? maximumPermissionsSubscribeToLightningReportsField;
    private bool maximumPermissionsSubscribeToLightningReportsFieldSpecified;
    private bool? maximumPermissionsTransferAnyCaseField;
    private bool maximumPermissionsTransferAnyCaseFieldSpecified;
    private bool? maximumPermissionsTransferAnyEntityField;
    private bool maximumPermissionsTransferAnyEntityFieldSpecified;
    private bool? maximumPermissionsTransferAnyLeadField;
    private bool maximumPermissionsTransferAnyLeadFieldSpecified;
    private bool? maximumPermissionsTwoFactorApiField;
    private bool maximumPermissionsTwoFactorApiFieldSpecified;
    private bool? maximumPermissionsUseTeamReassignWizardsField;
    private bool maximumPermissionsUseTeamReassignWizardsFieldSpecified;
    private bool? maximumPermissionsViewAllActivitiesField;
    private bool maximumPermissionsViewAllActivitiesFieldSpecified;
    private bool? maximumPermissionsViewAllDataField;
    private bool maximumPermissionsViewAllDataFieldSpecified;
    private bool? maximumPermissionsViewAllUsersField;
    private bool maximumPermissionsViewAllUsersFieldSpecified;
    private bool? maximumPermissionsViewContentField;
    private bool maximumPermissionsViewContentFieldSpecified;
    private bool? maximumPermissionsViewDataAssessmentField;
    private bool maximumPermissionsViewDataAssessmentFieldSpecified;
    private bool? maximumPermissionsViewDataCategoriesField;
    private bool maximumPermissionsViewDataCategoriesFieldSpecified;
    private bool? maximumPermissionsViewEncryptedDataField;
    private bool maximumPermissionsViewEncryptedDataFieldSpecified;
    private bool? maximumPermissionsViewEventLogFilesField;
    private bool maximumPermissionsViewEventLogFilesFieldSpecified;
    private bool? maximumPermissionsViewHealthCheckField;
    private bool maximumPermissionsViewHealthCheckFieldSpecified;
    private bool? maximumPermissionsViewHelpLinkField;
    private bool maximumPermissionsViewHelpLinkFieldSpecified;
    private bool? maximumPermissionsViewMyTeamsDashboardsField;
    private bool maximumPermissionsViewMyTeamsDashboardsFieldSpecified;
    private bool? maximumPermissionsViewPublicDashboardsField;
    private bool maximumPermissionsViewPublicDashboardsFieldSpecified;
    private bool? maximumPermissionsViewPublicReportsField;
    private bool maximumPermissionsViewPublicReportsFieldSpecified;
    private bool? maximumPermissionsViewSetupField;
    private bool maximumPermissionsViewSetupFieldSpecified;
    private bool? maximumPermissionsWorkCalibrationUserField;
    private bool maximumPermissionsWorkCalibrationUserFieldSpecified;
    private bool? maximumPermissionsWorkDotComUserPermField;
    private bool maximumPermissionsWorkDotComUserPermFieldSpecified;
    private QueryResult permissionSetLicenseAssignmentsField;
    private string permissionSetLicenseKeyField;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private int? totalLicensesField;
    private bool totalLicensesFieldSpecified;
    private int? usedLicensesField;
    private bool usedLicensesFieldSpecified;

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
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ExpirationDate
    {
      get => this.expirationDateField;
      set => this.expirationDateField = value;
    }

    [XmlIgnore]
    public bool ExpirationDateSpecified
    {
      get => this.expirationDateFieldSpecified;
      set => this.expirationDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult GrantedByLicenses
    {
      get => this.grantedByLicensesField;
      set => this.grantedByLicensesField = value;
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
    public string Language
    {
      get => this.languageField;
      set => this.languageField = value;
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
    public bool? MaximumPermissionsActivateContract
    {
      get => this.maximumPermissionsActivateContractField;
      set => this.maximumPermissionsActivateContractField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsActivateContractSpecified
    {
      get => this.maximumPermissionsActivateContractFieldSpecified;
      set => this.maximumPermissionsActivateContractFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsActivateOrder
    {
      get => this.maximumPermissionsActivateOrderField;
      set => this.maximumPermissionsActivateOrderField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsActivateOrderSpecified
    {
      get => this.maximumPermissionsActivateOrderFieldSpecified;
      set => this.maximumPermissionsActivateOrderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsAllowEmailIC
    {
      get => this.maximumPermissionsAllowEmailICField;
      set => this.maximumPermissionsAllowEmailICField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsAllowEmailICSpecified
    {
      get => this.maximumPermissionsAllowEmailICFieldSpecified;
      set => this.maximumPermissionsAllowEmailICFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsAllowUniversalSearch
    {
      get => this.maximumPermissionsAllowUniversalSearchField;
      set => this.maximumPermissionsAllowUniversalSearchField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsAllowUniversalSearchSpecified
    {
      get => this.maximumPermissionsAllowUniversalSearchFieldSpecified;
      set => this.maximumPermissionsAllowUniversalSearchFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsAllowViewEditConvertedLeads
    {
      get => this.maximumPermissionsAllowViewEditConvertedLeadsField;
      set => this.maximumPermissionsAllowViewEditConvertedLeadsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsAllowViewEditConvertedLeadsSpecified
    {
      get => this.maximumPermissionsAllowViewEditConvertedLeadsFieldSpecified;
      set => this.maximumPermissionsAllowViewEditConvertedLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsAllowViewKnowledge
    {
      get => this.maximumPermissionsAllowViewKnowledgeField;
      set => this.maximumPermissionsAllowViewKnowledgeField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsAllowViewKnowledgeSpecified
    {
      get => this.maximumPermissionsAllowViewKnowledgeFieldSpecified;
      set => this.maximumPermissionsAllowViewKnowledgeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsApiEnabled
    {
      get => this.maximumPermissionsApiEnabledField;
      set => this.maximumPermissionsApiEnabledField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsApiEnabledSpecified
    {
      get => this.maximumPermissionsApiEnabledFieldSpecified;
      set => this.maximumPermissionsApiEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsApiUserOnly
    {
      get => this.maximumPermissionsApiUserOnlyField;
      set => this.maximumPermissionsApiUserOnlyField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsApiUserOnlySpecified
    {
      get => this.maximumPermissionsApiUserOnlyFieldSpecified;
      set => this.maximumPermissionsApiUserOnlyFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsAssignPermissionSets
    {
      get => this.maximumPermissionsAssignPermissionSetsField;
      set => this.maximumPermissionsAssignPermissionSetsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsAssignPermissionSetsSpecified
    {
      get => this.maximumPermissionsAssignPermissionSetsFieldSpecified;
      set => this.maximumPermissionsAssignPermissionSetsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsAssignTopics
    {
      get => this.maximumPermissionsAssignTopicsField;
      set => this.maximumPermissionsAssignTopicsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsAssignTopicsSpecified
    {
      get => this.maximumPermissionsAssignTopicsFieldSpecified;
      set => this.maximumPermissionsAssignTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsAuthorApex
    {
      get => this.maximumPermissionsAuthorApexField;
      set => this.maximumPermissionsAuthorApexField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsAuthorApexSpecified
    {
      get => this.maximumPermissionsAuthorApexFieldSpecified;
      set => this.maximumPermissionsAuthorApexFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsBulkApiHardDelete
    {
      get => this.maximumPermissionsBulkApiHardDeleteField;
      set => this.maximumPermissionsBulkApiHardDeleteField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsBulkApiHardDeleteSpecified
    {
      get => this.maximumPermissionsBulkApiHardDeleteFieldSpecified;
      set => this.maximumPermissionsBulkApiHardDeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsBulkMacrosAllowed
    {
      get => this.maximumPermissionsBulkMacrosAllowedField;
      set => this.maximumPermissionsBulkMacrosAllowedField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsBulkMacrosAllowedSpecified
    {
      get => this.maximumPermissionsBulkMacrosAllowedFieldSpecified;
      set => this.maximumPermissionsBulkMacrosAllowedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCampaignInfluence2
    {
      get => this.maximumPermissionsCampaignInfluence2Field;
      set => this.maximumPermissionsCampaignInfluence2Field = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCampaignInfluence2Specified
    {
      get => this.maximumPermissionsCampaignInfluence2FieldSpecified;
      set => this.maximumPermissionsCampaignInfluence2FieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCanApproveFeedPost
    {
      get => this.maximumPermissionsCanApproveFeedPostField;
      set => this.maximumPermissionsCanApproveFeedPostField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCanApproveFeedPostSpecified
    {
      get => this.maximumPermissionsCanApproveFeedPostFieldSpecified;
      set => this.maximumPermissionsCanApproveFeedPostFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCanInsertFeedSystemFields
    {
      get => this.maximumPermissionsCanInsertFeedSystemFieldsField;
      set => this.maximumPermissionsCanInsertFeedSystemFieldsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCanInsertFeedSystemFieldsSpecified
    {
      get => this.maximumPermissionsCanInsertFeedSystemFieldsFieldSpecified;
      set => this.maximumPermissionsCanInsertFeedSystemFieldsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCanUseNewDashboardBuilder
    {
      get => this.maximumPermissionsCanUseNewDashboardBuilderField;
      set => this.maximumPermissionsCanUseNewDashboardBuilderField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCanUseNewDashboardBuilderSpecified
    {
      get => this.maximumPermissionsCanUseNewDashboardBuilderFieldSpecified;
      set => this.maximumPermissionsCanUseNewDashboardBuilderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsChatterComposeUiCodesnippet
    {
      get => this.maximumPermissionsChatterComposeUiCodesnippetField;
      set => this.maximumPermissionsChatterComposeUiCodesnippetField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsChatterComposeUiCodesnippetSpecified
    {
      get => this.maximumPermissionsChatterComposeUiCodesnippetFieldSpecified;
      set => this.maximumPermissionsChatterComposeUiCodesnippetFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsChatterEditOwnPost
    {
      get => this.maximumPermissionsChatterEditOwnPostField;
      set => this.maximumPermissionsChatterEditOwnPostField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsChatterEditOwnPostSpecified
    {
      get => this.maximumPermissionsChatterEditOwnPostFieldSpecified;
      set => this.maximumPermissionsChatterEditOwnPostFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsChatterEditOwnRecordPost
    {
      get => this.maximumPermissionsChatterEditOwnRecordPostField;
      set => this.maximumPermissionsChatterEditOwnRecordPostField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsChatterEditOwnRecordPostSpecified
    {
      get => this.maximumPermissionsChatterEditOwnRecordPostFieldSpecified;
      set => this.maximumPermissionsChatterEditOwnRecordPostFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsChatterFileLink
    {
      get => this.maximumPermissionsChatterFileLinkField;
      set => this.maximumPermissionsChatterFileLinkField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsChatterFileLinkSpecified
    {
      get => this.maximumPermissionsChatterFileLinkFieldSpecified;
      set => this.maximumPermissionsChatterFileLinkFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsChatterInternalUser
    {
      get => this.maximumPermissionsChatterInternalUserField;
      set => this.maximumPermissionsChatterInternalUserField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsChatterInternalUserSpecified
    {
      get => this.maximumPermissionsChatterInternalUserFieldSpecified;
      set => this.maximumPermissionsChatterInternalUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsChatterInviteExternalUsers
    {
      get => this.maximumPermissionsChatterInviteExternalUsersField;
      set => this.maximumPermissionsChatterInviteExternalUsersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsChatterInviteExternalUsersSpecified
    {
      get => this.maximumPermissionsChatterInviteExternalUsersFieldSpecified;
      set => this.maximumPermissionsChatterInviteExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsChatterOwnGroups
    {
      get => this.maximumPermissionsChatterOwnGroupsField;
      set => this.maximumPermissionsChatterOwnGroupsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsChatterOwnGroupsSpecified
    {
      get => this.maximumPermissionsChatterOwnGroupsFieldSpecified;
      set => this.maximumPermissionsChatterOwnGroupsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsConfigCustomRecs
    {
      get => this.maximumPermissionsConfigCustomRecsField;
      set => this.maximumPermissionsConfigCustomRecsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsConfigCustomRecsSpecified
    {
      get => this.maximumPermissionsConfigCustomRecsFieldSpecified;
      set => this.maximumPermissionsConfigCustomRecsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsConnectOrgToEnvironmentHub
    {
      get => this.maximumPermissionsConnectOrgToEnvironmentHubField;
      set => this.maximumPermissionsConnectOrgToEnvironmentHubField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsConnectOrgToEnvironmentHubSpecified
    {
      get => this.maximumPermissionsConnectOrgToEnvironmentHubFieldSpecified;
      set => this.maximumPermissionsConnectOrgToEnvironmentHubFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsContentAdministrator
    {
      get => this.maximumPermissionsContentAdministratorField;
      set => this.maximumPermissionsContentAdministratorField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsContentAdministratorSpecified
    {
      get => this.maximumPermissionsContentAdministratorFieldSpecified;
      set => this.maximumPermissionsContentAdministratorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsConvertLeads
    {
      get => this.maximumPermissionsConvertLeadsField;
      set => this.maximumPermissionsConvertLeadsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsConvertLeadsSpecified
    {
      get => this.maximumPermissionsConvertLeadsFieldSpecified;
      set => this.maximumPermissionsConvertLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCreateCustomizeDashboards
    {
      get => this.maximumPermissionsCreateCustomizeDashboardsField;
      set => this.maximumPermissionsCreateCustomizeDashboardsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCreateCustomizeDashboardsSpecified
    {
      get => this.maximumPermissionsCreateCustomizeDashboardsFieldSpecified;
      set => this.maximumPermissionsCreateCustomizeDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCreateCustomizeFilters
    {
      get => this.maximumPermissionsCreateCustomizeFiltersField;
      set => this.maximumPermissionsCreateCustomizeFiltersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCreateCustomizeFiltersSpecified
    {
      get => this.maximumPermissionsCreateCustomizeFiltersFieldSpecified;
      set => this.maximumPermissionsCreateCustomizeFiltersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCreateCustomizeReports
    {
      get => this.maximumPermissionsCreateCustomizeReportsField;
      set => this.maximumPermissionsCreateCustomizeReportsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCreateCustomizeReportsSpecified
    {
      get => this.maximumPermissionsCreateCustomizeReportsFieldSpecified;
      set => this.maximumPermissionsCreateCustomizeReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCreateDashboardFolders
    {
      get => this.maximumPermissionsCreateDashboardFoldersField;
      set => this.maximumPermissionsCreateDashboardFoldersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCreateDashboardFoldersSpecified
    {
      get => this.maximumPermissionsCreateDashboardFoldersFieldSpecified;
      set => this.maximumPermissionsCreateDashboardFoldersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCreatePackaging
    {
      get => this.maximumPermissionsCreatePackagingField;
      set => this.maximumPermissionsCreatePackagingField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCreatePackagingSpecified
    {
      get => this.maximumPermissionsCreatePackagingFieldSpecified;
      set => this.maximumPermissionsCreatePackagingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCreateReportFolders
    {
      get => this.maximumPermissionsCreateReportFoldersField;
      set => this.maximumPermissionsCreateReportFoldersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCreateReportFoldersSpecified
    {
      get => this.maximumPermissionsCreateReportFoldersFieldSpecified;
      set => this.maximumPermissionsCreateReportFoldersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCreateTopics
    {
      get => this.maximumPermissionsCreateTopicsField;
      set => this.maximumPermissionsCreateTopicsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCreateTopicsSpecified
    {
      get => this.maximumPermissionsCreateTopicsFieldSpecified;
      set => this.maximumPermissionsCreateTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCreateWorkspaces
    {
      get => this.maximumPermissionsCreateWorkspacesField;
      set => this.maximumPermissionsCreateWorkspacesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCreateWorkspacesSpecified
    {
      get => this.maximumPermissionsCreateWorkspacesFieldSpecified;
      set => this.maximumPermissionsCreateWorkspacesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCustomMobileAppsAccess
    {
      get => this.maximumPermissionsCustomMobileAppsAccessField;
      set => this.maximumPermissionsCustomMobileAppsAccessField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCustomMobileAppsAccessSpecified
    {
      get => this.maximumPermissionsCustomMobileAppsAccessFieldSpecified;
      set => this.maximumPermissionsCustomMobileAppsAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCustomSidebarOnAllPages
    {
      get => this.maximumPermissionsCustomSidebarOnAllPagesField;
      set => this.maximumPermissionsCustomSidebarOnAllPagesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCustomSidebarOnAllPagesSpecified
    {
      get => this.maximumPermissionsCustomSidebarOnAllPagesFieldSpecified;
      set => this.maximumPermissionsCustomSidebarOnAllPagesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsCustomizeApplication
    {
      get => this.maximumPermissionsCustomizeApplicationField;
      set => this.maximumPermissionsCustomizeApplicationField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsCustomizeApplicationSpecified
    {
      get => this.maximumPermissionsCustomizeApplicationFieldSpecified;
      set => this.maximumPermissionsCustomizeApplicationFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsDataExport
    {
      get => this.maximumPermissionsDataExportField;
      set => this.maximumPermissionsDataExportField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsDataExportSpecified
    {
      get => this.maximumPermissionsDataExportFieldSpecified;
      set => this.maximumPermissionsDataExportFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsDelegatedTwoFactor
    {
      get => this.maximumPermissionsDelegatedTwoFactorField;
      set => this.maximumPermissionsDelegatedTwoFactorField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsDelegatedTwoFactorSpecified
    {
      get => this.maximumPermissionsDelegatedTwoFactorFieldSpecified;
      set => this.maximumPermissionsDelegatedTwoFactorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsDeleteActivatedContract
    {
      get => this.maximumPermissionsDeleteActivatedContractField;
      set => this.maximumPermissionsDeleteActivatedContractField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsDeleteActivatedContractSpecified
    {
      get => this.maximumPermissionsDeleteActivatedContractFieldSpecified;
      set => this.maximumPermissionsDeleteActivatedContractFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsDeleteTopics
    {
      get => this.maximumPermissionsDeleteTopicsField;
      set => this.maximumPermissionsDeleteTopicsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsDeleteTopicsSpecified
    {
      get => this.maximumPermissionsDeleteTopicsFieldSpecified;
      set => this.maximumPermissionsDeleteTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsDistributeFromPersWksp
    {
      get => this.maximumPermissionsDistributeFromPersWkspField;
      set => this.maximumPermissionsDistributeFromPersWkspField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsDistributeFromPersWkspSpecified
    {
      get => this.maximumPermissionsDistributeFromPersWkspFieldSpecified;
      set => this.maximumPermissionsDistributeFromPersWkspFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditActivatedOrders
    {
      get => this.maximumPermissionsEditActivatedOrdersField;
      set => this.maximumPermissionsEditActivatedOrdersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditActivatedOrdersSpecified
    {
      get => this.maximumPermissionsEditActivatedOrdersFieldSpecified;
      set => this.maximumPermissionsEditActivatedOrdersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditBrandTemplates
    {
      get => this.maximumPermissionsEditBrandTemplatesField;
      set => this.maximumPermissionsEditBrandTemplatesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditBrandTemplatesSpecified
    {
      get => this.maximumPermissionsEditBrandTemplatesFieldSpecified;
      set => this.maximumPermissionsEditBrandTemplatesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditCaseComments
    {
      get => this.maximumPermissionsEditCaseCommentsField;
      set => this.maximumPermissionsEditCaseCommentsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditCaseCommentsSpecified
    {
      get => this.maximumPermissionsEditCaseCommentsFieldSpecified;
      set => this.maximumPermissionsEditCaseCommentsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditEvent
    {
      get => this.maximumPermissionsEditEventField;
      set => this.maximumPermissionsEditEventField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditEventSpecified
    {
      get => this.maximumPermissionsEditEventFieldSpecified;
      set => this.maximumPermissionsEditEventFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditHtmlTemplates
    {
      get => this.maximumPermissionsEditHtmlTemplatesField;
      set => this.maximumPermissionsEditHtmlTemplatesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditHtmlTemplatesSpecified
    {
      get => this.maximumPermissionsEditHtmlTemplatesFieldSpecified;
      set => this.maximumPermissionsEditHtmlTemplatesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditKnowledge
    {
      get => this.maximumPermissionsEditKnowledgeField;
      set => this.maximumPermissionsEditKnowledgeField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditKnowledgeSpecified
    {
      get => this.maximumPermissionsEditKnowledgeFieldSpecified;
      set => this.maximumPermissionsEditKnowledgeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditMyDashboards
    {
      get => this.maximumPermissionsEditMyDashboardsField;
      set => this.maximumPermissionsEditMyDashboardsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditMyDashboardsSpecified
    {
      get => this.maximumPermissionsEditMyDashboardsFieldSpecified;
      set => this.maximumPermissionsEditMyDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditMyReports
    {
      get => this.maximumPermissionsEditMyReportsField;
      set => this.maximumPermissionsEditMyReportsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditMyReportsSpecified
    {
      get => this.maximumPermissionsEditMyReportsFieldSpecified;
      set => this.maximumPermissionsEditMyReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditOppLineItemUnitPrice
    {
      get => this.maximumPermissionsEditOppLineItemUnitPriceField;
      set => this.maximumPermissionsEditOppLineItemUnitPriceField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditOppLineItemUnitPriceSpecified
    {
      get => this.maximumPermissionsEditOppLineItemUnitPriceFieldSpecified;
      set => this.maximumPermissionsEditOppLineItemUnitPriceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditPublicDocuments
    {
      get => this.maximumPermissionsEditPublicDocumentsField;
      set => this.maximumPermissionsEditPublicDocumentsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditPublicDocumentsSpecified
    {
      get => this.maximumPermissionsEditPublicDocumentsFieldSpecified;
      set => this.maximumPermissionsEditPublicDocumentsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditPublicTemplates
    {
      get => this.maximumPermissionsEditPublicTemplatesField;
      set => this.maximumPermissionsEditPublicTemplatesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditPublicTemplatesSpecified
    {
      get => this.maximumPermissionsEditPublicTemplatesFieldSpecified;
      set => this.maximumPermissionsEditPublicTemplatesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditReadonlyFields
    {
      get => this.maximumPermissionsEditReadonlyFieldsField;
      set => this.maximumPermissionsEditReadonlyFieldsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditReadonlyFieldsSpecified
    {
      get => this.maximumPermissionsEditReadonlyFieldsFieldSpecified;
      set => this.maximumPermissionsEditReadonlyFieldsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditTask
    {
      get => this.maximumPermissionsEditTaskField;
      set => this.maximumPermissionsEditTaskField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditTaskSpecified
    {
      get => this.maximumPermissionsEditTaskFieldSpecified;
      set => this.maximumPermissionsEditTaskFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEditTopics
    {
      get => this.maximumPermissionsEditTopicsField;
      set => this.maximumPermissionsEditTopicsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEditTopicsSpecified
    {
      get => this.maximumPermissionsEditTopicsFieldSpecified;
      set => this.maximumPermissionsEditTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEmailAdministration
    {
      get => this.maximumPermissionsEmailAdministrationField;
      set => this.maximumPermissionsEmailAdministrationField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEmailAdministrationSpecified
    {
      get => this.maximumPermissionsEmailAdministrationFieldSpecified;
      set => this.maximumPermissionsEmailAdministrationFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEmailMass
    {
      get => this.maximumPermissionsEmailMassField;
      set => this.maximumPermissionsEmailMassField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEmailMassSpecified
    {
      get => this.maximumPermissionsEmailMassFieldSpecified;
      set => this.maximumPermissionsEmailMassFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEmailSingle
    {
      get => this.maximumPermissionsEmailSingleField;
      set => this.maximumPermissionsEmailSingleField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEmailSingleSpecified
    {
      get => this.maximumPermissionsEmailSingleFieldSpecified;
      set => this.maximumPermissionsEmailSingleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEmailTemplateManagement
    {
      get => this.maximumPermissionsEmailTemplateManagementField;
      set => this.maximumPermissionsEmailTemplateManagementField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEmailTemplateManagementSpecified
    {
      get => this.maximumPermissionsEmailTemplateManagementFieldSpecified;
      set => this.maximumPermissionsEmailTemplateManagementFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsEnableNotifications
    {
      get => this.maximumPermissionsEnableNotificationsField;
      set => this.maximumPermissionsEnableNotificationsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsEnableNotificationsSpecified
    {
      get => this.maximumPermissionsEnableNotificationsFieldSpecified;
      set => this.maximumPermissionsEnableNotificationsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsExportReport
    {
      get => this.maximumPermissionsExportReportField;
      set => this.maximumPermissionsExportReportField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsExportReportSpecified
    {
      get => this.maximumPermissionsExportReportFieldSpecified;
      set => this.maximumPermissionsExportReportFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsFlowUFLRequired
    {
      get => this.maximumPermissionsFlowUFLRequiredField;
      set => this.maximumPermissionsFlowUFLRequiredField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsFlowUFLRequiredSpecified
    {
      get => this.maximumPermissionsFlowUFLRequiredFieldSpecified;
      set => this.maximumPermissionsFlowUFLRequiredFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsForceTwoFactor
    {
      get => this.maximumPermissionsForceTwoFactorField;
      set => this.maximumPermissionsForceTwoFactorField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsForceTwoFactorSpecified
    {
      get => this.maximumPermissionsForceTwoFactorFieldSpecified;
      set => this.maximumPermissionsForceTwoFactorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsIdentityConnect
    {
      get => this.maximumPermissionsIdentityConnectField;
      set => this.maximumPermissionsIdentityConnectField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsIdentityConnectSpecified
    {
      get => this.maximumPermissionsIdentityConnectFieldSpecified;
      set => this.maximumPermissionsIdentityConnectFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsIdentityEnabled
    {
      get => this.maximumPermissionsIdentityEnabledField;
      set => this.maximumPermissionsIdentityEnabledField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsIdentityEnabledSpecified
    {
      get => this.maximumPermissionsIdentityEnabledFieldSpecified;
      set => this.maximumPermissionsIdentityEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsImportCustomObjects
    {
      get => this.maximumPermissionsImportCustomObjectsField;
      set => this.maximumPermissionsImportCustomObjectsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsImportCustomObjectsSpecified
    {
      get => this.maximumPermissionsImportCustomObjectsFieldSpecified;
      set => this.maximumPermissionsImportCustomObjectsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsImportLeads
    {
      get => this.maximumPermissionsImportLeadsField;
      set => this.maximumPermissionsImportLeadsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsImportLeadsSpecified
    {
      get => this.maximumPermissionsImportLeadsFieldSpecified;
      set => this.maximumPermissionsImportLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsImportPersonal
    {
      get => this.maximumPermissionsImportPersonalField;
      set => this.maximumPermissionsImportPersonalField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsImportPersonalSpecified
    {
      get => this.maximumPermissionsImportPersonalFieldSpecified;
      set => this.maximumPermissionsImportPersonalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsInboundMigrationToolsUser
    {
      get => this.maximumPermissionsInboundMigrationToolsUserField;
      set => this.maximumPermissionsInboundMigrationToolsUserField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsInboundMigrationToolsUserSpecified
    {
      get => this.maximumPermissionsInboundMigrationToolsUserFieldSpecified;
      set => this.maximumPermissionsInboundMigrationToolsUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsInstallPackaging
    {
      get => this.maximumPermissionsInstallPackagingField;
      set => this.maximumPermissionsInstallPackagingField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsInstallPackagingSpecified
    {
      get => this.maximumPermissionsInstallPackagingFieldSpecified;
      set => this.maximumPermissionsInstallPackagingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsLightningExperienceUser
    {
      get => this.maximumPermissionsLightningExperienceUserField;
      set => this.maximumPermissionsLightningExperienceUserField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsLightningExperienceUserSpecified
    {
      get => this.maximumPermissionsLightningExperienceUserFieldSpecified;
      set => this.maximumPermissionsLightningExperienceUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageAnalyticSnapshots
    {
      get => this.maximumPermissionsManageAnalyticSnapshotsField;
      set => this.maximumPermissionsManageAnalyticSnapshotsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageAnalyticSnapshotsSpecified
    {
      get => this.maximumPermissionsManageAnalyticSnapshotsFieldSpecified;
      set => this.maximumPermissionsManageAnalyticSnapshotsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageAuthProviders
    {
      get => this.maximumPermissionsManageAuthProvidersField;
      set => this.maximumPermissionsManageAuthProvidersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageAuthProvidersSpecified
    {
      get => this.maximumPermissionsManageAuthProvidersFieldSpecified;
      set => this.maximumPermissionsManageAuthProvidersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageBusinessHourHolidays
    {
      get => this.maximumPermissionsManageBusinessHourHolidaysField;
      set => this.maximumPermissionsManageBusinessHourHolidaysField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageBusinessHourHolidaysSpecified
    {
      get => this.maximumPermissionsManageBusinessHourHolidaysFieldSpecified;
      set => this.maximumPermissionsManageBusinessHourHolidaysFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageCallCenters
    {
      get => this.maximumPermissionsManageCallCentersField;
      set => this.maximumPermissionsManageCallCentersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageCallCentersSpecified
    {
      get => this.maximumPermissionsManageCallCentersFieldSpecified;
      set => this.maximumPermissionsManageCallCentersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageCases
    {
      get => this.maximumPermissionsManageCasesField;
      set => this.maximumPermissionsManageCasesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageCasesSpecified
    {
      get => this.maximumPermissionsManageCasesFieldSpecified;
      set => this.maximumPermissionsManageCasesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageCategories
    {
      get => this.maximumPermissionsManageCategoriesField;
      set => this.maximumPermissionsManageCategoriesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageCategoriesSpecified
    {
      get => this.maximumPermissionsManageCategoriesFieldSpecified;
      set => this.maximumPermissionsManageCategoriesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageChatterMessages
    {
      get => this.maximumPermissionsManageChatterMessagesField;
      set => this.maximumPermissionsManageChatterMessagesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageChatterMessagesSpecified
    {
      get => this.maximumPermissionsManageChatterMessagesFieldSpecified;
      set => this.maximumPermissionsManageChatterMessagesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageContentPermissions
    {
      get => this.maximumPermissionsManageContentPermissionsField;
      set => this.maximumPermissionsManageContentPermissionsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageContentPermissionsSpecified
    {
      get => this.maximumPermissionsManageContentPermissionsFieldSpecified;
      set => this.maximumPermissionsManageContentPermissionsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageContentProperties
    {
      get => this.maximumPermissionsManageContentPropertiesField;
      set => this.maximumPermissionsManageContentPropertiesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageContentPropertiesSpecified
    {
      get => this.maximumPermissionsManageContentPropertiesFieldSpecified;
      set => this.maximumPermissionsManageContentPropertiesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageContentTypes
    {
      get => this.maximumPermissionsManageContentTypesField;
      set => this.maximumPermissionsManageContentTypesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageContentTypesSpecified
    {
      get => this.maximumPermissionsManageContentTypesFieldSpecified;
      set => this.maximumPermissionsManageContentTypesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageCustomPermissions
    {
      get => this.maximumPermissionsManageCustomPermissionsField;
      set => this.maximumPermissionsManageCustomPermissionsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageCustomPermissionsSpecified
    {
      get => this.maximumPermissionsManageCustomPermissionsFieldSpecified;
      set => this.maximumPermissionsManageCustomPermissionsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageCustomReportTypes
    {
      get => this.maximumPermissionsManageCustomReportTypesField;
      set => this.maximumPermissionsManageCustomReportTypesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageCustomReportTypesSpecified
    {
      get => this.maximumPermissionsManageCustomReportTypesFieldSpecified;
      set => this.maximumPermissionsManageCustomReportTypesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageDashbdsInPubFolders
    {
      get => this.maximumPermissionsManageDashbdsInPubFoldersField;
      set => this.maximumPermissionsManageDashbdsInPubFoldersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageDashbdsInPubFoldersSpecified
    {
      get => this.maximumPermissionsManageDashbdsInPubFoldersFieldSpecified;
      set => this.maximumPermissionsManageDashbdsInPubFoldersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageDataCategories
    {
      get => this.maximumPermissionsManageDataCategoriesField;
      set => this.maximumPermissionsManageDataCategoriesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageDataCategoriesSpecified
    {
      get => this.maximumPermissionsManageDataCategoriesFieldSpecified;
      set => this.maximumPermissionsManageDataCategoriesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageDataIntegrations
    {
      get => this.maximumPermissionsManageDataIntegrationsField;
      set => this.maximumPermissionsManageDataIntegrationsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageDataIntegrationsSpecified
    {
      get => this.maximumPermissionsManageDataIntegrationsFieldSpecified;
      set => this.maximumPermissionsManageDataIntegrationsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageDynamicDashboards
    {
      get => this.maximumPermissionsManageDynamicDashboardsField;
      set => this.maximumPermissionsManageDynamicDashboardsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageDynamicDashboardsSpecified
    {
      get => this.maximumPermissionsManageDynamicDashboardsFieldSpecified;
      set => this.maximumPermissionsManageDynamicDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageEmailClientConfig
    {
      get => this.maximumPermissionsManageEmailClientConfigField;
      set => this.maximumPermissionsManageEmailClientConfigField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageEmailClientConfigSpecified
    {
      get => this.maximumPermissionsManageEmailClientConfigFieldSpecified;
      set => this.maximumPermissionsManageEmailClientConfigFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageExchangeConfig
    {
      get => this.maximumPermissionsManageExchangeConfigField;
      set => this.maximumPermissionsManageExchangeConfigField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageExchangeConfigSpecified
    {
      get => this.maximumPermissionsManageExchangeConfigFieldSpecified;
      set => this.maximumPermissionsManageExchangeConfigFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageHealthCheck
    {
      get => this.maximumPermissionsManageHealthCheckField;
      set => this.maximumPermissionsManageHealthCheckField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageHealthCheckSpecified
    {
      get => this.maximumPermissionsManageHealthCheckFieldSpecified;
      set => this.maximumPermissionsManageHealthCheckFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageInteraction
    {
      get => this.maximumPermissionsManageInteractionField;
      set => this.maximumPermissionsManageInteractionField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageInteractionSpecified
    {
      get => this.maximumPermissionsManageInteractionFieldSpecified;
      set => this.maximumPermissionsManageInteractionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageInternalUsers
    {
      get => this.maximumPermissionsManageInternalUsersField;
      set => this.maximumPermissionsManageInternalUsersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageInternalUsersSpecified
    {
      get => this.maximumPermissionsManageInternalUsersFieldSpecified;
      set => this.maximumPermissionsManageInternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageIpAddresses
    {
      get => this.maximumPermissionsManageIpAddressesField;
      set => this.maximumPermissionsManageIpAddressesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageIpAddressesSpecified
    {
      get => this.maximumPermissionsManageIpAddressesFieldSpecified;
      set => this.maximumPermissionsManageIpAddressesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageKnowledge
    {
      get => this.maximumPermissionsManageKnowledgeField;
      set => this.maximumPermissionsManageKnowledgeField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageKnowledgeSpecified
    {
      get => this.maximumPermissionsManageKnowledgeFieldSpecified;
      set => this.maximumPermissionsManageKnowledgeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageKnowledgeImportExport
    {
      get => this.maximumPermissionsManageKnowledgeImportExportField;
      set => this.maximumPermissionsManageKnowledgeImportExportField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageKnowledgeImportExportSpecified
    {
      get => this.maximumPermissionsManageKnowledgeImportExportFieldSpecified;
      set => this.maximumPermissionsManageKnowledgeImportExportFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageLeads
    {
      get => this.maximumPermissionsManageLeadsField;
      set => this.maximumPermissionsManageLeadsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageLeadsSpecified
    {
      get => this.maximumPermissionsManageLeadsFieldSpecified;
      set => this.maximumPermissionsManageLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageLoginAccessPolicies
    {
      get => this.maximumPermissionsManageLoginAccessPoliciesField;
      set => this.maximumPermissionsManageLoginAccessPoliciesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageLoginAccessPoliciesSpecified
    {
      get => this.maximumPermissionsManageLoginAccessPoliciesFieldSpecified;
      set => this.maximumPermissionsManageLoginAccessPoliciesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageMobile
    {
      get => this.maximumPermissionsManageMobileField;
      set => this.maximumPermissionsManageMobileField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageMobileSpecified
    {
      get => this.maximumPermissionsManageMobileFieldSpecified;
      set => this.maximumPermissionsManageMobileFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManagePasswordPolicies
    {
      get => this.maximumPermissionsManagePasswordPoliciesField;
      set => this.maximumPermissionsManagePasswordPoliciesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManagePasswordPoliciesSpecified
    {
      get => this.maximumPermissionsManagePasswordPoliciesFieldSpecified;
      set => this.maximumPermissionsManagePasswordPoliciesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageProfilesPermissionsets
    {
      get => this.maximumPermissionsManageProfilesPermissionsetsField;
      set => this.maximumPermissionsManageProfilesPermissionsetsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageProfilesPermissionsetsSpecified
    {
      get => this.maximumPermissionsManageProfilesPermissionsetsFieldSpecified;
      set => this.maximumPermissionsManageProfilesPermissionsetsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManagePvtRptsAndDashbds
    {
      get => this.maximumPermissionsManagePvtRptsAndDashbdsField;
      set => this.maximumPermissionsManagePvtRptsAndDashbdsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManagePvtRptsAndDashbdsSpecified
    {
      get => this.maximumPermissionsManagePvtRptsAndDashbdsFieldSpecified;
      set => this.maximumPermissionsManagePvtRptsAndDashbdsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageRemoteAccess
    {
      get => this.maximumPermissionsManageRemoteAccessField;
      set => this.maximumPermissionsManageRemoteAccessField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageRemoteAccessSpecified
    {
      get => this.maximumPermissionsManageRemoteAccessFieldSpecified;
      set => this.maximumPermissionsManageRemoteAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageReportsInPubFolders
    {
      get => this.maximumPermissionsManageReportsInPubFoldersField;
      set => this.maximumPermissionsManageReportsInPubFoldersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageReportsInPubFoldersSpecified
    {
      get => this.maximumPermissionsManageReportsInPubFoldersFieldSpecified;
      set => this.maximumPermissionsManageReportsInPubFoldersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageRoles
    {
      get => this.maximumPermissionsManageRolesField;
      set => this.maximumPermissionsManageRolesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageRolesSpecified
    {
      get => this.maximumPermissionsManageRolesFieldSpecified;
      set => this.maximumPermissionsManageRolesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageSearchPromotionRules
    {
      get => this.maximumPermissionsManageSearchPromotionRulesField;
      set => this.maximumPermissionsManageSearchPromotionRulesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageSearchPromotionRulesSpecified
    {
      get => this.maximumPermissionsManageSearchPromotionRulesFieldSpecified;
      set => this.maximumPermissionsManageSearchPromotionRulesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageSharing
    {
      get => this.maximumPermissionsManageSharingField;
      set => this.maximumPermissionsManageSharingField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageSharingSpecified
    {
      get => this.maximumPermissionsManageSharingFieldSpecified;
      set => this.maximumPermissionsManageSharingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageSolutions
    {
      get => this.maximumPermissionsManageSolutionsField;
      set => this.maximumPermissionsManageSolutionsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageSolutionsSpecified
    {
      get => this.maximumPermissionsManageSolutionsFieldSpecified;
      set => this.maximumPermissionsManageSolutionsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageSynonyms
    {
      get => this.maximumPermissionsManageSynonymsField;
      set => this.maximumPermissionsManageSynonymsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageSynonymsSpecified
    {
      get => this.maximumPermissionsManageSynonymsFieldSpecified;
      set => this.maximumPermissionsManageSynonymsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageTwoFactor
    {
      get => this.maximumPermissionsManageTwoFactorField;
      set => this.maximumPermissionsManageTwoFactorField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageTwoFactorSpecified
    {
      get => this.maximumPermissionsManageTwoFactorFieldSpecified;
      set => this.maximumPermissionsManageTwoFactorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageUnlistedGroups
    {
      get => this.maximumPermissionsManageUnlistedGroupsField;
      set => this.maximumPermissionsManageUnlistedGroupsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageUnlistedGroupsSpecified
    {
      get => this.maximumPermissionsManageUnlistedGroupsFieldSpecified;
      set => this.maximumPermissionsManageUnlistedGroupsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsManageUsers
    {
      get => this.maximumPermissionsManageUsersField;
      set => this.maximumPermissionsManageUsersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsManageUsersSpecified
    {
      get => this.maximumPermissionsManageUsersFieldSpecified;
      set => this.maximumPermissionsManageUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsMassInlineEdit
    {
      get => this.maximumPermissionsMassInlineEditField;
      set => this.maximumPermissionsMassInlineEditField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsMassInlineEditSpecified
    {
      get => this.maximumPermissionsMassInlineEditFieldSpecified;
      set => this.maximumPermissionsMassInlineEditFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsMergeTopics
    {
      get => this.maximumPermissionsMergeTopicsField;
      set => this.maximumPermissionsMergeTopicsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsMergeTopicsSpecified
    {
      get => this.maximumPermissionsMergeTopicsFieldSpecified;
      set => this.maximumPermissionsMergeTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsModerateChatter
    {
      get => this.maximumPermissionsModerateChatterField;
      set => this.maximumPermissionsModerateChatterField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsModerateChatterSpecified
    {
      get => this.maximumPermissionsModerateChatterFieldSpecified;
      set => this.maximumPermissionsModerateChatterFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsModifyAllData
    {
      get => this.maximumPermissionsModifyAllDataField;
      set => this.maximumPermissionsModifyAllDataField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsModifyAllDataSpecified
    {
      get => this.maximumPermissionsModifyAllDataFieldSpecified;
      set => this.maximumPermissionsModifyAllDataFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsNewReportBuilder
    {
      get => this.maximumPermissionsNewReportBuilderField;
      set => this.maximumPermissionsNewReportBuilderField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsNewReportBuilderSpecified
    {
      get => this.maximumPermissionsNewReportBuilderFieldSpecified;
      set => this.maximumPermissionsNewReportBuilderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsOutboundMigrationToolsUser
    {
      get => this.maximumPermissionsOutboundMigrationToolsUserField;
      set => this.maximumPermissionsOutboundMigrationToolsUserField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsOutboundMigrationToolsUserSpecified
    {
      get => this.maximumPermissionsOutboundMigrationToolsUserFieldSpecified;
      set => this.maximumPermissionsOutboundMigrationToolsUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsPasswordNeverExpires
    {
      get => this.maximumPermissionsPasswordNeverExpiresField;
      set => this.maximumPermissionsPasswordNeverExpiresField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsPasswordNeverExpiresSpecified
    {
      get => this.maximumPermissionsPasswordNeverExpiresFieldSpecified;
      set => this.maximumPermissionsPasswordNeverExpiresFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsPublishPackaging
    {
      get => this.maximumPermissionsPublishPackagingField;
      set => this.maximumPermissionsPublishPackagingField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsPublishPackagingSpecified
    {
      get => this.maximumPermissionsPublishPackagingFieldSpecified;
      set => this.maximumPermissionsPublishPackagingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsResetPasswords
    {
      get => this.maximumPermissionsResetPasswordsField;
      set => this.maximumPermissionsResetPasswordsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsResetPasswordsSpecified
    {
      get => this.maximumPermissionsResetPasswordsFieldSpecified;
      set => this.maximumPermissionsResetPasswordsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsRunFlow
    {
      get => this.maximumPermissionsRunFlowField;
      set => this.maximumPermissionsRunFlowField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsRunFlowSpecified
    {
      get => this.maximumPermissionsRunFlowFieldSpecified;
      set => this.maximumPermissionsRunFlowFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsRunReports
    {
      get => this.maximumPermissionsRunReportsField;
      set => this.maximumPermissionsRunReportsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsRunReportsSpecified
    {
      get => this.maximumPermissionsRunReportsFieldSpecified;
      set => this.maximumPermissionsRunReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsSalesConsole
    {
      get => this.maximumPermissionsSalesConsoleField;
      set => this.maximumPermissionsSalesConsoleField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsSalesConsoleSpecified
    {
      get => this.maximumPermissionsSalesConsoleFieldSpecified;
      set => this.maximumPermissionsSalesConsoleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsScheduleJob
    {
      get => this.maximumPermissionsScheduleJobField;
      set => this.maximumPermissionsScheduleJobField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsScheduleJobSpecified
    {
      get => this.maximumPermissionsScheduleJobFieldSpecified;
      set => this.maximumPermissionsScheduleJobFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsScheduleReports
    {
      get => this.maximumPermissionsScheduleReportsField;
      set => this.maximumPermissionsScheduleReportsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsScheduleReportsSpecified
    {
      get => this.maximumPermissionsScheduleReportsFieldSpecified;
      set => this.maximumPermissionsScheduleReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsSelectFilesFromSalesforce
    {
      get => this.maximumPermissionsSelectFilesFromSalesforceField;
      set => this.maximumPermissionsSelectFilesFromSalesforceField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsSelectFilesFromSalesforceSpecified
    {
      get => this.maximumPermissionsSelectFilesFromSalesforceFieldSpecified;
      set => this.maximumPermissionsSelectFilesFromSalesforceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsSendAnnouncementEmails
    {
      get => this.maximumPermissionsSendAnnouncementEmailsField;
      set => this.maximumPermissionsSendAnnouncementEmailsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsSendAnnouncementEmailsSpecified
    {
      get => this.maximumPermissionsSendAnnouncementEmailsFieldSpecified;
      set => this.maximumPermissionsSendAnnouncementEmailsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsSendSitRequests
    {
      get => this.maximumPermissionsSendSitRequestsField;
      set => this.maximumPermissionsSendSitRequestsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsSendSitRequestsSpecified
    {
      get => this.maximumPermissionsSendSitRequestsFieldSpecified;
      set => this.maximumPermissionsSendSitRequestsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsShareInternalArticles
    {
      get => this.maximumPermissionsShareInternalArticlesField;
      set => this.maximumPermissionsShareInternalArticlesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsShareInternalArticlesSpecified
    {
      get => this.maximumPermissionsShareInternalArticlesFieldSpecified;
      set => this.maximumPermissionsShareInternalArticlesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsShowCompanyNameAsUserBadge
    {
      get => this.maximumPermissionsShowCompanyNameAsUserBadgeField;
      set => this.maximumPermissionsShowCompanyNameAsUserBadgeField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsShowCompanyNameAsUserBadgeSpecified
    {
      get => this.maximumPermissionsShowCompanyNameAsUserBadgeFieldSpecified;
      set => this.maximumPermissionsShowCompanyNameAsUserBadgeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsSolutionImport
    {
      get => this.maximumPermissionsSolutionImportField;
      set => this.maximumPermissionsSolutionImportField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsSolutionImportSpecified
    {
      get => this.maximumPermissionsSolutionImportFieldSpecified;
      set => this.maximumPermissionsSolutionImportFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsSubmitMacrosAllowed
    {
      get => this.maximumPermissionsSubmitMacrosAllowedField;
      set => this.maximumPermissionsSubmitMacrosAllowedField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsSubmitMacrosAllowedSpecified
    {
      get => this.maximumPermissionsSubmitMacrosAllowedFieldSpecified;
      set => this.maximumPermissionsSubmitMacrosAllowedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsSubscribeToLightningReports
    {
      get => this.maximumPermissionsSubscribeToLightningReportsField;
      set => this.maximumPermissionsSubscribeToLightningReportsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsSubscribeToLightningReportsSpecified
    {
      get => this.maximumPermissionsSubscribeToLightningReportsFieldSpecified;
      set => this.maximumPermissionsSubscribeToLightningReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsTransferAnyCase
    {
      get => this.maximumPermissionsTransferAnyCaseField;
      set => this.maximumPermissionsTransferAnyCaseField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsTransferAnyCaseSpecified
    {
      get => this.maximumPermissionsTransferAnyCaseFieldSpecified;
      set => this.maximumPermissionsTransferAnyCaseFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsTransferAnyEntity
    {
      get => this.maximumPermissionsTransferAnyEntityField;
      set => this.maximumPermissionsTransferAnyEntityField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsTransferAnyEntitySpecified
    {
      get => this.maximumPermissionsTransferAnyEntityFieldSpecified;
      set => this.maximumPermissionsTransferAnyEntityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsTransferAnyLead
    {
      get => this.maximumPermissionsTransferAnyLeadField;
      set => this.maximumPermissionsTransferAnyLeadField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsTransferAnyLeadSpecified
    {
      get => this.maximumPermissionsTransferAnyLeadFieldSpecified;
      set => this.maximumPermissionsTransferAnyLeadFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsTwoFactorApi
    {
      get => this.maximumPermissionsTwoFactorApiField;
      set => this.maximumPermissionsTwoFactorApiField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsTwoFactorApiSpecified
    {
      get => this.maximumPermissionsTwoFactorApiFieldSpecified;
      set => this.maximumPermissionsTwoFactorApiFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsUseTeamReassignWizards
    {
      get => this.maximumPermissionsUseTeamReassignWizardsField;
      set => this.maximumPermissionsUseTeamReassignWizardsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsUseTeamReassignWizardsSpecified
    {
      get => this.maximumPermissionsUseTeamReassignWizardsFieldSpecified;
      set => this.maximumPermissionsUseTeamReassignWizardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewAllActivities
    {
      get => this.maximumPermissionsViewAllActivitiesField;
      set => this.maximumPermissionsViewAllActivitiesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewAllActivitiesSpecified
    {
      get => this.maximumPermissionsViewAllActivitiesFieldSpecified;
      set => this.maximumPermissionsViewAllActivitiesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewAllData
    {
      get => this.maximumPermissionsViewAllDataField;
      set => this.maximumPermissionsViewAllDataField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewAllDataSpecified
    {
      get => this.maximumPermissionsViewAllDataFieldSpecified;
      set => this.maximumPermissionsViewAllDataFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewAllUsers
    {
      get => this.maximumPermissionsViewAllUsersField;
      set => this.maximumPermissionsViewAllUsersField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewAllUsersSpecified
    {
      get => this.maximumPermissionsViewAllUsersFieldSpecified;
      set => this.maximumPermissionsViewAllUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewContent
    {
      get => this.maximumPermissionsViewContentField;
      set => this.maximumPermissionsViewContentField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewContentSpecified
    {
      get => this.maximumPermissionsViewContentFieldSpecified;
      set => this.maximumPermissionsViewContentFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewDataAssessment
    {
      get => this.maximumPermissionsViewDataAssessmentField;
      set => this.maximumPermissionsViewDataAssessmentField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewDataAssessmentSpecified
    {
      get => this.maximumPermissionsViewDataAssessmentFieldSpecified;
      set => this.maximumPermissionsViewDataAssessmentFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewDataCategories
    {
      get => this.maximumPermissionsViewDataCategoriesField;
      set => this.maximumPermissionsViewDataCategoriesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewDataCategoriesSpecified
    {
      get => this.maximumPermissionsViewDataCategoriesFieldSpecified;
      set => this.maximumPermissionsViewDataCategoriesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewEncryptedData
    {
      get => this.maximumPermissionsViewEncryptedDataField;
      set => this.maximumPermissionsViewEncryptedDataField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewEncryptedDataSpecified
    {
      get => this.maximumPermissionsViewEncryptedDataFieldSpecified;
      set => this.maximumPermissionsViewEncryptedDataFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewEventLogFiles
    {
      get => this.maximumPermissionsViewEventLogFilesField;
      set => this.maximumPermissionsViewEventLogFilesField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewEventLogFilesSpecified
    {
      get => this.maximumPermissionsViewEventLogFilesFieldSpecified;
      set => this.maximumPermissionsViewEventLogFilesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewHealthCheck
    {
      get => this.maximumPermissionsViewHealthCheckField;
      set => this.maximumPermissionsViewHealthCheckField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewHealthCheckSpecified
    {
      get => this.maximumPermissionsViewHealthCheckFieldSpecified;
      set => this.maximumPermissionsViewHealthCheckFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewHelpLink
    {
      get => this.maximumPermissionsViewHelpLinkField;
      set => this.maximumPermissionsViewHelpLinkField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewHelpLinkSpecified
    {
      get => this.maximumPermissionsViewHelpLinkFieldSpecified;
      set => this.maximumPermissionsViewHelpLinkFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewMyTeamsDashboards
    {
      get => this.maximumPermissionsViewMyTeamsDashboardsField;
      set => this.maximumPermissionsViewMyTeamsDashboardsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewMyTeamsDashboardsSpecified
    {
      get => this.maximumPermissionsViewMyTeamsDashboardsFieldSpecified;
      set => this.maximumPermissionsViewMyTeamsDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewPublicDashboards
    {
      get => this.maximumPermissionsViewPublicDashboardsField;
      set => this.maximumPermissionsViewPublicDashboardsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewPublicDashboardsSpecified
    {
      get => this.maximumPermissionsViewPublicDashboardsFieldSpecified;
      set => this.maximumPermissionsViewPublicDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewPublicReports
    {
      get => this.maximumPermissionsViewPublicReportsField;
      set => this.maximumPermissionsViewPublicReportsField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewPublicReportsSpecified
    {
      get => this.maximumPermissionsViewPublicReportsFieldSpecified;
      set => this.maximumPermissionsViewPublicReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsViewSetup
    {
      get => this.maximumPermissionsViewSetupField;
      set => this.maximumPermissionsViewSetupField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsViewSetupSpecified
    {
      get => this.maximumPermissionsViewSetupFieldSpecified;
      set => this.maximumPermissionsViewSetupFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsWorkCalibrationUser
    {
      get => this.maximumPermissionsWorkCalibrationUserField;
      set => this.maximumPermissionsWorkCalibrationUserField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsWorkCalibrationUserSpecified
    {
      get => this.maximumPermissionsWorkCalibrationUserFieldSpecified;
      set => this.maximumPermissionsWorkCalibrationUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MaximumPermissionsWorkDotComUserPerm
    {
      get => this.maximumPermissionsWorkDotComUserPermField;
      set => this.maximumPermissionsWorkDotComUserPermField = value;
    }

    [XmlIgnore]
    public bool MaximumPermissionsWorkDotComUserPermSpecified
    {
      get => this.maximumPermissionsWorkDotComUserPermFieldSpecified;
      set => this.maximumPermissionsWorkDotComUserPermFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult PermissionSetLicenseAssignments
    {
      get => this.permissionSetLicenseAssignmentsField;
      set => this.permissionSetLicenseAssignmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PermissionSetLicenseKey
    {
      get => this.permissionSetLicenseKeyField;
      set => this.permissionSetLicenseKeyField = value;
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
    public int? TotalLicenses
    {
      get => this.totalLicensesField;
      set => this.totalLicensesField = value;
    }

    [XmlIgnore]
    public bool TotalLicensesSpecified
    {
      get => this.totalLicensesFieldSpecified;
      set => this.totalLicensesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? UsedLicenses
    {
      get => this.usedLicensesField;
      set => this.usedLicensesField = value;
    }

    [XmlIgnore]
    public bool UsedLicensesSpecified
    {
      get => this.usedLicensesFieldSpecified;
      set => this.usedLicensesFieldSpecified = value;
    }
  }
}
