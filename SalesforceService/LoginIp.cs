// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LoginIp
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
  public class LoginIp : sObject
  {
    private string challengeMethodField;
    private DateTime? challengeSentDateField;
    private bool challengeSentDateFieldSpecified;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private bool? isAuthenticatedField;
    private bool isAuthenticatedFieldSpecified;
    private string sourceIpField;
    private User usersField;
    private string usersIdField;

    [XmlElement(IsNullable = true)]
    public string ChallengeMethod
    {
      get => this.challengeMethodField;
      set => this.challengeMethodField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ChallengeSentDate
    {
      get => this.challengeSentDateField;
      set => this.challengeSentDateField = value;
    }

    [XmlIgnore]
    public bool ChallengeSentDateSpecified
    {
      get => this.challengeSentDateFieldSpecified;
      set => this.challengeSentDateFieldSpecified = value;
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
    public bool? IsAuthenticated
    {
      get => this.isAuthenticatedField;
      set => this.isAuthenticatedField = value;
    }

    [XmlIgnore]
    public bool IsAuthenticatedSpecified
    {
      get => this.isAuthenticatedFieldSpecified;
      set => this.isAuthenticatedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceIp
    {
      get => this.sourceIpField;
      set => this.sourceIpField = value;
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
