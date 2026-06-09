// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserRole
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
  public class UserRole : sObject
  {
    private string caseAccessForAccountOwnerField;
    private string contactAccessForAccountOwnerField;
    private string developerNameField;
    private string forecastUserIdField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private bool? mayForecastManagerShareField;
    private bool mayForecastManagerShareFieldSpecified;
    private string nameField;
    private string opportunityAccessForAccountOwnerField;
    private string parentRoleIdField;
    private string portalAccountIdField;
    private string portalAccountOwnerIdField;
    private string portalTypeField;
    private string rollupDescriptionField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult usersField;

    [XmlElement(IsNullable = true)]
    public string CaseAccessForAccountOwner
    {
      get => this.caseAccessForAccountOwnerField;
      set => this.caseAccessForAccountOwnerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContactAccessForAccountOwner
    {
      get => this.contactAccessForAccountOwnerField;
      set => this.contactAccessForAccountOwnerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ForecastUserId
    {
      get => this.forecastUserIdField;
      set => this.forecastUserIdField = value;
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
    public bool? MayForecastManagerShare
    {
      get => this.mayForecastManagerShareField;
      set => this.mayForecastManagerShareField = value;
    }

    [XmlIgnore]
    public bool MayForecastManagerShareSpecified
    {
      get => this.mayForecastManagerShareFieldSpecified;
      set => this.mayForecastManagerShareFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OpportunityAccessForAccountOwner
    {
      get => this.opportunityAccessForAccountOwnerField;
      set => this.opportunityAccessForAccountOwnerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentRoleId
    {
      get => this.parentRoleIdField;
      set => this.parentRoleIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PortalAccountId
    {
      get => this.portalAccountIdField;
      set => this.portalAccountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PortalAccountOwnerId
    {
      get => this.portalAccountOwnerIdField;
      set => this.portalAccountOwnerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PortalType
    {
      get => this.portalTypeField;
      set => this.portalTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RollupDescription
    {
      get => this.rollupDescriptionField;
      set => this.rollupDescriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SystemModstamp
    {
      get => this.systemModstampField;
      set => this.systemModstampField = value;
    }

    [XmlIgnore]
    public bool SystemModstampSpecified
    {
      get => this.systemModstampFieldSpecified;
      set => this.systemModstampFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Users
    {
      get => this.usersField;
      set => this.usersField = value;
    }
  }
}
