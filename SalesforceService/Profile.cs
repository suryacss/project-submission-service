// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Profile
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
  public class Profile : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private string nameField;
    private bool? permissionsActivateContractField;
    private bool permissionsActivateContractFieldSpecified;
    private bool? permissionsActivateOrderField;
    private bool permissionsActivateOrderFieldSpecified;
    private bool? permissionsAllowEmailICField;
    private bool permissionsAllowEmailICFieldSpecified;
    private bool? permissionsAllowUniversalSearchField;
    private bool permissionsAllowUniversalSearchFieldSpecified;
    private bool? permissionsAllowViewEditConvertedLeadsField;
    private bool permissionsAllowViewEditConvertedLeadsFieldSpecified;
    private bool? permissionsAllowViewKnowledgeField;
    private bool permissionsAllowViewKnowledgeFieldSpecified;
    private bool? permissionsApiEnabledField;
    private bool permissionsApiEnabledFieldSpecified;
    private bool? permissionsApiUserOnlyField;
    private bool permissionsApiUserOnlyFieldSpecified;
    private bool? permissionsAssignPermissionSetsField;
    private bool permissionsAssignPermissionSetsFieldSpecified;
    private bool? permissionsAssignTopicsField;
    private bool permissionsAssignTopicsFieldSpecified;
    private bool? permissionsAuthorApexField;
    private bool permissionsAuthorApexFieldSpecified;
    private bool? permissionsBulkApiHardDeleteField;
    private bool permissionsBulkApiHardDeleteFieldSpecified;
    private bool? permissionsBulkMacrosAllowedField;
    private bool permissionsBulkMacrosAllowedFieldSpecified;
    private bool? permissionsCampaignInfluence2Field;
    private bool permissionsCampaignInfluence2FieldSpecified;
    private bool? permissionsCanApproveFeedPostField;
    private bool permissionsCanApproveFeedPostFieldSpecified;
    private bool? permissionsCanInsertFeedSystemFieldsField;
    private bool permissionsCanInsertFeedSystemFieldsFieldSpecified;
    private bool? permissionsCanUseNewDashboardBuilderField;
    private bool permissionsCanUseNewDashboardBuilderFieldSpecified;
    private bool? permissionsChatterComposeUiCodesnippetField;
    private bool permissionsChatterComposeUiCodesnippetFieldSpecified;
    private bool? permissionsChatterEditOwnPostField;
    private bool permissionsChatterEditOwnPostFieldSpecified;
    private bool? permissionsChatterEditOwnRecordPostField;
    private bool permissionsChatterEditOwnRecordPostFieldSpecified;
    private bool? permissionsChatterFileLinkField;
    private bool permissionsChatterFileLinkFieldSpecified;
    private bool? permissionsChatterInternalUserField;
    private bool permissionsChatterInternalUserFieldSpecified;
    private bool? permissionsChatterInviteExternalUsersField;
    private bool permissionsChatterInviteExternalUsersFieldSpecified;
    private bool? permissionsChatterOwnGroupsField;
    private bool permissionsChatterOwnGroupsFieldSpecified;
    private bool? permissionsConfigCustomRecsField;
    private bool permissionsConfigCustomRecsFieldSpecified;
    private bool? permissionsConnectOrgToEnvironmentHubField;
    private bool permissionsConnectOrgToEnvironmentHubFieldSpecified;
    private bool? permissionsContentAdministratorField;
    private bool permissionsContentAdministratorFieldSpecified;
    private bool? permissionsConvertLeadsField;
    private bool permissionsConvertLeadsFieldSpecified;
    private bool? permissionsCreateCustomizeDashboardsField;
    private bool permissionsCreateCustomizeDashboardsFieldSpecified;
    private bool? permissionsCreateCustomizeFiltersField;
    private bool permissionsCreateCustomizeFiltersFieldSpecified;
    private bool? permissionsCreateCustomizeReportsField;
    private bool permissionsCreateCustomizeReportsFieldSpecified;
    private bool? permissionsCreateDashboardFoldersField;
    private bool permissionsCreateDashboardFoldersFieldSpecified;
    private bool? permissionsCreateMultiforceField;
    private bool permissionsCreateMultiforceFieldSpecified;
    private bool? permissionsCreateReportFoldersField;
    private bool permissionsCreateReportFoldersFieldSpecified;
    private bool? permissionsCreateTopicsField;
    private bool permissionsCreateTopicsFieldSpecified;
    private bool? permissionsCreateWorkspacesField;
    private bool permissionsCreateWorkspacesFieldSpecified;
    private bool? permissionsCustomMobileAppsAccessField;
    private bool permissionsCustomMobileAppsAccessFieldSpecified;
    private bool? permissionsCustomSidebarOnAllPagesField;
    private bool permissionsCustomSidebarOnAllPagesFieldSpecified;
    private bool? permissionsCustomizeApplicationField;
    private bool permissionsCustomizeApplicationFieldSpecified;
    private bool? permissionsDataExportField;
    private bool permissionsDataExportFieldSpecified;
    private bool? permissionsDelegatedTwoFactorField;
    private bool permissionsDelegatedTwoFactorFieldSpecified;
    private bool? permissionsDeleteActivatedContractField;
    private bool permissionsDeleteActivatedContractFieldSpecified;
    private bool? permissionsDeleteTopicsField;
    private bool permissionsDeleteTopicsFieldSpecified;
    private bool? permissionsDistributeFromPersWkspField;
    private bool permissionsDistributeFromPersWkspFieldSpecified;
    private bool? permissionsEditActivatedOrdersField;
    private bool permissionsEditActivatedOrdersFieldSpecified;
    private bool? permissionsEditBrandTemplatesField;
    private bool permissionsEditBrandTemplatesFieldSpecified;
    private bool? permissionsEditCaseCommentsField;
    private bool permissionsEditCaseCommentsFieldSpecified;
    private bool? permissionsEditEventField;
    private bool permissionsEditEventFieldSpecified;
    private bool? permissionsEditHtmlTemplatesField;
    private bool permissionsEditHtmlTemplatesFieldSpecified;
    private bool? permissionsEditKnowledgeField;
    private bool permissionsEditKnowledgeFieldSpecified;
    private bool? permissionsEditMyDashboardsField;
    private bool permissionsEditMyDashboardsFieldSpecified;
    private bool? permissionsEditMyReportsField;
    private bool permissionsEditMyReportsFieldSpecified;
    private bool? permissionsEditOppLineItemUnitPriceField;
    private bool permissionsEditOppLineItemUnitPriceFieldSpecified;
    private bool? permissionsEditPublicDocumentsField;
    private bool permissionsEditPublicDocumentsFieldSpecified;
    private bool? permissionsEditPublicTemplatesField;
    private bool permissionsEditPublicTemplatesFieldSpecified;
    private bool? permissionsEditReadonlyFieldsField;
    private bool permissionsEditReadonlyFieldsFieldSpecified;
    private bool? permissionsEditTaskField;
    private bool permissionsEditTaskFieldSpecified;
    private bool? permissionsEditTopicsField;
    private bool permissionsEditTopicsFieldSpecified;
    private bool? permissionsEmailAdministrationField;
    private bool permissionsEmailAdministrationFieldSpecified;
    private bool? permissionsEmailMassField;
    private bool permissionsEmailMassFieldSpecified;
    private bool? permissionsEmailSingleField;
    private bool permissionsEmailSingleFieldSpecified;
    private bool? permissionsEmailTemplateManagementField;
    private bool permissionsEmailTemplateManagementFieldSpecified;
    private bool? permissionsEnableNotificationsField;
    private bool permissionsEnableNotificationsFieldSpecified;
    private bool? permissionsExportReportField;
    private bool permissionsExportReportFieldSpecified;
    private bool? permissionsFlowUFLRequiredField;
    private bool permissionsFlowUFLRequiredFieldSpecified;
    private bool? permissionsForceTwoFactorField;
    private bool permissionsForceTwoFactorFieldSpecified;
    private bool? permissionsIdentityConnectField;
    private bool permissionsIdentityConnectFieldSpecified;
    private bool? permissionsIdentityEnabledField;
    private bool permissionsIdentityEnabledFieldSpecified;
    private bool? permissionsImportCustomObjectsField;
    private bool permissionsImportCustomObjectsFieldSpecified;
    private bool? permissionsImportLeadsField;
    private bool permissionsImportLeadsFieldSpecified;
    private bool? permissionsImportPersonalField;
    private bool permissionsImportPersonalFieldSpecified;
    private bool? permissionsInboundMigrationToolsUserField;
    private bool permissionsInboundMigrationToolsUserFieldSpecified;
    private bool? permissionsInstallMultiforceField;
    private bool permissionsInstallMultiforceFieldSpecified;
    private bool? permissionsLightningExperienceUserField;
    private bool permissionsLightningExperienceUserFieldSpecified;
    private bool? permissionsManageAnalyticSnapshotsField;
    private bool permissionsManageAnalyticSnapshotsFieldSpecified;
    private bool? permissionsManageAuthProvidersField;
    private bool permissionsManageAuthProvidersFieldSpecified;
    private bool? permissionsManageBusinessHourHolidaysField;
    private bool permissionsManageBusinessHourHolidaysFieldSpecified;
    private bool? permissionsManageCallCentersField;
    private bool permissionsManageCallCentersFieldSpecified;
    private bool? permissionsManageCasesField;
    private bool permissionsManageCasesFieldSpecified;
    private bool? permissionsManageCategoriesField;
    private bool permissionsManageCategoriesFieldSpecified;
    private bool? permissionsManageChatterMessagesField;
    private bool permissionsManageChatterMessagesFieldSpecified;
    private bool? permissionsManageContentPermissionsField;
    private bool permissionsManageContentPermissionsFieldSpecified;
    private bool? permissionsManageContentPropertiesField;
    private bool permissionsManageContentPropertiesFieldSpecified;
    private bool? permissionsManageContentTypesField;
    private bool permissionsManageContentTypesFieldSpecified;
    private bool? permissionsManageCustomPermissionsField;
    private bool permissionsManageCustomPermissionsFieldSpecified;
    private bool? permissionsManageCustomReportTypesField;
    private bool permissionsManageCustomReportTypesFieldSpecified;
    private bool? permissionsManageDashbdsInPubFoldersField;
    private bool permissionsManageDashbdsInPubFoldersFieldSpecified;
    private bool? permissionsManageDataCategoriesField;
    private bool permissionsManageDataCategoriesFieldSpecified;
    private bool? permissionsManageDataIntegrationsField;
    private bool permissionsManageDataIntegrationsFieldSpecified;
    private bool? permissionsManageDynamicDashboardsField;
    private bool permissionsManageDynamicDashboardsFieldSpecified;
    private bool? permissionsManageEmailClientConfigField;
    private bool permissionsManageEmailClientConfigFieldSpecified;
    private bool? permissionsManageExchangeConfigField;
    private bool permissionsManageExchangeConfigFieldSpecified;
    private bool? permissionsManageHealthCheckField;
    private bool permissionsManageHealthCheckFieldSpecified;
    private bool? permissionsManageInteractionField;
    private bool permissionsManageInteractionFieldSpecified;
    private bool? permissionsManageInternalUsersField;
    private bool permissionsManageInternalUsersFieldSpecified;
    private bool? permissionsManageIpAddressesField;
    private bool permissionsManageIpAddressesFieldSpecified;
    private bool? permissionsManageKnowledgeField;
    private bool permissionsManageKnowledgeFieldSpecified;
    private bool? permissionsManageKnowledgeImportExportField;
    private bool permissionsManageKnowledgeImportExportFieldSpecified;
    private bool? permissionsManageLeadsField;
    private bool permissionsManageLeadsFieldSpecified;
    private bool? permissionsManageLoginAccessPoliciesField;
    private bool permissionsManageLoginAccessPoliciesFieldSpecified;
    private bool? permissionsManageMobileField;
    private bool permissionsManageMobileFieldSpecified;
    private bool? permissionsManagePasswordPoliciesField;
    private bool permissionsManagePasswordPoliciesFieldSpecified;
    private bool? permissionsManageProfilesPermissionsetsField;
    private bool permissionsManageProfilesPermissionsetsFieldSpecified;
    private bool? permissionsManagePvtRptsAndDashbdsField;
    private bool permissionsManagePvtRptsAndDashbdsFieldSpecified;
    private bool? permissionsManageRemoteAccessField;
    private bool permissionsManageRemoteAccessFieldSpecified;
    private bool? permissionsManageReportsInPubFoldersField;
    private bool permissionsManageReportsInPubFoldersFieldSpecified;
    private bool? permissionsManageRolesField;
    private bool permissionsManageRolesFieldSpecified;
    private bool? permissionsManageSearchPromotionRulesField;
    private bool permissionsManageSearchPromotionRulesFieldSpecified;
    private bool? permissionsManageSharingField;
    private bool permissionsManageSharingFieldSpecified;
    private bool? permissionsManageSolutionsField;
    private bool permissionsManageSolutionsFieldSpecified;
    private bool? permissionsManageSynonymsField;
    private bool permissionsManageSynonymsFieldSpecified;
    private bool? permissionsManageTwoFactorField;
    private bool permissionsManageTwoFactorFieldSpecified;
    private bool? permissionsManageUnlistedGroupsField;
    private bool permissionsManageUnlistedGroupsFieldSpecified;
    private bool? permissionsManageUsersField;
    private bool permissionsManageUsersFieldSpecified;
    private bool? permissionsMassInlineEditField;
    private bool permissionsMassInlineEditFieldSpecified;
    private bool? permissionsMergeTopicsField;
    private bool permissionsMergeTopicsFieldSpecified;
    private bool? permissionsModerateChatterField;
    private bool permissionsModerateChatterFieldSpecified;
    private bool? permissionsModifyAllDataField;
    private bool permissionsModifyAllDataFieldSpecified;
    private bool? permissionsNewReportBuilderField;
    private bool permissionsNewReportBuilderFieldSpecified;
    private bool? permissionsOutboundMigrationToolsUserField;
    private bool permissionsOutboundMigrationToolsUserFieldSpecified;
    private bool? permissionsPasswordNeverExpiresField;
    private bool permissionsPasswordNeverExpiresFieldSpecified;
    private bool? permissionsPublishMultiforceField;
    private bool permissionsPublishMultiforceFieldSpecified;
    private bool? permissionsResetPasswordsField;
    private bool permissionsResetPasswordsFieldSpecified;
    private bool? permissionsRunFlowField;
    private bool permissionsRunFlowFieldSpecified;
    private bool? permissionsRunReportsField;
    private bool permissionsRunReportsFieldSpecified;
    private bool? permissionsSalesConsoleField;
    private bool permissionsSalesConsoleFieldSpecified;
    private bool? permissionsScheduleJobField;
    private bool permissionsScheduleJobFieldSpecified;
    private bool? permissionsScheduleReportsField;
    private bool permissionsScheduleReportsFieldSpecified;
    private bool? permissionsSelectFilesFromSalesforceField;
    private bool permissionsSelectFilesFromSalesforceFieldSpecified;
    private bool? permissionsSendAnnouncementEmailsField;
    private bool permissionsSendAnnouncementEmailsFieldSpecified;
    private bool? permissionsSendSitRequestsField;
    private bool permissionsSendSitRequestsFieldSpecified;
    private bool? permissionsShareInternalArticlesField;
    private bool permissionsShareInternalArticlesFieldSpecified;
    private bool? permissionsShowCompanyNameAsUserBadgeField;
    private bool permissionsShowCompanyNameAsUserBadgeFieldSpecified;
    private bool? permissionsSolutionImportField;
    private bool permissionsSolutionImportFieldSpecified;
    private bool? permissionsSubmitMacrosAllowedField;
    private bool permissionsSubmitMacrosAllowedFieldSpecified;
    private bool? permissionsSubscribeToLightningReportsField;
    private bool permissionsSubscribeToLightningReportsFieldSpecified;
    private bool? permissionsTransferAnyCaseField;
    private bool permissionsTransferAnyCaseFieldSpecified;
    private bool? permissionsTransferAnyEntityField;
    private bool permissionsTransferAnyEntityFieldSpecified;
    private bool? permissionsTransferAnyLeadField;
    private bool permissionsTransferAnyLeadFieldSpecified;
    private bool? permissionsTwoFactorApiField;
    private bool permissionsTwoFactorApiFieldSpecified;
    private bool? permissionsUseTeamReassignWizardsField;
    private bool permissionsUseTeamReassignWizardsFieldSpecified;
    private bool? permissionsViewAllActivitiesField;
    private bool permissionsViewAllActivitiesFieldSpecified;
    private bool? permissionsViewAllDataField;
    private bool permissionsViewAllDataFieldSpecified;
    private bool? permissionsViewAllUsersField;
    private bool permissionsViewAllUsersFieldSpecified;
    private bool? permissionsViewContentField;
    private bool permissionsViewContentFieldSpecified;
    private bool? permissionsViewDataAssessmentField;
    private bool permissionsViewDataAssessmentFieldSpecified;
    private bool? permissionsViewDataCategoriesField;
    private bool permissionsViewDataCategoriesFieldSpecified;
    private bool? permissionsViewEncryptedDataField;
    private bool permissionsViewEncryptedDataFieldSpecified;
    private bool? permissionsViewEventLogFilesField;
    private bool permissionsViewEventLogFilesFieldSpecified;
    private bool? permissionsViewHealthCheckField;
    private bool permissionsViewHealthCheckFieldSpecified;
    private bool? permissionsViewHelpLinkField;
    private bool permissionsViewHelpLinkFieldSpecified;
    private bool? permissionsViewMyTeamsDashboardsField;
    private bool permissionsViewMyTeamsDashboardsFieldSpecified;
    private bool? permissionsViewPublicDashboardsField;
    private bool permissionsViewPublicDashboardsFieldSpecified;
    private bool? permissionsViewPublicReportsField;
    private bool permissionsViewPublicReportsFieldSpecified;
    private bool? permissionsViewSetupField;
    private bool permissionsViewSetupFieldSpecified;
    private bool? permissionsWorkCalibrationUserField;
    private bool permissionsWorkCalibrationUserFieldSpecified;
    private bool? permissionsWorkDotComUserPermField;
    private bool permissionsWorkDotComUserPermFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private UserLicense userLicenseField;
    private string userLicenseIdField;
    private string userTypeField;
    private QueryResult usersField;

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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsActivateContract
    {
      get => this.permissionsActivateContractField;
      set => this.permissionsActivateContractField = value;
    }

    [XmlIgnore]
    public bool PermissionsActivateContractSpecified
    {
      get => this.permissionsActivateContractFieldSpecified;
      set => this.permissionsActivateContractFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsActivateOrder
    {
      get => this.permissionsActivateOrderField;
      set => this.permissionsActivateOrderField = value;
    }

    [XmlIgnore]
    public bool PermissionsActivateOrderSpecified
    {
      get => this.permissionsActivateOrderFieldSpecified;
      set => this.permissionsActivateOrderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsAllowEmailIC
    {
      get => this.permissionsAllowEmailICField;
      set => this.permissionsAllowEmailICField = value;
    }

    [XmlIgnore]
    public bool PermissionsAllowEmailICSpecified
    {
      get => this.permissionsAllowEmailICFieldSpecified;
      set => this.permissionsAllowEmailICFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsAllowUniversalSearch
    {
      get => this.permissionsAllowUniversalSearchField;
      set => this.permissionsAllowUniversalSearchField = value;
    }

    [XmlIgnore]
    public bool PermissionsAllowUniversalSearchSpecified
    {
      get => this.permissionsAllowUniversalSearchFieldSpecified;
      set => this.permissionsAllowUniversalSearchFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsAllowViewEditConvertedLeads
    {
      get => this.permissionsAllowViewEditConvertedLeadsField;
      set => this.permissionsAllowViewEditConvertedLeadsField = value;
    }

    [XmlIgnore]
    public bool PermissionsAllowViewEditConvertedLeadsSpecified
    {
      get => this.permissionsAllowViewEditConvertedLeadsFieldSpecified;
      set => this.permissionsAllowViewEditConvertedLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsAllowViewKnowledge
    {
      get => this.permissionsAllowViewKnowledgeField;
      set => this.permissionsAllowViewKnowledgeField = value;
    }

    [XmlIgnore]
    public bool PermissionsAllowViewKnowledgeSpecified
    {
      get => this.permissionsAllowViewKnowledgeFieldSpecified;
      set => this.permissionsAllowViewKnowledgeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsApiEnabled
    {
      get => this.permissionsApiEnabledField;
      set => this.permissionsApiEnabledField = value;
    }

    [XmlIgnore]
    public bool PermissionsApiEnabledSpecified
    {
      get => this.permissionsApiEnabledFieldSpecified;
      set => this.permissionsApiEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsApiUserOnly
    {
      get => this.permissionsApiUserOnlyField;
      set => this.permissionsApiUserOnlyField = value;
    }

    [XmlIgnore]
    public bool PermissionsApiUserOnlySpecified
    {
      get => this.permissionsApiUserOnlyFieldSpecified;
      set => this.permissionsApiUserOnlyFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsAssignPermissionSets
    {
      get => this.permissionsAssignPermissionSetsField;
      set => this.permissionsAssignPermissionSetsField = value;
    }

    [XmlIgnore]
    public bool PermissionsAssignPermissionSetsSpecified
    {
      get => this.permissionsAssignPermissionSetsFieldSpecified;
      set => this.permissionsAssignPermissionSetsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsAssignTopics
    {
      get => this.permissionsAssignTopicsField;
      set => this.permissionsAssignTopicsField = value;
    }

    [XmlIgnore]
    public bool PermissionsAssignTopicsSpecified
    {
      get => this.permissionsAssignTopicsFieldSpecified;
      set => this.permissionsAssignTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsAuthorApex
    {
      get => this.permissionsAuthorApexField;
      set => this.permissionsAuthorApexField = value;
    }

    [XmlIgnore]
    public bool PermissionsAuthorApexSpecified
    {
      get => this.permissionsAuthorApexFieldSpecified;
      set => this.permissionsAuthorApexFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsBulkApiHardDelete
    {
      get => this.permissionsBulkApiHardDeleteField;
      set => this.permissionsBulkApiHardDeleteField = value;
    }

    [XmlIgnore]
    public bool PermissionsBulkApiHardDeleteSpecified
    {
      get => this.permissionsBulkApiHardDeleteFieldSpecified;
      set => this.permissionsBulkApiHardDeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsBulkMacrosAllowed
    {
      get => this.permissionsBulkMacrosAllowedField;
      set => this.permissionsBulkMacrosAllowedField = value;
    }

    [XmlIgnore]
    public bool PermissionsBulkMacrosAllowedSpecified
    {
      get => this.permissionsBulkMacrosAllowedFieldSpecified;
      set => this.permissionsBulkMacrosAllowedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCampaignInfluence2
    {
      get => this.permissionsCampaignInfluence2Field;
      set => this.permissionsCampaignInfluence2Field = value;
    }

    [XmlIgnore]
    public bool PermissionsCampaignInfluence2Specified
    {
      get => this.permissionsCampaignInfluence2FieldSpecified;
      set => this.permissionsCampaignInfluence2FieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCanApproveFeedPost
    {
      get => this.permissionsCanApproveFeedPostField;
      set => this.permissionsCanApproveFeedPostField = value;
    }

    [XmlIgnore]
    public bool PermissionsCanApproveFeedPostSpecified
    {
      get => this.permissionsCanApproveFeedPostFieldSpecified;
      set => this.permissionsCanApproveFeedPostFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCanInsertFeedSystemFields
    {
      get => this.permissionsCanInsertFeedSystemFieldsField;
      set => this.permissionsCanInsertFeedSystemFieldsField = value;
    }

    [XmlIgnore]
    public bool PermissionsCanInsertFeedSystemFieldsSpecified
    {
      get => this.permissionsCanInsertFeedSystemFieldsFieldSpecified;
      set => this.permissionsCanInsertFeedSystemFieldsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCanUseNewDashboardBuilder
    {
      get => this.permissionsCanUseNewDashboardBuilderField;
      set => this.permissionsCanUseNewDashboardBuilderField = value;
    }

    [XmlIgnore]
    public bool PermissionsCanUseNewDashboardBuilderSpecified
    {
      get => this.permissionsCanUseNewDashboardBuilderFieldSpecified;
      set => this.permissionsCanUseNewDashboardBuilderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsChatterComposeUiCodesnippet
    {
      get => this.permissionsChatterComposeUiCodesnippetField;
      set => this.permissionsChatterComposeUiCodesnippetField = value;
    }

    [XmlIgnore]
    public bool PermissionsChatterComposeUiCodesnippetSpecified
    {
      get => this.permissionsChatterComposeUiCodesnippetFieldSpecified;
      set => this.permissionsChatterComposeUiCodesnippetFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsChatterEditOwnPost
    {
      get => this.permissionsChatterEditOwnPostField;
      set => this.permissionsChatterEditOwnPostField = value;
    }

    [XmlIgnore]
    public bool PermissionsChatterEditOwnPostSpecified
    {
      get => this.permissionsChatterEditOwnPostFieldSpecified;
      set => this.permissionsChatterEditOwnPostFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsChatterEditOwnRecordPost
    {
      get => this.permissionsChatterEditOwnRecordPostField;
      set => this.permissionsChatterEditOwnRecordPostField = value;
    }

    [XmlIgnore]
    public bool PermissionsChatterEditOwnRecordPostSpecified
    {
      get => this.permissionsChatterEditOwnRecordPostFieldSpecified;
      set => this.permissionsChatterEditOwnRecordPostFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsChatterFileLink
    {
      get => this.permissionsChatterFileLinkField;
      set => this.permissionsChatterFileLinkField = value;
    }

    [XmlIgnore]
    public bool PermissionsChatterFileLinkSpecified
    {
      get => this.permissionsChatterFileLinkFieldSpecified;
      set => this.permissionsChatterFileLinkFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsChatterInternalUser
    {
      get => this.permissionsChatterInternalUserField;
      set => this.permissionsChatterInternalUserField = value;
    }

    [XmlIgnore]
    public bool PermissionsChatterInternalUserSpecified
    {
      get => this.permissionsChatterInternalUserFieldSpecified;
      set => this.permissionsChatterInternalUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsChatterInviteExternalUsers
    {
      get => this.permissionsChatterInviteExternalUsersField;
      set => this.permissionsChatterInviteExternalUsersField = value;
    }

    [XmlIgnore]
    public bool PermissionsChatterInviteExternalUsersSpecified
    {
      get => this.permissionsChatterInviteExternalUsersFieldSpecified;
      set => this.permissionsChatterInviteExternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsChatterOwnGroups
    {
      get => this.permissionsChatterOwnGroupsField;
      set => this.permissionsChatterOwnGroupsField = value;
    }

    [XmlIgnore]
    public bool PermissionsChatterOwnGroupsSpecified
    {
      get => this.permissionsChatterOwnGroupsFieldSpecified;
      set => this.permissionsChatterOwnGroupsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsConfigCustomRecs
    {
      get => this.permissionsConfigCustomRecsField;
      set => this.permissionsConfigCustomRecsField = value;
    }

    [XmlIgnore]
    public bool PermissionsConfigCustomRecsSpecified
    {
      get => this.permissionsConfigCustomRecsFieldSpecified;
      set => this.permissionsConfigCustomRecsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsConnectOrgToEnvironmentHub
    {
      get => this.permissionsConnectOrgToEnvironmentHubField;
      set => this.permissionsConnectOrgToEnvironmentHubField = value;
    }

    [XmlIgnore]
    public bool PermissionsConnectOrgToEnvironmentHubSpecified
    {
      get => this.permissionsConnectOrgToEnvironmentHubFieldSpecified;
      set => this.permissionsConnectOrgToEnvironmentHubFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsContentAdministrator
    {
      get => this.permissionsContentAdministratorField;
      set => this.permissionsContentAdministratorField = value;
    }

    [XmlIgnore]
    public bool PermissionsContentAdministratorSpecified
    {
      get => this.permissionsContentAdministratorFieldSpecified;
      set => this.permissionsContentAdministratorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsConvertLeads
    {
      get => this.permissionsConvertLeadsField;
      set => this.permissionsConvertLeadsField = value;
    }

    [XmlIgnore]
    public bool PermissionsConvertLeadsSpecified
    {
      get => this.permissionsConvertLeadsFieldSpecified;
      set => this.permissionsConvertLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCreateCustomizeDashboards
    {
      get => this.permissionsCreateCustomizeDashboardsField;
      set => this.permissionsCreateCustomizeDashboardsField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateCustomizeDashboardsSpecified
    {
      get => this.permissionsCreateCustomizeDashboardsFieldSpecified;
      set => this.permissionsCreateCustomizeDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCreateCustomizeFilters
    {
      get => this.permissionsCreateCustomizeFiltersField;
      set => this.permissionsCreateCustomizeFiltersField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateCustomizeFiltersSpecified
    {
      get => this.permissionsCreateCustomizeFiltersFieldSpecified;
      set => this.permissionsCreateCustomizeFiltersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCreateCustomizeReports
    {
      get => this.permissionsCreateCustomizeReportsField;
      set => this.permissionsCreateCustomizeReportsField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateCustomizeReportsSpecified
    {
      get => this.permissionsCreateCustomizeReportsFieldSpecified;
      set => this.permissionsCreateCustomizeReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCreateDashboardFolders
    {
      get => this.permissionsCreateDashboardFoldersField;
      set => this.permissionsCreateDashboardFoldersField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateDashboardFoldersSpecified
    {
      get => this.permissionsCreateDashboardFoldersFieldSpecified;
      set => this.permissionsCreateDashboardFoldersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCreateMultiforce
    {
      get => this.permissionsCreateMultiforceField;
      set => this.permissionsCreateMultiforceField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateMultiforceSpecified
    {
      get => this.permissionsCreateMultiforceFieldSpecified;
      set => this.permissionsCreateMultiforceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCreateReportFolders
    {
      get => this.permissionsCreateReportFoldersField;
      set => this.permissionsCreateReportFoldersField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateReportFoldersSpecified
    {
      get => this.permissionsCreateReportFoldersFieldSpecified;
      set => this.permissionsCreateReportFoldersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCreateTopics
    {
      get => this.permissionsCreateTopicsField;
      set => this.permissionsCreateTopicsField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateTopicsSpecified
    {
      get => this.permissionsCreateTopicsFieldSpecified;
      set => this.permissionsCreateTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCreateWorkspaces
    {
      get => this.permissionsCreateWorkspacesField;
      set => this.permissionsCreateWorkspacesField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateWorkspacesSpecified
    {
      get => this.permissionsCreateWorkspacesFieldSpecified;
      set => this.permissionsCreateWorkspacesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCustomMobileAppsAccess
    {
      get => this.permissionsCustomMobileAppsAccessField;
      set => this.permissionsCustomMobileAppsAccessField = value;
    }

    [XmlIgnore]
    public bool PermissionsCustomMobileAppsAccessSpecified
    {
      get => this.permissionsCustomMobileAppsAccessFieldSpecified;
      set => this.permissionsCustomMobileAppsAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCustomSidebarOnAllPages
    {
      get => this.permissionsCustomSidebarOnAllPagesField;
      set => this.permissionsCustomSidebarOnAllPagesField = value;
    }

    [XmlIgnore]
    public bool PermissionsCustomSidebarOnAllPagesSpecified
    {
      get => this.permissionsCustomSidebarOnAllPagesFieldSpecified;
      set => this.permissionsCustomSidebarOnAllPagesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsCustomizeApplication
    {
      get => this.permissionsCustomizeApplicationField;
      set => this.permissionsCustomizeApplicationField = value;
    }

    [XmlIgnore]
    public bool PermissionsCustomizeApplicationSpecified
    {
      get => this.permissionsCustomizeApplicationFieldSpecified;
      set => this.permissionsCustomizeApplicationFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsDataExport
    {
      get => this.permissionsDataExportField;
      set => this.permissionsDataExportField = value;
    }

    [XmlIgnore]
    public bool PermissionsDataExportSpecified
    {
      get => this.permissionsDataExportFieldSpecified;
      set => this.permissionsDataExportFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsDelegatedTwoFactor
    {
      get => this.permissionsDelegatedTwoFactorField;
      set => this.permissionsDelegatedTwoFactorField = value;
    }

    [XmlIgnore]
    public bool PermissionsDelegatedTwoFactorSpecified
    {
      get => this.permissionsDelegatedTwoFactorFieldSpecified;
      set => this.permissionsDelegatedTwoFactorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsDeleteActivatedContract
    {
      get => this.permissionsDeleteActivatedContractField;
      set => this.permissionsDeleteActivatedContractField = value;
    }

    [XmlIgnore]
    public bool PermissionsDeleteActivatedContractSpecified
    {
      get => this.permissionsDeleteActivatedContractFieldSpecified;
      set => this.permissionsDeleteActivatedContractFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsDeleteTopics
    {
      get => this.permissionsDeleteTopicsField;
      set => this.permissionsDeleteTopicsField = value;
    }

    [XmlIgnore]
    public bool PermissionsDeleteTopicsSpecified
    {
      get => this.permissionsDeleteTopicsFieldSpecified;
      set => this.permissionsDeleteTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsDistributeFromPersWksp
    {
      get => this.permissionsDistributeFromPersWkspField;
      set => this.permissionsDistributeFromPersWkspField = value;
    }

    [XmlIgnore]
    public bool PermissionsDistributeFromPersWkspSpecified
    {
      get => this.permissionsDistributeFromPersWkspFieldSpecified;
      set => this.permissionsDistributeFromPersWkspFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditActivatedOrders
    {
      get => this.permissionsEditActivatedOrdersField;
      set => this.permissionsEditActivatedOrdersField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditActivatedOrdersSpecified
    {
      get => this.permissionsEditActivatedOrdersFieldSpecified;
      set => this.permissionsEditActivatedOrdersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditBrandTemplates
    {
      get => this.permissionsEditBrandTemplatesField;
      set => this.permissionsEditBrandTemplatesField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditBrandTemplatesSpecified
    {
      get => this.permissionsEditBrandTemplatesFieldSpecified;
      set => this.permissionsEditBrandTemplatesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditCaseComments
    {
      get => this.permissionsEditCaseCommentsField;
      set => this.permissionsEditCaseCommentsField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditCaseCommentsSpecified
    {
      get => this.permissionsEditCaseCommentsFieldSpecified;
      set => this.permissionsEditCaseCommentsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditEvent
    {
      get => this.permissionsEditEventField;
      set => this.permissionsEditEventField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditEventSpecified
    {
      get => this.permissionsEditEventFieldSpecified;
      set => this.permissionsEditEventFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditHtmlTemplates
    {
      get => this.permissionsEditHtmlTemplatesField;
      set => this.permissionsEditHtmlTemplatesField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditHtmlTemplatesSpecified
    {
      get => this.permissionsEditHtmlTemplatesFieldSpecified;
      set => this.permissionsEditHtmlTemplatesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditKnowledge
    {
      get => this.permissionsEditKnowledgeField;
      set => this.permissionsEditKnowledgeField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditKnowledgeSpecified
    {
      get => this.permissionsEditKnowledgeFieldSpecified;
      set => this.permissionsEditKnowledgeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditMyDashboards
    {
      get => this.permissionsEditMyDashboardsField;
      set => this.permissionsEditMyDashboardsField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditMyDashboardsSpecified
    {
      get => this.permissionsEditMyDashboardsFieldSpecified;
      set => this.permissionsEditMyDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditMyReports
    {
      get => this.permissionsEditMyReportsField;
      set => this.permissionsEditMyReportsField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditMyReportsSpecified
    {
      get => this.permissionsEditMyReportsFieldSpecified;
      set => this.permissionsEditMyReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditOppLineItemUnitPrice
    {
      get => this.permissionsEditOppLineItemUnitPriceField;
      set => this.permissionsEditOppLineItemUnitPriceField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditOppLineItemUnitPriceSpecified
    {
      get => this.permissionsEditOppLineItemUnitPriceFieldSpecified;
      set => this.permissionsEditOppLineItemUnitPriceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditPublicDocuments
    {
      get => this.permissionsEditPublicDocumentsField;
      set => this.permissionsEditPublicDocumentsField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditPublicDocumentsSpecified
    {
      get => this.permissionsEditPublicDocumentsFieldSpecified;
      set => this.permissionsEditPublicDocumentsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditPublicTemplates
    {
      get => this.permissionsEditPublicTemplatesField;
      set => this.permissionsEditPublicTemplatesField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditPublicTemplatesSpecified
    {
      get => this.permissionsEditPublicTemplatesFieldSpecified;
      set => this.permissionsEditPublicTemplatesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditReadonlyFields
    {
      get => this.permissionsEditReadonlyFieldsField;
      set => this.permissionsEditReadonlyFieldsField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditReadonlyFieldsSpecified
    {
      get => this.permissionsEditReadonlyFieldsFieldSpecified;
      set => this.permissionsEditReadonlyFieldsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditTask
    {
      get => this.permissionsEditTaskField;
      set => this.permissionsEditTaskField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditTaskSpecified
    {
      get => this.permissionsEditTaskFieldSpecified;
      set => this.permissionsEditTaskFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEditTopics
    {
      get => this.permissionsEditTopicsField;
      set => this.permissionsEditTopicsField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditTopicsSpecified
    {
      get => this.permissionsEditTopicsFieldSpecified;
      set => this.permissionsEditTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEmailAdministration
    {
      get => this.permissionsEmailAdministrationField;
      set => this.permissionsEmailAdministrationField = value;
    }

    [XmlIgnore]
    public bool PermissionsEmailAdministrationSpecified
    {
      get => this.permissionsEmailAdministrationFieldSpecified;
      set => this.permissionsEmailAdministrationFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEmailMass
    {
      get => this.permissionsEmailMassField;
      set => this.permissionsEmailMassField = value;
    }

    [XmlIgnore]
    public bool PermissionsEmailMassSpecified
    {
      get => this.permissionsEmailMassFieldSpecified;
      set => this.permissionsEmailMassFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEmailSingle
    {
      get => this.permissionsEmailSingleField;
      set => this.permissionsEmailSingleField = value;
    }

    [XmlIgnore]
    public bool PermissionsEmailSingleSpecified
    {
      get => this.permissionsEmailSingleFieldSpecified;
      set => this.permissionsEmailSingleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEmailTemplateManagement
    {
      get => this.permissionsEmailTemplateManagementField;
      set => this.permissionsEmailTemplateManagementField = value;
    }

    [XmlIgnore]
    public bool PermissionsEmailTemplateManagementSpecified
    {
      get => this.permissionsEmailTemplateManagementFieldSpecified;
      set => this.permissionsEmailTemplateManagementFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEnableNotifications
    {
      get => this.permissionsEnableNotificationsField;
      set => this.permissionsEnableNotificationsField = value;
    }

    [XmlIgnore]
    public bool PermissionsEnableNotificationsSpecified
    {
      get => this.permissionsEnableNotificationsFieldSpecified;
      set => this.permissionsEnableNotificationsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsExportReport
    {
      get => this.permissionsExportReportField;
      set => this.permissionsExportReportField = value;
    }

    [XmlIgnore]
    public bool PermissionsExportReportSpecified
    {
      get => this.permissionsExportReportFieldSpecified;
      set => this.permissionsExportReportFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsFlowUFLRequired
    {
      get => this.permissionsFlowUFLRequiredField;
      set => this.permissionsFlowUFLRequiredField = value;
    }

    [XmlIgnore]
    public bool PermissionsFlowUFLRequiredSpecified
    {
      get => this.permissionsFlowUFLRequiredFieldSpecified;
      set => this.permissionsFlowUFLRequiredFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsForceTwoFactor
    {
      get => this.permissionsForceTwoFactorField;
      set => this.permissionsForceTwoFactorField = value;
    }

    [XmlIgnore]
    public bool PermissionsForceTwoFactorSpecified
    {
      get => this.permissionsForceTwoFactorFieldSpecified;
      set => this.permissionsForceTwoFactorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsIdentityConnect
    {
      get => this.permissionsIdentityConnectField;
      set => this.permissionsIdentityConnectField = value;
    }

    [XmlIgnore]
    public bool PermissionsIdentityConnectSpecified
    {
      get => this.permissionsIdentityConnectFieldSpecified;
      set => this.permissionsIdentityConnectFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsIdentityEnabled
    {
      get => this.permissionsIdentityEnabledField;
      set => this.permissionsIdentityEnabledField = value;
    }

    [XmlIgnore]
    public bool PermissionsIdentityEnabledSpecified
    {
      get => this.permissionsIdentityEnabledFieldSpecified;
      set => this.permissionsIdentityEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsImportCustomObjects
    {
      get => this.permissionsImportCustomObjectsField;
      set => this.permissionsImportCustomObjectsField = value;
    }

    [XmlIgnore]
    public bool PermissionsImportCustomObjectsSpecified
    {
      get => this.permissionsImportCustomObjectsFieldSpecified;
      set => this.permissionsImportCustomObjectsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsImportLeads
    {
      get => this.permissionsImportLeadsField;
      set => this.permissionsImportLeadsField = value;
    }

    [XmlIgnore]
    public bool PermissionsImportLeadsSpecified
    {
      get => this.permissionsImportLeadsFieldSpecified;
      set => this.permissionsImportLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsImportPersonal
    {
      get => this.permissionsImportPersonalField;
      set => this.permissionsImportPersonalField = value;
    }

    [XmlIgnore]
    public bool PermissionsImportPersonalSpecified
    {
      get => this.permissionsImportPersonalFieldSpecified;
      set => this.permissionsImportPersonalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsInboundMigrationToolsUser
    {
      get => this.permissionsInboundMigrationToolsUserField;
      set => this.permissionsInboundMigrationToolsUserField = value;
    }

    [XmlIgnore]
    public bool PermissionsInboundMigrationToolsUserSpecified
    {
      get => this.permissionsInboundMigrationToolsUserFieldSpecified;
      set => this.permissionsInboundMigrationToolsUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsInstallMultiforce
    {
      get => this.permissionsInstallMultiforceField;
      set => this.permissionsInstallMultiforceField = value;
    }

    [XmlIgnore]
    public bool PermissionsInstallMultiforceSpecified
    {
      get => this.permissionsInstallMultiforceFieldSpecified;
      set => this.permissionsInstallMultiforceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsLightningExperienceUser
    {
      get => this.permissionsLightningExperienceUserField;
      set => this.permissionsLightningExperienceUserField = value;
    }

    [XmlIgnore]
    public bool PermissionsLightningExperienceUserSpecified
    {
      get => this.permissionsLightningExperienceUserFieldSpecified;
      set => this.permissionsLightningExperienceUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageAnalyticSnapshots
    {
      get => this.permissionsManageAnalyticSnapshotsField;
      set => this.permissionsManageAnalyticSnapshotsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageAnalyticSnapshotsSpecified
    {
      get => this.permissionsManageAnalyticSnapshotsFieldSpecified;
      set => this.permissionsManageAnalyticSnapshotsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageAuthProviders
    {
      get => this.permissionsManageAuthProvidersField;
      set => this.permissionsManageAuthProvidersField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageAuthProvidersSpecified
    {
      get => this.permissionsManageAuthProvidersFieldSpecified;
      set => this.permissionsManageAuthProvidersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageBusinessHourHolidays
    {
      get => this.permissionsManageBusinessHourHolidaysField;
      set => this.permissionsManageBusinessHourHolidaysField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageBusinessHourHolidaysSpecified
    {
      get => this.permissionsManageBusinessHourHolidaysFieldSpecified;
      set => this.permissionsManageBusinessHourHolidaysFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageCallCenters
    {
      get => this.permissionsManageCallCentersField;
      set => this.permissionsManageCallCentersField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageCallCentersSpecified
    {
      get => this.permissionsManageCallCentersFieldSpecified;
      set => this.permissionsManageCallCentersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageCases
    {
      get => this.permissionsManageCasesField;
      set => this.permissionsManageCasesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageCasesSpecified
    {
      get => this.permissionsManageCasesFieldSpecified;
      set => this.permissionsManageCasesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageCategories
    {
      get => this.permissionsManageCategoriesField;
      set => this.permissionsManageCategoriesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageCategoriesSpecified
    {
      get => this.permissionsManageCategoriesFieldSpecified;
      set => this.permissionsManageCategoriesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageChatterMessages
    {
      get => this.permissionsManageChatterMessagesField;
      set => this.permissionsManageChatterMessagesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageChatterMessagesSpecified
    {
      get => this.permissionsManageChatterMessagesFieldSpecified;
      set => this.permissionsManageChatterMessagesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageContentPermissions
    {
      get => this.permissionsManageContentPermissionsField;
      set => this.permissionsManageContentPermissionsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageContentPermissionsSpecified
    {
      get => this.permissionsManageContentPermissionsFieldSpecified;
      set => this.permissionsManageContentPermissionsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageContentProperties
    {
      get => this.permissionsManageContentPropertiesField;
      set => this.permissionsManageContentPropertiesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageContentPropertiesSpecified
    {
      get => this.permissionsManageContentPropertiesFieldSpecified;
      set => this.permissionsManageContentPropertiesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageContentTypes
    {
      get => this.permissionsManageContentTypesField;
      set => this.permissionsManageContentTypesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageContentTypesSpecified
    {
      get => this.permissionsManageContentTypesFieldSpecified;
      set => this.permissionsManageContentTypesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageCustomPermissions
    {
      get => this.permissionsManageCustomPermissionsField;
      set => this.permissionsManageCustomPermissionsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageCustomPermissionsSpecified
    {
      get => this.permissionsManageCustomPermissionsFieldSpecified;
      set => this.permissionsManageCustomPermissionsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageCustomReportTypes
    {
      get => this.permissionsManageCustomReportTypesField;
      set => this.permissionsManageCustomReportTypesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageCustomReportTypesSpecified
    {
      get => this.permissionsManageCustomReportTypesFieldSpecified;
      set => this.permissionsManageCustomReportTypesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageDashbdsInPubFolders
    {
      get => this.permissionsManageDashbdsInPubFoldersField;
      set => this.permissionsManageDashbdsInPubFoldersField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageDashbdsInPubFoldersSpecified
    {
      get => this.permissionsManageDashbdsInPubFoldersFieldSpecified;
      set => this.permissionsManageDashbdsInPubFoldersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageDataCategories
    {
      get => this.permissionsManageDataCategoriesField;
      set => this.permissionsManageDataCategoriesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageDataCategoriesSpecified
    {
      get => this.permissionsManageDataCategoriesFieldSpecified;
      set => this.permissionsManageDataCategoriesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageDataIntegrations
    {
      get => this.permissionsManageDataIntegrationsField;
      set => this.permissionsManageDataIntegrationsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageDataIntegrationsSpecified
    {
      get => this.permissionsManageDataIntegrationsFieldSpecified;
      set => this.permissionsManageDataIntegrationsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageDynamicDashboards
    {
      get => this.permissionsManageDynamicDashboardsField;
      set => this.permissionsManageDynamicDashboardsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageDynamicDashboardsSpecified
    {
      get => this.permissionsManageDynamicDashboardsFieldSpecified;
      set => this.permissionsManageDynamicDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageEmailClientConfig
    {
      get => this.permissionsManageEmailClientConfigField;
      set => this.permissionsManageEmailClientConfigField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageEmailClientConfigSpecified
    {
      get => this.permissionsManageEmailClientConfigFieldSpecified;
      set => this.permissionsManageEmailClientConfigFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageExchangeConfig
    {
      get => this.permissionsManageExchangeConfigField;
      set => this.permissionsManageExchangeConfigField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageExchangeConfigSpecified
    {
      get => this.permissionsManageExchangeConfigFieldSpecified;
      set => this.permissionsManageExchangeConfigFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageHealthCheck
    {
      get => this.permissionsManageHealthCheckField;
      set => this.permissionsManageHealthCheckField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageHealthCheckSpecified
    {
      get => this.permissionsManageHealthCheckFieldSpecified;
      set => this.permissionsManageHealthCheckFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageInteraction
    {
      get => this.permissionsManageInteractionField;
      set => this.permissionsManageInteractionField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageInteractionSpecified
    {
      get => this.permissionsManageInteractionFieldSpecified;
      set => this.permissionsManageInteractionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageInternalUsers
    {
      get => this.permissionsManageInternalUsersField;
      set => this.permissionsManageInternalUsersField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageInternalUsersSpecified
    {
      get => this.permissionsManageInternalUsersFieldSpecified;
      set => this.permissionsManageInternalUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageIpAddresses
    {
      get => this.permissionsManageIpAddressesField;
      set => this.permissionsManageIpAddressesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageIpAddressesSpecified
    {
      get => this.permissionsManageIpAddressesFieldSpecified;
      set => this.permissionsManageIpAddressesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageKnowledge
    {
      get => this.permissionsManageKnowledgeField;
      set => this.permissionsManageKnowledgeField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageKnowledgeSpecified
    {
      get => this.permissionsManageKnowledgeFieldSpecified;
      set => this.permissionsManageKnowledgeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageKnowledgeImportExport
    {
      get => this.permissionsManageKnowledgeImportExportField;
      set => this.permissionsManageKnowledgeImportExportField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageKnowledgeImportExportSpecified
    {
      get => this.permissionsManageKnowledgeImportExportFieldSpecified;
      set => this.permissionsManageKnowledgeImportExportFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageLeads
    {
      get => this.permissionsManageLeadsField;
      set => this.permissionsManageLeadsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageLeadsSpecified
    {
      get => this.permissionsManageLeadsFieldSpecified;
      set => this.permissionsManageLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageLoginAccessPolicies
    {
      get => this.permissionsManageLoginAccessPoliciesField;
      set => this.permissionsManageLoginAccessPoliciesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageLoginAccessPoliciesSpecified
    {
      get => this.permissionsManageLoginAccessPoliciesFieldSpecified;
      set => this.permissionsManageLoginAccessPoliciesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageMobile
    {
      get => this.permissionsManageMobileField;
      set => this.permissionsManageMobileField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageMobileSpecified
    {
      get => this.permissionsManageMobileFieldSpecified;
      set => this.permissionsManageMobileFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManagePasswordPolicies
    {
      get => this.permissionsManagePasswordPoliciesField;
      set => this.permissionsManagePasswordPoliciesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManagePasswordPoliciesSpecified
    {
      get => this.permissionsManagePasswordPoliciesFieldSpecified;
      set => this.permissionsManagePasswordPoliciesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageProfilesPermissionsets
    {
      get => this.permissionsManageProfilesPermissionsetsField;
      set => this.permissionsManageProfilesPermissionsetsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageProfilesPermissionsetsSpecified
    {
      get => this.permissionsManageProfilesPermissionsetsFieldSpecified;
      set => this.permissionsManageProfilesPermissionsetsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManagePvtRptsAndDashbds
    {
      get => this.permissionsManagePvtRptsAndDashbdsField;
      set => this.permissionsManagePvtRptsAndDashbdsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManagePvtRptsAndDashbdsSpecified
    {
      get => this.permissionsManagePvtRptsAndDashbdsFieldSpecified;
      set => this.permissionsManagePvtRptsAndDashbdsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageRemoteAccess
    {
      get => this.permissionsManageRemoteAccessField;
      set => this.permissionsManageRemoteAccessField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageRemoteAccessSpecified
    {
      get => this.permissionsManageRemoteAccessFieldSpecified;
      set => this.permissionsManageRemoteAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageReportsInPubFolders
    {
      get => this.permissionsManageReportsInPubFoldersField;
      set => this.permissionsManageReportsInPubFoldersField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageReportsInPubFoldersSpecified
    {
      get => this.permissionsManageReportsInPubFoldersFieldSpecified;
      set => this.permissionsManageReportsInPubFoldersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageRoles
    {
      get => this.permissionsManageRolesField;
      set => this.permissionsManageRolesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageRolesSpecified
    {
      get => this.permissionsManageRolesFieldSpecified;
      set => this.permissionsManageRolesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageSearchPromotionRules
    {
      get => this.permissionsManageSearchPromotionRulesField;
      set => this.permissionsManageSearchPromotionRulesField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageSearchPromotionRulesSpecified
    {
      get => this.permissionsManageSearchPromotionRulesFieldSpecified;
      set => this.permissionsManageSearchPromotionRulesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageSharing
    {
      get => this.permissionsManageSharingField;
      set => this.permissionsManageSharingField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageSharingSpecified
    {
      get => this.permissionsManageSharingFieldSpecified;
      set => this.permissionsManageSharingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageSolutions
    {
      get => this.permissionsManageSolutionsField;
      set => this.permissionsManageSolutionsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageSolutionsSpecified
    {
      get => this.permissionsManageSolutionsFieldSpecified;
      set => this.permissionsManageSolutionsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageSynonyms
    {
      get => this.permissionsManageSynonymsField;
      set => this.permissionsManageSynonymsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageSynonymsSpecified
    {
      get => this.permissionsManageSynonymsFieldSpecified;
      set => this.permissionsManageSynonymsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageTwoFactor
    {
      get => this.permissionsManageTwoFactorField;
      set => this.permissionsManageTwoFactorField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageTwoFactorSpecified
    {
      get => this.permissionsManageTwoFactorFieldSpecified;
      set => this.permissionsManageTwoFactorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageUnlistedGroups
    {
      get => this.permissionsManageUnlistedGroupsField;
      set => this.permissionsManageUnlistedGroupsField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageUnlistedGroupsSpecified
    {
      get => this.permissionsManageUnlistedGroupsFieldSpecified;
      set => this.permissionsManageUnlistedGroupsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsManageUsers
    {
      get => this.permissionsManageUsersField;
      set => this.permissionsManageUsersField = value;
    }

    [XmlIgnore]
    public bool PermissionsManageUsersSpecified
    {
      get => this.permissionsManageUsersFieldSpecified;
      set => this.permissionsManageUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsMassInlineEdit
    {
      get => this.permissionsMassInlineEditField;
      set => this.permissionsMassInlineEditField = value;
    }

    [XmlIgnore]
    public bool PermissionsMassInlineEditSpecified
    {
      get => this.permissionsMassInlineEditFieldSpecified;
      set => this.permissionsMassInlineEditFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsMergeTopics
    {
      get => this.permissionsMergeTopicsField;
      set => this.permissionsMergeTopicsField = value;
    }

    [XmlIgnore]
    public bool PermissionsMergeTopicsSpecified
    {
      get => this.permissionsMergeTopicsFieldSpecified;
      set => this.permissionsMergeTopicsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsModerateChatter
    {
      get => this.permissionsModerateChatterField;
      set => this.permissionsModerateChatterField = value;
    }

    [XmlIgnore]
    public bool PermissionsModerateChatterSpecified
    {
      get => this.permissionsModerateChatterFieldSpecified;
      set => this.permissionsModerateChatterFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsModifyAllData
    {
      get => this.permissionsModifyAllDataField;
      set => this.permissionsModifyAllDataField = value;
    }

    [XmlIgnore]
    public bool PermissionsModifyAllDataSpecified
    {
      get => this.permissionsModifyAllDataFieldSpecified;
      set => this.permissionsModifyAllDataFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsNewReportBuilder
    {
      get => this.permissionsNewReportBuilderField;
      set => this.permissionsNewReportBuilderField = value;
    }

    [XmlIgnore]
    public bool PermissionsNewReportBuilderSpecified
    {
      get => this.permissionsNewReportBuilderFieldSpecified;
      set => this.permissionsNewReportBuilderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsOutboundMigrationToolsUser
    {
      get => this.permissionsOutboundMigrationToolsUserField;
      set => this.permissionsOutboundMigrationToolsUserField = value;
    }

    [XmlIgnore]
    public bool PermissionsOutboundMigrationToolsUserSpecified
    {
      get => this.permissionsOutboundMigrationToolsUserFieldSpecified;
      set => this.permissionsOutboundMigrationToolsUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsPasswordNeverExpires
    {
      get => this.permissionsPasswordNeverExpiresField;
      set => this.permissionsPasswordNeverExpiresField = value;
    }

    [XmlIgnore]
    public bool PermissionsPasswordNeverExpiresSpecified
    {
      get => this.permissionsPasswordNeverExpiresFieldSpecified;
      set => this.permissionsPasswordNeverExpiresFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsPublishMultiforce
    {
      get => this.permissionsPublishMultiforceField;
      set => this.permissionsPublishMultiforceField = value;
    }

    [XmlIgnore]
    public bool PermissionsPublishMultiforceSpecified
    {
      get => this.permissionsPublishMultiforceFieldSpecified;
      set => this.permissionsPublishMultiforceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsResetPasswords
    {
      get => this.permissionsResetPasswordsField;
      set => this.permissionsResetPasswordsField = value;
    }

    [XmlIgnore]
    public bool PermissionsResetPasswordsSpecified
    {
      get => this.permissionsResetPasswordsFieldSpecified;
      set => this.permissionsResetPasswordsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsRunFlow
    {
      get => this.permissionsRunFlowField;
      set => this.permissionsRunFlowField = value;
    }

    [XmlIgnore]
    public bool PermissionsRunFlowSpecified
    {
      get => this.permissionsRunFlowFieldSpecified;
      set => this.permissionsRunFlowFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsRunReports
    {
      get => this.permissionsRunReportsField;
      set => this.permissionsRunReportsField = value;
    }

    [XmlIgnore]
    public bool PermissionsRunReportsSpecified
    {
      get => this.permissionsRunReportsFieldSpecified;
      set => this.permissionsRunReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsSalesConsole
    {
      get => this.permissionsSalesConsoleField;
      set => this.permissionsSalesConsoleField = value;
    }

    [XmlIgnore]
    public bool PermissionsSalesConsoleSpecified
    {
      get => this.permissionsSalesConsoleFieldSpecified;
      set => this.permissionsSalesConsoleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsScheduleJob
    {
      get => this.permissionsScheduleJobField;
      set => this.permissionsScheduleJobField = value;
    }

    [XmlIgnore]
    public bool PermissionsScheduleJobSpecified
    {
      get => this.permissionsScheduleJobFieldSpecified;
      set => this.permissionsScheduleJobFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsScheduleReports
    {
      get => this.permissionsScheduleReportsField;
      set => this.permissionsScheduleReportsField = value;
    }

    [XmlIgnore]
    public bool PermissionsScheduleReportsSpecified
    {
      get => this.permissionsScheduleReportsFieldSpecified;
      set => this.permissionsScheduleReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsSelectFilesFromSalesforce
    {
      get => this.permissionsSelectFilesFromSalesforceField;
      set => this.permissionsSelectFilesFromSalesforceField = value;
    }

    [XmlIgnore]
    public bool PermissionsSelectFilesFromSalesforceSpecified
    {
      get => this.permissionsSelectFilesFromSalesforceFieldSpecified;
      set => this.permissionsSelectFilesFromSalesforceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsSendAnnouncementEmails
    {
      get => this.permissionsSendAnnouncementEmailsField;
      set => this.permissionsSendAnnouncementEmailsField = value;
    }

    [XmlIgnore]
    public bool PermissionsSendAnnouncementEmailsSpecified
    {
      get => this.permissionsSendAnnouncementEmailsFieldSpecified;
      set => this.permissionsSendAnnouncementEmailsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsSendSitRequests
    {
      get => this.permissionsSendSitRequestsField;
      set => this.permissionsSendSitRequestsField = value;
    }

    [XmlIgnore]
    public bool PermissionsSendSitRequestsSpecified
    {
      get => this.permissionsSendSitRequestsFieldSpecified;
      set => this.permissionsSendSitRequestsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsShareInternalArticles
    {
      get => this.permissionsShareInternalArticlesField;
      set => this.permissionsShareInternalArticlesField = value;
    }

    [XmlIgnore]
    public bool PermissionsShareInternalArticlesSpecified
    {
      get => this.permissionsShareInternalArticlesFieldSpecified;
      set => this.permissionsShareInternalArticlesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsShowCompanyNameAsUserBadge
    {
      get => this.permissionsShowCompanyNameAsUserBadgeField;
      set => this.permissionsShowCompanyNameAsUserBadgeField = value;
    }

    [XmlIgnore]
    public bool PermissionsShowCompanyNameAsUserBadgeSpecified
    {
      get => this.permissionsShowCompanyNameAsUserBadgeFieldSpecified;
      set => this.permissionsShowCompanyNameAsUserBadgeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsSolutionImport
    {
      get => this.permissionsSolutionImportField;
      set => this.permissionsSolutionImportField = value;
    }

    [XmlIgnore]
    public bool PermissionsSolutionImportSpecified
    {
      get => this.permissionsSolutionImportFieldSpecified;
      set => this.permissionsSolutionImportFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsSubmitMacrosAllowed
    {
      get => this.permissionsSubmitMacrosAllowedField;
      set => this.permissionsSubmitMacrosAllowedField = value;
    }

    [XmlIgnore]
    public bool PermissionsSubmitMacrosAllowedSpecified
    {
      get => this.permissionsSubmitMacrosAllowedFieldSpecified;
      set => this.permissionsSubmitMacrosAllowedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsSubscribeToLightningReports
    {
      get => this.permissionsSubscribeToLightningReportsField;
      set => this.permissionsSubscribeToLightningReportsField = value;
    }

    [XmlIgnore]
    public bool PermissionsSubscribeToLightningReportsSpecified
    {
      get => this.permissionsSubscribeToLightningReportsFieldSpecified;
      set => this.permissionsSubscribeToLightningReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsTransferAnyCase
    {
      get => this.permissionsTransferAnyCaseField;
      set => this.permissionsTransferAnyCaseField = value;
    }

    [XmlIgnore]
    public bool PermissionsTransferAnyCaseSpecified
    {
      get => this.permissionsTransferAnyCaseFieldSpecified;
      set => this.permissionsTransferAnyCaseFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsTransferAnyEntity
    {
      get => this.permissionsTransferAnyEntityField;
      set => this.permissionsTransferAnyEntityField = value;
    }

    [XmlIgnore]
    public bool PermissionsTransferAnyEntitySpecified
    {
      get => this.permissionsTransferAnyEntityFieldSpecified;
      set => this.permissionsTransferAnyEntityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsTransferAnyLead
    {
      get => this.permissionsTransferAnyLeadField;
      set => this.permissionsTransferAnyLeadField = value;
    }

    [XmlIgnore]
    public bool PermissionsTransferAnyLeadSpecified
    {
      get => this.permissionsTransferAnyLeadFieldSpecified;
      set => this.permissionsTransferAnyLeadFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsTwoFactorApi
    {
      get => this.permissionsTwoFactorApiField;
      set => this.permissionsTwoFactorApiField = value;
    }

    [XmlIgnore]
    public bool PermissionsTwoFactorApiSpecified
    {
      get => this.permissionsTwoFactorApiFieldSpecified;
      set => this.permissionsTwoFactorApiFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsUseTeamReassignWizards
    {
      get => this.permissionsUseTeamReassignWizardsField;
      set => this.permissionsUseTeamReassignWizardsField = value;
    }

    [XmlIgnore]
    public bool PermissionsUseTeamReassignWizardsSpecified
    {
      get => this.permissionsUseTeamReassignWizardsFieldSpecified;
      set => this.permissionsUseTeamReassignWizardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewAllActivities
    {
      get => this.permissionsViewAllActivitiesField;
      set => this.permissionsViewAllActivitiesField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewAllActivitiesSpecified
    {
      get => this.permissionsViewAllActivitiesFieldSpecified;
      set => this.permissionsViewAllActivitiesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewAllData
    {
      get => this.permissionsViewAllDataField;
      set => this.permissionsViewAllDataField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewAllDataSpecified
    {
      get => this.permissionsViewAllDataFieldSpecified;
      set => this.permissionsViewAllDataFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewAllUsers
    {
      get => this.permissionsViewAllUsersField;
      set => this.permissionsViewAllUsersField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewAllUsersSpecified
    {
      get => this.permissionsViewAllUsersFieldSpecified;
      set => this.permissionsViewAllUsersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewContent
    {
      get => this.permissionsViewContentField;
      set => this.permissionsViewContentField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewContentSpecified
    {
      get => this.permissionsViewContentFieldSpecified;
      set => this.permissionsViewContentFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewDataAssessment
    {
      get => this.permissionsViewDataAssessmentField;
      set => this.permissionsViewDataAssessmentField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewDataAssessmentSpecified
    {
      get => this.permissionsViewDataAssessmentFieldSpecified;
      set => this.permissionsViewDataAssessmentFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewDataCategories
    {
      get => this.permissionsViewDataCategoriesField;
      set => this.permissionsViewDataCategoriesField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewDataCategoriesSpecified
    {
      get => this.permissionsViewDataCategoriesFieldSpecified;
      set => this.permissionsViewDataCategoriesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewEncryptedData
    {
      get => this.permissionsViewEncryptedDataField;
      set => this.permissionsViewEncryptedDataField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewEncryptedDataSpecified
    {
      get => this.permissionsViewEncryptedDataFieldSpecified;
      set => this.permissionsViewEncryptedDataFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewEventLogFiles
    {
      get => this.permissionsViewEventLogFilesField;
      set => this.permissionsViewEventLogFilesField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewEventLogFilesSpecified
    {
      get => this.permissionsViewEventLogFilesFieldSpecified;
      set => this.permissionsViewEventLogFilesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewHealthCheck
    {
      get => this.permissionsViewHealthCheckField;
      set => this.permissionsViewHealthCheckField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewHealthCheckSpecified
    {
      get => this.permissionsViewHealthCheckFieldSpecified;
      set => this.permissionsViewHealthCheckFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewHelpLink
    {
      get => this.permissionsViewHelpLinkField;
      set => this.permissionsViewHelpLinkField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewHelpLinkSpecified
    {
      get => this.permissionsViewHelpLinkFieldSpecified;
      set => this.permissionsViewHelpLinkFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewMyTeamsDashboards
    {
      get => this.permissionsViewMyTeamsDashboardsField;
      set => this.permissionsViewMyTeamsDashboardsField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewMyTeamsDashboardsSpecified
    {
      get => this.permissionsViewMyTeamsDashboardsFieldSpecified;
      set => this.permissionsViewMyTeamsDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewPublicDashboards
    {
      get => this.permissionsViewPublicDashboardsField;
      set => this.permissionsViewPublicDashboardsField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewPublicDashboardsSpecified
    {
      get => this.permissionsViewPublicDashboardsFieldSpecified;
      set => this.permissionsViewPublicDashboardsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewPublicReports
    {
      get => this.permissionsViewPublicReportsField;
      set => this.permissionsViewPublicReportsField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewPublicReportsSpecified
    {
      get => this.permissionsViewPublicReportsFieldSpecified;
      set => this.permissionsViewPublicReportsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewSetup
    {
      get => this.permissionsViewSetupField;
      set => this.permissionsViewSetupField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewSetupSpecified
    {
      get => this.permissionsViewSetupFieldSpecified;
      set => this.permissionsViewSetupFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsWorkCalibrationUser
    {
      get => this.permissionsWorkCalibrationUserField;
      set => this.permissionsWorkCalibrationUserField = value;
    }

    [XmlIgnore]
    public bool PermissionsWorkCalibrationUserSpecified
    {
      get => this.permissionsWorkCalibrationUserFieldSpecified;
      set => this.permissionsWorkCalibrationUserFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsWorkDotComUserPerm
    {
      get => this.permissionsWorkDotComUserPermField;
      set => this.permissionsWorkDotComUserPermField = value;
    }

    [XmlIgnore]
    public bool PermissionsWorkDotComUserPermSpecified
    {
      get => this.permissionsWorkDotComUserPermFieldSpecified;
      set => this.permissionsWorkDotComUserPermFieldSpecified = value;
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
    public UserLicense UserLicense
    {
      get => this.userLicenseField;
      set => this.userLicenseField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserLicenseId
    {
      get => this.userLicenseIdField;
      set => this.userLicenseIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserType
    {
      get => this.userTypeField;
      set => this.userTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Users
    {
      get => this.usersField;
      set => this.usersField = value;
    }
  }
}
