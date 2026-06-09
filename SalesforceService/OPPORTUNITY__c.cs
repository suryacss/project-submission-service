// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OPPORTUNITY__c
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class OPPORTUNITY__c : sObject
  {
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string cIRCUIT_TYPE__cField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private string eCCKT__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.ECCKT__c eCCKT__rField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private DateTime? gL_CODE_PROVIDED_DATE__cField;
    private bool gL_CODE_PROVIDED_DATE__cFieldSpecified;
    private string gL_CODE_PROVIDED__cField;
    private string gL_CODE_SUGGESTED__cField;
    private string gL_CODE__cField;
    private QueryResult historiesField;
    private string iCCKT__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.ICCKT__c iCCKT__rField;
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
    private double? mRC__cField;
    private bool mRC__cFieldSpecified;
    private string mRP2__cField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string oPPORTUNITY_MANAGER__cField;
    private QueryResult openActivitiesField;
    private string opportunity_Type__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private string pROJECT_ID__cField;
    private PROJECT_HEADER__c pROJECT_ID__rField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string rECOMMENDED_GROOM_TO_LOCATION__cField;
    private QueryResult recordAssociatedGroupsField;
    private double? sAVINGS_MRC__cField;
    private bool sAVINGS_MRC__cFieldSpecified;
    private string sWC_A_LOC__cField;
    private string sWC_Z_LOC__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private string uTILIZATION_TYPE__cField;
    private double? uTILIZATION__cField;
    private bool uTILIZATION__cFieldSpecified;
    private UserRecordAccess userRecordAccessField;
    private string vENDOR__cField;
    private Account vENDOR__rField;

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
    public string CIRCUIT_TYPE__c
    {
      get => this.cIRCUIT_TYPE__cField;
      set => this.cIRCUIT_TYPE__cField = value;
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
    public string ECCKT__c
    {
      get => this.eCCKT__cField;
      set => this.eCCKT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.ECCKT__c ECCKT__r
    {
      get => this.eCCKT__rField;
      set => this.eCCKT__rField = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? GL_CODE_PROVIDED_DATE__c
    {
      get => this.gL_CODE_PROVIDED_DATE__cField;
      set => this.gL_CODE_PROVIDED_DATE__cField = value;
    }

    [XmlIgnore]
    public bool GL_CODE_PROVIDED_DATE__cSpecified
    {
      get => this.gL_CODE_PROVIDED_DATE__cFieldSpecified;
      set => this.gL_CODE_PROVIDED_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string GL_CODE_PROVIDED__c
    {
      get => this.gL_CODE_PROVIDED__cField;
      set => this.gL_CODE_PROVIDED__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GL_CODE_SUGGESTED__c
    {
      get => this.gL_CODE_SUGGESTED__cField;
      set => this.gL_CODE_SUGGESTED__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GL_CODE__c
    {
      get => this.gL_CODE__cField;
      set => this.gL_CODE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT__c
    {
      get => this.iCCKT__cField;
      set => this.iCCKT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.ICCKT__c ICCKT__r
    {
      get => this.iCCKT__rField;
      set => this.iCCKT__rField = value;
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
    public double? MRC__c
    {
      get => this.mRC__cField;
      set => this.mRC__cField = value;
    }

    [XmlIgnore]
    public bool MRC__cSpecified
    {
      get => this.mRC__cFieldSpecified;
      set => this.mRC__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MRP2__c
    {
      get => this.mRP2__cField;
      set => this.mRP2__cField = value;
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
    public string OPPORTUNITY_MANAGER__c
    {
      get => this.oPPORTUNITY_MANAGER__cField;
      set => this.oPPORTUNITY_MANAGER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Opportunity_Type__c
    {
      get => this.opportunity_Type__cField;
      set => this.opportunity_Type__cField = value;
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
    public string PROJECT_ID__c
    {
      get => this.pROJECT_ID__cField;
      set => this.pROJECT_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public PROJECT_HEADER__c PROJECT_ID__r
    {
      get => this.pROJECT_ID__rField;
      set => this.pROJECT_ID__rField = value;
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
    public string RECOMMENDED_GROOM_TO_LOCATION__c
    {
      get => this.rECOMMENDED_GROOM_TO_LOCATION__cField;
      set => this.rECOMMENDED_GROOM_TO_LOCATION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SAVINGS_MRC__c
    {
      get => this.sAVINGS_MRC__cField;
      set => this.sAVINGS_MRC__cField = value;
    }

    [XmlIgnore]
    public bool SAVINGS_MRC__cSpecified
    {
      get => this.sAVINGS_MRC__cFieldSpecified;
      set => this.sAVINGS_MRC__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SWC_A_LOC__c
    {
      get => this.sWC_A_LOC__cField;
      set => this.sWC_A_LOC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SWC_Z_LOC__c
    {
      get => this.sWC_Z_LOC__cField;
      set => this.sWC_Z_LOC__cField = value;
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
    public string UTILIZATION_TYPE__c
    {
      get => this.uTILIZATION_TYPE__cField;
      set => this.uTILIZATION_TYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? UTILIZATION__c
    {
      get => this.uTILIZATION__cField;
      set => this.uTILIZATION__cField = value;
    }

    [XmlIgnore]
    public bool UTILIZATION__cSpecified
    {
      get => this.uTILIZATION__cFieldSpecified;
      set => this.uTILIZATION__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR__c
    {
      get => this.vENDOR__cField;
      set => this.vENDOR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account VENDOR__r
    {
      get => this.vENDOR__rField;
      set => this.vENDOR__rField = value;
    }
  }
}
