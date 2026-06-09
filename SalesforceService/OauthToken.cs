// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OauthToken
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class OauthToken : sObject
  {
    private string accessTokenField;
    private AppMenuItem appMenuItemField;
    private string appMenuItemIdField;
    private string appNameField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string deleteTokenField;
    private DateTime? lastUsedDateField;
    private bool lastUsedDateFieldSpecified;
    private string requestTokenField;
    private int? useCountField;
    private bool useCountFieldSpecified;
    private User userField;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public string AccessToken
    {
      get => this.accessTokenField;
      set => this.accessTokenField = value;
    }

    [XmlElement(IsNullable = true)]
    public AppMenuItem AppMenuItem
    {
      get => this.appMenuItemField;
      set => this.appMenuItemField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AppMenuItemId
    {
      get => this.appMenuItemIdField;
      set => this.appMenuItemIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AppName
    {
      get => this.appNameField;
      set => this.appNameField = value;
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
    public string DeleteToken
    {
      get => this.deleteTokenField;
      set => this.deleteTokenField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastUsedDate
    {
      get => this.lastUsedDateField;
      set => this.lastUsedDateField = value;
    }

    [XmlIgnore]
    public bool LastUsedDateSpecified
    {
      get => this.lastUsedDateFieldSpecified;
      set => this.lastUsedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RequestToken
    {
      get => this.requestTokenField;
      set => this.requestTokenField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? UseCount
    {
      get => this.useCountField;
      set => this.useCountField = value;
    }

    [XmlIgnore]
    public bool UseCountSpecified
    {
      get => this.useCountFieldSpecified;
      set => this.useCountFieldSpecified = value;
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
