// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SamlSsoConfig
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
  public class SamlSsoConfig : sObject
  {
    private string attributeFormatField;
    private string attributeNameField;
    private string audienceField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string developerNameField;
    private string errorUrlField;
    private User executionUserField;
    private string executionUserIdField;
    private string identityLocationField;
    private string identityMappingField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string issuerField;
    private string languageField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string loginUrlField;
    private string logoutUrlField;
    private string masterLabelField;
    private string namespacePrefixField;
    private bool? optionsSpInitBindingField;
    private bool optionsSpInitBindingFieldSpecified;
    private bool? optionsUserProvisioningField;
    private bool optionsUserProvisioningFieldSpecified;
    private string requestSignatureMethodField;
    private ApexClass samlJitHandlerField;
    private string samlJitHandlerIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string validationCertField;
    private string versionField;

    [XmlElement(IsNullable = true)]
    public string AttributeFormat
    {
      get => this.attributeFormatField;
      set => this.attributeFormatField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AttributeName
    {
      get => this.attributeNameField;
      set => this.attributeNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Audience
    {
      get => this.audienceField;
      set => this.audienceField = value;
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
    public string ErrorUrl
    {
      get => this.errorUrlField;
      set => this.errorUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public User ExecutionUser
    {
      get => this.executionUserField;
      set => this.executionUserField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExecutionUserId
    {
      get => this.executionUserIdField;
      set => this.executionUserIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IdentityLocation
    {
      get => this.identityLocationField;
      set => this.identityLocationField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IdentityMapping
    {
      get => this.identityMappingField;
      set => this.identityMappingField = value;
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
    public string Issuer
    {
      get => this.issuerField;
      set => this.issuerField = value;
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
    public string LoginUrl
    {
      get => this.loginUrlField;
      set => this.loginUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LogoutUrl
    {
      get => this.logoutUrlField;
      set => this.logoutUrlField = value;
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
    public bool? OptionsSpInitBinding
    {
      get => this.optionsSpInitBindingField;
      set => this.optionsSpInitBindingField = value;
    }

    [XmlIgnore]
    public bool OptionsSpInitBindingSpecified
    {
      get => this.optionsSpInitBindingFieldSpecified;
      set => this.optionsSpInitBindingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsUserProvisioning
    {
      get => this.optionsUserProvisioningField;
      set => this.optionsUserProvisioningField = value;
    }

    [XmlIgnore]
    public bool OptionsUserProvisioningSpecified
    {
      get => this.optionsUserProvisioningFieldSpecified;
      set => this.optionsUserProvisioningFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RequestSignatureMethod
    {
      get => this.requestSignatureMethodField;
      set => this.requestSignatureMethodField = value;
    }

    [XmlElement(IsNullable = true)]
    public ApexClass SamlJitHandler
    {
      get => this.samlJitHandlerField;
      set => this.samlJitHandlerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SamlJitHandlerId
    {
      get => this.samlJitHandlerIdField;
      set => this.samlJitHandlerIdField = value;
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
    public string ValidationCert
    {
      get => this.validationCertField;
      set => this.validationCertField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Version
    {
      get => this.versionField;
      set => this.versionField = value;
    }
  }
}
