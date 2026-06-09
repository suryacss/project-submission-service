// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RecentlyViewed
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
  public class RecentlyViewed : sObject
  {
    private string aliasField;
    private string emailField;
    private string firstNameField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private string languageField;
    private string lastNameField;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private string nameField;
    private string nameOrAliasField;
    private string phoneField;
    private Profile profileField;
    private string profileIdField;
    private RecordType recordTypeField;
    private string recordTypeIdField;
    private string titleField;
    private string typeField;
    private UserRole userRoleField;
    private string userRoleIdField;

    [XmlElement(IsNullable = true)]
    public string Alias
    {
      get => this.aliasField;
      set => this.aliasField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Email
    {
      get => this.emailField;
      set => this.emailField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FirstName
    {
      get => this.firstNameField;
      set => this.firstNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsActive
    {
      get => this.isActiveField;
      set => this.isActiveField = value;
    }

    [XmlIgnore]
    public bool IsActiveSpecified
    {
      get => this.isActiveFieldSpecified;
      set => this.isActiveFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Language
    {
      get => this.languageField;
      set => this.languageField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastName
    {
      get => this.lastNameField;
      set => this.lastNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastReferencedDate
    {
      get => this.lastReferencedDateField;
      set => this.lastReferencedDateField = value;
    }

    [XmlIgnore]
    public bool LastReferencedDateSpecified
    {
      get => this.lastReferencedDateFieldSpecified;
      set => this.lastReferencedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastViewedDate
    {
      get => this.lastViewedDateField;
      set => this.lastViewedDateField = value;
    }

    [XmlIgnore]
    public bool LastViewedDateSpecified
    {
      get => this.lastViewedDateFieldSpecified;
      set => this.lastViewedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NameOrAlias
    {
      get => this.nameOrAliasField;
      set => this.nameOrAliasField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Phone
    {
      get => this.phoneField;
      set => this.phoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public Profile Profile
    {
      get => this.profileField;
      set => this.profileField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProfileId
    {
      get => this.profileIdField;
      set => this.profileIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public RecordType RecordType
    {
      get => this.recordTypeField;
      set => this.recordTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecordTypeId
    {
      get => this.recordTypeIdField;
      set => this.recordTypeIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRole UserRole
    {
      get => this.userRoleField;
      set => this.userRoleField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserRoleId
    {
      get => this.userRoleIdField;
      set => this.userRoleIdField = value;
    }
  }
}
