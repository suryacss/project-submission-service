// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.CampaignMember
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class CampaignMember : sObject
  {
    private Campaign campaignField;
    private string campaignIdField;
    private string cityField;
    private string companyOrAccountField;
    private Contact contactField;
    private string contactIdField;
    private string countryField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private bool? doNotCallField;
    private bool doNotCallFieldSpecified;
    private string emailField;
    private string faxField;
    private string firstNameField;
    private DateTime? firstRespondedDateField;
    private bool firstRespondedDateFieldSpecified;
    private bool? hasOptedOutOfEmailField;
    private bool hasOptedOutOfEmailFieldSpecified;
    private bool? hasOptedOutOfFaxField;
    private bool hasOptedOutOfFaxFieldSpecified;
    private bool? hasRespondedField;
    private bool hasRespondedFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string lastNameField;
    private Lead leadField;
    private string leadIdField;
    private string leadOrContactIdField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name leadOrContactOwnerField;
    private string leadOrContactOwnerIdField;
    private string leadSourceField;
    private string mobilePhoneField;
    private string nameField;
    private string phoneField;
    private string postalCodeField;
    private string salutationField;
    private string stateField;
    private string statusField;
    private string streetField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string titleField;
    private string typeField;

    [XmlElement(IsNullable = true)]
    public Campaign Campaign
    {
      get => this.campaignField;
      set => this.campaignField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CampaignId
    {
      get => this.campaignIdField;
      set => this.campaignIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string City
    {
      get => this.cityField;
      set => this.cityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CompanyOrAccount
    {
      get => this.companyOrAccountField;
      set => this.companyOrAccountField = value;
    }

    [XmlElement(IsNullable = true)]
    public Contact Contact
    {
      get => this.contactField;
      set => this.contactField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContactId
    {
      get => this.contactIdField;
      set => this.contactIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Country
    {
      get => this.countryField;
      set => this.countryField = value;
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
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? DoNotCall
    {
      get => this.doNotCallField;
      set => this.doNotCallField = value;
    }

    [XmlIgnore]
    public bool DoNotCallSpecified
    {
      get => this.doNotCallFieldSpecified;
      set => this.doNotCallFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Email
    {
      get => this.emailField;
      set => this.emailField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Fax
    {
      get => this.faxField;
      set => this.faxField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FirstName
    {
      get => this.firstNameField;
      set => this.firstNameField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? FirstRespondedDate
    {
      get => this.firstRespondedDateField;
      set => this.firstRespondedDateField = value;
    }

    [XmlIgnore]
    public bool FirstRespondedDateSpecified
    {
      get => this.firstRespondedDateFieldSpecified;
      set => this.firstRespondedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasOptedOutOfEmail
    {
      get => this.hasOptedOutOfEmailField;
      set => this.hasOptedOutOfEmailField = value;
    }

    [XmlIgnore]
    public bool HasOptedOutOfEmailSpecified
    {
      get => this.hasOptedOutOfEmailFieldSpecified;
      set => this.hasOptedOutOfEmailFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasOptedOutOfFax
    {
      get => this.hasOptedOutOfFaxField;
      set => this.hasOptedOutOfFaxField = value;
    }

    [XmlIgnore]
    public bool HasOptedOutOfFaxSpecified
    {
      get => this.hasOptedOutOfFaxFieldSpecified;
      set => this.hasOptedOutOfFaxFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasResponded
    {
      get => this.hasRespondedField;
      set => this.hasRespondedField = value;
    }

    [XmlIgnore]
    public bool HasRespondedSpecified
    {
      get => this.hasRespondedFieldSpecified;
      set => this.hasRespondedFieldSpecified = value;
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
    public string LastName
    {
      get => this.lastNameField;
      set => this.lastNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public Lead Lead
    {
      get => this.leadField;
      set => this.leadField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LeadId
    {
      get => this.leadIdField;
      set => this.leadIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LeadOrContactId
    {
      get => this.leadOrContactIdField;
      set => this.leadOrContactIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name LeadOrContactOwner
    {
      get => this.leadOrContactOwnerField;
      set => this.leadOrContactOwnerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LeadOrContactOwnerId
    {
      get => this.leadOrContactOwnerIdField;
      set => this.leadOrContactOwnerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LeadSource
    {
      get => this.leadSourceField;
      set => this.leadSourceField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobilePhone
    {
      get => this.mobilePhoneField;
      set => this.mobilePhoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Phone
    {
      get => this.phoneField;
      set => this.phoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PostalCode
    {
      get => this.postalCodeField;
      set => this.postalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Salutation
    {
      get => this.salutationField;
      set => this.salutationField = value;
    }

    [XmlElement(IsNullable = true)]
    public string State
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Street
    {
      get => this.streetField;
      set => this.streetField = value;
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
  }
}
