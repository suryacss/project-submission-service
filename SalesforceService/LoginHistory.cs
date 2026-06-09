// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LoginHistory
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
  public class LoginHistory : sObject
  {
    private string apiTypeField;
    private string apiVersionField;
    private string applicationField;
    private string authenticationServiceIdField;
    private string browserField;
    private string cipherSuiteField;
    private string clientVersionField;
    private string countryIsoField;
    private LoginGeo loginGeoField;
    private string loginGeoIdField;
    private DateTime? loginTimeField;
    private bool loginTimeFieldSpecified;
    private string loginTypeField;
    private string loginUrlField;
    private string platformField;
    private string sourceIpField;
    private string statusField;
    private string tlsProtocolField;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public string ApiType
    {
      get => this.apiTypeField;
      set => this.apiTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApiVersion
    {
      get => this.apiVersionField;
      set => this.apiVersionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Application
    {
      get => this.applicationField;
      set => this.applicationField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AuthenticationServiceId
    {
      get => this.authenticationServiceIdField;
      set => this.authenticationServiceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Browser
    {
      get => this.browserField;
      set => this.browserField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CipherSuite
    {
      get => this.cipherSuiteField;
      set => this.cipherSuiteField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ClientVersion
    {
      get => this.clientVersionField;
      set => this.clientVersionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CountryIso
    {
      get => this.countryIsoField;
      set => this.countryIsoField = value;
    }

    [XmlElement(IsNullable = true)]
    public LoginGeo LoginGeo
    {
      get => this.loginGeoField;
      set => this.loginGeoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LoginGeoId
    {
      get => this.loginGeoIdField;
      set => this.loginGeoIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LoginTime
    {
      get => this.loginTimeField;
      set => this.loginTimeField = value;
    }

    [XmlIgnore]
    public bool LoginTimeSpecified
    {
      get => this.loginTimeFieldSpecified;
      set => this.loginTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LoginType
    {
      get => this.loginTypeField;
      set => this.loginTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LoginUrl
    {
      get => this.loginUrlField;
      set => this.loginUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Platform
    {
      get => this.platformField;
      set => this.platformField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceIp
    {
      get => this.sourceIpField;
      set => this.sourceIpField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TlsProtocol
    {
      get => this.tlsProtocolField;
      set => this.tlsProtocolField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }
  }
}
