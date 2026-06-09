// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserProvisioningConfig
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class UserProvisioningConfig : sObject
  {
    private string approvalRequiredField;
    private ConnectedApplication connectedAppField;
    private string connectedAppIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string developerNameField;
    private bool? enabledField;
    private bool enabledFieldSpecified;
    private string enabledOperationsField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string languageField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReconDateTimeField;
    private bool lastReconDateTimeFieldSpecified;
    private string masterLabelField;
    private NamedCredential namedCredentialField;
    private string namedCredentialIdField;
    private string namespacePrefixField;
    private string notesField;
    private string onUpdateAttributesField;
    private string reconFilterField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string userAccountMappingField;

    [XmlElement(IsNullable = true)]
    public string ApprovalRequired
    {
      get => this.approvalRequiredField;
      set => this.approvalRequiredField = value;
    }

    [XmlElement(IsNullable = true)]
    public ConnectedApplication ConnectedApp
    {
      get => this.connectedAppField;
      set => this.connectedAppField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConnectedAppId
    {
      get => this.connectedAppIdField;
      set => this.connectedAppIdField = value;
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
    public bool? Enabled
    {
      get => this.enabledField;
      set => this.enabledField = value;
    }

    [XmlIgnore]
    public bool EnabledSpecified
    {
      get => this.enabledFieldSpecified;
      set => this.enabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string EnabledOperations
    {
      get => this.enabledOperationsField;
      set => this.enabledOperationsField = value;
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
    public DateTime? LastReconDateTime
    {
      get => this.lastReconDateTimeField;
      set => this.lastReconDateTimeField = value;
    }

    [XmlIgnore]
    public bool LastReconDateTimeSpecified
    {
      get => this.lastReconDateTimeFieldSpecified;
      set => this.lastReconDateTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MasterLabel
    {
      get => this.masterLabelField;
      set => this.masterLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public NamedCredential NamedCredential
    {
      get => this.namedCredentialField;
      set => this.namedCredentialField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamedCredentialId
    {
      get => this.namedCredentialIdField;
      set => this.namedCredentialIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Notes
    {
      get => this.notesField;
      set => this.notesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OnUpdateAttributes
    {
      get => this.onUpdateAttributesField;
      set => this.onUpdateAttributesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ReconFilter
    {
      get => this.reconFilterField;
      set => this.reconFilterField = value;
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
    public string UserAccountMapping
    {
      get => this.userAccountMappingField;
      set => this.userAccountMappingField = value;
    }
  }
}
