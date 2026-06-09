// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SITE__c
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
  public class SITE__c : sObject
  {
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string cITY_CD__cField;
    private string cLLI_CD__cField;
    private string cOUNTRY_ISO_3_CD__cField;
    private string cOUNTRY_NAME__cField;
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
    private QueryResult eCCKTS_AEND_ASR__rField;
    private QueryResult eCCKTS_AEND_CLEAN__rField;
    private QueryResult eCCKTS_AEND__rField;
    private QueryResult eCCKTS_SITE_MUX_LOC__rField;
    private QueryResult eCCKTS_ZEND_ASR__rField;
    private QueryResult eCCKTS_ZEND_CLEAN__rField;
    private QueryResult eCCKTS_ZEND__rField;
    private QueryResult eCCKTS__rField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private QueryResult feedSubscriptionsForEntityField;
    private double? gEOLOCATION__Latitude__sField;
    private bool gEOLOCATION__Latitude__sFieldSpecified;
    private double? gEOLOCATION__Longitude__sField;
    private bool gEOLOCATION__Longitude__sFieldSpecified;
    private location gEOLOCATION__cField;
    private string gL_PROFIT_CTR_CD__cField;
    private string gL_SEG2_PROFIT_CTR_ODS_ID__cField;
    private double? h_COORD__cField;
    private bool h_COORD__cFieldSpecified;
    private QueryResult historiesField;
    private QueryResult iCCKTS_AEND_CLEAN__rField;
    private QueryResult iCCKTS_ZEND_CLEAN__rField;
    private QueryResult iCCKTS_ZEND__rField;
    private QueryResult iCCKTS__rField;
    private string iLEC_REGION_NAME__cField;
    private bool? iS_LATA_NUMBER__cField;
    private bool iS_LATA_NUMBER__cFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string lATA_CD__cField;
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
    private string mARKET_NAME__cField;
    private string mETRO_STATISTICAL_AREA_NAME__cField;
    private double? nPA_NBR__cField;
    private bool nPA_NBR__cFieldSpecified;
    private double? nXX_NBR__cField;
    private bool nXX_NBR__cFieldSpecified;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string oNNET_IND__cField;
    private QueryResult openActivitiesField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private string pHYS_STUCT_ODS_ID__cField;
    private string pOI_IND__cField;
    private string pOSTAL_CD__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string rEGION_NAME__cField;
    private QueryResult recordAssociatedGroupsField;
    private string sITE_AML_ID__cField;
    private string sITE_KEY_ID__cField;
    private DateTime? sOURCE_CREATE_DT__cField;
    private bool sOURCE_CREATE_DT__cFieldSpecified;
    private DateTime? sOURCE_LAST_MODIFY_DT__cField;
    private bool sOURCE_LAST_MODIFY_DT__cFieldSpecified;
    private string sOURCE_LAST_MODIFY_USER_ID__cField;
    private string sTATE_PROV_CD__cField;
    private string sTATE_PROV_NAME__cField;
    private string sTATUS_CD__cField;
    private string sTREET_ADDR__cField;
    private string sTRUCTURE_TYP__cField;
    private string sWC_CLLI_CD__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string tIER_NAME__cField;
    private QueryResult tasksField;
    private QueryResult topicAssignmentsField;
    private QueryResult uSOC_SUMMARIES__rField;
    private UserRecordAccess userRecordAccessField;
    private double? v_COORD__cField;
    private bool v_COORD__cFieldSpecified;

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
    public string CITY_CD__c
    {
      get => this.cITY_CD__cField;
      set => this.cITY_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLLI_CD__c
    {
      get => this.cLLI_CD__cField;
      set => this.cLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string COUNTRY_ISO_3_CD__c
    {
      get => this.cOUNTRY_ISO_3_CD__cField;
      set => this.cOUNTRY_ISO_3_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string COUNTRY_NAME__c
    {
      get => this.cOUNTRY_NAME__cField;
      set => this.cOUNTRY_NAME__cField = value;
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
    public QueryResult ECCKTS_AEND_ASR__r
    {
      get => this.eCCKTS_AEND_ASR__rField;
      set => this.eCCKTS_AEND_ASR__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS_AEND_CLEAN__r
    {
      get => this.eCCKTS_AEND_CLEAN__rField;
      set => this.eCCKTS_AEND_CLEAN__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS_AEND__r
    {
      get => this.eCCKTS_AEND__rField;
      set => this.eCCKTS_AEND__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS_SITE_MUX_LOC__r
    {
      get => this.eCCKTS_SITE_MUX_LOC__rField;
      set => this.eCCKTS_SITE_MUX_LOC__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS_ZEND_ASR__r
    {
      get => this.eCCKTS_ZEND_ASR__rField;
      set => this.eCCKTS_ZEND_ASR__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS_ZEND_CLEAN__r
    {
      get => this.eCCKTS_ZEND_CLEAN__rField;
      set => this.eCCKTS_ZEND_CLEAN__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS_ZEND__r
    {
      get => this.eCCKTS_ZEND__rField;
      set => this.eCCKTS_ZEND__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKTS__r
    {
      get => this.eCCKTS__rField;
      set => this.eCCKTS__rField = value;
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
    public double? GEOLOCATION__Latitude__s
    {
      get => this.gEOLOCATION__Latitude__sField;
      set => this.gEOLOCATION__Latitude__sField = value;
    }

    [XmlIgnore]
    public bool GEOLOCATION__Latitude__sSpecified
    {
      get => this.gEOLOCATION__Latitude__sFieldSpecified;
      set => this.gEOLOCATION__Latitude__sFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? GEOLOCATION__Longitude__s
    {
      get => this.gEOLOCATION__Longitude__sField;
      set => this.gEOLOCATION__Longitude__sField = value;
    }

    [XmlIgnore]
    public bool GEOLOCATION__Longitude__sSpecified
    {
      get => this.gEOLOCATION__Longitude__sFieldSpecified;
      set => this.gEOLOCATION__Longitude__sFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public location GEOLOCATION__c
    {
      get => this.gEOLOCATION__cField;
      set => this.gEOLOCATION__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GL_PROFIT_CTR_CD__c
    {
      get => this.gL_PROFIT_CTR_CD__cField;
      set => this.gL_PROFIT_CTR_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GL_SEG2_PROFIT_CTR_ODS_ID__c
    {
      get => this.gL_SEG2_PROFIT_CTR_ODS_ID__cField;
      set => this.gL_SEG2_PROFIT_CTR_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? H_COORD__c
    {
      get => this.h_COORD__cField;
      set => this.h_COORD__cField = value;
    }

    [XmlIgnore]
    public bool H_COORD__cSpecified
    {
      get => this.h_COORD__cFieldSpecified;
      set => this.h_COORD__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ICCKTS_AEND_CLEAN__r
    {
      get => this.iCCKTS_AEND_CLEAN__rField;
      set => this.iCCKTS_AEND_CLEAN__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ICCKTS_ZEND_CLEAN__r
    {
      get => this.iCCKTS_ZEND_CLEAN__rField;
      set => this.iCCKTS_ZEND_CLEAN__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ICCKTS_ZEND__r
    {
      get => this.iCCKTS_ZEND__rField;
      set => this.iCCKTS_ZEND__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ICCKTS__r
    {
      get => this.iCCKTS__rField;
      set => this.iCCKTS__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ILEC_REGION_NAME__c
    {
      get => this.iLEC_REGION_NAME__cField;
      set => this.iLEC_REGION_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IS_LATA_NUMBER__c
    {
      get => this.iS_LATA_NUMBER__cField;
      set => this.iS_LATA_NUMBER__cField = value;
    }

    [XmlIgnore]
    public bool IS_LATA_NUMBER__cSpecified
    {
      get => this.iS_LATA_NUMBER__cFieldSpecified;
      set => this.iS_LATA_NUMBER__cFieldSpecified = value;
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
    public string LATA_CD__c
    {
      get => this.lATA_CD__cField;
      set => this.lATA_CD__cField = value;
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
    public string MARKET_NAME__c
    {
      get => this.mARKET_NAME__cField;
      set => this.mARKET_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string METRO_STATISTICAL_AREA_NAME__c
    {
      get => this.mETRO_STATISTICAL_AREA_NAME__cField;
      set => this.mETRO_STATISTICAL_AREA_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NPA_NBR__c
    {
      get => this.nPA_NBR__cField;
      set => this.nPA_NBR__cField = value;
    }

    [XmlIgnore]
    public bool NPA_NBR__cSpecified
    {
      get => this.nPA_NBR__cFieldSpecified;
      set => this.nPA_NBR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NXX_NBR__c
    {
      get => this.nXX_NBR__cField;
      set => this.nXX_NBR__cField = value;
    }

    [XmlIgnore]
    public bool NXX_NBR__cSpecified
    {
      get => this.nXX_NBR__cFieldSpecified;
      set => this.nXX_NBR__cFieldSpecified = value;
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
    public string ONNET_IND__c
    {
      get => this.oNNET_IND__cField;
      set => this.oNNET_IND__cField = value;
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
    public string PHYS_STUCT_ODS_ID__c
    {
      get => this.pHYS_STUCT_ODS_ID__cField;
      set => this.pHYS_STUCT_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string POI_IND__c
    {
      get => this.pOI_IND__cField;
      set => this.pOI_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string POSTAL_CD__c
    {
      get => this.pOSTAL_CD__cField;
      set => this.pOSTAL_CD__cField = value;
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
    public string REGION_NAME__c
    {
      get => this.rEGION_NAME__cField;
      set => this.rEGION_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SITE_AML_ID__c
    {
      get => this.sITE_AML_ID__cField;
      set => this.sITE_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SITE_KEY_ID__c
    {
      get => this.sITE_KEY_ID__cField;
      set => this.sITE_KEY_ID__cField = value;
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
    public string STATE_PROV_CD__c
    {
      get => this.sTATE_PROV_CD__cField;
      set => this.sTATE_PROV_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string STATE_PROV_NAME__c
    {
      get => this.sTATE_PROV_NAME__cField;
      set => this.sTATE_PROV_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string STATUS_CD__c
    {
      get => this.sTATUS_CD__cField;
      set => this.sTATUS_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string STREET_ADDR__c
    {
      get => this.sTREET_ADDR__cField;
      set => this.sTREET_ADDR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string STRUCTURE_TYP__c
    {
      get => this.sTRUCTURE_TYP__cField;
      set => this.sTRUCTURE_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SWC_CLLI_CD__c
    {
      get => this.sWC_CLLI_CD__cField;
      set => this.sWC_CLLI_CD__cField = value;
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
    public string TIER_NAME__c
    {
      get => this.tIER_NAME__cField;
      set => this.tIER_NAME__cField = value;
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
    public QueryResult USOC_SUMMARIES__r
    {
      get => this.uSOC_SUMMARIES__rField;
      set => this.uSOC_SUMMARIES__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? V_COORD__c
    {
      get => this.v_COORD__cField;
      set => this.v_COORD__cField = value;
    }

    [XmlIgnore]
    public bool V_COORD__cSpecified
    {
      get => this.v_COORD__cFieldSpecified;
      set => this.v_COORD__cFieldSpecified = value;
    }
  }
}
