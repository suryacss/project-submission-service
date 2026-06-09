// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.CHANNEL__c
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
  public class CHANNEL__c : sObject
  {
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bANDWIDTH_CD__cField;
    private double? cHANNEL_BEGIN_POSITION_NBR__cField;
    private bool cHANNEL_BEGIN_POSITION_NBR__cFieldSpecified;
    private string cHANNEL_CNCT_NAME__cField;
    private string cHANNEL_KEY_ID__cField;
    private double? cHANNEL_POSITION_NBR__cField;
    private bool cHANNEL_POSITION_NBR__cFieldSpecified;
    private string cONSUMING_ICCKT_AML_ID__cField;
    private ICCKT__c cONSUMING_ICCKT_AML_ID__rField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private DateTime? dW_CREATE_DT__cField;
    private bool dW_CREATE_DT__cFieldSpecified;
    private string dW_DELETED_IND__cField;
    private string dW_HASHCODE_TXT__cField;
    private DateTime? dW_LAST_MODIFY_DT__cField;
    private bool dW_LAST_MODIFY_DT__cFieldSpecified;
    private string dW_SOURCE_SYSTEM_CD__cField;
    private QueryResult duplicateRecordItemsField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult historiesField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string lINK_CNCT_ODS_ID__cField;
    private DateTime? lastActivityDateField;
    private bool lastActivityDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private QueryResult openActivitiesField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private string pROVIDING_ICCKT_AML_ID__cField;
    private ICCKT__c pROVIDING_ICCKT_AML_ID__rField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private DateTime? sOURCE_CREATE_DT__cField;
    private bool sOURCE_CREATE_DT__cFieldSpecified;
    private DateTime? sOURCE_LAST_MODIFY_DT__cField;
    private bool sOURCE_LAST_MODIFY_DT__cFieldSpecified;
    private string sOURCE_LAST_MODIFY_USER_ID__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;

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
    public string BANDWIDTH_CD__c
    {
      get => this.bANDWIDTH_CD__cField;
      set => this.bANDWIDTH_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CHANNEL_BEGIN_POSITION_NBR__c
    {
      get => this.cHANNEL_BEGIN_POSITION_NBR__cField;
      set => this.cHANNEL_BEGIN_POSITION_NBR__cField = value;
    }

    [XmlIgnore]
    public bool CHANNEL_BEGIN_POSITION_NBR__cSpecified
    {
      get => this.cHANNEL_BEGIN_POSITION_NBR__cFieldSpecified;
      set => this.cHANNEL_BEGIN_POSITION_NBR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CHANNEL_CNCT_NAME__c
    {
      get => this.cHANNEL_CNCT_NAME__cField;
      set => this.cHANNEL_CNCT_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CHANNEL_KEY_ID__c
    {
      get => this.cHANNEL_KEY_ID__cField;
      set => this.cHANNEL_KEY_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CHANNEL_POSITION_NBR__c
    {
      get => this.cHANNEL_POSITION_NBR__cField;
      set => this.cHANNEL_POSITION_NBR__cField = value;
    }

    [XmlIgnore]
    public bool CHANNEL_POSITION_NBR__cSpecified
    {
      get => this.cHANNEL_POSITION_NBR__cFieldSpecified;
      set => this.cHANNEL_POSITION_NBR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CONSUMING_ICCKT_AML_ID__c
    {
      get => this.cONSUMING_ICCKT_AML_ID__cField;
      set => this.cONSUMING_ICCKT_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ICCKT__c CONSUMING_ICCKT_AML_ID__r
    {
      get => this.cONSUMING_ICCKT_AML_ID__rField;
      set => this.cONSUMING_ICCKT_AML_ID__rField = value;
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
    public DateTime? DW_CREATE_DT__c
    {
      get => this.dW_CREATE_DT__cField;
      set => this.dW_CREATE_DT__cField = value;
    }

    [XmlIgnore]
    public bool DW_CREATE_DT__cSpecified
    {
      get => this.dW_CREATE_DT__cFieldSpecified;
      set => this.dW_CREATE_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string DW_DELETED_IND__c
    {
      get => this.dW_DELETED_IND__cField;
      set => this.dW_DELETED_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DW_HASHCODE_TXT__c
    {
      get => this.dW_HASHCODE_TXT__cField;
      set => this.dW_HASHCODE_TXT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? DW_LAST_MODIFY_DT__c
    {
      get => this.dW_LAST_MODIFY_DT__cField;
      set => this.dW_LAST_MODIFY_DT__cField = value;
    }

    [XmlIgnore]
    public bool DW_LAST_MODIFY_DT__cSpecified
    {
      get => this.dW_LAST_MODIFY_DT__cFieldSpecified;
      set => this.dW_LAST_MODIFY_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string DW_SOURCE_SYSTEM_CD__c
    {
      get => this.dW_SOURCE_SYSTEM_CD__cField;
      set => this.dW_SOURCE_SYSTEM_CD__cField = value;
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

    [XmlElement(IsNullable = true)]
    public string LINK_CNCT_ODS_ID__c
    {
      get => this.lINK_CNCT_ODS_ID__cField;
      set => this.lINK_CNCT_ODS_ID__cField = value;
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
    public string PROVIDING_ICCKT_AML_ID__c
    {
      get => this.pROVIDING_ICCKT_AML_ID__cField;
      set => this.pROVIDING_ICCKT_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ICCKT__c PROVIDING_ICCKT_AML_ID__r
    {
      get => this.pROVIDING_ICCKT_AML_ID__rField;
      set => this.pROVIDING_ICCKT_AML_ID__rField = value;
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
    public DateTime? SOURCE_CREATE_DT__c
    {
      get => this.sOURCE_CREATE_DT__cField;
      set => this.sOURCE_CREATE_DT__cField = value;
    }

    [XmlIgnore]
    public bool SOURCE_CREATE_DT__cSpecified
    {
      get => this.sOURCE_CREATE_DT__cFieldSpecified;
      set => this.sOURCE_CREATE_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SOURCE_LAST_MODIFY_DT__c
    {
      get => this.sOURCE_LAST_MODIFY_DT__cField;
      set => this.sOURCE_LAST_MODIFY_DT__cField = value;
    }

    [XmlIgnore]
    public bool SOURCE_LAST_MODIFY_DT__cSpecified
    {
      get => this.sOURCE_LAST_MODIFY_DT__cFieldSpecified;
      set => this.sOURCE_LAST_MODIFY_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SOURCE_LAST_MODIFY_USER_ID__c
    {
      get => this.sOURCE_LAST_MODIFY_USER_ID__cField;
      set => this.sOURCE_LAST_MODIFY_USER_ID__cField = value;
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
