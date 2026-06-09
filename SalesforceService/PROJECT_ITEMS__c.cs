// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PROJECT_ITEMS__c
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class PROJECT_ITEMS__c : sObject
  {
    private string aCNA__cField;
    private string aCTION__cField;
    private string aCTL__cField;
    private double? aIM_ACCRUAL__cField;
    private bool aIM_ACCRUAL__cFieldSpecified;
    private string aML_ECCKT__cField;
    private ECCKT__c aML_ECCKT__rField;
    private string aML_ICCKT__cField;
    private ICCKT__c aML_ICCKT__rField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bANDWIDTH__cField;
    private string bAN_MERGE_IND__cField;
    private string cFA_CHANNEL__cField;
    private string cFA_ECCKT_NEW__cField;
    private string cFA_ECCKT__cField;
    private string cFA_PROVISIONING_ID_NEW__cField;
    private string cFA_PROVISIONING_ID__cField;
    private string cONTROLLING_VENDOR_INDICATOR_NEW__cField;
    private string cONTROLLING_VENDOR_INDICATOR__cField;
    private string cPA_DETERMINATION__cField;
    private string cURRENT_SWC__cField;
    private string cUSTOMER_NAME__cField;
    private bool? cUT_LEVEL_INDICATOR__cField;
    private bool cUT_LEVEL_INDICATOR__cFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult duplicateRecordItemsField;
    private string eCCKT_A_CLLI_NEW__cField;
    private string eCCKT_A_CLLI__cField;
    private string eCCKT_RAW_NAME__cField;
    private string eCCKT_Z_CLLI_NEW__cField;
    private string eCCKT_Z_CLLI__cField;
    private bool? eXISTING_ECCKT__cField;
    private bool eXISTING_ECCKT__cFieldSpecified;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private string grooms_Order_ID__cField;
    private QueryResult historiesField;
    private string iCCKT_A_CLLI__cField;
    private string iCCKT_Z_CLLI__cField;
    private string iTEM_REMARKS__cField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private double? lATA__cField;
    private bool lATA__cFieldSpecified;
    private string lTID__cField;
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
    private string mEETPOINT_INDICATOR__cField;
    private double? mRC_NEW__cField;
    private bool mRC_NEW__cFieldSpecified;
    private double? mRC_SAVINGS__cField;
    private bool mRC_SAVINGS__cFieldSpecified;
    private double? mRC__cField;
    private bool mRC__cFieldSpecified;
    private string nEW_ECCKT_TERM__cField;
    private double? nRC_New__cField;
    private bool nRC_New__cFieldSpecified;
    private double? nRC_TOTAL__cField;
    private bool nRC_TOTAL__cFieldSpecified;
    private string nameField;
    private string netBuild_Vendor_String__cField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string numeric_GOID__cField;
    private string oDM_Term_Status__cField;
    private string oN_Net_Capable__cField;
    private string on_Net_Action__cField;
    private QueryResult openActivitiesField;
    private string pLANNER_NOTE__cField;
    private string pNUM_NEW__cField;
    private string pROJECT_ICCKT__cField;
    private string pROJECT__cField;
    private PROJECT_HEADER__c pROJECT__rField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult recordAssociatedGroupsField;
    private string sUB_PROJECT__cField;
    private SUB_PROJECT_HEADER__c sUB_PROJECT__rField;
    private string switch_And_TG_ID__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private double? tERM_LIABILITY__cField;
    private bool tERM_LIABILITY__cFieldSpecified;
    private string tSC__cField;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private string trunk_Group_CLLI__cField;
    private UserRecordAccess userRecordAccessField;
    private string vENDOR_NAME_NEW__cField;
    private Account vENDOR_NAME_NEW__rField;
    private string vENDOR_NAME__cField;
    private Account vENDOR_NAME__rField;
    private string wORKFLOW_TYPE__cField;

    [XmlElement(IsNullable = true)]
    public string ACNA__c
    {
      get => this.aCNA__cField;
      set => this.aCNA__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACTION__c
    {
      get => this.aCTION__cField;
      set => this.aCTION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACTL__c
    {
      get => this.aCTL__cField;
      set => this.aCTL__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AIM_ACCRUAL__c
    {
      get => this.aIM_ACCRUAL__cField;
      set => this.aIM_ACCRUAL__cField = value;
    }

    [XmlIgnore]
    public bool AIM_ACCRUAL__cSpecified
    {
      get => this.aIM_ACCRUAL__cFieldSpecified;
      set => this.aIM_ACCRUAL__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string AML_ECCKT__c
    {
      get => this.aML_ECCKT__cField;
      set => this.aML_ECCKT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ECCKT__c AML_ECCKT__r
    {
      get => this.aML_ECCKT__rField;
      set => this.aML_ECCKT__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AML_ICCKT__c
    {
      get => this.aML_ICCKT__cField;
      set => this.aML_ICCKT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ICCKT__c AML_ICCKT__r
    {
      get => this.aML_ICCKT__rField;
      set => this.aML_ICCKT__rField = value;
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
    public string BANDWIDTH__c
    {
      get => this.bANDWIDTH__cField;
      set => this.bANDWIDTH__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BAN_MERGE_IND__c
    {
      get => this.bAN_MERGE_IND__cField;
      set => this.bAN_MERGE_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA_CHANNEL__c
    {
      get => this.cFA_CHANNEL__cField;
      set => this.cFA_CHANNEL__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA_ECCKT_NEW__c
    {
      get => this.cFA_ECCKT_NEW__cField;
      set => this.cFA_ECCKT_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA_ECCKT__c
    {
      get => this.cFA_ECCKT__cField;
      set => this.cFA_ECCKT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA_PROVISIONING_ID_NEW__c
    {
      get => this.cFA_PROVISIONING_ID_NEW__cField;
      set => this.cFA_PROVISIONING_ID_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA_PROVISIONING_ID__c
    {
      get => this.cFA_PROVISIONING_ID__cField;
      set => this.cFA_PROVISIONING_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CONTROLLING_VENDOR_INDICATOR_NEW__c
    {
      get => this.cONTROLLING_VENDOR_INDICATOR_NEW__cField;
      set => this.cONTROLLING_VENDOR_INDICATOR_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CONTROLLING_VENDOR_INDICATOR__c
    {
      get => this.cONTROLLING_VENDOR_INDICATOR__cField;
      set => this.cONTROLLING_VENDOR_INDICATOR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CPA_DETERMINATION__c
    {
      get => this.cPA_DETERMINATION__cField;
      set => this.cPA_DETERMINATION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CURRENT_SWC__c
    {
      get => this.cURRENT_SWC__cField;
      set => this.cURRENT_SWC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CUSTOMER_NAME__c
    {
      get => this.cUSTOMER_NAME__cField;
      set => this.cUSTOMER_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? CUT_LEVEL_INDICATOR__c
    {
      get => this.cUT_LEVEL_INDICATOR__cField;
      set => this.cUT_LEVEL_INDICATOR__cField = value;
    }

    [XmlIgnore]
    public bool CUT_LEVEL_INDICATOR__cSpecified
    {
      get => this.cUT_LEVEL_INDICATOR__cFieldSpecified;
      set => this.cUT_LEVEL_INDICATOR__cFieldSpecified = value;
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
    public string ECCKT_A_CLLI_NEW__c
    {
      get => this.eCCKT_A_CLLI_NEW__cField;
      set => this.eCCKT_A_CLLI_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_A_CLLI__c
    {
      get => this.eCCKT_A_CLLI__cField;
      set => this.eCCKT_A_CLLI__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_RAW_NAME__c
    {
      get => this.eCCKT_RAW_NAME__cField;
      set => this.eCCKT_RAW_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_Z_CLLI_NEW__c
    {
      get => this.eCCKT_Z_CLLI_NEW__cField;
      set => this.eCCKT_Z_CLLI_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_Z_CLLI__c
    {
      get => this.eCCKT_Z_CLLI__cField;
      set => this.eCCKT_Z_CLLI__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? EXISTING_ECCKT__c
    {
      get => this.eXISTING_ECCKT__cField;
      set => this.eXISTING_ECCKT__cField = value;
    }

    [XmlIgnore]
    public bool EXISTING_ECCKT__cSpecified
    {
      get => this.eXISTING_ECCKT__cFieldSpecified;
      set => this.eXISTING_ECCKT__cFieldSpecified = value;
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
    public string Grooms_Order_ID__c
    {
      get => this.grooms_Order_ID__cField;
      set => this.grooms_Order_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_A_CLLI__c
    {
      get => this.iCCKT_A_CLLI__cField;
      set => this.iCCKT_A_CLLI__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICCKT_Z_CLLI__c
    {
      get => this.iCCKT_Z_CLLI__cField;
      set => this.iCCKT_Z_CLLI__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ITEM_REMARKS__c
    {
      get => this.iTEM_REMARKS__cField;
      set => this.iTEM_REMARKS__cField = value;
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
    public double? LATA__c
    {
      get => this.lATA__cField;
      set => this.lATA__cField = value;
    }

    [XmlIgnore]
    public bool LATA__cSpecified
    {
      get => this.lATA__cFieldSpecified;
      set => this.lATA__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LTID__c
    {
      get => this.lTID__cField;
      set => this.lTID__cField = value;
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
    public string MEETPOINT_INDICATOR__c
    {
      get => this.mEETPOINT_INDICATOR__cField;
      set => this.mEETPOINT_INDICATOR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MRC_NEW__c
    {
      get => this.mRC_NEW__cField;
      set => this.mRC_NEW__cField = value;
    }

    [XmlIgnore]
    public bool MRC_NEW__cSpecified
    {
      get => this.mRC_NEW__cFieldSpecified;
      set => this.mRC_NEW__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MRC_SAVINGS__c
    {
      get => this.mRC_SAVINGS__cField;
      set => this.mRC_SAVINGS__cField = value;
    }

    [XmlIgnore]
    public bool MRC_SAVINGS__cSpecified
    {
      get => this.mRC_SAVINGS__cFieldSpecified;
      set => this.mRC_SAVINGS__cFieldSpecified = value;
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
    public string NEW_ECCKT_TERM__c
    {
      get => this.nEW_ECCKT_TERM__cField;
      set => this.nEW_ECCKT_TERM__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NRC_New__c
    {
      get => this.nRC_New__cField;
      set => this.nRC_New__cField = value;
    }

    [XmlIgnore]
    public bool NRC_New__cSpecified
    {
      get => this.nRC_New__cFieldSpecified;
      set => this.nRC_New__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NRC_TOTAL__c
    {
      get => this.nRC_TOTAL__cField;
      set => this.nRC_TOTAL__cField = value;
    }

    [XmlIgnore]
    public bool NRC_TOTAL__cSpecified
    {
      get => this.nRC_TOTAL__cFieldSpecified;
      set => this.nRC_TOTAL__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NetBuild_Vendor_String__c
    {
      get => this.netBuild_Vendor_String__cField;
      set => this.netBuild_Vendor_String__cField = value;
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
    public string Numeric_GOID__c
    {
      get => this.numeric_GOID__cField;
      set => this.numeric_GOID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_Term_Status__c
    {
      get => this.oDM_Term_Status__cField;
      set => this.oDM_Term_Status__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ON_Net_Capable__c
    {
      get => this.oN_Net_Capable__cField;
      set => this.oN_Net_Capable__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string On_Net_Action__c
    {
      get => this.on_Net_Action__cField;
      set => this.on_Net_Action__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PLANNER_NOTE__c
    {
      get => this.pLANNER_NOTE__cField;
      set => this.pLANNER_NOTE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PNUM_NEW__c
    {
      get => this.pNUM_NEW__cField;
      set => this.pNUM_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECT_ICCKT__c
    {
      get => this.pROJECT_ICCKT__cField;
      set => this.pROJECT_ICCKT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECT__c
    {
      get => this.pROJECT__cField;
      set => this.pROJECT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public PROJECT_HEADER__c PROJECT__r
    {
      get => this.pROJECT__rField;
      set => this.pROJECT__rField = value;
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
    public string SUB_PROJECT__c
    {
      get => this.sUB_PROJECT__cField;
      set => this.sUB_PROJECT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SUB_PROJECT_HEADER__c SUB_PROJECT__r
    {
      get => this.sUB_PROJECT__rField;
      set => this.sUB_PROJECT__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Switch_And_TG_ID__c
    {
      get => this.switch_And_TG_ID__cField;
      set => this.switch_And_TG_ID__cField = value;
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
    public double? TERM_LIABILITY__c
    {
      get => this.tERM_LIABILITY__cField;
      set => this.tERM_LIABILITY__cField = value;
    }

    [XmlIgnore]
    public bool TERM_LIABILITY__cSpecified
    {
      get => this.tERM_LIABILITY__cFieldSpecified;
      set => this.tERM_LIABILITY__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TSC__c
    {
      get => this.tSC__cField;
      set => this.tSC__cField = value;
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
    public string Trunk_Group_CLLI__c
    {
      get => this.trunk_Group_CLLI__cField;
      set => this.trunk_Group_CLLI__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR_NAME_NEW__c
    {
      get => this.vENDOR_NAME_NEW__cField;
      set => this.vENDOR_NAME_NEW__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account VENDOR_NAME_NEW__r
    {
      get => this.vENDOR_NAME_NEW__rField;
      set => this.vENDOR_NAME_NEW__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR_NAME__c
    {
      get => this.vENDOR_NAME__cField;
      set => this.vENDOR_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account VENDOR_NAME__r
    {
      get => this.vENDOR_NAME__rField;
      set => this.vENDOR_NAME__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string WORKFLOW_TYPE__c
    {
      get => this.wORKFLOW_TYPE__cField;
      set => this.wORKFLOW_TYPE__cField = value;
    }
  }
}
