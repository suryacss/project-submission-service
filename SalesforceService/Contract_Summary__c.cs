// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Contract_Summary__c
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class Contract_Summary__c : sObject
  {
    private string aUP_Section__cField;
    private string acceptable_Use_Policy_AUP__cField;
    private string acceptance_of_Service_Process_Section__cField;
    private string acceptance_of_Services_Process__cField;
    private QueryResult activityHistoriesField;
    private string affiliate_Assignment_Rights_Section__cField;
    private string affiliate_Assignment_Rights__cField;
    private string approved_Method_for_Ordering_Section__cField;
    private string approved_Method_for_Ordering__cField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string backbilling_Section__cField;
    private string backbilling__cField;
    private string broadband_Specific_SLAs_Section__cField;
    private string broadband_Specific_SLAs__cField;
    private string chronic_Outages_and_Remedies_Section__cField;
    private string chronic_Outages_and_Remedies__cField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private string contract_Amendment_Names_Related_Data__cField;
    private QueryResult contract_Summaries__rField;
    private string contract_Summary_Parent__cField;
    private Contract_Summary__c contract_Summary_Parent__rField;
    private bool? contract_Summary_Verified__cField;
    private bool contract_Summary_Verified__cFieldSpecified;
    private string contract_Title__cField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string credits_for_Missing_SLAs_Section__cField;
    private string credits_for_Missing_SLAs__cField;
    private string credits_for_missing_FOC_Section__cField;
    private string credits_for_missing_FOC_and_or_Standard__cField;
    private string delay_in_Start_Date_Section__cField;
    private string delay_in_Start_Date__cField;
    private string discount_Schedules_Section__cField;
    private string discount_Schedules__cField;
    private string dispute_Process_and_Guidelines_Section__cField;
    private string dispute_Process_and_Guidelines__cField;
    private string docs_Incorp_by_Agr_GuidesTariffsEtc__cField;
    private string docs_Incorp_by_Agr_Section__cField;
    private QueryResult duplicateRecordItemsField;
    private QueryResult emailsField;
    private string ethernet_Specific_SLAs_Section__cField;
    private string ethernet_Specific_SLAs__cField;
    private QueryResult eventsField;
    private string evergreen_Contract_Section__cField;
    private string evergreen_Contract__cField;
    private string executed_Contracts_Folder_Hyperlink__cField;
    private string executed_Contracts_Folder__cField;
    private string expedite_Process_and_Charges_Section__cField;
    private string expedite_Process_and_Charges__cField;
    private QueryResult feedSubscriptionsForEntityField;
    private string general_Document_Description_Section__cField;
    private string general_Document_Description__cField;
    private QueryResult historiesField;
    private string interval_to_Accept_Order_Section__cField;
    private string interval_to_Accept_Order__cField;
    private string interval_to_Return_DLR_Section__cField;
    private string interval_to_Return_DLR__cField;
    private string interval_to_Return_FOC_Section__cField;
    private string interval_to_Return_FOC__cField;
    private string invoice_Format_Section__cField;
    private string invoice_Format__cField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
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
    private string level_3_Entity__cField;
    private string location_Restrictions_on_Pricing_Section__cField;
    private string location_Restricts_Pricing_Tier_1_2_etc__cField;
    private QueryResult lookedUpFromActivitiesField;
    private string mFP_MFN_Section__cField;
    private string mFP_MFN__cField;
    private string master_Contract_Effective_Date_Section__cField;
    private string master_Contract_Effective_Date__cField;
    private string master_Contract_Expiration_Date_Section__cField;
    private string master_Contract_Expiration_Date__cField;
    private string nORMALIZED_VENDOR_NAME__cField;
    private Account nORMALIZED_VENDOR_NAME__rField;
    private string nameField;
    private string non_Payment_Section__cField;
    private string non_Payment__cField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private QueryResult openActivitiesField;
    private string order_Term_Section__cField;
    private string order_Term__cField;
    private string original_Master_Contract_Term_Section__cField;
    private string original_Master_Contract_Term__cField;
    private string other_Authorized_Charges_Fees_Section__cField;
    private string other_Authorized_Charges_Fees__cField;
    private string other_Contract_Expiration_Date__cField;
    private string other_TL_Portability_Restrictions__cField;
    private string other_TL_Portability_Restricts_Section__cField;
    private string payment_Guidelines_Section__cField;
    private string payment_Guidelines__cField;
    private string portability_Options_Section__cField;
    private string portability_Options__cField;
    private string post_Install_Disco_Process_Section__cField;
    private string post_Install_Disconnect_Process_Interval__cField;
    private string pre_Install_Cancel_Rules_Charges_Section__cField;
    private string pre_Install_Cancel_Rules_Charges__cField;
    private string preferred_Pricing_Clause_Section__cField;
    private string preferred_Pricing_Clause__cField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string process_for_Managing_Portability_Section__cField;
    private string process_for_Managing_Portability__cField;
    private string products_Covered__cField;
    private string rate_Card_Section__cField;
    private string rate_Card__cField;
    private QueryResult recordAssociatedGroupsField;
    private string renewal_Terms_Section__cField;
    private string renewal_Terms__cField;
    private string rules_for_Rerates_Section__cField;
    private string rules_for_Rerates__cField;
    private string sLAs_Availability_Section__cField;
    private string sLAs_Availability__cField;
    private string sLAs_MTTR_Section__cField;
    private string sLAs_MTTR__cField;
    private string scheduled_Maintenance_Notice_Section__cField;
    private string scheduled_Maintenance_and_Notice__cField;
    private string services_Impacted_Section__cField;
    private string services_Impacted__cField;
    private string standard_Intervals_for_Install_Section__cField;
    private string standard_Intervals_for_Installation__cField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string take_or_Pay_Agreement_Section__cField;
    private string take_or_Pay_Agreement_Terms__cField;
    private QueryResult tasksField;
    private string template_Paper__cField;
    private string term_Liability_Formula_Section__cField;
    private string term_Liability_Formula__cField;
    private QueryResult topicAssignmentsField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public string AUP_Section__c
    {
      get => this.aUP_Section__cField;
      set => this.aUP_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Acceptable_Use_Policy_AUP__c
    {
      get => this.acceptable_Use_Policy_AUP__cField;
      set => this.acceptable_Use_Policy_AUP__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Acceptance_of_Service_Process_Section__c
    {
      get => this.acceptance_of_Service_Process_Section__cField;
      set => this.acceptance_of_Service_Process_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Acceptance_of_Services_Process__c
    {
      get => this.acceptance_of_Services_Process__cField;
      set => this.acceptance_of_Services_Process__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ActivityHistories
    {
      get => this.activityHistoriesField;
      set => this.activityHistoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Affiliate_Assignment_Rights_Section__c
    {
      get => this.affiliate_Assignment_Rights_Section__cField;
      set => this.affiliate_Assignment_Rights_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Affiliate_Assignment_Rights__c
    {
      get => this.affiliate_Assignment_Rights__cField;
      set => this.affiliate_Assignment_Rights__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Approved_Method_for_Ordering_Section__c
    {
      get => this.approved_Method_for_Ordering_Section__cField;
      set => this.approved_Method_for_Ordering_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Approved_Method_for_Ordering__c
    {
      get => this.approved_Method_for_Ordering__cField;
      set => this.approved_Method_for_Ordering__cField = value;
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
    public string Backbilling_Section__c
    {
      get => this.backbilling_Section__cField;
      set => this.backbilling_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Backbilling__c
    {
      get => this.backbilling__cField;
      set => this.backbilling__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Broadband_Specific_SLAs_Section__c
    {
      get => this.broadband_Specific_SLAs_Section__cField;
      set => this.broadband_Specific_SLAs_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Broadband_Specific_SLAs__c
    {
      get => this.broadband_Specific_SLAs__cField;
      set => this.broadband_Specific_SLAs__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Chronic_Outages_and_Remedies_Section__c
    {
      get => this.chronic_Outages_and_Remedies_Section__cField;
      set => this.chronic_Outages_and_Remedies_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Chronic_Outages_and_Remedies__c
    {
      get => this.chronic_Outages_and_Remedies__cField;
      set => this.chronic_Outages_and_Remedies__cField = value;
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
    public string Contract_Amendment_Names_Related_Data__c
    {
      get => this.contract_Amendment_Names_Related_Data__cField;
      set => this.contract_Amendment_Names_Related_Data__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Contract_Summaries__r
    {
      get => this.contract_Summaries__rField;
      set => this.contract_Summaries__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Contract_Summary_Parent__c
    {
      get => this.contract_Summary_Parent__cField;
      set => this.contract_Summary_Parent__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Contract_Summary__c Contract_Summary_Parent__r
    {
      get => this.contract_Summary_Parent__rField;
      set => this.contract_Summary_Parent__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Contract_Summary_Verified__c
    {
      get => this.contract_Summary_Verified__cField;
      set => this.contract_Summary_Verified__cField = value;
    }

    [XmlIgnore]
    public bool Contract_Summary_Verified__cSpecified
    {
      get => this.contract_Summary_Verified__cFieldSpecified;
      set => this.contract_Summary_Verified__cFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Contract_Title__c
    {
      get => this.contract_Title__cField;
      set => this.contract_Title__cField = value;
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
    public string Credits_for_Missing_SLAs_Section__c
    {
      get => this.credits_for_Missing_SLAs_Section__cField;
      set => this.credits_for_Missing_SLAs_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Credits_for_Missing_SLAs__c
    {
      get => this.credits_for_Missing_SLAs__cField;
      set => this.credits_for_Missing_SLAs__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Credits_for_missing_FOC_Section__c
    {
      get => this.credits_for_missing_FOC_Section__cField;
      set => this.credits_for_missing_FOC_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Credits_for_missing_FOC_and_or_Standard__c
    {
      get => this.credits_for_missing_FOC_and_or_Standard__cField;
      set => this.credits_for_missing_FOC_and_or_Standard__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Delay_in_Start_Date_Section__c
    {
      get => this.delay_in_Start_Date_Section__cField;
      set => this.delay_in_Start_Date_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Delay_in_Start_Date__c
    {
      get => this.delay_in_Start_Date__cField;
      set => this.delay_in_Start_Date__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Discount_Schedules_Section__c
    {
      get => this.discount_Schedules_Section__cField;
      set => this.discount_Schedules_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Discount_Schedules__c
    {
      get => this.discount_Schedules__cField;
      set => this.discount_Schedules__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Dispute_Process_and_Guidelines_Section__c
    {
      get => this.dispute_Process_and_Guidelines_Section__cField;
      set => this.dispute_Process_and_Guidelines_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Dispute_Process_and_Guidelines__c
    {
      get => this.dispute_Process_and_Guidelines__cField;
      set => this.dispute_Process_and_Guidelines__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Docs_Incorp_by_Agr_GuidesTariffsEtc__c
    {
      get => this.docs_Incorp_by_Agr_GuidesTariffsEtc__cField;
      set => this.docs_Incorp_by_Agr_GuidesTariffsEtc__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Docs_Incorp_by_Agr_Section__c
    {
      get => this.docs_Incorp_by_Agr_Section__cField;
      set => this.docs_Incorp_by_Agr_Section__cField = value;
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
    public string Ethernet_Specific_SLAs_Section__c
    {
      get => this.ethernet_Specific_SLAs_Section__cField;
      set => this.ethernet_Specific_SLAs_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Ethernet_Specific_SLAs__c
    {
      get => this.ethernet_Specific_SLAs__cField;
      set => this.ethernet_Specific_SLAs__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Events
    {
      get => this.eventsField;
      set => this.eventsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Evergreen_Contract_Section__c
    {
      get => this.evergreen_Contract_Section__cField;
      set => this.evergreen_Contract_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Evergreen_Contract__c
    {
      get => this.evergreen_Contract__cField;
      set => this.evergreen_Contract__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Executed_Contracts_Folder_Hyperlink__c
    {
      get => this.executed_Contracts_Folder_Hyperlink__cField;
      set => this.executed_Contracts_Folder_Hyperlink__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Executed_Contracts_Folder__c
    {
      get => this.executed_Contracts_Folder__cField;
      set => this.executed_Contracts_Folder__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Expedite_Process_and_Charges_Section__c
    {
      get => this.expedite_Process_and_Charges_Section__cField;
      set => this.expedite_Process_and_Charges_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Expedite_Process_and_Charges__c
    {
      get => this.expedite_Process_and_Charges__cField;
      set => this.expedite_Process_and_Charges__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string General_Document_Description_Section__c
    {
      get => this.general_Document_Description_Section__cField;
      set => this.general_Document_Description_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string General_Document_Description__c
    {
      get => this.general_Document_Description__cField;
      set => this.general_Document_Description__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Interval_to_Accept_Order_Section__c
    {
      get => this.interval_to_Accept_Order_Section__cField;
      set => this.interval_to_Accept_Order_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Interval_to_Accept_Order__c
    {
      get => this.interval_to_Accept_Order__cField;
      set => this.interval_to_Accept_Order__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Interval_to_Return_DLR_Section__c
    {
      get => this.interval_to_Return_DLR_Section__cField;
      set => this.interval_to_Return_DLR_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Interval_to_Return_DLR__c
    {
      get => this.interval_to_Return_DLR__cField;
      set => this.interval_to_Return_DLR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Interval_to_Return_FOC_Section__c
    {
      get => this.interval_to_Return_FOC_Section__cField;
      set => this.interval_to_Return_FOC_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Interval_to_Return_FOC__c
    {
      get => this.interval_to_Return_FOC__cField;
      set => this.interval_to_Return_FOC__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Invoice_Format_Section__c
    {
      get => this.invoice_Format_Section__cField;
      set => this.invoice_Format_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Invoice_Format__c
    {
      get => this.invoice_Format__cField;
      set => this.invoice_Format__cField = value;
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
    public string Level_3_Entity__c
    {
      get => this.level_3_Entity__cField;
      set => this.level_3_Entity__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Location_Restrictions_on_Pricing_Section__c
    {
      get => this.location_Restrictions_on_Pricing_Section__cField;
      set => this.location_Restrictions_on_Pricing_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Location_Restricts_Pricing_Tier_1_2_etc__c
    {
      get => this.location_Restricts_Pricing_Tier_1_2_etc__cField;
      set => this.location_Restricts_Pricing_Tier_1_2_etc__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult LookedUpFromActivities
    {
      get => this.lookedUpFromActivitiesField;
      set => this.lookedUpFromActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MFP_MFN_Section__c
    {
      get => this.mFP_MFN_Section__cField;
      set => this.mFP_MFN_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MFP_MFN__c
    {
      get => this.mFP_MFN__cField;
      set => this.mFP_MFN__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Master_Contract_Effective_Date_Section__c
    {
      get => this.master_Contract_Effective_Date_Section__cField;
      set => this.master_Contract_Effective_Date_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Master_Contract_Effective_Date__c
    {
      get => this.master_Contract_Effective_Date__cField;
      set => this.master_Contract_Effective_Date__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Master_Contract_Expiration_Date_Section__c
    {
      get => this.master_Contract_Expiration_Date_Section__cField;
      set => this.master_Contract_Expiration_Date_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Master_Contract_Expiration_Date__c
    {
      get => this.master_Contract_Expiration_Date__cField;
      set => this.master_Contract_Expiration_Date__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NORMALIZED_VENDOR_NAME__c
    {
      get => this.nORMALIZED_VENDOR_NAME__cField;
      set => this.nORMALIZED_VENDOR_NAME__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public Account NORMALIZED_VENDOR_NAME__r
    {
      get => this.nORMALIZED_VENDOR_NAME__rField;
      set => this.nORMALIZED_VENDOR_NAME__rField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Non_Payment_Section__c
    {
      get => this.non_Payment_Section__cField;
      set => this.non_Payment_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Non_Payment__c
    {
      get => this.non_Payment__cField;
      set => this.non_Payment__cField = value;
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
    public QueryResult OpenActivities
    {
      get => this.openActivitiesField;
      set => this.openActivitiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Order_Term_Section__c
    {
      get => this.order_Term_Section__cField;
      set => this.order_Term_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Order_Term__c
    {
      get => this.order_Term__cField;
      set => this.order_Term__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Original_Master_Contract_Term_Section__c
    {
      get => this.original_Master_Contract_Term_Section__cField;
      set => this.original_Master_Contract_Term_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Original_Master_Contract_Term__c
    {
      get => this.original_Master_Contract_Term__cField;
      set => this.original_Master_Contract_Term__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Other_Authorized_Charges_Fees_Section__c
    {
      get => this.other_Authorized_Charges_Fees_Section__cField;
      set => this.other_Authorized_Charges_Fees_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Other_Authorized_Charges_Fees__c
    {
      get => this.other_Authorized_Charges_Fees__cField;
      set => this.other_Authorized_Charges_Fees__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Other_Contract_Expiration_Date__c
    {
      get => this.other_Contract_Expiration_Date__cField;
      set => this.other_Contract_Expiration_Date__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Other_TL_Portability_Restrictions__c
    {
      get => this.other_TL_Portability_Restrictions__cField;
      set => this.other_TL_Portability_Restrictions__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Other_TL_Portability_Restricts_Section__c
    {
      get => this.other_TL_Portability_Restricts_Section__cField;
      set => this.other_TL_Portability_Restricts_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Payment_Guidelines_Section__c
    {
      get => this.payment_Guidelines_Section__cField;
      set => this.payment_Guidelines_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Payment_Guidelines__c
    {
      get => this.payment_Guidelines__cField;
      set => this.payment_Guidelines__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Portability_Options_Section__c
    {
      get => this.portability_Options_Section__cField;
      set => this.portability_Options_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Portability_Options__c
    {
      get => this.portability_Options__cField;
      set => this.portability_Options__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Post_Install_Disco_Process_Section__c
    {
      get => this.post_Install_Disco_Process_Section__cField;
      set => this.post_Install_Disco_Process_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Post_Install_Disconnect_Process_Interval__c
    {
      get => this.post_Install_Disconnect_Process_Interval__cField;
      set => this.post_Install_Disconnect_Process_Interval__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Pre_Install_Cancel_Rules_Charges_Section__c
    {
      get => this.pre_Install_Cancel_Rules_Charges_Section__cField;
      set => this.pre_Install_Cancel_Rules_Charges_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Pre_Install_Cancel_Rules_Charges__c
    {
      get => this.pre_Install_Cancel_Rules_Charges__cField;
      set => this.pre_Install_Cancel_Rules_Charges__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Preferred_Pricing_Clause_Section__c
    {
      get => this.preferred_Pricing_Clause_Section__cField;
      set => this.preferred_Pricing_Clause_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Preferred_Pricing_Clause__c
    {
      get => this.preferred_Pricing_Clause__cField;
      set => this.preferred_Pricing_Clause__cField = value;
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
    public string Process_for_Managing_Portability_Section__c
    {
      get => this.process_for_Managing_Portability_Section__cField;
      set => this.process_for_Managing_Portability_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Process_for_Managing_Portability__c
    {
      get => this.process_for_Managing_Portability__cField;
      set => this.process_for_Managing_Portability__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Products_Covered__c
    {
      get => this.products_Covered__cField;
      set => this.products_Covered__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Rate_Card_Section__c
    {
      get => this.rate_Card_Section__cField;
      set => this.rate_Card_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Rate_Card__c
    {
      get => this.rate_Card__cField;
      set => this.rate_Card__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RecordAssociatedGroups
    {
      get => this.recordAssociatedGroupsField;
      set => this.recordAssociatedGroupsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Renewal_Terms_Section__c
    {
      get => this.renewal_Terms_Section__cField;
      set => this.renewal_Terms_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Renewal_Terms__c
    {
      get => this.renewal_Terms__cField;
      set => this.renewal_Terms__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Rules_for_Rerates_Section__c
    {
      get => this.rules_for_Rerates_Section__cField;
      set => this.rules_for_Rerates_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Rules_for_Rerates__c
    {
      get => this.rules_for_Rerates__cField;
      set => this.rules_for_Rerates__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SLAs_Availability_Section__c
    {
      get => this.sLAs_Availability_Section__cField;
      set => this.sLAs_Availability_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SLAs_Availability__c
    {
      get => this.sLAs_Availability__cField;
      set => this.sLAs_Availability__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SLAs_MTTR_Section__c
    {
      get => this.sLAs_MTTR_Section__cField;
      set => this.sLAs_MTTR_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SLAs_MTTR__c
    {
      get => this.sLAs_MTTR__cField;
      set => this.sLAs_MTTR__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Scheduled_Maintenance_Notice_Section__c
    {
      get => this.scheduled_Maintenance_Notice_Section__cField;
      set => this.scheduled_Maintenance_Notice_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Scheduled_Maintenance_and_Notice__c
    {
      get => this.scheduled_Maintenance_and_Notice__cField;
      set => this.scheduled_Maintenance_and_Notice__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Services_Impacted_Section__c
    {
      get => this.services_Impacted_Section__cField;
      set => this.services_Impacted_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Services_Impacted__c
    {
      get => this.services_Impacted__cField;
      set => this.services_Impacted__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Standard_Intervals_for_Install_Section__c
    {
      get => this.standard_Intervals_for_Install_Section__cField;
      set => this.standard_Intervals_for_Install_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Standard_Intervals_for_Installation__c
    {
      get => this.standard_Intervals_for_Installation__cField;
      set => this.standard_Intervals_for_Installation__cField = value;
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
    public string Take_or_Pay_Agreement_Section__c
    {
      get => this.take_or_Pay_Agreement_Section__cField;
      set => this.take_or_Pay_Agreement_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Take_or_Pay_Agreement_Terms__c
    {
      get => this.take_or_Pay_Agreement_Terms__cField;
      set => this.take_or_Pay_Agreement_Terms__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Tasks
    {
      get => this.tasksField;
      set => this.tasksField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Template_Paper__c
    {
      get => this.template_Paper__cField;
      set => this.template_Paper__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Term_Liability_Formula_Section__c
    {
      get => this.term_Liability_Formula_Section__cField;
      set => this.term_Liability_Formula_Section__cField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Term_Liability_Formula__c
    {
      get => this.term_Liability_Formula__cField;
      set => this.term_Liability_Formula__cField = value;
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
