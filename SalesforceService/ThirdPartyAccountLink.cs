// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ThirdPartyAccountLink
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class ThirdPartyAccountLink : sObject
  {
    private string handleField;
    private bool? isNotSsoUsableField;
    private bool isNotSsoUsableFieldSpecified;
    private string providerField;
    private string remoteIdentifierField;
    private AuthProvider ssoProviderField;
    private string ssoProviderIdField;
    private string ssoProviderNameField;
    private string thirdPartyAccountLinkKeyField;
    private User userField;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public string Handle
    {
      get => this.handleField;
      set => this.handleField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsNotSsoUsable
    {
      get => this.isNotSsoUsableField;
      set => this.isNotSsoUsableField = value;
    }

    [XmlIgnore]
    public bool IsNotSsoUsableSpecified
    {
      get => this.isNotSsoUsableFieldSpecified;
      set => this.isNotSsoUsableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Provider
    {
      get => this.providerField;
      set => this.providerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RemoteIdentifier
    {
      get => this.remoteIdentifierField;
      set => this.remoteIdentifierField = value;
    }

    [XmlElement(IsNullable = true)]
    public AuthProvider SsoProvider
    {
      get => this.ssoProviderField;
      set => this.ssoProviderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SsoProviderId
    {
      get => this.ssoProviderIdField;
      set => this.ssoProviderIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SsoProviderName
    {
      get => this.ssoProviderNameField;
      set => this.ssoProviderNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ThirdPartyAccountLinkKey
    {
      get => this.thirdPartyAccountLinkKeyField;
      set => this.thirdPartyAccountLinkKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public User User
    {
      get => this.userField;
      set => this.userField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }
  }
}
