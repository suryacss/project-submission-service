// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ExternalDataSource
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class ExternalDataSource : sObject
  {
    private AuthProvider authProviderField;
    private string authProviderIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string customConfigurationField;
    private string developerNameField;
    private string endpointField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isWritableField;
    private bool isWritableFieldSpecified;
    private string languageField;
    private StaticResource largeIconField;
    private string largeIconIdField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string masterLabelField;
    private string namespacePrefixField;
    private string principalTypeField;
    private string protocolField;
    private string repositoryField;
    private QueryResult setupEntityAccessItemsField;
    private StaticResource smallIconField;
    private string smallIconIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string typeField;
    private QueryResult userAuthsField;

    [XmlElement(IsNullable = true)]
    public AuthProvider AuthProvider
    {
      get => this.authProviderField;
      set => this.authProviderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AuthProviderId
    {
      get => this.authProviderIdField;
      set => this.authProviderIdField = value;
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
    public string CustomConfiguration
    {
      get => this.customConfigurationField;
      set => this.customConfigurationField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Endpoint
    {
      get => this.endpointField;
      set => this.endpointField = value;
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
    public bool? IsWritable
    {
      get => this.isWritableField;
      set => this.isWritableField = value;
    }

    [XmlIgnore]
    public bool IsWritableSpecified
    {
      get => this.isWritableFieldSpecified;
      set => this.isWritableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Language
    {
      get => this.languageField;
      set => this.languageField = value;
    }

    [XmlElement(IsNullable = true)]
    public StaticResource LargeIcon
    {
      get => this.largeIconField;
      set => this.largeIconField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LargeIconId
    {
      get => this.largeIconIdField;
      set => this.largeIconIdField = value;
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
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PrincipalType
    {
      get => this.principalTypeField;
      set => this.principalTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Protocol
    {
      get => this.protocolField;
      set => this.protocolField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Repository
    {
      get => this.repositoryField;
      set => this.repositoryField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SetupEntityAccessItems
    {
      get => this.setupEntityAccessItemsField;
      set => this.setupEntityAccessItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public StaticResource SmallIcon
    {
      get => this.smallIconField;
      set => this.smallIconField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SmallIconId
    {
      get => this.smallIconIdField;
      set => this.smallIconIdField = value;
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
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult UserAuths
    {
      get => this.userAuthsField;
      set => this.userAuthsField = value;
    }
  }
}
