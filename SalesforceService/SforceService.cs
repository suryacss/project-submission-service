// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SforceService
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using ProjectSubmissionsSvcLib.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib.SalesforceService
{
  [GeneratedCode("System.Web.Services", "4.6.1099.0")]
  [WebServiceBinding(Name = "SoapBinding", Namespace = "urn:enterprise.soap.sforce.com")]
  [XmlInclude(typeof (ApiFault))]
  [XmlInclude(typeof (NameObjectValuePair))]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class SforceService : SoapHttpClientProtocol
  {
    private LoginScopeHeader loginScopeHeaderValueField;
    private SendOrPostCallback loginOperationCompleted;
    private SessionHeader sessionHeaderValueField;
    private PackageVersionHeader packageVersionHeaderValueField;
    private LocaleOptions localeOptionsValueField;
    private LimitInfoHeader limitInfoHeaderValueField;
    private SendOrPostCallback describeSObjectOperationCompleted;
    private SendOrPostCallback describeSObjectsOperationCompleted;
    private SendOrPostCallback describeGlobalOperationCompleted;
    private SendOrPostCallback describeDataCategoryGroupsOperationCompleted;
    private SendOrPostCallback describeDataCategoryGroupStructuresOperationCompleted;
    private SendOrPostCallback describeKnowledgeSettingsOperationCompleted;
    private SendOrPostCallback describeAppMenuOperationCompleted;
    private SendOrPostCallback describeGlobalThemeOperationCompleted;
    private SendOrPostCallback describeThemeOperationCompleted;
    private SendOrPostCallback describeLayoutOperationCompleted;
    private SendOrPostCallback describeSoftphoneLayoutOperationCompleted;
    private SendOrPostCallback describeSearchLayoutsOperationCompleted;
    private SendOrPostCallback describeSearchableEntitiesOperationCompleted;
    private SendOrPostCallback describeSearchScopeOrderOperationCompleted;
    private SendOrPostCallback describeCompactLayoutsOperationCompleted;
    private SendOrPostCallback describePathAssistantsOperationCompleted;
    private SendOrPostCallback describeApprovalLayoutOperationCompleted;
    private SendOrPostCallback describeSoqlListViewsOperationCompleted;
    private MruHeader mruHeaderValueField;
    private SendOrPostCallback executeListViewOperationCompleted;
    private SendOrPostCallback describeSObjectListViewsOperationCompleted;
    private SendOrPostCallback describeTabsOperationCompleted;
    private SendOrPostCallback describeAllTabsOperationCompleted;
    private SendOrPostCallback describePrimaryCompactLayoutsOperationCompleted;
    private AssignmentRuleHeader assignmentRuleHeaderValueField;
    private AllowFieldTruncationHeader allowFieldTruncationHeaderValueField;
    private DisableFeedTrackingHeader disableFeedTrackingHeaderValueField;
    private StreamingEnabledHeader streamingEnabledHeaderValueField;
    private AllOrNoneHeader allOrNoneHeaderValueField;
    private DuplicateRuleHeader duplicateRuleHeaderValueField;
    private DebuggingHeader debuggingHeaderValueField;
    private EmailHeader emailHeaderValueField;
    private DebuggingInfo debuggingInfoValueField;
    private SendOrPostCallback createOperationCompleted;
    private OwnerChangeOptions ownerChangeOptionsValueField;
    private SendOrPostCallback updateOperationCompleted;
    private SendOrPostCallback upsertOperationCompleted;
    private SendOrPostCallback mergeOperationCompleted;
    private UserTerritoryDeleteHeader userTerritoryDeleteHeaderValueField;
    private SendOrPostCallback deleteOperationCompleted;
    private SendOrPostCallback undeleteOperationCompleted;
    private SendOrPostCallback emptyRecycleBinOperationCompleted;
    private QueryOptions queryOptionsValueField;
    private SendOrPostCallback retrieveOperationCompleted;
    private SendOrPostCallback processOperationCompleted;
    private SendOrPostCallback convertLeadOperationCompleted;
    private SendOrPostCallback logoutOperationCompleted;
    private SendOrPostCallback invalidateSessionsOperationCompleted;
    private SendOrPostCallback getDeletedOperationCompleted;
    private SendOrPostCallback getUpdatedOperationCompleted;
    private SendOrPostCallback queryOperationCompleted;
    private SendOrPostCallback queryAllOperationCompleted;
    private SendOrPostCallback queryMoreOperationCompleted;
    private SendOrPostCallback searchOperationCompleted;
    private SendOrPostCallback getServerTimestampOperationCompleted;
    private SendOrPostCallback setPasswordOperationCompleted;
    private SendOrPostCallback resetPasswordOperationCompleted;
    private SendOrPostCallback getUserInfoOperationCompleted;
    private SendOrPostCallback sendEmailMessageOperationCompleted;
    private SendOrPostCallback sendEmailOperationCompleted;
    private SendOrPostCallback renderEmailTemplateOperationCompleted;
    private SendOrPostCallback performQuickActionsOperationCompleted;
    private SendOrPostCallback describeQuickActionsOperationCompleted;
    private SendOrPostCallback describeAvailableQuickActionsOperationCompleted;
    private SendOrPostCallback retrieveQuickActionTemplatesOperationCompleted;
    private SendOrPostCallback describeVisualForceOperationCompleted;
    private SendOrPostCallback findDuplicatesOperationCompleted;
    private SendOrPostCallback describeNounsOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public SforceService()
    {
      this.Url = Settings.Default.ProjectSubmissionsSvcLib_SalesforceService_SforceService;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    public LoginScopeHeader LoginScopeHeaderValue
    {
      get => this.loginScopeHeaderValueField;
      set => this.loginScopeHeaderValueField = value;
    }

    public SessionHeader SessionHeaderValue
    {
      get => this.sessionHeaderValueField;
      set => this.sessionHeaderValueField = value;
    }

    public PackageVersionHeader PackageVersionHeaderValue
    {
      get => this.packageVersionHeaderValueField;
      set => this.packageVersionHeaderValueField = value;
    }

    public LocaleOptions LocaleOptionsValue
    {
      get => this.localeOptionsValueField;
      set => this.localeOptionsValueField = value;
    }

    public LimitInfoHeader LimitInfoHeaderValue
    {
      get => this.limitInfoHeaderValueField;
      set => this.limitInfoHeaderValueField = value;
    }

    public MruHeader MruHeaderValue
    {
      get => this.mruHeaderValueField;
      set => this.mruHeaderValueField = value;
    }

    public AssignmentRuleHeader AssignmentRuleHeaderValue
    {
      get => this.assignmentRuleHeaderValueField;
      set => this.assignmentRuleHeaderValueField = value;
    }

    public AllowFieldTruncationHeader AllowFieldTruncationHeaderValue
    {
      get => this.allowFieldTruncationHeaderValueField;
      set => this.allowFieldTruncationHeaderValueField = value;
    }

    public DisableFeedTrackingHeader DisableFeedTrackingHeaderValue
    {
      get => this.disableFeedTrackingHeaderValueField;
      set => this.disableFeedTrackingHeaderValueField = value;
    }

    public StreamingEnabledHeader StreamingEnabledHeaderValue
    {
      get => this.streamingEnabledHeaderValueField;
      set => this.streamingEnabledHeaderValueField = value;
    }

    public AllOrNoneHeader AllOrNoneHeaderValue
    {
      get => this.allOrNoneHeaderValueField;
      set => this.allOrNoneHeaderValueField = value;
    }

    public DuplicateRuleHeader DuplicateRuleHeaderValue
    {
      get => this.duplicateRuleHeaderValueField;
      set => this.duplicateRuleHeaderValueField = value;
    }

    public DebuggingHeader DebuggingHeaderValue
    {
      get => this.debuggingHeaderValueField;
      set => this.debuggingHeaderValueField = value;
    }

    public EmailHeader EmailHeaderValue
    {
      get => this.emailHeaderValueField;
      set => this.emailHeaderValueField = value;
    }

    public DebuggingInfo DebuggingInfoValue
    {
      get => this.debuggingInfoValueField;
      set => this.debuggingInfoValueField = value;
    }

    public OwnerChangeOptions OwnerChangeOptionsValue
    {
      get => this.ownerChangeOptionsValueField;
      set => this.ownerChangeOptionsValueField = value;
    }

    public UserTerritoryDeleteHeader UserTerritoryDeleteHeaderValue
    {
      get => this.userTerritoryDeleteHeaderValueField;
      set => this.userTerritoryDeleteHeaderValueField = value;
    }

    public QueryOptions QueryOptionsValue
    {
      get => this.queryOptionsValueField;
      set => this.queryOptionsValueField = value;
    }

    public new string Url
    {
      get => base.Url;
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get => base.UseDefaultCredentials;
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    public event loginCompletedEventHandler loginCompleted;

    public event describeSObjectCompletedEventHandler describeSObjectCompleted;

    public event describeSObjectsCompletedEventHandler describeSObjectsCompleted;

    public event describeGlobalCompletedEventHandler describeGlobalCompleted;

    public event describeDataCategoryGroupsCompletedEventHandler describeDataCategoryGroupsCompleted;

    public event describeDataCategoryGroupStructuresCompletedEventHandler describeDataCategoryGroupStructuresCompleted;

    public event describeKnowledgeSettingsCompletedEventHandler describeKnowledgeSettingsCompleted;

    public event describeAppMenuCompletedEventHandler describeAppMenuCompleted;

    public event describeGlobalThemeCompletedEventHandler describeGlobalThemeCompleted;

    public event describeThemeCompletedEventHandler describeThemeCompleted;

    public event describeLayoutCompletedEventHandler describeLayoutCompleted;

    public event describeSoftphoneLayoutCompletedEventHandler describeSoftphoneLayoutCompleted;

    public event describeSearchLayoutsCompletedEventHandler describeSearchLayoutsCompleted;

    public event describeSearchableEntitiesCompletedEventHandler describeSearchableEntitiesCompleted;

    public event describeSearchScopeOrderCompletedEventHandler describeSearchScopeOrderCompleted;

    public event describeCompactLayoutsCompletedEventHandler describeCompactLayoutsCompleted;

    public event describePathAssistantsCompletedEventHandler describePathAssistantsCompleted;

    public event describeApprovalLayoutCompletedEventHandler describeApprovalLayoutCompleted;

    public event describeSoqlListViewsCompletedEventHandler describeSoqlListViewsCompleted;

    public event executeListViewCompletedEventHandler executeListViewCompleted;

    public event describeSObjectListViewsCompletedEventHandler describeSObjectListViewsCompleted;

    public event describeTabsCompletedEventHandler describeTabsCompleted;

    public event describeAllTabsCompletedEventHandler describeAllTabsCompleted;

    public event describePrimaryCompactLayoutsCompletedEventHandler describePrimaryCompactLayoutsCompleted;

    public event createCompletedEventHandler createCompleted;

    public event updateCompletedEventHandler updateCompleted;

    public event upsertCompletedEventHandler upsertCompleted;

    public event mergeCompletedEventHandler mergeCompleted;

    public event deleteCompletedEventHandler deleteCompleted;

    public event undeleteCompletedEventHandler undeleteCompleted;

    public event emptyRecycleBinCompletedEventHandler emptyRecycleBinCompleted;

    public event retrieveCompletedEventHandler retrieveCompleted;

    public event processCompletedEventHandler processCompleted;

    public event convertLeadCompletedEventHandler convertLeadCompleted;

    public event logoutCompletedEventHandler logoutCompleted;

    public event invalidateSessionsCompletedEventHandler invalidateSessionsCompleted;

    public event getDeletedCompletedEventHandler getDeletedCompleted;

    public event getUpdatedCompletedEventHandler getUpdatedCompleted;

    public event queryCompletedEventHandler queryCompleted;

    public event queryAllCompletedEventHandler queryAllCompleted;

    public event queryMoreCompletedEventHandler queryMoreCompleted;

    public event searchCompletedEventHandler searchCompleted;

    public event getServerTimestampCompletedEventHandler getServerTimestampCompleted;

    public event setPasswordCompletedEventHandler setPasswordCompleted;

    public event resetPasswordCompletedEventHandler resetPasswordCompleted;

    public event getUserInfoCompletedEventHandler getUserInfoCompleted;

    public event sendEmailMessageCompletedEventHandler sendEmailMessageCompleted;

    public event sendEmailCompletedEventHandler sendEmailCompleted;

    public event renderEmailTemplateCompletedEventHandler renderEmailTemplateCompleted;

    public event performQuickActionsCompletedEventHandler performQuickActionsCompleted;

    public event describeQuickActionsCompletedEventHandler describeQuickActionsCompleted;

    public event describeAvailableQuickActionsCompletedEventHandler describeAvailableQuickActionsCompleted;

    public event retrieveQuickActionTemplatesCompletedEventHandler retrieveQuickActionTemplatesCompleted;

    public event describeVisualForceCompletedEventHandler describeVisualForceCompleted;

    public event findDuplicatesCompletedEventHandler findDuplicatesCompleted;

    public event describeNounsCompletedEventHandler describeNounsCompleted;

    [SoapHeader("LoginScopeHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result")]
    public LoginResult login(string username, string password)
    {
      return (LoginResult) this.Invoke(nameof (login), new object[2]
      {
        (object) username,
        (object) password
      })[0];
    }

    public void loginAsync(string username, string password)
    {
      this.loginAsync(username, password, (object) null);
    }

    public void loginAsync(string username, string password, object userState)
    {
      if (this.loginOperationCompleted == null)
        this.loginOperationCompleted = new SendOrPostCallback(this.OnloginOperationCompleted);
      this.InvokeAsync("login", new object[2]
      {
        (object) username,
        (object) password
      }, this.loginOperationCompleted, userState);
    }

    private void OnloginOperationCompleted(object arg)
    {
      if (this.loginCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.loginCompleted((object) this, new loginCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeSObjectResult describeSObject(string sObjectType)
    {
      return (DescribeSObjectResult) this.Invoke(nameof (describeSObject), new object[1]
      {
        (object) sObjectType
      })[0];
    }

    public void describeSObjectAsync(string sObjectType)
    {
      this.describeSObjectAsync(sObjectType, (object) null);
    }

    public void describeSObjectAsync(string sObjectType, object userState)
    {
      if (this.describeSObjectOperationCompleted == null)
        this.describeSObjectOperationCompleted = new SendOrPostCallback(this.OndescribeSObjectOperationCompleted);
      this.InvokeAsync("describeSObject", new object[1]
      {
        (object) sObjectType
      }, this.describeSObjectOperationCompleted, userState);
    }

    private void OndescribeSObjectOperationCompleted(object arg)
    {
      if (this.describeSObjectCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeSObjectCompleted((object) this, new describeSObjectCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("SessionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeSObjectResult[] describeSObjects([XmlElement("sObjectType")] string[] sObjectType)
    {
      return (DescribeSObjectResult[]) this.Invoke(nameof (describeSObjects), new object[1]
      {
        (object) sObjectType
      })[0];
    }

    public void describeSObjectsAsync(string[] sObjectType)
    {
      this.describeSObjectsAsync(sObjectType, (object) null);
    }

    public void describeSObjectsAsync(string[] sObjectType, object userState)
    {
      if (this.describeSObjectsOperationCompleted == null)
        this.describeSObjectsOperationCompleted = new SendOrPostCallback(this.OndescribeSObjectsOperationCompleted);
      this.InvokeAsync("describeSObjects", new object[1]
      {
        (object) sObjectType
      }, this.describeSObjectsOperationCompleted, userState);
    }

    private void OndescribeSObjectsOperationCompleted(object arg)
    {
      if (this.describeSObjectsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeSObjectsCompleted((object) this, new describeSObjectsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public DescribeGlobalResult describeGlobal()
    {
      return (DescribeGlobalResult) this.Invoke(nameof (describeGlobal), new object[0])[0];
    }

    public void describeGlobalAsync() => this.describeGlobalAsync((object) null);

    public void describeGlobalAsync(object userState)
    {
      if (this.describeGlobalOperationCompleted == null)
        this.describeGlobalOperationCompleted = new SendOrPostCallback(this.OndescribeGlobalOperationCompleted);
      this.InvokeAsync("describeGlobal", new object[0], this.describeGlobalOperationCompleted, userState);
    }

    private void OndescribeGlobalOperationCompleted(object arg)
    {
      if (this.describeGlobalCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeGlobalCompleted((object) this, new describeGlobalCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public DescribeDataCategoryGroupResult[] describeDataCategoryGroups([XmlElement("sObjectType")] string[] sObjectType)
    {
      return (DescribeDataCategoryGroupResult[]) this.Invoke(nameof (describeDataCategoryGroups), new object[1]
      {
        (object) sObjectType
      })[0];
    }

    public void describeDataCategoryGroupsAsync(string[] sObjectType)
    {
      this.describeDataCategoryGroupsAsync(sObjectType, (object) null);
    }

    public void describeDataCategoryGroupsAsync(string[] sObjectType, object userState)
    {
      if (this.describeDataCategoryGroupsOperationCompleted == null)
        this.describeDataCategoryGroupsOperationCompleted = new SendOrPostCallback(this.OndescribeDataCategoryGroupsOperationCompleted);
      this.InvokeAsync("describeDataCategoryGroups", new object[1]
      {
        (object) sObjectType
      }, this.describeDataCategoryGroupsOperationCompleted, userState);
    }

    private void OndescribeDataCategoryGroupsOperationCompleted(object arg)
    {
      if (this.describeDataCategoryGroupsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeDataCategoryGroupsCompleted((object) this, new describeDataCategoryGroupsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public DescribeDataCategoryGroupStructureResult[] describeDataCategoryGroupStructures(
      [XmlElement("pairs")] DataCategoryGroupSobjectTypePair[] pairs,
      bool topCategoriesOnly)
    {
      return (DescribeDataCategoryGroupStructureResult[]) this.Invoke(nameof (describeDataCategoryGroupStructures), new object[2]
      {
        (object) pairs,
        (object) topCategoriesOnly
      })[0];
    }

    public void describeDataCategoryGroupStructuresAsync(
      DataCategoryGroupSobjectTypePair[] pairs,
      bool topCategoriesOnly)
    {
      this.describeDataCategoryGroupStructuresAsync(pairs, topCategoriesOnly, (object) null);
    }

    public void describeDataCategoryGroupStructuresAsync(
      DataCategoryGroupSobjectTypePair[] pairs,
      bool topCategoriesOnly,
      object userState)
    {
      if (this.describeDataCategoryGroupStructuresOperationCompleted == null)
        this.describeDataCategoryGroupStructuresOperationCompleted = new SendOrPostCallback(this.OndescribeDataCategoryGroupStructuresOperationCompleted);
      this.InvokeAsync("describeDataCategoryGroupStructures", new object[2]
      {
        (object) pairs,
        (object) topCategoriesOnly
      }, this.describeDataCategoryGroupStructuresOperationCompleted, userState);
    }

    private void OndescribeDataCategoryGroupStructuresOperationCompleted(object arg)
    {
      if (this.describeDataCategoryGroupStructuresCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeDataCategoryGroupStructuresCompleted((object) this, new describeDataCategoryGroupStructuresCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result")]
    public KnowledgeSettings describeKnowledgeSettings()
    {
      return (KnowledgeSettings) this.Invoke(nameof (describeKnowledgeSettings), new object[0])[0];
    }

    public void describeKnowledgeSettingsAsync()
    {
      this.describeKnowledgeSettingsAsync((object) null);
    }

    public void describeKnowledgeSettingsAsync(object userState)
    {
      if (this.describeKnowledgeSettingsOperationCompleted == null)
        this.describeKnowledgeSettingsOperationCompleted = new SendOrPostCallback(this.OndescribeKnowledgeSettingsOperationCompleted);
      this.InvokeAsync("describeKnowledgeSettings", new object[0], this.describeKnowledgeSettingsOperationCompleted, userState);
    }

    private void OndescribeKnowledgeSettingsOperationCompleted(object arg)
    {
      if (this.describeKnowledgeSettingsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeKnowledgeSettingsCompleted((object) this, new describeKnowledgeSettingsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlArray("result", IsNullable = true)]
    [return: XmlArrayItem("appMenuItems", IsNullable = false)]
    public DescribeAppMenuItem[] describeAppMenu(AppMenuType appMenuType, [XmlElement(IsNullable = true)] string networkId)
    {
      return (DescribeAppMenuItem[]) this.Invoke(nameof (describeAppMenu), new object[2]
      {
        (object) appMenuType,
        (object) networkId
      })[0];
    }

    public void describeAppMenuAsync(AppMenuType appMenuType, string networkId)
    {
      this.describeAppMenuAsync(appMenuType, networkId, (object) null);
    }

    public void describeAppMenuAsync(AppMenuType appMenuType, string networkId, object userState)
    {
      if (this.describeAppMenuOperationCompleted == null)
        this.describeAppMenuOperationCompleted = new SendOrPostCallback(this.OndescribeAppMenuOperationCompleted);
      this.InvokeAsync("describeAppMenu", new object[2]
      {
        (object) appMenuType,
        (object) networkId
      }, this.describeAppMenuOperationCompleted, userState);
    }

    private void OndescribeAppMenuOperationCompleted(object arg)
    {
      if (this.describeAppMenuCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeAppMenuCompleted((object) this, new describeAppMenuCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("PackageVersionHeaderValue")]
    [return: XmlElement("result")]
    public DescribeGlobalTheme describeGlobalTheme()
    {
      return (DescribeGlobalTheme) this.Invoke(nameof (describeGlobalTheme), new object[0])[0];
    }

    public void describeGlobalThemeAsync() => this.describeGlobalThemeAsync((object) null);

    public void describeGlobalThemeAsync(object userState)
    {
      if (this.describeGlobalThemeOperationCompleted == null)
        this.describeGlobalThemeOperationCompleted = new SendOrPostCallback(this.OndescribeGlobalThemeOperationCompleted);
      this.InvokeAsync("describeGlobalTheme", new object[0], this.describeGlobalThemeOperationCompleted, userState);
    }

    private void OndescribeGlobalThemeOperationCompleted(object arg)
    {
      if (this.describeGlobalThemeCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeGlobalThemeCompleted((object) this, new describeGlobalThemeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArrayItem("themeItems", IsNullable = false)]
    [return: XmlArray("result")]
    public DescribeThemeItem[] describeTheme([XmlElement("sobjectType")] string[] sobjectType)
    {
      return (DescribeThemeItem[]) this.Invoke(nameof (describeTheme), new object[1]
      {
        (object) sobjectType
      })[0];
    }

    public void describeThemeAsync(string[] sobjectType)
    {
      this.describeThemeAsync(sobjectType, (object) null);
    }

    public void describeThemeAsync(string[] sobjectType, object userState)
    {
      if (this.describeThemeOperationCompleted == null)
        this.describeThemeOperationCompleted = new SendOrPostCallback(this.OndescribeThemeOperationCompleted);
      this.InvokeAsync("describeTheme", new object[1]
      {
        (object) sobjectType
      }, this.describeThemeOperationCompleted, userState);
    }

    private void OndescribeThemeOperationCompleted(object arg)
    {
      if (this.describeThemeCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeThemeCompleted((object) this, new describeThemeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeLayoutResult describeLayout(
      string sObjectType,
      [XmlElement(IsNullable = true)] string layoutName,
      [XmlElement("recordTypeIds")] string[] recordTypeIds)
    {
      return (DescribeLayoutResult) this.Invoke(nameof (describeLayout), new object[3]
      {
        (object) sObjectType,
        (object) layoutName,
        (object) recordTypeIds
      })[0];
    }

    public void describeLayoutAsync(string sObjectType, string layoutName, string[] recordTypeIds)
    {
      this.describeLayoutAsync(sObjectType, layoutName, recordTypeIds, (object) null);
    }

    public void describeLayoutAsync(
      string sObjectType,
      string layoutName,
      string[] recordTypeIds,
      object userState)
    {
      if (this.describeLayoutOperationCompleted == null)
        this.describeLayoutOperationCompleted = new SendOrPostCallback(this.OndescribeLayoutOperationCompleted);
      this.InvokeAsync("describeLayout", new object[3]
      {
        (object) sObjectType,
        (object) layoutName,
        (object) recordTypeIds
      }, this.describeLayoutOperationCompleted, userState);
    }

    private void OndescribeLayoutOperationCompleted(object arg)
    {
      if (this.describeLayoutCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeLayoutCompleted((object) this, new describeLayoutCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeSoftphoneLayoutResult describeSoftphoneLayout()
    {
      return (DescribeSoftphoneLayoutResult) this.Invoke(nameof (describeSoftphoneLayout), new object[0])[0];
    }

    public void describeSoftphoneLayoutAsync() => this.describeSoftphoneLayoutAsync((object) null);

    public void describeSoftphoneLayoutAsync(object userState)
    {
      if (this.describeSoftphoneLayoutOperationCompleted == null)
        this.describeSoftphoneLayoutOperationCompleted = new SendOrPostCallback(this.OndescribeSoftphoneLayoutOperationCompleted);
      this.InvokeAsync("describeSoftphoneLayout", new object[0], this.describeSoftphoneLayoutOperationCompleted, userState);
    }

    private void OndescribeSoftphoneLayoutOperationCompleted(object arg)
    {
      if (this.describeSoftphoneLayoutCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeSoftphoneLayoutCompleted((object) this, new describeSoftphoneLayoutCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("PackageVersionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeSearchLayoutResult[] describeSearchLayouts([XmlElement("sObjectType")] string[] sObjectType)
    {
      return (DescribeSearchLayoutResult[]) this.Invoke(nameof (describeSearchLayouts), new object[1]
      {
        (object) sObjectType
      })[0];
    }

    public void describeSearchLayoutsAsync(string[] sObjectType)
    {
      this.describeSearchLayoutsAsync(sObjectType, (object) null);
    }

    public void describeSearchLayoutsAsync(string[] sObjectType, object userState)
    {
      if (this.describeSearchLayoutsOperationCompleted == null)
        this.describeSearchLayoutsOperationCompleted = new SendOrPostCallback(this.OndescribeSearchLayoutsOperationCompleted);
      this.InvokeAsync("describeSearchLayouts", new object[1]
      {
        (object) sObjectType
      }, this.describeSearchLayoutsOperationCompleted, userState);
    }

    private void OndescribeSearchLayoutsOperationCompleted(object arg)
    {
      if (this.describeSearchLayoutsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeSearchLayoutsCompleted((object) this, new describeSearchLayoutsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public DescribeSearchableEntityResult[] describeSearchableEntities(
      bool includeOnlyEntitiesWithTabs)
    {
      return (DescribeSearchableEntityResult[]) this.Invoke(nameof (describeSearchableEntities), new object[1]
      {
        (object) includeOnlyEntitiesWithTabs
      })[0];
    }

    public void describeSearchableEntitiesAsync(bool includeOnlyEntitiesWithTabs)
    {
      this.describeSearchableEntitiesAsync(includeOnlyEntitiesWithTabs, (object) null);
    }

    public void describeSearchableEntitiesAsync(bool includeOnlyEntitiesWithTabs, object userState)
    {
      if (this.describeSearchableEntitiesOperationCompleted == null)
        this.describeSearchableEntitiesOperationCompleted = new SendOrPostCallback(this.OndescribeSearchableEntitiesOperationCompleted);
      this.InvokeAsync("describeSearchableEntities", new object[1]
      {
        (object) includeOnlyEntitiesWithTabs
      }, this.describeSearchableEntitiesOperationCompleted, userState);
    }

    private void OndescribeSearchableEntitiesOperationCompleted(object arg)
    {
      if (this.describeSearchableEntitiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeSearchableEntitiesCompleted((object) this, new describeSearchableEntitiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public DescribeSearchScopeOrderResult[] describeSearchScopeOrder()
    {
      return (DescribeSearchScopeOrderResult[]) this.Invoke(nameof (describeSearchScopeOrder), new object[0])[0];
    }

    public void describeSearchScopeOrderAsync()
    {
      this.describeSearchScopeOrderAsync((object) null);
    }

    public void describeSearchScopeOrderAsync(object userState)
    {
      if (this.describeSearchScopeOrderOperationCompleted == null)
        this.describeSearchScopeOrderOperationCompleted = new SendOrPostCallback(this.OndescribeSearchScopeOrderOperationCompleted);
      this.InvokeAsync("describeSearchScopeOrder", new object[0], this.describeSearchScopeOrderOperationCompleted, userState);
    }

    private void OndescribeSearchScopeOrderOperationCompleted(object arg)
    {
      if (this.describeSearchScopeOrderCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeSearchScopeOrderCompleted((object) this, new describeSearchScopeOrderCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeCompactLayoutsResult describeCompactLayouts(
      string sObjectType,
      [XmlElement("recordTypeIds")] string[] recordTypeIds)
    {
      return (DescribeCompactLayoutsResult) this.Invoke(nameof (describeCompactLayouts), new object[2]
      {
        (object) sObjectType,
        (object) recordTypeIds
      })[0];
    }

    public void describeCompactLayoutsAsync(string sObjectType, string[] recordTypeIds)
    {
      this.describeCompactLayoutsAsync(sObjectType, recordTypeIds, (object) null);
    }

    public void describeCompactLayoutsAsync(
      string sObjectType,
      string[] recordTypeIds,
      object userState)
    {
      if (this.describeCompactLayoutsOperationCompleted == null)
        this.describeCompactLayoutsOperationCompleted = new SendOrPostCallback(this.OndescribeCompactLayoutsOperationCompleted);
      this.InvokeAsync("describeCompactLayouts", new object[2]
      {
        (object) sObjectType,
        (object) recordTypeIds
      }, this.describeCompactLayoutsOperationCompleted, userState);
    }

    private void OndescribeCompactLayoutsOperationCompleted(object arg)
    {
      if (this.describeCompactLayoutsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeCompactLayoutsCompleted((object) this, new describeCompactLayoutsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArrayItem("pathAssistants", IsNullable = false)]
    [return: XmlArray("result", IsNullable = true)]
    public DescribePathAssistant[] describePathAssistants(
      string sObjectType,
      [XmlElement(IsNullable = true)] string picklistValue,
      [XmlElement("recordTypeIds")] string[] recordTypeIds)
    {
      return (DescribePathAssistant[]) this.Invoke(nameof (describePathAssistants), new object[3]
      {
        (object) sObjectType,
        (object) picklistValue,
        (object) recordTypeIds
      })[0];
    }

    public void describePathAssistantsAsync(
      string sObjectType,
      string picklistValue,
      string[] recordTypeIds)
    {
      this.describePathAssistantsAsync(sObjectType, picklistValue, recordTypeIds, (object) null);
    }

    public void describePathAssistantsAsync(
      string sObjectType,
      string picklistValue,
      string[] recordTypeIds,
      object userState)
    {
      if (this.describePathAssistantsOperationCompleted == null)
        this.describePathAssistantsOperationCompleted = new SendOrPostCallback(this.OndescribePathAssistantsOperationCompleted);
      this.InvokeAsync("describePathAssistants", new object[3]
      {
        (object) sObjectType,
        (object) picklistValue,
        (object) recordTypeIds
      }, this.describePathAssistantsOperationCompleted, userState);
    }

    private void OndescribePathAssistantsOperationCompleted(object arg)
    {
      if (this.describePathAssistantsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describePathAssistantsCompleted((object) this, new describePathAssistantsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArrayItem("approvalLayouts", IsNullable = false)]
    [return: XmlArray("result", IsNullable = true)]
    public DescribeApprovalLayout[] describeApprovalLayout(
      string sObjectType,
      [XmlElement("approvalProcessNames")] string[] approvalProcessNames)
    {
      return (DescribeApprovalLayout[]) this.Invoke(nameof (describeApprovalLayout), new object[2]
      {
        (object) sObjectType,
        (object) approvalProcessNames
      })[0];
    }

    public void describeApprovalLayoutAsync(string sObjectType, string[] approvalProcessNames)
    {
      this.describeApprovalLayoutAsync(sObjectType, approvalProcessNames, (object) null);
    }

    public void describeApprovalLayoutAsync(
      string sObjectType,
      string[] approvalProcessNames,
      object userState)
    {
      if (this.describeApprovalLayoutOperationCompleted == null)
        this.describeApprovalLayoutOperationCompleted = new SendOrPostCallback(this.OndescribeApprovalLayoutOperationCompleted);
      this.InvokeAsync("describeApprovalLayout", new object[2]
      {
        (object) sObjectType,
        (object) approvalProcessNames
      }, this.describeApprovalLayoutOperationCompleted, userState);
    }

    private void OndescribeApprovalLayoutOperationCompleted(object arg)
    {
      if (this.describeApprovalLayoutCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeApprovalLayoutCompleted((object) this, new describeApprovalLayoutCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("result")]
    [return: XmlArrayItem("describeSoqlListViews", IsNullable = false)]
    public DescribeSoqlListView[] describeSoqlListViews([XmlArrayItem("listViewParams", IsNullable = false)] DescribeSoqlListViewParams[] request)
    {
      return (DescribeSoqlListView[]) this.Invoke(nameof (describeSoqlListViews), new object[1]
      {
        (object) request
      })[0];
    }

    public void describeSoqlListViewsAsync(DescribeSoqlListViewParams[] request)
    {
      this.describeSoqlListViewsAsync(request, (object) null);
    }

    public void describeSoqlListViewsAsync(DescribeSoqlListViewParams[] request, object userState)
    {
      if (this.describeSoqlListViewsOperationCompleted == null)
        this.describeSoqlListViewsOperationCompleted = new SendOrPostCallback(this.OndescribeSoqlListViewsOperationCompleted);
      this.InvokeAsync("describeSoqlListViews", new object[1]
      {
        (object) request
      }, this.describeSoqlListViewsOperationCompleted, userState);
    }

    private void OndescribeSoqlListViewsOperationCompleted(object arg)
    {
      if (this.describeSoqlListViewsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeSoqlListViewsCompleted((object) this, new describeSoqlListViewsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("MruHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public ExecuteListViewResult executeListView(ExecuteListViewRequest request)
    {
      return (ExecuteListViewResult) this.Invoke(nameof (executeListView), new object[1]
      {
        (object) request
      })[0];
    }

    public void executeListViewAsync(ExecuteListViewRequest request)
    {
      this.executeListViewAsync(request, (object) null);
    }

    public void executeListViewAsync(ExecuteListViewRequest request, object userState)
    {
      if (this.executeListViewOperationCompleted == null)
        this.executeListViewOperationCompleted = new SendOrPostCallback(this.OnexecuteListViewOperationCompleted);
      this.InvokeAsync("executeListView", new object[1]
      {
        (object) request
      }, this.executeListViewOperationCompleted, userState);
    }

    private void OnexecuteListViewOperationCompleted(object arg)
    {
      if (this.executeListViewCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.executeListViewCompleted((object) this, new executeListViewCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArrayItem("describeSoqlListViews", IsNullable = false)]
    [return: XmlArray("result")]
    public DescribeSoqlListView[] describeSObjectListViews(
      string sObjectType,
      bool recentsOnly,
      listViewIsSoqlCompatible isSoqlCompatible,
      int limit,
      int offset)
    {
      return (DescribeSoqlListView[]) this.Invoke(nameof (describeSObjectListViews), new object[5]
      {
        (object) sObjectType,
        (object) recentsOnly,
        (object) isSoqlCompatible,
        (object) limit,
        (object) offset
      })[0];
    }

    public void describeSObjectListViewsAsync(
      string sObjectType,
      bool recentsOnly,
      listViewIsSoqlCompatible isSoqlCompatible,
      int limit,
      int offset)
    {
      this.describeSObjectListViewsAsync(sObjectType, recentsOnly, isSoqlCompatible, limit, offset, (object) null);
    }

    public void describeSObjectListViewsAsync(
      string sObjectType,
      bool recentsOnly,
      listViewIsSoqlCompatible isSoqlCompatible,
      int limit,
      int offset,
      object userState)
    {
      if (this.describeSObjectListViewsOperationCompleted == null)
        this.describeSObjectListViewsOperationCompleted = new SendOrPostCallback(this.OndescribeSObjectListViewsOperationCompleted);
      this.InvokeAsync("describeSObjectListViews", new object[5]
      {
        (object) sObjectType,
        (object) recentsOnly,
        (object) isSoqlCompatible,
        (object) limit,
        (object) offset
      }, this.describeSObjectListViewsOperationCompleted, userState);
    }

    private void OndescribeSObjectListViewsOperationCompleted(object arg)
    {
      if (this.describeSObjectListViewsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeSObjectListViewsCompleted((object) this, new describeSObjectListViewsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeTabSetResult[] describeTabs()
    {
      return (DescribeTabSetResult[]) this.Invoke(nameof (describeTabs), new object[0])[0];
    }

    public void describeTabsAsync() => this.describeTabsAsync((object) null);

    public void describeTabsAsync(object userState)
    {
      if (this.describeTabsOperationCompleted == null)
        this.describeTabsOperationCompleted = new SendOrPostCallback(this.OndescribeTabsOperationCompleted);
      this.InvokeAsync("describeTabs", new object[0], this.describeTabsOperationCompleted, userState);
    }

    private void OndescribeTabsOperationCompleted(object arg)
    {
      if (this.describeTabsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeTabsCompleted((object) this, new describeTabsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeTab[] describeAllTabs()
    {
      return (DescribeTab[]) this.Invoke(nameof (describeAllTabs), new object[0])[0];
    }

    public void describeAllTabsAsync() => this.describeAllTabsAsync((object) null);

    public void describeAllTabsAsync(object userState)
    {
      if (this.describeAllTabsOperationCompleted == null)
        this.describeAllTabsOperationCompleted = new SendOrPostCallback(this.OndescribeAllTabsOperationCompleted);
      this.InvokeAsync("describeAllTabs", new object[0], this.describeAllTabsOperationCompleted, userState);
    }

    private void OndescribeAllTabsOperationCompleted(object arg)
    {
      if (this.describeAllTabsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeAllTabsCompleted((object) this, new describeAllTabsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public DescribeCompactLayout[] describePrimaryCompactLayouts([XmlElement("sObjectTypes")] string[] sObjectTypes)
    {
      return (DescribeCompactLayout[]) this.Invoke(nameof (describePrimaryCompactLayouts), new object[1]
      {
        (object) sObjectTypes
      })[0];
    }

    public void describePrimaryCompactLayoutsAsync(string[] sObjectTypes)
    {
      this.describePrimaryCompactLayoutsAsync(sObjectTypes, (object) null);
    }

    public void describePrimaryCompactLayoutsAsync(string[] sObjectTypes, object userState)
    {
      if (this.describePrimaryCompactLayoutsOperationCompleted == null)
        this.describePrimaryCompactLayoutsOperationCompleted = new SendOrPostCallback(this.OndescribePrimaryCompactLayoutsOperationCompleted);
      this.InvokeAsync("describePrimaryCompactLayouts", new object[1]
      {
        (object) sObjectTypes
      }, this.describePrimaryCompactLayoutsOperationCompleted, userState);
    }

    private void OndescribePrimaryCompactLayoutsOperationCompleted(object arg)
    {
      if (this.describePrimaryCompactLayoutsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describePrimaryCompactLayoutsCompleted((object) this, new describePrimaryCompactLayoutsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("DebuggingInfoValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("EmailHeaderValue")]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("AllOrNoneHeaderValue")]
    [SoapHeader("AssignmentRuleHeaderValue")]
    [SoapHeader("DebuggingHeaderValue")]
    [SoapHeader("MruHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public SaveResult[] create([XmlElement("sObjects")] sObject[] sObjects)
    {
      return (SaveResult[]) this.Invoke(nameof (create), new object[1]
      {
        (object) sObjects
      })[0];
    }

    public void createAsync(sObject[] sObjects) => this.createAsync(sObjects, (object) null);

    public void createAsync(sObject[] sObjects, object userState)
    {
      if (this.createOperationCompleted == null)
        this.createOperationCompleted = new SendOrPostCallback(this.OncreateOperationCompleted);
      this.InvokeAsync("create", new object[1]
      {
        (object) sObjects
      }, this.createOperationCompleted, userState);
    }

    private void OncreateOperationCompleted(object arg)
    {
      if (this.createCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.createCompleted((object) this, new createCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("DebuggingHeaderValue")]
    [SoapHeader("DebuggingInfoValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("AssignmentRuleHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("AllOrNoneHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("EmailHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [SoapHeader("OwnerChangeOptionsValue")]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("MruHeaderValue")]
    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [return: XmlElement("result")]
    public SaveResult[] update([XmlElement("sObjects")] sObject[] sObjects)
    {
      return (SaveResult[]) this.Invoke(nameof (update), new object[1]
      {
        (object) sObjects
      })[0];
    }

    public void updateAsync(sObject[] sObjects) => this.updateAsync(sObjects, (object) null);

    public void updateAsync(sObject[] sObjects, object userState)
    {
      if (this.updateOperationCompleted == null)
        this.updateOperationCompleted = new SendOrPostCallback(this.OnupdateOperationCompleted);
      this.InvokeAsync("update", new object[1]
      {
        (object) sObjects
      }, this.updateOperationCompleted, userState);
    }

    private void OnupdateOperationCompleted(object arg)
    {
      if (this.updateCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.updateCompleted((object) this, new updateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("DebuggingHeaderValue")]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("EmailHeaderValue")]
    [SoapHeader("AssignmentRuleHeaderValue")]
    [SoapHeader("OwnerChangeOptionsValue")]
    [SoapHeader("MruHeaderValue")]
    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("DebuggingInfoValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("AllOrNoneHeaderValue")]
    [return: XmlElement("result")]
    public UpsertResult[] upsert(string externalIDFieldName, [XmlElement("sObjects")] sObject[] sObjects)
    {
      return (UpsertResult[]) this.Invoke(nameof (upsert), new object[2]
      {
        (object) externalIDFieldName,
        (object) sObjects
      })[0];
    }

    public void upsertAsync(string externalIDFieldName, sObject[] sObjects)
    {
      this.upsertAsync(externalIDFieldName, sObjects, (object) null);
    }

    public void upsertAsync(string externalIDFieldName, sObject[] sObjects, object userState)
    {
      if (this.upsertOperationCompleted == null)
        this.upsertOperationCompleted = new SendOrPostCallback(this.OnupsertOperationCompleted);
      this.InvokeAsync("upsert", new object[2]
      {
        (object) externalIDFieldName,
        (object) sObjects
      }, this.upsertOperationCompleted, userState);
    }

    private void OnupsertOperationCompleted(object arg)
    {
      if (this.upsertCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.upsertCompleted((object) this, new upsertCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [SoapHeader("EmailHeaderValue")]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("DebuggingInfoValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("AssignmentRuleHeaderValue")]
    [SoapHeader("DebuggingHeaderValue")]
    [SoapHeader("MruHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public MergeResult[] merge([XmlElement("request")] MergeRequest[] request)
    {
      return (MergeResult[]) this.Invoke(nameof (merge), new object[1]
      {
        (object) request
      })[0];
    }

    public void mergeAsync(MergeRequest[] request) => this.mergeAsync(request, (object) null);

    public void mergeAsync(MergeRequest[] request, object userState)
    {
      if (this.mergeOperationCompleted == null)
        this.mergeOperationCompleted = new SendOrPostCallback(this.OnmergeOperationCompleted);
      this.InvokeAsync("merge", new object[1]
      {
        (object) request
      }, this.mergeOperationCompleted, userState);
    }

    private void OnmergeOperationCompleted(object arg)
    {
      if (this.mergeCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.mergeCompleted((object) this, new mergeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("DebuggingInfoValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("EmailHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("DebuggingHeaderValue")]
    [SoapHeader("UserTerritoryDeleteHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("AllOrNoneHeaderValue")]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result")]
    public DeleteResult[] delete([XmlElement("ids")] string[] ids)
    {
      return (DeleteResult[]) this.Invoke(nameof (delete), new object[1]
      {
        (object) ids
      })[0];
    }

    public void deleteAsync(string[] ids) => this.deleteAsync(ids, (object) null);

    public void deleteAsync(string[] ids, object userState)
    {
      if (this.deleteOperationCompleted == null)
        this.deleteOperationCompleted = new SendOrPostCallback(this.OndeleteOperationCompleted);
      this.InvokeAsync("delete", new object[1]
      {
        (object) ids
      }, this.deleteOperationCompleted, userState);
    }

    private void OndeleteOperationCompleted(object arg)
    {
      if (this.deleteCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.deleteCompleted((object) this, new deleteCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("AllOrNoneHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [SoapHeader("DebuggingInfoValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("DebuggingHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public UndeleteResult[] undelete([XmlElement("ids")] string[] ids)
    {
      return (UndeleteResult[]) this.Invoke(nameof (undelete), new object[1]
      {
        (object) ids
      })[0];
    }

    public void undeleteAsync(string[] ids) => this.undeleteAsync(ids, (object) null);

    public void undeleteAsync(string[] ids, object userState)
    {
      if (this.undeleteOperationCompleted == null)
        this.undeleteOperationCompleted = new SendOrPostCallback(this.OnundeleteOperationCompleted);
      this.InvokeAsync("undelete", new object[1]
      {
        (object) ids
      }, this.undeleteOperationCompleted, userState);
    }

    private void OnundeleteOperationCompleted(object arg)
    {
      if (this.undeleteCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.undeleteCompleted((object) this, new undeleteCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("SessionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public EmptyRecycleBinResult[] emptyRecycleBin([XmlElement("ids")] string[] ids)
    {
      return (EmptyRecycleBinResult[]) this.Invoke(nameof (emptyRecycleBin), new object[1]
      {
        (object) ids
      })[0];
    }

    public void emptyRecycleBinAsync(string[] ids) => this.emptyRecycleBinAsync(ids, (object) null);

    public void emptyRecycleBinAsync(string[] ids, object userState)
    {
      if (this.emptyRecycleBinOperationCompleted == null)
        this.emptyRecycleBinOperationCompleted = new SendOrPostCallback(this.OnemptyRecycleBinOperationCompleted);
      this.InvokeAsync("emptyRecycleBin", new object[1]
      {
        (object) ids
      }, this.emptyRecycleBinOperationCompleted, userState);
    }

    private void OnemptyRecycleBinOperationCompleted(object arg)
    {
      if (this.emptyRecycleBinCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.emptyRecycleBinCompleted((object) this, new emptyRecycleBinCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("MruHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("QueryOptionsValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result", IsNullable = true)]
    public sObject[] retrieve(string fieldList, string sObjectType, [XmlElement("ids")] string[] ids)
    {
      return (sObject[]) this.Invoke(nameof (retrieve), new object[3]
      {
        (object) fieldList,
        (object) sObjectType,
        (object) ids
      })[0];
    }

    public void retrieveAsync(string fieldList, string sObjectType, string[] ids)
    {
      this.retrieveAsync(fieldList, sObjectType, ids, (object) null);
    }

    public void retrieveAsync(
      string fieldList,
      string sObjectType,
      string[] ids,
      object userState)
    {
      if (this.retrieveOperationCompleted == null)
        this.retrieveOperationCompleted = new SendOrPostCallback(this.OnretrieveOperationCompleted);
      this.InvokeAsync("retrieve", new object[3]
      {
        (object) fieldList,
        (object) sObjectType,
        (object) ids
      }, this.retrieveOperationCompleted, userState);
    }

    private void OnretrieveOperationCompleted(object arg)
    {
      if (this.retrieveCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.retrieveCompleted((object) this, new retrieveCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("DebuggingInfoValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("DebuggingHeaderValue")]
    [return: XmlElement("result")]
    public ProcessResult[] process([XmlElement("actions")] ProcessRequest[] actions)
    {
      return (ProcessResult[]) this.Invoke(nameof (process), new object[1]
      {
        (object) actions
      })[0];
    }

    public void processAsync(ProcessRequest[] actions) => this.processAsync(actions, (object) null);

    public void processAsync(ProcessRequest[] actions, object userState)
    {
      if (this.processOperationCompleted == null)
        this.processOperationCompleted = new SendOrPostCallback(this.OnprocessOperationCompleted);
      this.InvokeAsync("process", new object[1]
      {
        (object) actions
      }, this.processOperationCompleted, userState);
    }

    private void OnprocessOperationCompleted(object arg)
    {
      if (this.processCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.processCompleted((object) this, new processCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("DebuggingInfoValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("DebuggingHeaderValue")]
    [return: XmlElement("result")]
    public LeadConvertResult[] convertLead([XmlElement("leadConverts")] LeadConvert[] leadConverts)
    {
      return (LeadConvertResult[]) this.Invoke(nameof (convertLead), new object[1]
      {
        (object) leadConverts
      })[0];
    }

    public void convertLeadAsync(LeadConvert[] leadConverts)
    {
      this.convertLeadAsync(leadConverts, (object) null);
    }

    public void convertLeadAsync(LeadConvert[] leadConverts, object userState)
    {
      if (this.convertLeadOperationCompleted == null)
        this.convertLeadOperationCompleted = new SendOrPostCallback(this.OnconvertLeadOperationCompleted);
      this.InvokeAsync("convertLead", new object[1]
      {
        (object) leadConverts
      }, this.convertLeadOperationCompleted, userState);
    }

    private void OnconvertLeadOperationCompleted(object arg)
    {
      if (this.convertLeadCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.convertLeadCompleted((object) this, new convertLeadCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    public void logout() => this.Invoke(nameof (logout), new object[0]);

    public void logoutAsync() => this.logoutAsync((object) null);

    public void logoutAsync(object userState)
    {
      if (this.logoutOperationCompleted == null)
        this.logoutOperationCompleted = new SendOrPostCallback(this.OnlogoutOperationCompleted);
      this.InvokeAsync("logout", new object[0], this.logoutOperationCompleted, userState);
    }

    private void OnlogoutOperationCompleted(object arg)
    {
      if (this.logoutCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.logoutCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public InvalidateSessionsResult[] invalidateSessions([XmlElement("sessionIds")] string[] sessionIds)
    {
      return (InvalidateSessionsResult[]) this.Invoke(nameof (invalidateSessions), new object[1]
      {
        (object) sessionIds
      })[0];
    }

    public void invalidateSessionsAsync(string[] sessionIds)
    {
      this.invalidateSessionsAsync(sessionIds, (object) null);
    }

    public void invalidateSessionsAsync(string[] sessionIds, object userState)
    {
      if (this.invalidateSessionsOperationCompleted == null)
        this.invalidateSessionsOperationCompleted = new SendOrPostCallback(this.OninvalidateSessionsOperationCompleted);
      this.InvokeAsync("invalidateSessions", new object[1]
      {
        (object) sessionIds
      }, this.invalidateSessionsOperationCompleted, userState);
    }

    private void OninvalidateSessionsOperationCompleted(object arg)
    {
      if (this.invalidateSessionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.invalidateSessionsCompleted((object) this, new invalidateSessionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("SessionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public GetDeletedResult getDeleted(string sObjectType, DateTime startDate, DateTime endDate)
    {
      return (GetDeletedResult) this.Invoke(nameof (getDeleted), new object[3]
      {
        (object) sObjectType,
        (object) startDate,
        (object) endDate
      })[0];
    }

    public void getDeletedAsync(string sObjectType, DateTime startDate, DateTime endDate)
    {
      this.getDeletedAsync(sObjectType, startDate, endDate, (object) null);
    }

    public void getDeletedAsync(
      string sObjectType,
      DateTime startDate,
      DateTime endDate,
      object userState)
    {
      if (this.getDeletedOperationCompleted == null)
        this.getDeletedOperationCompleted = new SendOrPostCallback(this.OngetDeletedOperationCompleted);
      this.InvokeAsync("getDeleted", new object[3]
      {
        (object) sObjectType,
        (object) startDate,
        (object) endDate
      }, this.getDeletedOperationCompleted, userState);
    }

    private void OngetDeletedOperationCompleted(object arg)
    {
      if (this.getDeletedCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getDeletedCompleted((object) this, new getDeletedCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public GetUpdatedResult getUpdated(string sObjectType, DateTime startDate, DateTime endDate)
    {
      return (GetUpdatedResult) this.Invoke(nameof (getUpdated), new object[3]
      {
        (object) sObjectType,
        (object) startDate,
        (object) endDate
      })[0];
    }

    public void getUpdatedAsync(string sObjectType, DateTime startDate, DateTime endDate)
    {
      this.getUpdatedAsync(sObjectType, startDate, endDate, (object) null);
    }

    public void getUpdatedAsync(
      string sObjectType,
      DateTime startDate,
      DateTime endDate,
      object userState)
    {
      if (this.getUpdatedOperationCompleted == null)
        this.getUpdatedOperationCompleted = new SendOrPostCallback(this.OngetUpdatedOperationCompleted);
      this.InvokeAsync("getUpdated", new object[3]
      {
        (object) sObjectType,
        (object) startDate,
        (object) endDate
      }, this.getUpdatedOperationCompleted, userState);
    }

    private void OngetUpdatedOperationCompleted(object arg)
    {
      if (this.getUpdatedCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getUpdatedCompleted((object) this, new getUpdatedCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("QueryOptionsValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("MruHeaderValue")]
    [return: XmlElement("result")]
    public QueryResult query(string queryString)
    {
      return (QueryResult) this.Invoke(nameof (query), new object[1]
      {
        (object) queryString
      })[0];
    }

    public void queryAsync(string queryString) => this.queryAsync(queryString, (object) null);

    public void queryAsync(string queryString, object userState)
    {
      if (this.queryOperationCompleted == null)
        this.queryOperationCompleted = new SendOrPostCallback(this.OnqueryOperationCompleted);
      this.InvokeAsync("query", new object[1]
      {
        (object) queryString
      }, this.queryOperationCompleted, userState);
    }

    private void OnqueryOperationCompleted(object arg)
    {
      if (this.queryCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.queryCompleted((object) this, new queryCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("QueryOptionsValue")]
    [return: XmlElement("result")]
    public QueryResult queryAll(string queryString)
    {
      return (QueryResult) this.Invoke(nameof (queryAll), new object[1]
      {
        (object) queryString
      })[0];
    }

    public void queryAllAsync(string queryString) => this.queryAllAsync(queryString, (object) null);

    public void queryAllAsync(string queryString, object userState)
    {
      if (this.queryAllOperationCompleted == null)
        this.queryAllOperationCompleted = new SendOrPostCallback(this.OnqueryAllOperationCompleted);
      this.InvokeAsync("queryAll", new object[1]
      {
        (object) queryString
      }, this.queryAllOperationCompleted, userState);
    }

    private void OnqueryAllOperationCompleted(object arg)
    {
      if (this.queryAllCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.queryAllCompleted((object) this, new queryAllCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("SessionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("QueryOptionsValue")]
    [return: XmlElement("result")]
    public QueryResult queryMore(string queryLocator)
    {
      return (QueryResult) this.Invoke(nameof (queryMore), new object[1]
      {
        (object) queryLocator
      })[0];
    }

    public void queryMoreAsync(string queryLocator)
    {
      this.queryMoreAsync(queryLocator, (object) null);
    }

    public void queryMoreAsync(string queryLocator, object userState)
    {
      if (this.queryMoreOperationCompleted == null)
        this.queryMoreOperationCompleted = new SendOrPostCallback(this.OnqueryMoreOperationCompleted);
      this.InvokeAsync("queryMore", new object[1]
      {
        (object) queryLocator
      }, this.queryMoreOperationCompleted, userState);
    }

    private void OnqueryMoreOperationCompleted(object arg)
    {
      if (this.queryMoreCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.queryMoreCompleted((object) this, new queryMoreCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public SearchResult search(string searchString)
    {
      return (SearchResult) this.Invoke(nameof (search), new object[1]
      {
        (object) searchString
      })[0];
    }

    public void searchAsync(string searchString) => this.searchAsync(searchString, (object) null);

    public void searchAsync(string searchString, object userState)
    {
      if (this.searchOperationCompleted == null)
        this.searchOperationCompleted = new SendOrPostCallback(this.OnsearchOperationCompleted);
      this.InvokeAsync("search", new object[1]
      {
        (object) searchString
      }, this.searchOperationCompleted, userState);
    }

    private void OnsearchOperationCompleted(object arg)
    {
      if (this.searchCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.searchCompleted((object) this, new searchCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public GetServerTimestampResult getServerTimestamp()
    {
      return (GetServerTimestampResult) this.Invoke(nameof (getServerTimestamp), new object[0])[0];
    }

    public void getServerTimestampAsync() => this.getServerTimestampAsync((object) null);

    public void getServerTimestampAsync(object userState)
    {
      if (this.getServerTimestampOperationCompleted == null)
        this.getServerTimestampOperationCompleted = new SendOrPostCallback(this.OngetServerTimestampOperationCompleted);
      this.InvokeAsync("getServerTimestamp", new object[0], this.getServerTimestampOperationCompleted, userState);
    }

    private void OngetServerTimestampOperationCompleted(object arg)
    {
      if (this.getServerTimestampCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getServerTimestampCompleted((object) this, new getServerTimestampCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public SetPasswordResult setPassword(string userId, string password)
    {
      return (SetPasswordResult) this.Invoke(nameof (setPassword), new object[2]
      {
        (object) userId,
        (object) password
      })[0];
    }

    public void setPasswordAsync(string userId, string password)
    {
      this.setPasswordAsync(userId, password, (object) null);
    }

    public void setPasswordAsync(string userId, string password, object userState)
    {
      if (this.setPasswordOperationCompleted == null)
        this.setPasswordOperationCompleted = new SendOrPostCallback(this.OnsetPasswordOperationCompleted);
      this.InvokeAsync("setPassword", new object[2]
      {
        (object) userId,
        (object) password
      }, this.setPasswordOperationCompleted, userState);
    }

    private void OnsetPasswordOperationCompleted(object arg)
    {
      if (this.setPasswordCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.setPasswordCompleted((object) this, new setPasswordCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("EmailHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public ResetPasswordResult resetPassword(string userId)
    {
      return (ResetPasswordResult) this.Invoke(nameof (resetPassword), new object[1]
      {
        (object) userId
      })[0];
    }

    public void resetPasswordAsync(string userId) => this.resetPasswordAsync(userId, (object) null);

    public void resetPasswordAsync(string userId, object userState)
    {
      if (this.resetPasswordOperationCompleted == null)
        this.resetPasswordOperationCompleted = new SendOrPostCallback(this.OnresetPasswordOperationCompleted);
      this.InvokeAsync("resetPassword", new object[1]
      {
        (object) userId
      }, this.resetPasswordOperationCompleted, userState);
    }

    private void OnresetPasswordOperationCompleted(object arg)
    {
      if (this.resetPasswordCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.resetPasswordCompleted((object) this, new resetPasswordCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [return: XmlElement("result")]
    public GetUserInfoResult getUserInfo()
    {
      return (GetUserInfoResult) this.Invoke(nameof (getUserInfo), new object[0])[0];
    }

    public void getUserInfoAsync() => this.getUserInfoAsync((object) null);

    public void getUserInfoAsync(object userState)
    {
      if (this.getUserInfoOperationCompleted == null)
        this.getUserInfoOperationCompleted = new SendOrPostCallback(this.OngetUserInfoOperationCompleted);
      this.InvokeAsync("getUserInfo", new object[0], this.getUserInfoOperationCompleted, userState);
    }

    private void OngetUserInfoOperationCompleted(object arg)
    {
      if (this.getUserInfoCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getUserInfoCompleted((object) this, new getUserInfoCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result")]
    public SendEmailResult[] sendEmailMessage([XmlElement("ids")] string[] ids)
    {
      return (SendEmailResult[]) this.Invoke(nameof (sendEmailMessage), new object[1]
      {
        (object) ids
      })[0];
    }

    public void sendEmailMessageAsync(string[] ids)
    {
      this.sendEmailMessageAsync(ids, (object) null);
    }

    public void sendEmailMessageAsync(string[] ids, object userState)
    {
      if (this.sendEmailMessageOperationCompleted == null)
        this.sendEmailMessageOperationCompleted = new SendOrPostCallback(this.OnsendEmailMessageOperationCompleted);
      this.InvokeAsync("sendEmailMessage", new object[1]
      {
        (object) ids
      }, this.sendEmailMessageOperationCompleted, userState);
    }

    private void OnsendEmailMessageOperationCompleted(object arg)
    {
      if (this.sendEmailMessageCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.sendEmailMessageCompleted((object) this, new sendEmailMessageCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result")]
    public SendEmailResult[] sendEmail([XmlElement("messages")] Email[] messages)
    {
      return (SendEmailResult[]) this.Invoke(nameof (sendEmail), new object[1]
      {
        (object) messages
      })[0];
    }

    public void sendEmailAsync(Email[] messages) => this.sendEmailAsync(messages, (object) null);

    public void sendEmailAsync(Email[] messages, object userState)
    {
      if (this.sendEmailOperationCompleted == null)
        this.sendEmailOperationCompleted = new SendOrPostCallback(this.OnsendEmailOperationCompleted);
      this.InvokeAsync("sendEmail", new object[1]
      {
        (object) messages
      }, this.sendEmailOperationCompleted, userState);
    }

    private void OnsendEmailOperationCompleted(object arg)
    {
      if (this.sendEmailCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.sendEmailCompleted((object) this, new sendEmailCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public RenderEmailTemplateResult[] renderEmailTemplate(
      [XmlElement("renderRequests")] RenderEmailTemplateRequest[] renderRequests)
    {
      return (RenderEmailTemplateResult[]) this.Invoke(nameof (renderEmailTemplate), new object[1]
      {
        (object) renderRequests
      })[0];
    }

    public void renderEmailTemplateAsync(RenderEmailTemplateRequest[] renderRequests)
    {
      this.renderEmailTemplateAsync(renderRequests, (object) null);
    }

    public void renderEmailTemplateAsync(
      RenderEmailTemplateRequest[] renderRequests,
      object userState)
    {
      if (this.renderEmailTemplateOperationCompleted == null)
        this.renderEmailTemplateOperationCompleted = new SendOrPostCallback(this.OnrenderEmailTemplateOperationCompleted);
      this.InvokeAsync("renderEmailTemplate", new object[1]
      {
        (object) renderRequests
      }, this.renderEmailTemplateOperationCompleted, userState);
    }

    private void OnrenderEmailTemplateOperationCompleted(object arg)
    {
      if (this.renderEmailTemplateCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.renderEmailTemplateCompleted((object) this, new renderEmailTemplateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("AllOrNoneHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("DisableFeedTrackingHeaderValue")]
    [SoapHeader("MruHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("EmailHeaderValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("DebuggingHeaderValue")]
    [SoapHeader("OwnerChangeOptionsValue")]
    [SoapHeader("AssignmentRuleHeaderValue")]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [SoapHeader("AllowFieldTruncationHeaderValue")]
    [SoapHeader("StreamingEnabledHeaderValue")]
    [return: XmlElement("result")]
    public PerformQuickActionResult[] performQuickActions([XmlElement("quickActions")] PerformQuickActionRequest[] quickActions)
    {
      return (PerformQuickActionResult[]) this.Invoke(nameof (performQuickActions), new object[1]
      {
        (object) quickActions
      })[0];
    }

    public void performQuickActionsAsync(PerformQuickActionRequest[] quickActions)
    {
      this.performQuickActionsAsync(quickActions, (object) null);
    }

    public void performQuickActionsAsync(PerformQuickActionRequest[] quickActions, object userState)
    {
      if (this.performQuickActionsOperationCompleted == null)
        this.performQuickActionsOperationCompleted = new SendOrPostCallback(this.OnperformQuickActionsOperationCompleted);
      this.InvokeAsync("performQuickActions", new object[1]
      {
        (object) quickActions
      }, this.performQuickActionsOperationCompleted, userState);
    }

    private void OnperformQuickActionsOperationCompleted(object arg)
    {
      if (this.performQuickActionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.performQuickActionsCompleted((object) this, new performQuickActionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LocaleOptionsValue")]
    [return: XmlElement("result")]
    public DescribeQuickActionResult[] describeQuickActions([XmlElement("quickActions")] string[] quickActions)
    {
      return (DescribeQuickActionResult[]) this.Invoke(nameof (describeQuickActions), new object[1]
      {
        (object) quickActions
      })[0];
    }

    public void describeQuickActionsAsync(string[] quickActions)
    {
      this.describeQuickActionsAsync(quickActions, (object) null);
    }

    public void describeQuickActionsAsync(string[] quickActions, object userState)
    {
      if (this.describeQuickActionsOperationCompleted == null)
        this.describeQuickActionsOperationCompleted = new SendOrPostCallback(this.OndescribeQuickActionsOperationCompleted);
      this.InvokeAsync("describeQuickActions", new object[1]
      {
        (object) quickActions
      }, this.describeQuickActionsOperationCompleted, userState);
    }

    private void OndescribeQuickActionsOperationCompleted(object arg)
    {
      if (this.describeQuickActionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeQuickActionsCompleted((object) this, new describeQuickActionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("LocaleOptionsValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result")]
    public DescribeAvailableQuickActionResult[] describeAvailableQuickActions([XmlElement(IsNullable = true)] string contextType)
    {
      return (DescribeAvailableQuickActionResult[]) this.Invoke(nameof (describeAvailableQuickActions), new object[1]
      {
        (object) contextType
      })[0];
    }

    public void describeAvailableQuickActionsAsync(string contextType)
    {
      this.describeAvailableQuickActionsAsync(contextType, (object) null);
    }

    public void describeAvailableQuickActionsAsync(string contextType, object userState)
    {
      if (this.describeAvailableQuickActionsOperationCompleted == null)
        this.describeAvailableQuickActionsOperationCompleted = new SendOrPostCallback(this.OndescribeAvailableQuickActionsOperationCompleted);
      this.InvokeAsync("describeAvailableQuickActions", new object[1]
      {
        (object) contextType
      }, this.describeAvailableQuickActionsOperationCompleted, userState);
    }

    private void OndescribeAvailableQuickActionsOperationCompleted(object arg)
    {
      if (this.describeAvailableQuickActionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeAvailableQuickActionsCompleted((object) this, new describeAvailableQuickActionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LocaleOptionsValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("result")]
    public QuickActionTemplateResult[] retrieveQuickActionTemplates(
      [XmlElement("quickActionNames")] string[] quickActionNames,
      [XmlElement(IsNullable = true)] string contextId)
    {
      return (QuickActionTemplateResult[]) this.Invoke(nameof (retrieveQuickActionTemplates), new object[2]
      {
        (object) quickActionNames,
        (object) contextId
      })[0];
    }

    public void retrieveQuickActionTemplatesAsync(string[] quickActionNames, string contextId)
    {
      this.retrieveQuickActionTemplatesAsync(quickActionNames, contextId, (object) null);
    }

    public void retrieveQuickActionTemplatesAsync(
      string[] quickActionNames,
      string contextId,
      object userState)
    {
      if (this.retrieveQuickActionTemplatesOperationCompleted == null)
        this.retrieveQuickActionTemplatesOperationCompleted = new SendOrPostCallback(this.OnretrieveQuickActionTemplatesOperationCompleted);
      this.InvokeAsync("retrieveQuickActionTemplates", new object[2]
      {
        (object) quickActionNames,
        (object) contextId
      }, this.retrieveQuickActionTemplatesOperationCompleted, userState);
    }

    private void OnretrieveQuickActionTemplatesOperationCompleted(object arg)
    {
      if (this.retrieveQuickActionTemplatesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.retrieveQuickActionTemplatesCompleted((object) this, new retrieveQuickActionTemplatesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result")]
    public DescribeVisualForceResult describeVisualForce(
      bool includeAllDetails,
      [XmlElement(IsNullable = true)] string namespacePrefix)
    {
      return (DescribeVisualForceResult) this.Invoke(nameof (describeVisualForce), new object[2]
      {
        (object) includeAllDetails,
        (object) namespacePrefix
      })[0];
    }

    public void describeVisualForceAsync(bool includeAllDetails, string namespacePrefix)
    {
      this.describeVisualForceAsync(includeAllDetails, namespacePrefix, (object) null);
    }

    public void describeVisualForceAsync(
      bool includeAllDetails,
      string namespacePrefix,
      object userState)
    {
      if (this.describeVisualForceOperationCompleted == null)
        this.describeVisualForceOperationCompleted = new SendOrPostCallback(this.OndescribeVisualForceOperationCompleted);
      this.InvokeAsync("describeVisualForce", new object[2]
      {
        (object) includeAllDetails,
        (object) namespacePrefix
      }, this.describeVisualForceOperationCompleted, userState);
    }

    private void OndescribeVisualForceOperationCompleted(object arg)
    {
      if (this.describeVisualForceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeVisualForceCompleted((object) this, new describeVisualForceCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("SessionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("DuplicateRuleHeaderValue")]
    [return: XmlElement("result")]
    public FindDuplicatesResult[] findDuplicates([XmlElement("sObjects")] sObject[] sObjects)
    {
      return (FindDuplicatesResult[]) this.Invoke(nameof (findDuplicates), new object[1]
      {
        (object) sObjects
      })[0];
    }

    public void findDuplicatesAsync(sObject[] sObjects)
    {
      this.findDuplicatesAsync(sObjects, (object) null);
    }

    public void findDuplicatesAsync(sObject[] sObjects, object userState)
    {
      if (this.findDuplicatesOperationCompleted == null)
        this.findDuplicatesOperationCompleted = new SendOrPostCallback(this.OnfindDuplicatesOperationCompleted);
      this.InvokeAsync("findDuplicates", new object[1]
      {
        (object) sObjects
      }, this.findDuplicatesOperationCompleted, userState);
    }

    private void OnfindDuplicatesOperationCompleted(object arg)
    {
      if (this.findDuplicatesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.findDuplicatesCompleted((object) this, new findDuplicatesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("LimitInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("LocaleOptionsValue")]
    [SoapHeader("PackageVersionHeaderValue")]
    [SoapHeader("SessionHeaderValue")]
    [SoapDocumentMethod("", RequestNamespace = "urn:enterprise.soap.sforce.com", ResponseNamespace = "urn:enterprise.soap.sforce.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    [return: XmlElement("result", IsNullable = true)]
    public DescribeNounResult[] describeNouns([XmlElement("nouns")] string[] nouns, bool onlyRenamed, bool includeFields)
    {
      return (DescribeNounResult[]) this.Invoke(nameof (describeNouns), new object[3]
      {
        (object) nouns,
        (object) onlyRenamed,
        (object) includeFields
      })[0];
    }

    public void describeNounsAsync(string[] nouns, bool onlyRenamed, bool includeFields)
    {
      this.describeNounsAsync(nouns, onlyRenamed, includeFields, (object) null);
    }

    public void describeNounsAsync(
      string[] nouns,
      bool onlyRenamed,
      bool includeFields,
      object userState)
    {
      if (this.describeNounsOperationCompleted == null)
        this.describeNounsOperationCompleted = new SendOrPostCallback(this.OndescribeNounsOperationCompleted);
      this.InvokeAsync("describeNouns", new object[3]
      {
        (object) nouns,
        (object) onlyRenamed,
        (object) includeFields
      }, this.describeNounsOperationCompleted, userState);
    }

    private void OndescribeNounsOperationCompleted(object arg)
    {
      if (this.describeNounsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.describeNounsCompleted((object) this, new describeNounsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    public new void CancelAsync(object userState) => base.CancelAsync(userState);

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || url == string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}
