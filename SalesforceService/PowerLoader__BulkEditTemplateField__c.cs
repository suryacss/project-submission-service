// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PowerLoader__BulkEditTemplateField__c
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class PowerLoader__BulkEditTemplateField__c : sObject
  {
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
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string powerLoader__BulkEditTemplate__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.PowerLoader__BulkEditTemplate__c powerLoader__BulkEditTemplate__rField;
    private double? powerLoader__FieldOrder__cField;
    private bool powerLoader__FieldOrder__cFieldSpecified;
    private bool? powerLoader__Group__cField;
    private bool powerLoader__Group__cFieldSpecified;
    private bool? powerLoader__SplitAt__cField;
    private bool powerLoader__SplitAt__cFieldSpecified;
    private string powerLoader__SummaryType__cField;
    private double? powerLoader__Width__cField;
    private bool powerLoader__Width__cFieldSpecified;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult topicAssignmentsField;
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
    public string PowerLoader__BulkEditTemplate__c
    {
      get => this.powerLoader__BulkEditTemplate__cField;
      set => this.powerLoader__BulkEditTemplate__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.PowerLoader__BulkEditTemplate__c PowerLoader__BulkEditTemplate__r
    {
      get => this.powerLoader__BulkEditTemplate__rField;
      set => this.powerLoader__BulkEditTemplate__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PowerLoader__FieldOrder__c
    {
      get => this.powerLoader__FieldOrder__cField;
      set => this.powerLoader__FieldOrder__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__FieldOrder__cSpecified
    {
      get => this.powerLoader__FieldOrder__cFieldSpecified;
      set => this.powerLoader__FieldOrder__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PowerLoader__Group__c
    {
      get => this.powerLoader__Group__cField;
      set => this.powerLoader__Group__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__Group__cSpecified
    {
      get => this.powerLoader__Group__cFieldSpecified;
      set => this.powerLoader__Group__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PowerLoader__SplitAt__c
    {
      get => this.powerLoader__SplitAt__cField;
      set => this.powerLoader__SplitAt__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__SplitAt__cSpecified
    {
      get => this.powerLoader__SplitAt__cFieldSpecified;
      set => this.powerLoader__SplitAt__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__SummaryType__c
    {
      get => this.powerLoader__SummaryType__cField;
      set => this.powerLoader__SummaryType__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PowerLoader__Width__c
    {
      get => this.powerLoader__Width__cField;
      set => this.powerLoader__Width__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__Width__cSpecified
    {
      get => this.powerLoader__Width__cFieldSpecified;
      set => this.powerLoader__Width__cFieldSpecified = value;
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
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
