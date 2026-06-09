// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserLogin
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
  public class UserLogin : sObject
  {
    private bool? isFrozenField;
    private bool isFrozenFieldSpecified;
    private bool? isPasswordLockedField;
    private bool isPasswordLockedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public bool? IsFrozen
    {
      get => this.isFrozenField;
      set => this.isFrozenField = value;
    }

    [XmlIgnore]
    public bool IsFrozenSpecified
    {
      get => this.isFrozenFieldSpecified;
      set => this.isFrozenFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsPasswordLocked
    {
      get => this.isPasswordLockedField;
      set => this.isPasswordLockedField = value;
    }

    [XmlIgnore]
    public bool IsPasswordLockedSpecified
    {
      get => this.isPasswordLockedFieldSpecified;
      set => this.isPasswordLockedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User LastModifiedBy
    {
      get => this.lastModifiedByField;
      set => this.lastModifiedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastModifiedById
    {
      get => this.lastModifiedByIdField;
      set => this.lastModifiedByIdField = value;
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
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }
  }
}
