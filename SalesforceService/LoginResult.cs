// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LoginResult
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class LoginResult
  {
    private string metadataServerUrlField;
    private bool passwordExpiredField;
    private bool sandboxField;
    private string serverUrlField;
    private string sessionIdField;
    private string userIdField;
    private GetUserInfoResult userInfoField;

    [XmlElement(IsNullable = true)]
    public string metadataServerUrl
    {
      get => this.metadataServerUrlField;
      set => this.metadataServerUrlField = value;
    }

    public bool passwordExpired
    {
      get => this.passwordExpiredField;
      set => this.passwordExpiredField = value;
    }

    public bool sandbox
    {
      get => this.sandboxField;
      set => this.sandboxField = value;
    }

    [XmlElement(IsNullable = true)]
    public string serverUrl
    {
      get => this.serverUrlField;
      set => this.serverUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string sessionId
    {
      get => this.sessionIdField;
      set => this.sessionIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string userId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    public GetUserInfoResult userInfo
    {
      get => this.userInfoField;
      set => this.userInfoField = value;
    }
  }
}
