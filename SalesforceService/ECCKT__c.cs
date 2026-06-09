// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ECCKT__c
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
  public class ECCKT__c : sObject
  {
    private string aCCESS_PLANNER__cField;
    private string aCCESS_TYPE__cField;
    private string aCNA_CD__cField;
    private string aEND_ASR_CLLI_CD__cField;
    private string aEND_CLLI_CD__cField;
    private string aEND_FRAB_AML_ID__cField;
    private string aEND_PROFIT_CTR_CD__cField;
    private string aEND_PROFIT_CTR_SOURCE_TYP__cField;
    private string aEND_REGION_CD__cField;
    private string aEND_SITE_ASR__cField;
    private SITE__c aEND_SITE_ASR__rField;
    private string aEND_SITE_CLEAN__cField;
    private SITE__c aEND_SITE_CLEAN__rField;
    private string aEND_SITE__cField;
    private SITE__c aEND_SITE__rField;
    private double? aIM_USD_TOTAL_MRC_AMT__cField;
    private bool aIM_USD_TOTAL_MRC_AMT__cFieldSpecified;
    private string aLT_BANDWIDTH_CD__cField;
    private string aPPROVED_VENDOR_IND__cField;
    private double? aSG_MRC_AMT__cField;
    private bool aSG_MRC_AMT__cFieldSpecified;
    private string aSR_ACTIVITY_DESC__cField;
    private string aSR_ACTL_CD__cField;
    private string aSR_ASG_CD__cField;
    private string aSR_BANDWIDTH_CD__cField;
    private string aSR_CANCELLED_IND__cField;
    private DateTime? aSR_CANCEL_SENT_DT__cField;
    private bool aSR_CANCEL_SENT_DT__cFieldSpecified;
    private double? aSR_CIC_CD__cField;
    private bool aSR_CIC_CD__cFieldSpecified;
    private string aSR_EXPEDITE_IND__cField;
    private string aSR_FACTL_CD__cField;
    private string aSR_MUX_LOC_CD__cField;
    private string aSR_NC1_CD__cField;
    private string aSR_PNUM_NBR__cField;
    private string aSR_REMARK_TXT__cField;
    private string aSR_REQUISITION_TYP__cField;
    private string aSR_RPON_NBR__cField;
    private string aSR_SECLOC_CD__cField;
    private string aSR_SPEC_CD__cField;
    private string aSR_STATUS_CD__cField;
    private double? aSR_SUB_BANDWIDTH_VALUE__cField;
    private bool aSR_SUB_BANDWIDTH_VALUE__cFieldSpecified;
    private double? aSR_TERM_MONTHS_QTY__cField;
    private bool aSR_TERM_MONTHS_QTY__cFieldSpecified;
    private string aSR_TSC_CD__cField;
    private string aSR_TSP_CD__cField;
    private string aSR_VTA_CD__cField;
    private string aSR_WRITER_NAME__cField;
    private string access_Carrier_Vendor__cField;
    private Account access_Carrier_Vendor__rField;
    private string action__cField;
    private QueryResult activityHistoriesField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bANDWIDTH_CD__cField;
    private string bAN_MERGE_IND__cField;
    private string bAN_NBR__cField;
    private DateTime? bILLING_CUSTOMER_TERM_END_DT__cField;
    private bool bILLING_CUSTOMER_TERM_END_DT__cFieldSpecified;
    private DateTime? bILLING_CUSTOMER_TERM_START_DT__cField;
    private bool bILLING_CUSTOMER_TERM_START_DT__cFieldSpecified;
    private string bILLING_CUST_ACCOUNT_NAME__cField;
    private string bILLING_CUST_ADDRESS__cField;
    private string bILLING_CUST_CITY_NAME__cField;
    private DateTime? bILLING_CUST_LAST_BILL_DT__cField;
    private bool bILLING_CUST_LAST_BILL_DT__cFieldSpecified;
    private DateTime? bILLING_CUST_SERV_INACTIVE_DT__cField;
    private bool bILLING_CUST_SERV_INACTIVE_DT__cFieldSpecified;
    private string bILLING_CUST_STATE_CD__cField;
    private double? bILLING_CUST_TERM_IN_MNTHS__cField;
    private bool bILLING_CUST_TERM_IN_MNTHS__cFieldSpecified;
    private double? bILLING_MRR__cField;
    private bool bILLING_MRR__cFieldSpecified;
    private string bILLING_PACKAGE_NAME__cField;
    private string bILLING_PRODUCT_COMPNT_ODS_ID__cField;
    private DateTime? bILL_EFFECT_DT__cField;
    private bool bILL_EFFECT_DT__cFieldSpecified;
    private string bILL_FREQ_DESC__cField;
    private string bUYING_PLAN_NAME__cField;
    private ACC_CAR_BUYING_PLAN__c bUYING_PLAN_NAME__rField;
    private string cARRIER_RELATIONS_MGR_NAME__cField;
    private string cCNA_CD__cField;
    private string cFA_NAME__cField;
    private string cFA_STRIPPED_NAME__cField;
    private double? cHANNEL_NBR__cField;
    private bool cHANNEL_NBR__cFieldSpecified;
    private string cITY_VENDOR_BANDWIDTH__cField;
    private string cLEAN_AEND_CLLI_CD__cField;
    private string cLEAN_AEND_SOURCE_SYSTEM_TYP__cField;
    private string cLEAN_ZEND_CLLI_CD__cField;
    private string cLEAN_ZEND_SOURCE_SYSTEM_TYP__cField;
    private QueryResult cLM_Export_Rows__rField;
    private string cOMPANY_CD__cField;
    private string cONTROLLING_TERMNT_VENDOR_CD__cField;
    private string cPA_IND__cField;
    private double? cRM_OPPORTUNITY_SAVINGS__cField;
    private bool cRM_OPPORTUNITY_SAVINGS__cFieldSpecified;
    private string cURRENCY_CD__cField;
    private double? chanTerm__cField;
    private bool chanTerm__cFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string dERIVED_BANDWIDTH__cField;
    private DateTime? dISCONNECT_DT__cField;
    private bool dISCONNECT_DT__cFieldSpecified;
    private DateTime? dW_CREATE_DT__cField;
    private bool dW_CREATE_DT__cFieldSpecified;
    private string dW_DELETED_IND__cField;
    private string dW_HASHCODE_TXT__cField;
    private DateTime? dW_LAST_MODIFY_DT__cField;
    private bool dW_LAST_MODIFY_DT__cFieldSpecified;
    private string dW_SOURCE_SYSTEM_CD__cField;
    private double? days_Since_Last_NetEx_Change__cField;
    private bool days_Since_Last_NetEx_Change__cFieldSpecified;
    private string do_Not_Touch_Reasons__cField;
    private QueryResult duplicateRecordItemsField;
    private bool? eCCKT_AML_ID_MATCH__cField;
    private bool eCCKT_AML_ID_MATCH__cFieldSpecified;
    private string eCCKT_AML_ID__cField;
    private QueryResult eCCKT_ICCKT_XREFS__rField;
    private string eCCKT_ICCKT_XREF__cField;
    private ProjectSubmissionsSvcLib.SalesforceService.ECCKT_ICCKT_XREF__c eCCKT_ICCKT_XREF__rField;
    private string eCCKT_KEY_ID__cField;
    private string eCCKT_RAW_NAME__cField;
    private string eCCKT_STATUS_CD__cField;
    private QueryResult eCCKT_SUPPLEMENTAL__rField;
    private string eCCKT_SUP__cField;
    private ECCKT_SUPPLEMENTAL__c eCCKT_SUP__rField;
    private double? eFFICIENT_MARKET_VALUE__cField;
    private bool eFFICIENT_MARKET_VALUE__cFieldSpecified;
    private double? eMV_Delta__cField;
    private bool eMV_Delta__cFieldSpecified;
    private double? eXCHANGE_RT__cField;
    private bool eXCHANGE_RT__cFieldSpecified;
    private string eXTRACTED_A_ACTL_CD__cField;
    private string eXTRACTED_A_CLLI_CD__cField;
    private string eXTRACTED_Z_ACTL_CD__cField;
    private string eXTRACTED_Z_CLLI_CD__cField;
    private QueryResult emailsField;
    private QueryResult eventsField;
    private DateTime? fIRST_BILL_DT__cField;
    private bool fIRST_BILL_DT__cFieldSpecified;
    private DateTime? fIRST_LOGGED_DT__cField;
    private bool fIRST_LOGGED_DT__cFieldSpecified;
    private double? fIRST_LOGGED_MRC_AMT__cField;
    private bool fIRST_LOGGED_MRC_AMT__cFieldSpecified;
    private DateTime? fOC_DT__cField;
    private bool fOC_DT__cFieldSpecified;
    private QueryResult feedSubscriptionsForEntityField;
    private double? fixedMilage__cField;
    private bool fixedMilage__cFieldSpecified;
    private string gL_CD__cField;
    private string gL_LOB_CD__cField;
    private string gL_PRODUCT_CD__cField;
    private QueryResult historiesField;
    private string iCCKT_AML_ID__cField;
    private ICCKT__c iCCKT_AML_ID__rField;
    private string iCSC_CD__cField;
    private string iNVOICE_FORMAT_CATEGORY_TYP__cField;
    private string iNVOICE_FORMAT_TYP__cField;
    private string iN_RFP__cField;
    private bool? iS_ORPHAN_LINKED__cField;
    private bool iS_ORPHAN_LINKED__cFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private DateTime? lAST_BILL_DT__cField;
    private bool lAST_BILL_DT__cFieldSpecified;
    private string lAST_BILL_GTZ_MRC_IND__cField;
    private double? lAST_GTZ_ASG_MRC_AMT__cField;
    private bool lAST_GTZ_ASG_MRC_AMT__cFieldSpecified;
    private double? lAST_GTZ_CKT_MRC_AMT__cField;
    private bool lAST_GTZ_CKT_MRC_AMT__cFieldSpecified;
    private DateTime? lAST_GTZ_MRC_BILL_DT__cField;
    private bool lAST_GTZ_MRC_BILL_DT__cFieldSpecified;
    private string lAST_GTZ_MRC_INV_DTL_ODS_ID__cField;
    private double? lAST_GTZ_TOT_MRC_AMT__cField;
    private bool lAST_GTZ_TOT_MRC_AMT__cFieldSpecified;
    private double? lAST_GTZ_TSC_MRC_AMT__cField;
    private bool lAST_GTZ_TSC_MRC_AMT__cFieldSpecified;
    private string lEGACY_COMPANY_NAME__cField;
    private string lTID_AML_ID__cField;
    private string lTID_NAME__cField;
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
    private double? last_Bill_Date_Days__cField;
    private bool last_Bill_Date_Days__cFieldSpecified;
    private QueryResult lookedUpFromActivitiesField;
    private string mAX_NOTE_CATEGORY__cField;
    private string mAX_NOTE_CREATED_BY__cField;
    private DateTime? mAX_NOTE_DATE__cField;
    private bool mAX_NOTE_DATE__cFieldSpecified;
    private string mAX_NOTE__cField;
    private string mEETPOINT_IND__cField;
    private string mONTH_TO_MONTH_CALCULATED__cField;
    private bool? mONTH_TO_MONTH_MANUAL__cField;
    private bool mONTH_TO_MONTH_MANUAL__cFieldSpecified;
    private double? mRC_AMT__cField;
    private bool mRC_AMT__cFieldSpecified;
    private string mUX_IND__cField;
    private string mUX_LOC_SITE_ASR__cField;
    private SITE__c mUX_LOC_SITE_ASR__rField;
    private string mUX_LOC_SITE__cField;
    private SITE__c mUX_LOC_SITE__rField;
    private double? muxUsoc__cField;
    private bool muxUsoc__cFieldSpecified;
    private string nCI_CD__cField;
    private string nC_CD__cField;
    private string nETEX_ACNA_CD__cField;
    private string nETEX_ACTL_CD__cField;
    private string nETEX_CCNA_CD__cField;
    private string nETEX_CFA_NAME__cField;
    private string nETEX_CUSTOMER_NAME__cField;
    private string nETEX_ICSC_CD__cField;
    private string nETEX_MRP1_CD__cField;
    private string nETEX_MRP2_CD__cField;
    private double? nETEX_PIU_RT__cField;
    private bool nETEX_PIU_RT__cFieldSpecified;
    private string nETEX_PNUM_NBR__cField;
    private string nETEX_PURCHASE_ORDER_NBR__cField;
    private DateTime? nETEX_SERV_ESTBL_DT__cField;
    private bool nETEX_SERV_ESTBL_DT__cFieldSpecified;
    private string nETEX_SPEC_CD__cField;
    private string nETEX_SUPPLIER_BILL_ACCT_NBR__cField;
    private string nETEX_SUPPLIER_PLAN_ID__cField;
    private DateTime? nETEX_TERM_AGREE_END_DT__cField;
    private bool nETEX_TERM_AGREE_END_DT__cFieldSpecified;
    private DateTime? nETEX_TERM_AGREE_START_DT__cField;
    private bool nETEX_TERM_AGREE_START_DT__cFieldSpecified;
    private double? nETEX_TERM_LENGTH_MONTHS_NBR__cField;
    private bool nETEX_TERM_LENGTH_MONTHS_NBR__cFieldSpecified;
    private string nETEX_TRAIL_NAME__cField;
    private string nETEX_VTA_CD__cField;
    private string nOTE_LOG__cField;
    private double? nRC_AMT__cField;
    private bool nRC_AMT__cFieldSpecified;
    private string nameField;
    private DateTime? netEx_Last_Change_Date__cField;
    private bool netEx_Last_Change_Date__cFieldSpecified;
    private DateTime? netEx_Term_Agree_End_Last_Change_Date__cField;
    private bool netEx_Term_Agree_End_Last_Change_Date__cFieldSpecified;
    private DateTime? netEx_Term_Agree_Start_Last_Change_Date__cField;
    private bool netEx_Term_Agree_Start_Last_Change_Date__cFieldSpecified;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private string oCC_DISCOUNT_ESTIMATE_IND__cField;
    private double? oCC_DISCOUNT_MRC_AMT__cField;
    private bool oCC_DISCOUNT_MRC_AMT__cFieldSpecified;
    private string oCN_CD__cField;
    private string oCN_NAME__cField;
    private string oDM_SOURCE_SYSTEM_ID__cField;
    private DateTime? oDM_TERM_AGREE_END_DT__cField;
    private bool oDM_TERM_AGREE_END_DT__cFieldSpecified;
    private DateTime? oDM_TERM_AGREE_START_DT__cField;
    private bool oDM_TERM_AGREE_START_DT__cFieldSpecified;
    private double? oDM_TERM_LENGTH_QTY__cField;
    private bool oDM_TERM_LENGTH_QTY__cFieldSpecified;
    private string oDM_TERM_STATUS_CD__cField;
    private string oDM_VENDOR_NAME__cField;
    private string oDM_VENDOR_ODS_ID__cField;
    private bool? oDM_VNN_2_AML_VNN__cField;
    private bool oDM_VNN_2_AML_VNN__cFieldSpecified;
    private string oFFNET_ORDER_ODS_ID__cField;
    private string oFFNET_OVERRIDE_ODS_ID__cField;
    private string oFFNET_VENDOR_ODS_ID__cField;
    private string oFF_TO_ONNET_NOTE__cField;
    private QueryResult openActivitiesField;
    private QueryResult opportunities__rField;
    private double? other_USOC_Charges__cField;
    private bool other_USOC_Charges__cFieldSpecified;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private string pC_AEND_CITY_NAME__cField;
    private string pC_AEND_CLLI_CD__cField;
    private string pC_AEND_LINE1_ADDR__cField;
    private string pC_AEND_POSTAL_CD__cField;
    private string pC_AEND_STATE_CD__cField;
    private DateTime? pC_AMS_QUOTE_DT__cField;
    private bool pC_AMS_QUOTE_DT__cFieldSpecified;
    private string pC_AMS_SOLUTION_ID__cField;
    private string pC_BANDWIDTH_CD__cField;
    private string pC_CUST_ORDER_NBR__cField;
    private string pC_DERIVED_ECCKT_ACTION_TYP__cField;
    private string pC_OFFNET_SOLUTION_TYP__cField;
    private string pC_ORDER_VENDOR_NAME__cField;
    private string pC_OVERRIDE_IND__cField;
    private string pC_PLANNED_BILLED_COST_AML_ID__cField;
    private string pC_PRODUCT_ELEM_ID__cField;
    private string pC_PRODUCT_INST_ID__cField;
    private string pC_QUOTE_NBR__cField;
    private string pC_RESEARCH_CD__cField;
    private string pC_RESEARCH_NOTE_TXT__cField;
    private string pC_RESEARCH_OWNER_NAME__cField;
    private string pC_ROLLUP_TYP__cField;
    private string pC_SEGMENT_TYP__cField;
    private string pC_SERV_COMPNT_ID__cField;
    private string pC_SERV_ORDER_NBR__cField;
    private double? pC_TERM_MONTHS_QTY__cField;
    private bool pC_TERM_MONTHS_QTY__cFieldSpecified;
    private string pC_VENDOR_QUOTE_TYP__cField;
    private double? pC_VENDOR_USD_MRC_AMT__cField;
    private bool pC_VENDOR_USD_MRC_AMT__cFieldSpecified;
    private double? pC_VENDOR_USD_NRC_AMT__cField;
    private bool pC_VENDOR_USD_NRC_AMT__cFieldSpecified;
    private string pC_WF_JEOP_AMS_SOLUTION_ID__cField;
    private string pC_WF_JEOP_CONSTRAINT_TXT__cField;
    private double? pC_WF_JEOP_NEW_MRC_AMT__cField;
    private bool pC_WF_JEOP_NEW_MRC_AMT__cFieldSpecified;
    private string pC_ZEND_CITY_NAME__cField;
    private string pC_ZEND_CLLI_CD__cField;
    private string pC_ZEND_LINE1_ADDR__cField;
    private string pC_ZEND_POSTAL_CD__cField;
    private string pC_ZEND_STATE_CD__cField;
    private string pIU_RT__cField;
    private string pLANNER_REVIEW_NOTE__cField;
    private string pLU_RT__cField;
    private bool? pNUM_Comparison__cField;
    private bool pNUM_Comparison__cFieldSpecified;
    private string pON_NBR__cField;
    private string pON_VERSION_NBR__cField;
    private string pRODUCT_INST_ID_SOURCE_NAME__cField;
    private string pRODUCT_INST_ID__cField;
    private string pROJECT_ID__cField;
    private PROJECT_HEADER__c pROJECT_ID__rField;
    private string pROVIDER_ORDER_NBR__cField;
    private string pc_Drill_Down_ECCKT_List__cField;
    private QueryResult phoenix_Notes__rField;
    private QueryResult prime_Notes__rField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private QueryResult project_Items__rField;
    private string rEV_PRODUCT_COMPNT_ID_TYP__cField;
    private string rEV_PRODUCT_COMPNT_ID__cField;
    private double? rFP_BID_RATE__cField;
    private bool rFP_BID_RATE__cFieldSpecified;
    private QueryResult rFP_Quotes__rField;
    private string rFT_APPROVAL_COMMENTS__cField;
    private string rFT_BANDWIDTH__cField;
    private string rFT_BTP_BAN__cField;
    private DateTime? rFT_BTP_BILL_DATE__cField;
    private bool rFT_BTP_BILL_DATE__cFieldSpecified;
    private string rFT_COMMENTS__cField;
    private string rFT_CRM__cField;
    private DateTime? rFT_CUSTOMER_REQUESTED_DATE__cField;
    private bool rFT_CUSTOMER_REQUESTED_DATE__cFieldSpecified;
    private string rFT_DECISION_TREE__cField;
    private DateTime? rFT_DISCONNECT_FOC_DATE__cField;
    private bool rFT_DISCONNECT_FOC_DATE__cFieldSpecified;
    private string rFT_DISCONNECT_PON__cField;
    private double? rFT_ESTIMATED_TL_AMOUNT__cField;
    private bool rFT_ESTIMATED_TL_AMOUNT__cFieldSpecified;
    private string rFT_HFT_CIRCUIT_ID__cField;
    private string rFT_HFT_PORTABILITY_CATEGORY__cField;
    private string rFT_INTERNAL_CIRCUIT_ID__cField;
    private string rFT_LEVEL3_DISCONNECT_ORDER_NBR__cField;
    private string rFT_Legacy_Windu_Wrkflw_ID__cField;
    private double? rFT_MITIGATED_TL_AMOUNT__cField;
    private bool rFT_MITIGATED_TL_AMOUNT__cFieldSpecified;
    private double? rFT_ORIGINAL_CIRCUIT_TERM__cField;
    private bool rFT_ORIGINAL_CIRCUIT_TERM__cFieldSpecified;
    private string rFT_ORIGINAL_INSTALL_PON__cField;
    private string rFT_Original_Requested_By__cField;
    private string rFT_PROJECT_ID__cField;
    private DateTime? rFT_RELEASE_DATE__cField;
    private bool rFT_RELEASE_DATE__cFieldSpecified;
    private DateTime? rFT_RELEASE_INVENTORY_DATE__cField;
    private bool rFT_RELEASE_INVENTORY_DATE__cFieldSpecified;
    private DateTime? rFT_RFA_APPROVAL_DATE__cField;
    private bool rFT_RFA_APPROVAL_DATE__cFieldSpecified;
    private string rFT_RFA_Number__cField;
    private string rFT_RFA_Status__cField;
    private string rFT_RFT_STATUS__cField;
    private string rFT_Reject_to_SA_Comments__cField;
    private string rFT_Requested_By__cField;
    private double? rFT_Status_Age__cField;
    private bool rFT_Status_Age__cFieldSpecified;
    private DateTime? rFT_Status_Date__cField;
    private bool rFT_Status_Date__cFieldSpecified;
    private string rFT_VENDOR_SERVICE_ORDER_NBR__cField;
    private QueryResult recordAssociatedGroupsField;
    private string sCFA_NAME__cField;
    private string sEGMENT_TYPE_SEQ_NBR__cField;
    private string sEG_TYP__cField;
    private string sERVICE_TYP__cField;
    private string sERV_COMPNT_ID_SOURCE_NAME__cField;
    private string sERV_COMPNT_ID__cField;
    private string sOURCE_BANDWIDTH_CD__cField;
    private DateTime? sOURCE_CREATE_DT__cField;
    private bool sOURCE_CREATE_DT__cFieldSpecified;
    private DateTime? sOURCE_LAST_MODIFY_DT__cField;
    private bool sOURCE_LAST_MODIFY_DT__cFieldSpecified;
    private string sOURCE_LAST_MODIFY_USER_ID__cField;
    private double? sRC_ASG_MRC_AMT__cField;
    private bool sRC_ASG_MRC_AMT__cFieldSpecified;
    private double? sRC_FIRST_LOGGED_MRC_AMT__cField;
    private bool sRC_FIRST_LOGGED_MRC_AMT__cFieldSpecified;
    private double? sRC_MRC_AMT__cField;
    private bool sRC_MRC_AMT__cFieldSpecified;
    private double? sRC_NRC_AMT__cField;
    private bool sRC_NRC_AMT__cFieldSpecified;
    private double? sRC_OCC_DISCOUNT_MRC_AMT__cField;
    private bool sRC_OCC_DISCOUNT_MRC_AMT__cFieldSpecified;
    private double? sRC_TOTAL_MRC_AMT__cField;
    private bool sRC_TOTAL_MRC_AMT__cFieldSpecified;
    private double? sRC_TSC_MRC_AMT__cField;
    private bool sRC_TSC_MRC_AMT__cFieldSpecified;
    private double? sUB_BANDWIDTH_VALUE__cField;
    private bool sUB_BANDWIDTH_VALUE__cFieldSpecified;
    private string sUPPLIER_CIRCUIT_ODS_ID__cField;
    private DateTime? sVC_ESTABLISH_DT__cField;
    private bool sVC_ESTABLISH_DT__cFieldSpecified;
    private bool? sYSTEM_ID_AML_VS_ODM__cField;
    private bool sYSTEM_ID_AML_VS_ODM__cFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string system_ID_from_ODM__cField;
    private double? tARGET_MARKET_RATE__cField;
    private bool tARGET_MARKET_RATE__cFieldSpecified;
    private DateTime? tERM_END_DT__cField;
    private bool tERM_END_DT__cFieldSpecified;
    private bool? tERM_END_PHOENIX_VS_NETEX__cField;
    private bool tERM_END_PHOENIX_VS_NETEX__cFieldSpecified;
    private double? tERM_LENGTH_NBR__cField;
    private bool tERM_LENGTH_NBR__cFieldSpecified;
    private DateTime? tERM_START_DT__cField;
    private bool tERM_START_DT__cFieldSpecified;
    private double? tOTAL_MRC_AMT__cField;
    private bool tOTAL_MRC_AMT__cFieldSpecified;
    private string tRAIL_ODS_ID__cField;
    private double? tSC_MRC_AMT__cField;
    private bool tSC_MRC_AMT__cFieldSpecified;
    private bool? tSC_ONLY_CHARGE__cField;
    private bool tSC_ONLY_CHARGE__cFieldSpecified;
    private QueryResult tasksField;
    private string term_Status_from_ODM__cField;
    private QueryResult topicAssignmentsField;
    private DateTime? total_MRC_Last_Change_Date__cField;
    private bool total_MRC_Last_Change_Date__cFieldSpecified;
    private QueryResult uSOC_SUMMARIES__rField;
    private UserRecordAccess userRecordAccessField;
    private string vBR_BILL_ACCOUNT_TYPE_CD__cField;
    private string vBR_BILL_ACCOUNT_TYPE_DESC__cField;
    private string vENDOR_NAME__cField;
    private string vENDOR_NORMALIZED_NAME__cField;
    private string vENDOR_PARENT_NAME__cField;
    private string vENDOR_RELATIONSHIP_TYP__cField;
    private string vENDOR_TYP__cField;
    private bool? vNNtoODM_Name__cField;
    private bool vNNtoODM_Name__cFieldSpecified;
    private double? variableMileage__cField;
    private bool variableMileage__cFieldSpecified;
    private bool? vendorMatch__cField;
    private bool vendorMatch__cFieldSpecified;
    private string zEND_ASR_CLLI_CD__cField;
    private string zEND_CLLI_CD__cField;
    private string zEND_FRAB_AML_ID__cField;
    private string zEND_PROFIT_CTR_CD__cField;
    private string zEND_PROFIT_CTR_SOURCE_TYP__cField;
    private string zEND_REGION_CD__cField;
    private string zEND_SITE_ASR__cField;
    private SITE__c zEND_SITE_ASR__rField;
    private string zEND_SITE_CLEAN__cField;
    private SITE__c zEND_SITE_CLEAN__rField;
    private string zEND_SITE__cField;
    private SITE__c zEND_SITE__rField;

    [XmlElement(IsNullable = true)]
    public string ACCESS_PLANNER__c
    {
      get => this.aCCESS_PLANNER__cField;
      set => this.aCCESS_PLANNER__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACCESS_TYPE__c
    {
      get => this.aCCESS_TYPE__cField;
      set => this.aCCESS_TYPE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ACNA_CD__c
    {
      get => this.aCNA_CD__cField;
      set => this.aCNA_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_ASR_CLLI_CD__c
    {
      get => this.aEND_ASR_CLLI_CD__cField;
      set => this.aEND_ASR_CLLI_CD__cField = value;
    }

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
    public string AEND_PROFIT_CTR_CD__c
    {
      get => this.aEND_PROFIT_CTR_CD__cField;
      set => this.aEND_PROFIT_CTR_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_PROFIT_CTR_SOURCE_TYP__c
    {
      get => this.aEND_PROFIT_CTR_SOURCE_TYP__cField;
      set => this.aEND_PROFIT_CTR_SOURCE_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_REGION_CD__c
    {
      get => this.aEND_REGION_CD__cField;
      set => this.aEND_REGION_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AEND_SITE_ASR__c
    {
      get => this.aEND_SITE_ASR__cField;
      set => this.aEND_SITE_ASR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SITE__c AEND_SITE_ASR__r
    {
      get => this.aEND_SITE_ASR__rField;
      set => this.aEND_SITE_ASR__rField = value;
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
    public double? AIM_USD_TOTAL_MRC_AMT__c
    {
      get => this.aIM_USD_TOTAL_MRC_AMT__cField;
      set => this.aIM_USD_TOTAL_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool AIM_USD_TOTAL_MRC_AMT__cSpecified
    {
      get => this.aIM_USD_TOTAL_MRC_AMT__cFieldSpecified;
      set => this.aIM_USD_TOTAL_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ALT_BANDWIDTH_CD__c
    {
      get => this.aLT_BANDWIDTH_CD__cField;
      set => this.aLT_BANDWIDTH_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string APPROVED_VENDOR_IND__c
    {
      get => this.aPPROVED_VENDOR_IND__cField;
      set => this.aPPROVED_VENDOR_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ASG_MRC_AMT__c
    {
      get => this.aSG_MRC_AMT__cField;
      set => this.aSG_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool ASG_MRC_AMT__cSpecified
    {
      get => this.aSG_MRC_AMT__cFieldSpecified;
      set => this.aSG_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_ACTIVITY_DESC__c
    {
      get => this.aSR_ACTIVITY_DESC__cField;
      set => this.aSR_ACTIVITY_DESC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_ACTL_CD__c
    {
      get => this.aSR_ACTL_CD__cField;
      set => this.aSR_ACTL_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_ASG_CD__c
    {
      get => this.aSR_ASG_CD__cField;
      set => this.aSR_ASG_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_BANDWIDTH_CD__c
    {
      get => this.aSR_BANDWIDTH_CD__cField;
      set => this.aSR_BANDWIDTH_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_CANCELLED_IND__c
    {
      get => this.aSR_CANCELLED_IND__cField;
      set => this.aSR_CANCELLED_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ASR_CANCEL_SENT_DT__c
    {
      get => this.aSR_CANCEL_SENT_DT__cField;
      set => this.aSR_CANCEL_SENT_DT__cField = value;
    }

    [XmlIgnore]
    public bool ASR_CANCEL_SENT_DT__cSpecified
    {
      get => this.aSR_CANCEL_SENT_DT__cFieldSpecified;
      set => this.aSR_CANCEL_SENT_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ASR_CIC_CD__c
    {
      get => this.aSR_CIC_CD__cField;
      set => this.aSR_CIC_CD__cField = value;
    }

    [XmlIgnore]
    public bool ASR_CIC_CD__cSpecified
    {
      get => this.aSR_CIC_CD__cFieldSpecified;
      set => this.aSR_CIC_CD__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_EXPEDITE_IND__c
    {
      get => this.aSR_EXPEDITE_IND__cField;
      set => this.aSR_EXPEDITE_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_FACTL_CD__c
    {
      get => this.aSR_FACTL_CD__cField;
      set => this.aSR_FACTL_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_MUX_LOC_CD__c
    {
      get => this.aSR_MUX_LOC_CD__cField;
      set => this.aSR_MUX_LOC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_NC1_CD__c
    {
      get => this.aSR_NC1_CD__cField;
      set => this.aSR_NC1_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_PNUM_NBR__c
    {
      get => this.aSR_PNUM_NBR__cField;
      set => this.aSR_PNUM_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_REMARK_TXT__c
    {
      get => this.aSR_REMARK_TXT__cField;
      set => this.aSR_REMARK_TXT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_REQUISITION_TYP__c
    {
      get => this.aSR_REQUISITION_TYP__cField;
      set => this.aSR_REQUISITION_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_RPON_NBR__c
    {
      get => this.aSR_RPON_NBR__cField;
      set => this.aSR_RPON_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_SECLOC_CD__c
    {
      get => this.aSR_SECLOC_CD__cField;
      set => this.aSR_SECLOC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_SPEC_CD__c
    {
      get => this.aSR_SPEC_CD__cField;
      set => this.aSR_SPEC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_STATUS_CD__c
    {
      get => this.aSR_STATUS_CD__cField;
      set => this.aSR_STATUS_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ASR_SUB_BANDWIDTH_VALUE__c
    {
      get => this.aSR_SUB_BANDWIDTH_VALUE__cField;
      set => this.aSR_SUB_BANDWIDTH_VALUE__cField = value;
    }

    [XmlIgnore]
    public bool ASR_SUB_BANDWIDTH_VALUE__cSpecified
    {
      get => this.aSR_SUB_BANDWIDTH_VALUE__cFieldSpecified;
      set => this.aSR_SUB_BANDWIDTH_VALUE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ASR_TERM_MONTHS_QTY__c
    {
      get => this.aSR_TERM_MONTHS_QTY__cField;
      set => this.aSR_TERM_MONTHS_QTY__cField = value;
    }

    [XmlIgnore]
    public bool ASR_TERM_MONTHS_QTY__cSpecified
    {
      get => this.aSR_TERM_MONTHS_QTY__cFieldSpecified;
      set => this.aSR_TERM_MONTHS_QTY__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_TSC_CD__c
    {
      get => this.aSR_TSC_CD__cField;
      set => this.aSR_TSC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_TSP_CD__c
    {
      get => this.aSR_TSP_CD__cField;
      set => this.aSR_TSP_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_VTA_CD__c
    {
      get => this.aSR_VTA_CD__cField;
      set => this.aSR_VTA_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ASR_WRITER_NAME__c
    {
      get => this.aSR_WRITER_NAME__cField;
      set => this.aSR_WRITER_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Access_Carrier_Vendor__c
    {
      get => this.access_Carrier_Vendor__cField;
      set => this.access_Carrier_Vendor__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account Access_Carrier_Vendor__r
    {
      get => this.access_Carrier_Vendor__rField;
      set => this.access_Carrier_Vendor__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Action__c
    {
      get => this.action__cField;
      set => this.action__cField = value;
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
    public string BAN_MERGE_IND__c
    {
      get => this.bAN_MERGE_IND__cField;
      set => this.bAN_MERGE_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BAN_NBR__c
    {
      get => this.bAN_NBR__cField;
      set => this.bAN_NBR__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? BILLING_CUSTOMER_TERM_END_DT__c
    {
      get => this.bILLING_CUSTOMER_TERM_END_DT__cField;
      set => this.bILLING_CUSTOMER_TERM_END_DT__cField = value;
    }

    [XmlIgnore]
    public bool BILLING_CUSTOMER_TERM_END_DT__cSpecified
    {
      get => this.bILLING_CUSTOMER_TERM_END_DT__cFieldSpecified;
      set => this.bILLING_CUSTOMER_TERM_END_DT__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? BILLING_CUSTOMER_TERM_START_DT__c
    {
      get => this.bILLING_CUSTOMER_TERM_START_DT__cField;
      set => this.bILLING_CUSTOMER_TERM_START_DT__cField = value;
    }

    [XmlIgnore]
    public bool BILLING_CUSTOMER_TERM_START_DT__cSpecified
    {
      get => this.bILLING_CUSTOMER_TERM_START_DT__cFieldSpecified;
      set => this.bILLING_CUSTOMER_TERM_START_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string BILLING_CUST_ACCOUNT_NAME__c
    {
      get => this.bILLING_CUST_ACCOUNT_NAME__cField;
      set => this.bILLING_CUST_ACCOUNT_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BILLING_CUST_ADDRESS__c
    {
      get => this.bILLING_CUST_ADDRESS__cField;
      set => this.bILLING_CUST_ADDRESS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BILLING_CUST_CITY_NAME__c
    {
      get => this.bILLING_CUST_CITY_NAME__cField;
      set => this.bILLING_CUST_CITY_NAME__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? BILLING_CUST_LAST_BILL_DT__c
    {
      get => this.bILLING_CUST_LAST_BILL_DT__cField;
      set => this.bILLING_CUST_LAST_BILL_DT__cField = value;
    }

    [XmlIgnore]
    public bool BILLING_CUST_LAST_BILL_DT__cSpecified
    {
      get => this.bILLING_CUST_LAST_BILL_DT__cFieldSpecified;
      set => this.bILLING_CUST_LAST_BILL_DT__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? BILLING_CUST_SERV_INACTIVE_DT__c
    {
      get => this.bILLING_CUST_SERV_INACTIVE_DT__cField;
      set => this.bILLING_CUST_SERV_INACTIVE_DT__cField = value;
    }

    [XmlIgnore]
    public bool BILLING_CUST_SERV_INACTIVE_DT__cSpecified
    {
      get => this.bILLING_CUST_SERV_INACTIVE_DT__cFieldSpecified;
      set => this.bILLING_CUST_SERV_INACTIVE_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string BILLING_CUST_STATE_CD__c
    {
      get => this.bILLING_CUST_STATE_CD__cField;
      set => this.bILLING_CUST_STATE_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? BILLING_CUST_TERM_IN_MNTHS__c
    {
      get => this.bILLING_CUST_TERM_IN_MNTHS__cField;
      set => this.bILLING_CUST_TERM_IN_MNTHS__cField = value;
    }

    [XmlIgnore]
    public bool BILLING_CUST_TERM_IN_MNTHS__cSpecified
    {
      get => this.bILLING_CUST_TERM_IN_MNTHS__cFieldSpecified;
      set => this.bILLING_CUST_TERM_IN_MNTHS__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? BILLING_MRR__c
    {
      get => this.bILLING_MRR__cField;
      set => this.bILLING_MRR__cField = value;
    }

    [XmlIgnore]
    public bool BILLING_MRR__cSpecified
    {
      get => this.bILLING_MRR__cFieldSpecified;
      set => this.bILLING_MRR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string BILLING_PACKAGE_NAME__c
    {
      get => this.bILLING_PACKAGE_NAME__cField;
      set => this.bILLING_PACKAGE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BILLING_PRODUCT_COMPNT_ODS_ID__c
    {
      get => this.bILLING_PRODUCT_COMPNT_ODS_ID__cField;
      set => this.bILLING_PRODUCT_COMPNT_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? BILL_EFFECT_DT__c
    {
      get => this.bILL_EFFECT_DT__cField;
      set => this.bILL_EFFECT_DT__cField = value;
    }

    [XmlIgnore]
    public bool BILL_EFFECT_DT__cSpecified
    {
      get => this.bILL_EFFECT_DT__cFieldSpecified;
      set => this.bILL_EFFECT_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string BILL_FREQ_DESC__c
    {
      get => this.bILL_FREQ_DESC__cField;
      set => this.bILL_FREQ_DESC__cField = value;
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
    public string CARRIER_RELATIONS_MGR_NAME__c
    {
      get => this.cARRIER_RELATIONS_MGR_NAME__cField;
      set => this.cARRIER_RELATIONS_MGR_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CCNA_CD__c
    {
      get => this.cCNA_CD__cField;
      set => this.cCNA_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA_NAME__c
    {
      get => this.cFA_NAME__cField;
      set => this.cFA_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CFA_STRIPPED_NAME__c
    {
      get => this.cFA_STRIPPED_NAME__cField;
      set => this.cFA_STRIPPED_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CHANNEL_NBR__c
    {
      get => this.cHANNEL_NBR__cField;
      set => this.cHANNEL_NBR__cField = value;
    }

    [XmlIgnore]
    public bool CHANNEL_NBR__cSpecified
    {
      get => this.cHANNEL_NBR__cFieldSpecified;
      set => this.cHANNEL_NBR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CITY_VENDOR_BANDWIDTH__c
    {
      get => this.cITY_VENDOR_BANDWIDTH__cField;
      set => this.cITY_VENDOR_BANDWIDTH__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLEAN_AEND_CLLI_CD__c
    {
      get => this.cLEAN_AEND_CLLI_CD__cField;
      set => this.cLEAN_AEND_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLEAN_AEND_SOURCE_SYSTEM_TYP__c
    {
      get => this.cLEAN_AEND_SOURCE_SYSTEM_TYP__cField;
      set => this.cLEAN_AEND_SOURCE_SYSTEM_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLEAN_ZEND_CLLI_CD__c
    {
      get => this.cLEAN_ZEND_CLLI_CD__cField;
      set => this.cLEAN_ZEND_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CLEAN_ZEND_SOURCE_SYSTEM_TYP__c
    {
      get => this.cLEAN_ZEND_SOURCE_SYSTEM_TYP__cField;
      set => this.cLEAN_ZEND_SOURCE_SYSTEM_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CLM_Export_Rows__r
    {
      get => this.cLM_Export_Rows__rField;
      set => this.cLM_Export_Rows__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string COMPANY_CD__c
    {
      get => this.cOMPANY_CD__cField;
      set => this.cOMPANY_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CONTROLLING_TERMNT_VENDOR_CD__c
    {
      get => this.cONTROLLING_TERMNT_VENDOR_CD__cField;
      set => this.cONTROLLING_TERMNT_VENDOR_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CPA_IND__c
    {
      get => this.cPA_IND__cField;
      set => this.cPA_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? CRM_OPPORTUNITY_SAVINGS__c
    {
      get => this.cRM_OPPORTUNITY_SAVINGS__cField;
      set => this.cRM_OPPORTUNITY_SAVINGS__cField = value;
    }

    [XmlIgnore]
    public bool CRM_OPPORTUNITY_SAVINGS__cSpecified
    {
      get => this.cRM_OPPORTUNITY_SAVINGS__cFieldSpecified;
      set => this.cRM_OPPORTUNITY_SAVINGS__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CURRENCY_CD__c
    {
      get => this.cURRENCY_CD__cField;
      set => this.cURRENCY_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ChanTerm__c
    {
      get => this.chanTerm__cField;
      set => this.chanTerm__cField = value;
    }

    [XmlIgnore]
    public bool ChanTerm__cSpecified
    {
      get => this.chanTerm__cFieldSpecified;
      set => this.chanTerm__cFieldSpecified = value;
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
    public string DERIVED_BANDWIDTH__c
    {
      get => this.dERIVED_BANDWIDTH__cField;
      set => this.dERIVED_BANDWIDTH__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? DISCONNECT_DT__c
    {
      get => this.dISCONNECT_DT__cField;
      set => this.dISCONNECT_DT__cField = value;
    }

    [XmlIgnore]
    public bool DISCONNECT_DT__cSpecified
    {
      get => this.dISCONNECT_DT__cFieldSpecified;
      set => this.dISCONNECT_DT__cFieldSpecified = value;
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
    public double? Days_Since_Last_NetEx_Change__c
    {
      get => this.days_Since_Last_NetEx_Change__cField;
      set => this.days_Since_Last_NetEx_Change__cField = value;
    }

    [XmlIgnore]
    public bool Days_Since_Last_NetEx_Change__cSpecified
    {
      get => this.days_Since_Last_NetEx_Change__cFieldSpecified;
      set => this.days_Since_Last_NetEx_Change__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Do_Not_Touch_Reasons__c
    {
      get => this.do_Not_Touch_Reasons__cField;
      set => this.do_Not_Touch_Reasons__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult DuplicateRecordItems
    {
      get => this.duplicateRecordItemsField;
      set => this.duplicateRecordItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ECCKT_AML_ID_MATCH__c
    {
      get => this.eCCKT_AML_ID_MATCH__cField;
      set => this.eCCKT_AML_ID_MATCH__cField = value;
    }

    [XmlIgnore]
    public bool ECCKT_AML_ID_MATCH__cSpecified
    {
      get => this.eCCKT_AML_ID_MATCH__cFieldSpecified;
      set => this.eCCKT_AML_ID_MATCH__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_AML_ID__c
    {
      get => this.eCCKT_AML_ID__cField;
      set => this.eCCKT_AML_ID__cField = value;
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
    public string ECCKT_KEY_ID__c
    {
      get => this.eCCKT_KEY_ID__cField;
      set => this.eCCKT_KEY_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_RAW_NAME__c
    {
      get => this.eCCKT_RAW_NAME__cField;
      set => this.eCCKT_RAW_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_STATUS_CD__c
    {
      get => this.eCCKT_STATUS_CD__cField;
      set => this.eCCKT_STATUS_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ECCKT_SUPPLEMENTAL__r
    {
      get => this.eCCKT_SUPPLEMENTAL__rField;
      set => this.eCCKT_SUPPLEMENTAL__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ECCKT_SUP__c
    {
      get => this.eCCKT_SUP__cField;
      set => this.eCCKT_SUP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public ECCKT_SUPPLEMENTAL__c ECCKT_SUP__r
    {
      get => this.eCCKT_SUP__rField;
      set => this.eCCKT_SUP__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? EFFICIENT_MARKET_VALUE__c
    {
      get => this.eFFICIENT_MARKET_VALUE__cField;
      set => this.eFFICIENT_MARKET_VALUE__cField = value;
    }

    [XmlIgnore]
    public bool EFFICIENT_MARKET_VALUE__cSpecified
    {
      get => this.eFFICIENT_MARKET_VALUE__cFieldSpecified;
      set => this.eFFICIENT_MARKET_VALUE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? EMV_Delta__c
    {
      get => this.eMV_Delta__cField;
      set => this.eMV_Delta__cField = value;
    }

    [XmlIgnore]
    public bool EMV_Delta__cSpecified
    {
      get => this.eMV_Delta__cFieldSpecified;
      set => this.eMV_Delta__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? EXCHANGE_RT__c
    {
      get => this.eXCHANGE_RT__cField;
      set => this.eXCHANGE_RT__cField = value;
    }

    [XmlIgnore]
    public bool EXCHANGE_RT__cSpecified
    {
      get => this.eXCHANGE_RT__cFieldSpecified;
      set => this.eXCHANGE_RT__cFieldSpecified = value;
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
    public DateTime? FIRST_BILL_DT__c
    {
      get => this.fIRST_BILL_DT__cField;
      set => this.fIRST_BILL_DT__cField = value;
    }

    [XmlIgnore]
    public bool FIRST_BILL_DT__cSpecified
    {
      get => this.fIRST_BILL_DT__cFieldSpecified;
      set => this.fIRST_BILL_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? FIRST_LOGGED_DT__c
    {
      get => this.fIRST_LOGGED_DT__cField;
      set => this.fIRST_LOGGED_DT__cField = value;
    }

    [XmlIgnore]
    public bool FIRST_LOGGED_DT__cSpecified
    {
      get => this.fIRST_LOGGED_DT__cFieldSpecified;
      set => this.fIRST_LOGGED_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? FIRST_LOGGED_MRC_AMT__c
    {
      get => this.fIRST_LOGGED_MRC_AMT__cField;
      set => this.fIRST_LOGGED_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool FIRST_LOGGED_MRC_AMT__cSpecified
    {
      get => this.fIRST_LOGGED_MRC_AMT__cFieldSpecified;
      set => this.fIRST_LOGGED_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? FOC_DT__c
    {
      get => this.fOC_DT__cField;
      set => this.fOC_DT__cField = value;
    }

    [XmlIgnore]
    public bool FOC_DT__cSpecified
    {
      get => this.fOC_DT__cFieldSpecified;
      set => this.fOC_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? FixedMilage__c
    {
      get => this.fixedMilage__cField;
      set => this.fixedMilage__cField = value;
    }

    [XmlIgnore]
    public bool FixedMilage__cSpecified
    {
      get => this.fixedMilage__cFieldSpecified;
      set => this.fixedMilage__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string GL_CD__c
    {
      get => this.gL_CD__cField;
      set => this.gL_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GL_LOB_CD__c
    {
      get => this.gL_LOB_CD__cField;
      set => this.gL_LOB_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GL_PRODUCT_CD__c
    {
      get => this.gL_PRODUCT_CD__cField;
      set => this.gL_PRODUCT_CD__cField = value;
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
    public ICCKT__c ICCKT_AML_ID__r
    {
      get => this.iCCKT_AML_ID__rField;
      set => this.iCCKT_AML_ID__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ICSC_CD__c
    {
      get => this.iCSC_CD__cField;
      set => this.iCSC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string INVOICE_FORMAT_CATEGORY_TYP__c
    {
      get => this.iNVOICE_FORMAT_CATEGORY_TYP__cField;
      set => this.iNVOICE_FORMAT_CATEGORY_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string INVOICE_FORMAT_TYP__c
    {
      get => this.iNVOICE_FORMAT_TYP__cField;
      set => this.iNVOICE_FORMAT_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IN_RFP__c
    {
      get => this.iN_RFP__cField;
      set => this.iN_RFP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IS_ORPHAN_LINKED__c
    {
      get => this.iS_ORPHAN_LINKED__cField;
      set => this.iS_ORPHAN_LINKED__cField = value;
    }

    [XmlIgnore]
    public bool IS_ORPHAN_LINKED__cSpecified
    {
      get => this.iS_ORPHAN_LINKED__cFieldSpecified;
      set => this.iS_ORPHAN_LINKED__cFieldSpecified = value;
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
    public DateTime? LAST_BILL_DT__c
    {
      get => this.lAST_BILL_DT__cField;
      set => this.lAST_BILL_DT__cField = value;
    }

    [XmlIgnore]
    public bool LAST_BILL_DT__cSpecified
    {
      get => this.lAST_BILL_DT__cFieldSpecified;
      set => this.lAST_BILL_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LAST_BILL_GTZ_MRC_IND__c
    {
      get => this.lAST_BILL_GTZ_MRC_IND__cField;
      set => this.lAST_BILL_GTZ_MRC_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? LAST_GTZ_ASG_MRC_AMT__c
    {
      get => this.lAST_GTZ_ASG_MRC_AMT__cField;
      set => this.lAST_GTZ_ASG_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool LAST_GTZ_ASG_MRC_AMT__cSpecified
    {
      get => this.lAST_GTZ_ASG_MRC_AMT__cFieldSpecified;
      set => this.lAST_GTZ_ASG_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? LAST_GTZ_CKT_MRC_AMT__c
    {
      get => this.lAST_GTZ_CKT_MRC_AMT__cField;
      set => this.lAST_GTZ_CKT_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool LAST_GTZ_CKT_MRC_AMT__cSpecified
    {
      get => this.lAST_GTZ_CKT_MRC_AMT__cFieldSpecified;
      set => this.lAST_GTZ_CKT_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LAST_GTZ_MRC_BILL_DT__c
    {
      get => this.lAST_GTZ_MRC_BILL_DT__cField;
      set => this.lAST_GTZ_MRC_BILL_DT__cField = value;
    }

    [XmlIgnore]
    public bool LAST_GTZ_MRC_BILL_DT__cSpecified
    {
      get => this.lAST_GTZ_MRC_BILL_DT__cFieldSpecified;
      set => this.lAST_GTZ_MRC_BILL_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LAST_GTZ_MRC_INV_DTL_ODS_ID__c
    {
      get => this.lAST_GTZ_MRC_INV_DTL_ODS_ID__cField;
      set => this.lAST_GTZ_MRC_INV_DTL_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? LAST_GTZ_TOT_MRC_AMT__c
    {
      get => this.lAST_GTZ_TOT_MRC_AMT__cField;
      set => this.lAST_GTZ_TOT_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool LAST_GTZ_TOT_MRC_AMT__cSpecified
    {
      get => this.lAST_GTZ_TOT_MRC_AMT__cFieldSpecified;
      set => this.lAST_GTZ_TOT_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? LAST_GTZ_TSC_MRC_AMT__c
    {
      get => this.lAST_GTZ_TSC_MRC_AMT__cField;
      set => this.lAST_GTZ_TSC_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool LAST_GTZ_TSC_MRC_AMT__cSpecified
    {
      get => this.lAST_GTZ_TSC_MRC_AMT__cFieldSpecified;
      set => this.lAST_GTZ_TSC_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LEGACY_COMPANY_NAME__c
    {
      get => this.lEGACY_COMPANY_NAME__cField;
      set => this.lEGACY_COMPANY_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LTID_AML_ID__c
    {
      get => this.lTID_AML_ID__cField;
      set => this.lTID_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LTID_NAME__c
    {
      get => this.lTID_NAME__cField;
      set => this.lTID_NAME__cField = value;
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
    public double? Last_Bill_Date_Days__c
    {
      get => this.last_Bill_Date_Days__cField;
      set => this.last_Bill_Date_Days__cField = value;
    }

    [XmlIgnore]
    public bool Last_Bill_Date_Days__cSpecified
    {
      get => this.last_Bill_Date_Days__cFieldSpecified;
      set => this.last_Bill_Date_Days__cFieldSpecified = value;
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
    public string MAX_NOTE__c
    {
      get => this.mAX_NOTE__cField;
      set => this.mAX_NOTE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MEETPOINT_IND__c
    {
      get => this.mEETPOINT_IND__cField;
      set => this.mEETPOINT_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MONTH_TO_MONTH_CALCULATED__c
    {
      get => this.mONTH_TO_MONTH_CALCULATED__cField;
      set => this.mONTH_TO_MONTH_CALCULATED__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? MONTH_TO_MONTH_MANUAL__c
    {
      get => this.mONTH_TO_MONTH_MANUAL__cField;
      set => this.mONTH_TO_MONTH_MANUAL__cField = value;
    }

    [XmlIgnore]
    public bool MONTH_TO_MONTH_MANUAL__cSpecified
    {
      get => this.mONTH_TO_MONTH_MANUAL__cFieldSpecified;
      set => this.mONTH_TO_MONTH_MANUAL__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MRC_AMT__c
    {
      get => this.mRC_AMT__cField;
      set => this.mRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool MRC_AMT__cSpecified
    {
      get => this.mRC_AMT__cFieldSpecified;
      set => this.mRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MUX_IND__c
    {
      get => this.mUX_IND__cField;
      set => this.mUX_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MUX_LOC_SITE_ASR__c
    {
      get => this.mUX_LOC_SITE_ASR__cField;
      set => this.mUX_LOC_SITE_ASR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SITE__c MUX_LOC_SITE_ASR__r
    {
      get => this.mUX_LOC_SITE_ASR__rField;
      set => this.mUX_LOC_SITE_ASR__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MUX_LOC_SITE__c
    {
      get => this.mUX_LOC_SITE__cField;
      set => this.mUX_LOC_SITE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SITE__c MUX_LOC_SITE__r
    {
      get => this.mUX_LOC_SITE__rField;
      set => this.mUX_LOC_SITE__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? MuxUsoc__c
    {
      get => this.muxUsoc__cField;
      set => this.muxUsoc__cField = value;
    }

    [XmlIgnore]
    public bool MuxUsoc__cSpecified
    {
      get => this.muxUsoc__cFieldSpecified;
      set => this.muxUsoc__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string NCI_CD__c
    {
      get => this.nCI_CD__cField;
      set => this.nCI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NC_CD__c
    {
      get => this.nC_CD__cField;
      set => this.nC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_ACNA_CD__c
    {
      get => this.nETEX_ACNA_CD__cField;
      set => this.nETEX_ACNA_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_ACTL_CD__c
    {
      get => this.nETEX_ACTL_CD__cField;
      set => this.nETEX_ACTL_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_CCNA_CD__c
    {
      get => this.nETEX_CCNA_CD__cField;
      set => this.nETEX_CCNA_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_CFA_NAME__c
    {
      get => this.nETEX_CFA_NAME__cField;
      set => this.nETEX_CFA_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_CUSTOMER_NAME__c
    {
      get => this.nETEX_CUSTOMER_NAME__cField;
      set => this.nETEX_CUSTOMER_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_ICSC_CD__c
    {
      get => this.nETEX_ICSC_CD__cField;
      set => this.nETEX_ICSC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_MRP1_CD__c
    {
      get => this.nETEX_MRP1_CD__cField;
      set => this.nETEX_MRP1_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_MRP2_CD__c
    {
      get => this.nETEX_MRP2_CD__cField;
      set => this.nETEX_MRP2_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NETEX_PIU_RT__c
    {
      get => this.nETEX_PIU_RT__cField;
      set => this.nETEX_PIU_RT__cField = value;
    }

    [XmlIgnore]
    public bool NETEX_PIU_RT__cSpecified
    {
      get => this.nETEX_PIU_RT__cFieldSpecified;
      set => this.nETEX_PIU_RT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_PNUM_NBR__c
    {
      get => this.nETEX_PNUM_NBR__cField;
      set => this.nETEX_PNUM_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_PURCHASE_ORDER_NBR__c
    {
      get => this.nETEX_PURCHASE_ORDER_NBR__cField;
      set => this.nETEX_PURCHASE_ORDER_NBR__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? NETEX_SERV_ESTBL_DT__c
    {
      get => this.nETEX_SERV_ESTBL_DT__cField;
      set => this.nETEX_SERV_ESTBL_DT__cField = value;
    }

    [XmlIgnore]
    public bool NETEX_SERV_ESTBL_DT__cSpecified
    {
      get => this.nETEX_SERV_ESTBL_DT__cFieldSpecified;
      set => this.nETEX_SERV_ESTBL_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_SPEC_CD__c
    {
      get => this.nETEX_SPEC_CD__cField;
      set => this.nETEX_SPEC_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_SUPPLIER_BILL_ACCT_NBR__c
    {
      get => this.nETEX_SUPPLIER_BILL_ACCT_NBR__cField;
      set => this.nETEX_SUPPLIER_BILL_ACCT_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_SUPPLIER_PLAN_ID__c
    {
      get => this.nETEX_SUPPLIER_PLAN_ID__cField;
      set => this.nETEX_SUPPLIER_PLAN_ID__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? NETEX_TERM_AGREE_END_DT__c
    {
      get => this.nETEX_TERM_AGREE_END_DT__cField;
      set => this.nETEX_TERM_AGREE_END_DT__cField = value;
    }

    [XmlIgnore]
    public bool NETEX_TERM_AGREE_END_DT__cSpecified
    {
      get => this.nETEX_TERM_AGREE_END_DT__cFieldSpecified;
      set => this.nETEX_TERM_AGREE_END_DT__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? NETEX_TERM_AGREE_START_DT__c
    {
      get => this.nETEX_TERM_AGREE_START_DT__cField;
      set => this.nETEX_TERM_AGREE_START_DT__cField = value;
    }

    [XmlIgnore]
    public bool NETEX_TERM_AGREE_START_DT__cSpecified
    {
      get => this.nETEX_TERM_AGREE_START_DT__cFieldSpecified;
      set => this.nETEX_TERM_AGREE_START_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NETEX_TERM_LENGTH_MONTHS_NBR__c
    {
      get => this.nETEX_TERM_LENGTH_MONTHS_NBR__cField;
      set => this.nETEX_TERM_LENGTH_MONTHS_NBR__cField = value;
    }

    [XmlIgnore]
    public bool NETEX_TERM_LENGTH_MONTHS_NBR__cSpecified
    {
      get => this.nETEX_TERM_LENGTH_MONTHS_NBR__cFieldSpecified;
      set => this.nETEX_TERM_LENGTH_MONTHS_NBR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_TRAIL_NAME__c
    {
      get => this.nETEX_TRAIL_NAME__cField;
      set => this.nETEX_TRAIL_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NETEX_VTA_CD__c
    {
      get => this.nETEX_VTA_CD__cField;
      set => this.nETEX_VTA_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NOTE_LOG__c
    {
      get => this.nOTE_LOG__cField;
      set => this.nOTE_LOG__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? NRC_AMT__c
    {
      get => this.nRC_AMT__cField;
      set => this.nRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool NRC_AMT__cSpecified
    {
      get => this.nRC_AMT__cFieldSpecified;
      set => this.nRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? NetEx_Last_Change_Date__c
    {
      get => this.netEx_Last_Change_Date__cField;
      set => this.netEx_Last_Change_Date__cField = value;
    }

    [XmlIgnore]
    public bool NetEx_Last_Change_Date__cSpecified
    {
      get => this.netEx_Last_Change_Date__cFieldSpecified;
      set => this.netEx_Last_Change_Date__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? NetEx_Term_Agree_End_Last_Change_Date__c
    {
      get => this.netEx_Term_Agree_End_Last_Change_Date__cField;
      set => this.netEx_Term_Agree_End_Last_Change_Date__cField = value;
    }

    [XmlIgnore]
    public bool NetEx_Term_Agree_End_Last_Change_Date__cSpecified
    {
      get => this.netEx_Term_Agree_End_Last_Change_Date__cFieldSpecified;
      set => this.netEx_Term_Agree_End_Last_Change_Date__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? NetEx_Term_Agree_Start_Last_Change_Date__c
    {
      get => this.netEx_Term_Agree_Start_Last_Change_Date__cField;
      set => this.netEx_Term_Agree_Start_Last_Change_Date__cField = value;
    }

    [XmlIgnore]
    public bool NetEx_Term_Agree_Start_Last_Change_Date__cSpecified
    {
      get => this.netEx_Term_Agree_Start_Last_Change_Date__cFieldSpecified;
      set => this.netEx_Term_Agree_Start_Last_Change_Date__cFieldSpecified = value;
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
    public string OCC_DISCOUNT_ESTIMATE_IND__c
    {
      get => this.oCC_DISCOUNT_ESTIMATE_IND__cField;
      set => this.oCC_DISCOUNT_ESTIMATE_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? OCC_DISCOUNT_MRC_AMT__c
    {
      get => this.oCC_DISCOUNT_MRC_AMT__cField;
      set => this.oCC_DISCOUNT_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool OCC_DISCOUNT_MRC_AMT__cSpecified
    {
      get => this.oCC_DISCOUNT_MRC_AMT__cFieldSpecified;
      set => this.oCC_DISCOUNT_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string OCN_CD__c
    {
      get => this.oCN_CD__cField;
      set => this.oCN_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OCN_NAME__c
    {
      get => this.oCN_NAME__cField;
      set => this.oCN_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_SOURCE_SYSTEM_ID__c
    {
      get => this.oDM_SOURCE_SYSTEM_ID__cField;
      set => this.oDM_SOURCE_SYSTEM_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ODM_TERM_AGREE_END_DT__c
    {
      get => this.oDM_TERM_AGREE_END_DT__cField;
      set => this.oDM_TERM_AGREE_END_DT__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_AGREE_END_DT__cSpecified
    {
      get => this.oDM_TERM_AGREE_END_DT__cFieldSpecified;
      set => this.oDM_TERM_AGREE_END_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ODM_TERM_AGREE_START_DT__c
    {
      get => this.oDM_TERM_AGREE_START_DT__cField;
      set => this.oDM_TERM_AGREE_START_DT__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_AGREE_START_DT__cSpecified
    {
      get => this.oDM_TERM_AGREE_START_DT__cFieldSpecified;
      set => this.oDM_TERM_AGREE_START_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ODM_TERM_LENGTH_QTY__c
    {
      get => this.oDM_TERM_LENGTH_QTY__cField;
      set => this.oDM_TERM_LENGTH_QTY__cField = value;
    }

    [XmlIgnore]
    public bool ODM_TERM_LENGTH_QTY__cSpecified
    {
      get => this.oDM_TERM_LENGTH_QTY__cFieldSpecified;
      set => this.oDM_TERM_LENGTH_QTY__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_TERM_STATUS_CD__c
    {
      get => this.oDM_TERM_STATUS_CD__cField;
      set => this.oDM_TERM_STATUS_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_VENDOR_NAME__c
    {
      get => this.oDM_VENDOR_NAME__cField;
      set => this.oDM_VENDOR_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ODM_VENDOR_ODS_ID__c
    {
      get => this.oDM_VENDOR_ODS_ID__cField;
      set => this.oDM_VENDOR_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? ODM_VNN_2_AML_VNN__c
    {
      get => this.oDM_VNN_2_AML_VNN__cField;
      set => this.oDM_VNN_2_AML_VNN__cField = value;
    }

    [XmlIgnore]
    public bool ODM_VNN_2_AML_VNN__cSpecified
    {
      get => this.oDM_VNN_2_AML_VNN__cFieldSpecified;
      set => this.oDM_VNN_2_AML_VNN__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string OFFNET_ORDER_ODS_ID__c
    {
      get => this.oFFNET_ORDER_ODS_ID__cField;
      set => this.oFFNET_ORDER_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OFFNET_OVERRIDE_ODS_ID__c
    {
      get => this.oFFNET_OVERRIDE_ODS_ID__cField;
      set => this.oFFNET_OVERRIDE_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OFFNET_VENDOR_ODS_ID__c
    {
      get => this.oFFNET_VENDOR_ODS_ID__cField;
      set => this.oFFNET_VENDOR_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OFF_TO_ONNET_NOTE__c
    {
      get => this.oFF_TO_ONNET_NOTE__cField;
      set => this.oFF_TO_ONNET_NOTE__cField = value;
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
    public double? Other_USOC_Charges__c
    {
      get => this.other_USOC_Charges__cField;
      set => this.other_USOC_Charges__cField = value;
    }

    [XmlIgnore]
    public bool Other_USOC_Charges__cSpecified
    {
      get => this.other_USOC_Charges__cFieldSpecified;
      set => this.other_USOC_Charges__cFieldSpecified = value;
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
    public string PC_AEND_CITY_NAME__c
    {
      get => this.pC_AEND_CITY_NAME__cField;
      set => this.pC_AEND_CITY_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_AEND_CLLI_CD__c
    {
      get => this.pC_AEND_CLLI_CD__cField;
      set => this.pC_AEND_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_AEND_LINE1_ADDR__c
    {
      get => this.pC_AEND_LINE1_ADDR__cField;
      set => this.pC_AEND_LINE1_ADDR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_AEND_POSTAL_CD__c
    {
      get => this.pC_AEND_POSTAL_CD__cField;
      set => this.pC_AEND_POSTAL_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_AEND_STATE_CD__c
    {
      get => this.pC_AEND_STATE_CD__cField;
      set => this.pC_AEND_STATE_CD__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? PC_AMS_QUOTE_DT__c
    {
      get => this.pC_AMS_QUOTE_DT__cField;
      set => this.pC_AMS_QUOTE_DT__cField = value;
    }

    [XmlIgnore]
    public bool PC_AMS_QUOTE_DT__cSpecified
    {
      get => this.pC_AMS_QUOTE_DT__cFieldSpecified;
      set => this.pC_AMS_QUOTE_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_AMS_SOLUTION_ID__c
    {
      get => this.pC_AMS_SOLUTION_ID__cField;
      set => this.pC_AMS_SOLUTION_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_BANDWIDTH_CD__c
    {
      get => this.pC_BANDWIDTH_CD__cField;
      set => this.pC_BANDWIDTH_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_CUST_ORDER_NBR__c
    {
      get => this.pC_CUST_ORDER_NBR__cField;
      set => this.pC_CUST_ORDER_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_DERIVED_ECCKT_ACTION_TYP__c
    {
      get => this.pC_DERIVED_ECCKT_ACTION_TYP__cField;
      set => this.pC_DERIVED_ECCKT_ACTION_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_OFFNET_SOLUTION_TYP__c
    {
      get => this.pC_OFFNET_SOLUTION_TYP__cField;
      set => this.pC_OFFNET_SOLUTION_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_ORDER_VENDOR_NAME__c
    {
      get => this.pC_ORDER_VENDOR_NAME__cField;
      set => this.pC_ORDER_VENDOR_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_OVERRIDE_IND__c
    {
      get => this.pC_OVERRIDE_IND__cField;
      set => this.pC_OVERRIDE_IND__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_PLANNED_BILLED_COST_AML_ID__c
    {
      get => this.pC_PLANNED_BILLED_COST_AML_ID__cField;
      set => this.pC_PLANNED_BILLED_COST_AML_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_PRODUCT_ELEM_ID__c
    {
      get => this.pC_PRODUCT_ELEM_ID__cField;
      set => this.pC_PRODUCT_ELEM_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_PRODUCT_INST_ID__c
    {
      get => this.pC_PRODUCT_INST_ID__cField;
      set => this.pC_PRODUCT_INST_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_QUOTE_NBR__c
    {
      get => this.pC_QUOTE_NBR__cField;
      set => this.pC_QUOTE_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_RESEARCH_CD__c
    {
      get => this.pC_RESEARCH_CD__cField;
      set => this.pC_RESEARCH_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_RESEARCH_NOTE_TXT__c
    {
      get => this.pC_RESEARCH_NOTE_TXT__cField;
      set => this.pC_RESEARCH_NOTE_TXT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_RESEARCH_OWNER_NAME__c
    {
      get => this.pC_RESEARCH_OWNER_NAME__cField;
      set => this.pC_RESEARCH_OWNER_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_ROLLUP_TYP__c
    {
      get => this.pC_ROLLUP_TYP__cField;
      set => this.pC_ROLLUP_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_SEGMENT_TYP__c
    {
      get => this.pC_SEGMENT_TYP__cField;
      set => this.pC_SEGMENT_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_SERV_COMPNT_ID__c
    {
      get => this.pC_SERV_COMPNT_ID__cField;
      set => this.pC_SERV_COMPNT_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_SERV_ORDER_NBR__c
    {
      get => this.pC_SERV_ORDER_NBR__cField;
      set => this.pC_SERV_ORDER_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PC_TERM_MONTHS_QTY__c
    {
      get => this.pC_TERM_MONTHS_QTY__cField;
      set => this.pC_TERM_MONTHS_QTY__cField = value;
    }

    [XmlIgnore]
    public bool PC_TERM_MONTHS_QTY__cSpecified
    {
      get => this.pC_TERM_MONTHS_QTY__cFieldSpecified;
      set => this.pC_TERM_MONTHS_QTY__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_VENDOR_QUOTE_TYP__c
    {
      get => this.pC_VENDOR_QUOTE_TYP__cField;
      set => this.pC_VENDOR_QUOTE_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PC_VENDOR_USD_MRC_AMT__c
    {
      get => this.pC_VENDOR_USD_MRC_AMT__cField;
      set => this.pC_VENDOR_USD_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool PC_VENDOR_USD_MRC_AMT__cSpecified
    {
      get => this.pC_VENDOR_USD_MRC_AMT__cFieldSpecified;
      set => this.pC_VENDOR_USD_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PC_VENDOR_USD_NRC_AMT__c
    {
      get => this.pC_VENDOR_USD_NRC_AMT__cField;
      set => this.pC_VENDOR_USD_NRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool PC_VENDOR_USD_NRC_AMT__cSpecified
    {
      get => this.pC_VENDOR_USD_NRC_AMT__cFieldSpecified;
      set => this.pC_VENDOR_USD_NRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_WF_JEOP_AMS_SOLUTION_ID__c
    {
      get => this.pC_WF_JEOP_AMS_SOLUTION_ID__cField;
      set => this.pC_WF_JEOP_AMS_SOLUTION_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_WF_JEOP_CONSTRAINT_TXT__c
    {
      get => this.pC_WF_JEOP_CONSTRAINT_TXT__cField;
      set => this.pC_WF_JEOP_CONSTRAINT_TXT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? PC_WF_JEOP_NEW_MRC_AMT__c
    {
      get => this.pC_WF_JEOP_NEW_MRC_AMT__cField;
      set => this.pC_WF_JEOP_NEW_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool PC_WF_JEOP_NEW_MRC_AMT__cSpecified
    {
      get => this.pC_WF_JEOP_NEW_MRC_AMT__cFieldSpecified;
      set => this.pC_WF_JEOP_NEW_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_ZEND_CITY_NAME__c
    {
      get => this.pC_ZEND_CITY_NAME__cField;
      set => this.pC_ZEND_CITY_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_ZEND_CLLI_CD__c
    {
      get => this.pC_ZEND_CLLI_CD__cField;
      set => this.pC_ZEND_CLLI_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_ZEND_LINE1_ADDR__c
    {
      get => this.pC_ZEND_LINE1_ADDR__cField;
      set => this.pC_ZEND_LINE1_ADDR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_ZEND_POSTAL_CD__c
    {
      get => this.pC_ZEND_POSTAL_CD__cField;
      set => this.pC_ZEND_POSTAL_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PC_ZEND_STATE_CD__c
    {
      get => this.pC_ZEND_STATE_CD__cField;
      set => this.pC_ZEND_STATE_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PIU_RT__c
    {
      get => this.pIU_RT__cField;
      set => this.pIU_RT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PLANNER_REVIEW_NOTE__c
    {
      get => this.pLANNER_REVIEW_NOTE__cField;
      set => this.pLANNER_REVIEW_NOTE__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PLU_RT__c
    {
      get => this.pLU_RT__cField;
      set => this.pLU_RT__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PNUM_Comparison__c
    {
      get => this.pNUM_Comparison__cField;
      set => this.pNUM_Comparison__cField = value;
    }

    [XmlIgnore]
    public bool PNUM_Comparison__cSpecified
    {
      get => this.pNUM_Comparison__cFieldSpecified;
      set => this.pNUM_Comparison__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PON_NBR__c
    {
      get => this.pON_NBR__cField;
      set => this.pON_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PON_VERSION_NBR__c
    {
      get => this.pON_VERSION_NBR__cField;
      set => this.pON_VERSION_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PRODUCT_INST_ID_SOURCE_NAME__c
    {
      get => this.pRODUCT_INST_ID_SOURCE_NAME__cField;
      set => this.pRODUCT_INST_ID_SOURCE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PRODUCT_INST_ID__c
    {
      get => this.pRODUCT_INST_ID__cField;
      set => this.pRODUCT_INST_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROJECT_ID__c
    {
      get => this.pROJECT_ID__cField;
      set => this.pROJECT_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public PROJECT_HEADER__c PROJECT_ID__r
    {
      get => this.pROJECT_ID__rField;
      set => this.pROJECT_ID__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PROVIDER_ORDER_NBR__c
    {
      get => this.pROVIDER_ORDER_NBR__cField;
      set => this.pROVIDER_ORDER_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Pc_Drill_Down_ECCKT_List__c
    {
      get => this.pc_Drill_Down_ECCKT_List__cField;
      set => this.pc_Drill_Down_ECCKT_List__cField = value;
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
    public string REV_PRODUCT_COMPNT_ID_TYP__c
    {
      get => this.rEV_PRODUCT_COMPNT_ID_TYP__cField;
      set => this.rEV_PRODUCT_COMPNT_ID_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string REV_PRODUCT_COMPNT_ID__c
    {
      get => this.rEV_PRODUCT_COMPNT_ID__cField;
      set => this.rEV_PRODUCT_COMPNT_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFP_BID_RATE__c
    {
      get => this.rFP_BID_RATE__cField;
      set => this.rFP_BID_RATE__cField = value;
    }

    [XmlIgnore]
    public bool RFP_BID_RATE__cSpecified
    {
      get => this.rFP_BID_RATE__cFieldSpecified;
      set => this.rFP_BID_RATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RFP_Quotes__r
    {
      get => this.rFP_Quotes__rField;
      set => this.rFP_Quotes__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_APPROVAL_COMMENTS__c
    {
      get => this.rFT_APPROVAL_COMMENTS__cField;
      set => this.rFT_APPROVAL_COMMENTS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_BANDWIDTH__c
    {
      get => this.rFT_BANDWIDTH__cField;
      set => this.rFT_BANDWIDTH__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_BTP_BAN__c
    {
      get => this.rFT_BTP_BAN__cField;
      set => this.rFT_BTP_BAN__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFT_BTP_BILL_DATE__c
    {
      get => this.rFT_BTP_BILL_DATE__cField;
      set => this.rFT_BTP_BILL_DATE__cField = value;
    }

    [XmlIgnore]
    public bool RFT_BTP_BILL_DATE__cSpecified
    {
      get => this.rFT_BTP_BILL_DATE__cFieldSpecified;
      set => this.rFT_BTP_BILL_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_COMMENTS__c
    {
      get => this.rFT_COMMENTS__cField;
      set => this.rFT_COMMENTS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_CRM__c
    {
      get => this.rFT_CRM__cField;
      set => this.rFT_CRM__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFT_CUSTOMER_REQUESTED_DATE__c
    {
      get => this.rFT_CUSTOMER_REQUESTED_DATE__cField;
      set => this.rFT_CUSTOMER_REQUESTED_DATE__cField = value;
    }

    [XmlIgnore]
    public bool RFT_CUSTOMER_REQUESTED_DATE__cSpecified
    {
      get => this.rFT_CUSTOMER_REQUESTED_DATE__cFieldSpecified;
      set => this.rFT_CUSTOMER_REQUESTED_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_DECISION_TREE__c
    {
      get => this.rFT_DECISION_TREE__cField;
      set => this.rFT_DECISION_TREE__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFT_DISCONNECT_FOC_DATE__c
    {
      get => this.rFT_DISCONNECT_FOC_DATE__cField;
      set => this.rFT_DISCONNECT_FOC_DATE__cField = value;
    }

    [XmlIgnore]
    public bool RFT_DISCONNECT_FOC_DATE__cSpecified
    {
      get => this.rFT_DISCONNECT_FOC_DATE__cFieldSpecified;
      set => this.rFT_DISCONNECT_FOC_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_DISCONNECT_PON__c
    {
      get => this.rFT_DISCONNECT_PON__cField;
      set => this.rFT_DISCONNECT_PON__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFT_ESTIMATED_TL_AMOUNT__c
    {
      get => this.rFT_ESTIMATED_TL_AMOUNT__cField;
      set => this.rFT_ESTIMATED_TL_AMOUNT__cField = value;
    }

    [XmlIgnore]
    public bool RFT_ESTIMATED_TL_AMOUNT__cSpecified
    {
      get => this.rFT_ESTIMATED_TL_AMOUNT__cFieldSpecified;
      set => this.rFT_ESTIMATED_TL_AMOUNT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_HFT_CIRCUIT_ID__c
    {
      get => this.rFT_HFT_CIRCUIT_ID__cField;
      set => this.rFT_HFT_CIRCUIT_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_HFT_PORTABILITY_CATEGORY__c
    {
      get => this.rFT_HFT_PORTABILITY_CATEGORY__cField;
      set => this.rFT_HFT_PORTABILITY_CATEGORY__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_INTERNAL_CIRCUIT_ID__c
    {
      get => this.rFT_INTERNAL_CIRCUIT_ID__cField;
      set => this.rFT_INTERNAL_CIRCUIT_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_LEVEL3_DISCONNECT_ORDER_NBR__c
    {
      get => this.rFT_LEVEL3_DISCONNECT_ORDER_NBR__cField;
      set => this.rFT_LEVEL3_DISCONNECT_ORDER_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_Legacy_Windu_Wrkflw_ID__c
    {
      get => this.rFT_Legacy_Windu_Wrkflw_ID__cField;
      set => this.rFT_Legacy_Windu_Wrkflw_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFT_MITIGATED_TL_AMOUNT__c
    {
      get => this.rFT_MITIGATED_TL_AMOUNT__cField;
      set => this.rFT_MITIGATED_TL_AMOUNT__cField = value;
    }

    [XmlIgnore]
    public bool RFT_MITIGATED_TL_AMOUNT__cSpecified
    {
      get => this.rFT_MITIGATED_TL_AMOUNT__cFieldSpecified;
      set => this.rFT_MITIGATED_TL_AMOUNT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFT_ORIGINAL_CIRCUIT_TERM__c
    {
      get => this.rFT_ORIGINAL_CIRCUIT_TERM__cField;
      set => this.rFT_ORIGINAL_CIRCUIT_TERM__cField = value;
    }

    [XmlIgnore]
    public bool RFT_ORIGINAL_CIRCUIT_TERM__cSpecified
    {
      get => this.rFT_ORIGINAL_CIRCUIT_TERM__cFieldSpecified;
      set => this.rFT_ORIGINAL_CIRCUIT_TERM__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_ORIGINAL_INSTALL_PON__c
    {
      get => this.rFT_ORIGINAL_INSTALL_PON__cField;
      set => this.rFT_ORIGINAL_INSTALL_PON__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_Original_Requested_By__c
    {
      get => this.rFT_Original_Requested_By__cField;
      set => this.rFT_Original_Requested_By__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_PROJECT_ID__c
    {
      get => this.rFT_PROJECT_ID__cField;
      set => this.rFT_PROJECT_ID__cField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFT_RELEASE_DATE__c
    {
      get => this.rFT_RELEASE_DATE__cField;
      set => this.rFT_RELEASE_DATE__cField = value;
    }

    [XmlIgnore]
    public bool RFT_RELEASE_DATE__cSpecified
    {
      get => this.rFT_RELEASE_DATE__cFieldSpecified;
      set => this.rFT_RELEASE_DATE__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFT_RELEASE_INVENTORY_DATE__c
    {
      get => this.rFT_RELEASE_INVENTORY_DATE__cField;
      set => this.rFT_RELEASE_INVENTORY_DATE__cField = value;
    }

    [XmlIgnore]
    public bool RFT_RELEASE_INVENTORY_DATE__cSpecified
    {
      get => this.rFT_RELEASE_INVENTORY_DATE__cFieldSpecified;
      set => this.rFT_RELEASE_INVENTORY_DATE__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFT_RFA_APPROVAL_DATE__c
    {
      get => this.rFT_RFA_APPROVAL_DATE__cField;
      set => this.rFT_RFA_APPROVAL_DATE__cField = value;
    }

    [XmlIgnore]
    public bool RFT_RFA_APPROVAL_DATE__cSpecified
    {
      get => this.rFT_RFA_APPROVAL_DATE__cFieldSpecified;
      set => this.rFT_RFA_APPROVAL_DATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_RFA_Number__c
    {
      get => this.rFT_RFA_Number__cField;
      set => this.rFT_RFA_Number__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_RFA_Status__c
    {
      get => this.rFT_RFA_Status__cField;
      set => this.rFT_RFA_Status__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_RFT_STATUS__c
    {
      get => this.rFT_RFT_STATUS__cField;
      set => this.rFT_RFT_STATUS__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_Reject_to_SA_Comments__c
    {
      get => this.rFT_Reject_to_SA_Comments__cField;
      set => this.rFT_Reject_to_SA_Comments__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_Requested_By__c
    {
      get => this.rFT_Requested_By__cField;
      set => this.rFT_Requested_By__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? RFT_Status_Age__c
    {
      get => this.rFT_Status_Age__cField;
      set => this.rFT_Status_Age__cField = value;
    }

    [XmlIgnore]
    public bool RFT_Status_Age__cSpecified
    {
      get => this.rFT_Status_Age__cFieldSpecified;
      set => this.rFT_Status_Age__cFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? RFT_Status_Date__c
    {
      get => this.rFT_Status_Date__cField;
      set => this.rFT_Status_Date__cField = value;
    }

    [XmlIgnore]
    public bool RFT_Status_Date__cSpecified
    {
      get => this.rFT_Status_Date__cFieldSpecified;
      set => this.rFT_Status_Date__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string RFT_VENDOR_SERVICE_ORDER_NBR__c
    {
      get => this.rFT_VENDOR_SERVICE_ORDER_NBR__cField;
      set => this.rFT_VENDOR_SERVICE_ORDER_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SCFA_NAME__c
    {
      get => this.sCFA_NAME__cField;
      set => this.sCFA_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SEGMENT_TYPE_SEQ_NBR__c
    {
      get => this.sEGMENT_TYPE_SEQ_NBR__cField;
      set => this.sEGMENT_TYPE_SEQ_NBR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SEG_TYP__c
    {
      get => this.sEG_TYP__cField;
      set => this.sEG_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SERVICE_TYP__c
    {
      get => this.sERVICE_TYP__cField;
      set => this.sERVICE_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SERV_COMPNT_ID_SOURCE_NAME__c
    {
      get => this.sERV_COMPNT_ID_SOURCE_NAME__cField;
      set => this.sERV_COMPNT_ID_SOURCE_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SERV_COMPNT_ID__c
    {
      get => this.sERV_COMPNT_ID__cField;
      set => this.sERV_COMPNT_ID__cField = value;
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
    public double? SRC_ASG_MRC_AMT__c
    {
      get => this.sRC_ASG_MRC_AMT__cField;
      set => this.sRC_ASG_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_ASG_MRC_AMT__cSpecified
    {
      get => this.sRC_ASG_MRC_AMT__cFieldSpecified;
      set => this.sRC_ASG_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_FIRST_LOGGED_MRC_AMT__c
    {
      get => this.sRC_FIRST_LOGGED_MRC_AMT__cField;
      set => this.sRC_FIRST_LOGGED_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_FIRST_LOGGED_MRC_AMT__cSpecified
    {
      get => this.sRC_FIRST_LOGGED_MRC_AMT__cFieldSpecified;
      set => this.sRC_FIRST_LOGGED_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_MRC_AMT__c
    {
      get => this.sRC_MRC_AMT__cField;
      set => this.sRC_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_MRC_AMT__cSpecified
    {
      get => this.sRC_MRC_AMT__cFieldSpecified;
      set => this.sRC_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_NRC_AMT__c
    {
      get => this.sRC_NRC_AMT__cField;
      set => this.sRC_NRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_NRC_AMT__cSpecified
    {
      get => this.sRC_NRC_AMT__cFieldSpecified;
      set => this.sRC_NRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_OCC_DISCOUNT_MRC_AMT__c
    {
      get => this.sRC_OCC_DISCOUNT_MRC_AMT__cField;
      set => this.sRC_OCC_DISCOUNT_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_OCC_DISCOUNT_MRC_AMT__cSpecified
    {
      get => this.sRC_OCC_DISCOUNT_MRC_AMT__cFieldSpecified;
      set => this.sRC_OCC_DISCOUNT_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_TOTAL_MRC_AMT__c
    {
      get => this.sRC_TOTAL_MRC_AMT__cField;
      set => this.sRC_TOTAL_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_TOTAL_MRC_AMT__cSpecified
    {
      get => this.sRC_TOTAL_MRC_AMT__cFieldSpecified;
      set => this.sRC_TOTAL_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SRC_TSC_MRC_AMT__c
    {
      get => this.sRC_TSC_MRC_AMT__cField;
      set => this.sRC_TSC_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool SRC_TSC_MRC_AMT__cSpecified
    {
      get => this.sRC_TSC_MRC_AMT__cFieldSpecified;
      set => this.sRC_TSC_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? SUB_BANDWIDTH_VALUE__c
    {
      get => this.sUB_BANDWIDTH_VALUE__cField;
      set => this.sUB_BANDWIDTH_VALUE__cField = value;
    }

    [XmlIgnore]
    public bool SUB_BANDWIDTH_VALUE__cSpecified
    {
      get => this.sUB_BANDWIDTH_VALUE__cFieldSpecified;
      set => this.sUB_BANDWIDTH_VALUE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SUPPLIER_CIRCUIT_ODS_ID__c
    {
      get => this.sUPPLIER_CIRCUIT_ODS_ID__cField;
      set => this.sUPPLIER_CIRCUIT_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SVC_ESTABLISH_DT__c
    {
      get => this.sVC_ESTABLISH_DT__cField;
      set => this.sVC_ESTABLISH_DT__cField = value;
    }

    [XmlIgnore]
    public bool SVC_ESTABLISH_DT__cSpecified
    {
      get => this.sVC_ESTABLISH_DT__cFieldSpecified;
      set => this.sVC_ESTABLISH_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? SYSTEM_ID_AML_VS_ODM__c
    {
      get => this.sYSTEM_ID_AML_VS_ODM__cField;
      set => this.sYSTEM_ID_AML_VS_ODM__cField = value;
    }

    [XmlIgnore]
    public bool SYSTEM_ID_AML_VS_ODM__cSpecified
    {
      get => this.sYSTEM_ID_AML_VS_ODM__cFieldSpecified;
      set => this.sYSTEM_ID_AML_VS_ODM__cFieldSpecified = value;
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
    public string System_ID_from_ODM__c
    {
      get => this.system_ID_from_ODM__cField;
      set => this.system_ID_from_ODM__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? TARGET_MARKET_RATE__c
    {
      get => this.tARGET_MARKET_RATE__cField;
      set => this.tARGET_MARKET_RATE__cField = value;
    }

    [XmlIgnore]
    public bool TARGET_MARKET_RATE__cSpecified
    {
      get => this.tARGET_MARKET_RATE__cFieldSpecified;
      set => this.tARGET_MARKET_RATE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? TERM_END_DT__c
    {
      get => this.tERM_END_DT__cField;
      set => this.tERM_END_DT__cField = value;
    }

    [XmlIgnore]
    public bool TERM_END_DT__cSpecified
    {
      get => this.tERM_END_DT__cFieldSpecified;
      set => this.tERM_END_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? TERM_END_PHOENIX_VS_NETEX__c
    {
      get => this.tERM_END_PHOENIX_VS_NETEX__cField;
      set => this.tERM_END_PHOENIX_VS_NETEX__cField = value;
    }

    [XmlIgnore]
    public bool TERM_END_PHOENIX_VS_NETEX__cSpecified
    {
      get => this.tERM_END_PHOENIX_VS_NETEX__cFieldSpecified;
      set => this.tERM_END_PHOENIX_VS_NETEX__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? TERM_LENGTH_NBR__c
    {
      get => this.tERM_LENGTH_NBR__cField;
      set => this.tERM_LENGTH_NBR__cField = value;
    }

    [XmlIgnore]
    public bool TERM_LENGTH_NBR__cSpecified
    {
      get => this.tERM_LENGTH_NBR__cFieldSpecified;
      set => this.tERM_LENGTH_NBR__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? TERM_START_DT__c
    {
      get => this.tERM_START_DT__cField;
      set => this.tERM_START_DT__cField = value;
    }

    [XmlIgnore]
    public bool TERM_START_DT__cSpecified
    {
      get => this.tERM_START_DT__cFieldSpecified;
      set => this.tERM_START_DT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? TOTAL_MRC_AMT__c
    {
      get => this.tOTAL_MRC_AMT__cField;
      set => this.tOTAL_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool TOTAL_MRC_AMT__cSpecified
    {
      get => this.tOTAL_MRC_AMT__cFieldSpecified;
      set => this.tOTAL_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TRAIL_ODS_ID__c
    {
      get => this.tRAIL_ODS_ID__cField;
      set => this.tRAIL_ODS_ID__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? TSC_MRC_AMT__c
    {
      get => this.tSC_MRC_AMT__cField;
      set => this.tSC_MRC_AMT__cField = value;
    }

    [XmlIgnore]
    public bool TSC_MRC_AMT__cSpecified
    {
      get => this.tSC_MRC_AMT__cFieldSpecified;
      set => this.tSC_MRC_AMT__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? TSC_ONLY_CHARGE__c
    {
      get => this.tSC_ONLY_CHARGE__cField;
      set => this.tSC_ONLY_CHARGE__cField = value;
    }

    [XmlIgnore]
    public bool TSC_ONLY_CHARGE__cSpecified
    {
      get => this.tSC_ONLY_CHARGE__cFieldSpecified;
      set => this.tSC_ONLY_CHARGE__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Tasks
    {
      get => this.tasksField;
      set => this.tasksField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Term_Status_from_ODM__c
    {
      get => this.term_Status_from_ODM__cField;
      set => this.term_Status_from_ODM__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult TopicAssignments
    {
      get => this.topicAssignmentsField;
      set => this.topicAssignmentsField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? Total_MRC_Last_Change_Date__c
    {
      get => this.total_MRC_Last_Change_Date__cField;
      set => this.total_MRC_Last_Change_Date__cField = value;
    }

    [XmlIgnore]
    public bool Total_MRC_Last_Change_Date__cSpecified
    {
      get => this.total_MRC_Last_Change_Date__cFieldSpecified;
      set => this.total_MRC_Last_Change_Date__cFieldSpecified = value;
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
    public string VBR_BILL_ACCOUNT_TYPE_CD__c
    {
      get => this.vBR_BILL_ACCOUNT_TYPE_CD__cField;
      set => this.vBR_BILL_ACCOUNT_TYPE_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VBR_BILL_ACCOUNT_TYPE_DESC__c
    {
      get => this.vBR_BILL_ACCOUNT_TYPE_DESC__cField;
      set => this.vBR_BILL_ACCOUNT_TYPE_DESC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR_NAME__c
    {
      get => this.vENDOR_NAME__cField;
      set => this.vENDOR_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR_NORMALIZED_NAME__c
    {
      get => this.vENDOR_NORMALIZED_NAME__cField;
      set => this.vENDOR_NORMALIZED_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR_PARENT_NAME__c
    {
      get => this.vENDOR_PARENT_NAME__cField;
      set => this.vENDOR_PARENT_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR_RELATIONSHIP_TYP__c
    {
      get => this.vENDOR_RELATIONSHIP_TYP__cField;
      set => this.vENDOR_RELATIONSHIP_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VENDOR_TYP__c
    {
      get => this.vENDOR_TYP__cField;
      set => this.vENDOR_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? VNNtoODM_Name__c
    {
      get => this.vNNtoODM_Name__cField;
      set => this.vNNtoODM_Name__cField = value;
    }

    [XmlIgnore]
    public bool VNNtoODM_Name__cSpecified
    {
      get => this.vNNtoODM_Name__cFieldSpecified;
      set => this.vNNtoODM_Name__cFieldSpecified = value;
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

    [XmlElement(IsNullable = true)]
    public bool? VendorMatch__c
    {
      get => this.vendorMatch__cField;
      set => this.vendorMatch__cField = value;
    }

    [XmlIgnore]
    public bool VendorMatch__cSpecified
    {
      get => this.vendorMatch__cFieldSpecified;
      set => this.vendorMatch__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_ASR_CLLI_CD__c
    {
      get => this.zEND_ASR_CLLI_CD__cField;
      set => this.zEND_ASR_CLLI_CD__cField = value;
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
    public string ZEND_PROFIT_CTR_CD__c
    {
      get => this.zEND_PROFIT_CTR_CD__cField;
      set => this.zEND_PROFIT_CTR_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_PROFIT_CTR_SOURCE_TYP__c
    {
      get => this.zEND_PROFIT_CTR_SOURCE_TYP__cField;
      set => this.zEND_PROFIT_CTR_SOURCE_TYP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_REGION_CD__c
    {
      get => this.zEND_REGION_CD__cField;
      set => this.zEND_REGION_CD__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ZEND_SITE_ASR__c
    {
      get => this.zEND_SITE_ASR__cField;
      set => this.zEND_SITE_ASR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public SITE__c ZEND_SITE_ASR__r
    {
      get => this.zEND_SITE_ASR__rField;
      set => this.zEND_SITE_ASR__rField = value;
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
  }
}
