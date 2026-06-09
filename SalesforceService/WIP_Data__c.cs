// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.WIP_Data__c
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class WIP_Data__c : sObject
  {
    private string aCTIONTYPEQUALIFIER__cField;
    private double? aGE__cField;
    private bool aGE__cFieldSpecified;
    private QueryResult aMO_ECCKT_Data__rField;
    private string aSR_PON__cField;
    private DateTime? aSR_SentDate__cField;
    private bool aSR_SentDate__cFieldSpecified;
    private string actionableLabel__cField;
    private bool? actionable__cField;
    private bool actionable__cFieldSpecified;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bAN__cField;
    private string bandwidth__cField;
    private string cFA__cField;
    private string cHANNEL__cField;
    private string cICS__cField;
    private string cIRCUIT_ID__cField;
    private DateTime? cOMMITDATE__cField;
    private bool cOMMITDATE__cFieldSpecified;
    private string cOMPANYCODE__cField;
    private string cONSOLIDATE_TASK_PHASE__cField;
    private string cPA_Dependency__cField;
    private string cPA_IND__cField;
    private DateTime? cREATEDATE__cField;
    private bool cREATEDATE__cFieldSpecified;
    private string cUSTOMER_NAME__cField;
    private double? cUTLEVELCIRCUITS__cField;
    private bool cUTLEVELCIRCUITS__cFieldSpecified;
    private string cUTLEVELINDICATOR__cField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string dATA_SOURCE__cField;
    private double? dCD_Avg_Delta__cField;
    private bool dCD_Avg_Delta__cFieldSpecified;
    private double? dCD_Reset_Count__cField;
    private bool dCD_Reset_Count__cFieldSpecified;
    private DateTime? dCD__cField;
    private bool dCD__cFieldSpecified;
    private double? dEFECT_COUNT__cField;
    private bool dEFECT_COUNT__cFieldSpecified;
    private string defect_Summary__cField;
    private QueryResult duplicateRecordItemsField;
    private string e911_IND__cField;
    private string eCCKTRELATEDID__cField;
    private string eCCKT_STATUS__cField;
    private string eCCKT_STRIPPED__cField;
    private string eCCKT__cField;
    private QueryResult emailsField;
    private DateTime? fOC_DATE__cField;
    private bool fOC_DATE__cFieldSpecified;
    private DateTime? fSD_DATE__cField;
    private bool fSD_DATE__cFieldSpecified;
    private QueryResult feedSubscriptionsForEntityField;
    private bool? hASEXCEPTION__cField;
    private bool hASEXCEPTION__cFieldSpecified;
    private string hIERARCHYInd__cField;
    private string iNSTANCE_IDENTIFIER__cField;
    private bool? iSJEOPED__cField;
    private bool iSJEOPED__cFieldSpecified;
    private string iTEMACTIONCODE__cField;
    private string in_RSP__cField;
    private double? install_MRC__cField;
    private bool install_MRC__cFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private DateTime? jEOP_CREATE_DT__cField;
    private bool jEOP_CREATE_DT__cFieldSpecified;
    private double? jeop_age__cField;
    private bool jeop_age__cFieldSpecified;
    private string lATA__cField;
    private string lEVEL3CLLI__cField;
    private string lEVEL3TOSENDASRS__cField;
    private string lTID__cField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private string mEETPOINTIndicator__cField;
    private double? mRCSAVINGS__cField;
    private bool mRCSAVINGS__cFieldSpecified;
    private string mUXLOC__cField;
    private DateTime? manage_CPA__cField;
    private bool manage_CPA__cFieldSpecified;
    private string max_Network_Order_Number__cField;
    private string nETWORK_ORDER_NUMBER__cField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private DateTime? notify_customer__cField;
    private bool notify_customer__cFieldSpecified;
    private DateTime? oRDER_DW_CREATE_DT__cField;
    private bool oRDER_DW_CREATE_DT__cFieldSpecified;
    private string oRDER_STATUS__cField;
    private DateTime? orig_DCD__cField;
    private bool orig_DCD__cFieldSpecified;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private string pERFORMEDBY__cField;
    private string pERFORMER_NAME__cField;
    private double? pHASE_ORDER__cField;
    private bool pHASE_ORDER__cFieldSpecified;
    private DateTime? pLANNEDCOMPLETEDATE__cField;
    private bool pLANNEDCOMPLETEDATE__cFieldSpecified;
    private string pLANNER__cField;
    private double? pROCESS_ID__cField;
    private bool pROCESS_ID__cFieldSpecified;
    private string pROCESS_NAME__cField;
    private double? pROCESS_NID__cField;
    private bool pROCESS_NID__cFieldSpecified;
    private string pROCESS_STATUS_DESC__cField;
    private string pROJECTNAME__cField;
    private string pROJECT_TYPE__cField;
    private string pROVISIONINGID__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private DateTime? rCD__cField;
    private bool rCD__cFieldSpecified;
    private string rEQTYPE__cField;
    private DateTime? rEVISEDPLANNEDCOMPLETEDATE__cField;
    private bool rEVISEDPLANNEDCOMPLETEDATE__cFieldSpecified;
    private QueryResult recordAssociatedGroupsField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private DateTime? tASK_DUE_DT__cField;
    private bool tASK_DUE_DT__cFieldSpecified;
    private DateTime? tASK_END_TIME__cField;
    private bool tASK_END_TIME__cFieldSpecified;
    private double? tASK_ID__cField;
    private bool tASK_ID__cFieldSpecified;
    private string tASK_NAME__cField;
    private double? tASK_NID__cField;
    private bool tASK_NID__cFieldSpecified;
    private double? tASK_ORDER__cField;
    private bool tASK_ORDER__cFieldSpecified;
    private string tASK_PHASE_ORDER__cField;
    private string tASK_PHASE__cField;
    private DateTime? tASK_START_TIME__cField;
    private bool tASK_START_TIME__cFieldSpecified;
    private string tASK_STATUS__cField;
    private string tEST_ACTIONTYPEQUALIFIER__cField;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;
    private string vendorRollup__cField;
    private string vendor__cField;
    private double? wk_Bucket__cField;
    private bool wk_Bucket__cFieldSpecified;
    private string clli_a__cField;
    private string clli_z__cField;
    private DateTime? completed_date__cField;
    private bool completed_date__cFieldSpecified;
    private string jeop_code__cField;
    private DateTime? longPole_DCD__cField;
    private bool longPole_DCD__cFieldSpecified;
    private DateTime? longPole_JEOP_CREATE_DT__cField;
    private bool longPole_JEOP_CREATE_DT__cFieldSpecified;
    private string longPole_JeopCode__cField;
    private bool? manage_asr_wip__cField;
    private bool manage_asr_wip__cFieldSpecified;
    private string manager_gal__cField;
    private double? minphase__cField;
    private bool minphase__cFieldSpecified;
    private string vendor_pm__cField;

    [XmlElement(IsNullable = true)]
    public string ACTIONTYPEQUALIFIER__c
    {
      get => this.aCTIONTYPEQUALIFIER__cField;
      set => this.aCTIONTYPEQUALIFIER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? AGE__c
    {
      get => this.aGE__cField;
      set => this.aGE__cField = value;
    }

    [XmlIgnore]
    public bool AGE__cSpecified
    {
      get => this.aGE__cFieldSpecified;
      set => this.aGE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AMO_ECCKT_Data__r
    {
      get => this.aMO_ECCKT_Data__rField;
      set => this.aMO_ECCKT_Data__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_PON__c
    {
      get => this.aSR_PON__cField;
      set => this.aSR_PON__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ASR_SentDate__c
    {
      get => this.aSR_SentDate__cField;
      set => this.aSR_SentDate__cField = value;
    }

    [XmlIgnore]
    public bool ASR_SentDate__cSpecified
    {
      get => this.aSR_SentDate__cFieldSpecified;
      set => this.aSR_SentDate__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ActionableLabel__c
    {
      get => this.actionableLabel__cField;
      set => this.actionableLabel__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Actionable__c
    {
      get => this.actionable__cField;
      set => this.actionable__cField = value;
    }

    [XmlIgnore]
    public bool Actionable__cSpecified
    {
      get => this.actionable__cFieldSpecified;
      set => this.actionable__cFieldSpecified = value;
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
    public string BAN__c
    {
      get => this.bAN__cField;
      set => this.bAN__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Bandwidth__c
    {
      get => this.bandwidth__cField;
      set => this.bandwidth__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA__c
    {
      get => this.cFA__cField;
      set => this.cFA__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CHANNEL__c
    {
      get => this.cHANNEL__cField;
      set => this.cHANNEL__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CICS__c
    {
      get => this.cICS__cField;
      set => this.cICS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CIRCUIT_ID__c
    {
      get => this.cIRCUIT_ID__cField;
      set => this.cIRCUIT_ID__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? COMMITDATE__c
    {
      get => this.cOMMITDATE__cField;
      set => this.cOMMITDATE__cField = value;
    }

    [XmlIgnore]
    public bool COMMITDATE__cSpecified
    {
      get => this.cOMMITDATE__cFieldSpecified;
      set => this.cOMMITDATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string COMPANYCODE__c
    {
      get => this.cOMPANYCODE__cField;
      set => this.cOMPANYCODE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CONSOLIDATE_TASK_PHASE__c
    {
      get => this.cONSOLIDATE_TASK_PHASE__cField;
      set => this.cONSOLIDATE_TASK_PHASE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CPA_Dependency__c
    {
      get => this.cPA_Dependency__cField;
      set => this.cPA_Dependency__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CPA_IND__c
    {
      get => this.cPA_IND__cField;
      set => this.cPA_IND__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? CREATEDATE__c
    {
      get => this.cREATEDATE__cField;
      set => this.cREATEDATE__cField = value;
    }

    [XmlIgnore]
    public bool CREATEDATE__cSpecified
    {
      get => this.cREATEDATE__cFieldSpecified;
      set => this.cREATEDATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CUSTOMER_NAME__c
    {
      get => this.cUSTOMER_NAME__cField;
      set => this.cUSTOMER_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CUTLEVELCIRCUITS__c
    {
      get => this.cUTLEVELCIRCUITS__cField;
      set => this.cUTLEVELCIRCUITS__cField = value;
    }

    [XmlIgnore]
    public bool CUTLEVELCIRCUITS__cSpecified
    {
      get => this.cUTLEVELCIRCUITS__cFieldSpecified;
      set => this.cUTLEVELCIRCUITS__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CUTLEVELINDICATOR__c
    {
      get => this.cUTLEVELINDICATOR__cField;
      set => this.cUTLEVELINDICATOR__cField = value;
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
    public string DATA_SOURCE__c
    {
      get => this.dATA_SOURCE__cField;
      set => this.dATA_SOURCE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? DCD_Avg_Delta__c
    {
      get => this.dCD_Avg_Delta__cField;
      set => this.dCD_Avg_Delta__cField = value;
    }

    [XmlIgnore]
    public bool DCD_Avg_Delta__cSpecified
    {
      get => this.dCD_Avg_Delta__cFieldSpecified;
      set => this.dCD_Avg_Delta__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? DCD_Reset_Count__c
    {
      get => this.dCD_Reset_Count__cField;
      set => this.dCD_Reset_Count__cField = value;
    }

    [XmlIgnore]
    public bool DCD_Reset_Count__cSpecified
    {
      get => this.dCD_Reset_Count__cFieldSpecified;
      set => this.dCD_Reset_Count__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? DCD__c
    {
      get => this.dCD__cField;
      set => this.dCD__cField = value;
    }

    [XmlIgnore]
    public bool DCD__cSpecified
    {
      get => this.dCD__cFieldSpecified;
      set => this.dCD__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? DEFECT_COUNT__c
    {
      get => this.dEFECT_COUNT__cField;
      set => this.dEFECT_COUNT__cField = value;
    }

    [XmlIgnore]
    public bool DEFECT_COUNT__cSpecified
    {
      get => this.dEFECT_COUNT__cFieldSpecified;
      set => this.dEFECT_COUNT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Defect_Summary__c
    {
      get => this.defect_Summary__cField;
      set => this.defect_Summary__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string E911_IND__c
    {
      get => this.e911_IND__cField;
      set => this.e911_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKTRELATEDID__c
    {
      get => this.eCCKTRELATEDID__cField;
      set => this.eCCKTRELATEDID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_STATUS__c
    {
      get => this.eCCKT_STATUS__cField;
      set => this.eCCKT_STATUS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_STRIPPED__c
    {
      get => this.eCCKT_STRIPPED__cField;
      set => this.eCCKT_STRIPPED__cField = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? FOC_DATE__c
    {
      get => this.fOC_DATE__cField;
      set => this.fOC_DATE__cField = value;
    }

    [XmlIgnore]
    public bool FOC_DATE__cSpecified
    {
      get => this.fOC_DATE__cFieldSpecified;
      set => this.fOC_DATE__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? FSD_DATE__c
    {
      get => this.fSD_DATE__cField;
      set => this.fSD_DATE__cField = value;
    }

    [XmlIgnore]
    public bool FSD_DATE__cSpecified
    {
      get => this.fSD_DATE__cFieldSpecified;
      set => this.fSD_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HASEXCEPTION__c
    {
      get => this.hASEXCEPTION__cField;
      set => this.hASEXCEPTION__cField = value;
    }

    [XmlIgnore]
    public bool HASEXCEPTION__cSpecified
    {
      get => this.hASEXCEPTION__cFieldSpecified;
      set => this.hASEXCEPTION__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string HIERARCHYInd__c
    {
      get => this.hIERARCHYInd__cField;
      set => this.hIERARCHYInd__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string INSTANCE_IDENTIFIER__c
    {
      get => this.iNSTANCE_IDENTIFIER__cField;
      set => this.iNSTANCE_IDENTIFIER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ISJEOPED__c
    {
      get => this.iSJEOPED__cField;
      set => this.iSJEOPED__cField = value;
    }

    [XmlIgnore]
    public bool ISJEOPED__cSpecified
    {
      get => this.iSJEOPED__cFieldSpecified;
      set => this.iSJEOPED__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ITEMACTIONCODE__c
    {
      get => this.iTEMACTIONCODE__cField;
      set => this.iTEMACTIONCODE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string In_RSP__c
    {
      get => this.in_RSP__cField;
      set => this.in_RSP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Install_MRC__c
    {
      get => this.install_MRC__cField;
      set => this.install_MRC__cField = value;
    }

    [XmlIgnore]
    public bool Install_MRC__cSpecified
    {
      get => this.install_MRC__cFieldSpecified;
      set => this.install_MRC__cFieldSpecified = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? JEOP_CREATE_DT__c
    {
      get => this.jEOP_CREATE_DT__cField;
      set => this.jEOP_CREATE_DT__cField = value;
    }

    [XmlIgnore]
    public bool JEOP_CREATE_DT__cSpecified
    {
      get => this.jEOP_CREATE_DT__cFieldSpecified;
      set => this.jEOP_CREATE_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Jeop_age__c
    {
      get => this.jeop_age__cField;
      set => this.jeop_age__cField = value;
    }

    [XmlIgnore]
    public bool Jeop_age__cSpecified
    {
      get => this.jeop_age__cFieldSpecified;
      set => this.jeop_age__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LATA__c
    {
      get => this.lATA__cField;
      set => this.lATA__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LEVEL3CLLI__c
    {
      get => this.lEVEL3CLLI__cField;
      set => this.lEVEL3CLLI__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LEVEL3TOSENDASRS__c
    {
      get => this.lEVEL3TOSENDASRS__cField;
      set => this.lEVEL3TOSENDASRS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LTID__c
    {
      get => this.lTID__cField;
      set => this.lTID__cField = value;
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
    public string MEETPOINTIndicator__c
    {
      get => this.mEETPOINTIndicator__cField;
      set => this.mEETPOINTIndicator__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MRCSAVINGS__c
    {
      get => this.mRCSAVINGS__cField;
      set => this.mRCSAVINGS__cField = value;
    }

    [XmlIgnore]
    public bool MRCSAVINGS__cSpecified
    {
      get => this.mRCSAVINGS__cFieldSpecified;
      set => this.mRCSAVINGS__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MUXLOC__c
    {
      get => this.mUXLOC__cField;
      set => this.mUXLOC__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Manage_CPA__c
    {
      get => this.manage_CPA__cField;
      set => this.manage_CPA__cField = value;
    }

    [XmlIgnore]
    public bool Manage_CPA__cSpecified
    {
      get => this.manage_CPA__cFieldSpecified;
      set => this.manage_CPA__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Max_Network_Order_Number__c
    {
      get => this.max_Network_Order_Number__cField;
      set => this.max_Network_Order_Number__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETWORK_ORDER_NUMBER__c
    {
      get => this.nETWORK_ORDER_NUMBER__cField;
      set => this.nETWORK_ORDER_NUMBER__cField = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Notify_customer__c
    {
      get => this.notify_customer__cField;
      set => this.notify_customer__cField = value;
    }

    [XmlIgnore]
    public bool Notify_customer__cSpecified
    {
      get => this.notify_customer__cFieldSpecified;
      set => this.notify_customer__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? ORDER_DW_CREATE_DT__c
    {
      get => this.oRDER_DW_CREATE_DT__cField;
      set => this.oRDER_DW_CREATE_DT__cField = value;
    }

    [XmlIgnore]
    public bool ORDER_DW_CREATE_DT__cSpecified
    {
      get => this.oRDER_DW_CREATE_DT__cFieldSpecified;
      set => this.oRDER_DW_CREATE_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ORDER_STATUS__c
    {
      get => this.oRDER_STATUS__cField;
      set => this.oRDER_STATUS__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Orig_DCD__c
    {
      get => this.orig_DCD__cField;
      set => this.orig_DCD__cField = value;
    }

    [XmlIgnore]
    public bool Orig_DCD__cSpecified
    {
      get => this.orig_DCD__cFieldSpecified;
      set => this.orig_DCD__cFieldSpecified = value;
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
    public string PERFORMEDBY__c
    {
      get => this.pERFORMEDBY__cField;
      set => this.pERFORMEDBY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PERFORMER_NAME__c
    {
      get => this.pERFORMER_NAME__cField;
      set => this.pERFORMER_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PHASE_ORDER__c
    {
      get => this.pHASE_ORDER__cField;
      set => this.pHASE_ORDER__cField = value;
    }

    [XmlIgnore]
    public bool PHASE_ORDER__cSpecified
    {
      get => this.pHASE_ORDER__cFieldSpecified;
      set => this.pHASE_ORDER__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? PLANNEDCOMPLETEDATE__c
    {
      get => this.pLANNEDCOMPLETEDATE__cField;
      set => this.pLANNEDCOMPLETEDATE__cField = value;
    }

    [XmlIgnore]
    public bool PLANNEDCOMPLETEDATE__cSpecified
    {
      get => this.pLANNEDCOMPLETEDATE__cFieldSpecified;
      set => this.pLANNEDCOMPLETEDATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PLANNER__c
    {
      get => this.pLANNER__cField;
      set => this.pLANNER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PROCESS_ID__c
    {
      get => this.pROCESS_ID__cField;
      set => this.pROCESS_ID__cField = value;
    }

    [XmlIgnore]
    public bool PROCESS_ID__cSpecified
    {
      get => this.pROCESS_ID__cFieldSpecified;
      set => this.pROCESS_ID__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROCESS_NAME__c
    {
      get => this.pROCESS_NAME__cField;
      set => this.pROCESS_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PROCESS_NID__c
    {
      get => this.pROCESS_NID__cField;
      set => this.pROCESS_NID__cField = value;
    }

    [XmlIgnore]
    public bool PROCESS_NID__cSpecified
    {
      get => this.pROCESS_NID__cFieldSpecified;
      set => this.pROCESS_NID__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROCESS_STATUS_DESC__c
    {
      get => this.pROCESS_STATUS_DESC__cField;
      set => this.pROCESS_STATUS_DESC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECTNAME__c
    {
      get => this.pROJECTNAME__cField;
      set => this.pROJECTNAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECT_TYPE__c
    {
      get => this.pROJECT_TYPE__cField;
      set => this.pROJECT_TYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROVISIONINGID__c
    {
      get => this.pROVISIONINGID__cField;
      set => this.pROVISIONINGID__cField = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RCD__c
    {
      get => this.rCD__cField;
      set => this.rCD__cField = value;
    }

    [XmlIgnore]
    public bool RCD__cSpecified
    {
      get => this.rCD__cFieldSpecified;
      set => this.rCD__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string REQTYPE__c
    {
      get => this.rEQTYPE__cField;
      set => this.rEQTYPE__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? REVISEDPLANNEDCOMPLETEDATE__c
    {
      get => this.rEVISEDPLANNEDCOMPLETEDATE__cField;
      set => this.rEVISEDPLANNEDCOMPLETEDATE__cField = value;
    }

    [XmlIgnore]
    public bool REVISEDPLANNEDCOMPLETEDATE__cSpecified
    {
      get => this.rEVISEDPLANNEDCOMPLETEDATE__cFieldSpecified;
      set => this.rEVISEDPLANNEDCOMPLETEDATE__cFieldSpecified = value;
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

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? TASK_DUE_DT__c
    {
      get => this.tASK_DUE_DT__cField;
      set => this.tASK_DUE_DT__cField = value;
    }

    [XmlIgnore]
    public bool TASK_DUE_DT__cSpecified
    {
      get => this.tASK_DUE_DT__cFieldSpecified;
      set => this.tASK_DUE_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? TASK_END_TIME__c
    {
      get => this.tASK_END_TIME__cField;
      set => this.tASK_END_TIME__cField = value;
    }

    [XmlIgnore]
    public bool TASK_END_TIME__cSpecified
    {
      get => this.tASK_END_TIME__cFieldSpecified;
      set => this.tASK_END_TIME__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? TASK_ID__c
    {
      get => this.tASK_ID__cField;
      set => this.tASK_ID__cField = value;
    }

    [XmlIgnore]
    public bool TASK_ID__cSpecified
    {
      get => this.tASK_ID__cFieldSpecified;
      set => this.tASK_ID__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TASK_NAME__c
    {
      get => this.tASK_NAME__cField;
      set => this.tASK_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? TASK_NID__c
    {
      get => this.tASK_NID__cField;
      set => this.tASK_NID__cField = value;
    }

    [XmlIgnore]
    public bool TASK_NID__cSpecified
    {
      get => this.tASK_NID__cFieldSpecified;
      set => this.tASK_NID__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? TASK_ORDER__c
    {
      get => this.tASK_ORDER__cField;
      set => this.tASK_ORDER__cField = value;
    }

    [XmlIgnore]
    public bool TASK_ORDER__cSpecified
    {
      get => this.tASK_ORDER__cFieldSpecified;
      set => this.tASK_ORDER__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TASK_PHASE_ORDER__c
    {
      get => this.tASK_PHASE_ORDER__cField;
      set => this.tASK_PHASE_ORDER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TASK_PHASE__c
    {
      get => this.tASK_PHASE__cField;
      set => this.tASK_PHASE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? TASK_START_TIME__c
    {
      get => this.tASK_START_TIME__cField;
      set => this.tASK_START_TIME__cField = value;
    }

    [XmlIgnore]
    public bool TASK_START_TIME__cSpecified
    {
      get => this.tASK_START_TIME__cFieldSpecified;
      set => this.tASK_START_TIME__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TASK_STATUS__c
    {
      get => this.tASK_STATUS__cField;
      set => this.tASK_STATUS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TEST_ACTIONTYPEQUALIFIER__c
    {
      get => this.tEST_ACTIONTYPEQUALIFIER__cField;
      set => this.tEST_ACTIONTYPEQUALIFIER__cField = value;
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
    public string VendorRollup__c
    {
      get => this.vendorRollup__cField;
      set => this.vendorRollup__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Vendor__c
    {
      get => this.vendor__cField;
      set => this.vendor__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Wk_Bucket__c
    {
      get => this.wk_Bucket__cField;
      set => this.wk_Bucket__cField = value;
    }

    [XmlIgnore]
    public bool Wk_Bucket__cSpecified
    {
      get => this.wk_Bucket__cFieldSpecified;
      set => this.wk_Bucket__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string clli_a__c
    {
      get => this.clli_a__cField;
      set => this.clli_a__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string clli_z__c
    {
      get => this.clli_z__cField;
      set => this.clli_z__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? completed_date__c
    {
      get => this.completed_date__cField;
      set => this.completed_date__cField = value;
    }

    [XmlIgnore]
    public bool completed_date__cSpecified
    {
      get => this.completed_date__cFieldSpecified;
      set => this.completed_date__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string jeop_code__c
    {
      get => this.jeop_code__cField;
      set => this.jeop_code__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? longPole_DCD__c
    {
      get => this.longPole_DCD__cField;
      set => this.longPole_DCD__cField = value;
    }

    [XmlIgnore]
    public bool longPole_DCD__cSpecified
    {
      get => this.longPole_DCD__cFieldSpecified;
      set => this.longPole_DCD__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? longPole_JEOP_CREATE_DT__c
    {
      get => this.longPole_JEOP_CREATE_DT__cField;
      set => this.longPole_JEOP_CREATE_DT__cField = value;
    }

    [XmlIgnore]
    public bool longPole_JEOP_CREATE_DT__cSpecified
    {
      get => this.longPole_JEOP_CREATE_DT__cFieldSpecified;
      set => this.longPole_JEOP_CREATE_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string longPole_JeopCode__c
    {
      get => this.longPole_JeopCode__cField;
      set => this.longPole_JeopCode__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? manage_asr_wip__c
    {
      get => this.manage_asr_wip__cField;
      set => this.manage_asr_wip__cField = value;
    }

    [XmlIgnore]
    public bool manage_asr_wip__cSpecified
    {
      get => this.manage_asr_wip__cFieldSpecified;
      set => this.manage_asr_wip__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string manager_gal__c
    {
      get => this.manager_gal__cField;
      set => this.manager_gal__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? minphase__c
    {
      get => this.minphase__cField;
      set => this.minphase__cField = value;
    }

    [XmlIgnore]
    public bool minphase__cSpecified
    {
      get => this.minphase__cFieldSpecified;
      set => this.minphase__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string vendor_pm__c
    {
      get => this.vendor_pm__cField;
      set => this.vendor_pm__cField = value;
    }
  }
}
