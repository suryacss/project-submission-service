// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Opportunity
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class Opportunity : sObject
  {
    private Account accountField;
    private string accountIdField;
    private QueryResult accountPartnersField;
    private QueryResult activityHistoriesField;
    private double? amountField;
    private bool amountFieldSpecified;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private Campaign campaignField;
    private string campaignIdField;
    private DateTime? closeDateField;
    private bool closeDateFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private string fiscalField;
    private int? fiscalQuarterField;
    private bool fiscalQuarterFieldSpecified;
    private int? fiscalYearField;
    private bool fiscalYearFieldSpecified;
    private string forecastCategoryField;
    private string forecastCategoryNameField;
    private bool? hasOpenActivityField;
    private bool hasOpenActivityFieldSpecified;
    private bool? hasOpportunityLineItemField;
    private bool hasOpportunityLineItemFieldSpecified;
    private bool? hasOverdueTaskField;
    private bool hasOverdueTaskFieldSpecified;
    private QueryResult historiesField;
    private bool? isClosedField;
    private bool isClosedFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isWonField;
    private bool isWonFieldSpecified;
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
    private string leadSourceField;
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private string nextStepField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private QueryResult openActivitiesField;
    private QueryResult opportunityCompetitorsField;
    private QueryResult opportunityContactRolesField;
    private QueryResult opportunityHistoriesField;
    private QueryResult opportunityLineItemsField;
    private QueryResult opportunityPartnersFromField;
    private QueryResult ordersField;
    private User ownerField;
    private string ownerIdField;
    private QueryResult partnersField;
    private Pricebook2 pricebook2Field;
    private string pricebook2IdField;
    private double? probabilityField;
    private bool probabilityFieldSpecified;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private QueryResult sharesField;
    private string stageNameField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private string typeField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public Account Account
    {
      get => this.accountField;
      set => this.accountField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AccountId
    {
      get => this.accountIdField;
      set => this.accountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AccountPartners
    {
      get => this.accountPartnersField;
      set => this.accountPartnersField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Amount
    {
      get => this.amountField;
      set => this.amountField = value;
    }

    [XmlIgnore]
    public bool AmountSpecified
    {
      get => this.amountFieldSpecified;
      set => this.amountFieldSpecified = value;
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
    public string CampaignId
    {
      get => this.campaignIdField;
      set => this.campaignIdField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? CloseDate
    {
      get => this.closeDateField;
      set => this.closeDateField = value;
    }

    [XmlIgnore]
    public bool CloseDateSpecified
    {
      get => this.closeDateFieldSpecified;
      set => this.closeDateFieldSpecified = value;
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
    public string Fiscal
    {
      get => this.fiscalField;
      set => this.fiscalField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? FiscalQuarter
    {
      get => this.fiscalQuarterField;
      set => this.fiscalQuarterField = value;
    }

    [XmlIgnore]
    public bool FiscalQuarterSpecified
    {
      get => this.fiscalQuarterFieldSpecified;
      set => this.fiscalQuarterFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? FiscalYear
    {
      get => this.fiscalYearField;
      set => this.fiscalYearField = value;
    }

    [XmlIgnore]
    public bool FiscalYearSpecified
    {
      get => this.fiscalYearFieldSpecified;
      set => this.fiscalYearFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ForecastCategory
    {
      get => this.forecastCategoryField;
      set => this.forecastCategoryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ForecastCategoryName
    {
      get => this.forecastCategoryNameField;
      set => this.forecastCategoryNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasOpenActivity
    {
      get => this.hasOpenActivityField;
      set => this.hasOpenActivityField = value;
    }

    [XmlIgnore]
    public bool HasOpenActivitySpecified
    {
      get => this.hasOpenActivityFieldSpecified;
      set => this.hasOpenActivityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasOpportunityLineItem
    {
      get => this.hasOpportunityLineItemField;
      set => this.hasOpportunityLineItemField = value;
    }

    [XmlIgnore]
    public bool HasOpportunityLineItemSpecified
    {
      get => this.hasOpportunityLineItemFieldSpecified;
      set => this.hasOpportunityLineItemFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasOverdueTask
    {
      get => this.hasOverdueTaskField;
      set => this.hasOverdueTaskField = value;
    }

    [XmlIgnore]
    public bool HasOverdueTaskSpecified
    {
      get => this.hasOverdueTaskFieldSpecified;
      set => this.hasOverdueTaskFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsClosed
    {
      get => this.isClosedField;
      set => this.isClosedField = value;
    }

    [XmlIgnore]
    public bool IsClosedSpecified
    {
      get => this.isClosedFieldSpecified;
      set => this.isClosedFieldSpecified = value;
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
    public bool? IsWon
    {
      get => this.isWonField;
      set => this.isWonField = value;
    }

    [XmlIgnore]
    public bool IsWonSpecified
    {
      get => this.isWonFieldSpecified;
      set => this.isWonFieldSpecified = value;
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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NextStep
    {
      get => this.nextStepField;
      set => this.nextStepField = value;
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
    public QueryResult OpportunityCompetitors
    {
      get => this.opportunityCompetitorsField;
      set => this.opportunityCompetitorsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpportunityContactRoles
    {
      get => this.opportunityContactRolesField;
      set => this.opportunityContactRolesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpportunityHistories
    {
      get => this.opportunityHistoriesField;
      set => this.opportunityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpportunityLineItems
    {
      get => this.opportunityLineItemsField;
      set => this.opportunityLineItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpportunityPartnersFrom
    {
      get => this.opportunityPartnersFromField;
      set => this.opportunityPartnersFromField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Orders
    {
      get => this.ordersField;
      set => this.ordersField = value;
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
    public QueryResult Partners
    {
      get => this.partnersField;
      set => this.partnersField = value;
    }

    [XmlElement(IsNullable = true)]
    public Pricebook2 Pricebook2
    {
      get => this.pricebook2Field;
      set => this.pricebook2Field = value;
    }

    [XmlElement(IsNullable = true)]
    public string Pricebook2Id
    {
      get => this.pricebook2IdField;
      set => this.pricebook2IdField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Probability
    {
      get => this.probabilityField;
      set => this.probabilityField = value;
    }

    [XmlIgnore]
    public bool ProbabilitySpecified
    {
      get => this.probabilityFieldSpecified;
      set => this.probabilityFieldSpecified = value;
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

    [XmlElement(IsNullable = true)]
    public string StageName
    {
      get => this.stageNameField;
      set => this.stageNameField = value;
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
