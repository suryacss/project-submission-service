// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PowerLoader__Query_Parameter__c
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class PowerLoader__Query_Parameter__c : sObject
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
    private string powerLoader__Base_Master_Field_API_Name__cField;
    private string powerLoader__Base_Object_API_Name__cField;
    private string powerLoader__Default_Value_Type__cField;
    private string powerLoader__Default_Value__cField;
    private double? powerLoader__Display_Sequence__cField;
    private bool powerLoader__Display_Sequence__cFieldSpecified;
    private string powerLoader__Display_Type__cField;
    private bool? powerLoader__IsDisabled__cField;
    private bool powerLoader__IsDisabled__cFieldSpecified;
    private bool? powerLoader__IsHidden__cField;
    private bool powerLoader__IsHidden__cFieldSpecified;
    private bool? powerLoader__IsRequired__cField;
    private bool powerLoader__IsRequired__cFieldSpecified;
    private bool? powerLoader__Is_Label_HTML__cField;
    private bool powerLoader__Is_Label_HTML__cFieldSpecified;
    private string powerLoader__Label__cField;
    private string powerLoader__List_Label_Field_API_Name__cField;
    private string powerLoader__List_Source_Type__cField;
    private string powerLoader__List_Source__cField;
    private string powerLoader__List_Value_Field_API_Name__cField;
    private string powerLoader__Object_API_Name__cField;
    private string powerLoader__Query_Panel__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.PowerLoader__Query_Panel__c powerLoader__Query_Panel__rField;
    private QueryResult powerLoader__Query_Parameter_Client_Behaviors__rField;
    private QueryResult powerLoader__Query_Parameter_Server_Filters__rField;
    private string powerLoader__Tag__cField;
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
    public string PowerLoader__Base_Master_Field_API_Name__c
    {
      get => this.powerLoader__Base_Master_Field_API_Name__cField;
      set => this.powerLoader__Base_Master_Field_API_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__Base_Object_API_Name__c
    {
      get => this.powerLoader__Base_Object_API_Name__cField;
      set => this.powerLoader__Base_Object_API_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__Default_Value_Type__c
    {
      get => this.powerLoader__Default_Value_Type__cField;
      set => this.powerLoader__Default_Value_Type__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__Default_Value__c
    {
      get => this.powerLoader__Default_Value__cField;
      set => this.powerLoader__Default_Value__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PowerLoader__Display_Sequence__c
    {
      get => this.powerLoader__Display_Sequence__cField;
      set => this.powerLoader__Display_Sequence__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__Display_Sequence__cSpecified
    {
      get => this.powerLoader__Display_Sequence__cFieldSpecified;
      set => this.powerLoader__Display_Sequence__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__Display_Type__c
    {
      get => this.powerLoader__Display_Type__cField;
      set => this.powerLoader__Display_Type__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PowerLoader__IsDisabled__c
    {
      get => this.powerLoader__IsDisabled__cField;
      set => this.powerLoader__IsDisabled__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__IsDisabled__cSpecified
    {
      get => this.powerLoader__IsDisabled__cFieldSpecified;
      set => this.powerLoader__IsDisabled__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PowerLoader__IsHidden__c
    {
      get => this.powerLoader__IsHidden__cField;
      set => this.powerLoader__IsHidden__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__IsHidden__cSpecified
    {
      get => this.powerLoader__IsHidden__cFieldSpecified;
      set => this.powerLoader__IsHidden__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PowerLoader__IsRequired__c
    {
      get => this.powerLoader__IsRequired__cField;
      set => this.powerLoader__IsRequired__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__IsRequired__cSpecified
    {
      get => this.powerLoader__IsRequired__cFieldSpecified;
      set => this.powerLoader__IsRequired__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PowerLoader__Is_Label_HTML__c
    {
      get => this.powerLoader__Is_Label_HTML__cField;
      set => this.powerLoader__Is_Label_HTML__cField = value;
    }

    [XmlIgnore]
    public bool PowerLoader__Is_Label_HTML__cSpecified
    {
      get => this.powerLoader__Is_Label_HTML__cFieldSpecified;
      set => this.powerLoader__Is_Label_HTML__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__Label__c
    {
      get => this.powerLoader__Label__cField;
      set => this.powerLoader__Label__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__List_Label_Field_API_Name__c
    {
      get => this.powerLoader__List_Label_Field_API_Name__cField;
      set => this.powerLoader__List_Label_Field_API_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__List_Source_Type__c
    {
      get => this.powerLoader__List_Source_Type__cField;
      set => this.powerLoader__List_Source_Type__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__List_Source__c
    {
      get => this.powerLoader__List_Source__cField;
      set => this.powerLoader__List_Source__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__List_Value_Field_API_Name__c
    {
      get => this.powerLoader__List_Value_Field_API_Name__cField;
      set => this.powerLoader__List_Value_Field_API_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__Object_API_Name__c
    {
      get => this.powerLoader__Object_API_Name__cField;
      set => this.powerLoader__Object_API_Name__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__Query_Panel__c
    {
      get => this.powerLoader__Query_Panel__cField;
      set => this.powerLoader__Query_Panel__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.PowerLoader__Query_Panel__c PowerLoader__Query_Panel__r
    {
      get => this.powerLoader__Query_Panel__rField;
      set => this.powerLoader__Query_Panel__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult PowerLoader__Query_Parameter_Client_Behaviors__r
    {
      get => this.powerLoader__Query_Parameter_Client_Behaviors__rField;
      set => this.powerLoader__Query_Parameter_Client_Behaviors__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult PowerLoader__Query_Parameter_Server_Filters__r
    {
      get => this.powerLoader__Query_Parameter_Server_Filters__rField;
      set => this.powerLoader__Query_Parameter_Server_Filters__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PowerLoader__Tag__c
    {
      get => this.powerLoader__Tag__cField;
      set => this.powerLoader__Tag__cField = value;
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
