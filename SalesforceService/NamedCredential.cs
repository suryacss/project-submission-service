// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.NamedCredential
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
  public class NamedCredential : sObject
  {
    private AuthProvider authProviderField;
    private string authProviderIdField;
    private bool? calloutOptionsAllowMergeFieldsInBodyField;
    private bool calloutOptionsAllowMergeFieldsInBodyFieldSpecified;
    private bool? calloutOptionsAllowMergeFieldsInHeaderField;
    private bool calloutOptionsAllowMergeFieldsInHeaderFieldSpecified;
    private bool? calloutOptionsGenerateAuthorizationHeaderField;
    private bool calloutOptionsGenerateAuthorizationHeaderFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string developerNameField;
    private string endpointField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string languageField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string masterLabelField;
    private string namespacePrefixField;
    private string principalTypeField;
    private QueryResult setupEntityAccessItemsField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
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
    public bool? CalloutOptionsAllowMergeFieldsInBody
    {
      get => this.calloutOptionsAllowMergeFieldsInBodyField;
      set => this.calloutOptionsAllowMergeFieldsInBodyField = value;
    }

    [XmlIgnore]
    public bool CalloutOptionsAllowMergeFieldsInBodySpecified
    {
      get => this.calloutOptionsAllowMergeFieldsInBodyFieldSpecified;
      set => this.calloutOptionsAllowMergeFieldsInBodyFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? CalloutOptionsAllowMergeFieldsInHeader
    {
      get => this.calloutOptionsAllowMergeFieldsInHeaderField;
      set => this.calloutOptionsAllowMergeFieldsInHeaderField = value;
    }

    [XmlIgnore]
    public bool CalloutOptionsAllowMergeFieldsInHeaderSpecified
    {
      get => this.calloutOptionsAllowMergeFieldsInHeaderFieldSpecified;
      set => this.calloutOptionsAllowMergeFieldsInHeaderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? CalloutOptionsGenerateAuthorizationHeader
    {
      get => this.calloutOptionsGenerateAuthorizationHeaderField;
      set => this.calloutOptionsGenerateAuthorizationHeaderField = value;
    }

    [XmlIgnore]
    public bool CalloutOptionsGenerateAuthorizationHeaderSpecified
    {
      get => this.calloutOptionsGenerateAuthorizationHeaderFieldSpecified;
      set => this.calloutOptionsGenerateAuthorizationHeaderFieldSpecified = value;
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
    public QueryResult SetupEntityAccessItems
    {
      get => this.setupEntityAccessItemsField;
      set => this.setupEntityAccessItemsField = value;
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
    public QueryResult UserAuths
    {
      get => this.userAuthsField;
      set => this.userAuthsField = value;
    }
  }
}
