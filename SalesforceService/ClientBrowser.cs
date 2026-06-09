// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ClientBrowser
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class ClientBrowser : sObject
  {
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string fullUserAgentField;
    private DateTime? lastUpdateField;
    private bool lastUpdateFieldSpecified;
    private string proxyInfoField;
    private User usersField;
    private string usersIdField;

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
    public string FullUserAgent
    {
      get => this.fullUserAgentField;
      set => this.fullUserAgentField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastUpdate
    {
      get => this.lastUpdateField;
      set => this.lastUpdateField = value;
    }

    [XmlIgnore]
    public bool LastUpdateSpecified
    {
      get => this.lastUpdateFieldSpecified;
      set => this.lastUpdateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProxyInfo
    {
      get => this.proxyInfoField;
      set => this.proxyInfoField = value;
    }

    [XmlElement(IsNullable = true)]
    public User Users
    {
      get => this.usersField;
      set => this.usersField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UsersId
    {
      get => this.usersIdField;
      set => this.usersIdField = value;
    }
  }
}
