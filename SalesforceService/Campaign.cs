// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Campaign
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class Campaign : sObject
  {
    private QueryResult activityHistoriesField;
    private double? actualCostField;
    private bool actualCostFieldSpecified;
    private double? amountAllOpportunitiesField;
    private bool amountAllOpportunitiesFieldSpecified;
    private double? amountWonOpportunitiesField;
    private bool amountWonOpportunitiesFieldSpecified;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private double? budgetedCostField;
    private bool budgetedCostFieldSpecified;
    private RecordType campaignMemberRecordTypeField;
    private string campaignMemberRecordTypeIdField;
    private QueryResult campaignMemberStatusesField;
    private QueryResult campaignMembersField;
    private QueryResult childCampaignsField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private QueryResult emailsField;
    private DateTime? endDateField;
    private bool endDateFieldSpecified;
    private QueryResult eventsField;
    private double? expectedResponseField;
    private bool expectedResponseFieldSpecified;
    private double? expectedRevenueField;
    private bool expectedRevenueFieldSpecified;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private DateTime? lastActivityDateField;
    private bool lastActivityDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private QueryResult leadsField;
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private int? numberOfContactsField;
    private bool numberOfContactsFieldSpecified;
    private int? numberOfConvertedLeadsField;
    private bool numberOfConvertedLeadsFieldSpecified;
    private int? numberOfLeadsField;
    private bool numberOfLeadsFieldSpecified;
    private int? numberOfOpportunitiesField;
    private bool numberOfOpportunitiesFieldSpecified;
    private int? numberOfResponsesField;
    private bool numberOfResponsesFieldSpecified;
    private int? numberOfWonOpportunitiesField;
    private bool numberOfWonOpportunitiesFieldSpecified;
    private double? numberSentField;
    private bool numberSentFieldSpecified;
    private QueryResult openActivitiesField;
    private QueryResult opportunitiesField;
    private User ownerField;
    private string ownerIdField;
    private Campaign parentField;
    private string parentIdField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private QueryResult sharesField;
    private DateTime? startDateField;
    private bool startDateFieldSpecified;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private string typeField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ActualCost
    {
      get => this.actualCostField;
      set => this.actualCostField = value;
    }

    [XmlIgnore]
    public bool ActualCostSpecified
    {
      get => this.actualCostFieldSpecified;
      set => this.actualCostFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AmountAllOpportunities
    {
      get => this.amountAllOpportunitiesField;
      set => this.amountAllOpportunitiesField = value;
    }

    [XmlIgnore]
    public bool AmountAllOpportunitiesSpecified
    {
      get => this.amountAllOpportunitiesFieldSpecified;
      set => this.amountAllOpportunitiesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AmountWonOpportunities
    {
      get => this.amountWonOpportunitiesField;
      set => this.amountWonOpportunitiesField = value;
    }

    [XmlIgnore]
    public bool AmountWonOpportunitiesSpecified
    {
      get => this.amountWonOpportunitiesFieldSpecified;
      set => this.amountWonOpportunitiesFieldSpecified = value;
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
    public double? BudgetedCost
    {
      get => this.budgetedCostField;
      set => this.budgetedCostField = value;
    }

    [XmlIgnore]
    public bool BudgetedCostSpecified
    {
      get => this.budgetedCostFieldSpecified;
      set => this.budgetedCostFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public RecordType CampaignMemberRecordType
    {
      get => this.campaignMemberRecordTypeField;
      set => this.campaignMemberRecordTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CampaignMemberRecordTypeId
    {
      get => this.campaignMemberRecordTypeIdField;
      set => this.campaignMemberRecordTypeIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CampaignMemberStatuses
    {
      get => this.campaignMemberStatusesField;
      set => this.campaignMemberStatusesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CampaignMembers
    {
      get => this.campaignMembersField;
      set => this.campaignMembersField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ChildCampaigns
    {
      get => this.childCampaignsField;
      set => this.childCampaignsField = value;
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
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? EndDate
    {
      get => this.endDateField;
      set => this.endDateField = value;
    }

    [XmlIgnore]
    public bool EndDateSpecified
    {
      get => this.endDateFieldSpecified;
      set => this.endDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Events
    {
      get => this.eventsField;
      set => this.eventsField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ExpectedResponse
    {
      get => this.expectedResponseField;
      set => this.expectedResponseField = value;
    }

    [XmlIgnore]
    public bool ExpectedResponseSpecified
    {
      get => this.expectedResponseFieldSpecified;
      set => this.expectedResponseFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ExpectedRevenue
    {
      get => this.expectedRevenueField;
      set => this.expectedRevenueField = value;
    }

    [XmlIgnore]
    public bool ExpectedRevenueSpecified
    {
      get => this.expectedRevenueFieldSpecified;
      set => this.expectedRevenueFieldSpecified = value;
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
    public QueryResult Leads
    {
      get => this.leadsField;
      set => this.leadsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfContacts
    {
      get => this.numberOfContactsField;
      set => this.numberOfContactsField = value;
    }

    [XmlIgnore]
    public bool NumberOfContactsSpecified
    {
      get => this.numberOfContactsFieldSpecified;
      set => this.numberOfContactsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfConvertedLeads
    {
      get => this.numberOfConvertedLeadsField;
      set => this.numberOfConvertedLeadsField = value;
    }

    [XmlIgnore]
    public bool NumberOfConvertedLeadsSpecified
    {
      get => this.numberOfConvertedLeadsFieldSpecified;
      set => this.numberOfConvertedLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfLeads
    {
      get => this.numberOfLeadsField;
      set => this.numberOfLeadsField = value;
    }

    [XmlIgnore]
    public bool NumberOfLeadsSpecified
    {
      get => this.numberOfLeadsFieldSpecified;
      set => this.numberOfLeadsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfOpportunities
    {
      get => this.numberOfOpportunitiesField;
      set => this.numberOfOpportunitiesField = value;
    }

    [XmlIgnore]
    public bool NumberOfOpportunitiesSpecified
    {
      get => this.numberOfOpportunitiesFieldSpecified;
      set => this.numberOfOpportunitiesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfResponses
    {
      get => this.numberOfResponsesField;
      set => this.numberOfResponsesField = value;
    }

    [XmlIgnore]
    public bool NumberOfResponsesSpecified
    {
      get => this.numberOfResponsesFieldSpecified;
      set => this.numberOfResponsesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfWonOpportunities
    {
      get => this.numberOfWonOpportunitiesField;
      set => this.numberOfWonOpportunitiesField = value;
    }

    [XmlIgnore]
    public bool NumberOfWonOpportunitiesSpecified
    {
      get => this.numberOfWonOpportunitiesFieldSpecified;
      set => this.numberOfWonOpportunitiesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NumberSent
    {
      get => this.numberSentField;
      set => this.numberSentField = value;
    }

    [XmlIgnore]
    public bool NumberSentSpecified
    {
      get => this.numberSentFieldSpecified;
      set => this.numberSentFieldSpecified = value;
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
    public Campaign Parent
    {
      get => this.parentField;
      set => this.parentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentId
    {
      get => this.parentIdField;
      set => this.parentIdField = value;
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
    public QueryResult Shares
    {
      get => this.sharesField;
      set => this.sharesField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? StartDate
    {
      get => this.startDateField;
      set => this.startDateField = value;
    }

    [XmlIgnore]
    public bool StartDateSpecified
    {
      get => this.startDateFieldSpecified;
      set => this.startDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
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
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
