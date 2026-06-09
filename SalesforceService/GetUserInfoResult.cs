// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.GetUserInfoResult
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class GetUserInfoResult
  {
    private bool accessibilityModeField;
    private string currencySymbolField;
    private int orgAttachmentFileSizeLimitField;
    private string orgDefaultCurrencyIsoCodeField;
    private string orgDefaultCurrencyLocaleField;
    private bool orgDisallowHtmlAttachmentsField;
    private bool orgHasPersonAccountsField;
    private string organizationIdField;
    private bool organizationMultiCurrencyField;
    private string organizationNameField;
    private string profileIdField;
    private string roleIdField;
    private int sessionSecondsValidField;
    private string userDefaultCurrencyIsoCodeField;
    private string userEmailField;
    private string userFullNameField;
    private string userIdField;
    private string userLanguageField;
    private string userLocaleField;
    private string userNameField;
    private string userTimeZoneField;
    private string userTypeField;
    private string userUiSkinField;

    public bool accessibilityMode
    {
      get => this.accessibilityModeField;
      set => this.accessibilityModeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string currencySymbol
    {
      get => this.currencySymbolField;
      set => this.currencySymbolField = value;
    }

    public int orgAttachmentFileSizeLimit
    {
      get => this.orgAttachmentFileSizeLimitField;
      set => this.orgAttachmentFileSizeLimitField = value;
    }

    [XmlElement(IsNullable = true)]
    public string orgDefaultCurrencyIsoCode
    {
      get => this.orgDefaultCurrencyIsoCodeField;
      set => this.orgDefaultCurrencyIsoCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string orgDefaultCurrencyLocale
    {
      get => this.orgDefaultCurrencyLocaleField;
      set => this.orgDefaultCurrencyLocaleField = value;
    }

    public bool orgDisallowHtmlAttachments
    {
      get => this.orgDisallowHtmlAttachmentsField;
      set => this.orgDisallowHtmlAttachmentsField = value;
    }

    public bool orgHasPersonAccounts
    {
      get => this.orgHasPersonAccountsField;
      set => this.orgHasPersonAccountsField = value;
    }

    public string organizationId
    {
      get => this.organizationIdField;
      set => this.organizationIdField = value;
    }

    public bool organizationMultiCurrency
    {
      get => this.organizationMultiCurrencyField;
      set => this.organizationMultiCurrencyField = value;
    }

    public string organizationName
    {
      get => this.organizationNameField;
      set => this.organizationNameField = value;
    }

    public string profileId
    {
      get => this.profileIdField;
      set => this.profileIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string roleId
    {
      get => this.roleIdField;
      set => this.roleIdField = value;
    }

    public int sessionSecondsValid
    {
      get => this.sessionSecondsValidField;
      set => this.sessionSecondsValidField = value;
    }

    [XmlElement(IsNullable = true)]
    public string userDefaultCurrencyIsoCode
    {
      get => this.userDefaultCurrencyIsoCodeField;
      set => this.userDefaultCurrencyIsoCodeField = value;
    }

    public string userEmail
    {
      get => this.userEmailField;
      set => this.userEmailField = value;
    }

    public string userFullName
    {
      get => this.userFullNameField;
      set => this.userFullNameField = value;
    }

    public string userId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    public string userLanguage
    {
      get => this.userLanguageField;
      set => this.userLanguageField = value;
    }

    public string userLocale
    {
      get => this.userLocaleField;
      set => this.userLocaleField = value;
    }

    public string userName
    {
      get => this.userNameField;
      set => this.userNameField = value;
    }

    public string userTimeZone
    {
      get => this.userTimeZoneField;
      set => this.userTimeZoneField = value;
    }

    public string userType
    {
      get => this.userTypeField;
      set => this.userTypeField = value;
    }

    public string userUiSkin
    {
      get => this.userUiSkinField;
      set => this.userUiSkinField = value;
    }
  }
}
