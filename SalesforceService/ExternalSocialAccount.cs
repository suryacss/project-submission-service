// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ExternalSocialAccount
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
  public class ExternalSocialAccount : sObject
  {
    private string authorizedByField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string dataSourceIdField;
    private ExternalSocialAccount defaultResponseAccountField;
    private string defaultResponseAccountIdField;
    private string developerNameField;
    private string externalAccountIdField;
    private string externalPictureURLField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isAuthenticatedField;
    private bool isAuthenticatedFieldSpecified;
    private bool? isCaseCreationEnabledField;
    private bool isCaseCreationEnabledFieldSpecified;
    private bool? isDataSourceActiveField;
    private bool isDataSourceActiveFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string languageField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string masterLabelField;
    private string profileUrlField;
    private string providerField;
    private string providerUserIdField;
    private string ruleIdField;
    private QueryResult setupEntityAccessItemsField;
    private string socialPropertyIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string topicIdField;
    private string uniqueNameField;
    private string usernameField;

    [XmlElement(IsNullable = true)]
    public string AuthorizedBy
    {
      get => this.authorizedByField;
      set => this.authorizedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public User CreatedBy
    {
      get => this.createdByField;
      set => this.createdByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CreatedById
    {
      get => this.createdByIdField;
      set => this.createdByIdField = value;
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
    public string DataSourceId
    {
      get => this.dataSourceIdField;
      set => this.dataSourceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ExternalSocialAccount DefaultResponseAccount
    {
      get => this.defaultResponseAccountField;
      set => this.defaultResponseAccountField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultResponseAccountId
    {
      get => this.defaultResponseAccountIdField;
      set => this.defaultResponseAccountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalAccountId
    {
      get => this.externalAccountIdField;
      set => this.externalAccountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalPictureURL
    {
      get => this.externalPictureURLField;
      set => this.externalPictureURLField = value;
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
    public bool? IsCaseCreationEnabled
    {
      get => this.isCaseCreationEnabledField;
      set => this.isCaseCreationEnabledField = value;
    }

    [XmlIgnore]
    public bool IsCaseCreationEnabledSpecified
    {
      get => this.isCaseCreationEnabledFieldSpecified;
      set => this.isCaseCreationEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDataSourceActive
    {
      get => this.isDataSourceActiveField;
      set => this.isDataSourceActiveField = value;
    }

    [XmlIgnore]
    public bool IsDataSourceActiveSpecified
    {
      get => this.isDataSourceActiveFieldSpecified;
      set => this.isDataSourceActiveFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeleted
    {
      get => this.isDeletedField;
      set => this.isDeletedField = value;
    }

    [XmlIgnore]
    public bool IsDeletedSpecified
    {
      get => this.isDeletedFieldSpecified;
      set => this.isDeletedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Language
    {
      get => this.languageField;
      set => this.languageField = value;
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
    public string MasterLabel
    {
      get => this.masterLabelField;
      set => this.masterLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProfileUrl
    {
      get => this.profileUrlField;
      set => this.profileUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Provider
    {
      get => this.providerField;
      set => this.providerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProviderUserId
    {
      get => this.providerUserIdField;
      set => this.providerUserIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RuleId
    {
      get => this.ruleIdField;
      set => this.ruleIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SetupEntityAccessItems
    {
      get => this.setupEntityAccessItemsField;
      set => this.setupEntityAccessItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SocialPropertyId
    {
      get => this.socialPropertyIdField;
      set => this.socialPropertyIdField = value;
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
    public string TopicId
    {
      get => this.topicIdField;
      set => this.topicIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UniqueName
    {
      get => this.uniqueNameField;
      set => this.uniqueNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }
  }
}
