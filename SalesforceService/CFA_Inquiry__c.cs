// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.CFA_Inquiry__c
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
  public class CFA_Inquiry__c : sObject
  {
    private string aLOC__cField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string cCNA__cField;
    private string cC__cField;
    private string cKR__cField;
    private double? channel_Id__cField;
    private bool channel_Id__cFieldSpecified;
    private string channel__cField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string dD__cField;
    private QueryResult duplicateRecordItemsField;
    private string eCCKT__cField;
    private QueryResult emailsField;
    private string error__cField;
    private string fACDESG__cField;
    private string fACTYPE__cField;
    private QueryResult feedSubscriptionsForEntityField;
    private string iRI__cField;
    private string iRM__cField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private double? message_Id__cField;
    private bool message_Id__cFieldSpecified;
    private string message_Time_Stamp__cField;
    private string nCI__cField;
    private string nC__cField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private string pA__cField;
    private string pON__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private string sTATUS__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;
    private string zLOC__cField;

    [XmlElement(IsNullable = true)]
    public string ALOC__c
    {
      get => this.aLOC__cField;
      set => this.aLOC__cField = value;
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
    public string CCNA__c
    {
      get => this.cCNA__cField;
      set => this.cCNA__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CC__c
    {
      get => this.cC__cField;
      set => this.cC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CKR__c
    {
      get => this.cKR__cField;
      set => this.cKR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Channel_Id__c
    {
      get => this.channel_Id__cField;
      set => this.channel_Id__cField = value;
    }

    [XmlIgnore]
    public bool Channel_Id__cSpecified
    {
      get => this.channel_Id__cFieldSpecified;
      set => this.channel_Id__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Channel__c
    {
      get => this.channel__cField;
      set => this.channel__cField = value;
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
    public string DD__c
    {
      get => this.dD__cField;
      set => this.dD__cField = value;
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
    public QueryResult Emails
    {
      get => this.emailsField;
      set => this.emailsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Error__c
    {
      get => this.error__cField;
      set => this.error__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FACDESG__c
    {
      get => this.fACDESG__cField;
      set => this.fACDESG__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FACTYPE__c
    {
      get => this.fACTYPE__cField;
      set => this.fACTYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IRI__c
    {
      get => this.iRI__cField;
      set => this.iRI__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IRM__c
    {
      get => this.iRM__cField;
      set => this.iRM__cField = value;
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
    public double? Message_Id__c
    {
      get => this.message_Id__cField;
      set => this.message_Id__cField = value;
    }

    [XmlIgnore]
    public bool Message_Id__cSpecified
    {
      get => this.message_Id__cFieldSpecified;
      set => this.message_Id__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Message_Time_Stamp__c
    {
      get => this.message_Time_Stamp__cField;
      set => this.message_Time_Stamp__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NCI__c
    {
      get => this.nCI__cField;
      set => this.nCI__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NC__c
    {
      get => this.nC__cField;
      set => this.nC__cField = value;
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
    public string PA__c
    {
      get => this.pA__cField;
      set => this.pA__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PON__c
    {
      get => this.pON__cField;
      set => this.pON__cField = value;
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
    public string STATUS__c
    {
      get => this.sTATUS__cField;
      set => this.sTATUS__cField = value;
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

    [XmlElement(IsNullable = true)]
    public string ZLOC__c
    {
      get => this.zLOC__cField;
      set => this.zLOC__cField = value;
    }
  }
}
