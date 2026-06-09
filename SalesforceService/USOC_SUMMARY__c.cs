// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.USOC_SUMMARY__c
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
  public class USOC_SUMMARY__c : sObject
  {
    private string aCCESS_SERV_GROUP_ID__cField;
    private string aCCESS_TYP_CD__cField;
    private DateTime? aGREMNT_END_DT__cField;
    private bool aGREMNT_END_DT__cFieldSpecified;
    private DateTime? aGREMNT_START_DT__cField;
    private bool aGREMNT_START_DT__cFieldSpecified;
    private string aGREMNT_TERM_DURATN_VALUE__cField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private double? bILL_ICONNECT_PCT_RT__cField;
    private bool bILL_ICONNECT_PCT_RT__cFieldSpecified;
    private string bUYING_PLAN_NAME__cField;
    private ACC_CAR_BUYING_PLAN__c bUYING_PLAN_NAME__rField;
    private string cFA_NAME__cField;
    private string cHARGE_TYP__cField;
    private double? cHRG_PCT_RT__cField;
    private bool cHRG_PCT_RT__cFieldSpecified;
    private string cHRG_TYP__cField;
    private string cIRCUIT_LOC_ADDR__cField;
    private string cIRCUIT_LOC_NBR__cField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private double? dISCNT_PCT_RT__cField;
    private bool dISCNT_PCT_RT__cFieldSpecified;
    private double? dSCNT_FACTOR_RT__cField;
    private bool dSCNT_FACTOR_RT__cFieldSpecified;
    private DateTime? dW_CREATE_DT__cField;
    private bool dW_CREATE_DT__cFieldSpecified;
    private string dW_DELETED_IND__cField;
    private string dW_HASHCODE_TXT__cField;
    private DateTime? dW_LAST_MODIFY_DT__cField;
    private bool dW_LAST_MODIFY_DT__cFieldSpecified;
    private string dW_SOURCE_SYSTEM_CD__cField;
    private QueryResult duplicateRecordItemsField;
    private string eCCKT_STRIPPED_NAME__cField;
    private ECCKT__c eCCKT_STRIPPED_NAME__rField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private string fACILITY_CHRG_TYP_CD__cField;
    private QueryResult feedSubscriptionsForEntityField;
    private double? fixedMileage__cField;
    private bool fixedMileage__cFieldSpecified;
    private QueryResult historiesField;
    private double? iNITIAL_CHRG_AMT__cField;
    private bool iNITIAL_CHRG_AMT__cFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string jURSDCTN_DESC__cField;
    private string lINE_ITEM_CD__cField;
    private string lINE_ITEM_DESC__cField;
    private string lINE_ITEM_JURSDCTN_DETAIL_ID__cField;
    private double? lINE_ITEM_QTY__cField;
    private bool lINE_ITEM_QTY__cFieldSpecified;
    private string lINE_ITEM_SRC_TYP__cField;
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
    private string nCI_CD__cField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string oCL_LOCATION_CD__cField;
    private QueryResult openActivitiesField;
    private string pURCHASE_ORDER_NBR__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private double? rACHET_FACTOR_RT__cField;
    private bool rACHET_FACTOR_RT__cFieldSpecified;
    private string rATE_ZONE_CD__cField;
    private QueryResult recordAssociatedGroupsField;
    private DateTime? sERV_ESTBL_DT__cField;
    private bool sERV_ESTBL_DT__cFieldSpecified;
    private string sITE__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.SITE__c sITE__rField;
    private DateTime? sOURCE_CREATE_DT__cField;
    private bool sOURCE_CREATE_DT__cFieldSpecified;
    private DateTime? sOURCE_LAST_MODIFY_DT__cField;
    private bool sOURCE_LAST_MODIFY_DT__cFieldSpecified;
    private string sOURCE_LAST_MODIFY_USER_ID__cField;
    private string sPECIAL_PRICING_PLAN_NAME__cField;
    private double? sRC_INITIAL_CHRG_AMT__cField;
    private bool sRC_INITIAL_CHRG_AMT__cFieldSpecified;
    private double? sRC_UNIT_CHRG_AMT__cField;
    private bool sRC_UNIT_CHRG_AMT__cFieldSpecified;
    private double? sRC_USOC_AMT__cField;
    private bool sRC_USOC_AMT__cFieldSpecified;
    private string sTATE_CD__cField;
    private string sTRIPPED_ECCKT__cField;
    private string sUPPLIER_CIRCUIT_ODS_ID__cField;
    private double? sUPPL_BILL_ICONNECT_PCT_RT__cField;
    private bool sUPPL_BILL_ICONNECT_PCT_RT__cFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private double? uNIT_CHRG_AMT__cField;
    private bool uNIT_CHRG_AMT__cFieldSpecified;
    private double? uSOC_AMT__cField;
    private bool uSOC_AMT__cFieldSpecified;
    private string uSOC_BILLED_ODS_ID__cField;
    private string uSOC_DESC__cField;
    private string uSOC_NAME__cField;
    private string uSOC_SUMMARY_AML_ID__cField;
    private string uSOC_SUMMARY_KEY_ID__cField;
    private string uSOC_TYP__cField;
    private bool? uSOC_WF_Update__cField;
    private bool uSOC_WF_Update__cFieldSpecified;
    private UserRecordAccess userRecordAccessField;
    private double? variableMileage__cField;
    private bool variableMileage__cFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string ACCESS_SERV_GROUP_ID__c
    {
      get => this.aCCESS_SERV_GROUP_ID__cField;
      set => this.aCCESS_SERV_GROUP_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACCESS_TYP_CD__c
    {
      get => this.aCCESS_TYP_CD__cField;
      set => this.aCCESS_TYP_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? AGREMNT_END_DT__c
    {
      get => this.aGREMNT_END_DT__cField;
      set => this.aGREMNT_END_DT__cField = value;
    }

    [XmlIgnore]
    public bool AGREMNT_END_DT__cSpecified
    {
      get => this.aGREMNT_END_DT__cFieldSpecified;
      set => this.aGREMNT_END_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? AGREMNT_START_DT__c
    {
      get => this.aGREMNT_START_DT__cField;
      set => this.aGREMNT_START_DT__cField = value;
    }

    [XmlIgnore]
    public bool AGREMNT_START_DT__cSpecified
    {
      get => this.aGREMNT_START_DT__cFieldSpecified;
      set => this.aGREMNT_START_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string AGREMNT_TERM_DURATN_VALUE__c
    {
      get => this.aGREMNT_TERM_DURATN_VALUE__cField;
      set => this.aGREMNT_TERM_DURATN_VALUE__cField = value;
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
    public double? BILL_ICONNECT_PCT_RT__c
    {
      get => this.bILL_ICONNECT_PCT_RT__cField;
      set => this.bILL_ICONNECT_PCT_RT__cField = value;
    }

    [XmlIgnore]
    public bool BILL_ICONNECT_PCT_RT__cSpecified
    {
      get => this.bILL_ICONNECT_PCT_RT__cFieldSpecified;
      set => this.bILL_ICONNECT_PCT_RT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string BUYING_PLAN_NAME__c
    {
      get => this.bUYING_PLAN_NAME__cField;
      set => this.bUYING_PLAN_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ACC_CAR_BUYING_PLAN__c BUYING_PLAN_NAME__r
    {
      get => this.bUYING_PLAN_NAME__rField;
      set => this.bUYING_PLAN_NAME__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA_NAME__c
    {
      get => this.cFA_NAME__cField;
      set => this.cFA_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CHARGE_TYP__c
    {
      get => this.cHARGE_TYP__cField;
      set => this.cHARGE_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CHRG_PCT_RT__c
    {
      get => this.cHRG_PCT_RT__cField;
      set => this.cHRG_PCT_RT__cField = value;
    }

    [XmlIgnore]
    public bool CHRG_PCT_RT__cSpecified
    {
      get => this.cHRG_PCT_RT__cFieldSpecified;
      set => this.cHRG_PCT_RT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CHRG_TYP__c
    {
      get => this.cHRG_TYP__cField;
      set => this.cHRG_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CIRCUIT_LOC_ADDR__c
    {
      get => this.cIRCUIT_LOC_ADDR__cField;
      set => this.cIRCUIT_LOC_ADDR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CIRCUIT_LOC_NBR__c
    {
      get => this.cIRCUIT_LOC_NBR__cField;
      set => this.cIRCUIT_LOC_NBR__cField = value;
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
    public double? DISCNT_PCT_RT__c
    {
      get => this.dISCNT_PCT_RT__cField;
      set => this.dISCNT_PCT_RT__cField = value;
    }

    [XmlIgnore]
    public bool DISCNT_PCT_RT__cSpecified
    {
      get => this.dISCNT_PCT_RT__cFieldSpecified;
      set => this.dISCNT_PCT_RT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? DSCNT_FACTOR_RT__c
    {
      get => this.dSCNT_FACTOR_RT__cField;
      set => this.dSCNT_FACTOR_RT__cField = value;
    }

    [XmlIgnore]
    public bool DSCNT_FACTOR_RT__cSpecified
    {
      get => this.dSCNT_FACTOR_RT__cFieldSpecified;
      set => this.dSCNT_FACTOR_RT__cFieldSpecified = value;
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
    public string ECCKT_STRIPPED_NAME__c
    {
      get => this.eCCKT_STRIPPED_NAME__cField;
      set => this.eCCKT_STRIPPED_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ECCKT__c ECCKT_STRIPPED_NAME__r
    {
      get => this.eCCKT_STRIPPED_NAME__rField;
      set => this.eCCKT_STRIPPED_NAME__rField = value;
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
    public string FACILITY_CHRG_TYP_CD__c
    {
      get => this.fACILITY_CHRG_TYP_CD__cField;
      set => this.fACILITY_CHRG_TYP_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? FixedMileage__c
    {
      get => this.fixedMileage__cField;
      set => this.fixedMileage__cField = value;
    }

    [XmlIgnore]
    public bool FixedMileage__cSpecified
    {
      get => this.fixedMileage__cFieldSpecified;
      set => this.fixedMileage__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? INITIAL_CHRG_AMT__c
    {
      get => this.iNITIAL_CHRG_AMT__cField;
      set => this.iNITIAL_CHRG_AMT__cField = value;
    }

    [XmlIgnore]
    public bool INITIAL_CHRG_AMT__cSpecified
    {
      get => this.iNITIAL_CHRG_AMT__cFieldSpecified;
      set => this.iNITIAL_CHRG_AMT__cFieldSpecified = value;
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
    public string JURSDCTN_DESC__c
    {
      get => this.jURSDCTN_DESC__cField;
      set => this.jURSDCTN_DESC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LINE_ITEM_CD__c
    {
      get => this.lINE_ITEM_CD__cField;
      set => this.lINE_ITEM_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LINE_ITEM_DESC__c
    {
      get => this.lINE_ITEM_DESC__cField;
      set => this.lINE_ITEM_DESC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LINE_ITEM_JURSDCTN_DETAIL_ID__c
    {
      get => this.lINE_ITEM_JURSDCTN_DETAIL_ID__cField;
      set => this.lINE_ITEM_JURSDCTN_DETAIL_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? LINE_ITEM_QTY__c
    {
      get => this.lINE_ITEM_QTY__cField;
      set => this.lINE_ITEM_QTY__cField = value;
    }

    [XmlIgnore]
    public bool LINE_ITEM_QTY__cSpecified
    {
      get => this.lINE_ITEM_QTY__cFieldSpecified;
      set => this.lINE_ITEM_QTY__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LINE_ITEM_SRC_TYP__c
    {
      get => this.lINE_ITEM_SRC_TYP__cField;
      set => this.lINE_ITEM_SRC_TYP__cField = value;
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
    public string NCI_CD__c
    {
      get => this.nCI_CD__cField;
      set => this.nCI_CD__cField = value;
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
    public string OCL_LOCATION_CD__c
    {
      get => this.oCL_LOCATION_CD__cField;
      set => this.oCL_LOCATION_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PURCHASE_ORDER_NBR__c
    {
      get => this.pURCHASE_ORDER_NBR__cField;
      set => this.pURCHASE_ORDER_NBR__cField = value;
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
    public double? RACHET_FACTOR_RT__c
    {
      get => this.rACHET_FACTOR_RT__cField;
      set => this.rACHET_FACTOR_RT__cField = value;
    }

    [XmlIgnore]
    public bool RACHET_FACTOR_RT__cSpecified
    {
      get => this.rACHET_FACTOR_RT__cFieldSpecified;
      set => this.rACHET_FACTOR_RT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RATE_ZONE_CD__c
    {
      get => this.rATE_ZONE_CD__cField;
      set => this.rATE_ZONE_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SERV_ESTBL_DT__c
    {
      get => this.sERV_ESTBL_DT__cField;
      set => this.sERV_ESTBL_DT__cField = value;
    }

    [XmlIgnore]
    public bool SERV_ESTBL_DT__cSpecified
    {
      get => this.sERV_ESTBL_DT__cFieldSpecified;
      set => this.sERV_ESTBL_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SITE__c
    {
      get => this.sITE__cField;
      set => this.sITE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.SITE__c SITE__r
    {
      get => this.sITE__rField;
      set => this.sITE__rField = value;
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
    public string SPECIAL_PRICING_PLAN_NAME__c
    {
      get => this.sPECIAL_PRICING_PLAN_NAME__cField;
      set => this.sPECIAL_PRICING_PLAN_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_INITIAL_CHRG_AMT__c
    {
      get => this.sRC_INITIAL_CHRG_AMT__cField;
      set => this.sRC_INITIAL_CHRG_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_INITIAL_CHRG_AMT__cSpecified
    {
      get => this.sRC_INITIAL_CHRG_AMT__cFieldSpecified;
      set => this.sRC_INITIAL_CHRG_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_UNIT_CHRG_AMT__c
    {
      get => this.sRC_UNIT_CHRG_AMT__cField;
      set => this.sRC_UNIT_CHRG_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_UNIT_CHRG_AMT__cSpecified
    {
      get => this.sRC_UNIT_CHRG_AMT__cFieldSpecified;
      set => this.sRC_UNIT_CHRG_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_USOC_AMT__c
    {
      get => this.sRC_USOC_AMT__cField;
      set => this.sRC_USOC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_USOC_AMT__cSpecified
    {
      get => this.sRC_USOC_AMT__cFieldSpecified;
      set => this.sRC_USOC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string STATE_CD__c
    {
      get => this.sTATE_CD__cField;
      set => this.sTATE_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string STRIPPED_ECCKT__c
    {
      get => this.sTRIPPED_ECCKT__cField;
      set => this.sTRIPPED_ECCKT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUPPLIER_CIRCUIT_ODS_ID__c
    {
      get => this.sUPPLIER_CIRCUIT_ODS_ID__cField;
      set => this.sUPPLIER_CIRCUIT_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SUPPL_BILL_ICONNECT_PCT_RT__c
    {
      get => this.sUPPL_BILL_ICONNECT_PCT_RT__cField;
      set => this.sUPPL_BILL_ICONNECT_PCT_RT__cField = value;
    }

    [XmlIgnore]
    public bool SUPPL_BILL_ICONNECT_PCT_RT__cSpecified
    {
      get => this.sUPPL_BILL_ICONNECT_PCT_RT__cFieldSpecified;
      set => this.sUPPL_BILL_ICONNECT_PCT_RT__cFieldSpecified = value;
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
    public double? UNIT_CHRG_AMT__c
    {
      get => this.uNIT_CHRG_AMT__cField;
      set => this.uNIT_CHRG_AMT__cField = value;
    }

    [XmlIgnore]
    public bool UNIT_CHRG_AMT__cSpecified
    {
      get => this.uNIT_CHRG_AMT__cFieldSpecified;
      set => this.uNIT_CHRG_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? USOC_AMT__c
    {
      get => this.uSOC_AMT__cField;
      set => this.uSOC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool USOC_AMT__cSpecified
    {
      get => this.uSOC_AMT__cFieldSpecified;
      set => this.uSOC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string USOC_BILLED_ODS_ID__c
    {
      get => this.uSOC_BILLED_ODS_ID__cField;
      set => this.uSOC_BILLED_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string USOC_DESC__c
    {
      get => this.uSOC_DESC__cField;
      set => this.uSOC_DESC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string USOC_NAME__c
    {
      get => this.uSOC_NAME__cField;
      set => this.uSOC_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string USOC_SUMMARY_AML_ID__c
    {
      get => this.uSOC_SUMMARY_AML_ID__cField;
      set => this.uSOC_SUMMARY_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string USOC_SUMMARY_KEY_ID__c
    {
      get => this.uSOC_SUMMARY_KEY_ID__cField;
      set => this.uSOC_SUMMARY_KEY_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string USOC_TYP__c
    {
      get => this.uSOC_TYP__cField;
      set => this.uSOC_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? USOC_WF_Update__c
    {
      get => this.uSOC_WF_Update__cField;
      set => this.uSOC_WF_Update__cField = value;
    }

    [XmlIgnore]
    public bool USOC_WF_Update__cSpecified
    {
      get => this.uSOC_WF_Update__cFieldSpecified;
      set => this.uSOC_WF_Update__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? VariableMileage__c
    {
      get => this.variableMileage__cField;
      set => this.variableMileage__cField = value;
    }

    [XmlIgnore]
    public bool VariableMileage__cSpecified
    {
      get => this.variableMileage__cFieldSpecified;
      set => this.variableMileage__cFieldSpecified = value;
    }
  }
}
