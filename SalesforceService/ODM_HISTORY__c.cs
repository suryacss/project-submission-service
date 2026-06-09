// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ODM_HISTORY__c
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class ODM_HISTORY__c : sObject
  {
    private string aCC_CAR_ID_NEW__cField;
    private string aCC_CAR_ID_OLD__cField;
    private string aCC_CAR_NAME_NEW__cField;
    private string aCC_CAR_NAME_OLD__cField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private string eCCKT_AML_ID__cField;
    private QueryResult emailsField;
    private QueryResult feedSubscriptionsForEntityField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private DateTime? lAST_MODIFY_DATE__cField;
    private bool lAST_MODIFY_DATE__cFieldSpecified;
    private string lAST_MODIFY_USERID__cField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string oDM_LENGTH_OF_TERM_NEW__cField;
    private string oDM_LENGTH_OF_TERM_OLD__cField;
    private string oDM_TERM_AGREE_END_DATE_NEW__cField;
    private string oDM_TERM_AGREE_END_DATE_OLD__cField;
    private string oDM_TERM_AGREE_START_DATE_NEW__cField;
    private string oDM_TERM_AGREE_START_DATE_OLD__cField;
    private string oDM_TERM_STATUS_NEW__cField;
    private string oDM_TERM_STATUS_OLD__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private string sYSTEM_ID__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public string ACC_CAR_ID_NEW__c
    {
      get => this.aCC_CAR_ID_NEW__cField;
      set => this.aCC_CAR_ID_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACC_CAR_ID_OLD__c
    {
      get => this.aCC_CAR_ID_OLD__cField;
      set => this.aCC_CAR_ID_OLD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACC_CAR_NAME_NEW__c
    {
      get => this.aCC_CAR_NAME_NEW__cField;
      set => this.aCC_CAR_NAME_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACC_CAR_NAME_OLD__c
    {
      get => this.aCC_CAR_NAME_OLD__cField;
      set => this.aCC_CAR_NAME_OLD__cField = value;
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
    public string ECCKT_AML_ID__c
    {
      get => this.eCCKT_AML_ID__cField;
      set => this.eCCKT_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
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
    public DateTime? LAST_MODIFY_DATE__c
    {
      get => this.lAST_MODIFY_DATE__cField;
      set => this.lAST_MODIFY_DATE__cField = value;
    }

    [XmlIgnore]
    public bool LAST_MODIFY_DATE__cSpecified
    {
      get => this.lAST_MODIFY_DATE__cFieldSpecified;
      set => this.lAST_MODIFY_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LAST_MODIFY_USERID__c
    {
      get => this.lAST_MODIFY_USERID__cField;
      set => this.lAST_MODIFY_USERID__cField = value;
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
    public string ODM_LENGTH_OF_TERM_NEW__c
    {
      get => this.oDM_LENGTH_OF_TERM_NEW__cField;
      set => this.oDM_LENGTH_OF_TERM_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_LENGTH_OF_TERM_OLD__c
    {
      get => this.oDM_LENGTH_OF_TERM_OLD__cField;
      set => this.oDM_LENGTH_OF_TERM_OLD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_TERM_AGREE_END_DATE_NEW__c
    {
      get => this.oDM_TERM_AGREE_END_DATE_NEW__cField;
      set => this.oDM_TERM_AGREE_END_DATE_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_TERM_AGREE_END_DATE_OLD__c
    {
      get => this.oDM_TERM_AGREE_END_DATE_OLD__cField;
      set => this.oDM_TERM_AGREE_END_DATE_OLD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_TERM_AGREE_START_DATE_NEW__c
    {
      get => this.oDM_TERM_AGREE_START_DATE_NEW__cField;
      set => this.oDM_TERM_AGREE_START_DATE_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_TERM_AGREE_START_DATE_OLD__c
    {
      get => this.oDM_TERM_AGREE_START_DATE_OLD__cField;
      set => this.oDM_TERM_AGREE_START_DATE_OLD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_TERM_STATUS_NEW__c
    {
      get => this.oDM_TERM_STATUS_NEW__cField;
      set => this.oDM_TERM_STATUS_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_TERM_STATUS_OLD__c
    {
      get => this.oDM_TERM_STATUS_OLD__cField;
      set => this.oDM_TERM_STATUS_OLD__cField = value;
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
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SYSTEM_ID__c
    {
      get => this.sYSTEM_ID__cField;
      set => this.sYSTEM_ID__cField = value;
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
