// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PHOENIX_NOTE__c
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
  public class PHOENIX_NOTE__c : sObject
  {
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string cREATED_BY__cField;
    private DateTime? cREATED_DATE__cField;
    private bool cREATED_DATE__cFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private string eCCKT_AML_ID__cField;
    private ECCKT__c eCCKT_AML_ID__rField;
    private QueryResult emailsField;
    private QueryResult feedSubscriptionsForEntityField;
    private string iCCKT_AML_ID__cField;
    private ICCKT__c iCCKT_AML_ID__rField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private string nOTE_CATEGORY__cField;
    private string nOTE_DETAIL__cField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private string pROJECT_ID__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult topicAssignmentsField;
    private bool? trigger_Flag__cField;
    private bool trigger_Flag__cFieldSpecified;
    private UserRecordAccess userRecordAccessField;

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
    public string CREATED_BY__c
    {
      get => this.cREATED_BY__cField;
      set => this.cREATED_BY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? CREATED_DATE__c
    {
      get => this.cREATED_DATE__cField;
      set => this.cREATED_DATE__cField = value;
    }

    [XmlIgnore]
    public bool CREATED_DATE__cSpecified
    {
      get => this.cREATED_DATE__cFieldSpecified;
      set => this.cREATED_DATE__cFieldSpecified = value;
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
    public ECCKT__c ECCKT_AML_ID__r
    {
      get => this.eCCKT_AML_ID__rField;
      set => this.eCCKT_AML_ID__rField = value;
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
    public string ICCKT_AML_ID__c
    {
      get => this.iCCKT_AML_ID__cField;
      set => this.iCCKT_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ICCKT__c ICCKT_AML_ID__r
    {
      get => this.iCCKT_AML_ID__rField;
      set => this.iCCKT_AML_ID__rField = value;
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
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NOTE_CATEGORY__c
    {
      get => this.nOTE_CATEGORY__cField;
      set => this.nOTE_CATEGORY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NOTE_DETAIL__c
    {
      get => this.nOTE_DETAIL__cField;
      set => this.nOTE_DETAIL__cField = value;
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
    public bool? Trigger_Flag__c
    {
      get => this.trigger_Flag__cField;
      set => this.trigger_Flag__cField = value;
    }

    [XmlIgnore]
    public bool Trigger_Flag__cSpecified
    {
      get => this.trigger_Flag__cFieldSpecified;
      set => this.trigger_Flag__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
