// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.AuthProvider
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
  public class AuthProvider : sObject
  {
    private string authorizeUrlField;
    private string consumerKeyField;
    private string consumerSecretField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string customMetadataTypeRecordField;
    private string defaultScopesField;
    private string developerNameField;
    private string errorUrlField;
    private string executionUserIdField;
    private string friendlyNameField;
    private string iconUrlField;
    private string idTokenIssuerField;
    private string logoutUrlField;
    private bool? optionsIncludeOrgIdInIdField;
    private bool optionsIncludeOrgIdInIdFieldSpecified;
    private bool? optionsSendAccessTokenInHeaderField;
    private bool optionsSendAccessTokenInHeaderFieldSpecified;
    private bool? optionsSendClientCredentialsInHeaderField;
    private bool optionsSendClientCredentialsInHeaderFieldSpecified;
    private string pluginIdField;
    private string providerTypeField;
    private string registrationHandlerIdField;
    private string tokenUrlField;
    private string userInfoUrlField;

    [XmlElement(IsNullable = true)]
    public string AuthorizeUrl
    {
      get => this.authorizeUrlField;
      set => this.authorizeUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConsumerKey
    {
      get => this.consumerKeyField;
      set => this.consumerKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConsumerSecret
    {
      get => this.consumerSecretField;
      set => this.consumerSecretField = value;
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
    public string CustomMetadataTypeRecord
    {
      get => this.customMetadataTypeRecordField;
      set => this.customMetadataTypeRecordField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultScopes
    {
      get => this.defaultScopesField;
      set => this.defaultScopesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ErrorUrl
    {
      get => this.errorUrlField;
      set => this.errorUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExecutionUserId
    {
      get => this.executionUserIdField;
      set => this.executionUserIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FriendlyName
    {
      get => this.friendlyNameField;
      set => this.friendlyNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IconUrl
    {
      get => this.iconUrlField;
      set => this.iconUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IdTokenIssuer
    {
      get => this.idTokenIssuerField;
      set => this.idTokenIssuerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LogoutUrl
    {
      get => this.logoutUrlField;
      set => this.logoutUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsIncludeOrgIdInId
    {
      get => this.optionsIncludeOrgIdInIdField;
      set => this.optionsIncludeOrgIdInIdField = value;
    }

    [XmlIgnore]
    public bool OptionsIncludeOrgIdInIdSpecified
    {
      get => this.optionsIncludeOrgIdInIdFieldSpecified;
      set => this.optionsIncludeOrgIdInIdFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsSendAccessTokenInHeader
    {
      get => this.optionsSendAccessTokenInHeaderField;
      set => this.optionsSendAccessTokenInHeaderField = value;
    }

    [XmlIgnore]
    public bool OptionsSendAccessTokenInHeaderSpecified
    {
      get => this.optionsSendAccessTokenInHeaderFieldSpecified;
      set => this.optionsSendAccessTokenInHeaderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsSendClientCredentialsInHeader
    {
      get => this.optionsSendClientCredentialsInHeaderField;
      set => this.optionsSendClientCredentialsInHeaderField = value;
    }

    [XmlIgnore]
    public bool OptionsSendClientCredentialsInHeaderSpecified
    {
      get => this.optionsSendClientCredentialsInHeaderFieldSpecified;
      set => this.optionsSendClientCredentialsInHeaderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PluginId
    {
      get => this.pluginIdField;
      set => this.pluginIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProviderType
    {
      get => this.providerTypeField;
      set => this.providerTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RegistrationHandlerId
    {
      get => this.registrationHandlerIdField;
      set => this.registrationHandlerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TokenUrl
    {
      get => this.tokenUrlField;
      set => this.tokenUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserInfoUrl
    {
      get => this.userInfoUrlField;
      set => this.userInfoUrlField = value;
    }
  }
}
