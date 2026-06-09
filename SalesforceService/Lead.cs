// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Lead
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
  public class Lead : sObject
  {
    private QueryResult acceptedEventRelationsField;
    private QueryResult activityHistoriesField;
    private address addressField;
    private double? annualRevenueField;
    private bool annualRevenueFieldSpecified;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private Campaign campaignField;
    private QueryResult campaignMembersField;
    private string cityField;
    private QueryResult combinedAttachmentsField;
    private string companyField;
    private QueryResult contentDocumentLinksField;
    private Account convertedAccountField;
    private string convertedAccountIdField;
    private Contact convertedContactField;
    private string convertedContactIdField;
    private DateTime? convertedDateField;
    private bool convertedDateFieldSpecified;
    private Opportunity convertedOpportunityField;
    private string convertedOpportunityIdField;
    private string countryField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult declinedEventRelationsField;
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
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private string firstNameField;
    private string geocodeAccuracyField;
    private QueryResult historiesField;
    private string industryField;
    private bool? isConvertedField;
    private bool isConvertedFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isUnreadByOwnerField;
    private bool isUnreadByOwnerFieldSpecified;
    private string jigsawField;
    private string jigsawContactIdField;
    private DateTime? lastActivityDateField;
    private bool lastActivityDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string lastNameField;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private double? latitudeField;
    private bool latitudeFieldSpecified;
    private string leadSourceField;
    private double? longitudeField;
    private bool longitudeFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private Lead masterRecordField;
    private string masterRecordIdField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private int? numberOfEmployeesField;
    private bool numberOfEmployeesFieldSpecified;
    private QueryResult openActivitiesField;
    private QueryResult outgoingEmailRelationsField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private QueryResult personasField;
    private string phoneField;
    private string photoUrlField;
    private string postalCodeField;
    private QueryResult postsField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string ratingField;
    private QueryResult recordAssociatedGroupsField;
    private string salutationField;
    private QueryResult sharesField;
    private string stateField;
    private string statusField;
    private string streetField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private string titleField;
    private QueryResult topicAssignmentsField;
    private QueryResult undecidedEventRelationsField;
    private UserRecordAccess userRecordAccessField;
    private string websiteField;

    [XmlElement(IsNullable = true)]
    public QueryResult AcceptedEventRelations
    {
      get => this.acceptedEventRelationsField;
      set => this.acceptedEventRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public address Address
    {
      get => this.addressField;
      set => this.addressField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AnnualRevenue
    {
      get => this.annualRevenueField;
      set => this.annualRevenueField = value;
    }

    [XmlIgnore]
    public bool AnnualRevenueSpecified
    {
      get => this.annualRevenueFieldSpecified;
      set => this.annualRevenueFieldSpecified = value;
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

    [XmlElement(IsNullable = true)]
    public Campaign Campaign
    {
      get => this.campaignField;
      set => this.campaignField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CampaignMembers
    {
      get => this.campaignMembersField;
      set => this.campaignMembersField = value;
    }

    [XmlElement(IsNullable = true)]
    public string City
    {
      get => this.cityField;
      set => this.cityField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Company
    {
      get => this.companyField;
      set => this.companyField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account ConvertedAccount
    {
      get => this.convertedAccountField;
      set => this.convertedAccountField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConvertedAccountId
    {
      get => this.convertedAccountIdField;
      set => this.convertedAccountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public Contact ConvertedContact
    {
      get => this.convertedContactField;
      set => this.convertedContactField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConvertedContactId
    {
      get => this.convertedContactIdField;
      set => this.convertedContactIdField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ConvertedDate
    {
      get => this.convertedDateField;
      set => this.convertedDateField = value;
    }

    [XmlIgnore]
    public bool ConvertedDateSpecified
    {
      get => this.convertedDateFieldSpecified;
      set => this.convertedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public Opportunity ConvertedOpportunity
    {
      get => this.convertedOpportunityField;
      set => this.convertedOpportunityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConvertedOpportunityId
    {
      get => this.convertedOpportunityIdField;
      set => this.convertedOpportunityIdField = value;
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
    public QueryResult DeclinedEventRelations
    {
      get => this.declinedEventRelationsField;
      set => this.declinedEventRelationsField = value;
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
    public string GeocodeAccuracy
    {
      get => this.geocodeAccuracyField;
      set => this.geocodeAccuracyField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Industry
    {
      get => this.industryField;
      set => this.industryField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsConverted
    {
      get => this.isConvertedField;
      set => this.isConvertedField = value;
    }

    [XmlIgnore]
    public bool IsConvertedSpecified
    {
      get => this.isConvertedFieldSpecified;
      set => this.isConvertedFieldSpecified = value;
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
    public bool? IsUnreadByOwner
    {
      get => this.isUnreadByOwnerField;
      set => this.isUnreadByOwnerField = value;
    }

    [XmlIgnore]
    public bool IsUnreadByOwnerSpecified
    {
      get => this.isUnreadByOwnerFieldSpecified;
      set => this.isUnreadByOwnerFieldSpecified = value;
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
    public double? Latitude
    {
      get => this.latitudeField;
      set => this.latitudeField = value;
    }

    [XmlIgnore]
    public bool LatitudeSpecified
    {
      get => this.latitudeFieldSpecified;
      set => this.latitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LeadSource
    {
      get => this.leadSourceField;
      set => this.leadSourceField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Longitude
    {
      get => this.longitudeField;
      set => this.longitudeField = value;
    }

    [XmlIgnore]
    public bool LongitudeSpecified
    {
      get => this.longitudeFieldSpecified;
      set => this.longitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public Lead MasterRecord
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
    public int? NumberOfEmployees
    {
      get => this.numberOfEmployeesField;
      set => this.numberOfEmployeesField = value;
    }

    [XmlIgnore]
    public bool NumberOfEmployeesSpecified
    {
      get => this.numberOfEmployeesFieldSpecified;
      set => this.numberOfEmployeesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OutgoingEmailRelations
    {
      get => this.outgoingEmailRelationsField;
      set => this.outgoingEmailRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name Owner
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
    public string PostalCode
    {
      get => this.postalCodeField;
      set => this.postalCodeField = value;
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
    public string Rating
    {
      get => this.ratingField;
      set => this.ratingField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
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

    [XmlElement(IsNullable = true)]
    public string Website
    {
      get => this.websiteField;
      set => this.websiteField = value;
    }
  }
}
