// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.L3_Export_Report_IDs__c
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
  public class L3_Export_Report_IDs__c : sObject
  {
    private QueryResult attachedContentDocumentsField;
    private string bAN_MERGE_IND__cField;
    private string cLM_Export_Id__cField;
    private string carrier_Manager_Field_ID__cField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private string eCCKT_Stripped_Name_Field_ID__cField;
    private QueryResult emailsField;
    private QueryResult feedSubscriptionsForEntityField;
    private string iCCKT_Group_Name__cField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string last_Bill_Date_Field_ID__cField;
    private QueryResult lookedUpFromActivitiesField;
    private string nameField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private string report_ID__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name setupOwnerField;
    private string setupOwnerIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string term_Ending_Field_ID__cField;
    private string term_Status_Field_ID__cField;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;
    private string vendor_Field_ID__cField;

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BAN_MERGE_IND__c
    {
      get => this.bAN_MERGE_IND__cField;
      set => this.bAN_MERGE_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLM_Export_Id__c
    {
      get => this.cLM_Export_Id__cField;
      set => this.cLM_Export_Id__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Carrier_Manager_Field_ID__c
    {
      get => this.carrier_Manager_Field_ID__cField;
      set => this.carrier_Manager_Field_ID__cField = value;
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
    public string ECCKT_Stripped_Name_Field_ID__c
    {
      get => this.eCCKT_Stripped_Name_Field_ID__cField;
      set => this.eCCKT_Stripped_Name_Field_ID__cField = value;
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
    public string ICCKT_Group_Name__c
    {
      get => this.iCCKT_Group_Name__cField;
      set => this.iCCKT_Group_Name__cField = value;
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
    public string Last_Bill_Date_Field_ID__c
    {
      get => this.last_Bill_Date_Field_ID__cField;
      set => this.last_Bill_Date_Field_ID__cField = value;
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
    public string Report_ID__c
    {
      get => this.report_ID__cField;
      set => this.report_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name SetupOwner
    {
      get => this.setupOwnerField;
      set => this.setupOwnerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SetupOwnerId
    {
      get => this.setupOwnerIdField;
      set => this.setupOwnerIdField = value;
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
    public string Term_Ending_Field_ID__c
    {
      get => this.term_Ending_Field_ID__cField;
      set => this.term_Ending_Field_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Term_Status_Field_ID__c
    {
      get => this.term_Status_Field_ID__cField;
      set => this.term_Status_Field_ID__cField = value;
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
    public string Vendor_Field_ID__c
    {
      get => this.vendor_Field_ID__cField;
      set => this.vendor_Field_ID__cField = value;
    }
  }
}
