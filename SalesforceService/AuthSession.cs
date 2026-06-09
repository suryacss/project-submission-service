// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.AuthSession
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class AuthSession : sObject
  {
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private bool? isCurrentField;
    private bool isCurrentFieldSpecified;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private LoginGeo loginGeoField;
    private string loginGeoIdField;
    private LoginHistory loginHistoryField;
    private string loginHistoryIdField;
    private string loginTypeField;
    private string logoutUrlField;
    private int? numSecondsValidField;
    private bool numSecondsValidFieldSpecified;
    private string parentIdField;
    private string sessionSecurityLevelField;
    private string sessionTypeField;
    private string sourceIpField;
    private string userTypeField;
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
    public bool? IsCurrent
    {
      get => this.isCurrentField;
      set => this.isCurrentField = value;
    }

    [XmlIgnore]
    public bool IsCurrentSpecified
    {
      get => this.isCurrentFieldSpecified;
      set => this.isCurrentFieldSpecified = value;
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
    public LoginHistory LoginHistory
    {
      get => this.loginHistoryField;
      set => this.loginHistoryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LoginHistoryId
    {
      get => this.loginHistoryIdField;
      set => this.loginHistoryIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LoginType
    {
      get => this.loginTypeField;
      set => this.loginTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LogoutUrl
    {
      get => this.logoutUrlField;
      set => this.logoutUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumSecondsValid
    {
      get => this.numSecondsValidField;
      set => this.numSecondsValidField = value;
    }

    [XmlIgnore]
    public bool NumSecondsValidSpecified
    {
      get => this.numSecondsValidFieldSpecified;
      set => this.numSecondsValidFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentId
    {
      get => this.parentIdField;
      set => this.parentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SessionSecurityLevel
    {
      get => this.sessionSecurityLevelField;
      set => this.sessionSecurityLevelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SessionType
    {
      get => this.sessionTypeField;
      set => this.sessionTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceIp
    {
      get => this.sourceIpField;
      set => this.sourceIpField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserType
    {
      get => this.userTypeField;
      set => this.userTypeField = value;
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
