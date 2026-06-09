// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.REQUEST_FOR_PROPOSAL__c
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
  public class REQUEST_FOR_PROPOSAL__c : sObject
  {
    private QueryResult accounts__rField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult historiesField;
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
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private QueryResult openActivitiesField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string rFP_QUOTE_BANDWIDTH__cField;
    private string rFP_QUOTE_COMMENTS__cField;
    private DateTime? rFP_QUOTE_DATE__cField;
    private bool rFP_QUOTE_DATE__cFieldSpecified;
    private string rFP_QUOTE_ECCKT_AML_ID__cField;
    private ECCKT__c rFP_QUOTE_ECCKT_AML_ID__rField;
    private string rFP_QUOTE_ID__cField;
    private string rFP_QUOTE_INTERNAL_PROJECT_NAME__cField;
    private double? rFP_QUOTE_MRC_VARIANCE__cField;
    private bool rFP_QUOTE_MRC_VARIANCE__cFieldSpecified;
    private double? rFP_QUOTE_MRC__cField;
    private bool rFP_QUOTE_MRC__cFieldSpecified;
    private double? rFP_QUOTE_NRC__cField;
    private bool rFP_QUOTE_NRC__cFieldSpecified;
    private string rFP_QUOTE_PRODUCT__cField;
    private string rFP_QUOTE_STREET_ADDRESS__cField;
    private double? rFP_QUOTE_SUBBANDWIDTH__cField;
    private bool rFP_QUOTE_SUBBANDWIDTH__cFieldSpecified;
    private double? rFP_QUOTE_TERM__cField;
    private bool rFP_QUOTE_TERM__cFieldSpecified;
    private string rFP_QUOTE_VENDOR__cField;
    private Account rFP_QUOTE_VENDOR__rField;
    private string rFP_Quote_Address_State__cField;
    private string rFP_Quote_Address_Zip_Code__cField;
    private string rFP_Quote_City__cField;
    private DateTime? rFP_Quote_Sent_Date__cField;
    private bool rFP_Quote_Sent_Date__cFieldSpecified;
    private DateTime? rFP_Quote_Valid_Through__cField;
    private bool rFP_Quote_Valid_Through__cFieldSpecified;
    private QueryResult recordAssociatedGroupsField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public QueryResult Accounts__r
    {
      get => this.accounts__rField;
      set => this.accounts__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
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
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
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
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
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
    public string RFP_QUOTE_BANDWIDTH__c
    {
      get => this.rFP_QUOTE_BANDWIDTH__cField;
      set => this.rFP_QUOTE_BANDWIDTH__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_QUOTE_COMMENTS__c
    {
      get => this.rFP_QUOTE_COMMENTS__cField;
      set => this.rFP_QUOTE_COMMENTS__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFP_QUOTE_DATE__c
    {
      get => this.rFP_QUOTE_DATE__cField;
      set => this.rFP_QUOTE_DATE__cField = value;
    }

    [XmlIgnore]
    public bool RFP_QUOTE_DATE__cSpecified
    {
      get => this.rFP_QUOTE_DATE__cFieldSpecified;
      set => this.rFP_QUOTE_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_QUOTE_ECCKT_AML_ID__c
    {
      get => this.rFP_QUOTE_ECCKT_AML_ID__cField;
      set => this.rFP_QUOTE_ECCKT_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ECCKT__c RFP_QUOTE_ECCKT_AML_ID__r
    {
      get => this.rFP_QUOTE_ECCKT_AML_ID__rField;
      set => this.rFP_QUOTE_ECCKT_AML_ID__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_QUOTE_ID__c
    {
      get => this.rFP_QUOTE_ID__cField;
      set => this.rFP_QUOTE_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_QUOTE_INTERNAL_PROJECT_NAME__c
    {
      get => this.rFP_QUOTE_INTERNAL_PROJECT_NAME__cField;
      set => this.rFP_QUOTE_INTERNAL_PROJECT_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFP_QUOTE_MRC_VARIANCE__c
    {
      get => this.rFP_QUOTE_MRC_VARIANCE__cField;
      set => this.rFP_QUOTE_MRC_VARIANCE__cField = value;
    }

    [XmlIgnore]
    public bool RFP_QUOTE_MRC_VARIANCE__cSpecified
    {
      get => this.rFP_QUOTE_MRC_VARIANCE__cFieldSpecified;
      set => this.rFP_QUOTE_MRC_VARIANCE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFP_QUOTE_MRC__c
    {
      get => this.rFP_QUOTE_MRC__cField;
      set => this.rFP_QUOTE_MRC__cField = value;
    }

    [XmlIgnore]
    public bool RFP_QUOTE_MRC__cSpecified
    {
      get => this.rFP_QUOTE_MRC__cFieldSpecified;
      set => this.rFP_QUOTE_MRC__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFP_QUOTE_NRC__c
    {
      get => this.rFP_QUOTE_NRC__cField;
      set => this.rFP_QUOTE_NRC__cField = value;
    }

    [XmlIgnore]
    public bool RFP_QUOTE_NRC__cSpecified
    {
      get => this.rFP_QUOTE_NRC__cFieldSpecified;
      set => this.rFP_QUOTE_NRC__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_QUOTE_PRODUCT__c
    {
      get => this.rFP_QUOTE_PRODUCT__cField;
      set => this.rFP_QUOTE_PRODUCT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_QUOTE_STREET_ADDRESS__c
    {
      get => this.rFP_QUOTE_STREET_ADDRESS__cField;
      set => this.rFP_QUOTE_STREET_ADDRESS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFP_QUOTE_SUBBANDWIDTH__c
    {
      get => this.rFP_QUOTE_SUBBANDWIDTH__cField;
      set => this.rFP_QUOTE_SUBBANDWIDTH__cField = value;
    }

    [XmlIgnore]
    public bool RFP_QUOTE_SUBBANDWIDTH__cSpecified
    {
      get => this.rFP_QUOTE_SUBBANDWIDTH__cFieldSpecified;
      set => this.rFP_QUOTE_SUBBANDWIDTH__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFP_QUOTE_TERM__c
    {
      get => this.rFP_QUOTE_TERM__cField;
      set => this.rFP_QUOTE_TERM__cField = value;
    }

    [XmlIgnore]
    public bool RFP_QUOTE_TERM__cSpecified
    {
      get => this.rFP_QUOTE_TERM__cFieldSpecified;
      set => this.rFP_QUOTE_TERM__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_QUOTE_VENDOR__c
    {
      get => this.rFP_QUOTE_VENDOR__cField;
      set => this.rFP_QUOTE_VENDOR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account RFP_QUOTE_VENDOR__r
    {
      get => this.rFP_QUOTE_VENDOR__rField;
      set => this.rFP_QUOTE_VENDOR__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_Quote_Address_State__c
    {
      get => this.rFP_Quote_Address_State__cField;
      set => this.rFP_Quote_Address_State__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_Quote_Address_Zip_Code__c
    {
      get => this.rFP_Quote_Address_Zip_Code__cField;
      set => this.rFP_Quote_Address_Zip_Code__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFP_Quote_City__c
    {
      get => this.rFP_Quote_City__cField;
      set => this.rFP_Quote_City__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFP_Quote_Sent_Date__c
    {
      get => this.rFP_Quote_Sent_Date__cField;
      set => this.rFP_Quote_Sent_Date__cField = value;
    }

    [XmlIgnore]
    public bool RFP_Quote_Sent_Date__cSpecified
    {
      get => this.rFP_Quote_Sent_Date__cFieldSpecified;
      set => this.rFP_Quote_Sent_Date__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFP_Quote_Valid_Through__c
    {
      get => this.rFP_Quote_Valid_Through__cField;
      set => this.rFP_Quote_Valid_Through__cField = value;
    }

    [XmlIgnore]
    public bool RFP_Quote_Valid_Through__cSpecified
    {
      get => this.rFP_Quote_Valid_Through__cFieldSpecified;
      set => this.rFP_Quote_Valid_Through__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
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
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
