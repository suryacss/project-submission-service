// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Contact
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class Contact : sObject
  {
    private QueryResult acceptedEventRelationsField;
    private Account accountField;
    private QueryResult accountContactRolesField;
    private string accountIdField;
    private QueryResult activityHistoriesField;
    private QueryResult assetsField;
    private string assistantNameField;
    private string assistantPhoneField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private DateTime? birthdateField;
    private bool birthdateFieldSpecified;
    private QueryResult campaignMembersField;
    private QueryResult caseContactRolesField;
    private QueryResult casesField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private QueryResult contractContactRolesField;
    private QueryResult contractsSignedField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult declinedEventRelationsField;
    private string departmentField;
    private string descriptionField;
    private QueryResult duplicateRecordItemsField;
    private string emailField;
    private DateTime? emailBouncedDateField;
    private bool emailBouncedDateFieldSpecified;
    private string emailBouncedReasonField;
    private QueryResult emailMessageRelationsField;
    private QueryResult emailStatusesField;
    private QueryResult eventRelationsField;
    private QueryResult eventsField;
    private string faxField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private string firstNameField;
    private QueryResult historiesField;
    private string homePhoneField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isEmailBouncedField;
    private bool isEmailBouncedFieldSpecified;
    private string jigsawField;
    private string jigsawContactIdField;
    private DateTime? lastActivityDateField;
    private bool lastActivityDateFieldSpecified;
    private DateTime? lastCURequestDateField;
    private bool lastCURequestDateFieldSpecified;
    private DateTime? lastCUUpdateDateField;
    private bool lastCUUpdateDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string lastNameField;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private string leadSourceField;
    private QueryResult lookedUpFromActivitiesField;
    private address mailingAddressField;
    private string mailingCityField;
    private string mailingCountryField;
    private string mailingGeocodeAccuracyField;
    private double? mailingLatitudeField;
    private bool mailingLatitudeFieldSpecified;
    private double? mailingLongitudeField;
    private bool mailingLongitudeFieldSpecified;
    private string mailingPostalCodeField;
    private string mailingStateField;
    private string mailingStreetField;
    private Contact masterRecordField;
    private string masterRecordIdField;
    private string mobilePhoneField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private QueryResult openActivitiesField;
    private QueryResult opportunitiesField;
    private QueryResult opportunityContactRolesField;
    private address otherAddressField;
    private string otherCityField;
    private string otherCountryField;
    private string otherGeocodeAccuracyField;
    private double? otherLatitudeField;
    private bool otherLatitudeFieldSpecified;
    private double? otherLongitudeField;
    private bool otherLongitudeFieldSpecified;
    private string otherPhoneField;
    private string otherPostalCodeField;
    private string otherStateField;
    private string otherStreetField;
    private QueryResult outgoingEmailRelationsField;
    private User ownerField;
    private string ownerIdField;
    private QueryResult personasField;
    private string phoneField;
    private string photoUrlField;
    private QueryResult postsField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private Contact reportsToField;
    private string reportsToIdField;
    private string salutationField;
    private QueryResult sharesField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private string titleField;
    private QueryResult topicAssignmentsField;
    private QueryResult undecidedEventRelationsField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public QueryResult AcceptedEventRelations
    {
      get => this.acceptedEventRelationsField;
      set => this.acceptedEventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account Account
    {
      get => this.accountField;
      set => this.accountField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AccountContactRoles
    {
      get => this.accountContactRolesField;
      set => this.accountContactRolesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AccountId
    {
      get => this.accountIdField;
      set => this.accountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Assets
    {
      get => this.assetsField;
      set => this.assetsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AssistantName
    {
      get => this.assistantNameField;
      set => this.assistantNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AssistantPhone
    {
      get => this.assistantPhoneField;
      set => this.assistantPhoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Attachments
    {
      get => this.attachmentsField;
      set => this.attachmentsField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Birthdate
    {
      get => this.birthdateField;
      set => this.birthdateField = value;
    }

    [XmlIgnore]
    public bool BirthdateSpecified
    {
      get => this.birthdateFieldSpecified;
      set => this.birthdateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CampaignMembers
    {
      get => this.campaignMembersField;
      set => this.campaignMembersField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CaseContactRoles
    {
      get => this.caseContactRolesField;
      set => this.caseContactRolesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Cases
    {
      get => this.casesField;
      set => this.casesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContractContactRoles
    {
      get => this.contractContactRolesField;
      set => this.contractContactRolesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContractsSigned
    {
      get => this.contractsSignedField;
      set => this.contractsSignedField = value;
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
    public QueryResult DeclinedEventRelations
    {
      get => this.declinedEventRelationsField;
      set => this.declinedEventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Department
    {
      get => this.departmentField;
      set => this.departmentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Email
    {
      get => this.emailField;
      set => this.emailField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? EmailBouncedDate
    {
      get => this.emailBouncedDateField;
      set => this.emailBouncedDateField = value;
    }

    [XmlIgnore]
    public bool EmailBouncedDateSpecified
    {
      get => this.emailBouncedDateFieldSpecified;
      set => this.emailBouncedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string EmailBouncedReason
    {
      get => this.emailBouncedReasonField;
      set => this.emailBouncedReasonField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult EmailMessageRelations
    {
      get => this.emailMessageRelationsField;
      set => this.emailMessageRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult EmailStatuses
    {
      get => this.emailStatusesField;
      set => this.emailStatusesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult EventRelations
    {
      get => this.eventRelationsField;
      set => this.eventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Events
    {
      get => this.eventsField;
      set => this.eventsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Fax
    {
      get => this.faxField;
      set => this.faxField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Feeds
    {
      get => this.feedsField;
      set => this.feedsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FirstName
    {
      get => this.firstNameField;
      set => this.firstNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string HomePhone
    {
      get => this.homePhoneField;
      set => this.homePhoneField = value;
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
    public bool? IsEmailBounced
    {
      get => this.isEmailBouncedField;
      set => this.isEmailBouncedField = value;
    }

    [XmlIgnore]
    public bool IsEmailBouncedSpecified
    {
      get => this.isEmailBouncedFieldSpecified;
      set => this.isEmailBouncedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Jigsaw
    {
      get => this.jigsawField;
      set => this.jigsawField = value;
    }

    [XmlElement(IsNullable = true)]
    public string JigsawContactId
    {
      get => this.jigsawContactIdField;
      set => this.jigsawContactIdField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? LastActivityDate
    {
      get => this.lastActivityDateField;
      set => this.lastActivityDateField = value;
    }

    [XmlIgnore]
    public bool LastActivityDateSpecified
    {
      get => this.lastActivityDateFieldSpecified;
      set => this.lastActivityDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastCURequestDate
    {
      get => this.lastCURequestDateField;
      set => this.lastCURequestDateField = value;
    }

    [XmlIgnore]
    public bool LastCURequestDateSpecified
    {
      get => this.lastCURequestDateFieldSpecified;
      set => this.lastCURequestDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastCUUpdateDate
    {
      get => this.lastCUUpdateDateField;
      set => this.lastCUUpdateDateField = value;
    }

    [XmlIgnore]
    public bool LastCUUpdateDateSpecified
    {
      get => this.lastCUUpdateDateFieldSpecified;
      set => this.lastCUUpdateDateFieldSpecified = value;
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
    public string LeadSource
    {
      get => this.leadSourceField;
      set => this.leadSourceField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public address MailingAddress
    {
      get => this.mailingAddressField;
      set => this.mailingAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MailingCity
    {
      get => this.mailingCityField;
      set => this.mailingCityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MailingCountry
    {
      get => this.mailingCountryField;
      set => this.mailingCountryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MailingGeocodeAccuracy
    {
      get => this.mailingGeocodeAccuracyField;
      set => this.mailingGeocodeAccuracyField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MailingLatitude
    {
      get => this.mailingLatitudeField;
      set => this.mailingLatitudeField = value;
    }

    [XmlIgnore]
    public bool MailingLatitudeSpecified
    {
      get => this.mailingLatitudeFieldSpecified;
      set => this.mailingLatitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MailingLongitude
    {
      get => this.mailingLongitudeField;
      set => this.mailingLongitudeField = value;
    }

    [XmlIgnore]
    public bool MailingLongitudeSpecified
    {
      get => this.mailingLongitudeFieldSpecified;
      set => this.mailingLongitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MailingPostalCode
    {
      get => this.mailingPostalCodeField;
      set => this.mailingPostalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MailingState
    {
      get => this.mailingStateField;
      set => this.mailingStateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MailingStreet
    {
      get => this.mailingStreetField;
      set => this.mailingStreetField = value;
    }

    [XmlElement(IsNullable = true)]
    public Contact MasterRecord
    {
      get => this.masterRecordField;
      set => this.masterRecordField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MasterRecordId
    {
      get => this.masterRecordIdField;
      set => this.masterRecordIdField = value;
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
    public QueryResult Notes
    {
      get => this.notesField;
      set => this.notesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult NotesAndAttachments
    {
      get => this.notesAndAttachmentsField;
      set => this.notesAndAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Opportunities
    {
      get => this.opportunitiesField;
      set => this.opportunitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpportunityContactRoles
    {
      get => this.opportunityContactRolesField;
      set => this.opportunityContactRolesField = value;
    }

    [XmlElement(IsNullable = true)]
    public address OtherAddress
    {
      get => this.otherAddressField;
      set => this.otherAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OtherCity
    {
      get => this.otherCityField;
      set => this.otherCityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OtherCountry
    {
      get => this.otherCountryField;
      set => this.otherCountryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OtherGeocodeAccuracy
    {
      get => this.otherGeocodeAccuracyField;
      set => this.otherGeocodeAccuracyField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? OtherLatitude
    {
      get => this.otherLatitudeField;
      set => this.otherLatitudeField = value;
    }

    [XmlIgnore]
    public bool OtherLatitudeSpecified
    {
      get => this.otherLatitudeFieldSpecified;
      set => this.otherLatitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? OtherLongitude
    {
      get => this.otherLongitudeField;
      set => this.otherLongitudeField = value;
    }

    [XmlIgnore]
    public bool OtherLongitudeSpecified
    {
      get => this.otherLongitudeFieldSpecified;
      set => this.otherLongitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string OtherPhone
    {
      get => this.otherPhoneField;
      set => this.otherPhoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OtherPostalCode
    {
      get => this.otherPostalCodeField;
      set => this.otherPostalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OtherState
    {
      get => this.otherStateField;
      set => this.otherStateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OtherStreet
    {
      get => this.otherStreetField;
      set => this.otherStreetField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OutgoingEmailRelations
    {
      get => this.outgoingEmailRelationsField;
      set => this.outgoingEmailRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public User Owner
    {
      get => this.ownerField;
      set => this.ownerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OwnerId
    {
      get => this.ownerIdField;
      set => this.ownerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Personas
    {
      get => this.personasField;
      set => this.personasField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Phone
    {
      get => this.phoneField;
      set => this.phoneField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PhotoUrl
    {
      get => this.photoUrlField;
      set => this.photoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Posts
    {
      get => this.postsField;
      set => this.postsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessInstances
    {
      get => this.processInstancesField;
      set => this.processInstancesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessSteps
    {
      get => this.processStepsField;
      set => this.processStepsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Contact ReportsTo
    {
      get => this.reportsToField;
      set => this.reportsToField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ReportsToId
    {
      get => this.reportsToIdField;
      set => this.reportsToIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Salutation
    {
      get => this.salutationField;
      set => this.salutationField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Shares
    {
      get => this.sharesField;
      set => this.sharesField = value;
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
    public QueryResult Tasks
    {
      get => this.tasksField;
      set => this.tasksField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult UndecidedEventRelations
    {
      get => this.undecidedEventRelationsField;
      set => this.undecidedEventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
