// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ICCKT__c
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class ICCKT__c : sObject
  {
    private string aEND_CLLI_CD__cField;
    private string aEND_FRAB_AML_ID__cField;
    private string aEND_INE_NE_UNIQUE_NAME__cField;
    private string aEND_INE_PORT_UNIQUE_NAME__cField;
    private string aEND_SITE_CLEAN__cField;
    private SITE__c aEND_SITE_CLEAN__rField;
    private string aEND_SITE__cField;
    private SITE__c aEND_SITE__rField;
    private string aEND_ULT_NE_UNIQUE_NAME__cField;
    private string aEND_ULT_PORT_UNIQUE_NAME__cField;
    private string aLT_BANDWIDTH_CD__cField;
    private double? aSSIGNED_SLOTS_QTY__cField;
    private bool aSSIGNED_SLOTS_QTY__cFieldSpecified;
    private double? aVAILABLE_SLOTS_QTY__cField;
    private bool aVAILABLE_SLOTS_QTY__cFieldSpecified;
    private string a_ACTL_CD__cField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bANDWIDTH_CD__cField;
    private QueryResult cHANNELS_PROVIDER__rField;
    private QueryResult cHANNEL_CONSUMER__rField;
    private string cLEAN_AEND_CLLI_CD__cField;
    private string cLEAN_A_CLLI_FIRST_6__cField;
    private string cLEAN_ZEND_CLLI_CD__cField;
    private string cUST_AML_ID__cField;
    private string cUST_NAME__cField;
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
    private QueryResult eCCKT_ICCKT_XREFS__rField;
    private string eCCKT_ICCKT_XREF__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.ECCKT_ICCKT_XREF__c eCCKT_ICCKT_XREF__rField;
    private QueryResult eCCKT__rField;
    private string eXTRACTED_A_ACTL_CD__cField;
    private string eXTRACTED_A_CLLI_CD__cField;
    private string eXTRACTED_Z_ACTL_CD__cField;
    private string eXTRACTED_Z_CLLI_CD__cField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private string fRAMING_CD__cField;
    private QueryResult feedSubscriptionsForEntityField;
    private string hUB_SWC_CD__cField;
    private QueryResult historiesField;
    private string iCCKT_AML_ID__cField;
    private string iCCKT_GROUP_NAME__cField;
    private string iCCKT_KEY_ID__cField;
    private string iCCKT_RAW_NAME__cField;
    private string iCCKT_SHORT_NAME__cField;
    private string iCCKT_STRIPPED_NAME__cField;
    private string iCCKT_VERSION_GROUP_ID__cField;
    private double? iCCKT_VERSION_NBR__cField;
    private bool iCCKT_VERSION_NBR__cFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string lEGACY_COMPANY_NAME__cField;
    private string lINE_CODING_CD__cField;
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
    private string mAX_NOTE_CATEGORY__cField;
    private string mAX_NOTE_CREATED_BY__cField;
    private DateTime? mAX_NOTE_DATE__cField;
    private bool mAX_NOTE_DATE__cFieldSpecified;
    private string mAX_NOTE_PROJECT_ID__cField;
    private string mAX_NOTE__cField;
    private string mUX_LOC_CD__cField;
    private string nOTE_LOG__cField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string oFFNET_ICCKT_PARENT_NAME__cField;
    private string oRDER_NBR__cField;
    private string oRDER_STATUS_CD__cField;
    private QueryResult openActivitiesField;
    private QueryResult opportunities__rField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private string pIID_ID__cField;
    private string pRODUCT_CATEGORY_NAME__cField;
    private QueryResult phoenix_Notes__rField;
    private QueryResult prime_Notes__rField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult project_Items__rField;
    private string rAW_A_LOC_CD__cField;
    private string rAW_Z_LOC_CD__cField;
    private string rOUTER_NAME__cField;
    private QueryResult recordAssociatedGroupsField;
    private string sOURCE_BANDWIDTH_CD__cField;
    private DateTime? sOURCE_CREATE_DT__cField;
    private bool sOURCE_CREATE_DT__cFieldSpecified;
    private DateTime? sOURCE_LAST_MODIFY_DT__cField;
    private bool sOURCE_LAST_MODIFY_DT__cFieldSpecified;
    private string sOURCE_LAST_MODIFY_USER_ID__cField;
    private string sOURCE_USED_FOR_TYP__cField;
    private string sTATUS_CD__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private double? tOTAL_SLOTS_QTY__cField;
    private bool tOTAL_SLOTS_QTY__cFieldSpecified;
    private string tRAIL_ODS_ID__cField;
    private string tSP_CD__cField;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private string uSED_FOR_TYP__cField;
    private UserRecordAccess userRecordAccessField;
    private double? utilization__cField;
    private bool utilization__cFieldSpecified;
    private string zEND_CLLI_CD__cField;
    private string zEND_FRAB_AML_ID__cField;
    private string zEND_INE_NE_UNIQUE_NAME__cField;
    private string zEND_INE_PORT_UNIQUE_NAME__cField;
    private string zEND_SITE_CLEAN__cField;
    private SITE__c zEND_SITE_CLEAN__rField;
    private string zEND_SITE__cField;
    private SITE__c zEND_SITE__rField;
    private string zEND_ULT_NE_UNIQUE_NAME__cField;
    private string zEND_ULT_PORT_UNIQUE_NAME__cField;
    private string z_ACTL_CD__cField;

    [XmlElement(IsNullable = true)]
    public string AEND_CLLI_CD__c
    {
      get => this.aEND_CLLI_CD__cField;
      set => this.aEND_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_FRAB_AML_ID__c
    {
      get => this.aEND_FRAB_AML_ID__cField;
      set => this.aEND_FRAB_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_INE_NE_UNIQUE_NAME__c
    {
      get => this.aEND_INE_NE_UNIQUE_NAME__cField;
      set => this.aEND_INE_NE_UNIQUE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_INE_PORT_UNIQUE_NAME__c
    {
      get => this.aEND_INE_PORT_UNIQUE_NAME__cField;
      set => this.aEND_INE_PORT_UNIQUE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_SITE_CLEAN__c
    {
      get => this.aEND_SITE_CLEAN__cField;
      set => this.aEND_SITE_CLEAN__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SITE__c AEND_SITE_CLEAN__r
    {
      get => this.aEND_SITE_CLEAN__rField;
      set => this.aEND_SITE_CLEAN__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_SITE__c
    {
      get => this.aEND_SITE__cField;
      set => this.aEND_SITE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SITE__c AEND_SITE__r
    {
      get => this.aEND_SITE__rField;
      set => this.aEND_SITE__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_ULT_NE_UNIQUE_NAME__c
    {
      get => this.aEND_ULT_NE_UNIQUE_NAME__cField;
      set => this.aEND_ULT_NE_UNIQUE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_ULT_PORT_UNIQUE_NAME__c
    {
      get => this.aEND_ULT_PORT_UNIQUE_NAME__cField;
      set => this.aEND_ULT_PORT_UNIQUE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ALT_BANDWIDTH_CD__c
    {
      get => this.aLT_BANDWIDTH_CD__cField;
      set => this.aLT_BANDWIDTH_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ASSIGNED_SLOTS_QTY__c
    {
      get => this.aSSIGNED_SLOTS_QTY__cField;
      set => this.aSSIGNED_SLOTS_QTY__cField = value;
    }

    [XmlIgnore]
    public bool ASSIGNED_SLOTS_QTY__cSpecified
    {
      get => this.aSSIGNED_SLOTS_QTY__cFieldSpecified;
      set => this.aSSIGNED_SLOTS_QTY__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AVAILABLE_SLOTS_QTY__c
    {
      get => this.aVAILABLE_SLOTS_QTY__cField;
      set => this.aVAILABLE_SLOTS_QTY__cField = value;
    }

    [XmlIgnore]
    public bool AVAILABLE_SLOTS_QTY__cSpecified
    {
      get => this.aVAILABLE_SLOTS_QTY__cFieldSpecified;
      set => this.aVAILABLE_SLOTS_QTY__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string A_ACTL_CD__c
    {
      get => this.a_ACTL_CD__cField;
      set => this.a_ACTL_CD__cField = value;
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
    public string BANDWIDTH_CD__c
    {
      get => this.bANDWIDTH_CD__cField;
      set => this.bANDWIDTH_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CHANNELS_PROVIDER__r
    {
      get => this.cHANNELS_PROVIDER__rField;
      set => this.cHANNELS_PROVIDER__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CHANNEL_CONSUMER__r
    {
      get => this.cHANNEL_CONSUMER__rField;
      set => this.cHANNEL_CONSUMER__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLEAN_AEND_CLLI_CD__c
    {
      get => this.cLEAN_AEND_CLLI_CD__cField;
      set => this.cLEAN_AEND_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLEAN_A_CLLI_FIRST_6__c
    {
      get => this.cLEAN_A_CLLI_FIRST_6__cField;
      set => this.cLEAN_A_CLLI_FIRST_6__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLEAN_ZEND_CLLI_CD__c
    {
      get => this.cLEAN_ZEND_CLLI_CD__cField;
      set => this.cLEAN_ZEND_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CUST_AML_ID__c
    {
      get => this.cUST_AML_ID__cField;
      set => this.cUST_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CUST_NAME__c
    {
      get => this.cUST_NAME__cField;
      set => this.cUST_NAME__cField = value;
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
    public QueryResult ECCKT_ICCKT_XREFS__r
    {
      get => this.eCCKT_ICCKT_XREFS__rField;
      set => this.eCCKT_ICCKT_XREFS__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_ICCKT_XREF__c
    {
      get => this.eCCKT_ICCKT_XREF__cField;
      set => this.eCCKT_ICCKT_XREF__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.ECCKT_ICCKT_XREF__c ECCKT_ICCKT_XREF__r
    {
      get => this.eCCKT_ICCKT_XREF__rField;
      set => this.eCCKT_ICCKT_XREF__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKT__r
    {
      get => this.eCCKT__rField;
      set => this.eCCKT__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EXTRACTED_A_ACTL_CD__c
    {
      get => this.eXTRACTED_A_ACTL_CD__cField;
      set => this.eXTRACTED_A_ACTL_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EXTRACTED_A_CLLI_CD__c
    {
      get => this.eXTRACTED_A_CLLI_CD__cField;
      set => this.eXTRACTED_A_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EXTRACTED_Z_ACTL_CD__c
    {
      get => this.eXTRACTED_Z_ACTL_CD__cField;
      set => this.eXTRACTED_Z_ACTL_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EXTRACTED_Z_CLLI_CD__c
    {
      get => this.eXTRACTED_Z_CLLI_CD__cField;
      set => this.eXTRACTED_Z_CLLI_CD__cField = value;
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
    public string FRAMING_CD__c
    {
      get => this.fRAMING_CD__cField;
      set => this.fRAMING_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string HUB_SWC_CD__c
    {
      get => this.hUB_SWC_CD__cField;
      set => this.hUB_SWC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_AML_ID__c
    {
      get => this.iCCKT_AML_ID__cField;
      set => this.iCCKT_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_GROUP_NAME__c
    {
      get => this.iCCKT_GROUP_NAME__cField;
      set => this.iCCKT_GROUP_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_KEY_ID__c
    {
      get => this.iCCKT_KEY_ID__cField;
      set => this.iCCKT_KEY_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_RAW_NAME__c
    {
      get => this.iCCKT_RAW_NAME__cField;
      set => this.iCCKT_RAW_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_SHORT_NAME__c
    {
      get => this.iCCKT_SHORT_NAME__cField;
      set => this.iCCKT_SHORT_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_STRIPPED_NAME__c
    {
      get => this.iCCKT_STRIPPED_NAME__cField;
      set => this.iCCKT_STRIPPED_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_VERSION_GROUP_ID__c
    {
      get => this.iCCKT_VERSION_GROUP_ID__cField;
      set => this.iCCKT_VERSION_GROUP_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ICCKT_VERSION_NBR__c
    {
      get => this.iCCKT_VERSION_NBR__cField;
      set => this.iCCKT_VERSION_NBR__cField = value;
    }

    [XmlIgnore]
    public bool ICCKT_VERSION_NBR__cSpecified
    {
      get => this.iCCKT_VERSION_NBR__cFieldSpecified;
      set => this.iCCKT_VERSION_NBR__cFieldSpecified = value;
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
    public string LEGACY_COMPANY_NAME__c
    {
      get => this.lEGACY_COMPANY_NAME__cField;
      set => this.lEGACY_COMPANY_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LINE_CODING_CD__c
    {
      get => this.lINE_CODING_CD__cField;
      set => this.lINE_CODING_CD__cField = value;
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
    public string MAX_NOTE_CATEGORY__c
    {
      get => this.mAX_NOTE_CATEGORY__cField;
      set => this.mAX_NOTE_CATEGORY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MAX_NOTE_CREATED_BY__c
    {
      get => this.mAX_NOTE_CREATED_BY__cField;
      set => this.mAX_NOTE_CREATED_BY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? MAX_NOTE_DATE__c
    {
      get => this.mAX_NOTE_DATE__cField;
      set => this.mAX_NOTE_DATE__cField = value;
    }

    [XmlIgnore]
    public bool MAX_NOTE_DATE__cSpecified
    {
      get => this.mAX_NOTE_DATE__cFieldSpecified;
      set => this.mAX_NOTE_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MAX_NOTE_PROJECT_ID__c
    {
      get => this.mAX_NOTE_PROJECT_ID__cField;
      set => this.mAX_NOTE_PROJECT_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MAX_NOTE__c
    {
      get => this.mAX_NOTE__cField;
      set => this.mAX_NOTE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MUX_LOC_CD__c
    {
      get => this.mUX_LOC_CD__cField;
      set => this.mUX_LOC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NOTE_LOG__c
    {
      get => this.nOTE_LOG__cField;
      set => this.nOTE_LOG__cField = value;
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
    public string OFFNET_ICCKT_PARENT_NAME__c
    {
      get => this.oFFNET_ICCKT_PARENT_NAME__cField;
      set => this.oFFNET_ICCKT_PARENT_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ORDER_NBR__c
    {
      get => this.oRDER_NBR__cField;
      set => this.oRDER_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ORDER_STATUS_CD__c
    {
      get => this.oRDER_STATUS_CD__cField;
      set => this.oRDER_STATUS_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Opportunities__r
    {
      get => this.opportunities__rField;
      set => this.opportunities__rField = value;
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
    public string PIID_ID__c
    {
      get => this.pIID_ID__cField;
      set => this.pIID_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PRODUCT_CATEGORY_NAME__c
    {
      get => this.pRODUCT_CATEGORY_NAME__cField;
      set => this.pRODUCT_CATEGORY_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Phoenix_Notes__r
    {
      get => this.phoenix_Notes__rField;
      set => this.phoenix_Notes__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Prime_Notes__r
    {
      get => this.prime_Notes__rField;
      set => this.prime_Notes__rField = value;
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
    public QueryResult Project_Items__r
    {
      get => this.project_Items__rField;
      set => this.project_Items__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RAW_A_LOC_CD__c
    {
      get => this.rAW_A_LOC_CD__cField;
      set => this.rAW_A_LOC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RAW_Z_LOC_CD__c
    {
      get => this.rAW_Z_LOC_CD__cField;
      set => this.rAW_Z_LOC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ROUTER_NAME__c
    {
      get => this.rOUTER_NAME__cField;
      set => this.rOUTER_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SOURCE_BANDWIDTH_CD__c
    {
      get => this.sOURCE_BANDWIDTH_CD__cField;
      set => this.sOURCE_BANDWIDTH_CD__cField = value;
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
    public string SOURCE_USED_FOR_TYP__c
    {
      get => this.sOURCE_USED_FOR_TYP__cField;
      set => this.sOURCE_USED_FOR_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string STATUS_CD__c
    {
      get => this.sTATUS_CD__cField;
      set => this.sTATUS_CD__cField = value;
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
    public double? TOTAL_SLOTS_QTY__c
    {
      get => this.tOTAL_SLOTS_QTY__cField;
      set => this.tOTAL_SLOTS_QTY__cField = value;
    }

    [XmlIgnore]
    public bool TOTAL_SLOTS_QTY__cSpecified
    {
      get => this.tOTAL_SLOTS_QTY__cFieldSpecified;
      set => this.tOTAL_SLOTS_QTY__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TRAIL_ODS_ID__c
    {
      get => this.tRAIL_ODS_ID__cField;
      set => this.tRAIL_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TSP_CD__c
    {
      get => this.tSP_CD__cField;
      set => this.tSP_CD__cField = value;
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
    public string USED_FOR_TYP__c
    {
      get => this.uSED_FOR_TYP__cField;
      set => this.uSED_FOR_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Utilization__c
    {
      get => this.utilization__cField;
      set => this.utilization__cField = value;
    }

    [XmlIgnore]
    public bool Utilization__cSpecified
    {
      get => this.utilization__cFieldSpecified;
      set => this.utilization__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_CLLI_CD__c
    {
      get => this.zEND_CLLI_CD__cField;
      set => this.zEND_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_FRAB_AML_ID__c
    {
      get => this.zEND_FRAB_AML_ID__cField;
      set => this.zEND_FRAB_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_INE_NE_UNIQUE_NAME__c
    {
      get => this.zEND_INE_NE_UNIQUE_NAME__cField;
      set => this.zEND_INE_NE_UNIQUE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_INE_PORT_UNIQUE_NAME__c
    {
      get => this.zEND_INE_PORT_UNIQUE_NAME__cField;
      set => this.zEND_INE_PORT_UNIQUE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_SITE_CLEAN__c
    {
      get => this.zEND_SITE_CLEAN__cField;
      set => this.zEND_SITE_CLEAN__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SITE__c ZEND_SITE_CLEAN__r
    {
      get => this.zEND_SITE_CLEAN__rField;
      set => this.zEND_SITE_CLEAN__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_SITE__c
    {
      get => this.zEND_SITE__cField;
      set => this.zEND_SITE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SITE__c ZEND_SITE__r
    {
      get => this.zEND_SITE__rField;
      set => this.zEND_SITE__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_ULT_NE_UNIQUE_NAME__c
    {
      get => this.zEND_ULT_NE_UNIQUE_NAME__cField;
      set => this.zEND_ULT_NE_UNIQUE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_ULT_PORT_UNIQUE_NAME__c
    {
      get => this.zEND_ULT_PORT_UNIQUE_NAME__cField;
      set => this.zEND_ULT_PORT_UNIQUE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Z_ACTL_CD__c
    {
      get => this.z_ACTL_CD__cField;
      set => this.z_ACTL_CD__cField = value;
    }
  }
}
