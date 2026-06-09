// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EmailServicesFunction
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
  public class EmailServicesFunction : sObject
  {
    private string addressInactiveActionField;
    private QueryResult addressesField;
    private string apexClassIdField;
    private string attachmentOptionField;
    private string authenticationFailureActionField;
    private string authorizationFailureActionField;
    private string authorizedSendersField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string errorRoutingAddressField;
    private string functionInactiveActionField;
    private string functionNameField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isAuthenticationRequiredField;
    private bool isAuthenticationRequiredFieldSpecified;
    private bool? isErrorRoutingEnabledField;
    private bool isErrorRoutingEnabledFieldSpecified;
    private bool? isTextAttachmentsAsBinaryField;
    private bool isTextAttachmentsAsBinaryFieldSpecified;
    private bool? isTlsRequiredField;
    private bool isTlsRequiredFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string overLimitActionField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string AddressInactiveAction
    {
      get => this.addressInactiveActionField;
      set => this.addressInactiveActionField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Addresses
    {
      get => this.addressesField;
      set => this.addressesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApexClassId
    {
      get => this.apexClassIdField;
      set => this.apexClassIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AttachmentOption
    {
      get => this.attachmentOptionField;
      set => this.attachmentOptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AuthenticationFailureAction
    {
      get => this.authenticationFailureActionField;
      set => this.authenticationFailureActionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AuthorizationFailureAction
    {
      get => this.authorizationFailureActionField;
      set => this.authorizationFailureActionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AuthorizedSenders
    {
      get => this.authorizedSendersField;
      set => this.authorizedSendersField = value;
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
    public string ErrorRoutingAddress
    {
      get => this.errorRoutingAddressField;
      set => this.errorRoutingAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FunctionInactiveAction
    {
      get => this.functionInactiveActionField;
      set => this.functionInactiveActionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FunctionName
    {
      get => this.functionNameField;
      set => this.functionNameField = value;
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
    public bool? IsAuthenticationRequired
    {
      get => this.isAuthenticationRequiredField;
      set => this.isAuthenticationRequiredField = value;
    }

    [XmlIgnore]
    public bool IsAuthenticationRequiredSpecified
    {
      get => this.isAuthenticationRequiredFieldSpecified;
      set => this.isAuthenticationRequiredFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsErrorRoutingEnabled
    {
      get => this.isErrorRoutingEnabledField;
      set => this.isErrorRoutingEnabledField = value;
    }

    [XmlIgnore]
    public bool IsErrorRoutingEnabledSpecified
    {
      get => this.isErrorRoutingEnabledFieldSpecified;
      set => this.isErrorRoutingEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsTextAttachmentsAsBinary
    {
      get => this.isTextAttachmentsAsBinaryField;
      set => this.isTextAttachmentsAsBinaryField = value;
    }

    [XmlIgnore]
    public bool IsTextAttachmentsAsBinarySpecified
    {
      get => this.isTextAttachmentsAsBinaryFieldSpecified;
      set => this.isTextAttachmentsAsBinaryFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsTlsRequired
    {
      get => this.isTlsRequiredField;
      set => this.isTlsRequiredField = value;
    }

    [XmlIgnore]
    public bool IsTlsRequiredSpecified
    {
      get => this.isTlsRequiredFieldSpecified;
      set => this.isTlsRequiredFieldSpecified = value;
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
    public string OverLimitAction
    {
      get => this.overLimitActionField;
      set => this.overLimitActionField = value;
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
  }
}
