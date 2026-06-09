// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EntityDefinition
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
  public class EntityDefinition : sObject
  {
    private QueryResult childRelationshipsField;
    private string defaultCompactLayoutIdField;
    private string detailUrlField;
    private string developerNameField;
    private string durableIdField;
    private string editDefinitionUrlField;
    private string editUrlField;
    private string externalSharingModelField;
    private QueryResult fieldsField;
    private bool? hasSubtypesField;
    private bool hasSubtypesFieldSpecified;
    private string helpSettingPageNameField;
    private string helpSettingPageUrlField;
    private string internalSharingModelField;
    private bool? isApexTriggerableField;
    private bool isApexTriggerableFieldSpecified;
    private bool? isCompactLayoutableField;
    private bool isCompactLayoutableFieldSpecified;
    private bool? isCustomSettingField;
    private bool isCustomSettingFieldSpecified;
    private bool? isCustomizableField;
    private bool isCustomizableFieldSpecified;
    private bool? isDeprecatedAndHiddenField;
    private bool isDeprecatedAndHiddenFieldSpecified;
    private bool? isEverCreatableField;
    private bool isEverCreatableFieldSpecified;
    private bool? isEverDeletableField;
    private bool isEverDeletableFieldSpecified;
    private bool? isEverUpdatableField;
    private bool isEverUpdatableFieldSpecified;
    private bool? isFeedEnabledField;
    private bool isFeedEnabledFieldSpecified;
    private bool? isIdEnabledField;
    private bool isIdEnabledFieldSpecified;
    private bool? isLayoutableField;
    private bool isLayoutableFieldSpecified;
    private bool? isMruEnabledField;
    private bool isMruEnabledFieldSpecified;
    private bool? isProcessEnabledField;
    private bool isProcessEnabledFieldSpecified;
    private bool? isQueryableField;
    private bool isQueryableFieldSpecified;
    private bool? isReplicateableField;
    private bool isReplicateableFieldSpecified;
    private bool? isRetrieveableField;
    private bool isRetrieveableFieldSpecified;
    private bool? isSearchLayoutableField;
    private bool isSearchLayoutableFieldSpecified;
    private bool? isSearchableField;
    private bool isSearchableFieldSpecified;
    private bool? isSubtypeField;
    private bool isSubtypeFieldSpecified;
    private bool? isTriggerableField;
    private bool isTriggerableFieldSpecified;
    private bool? isWorkflowEnabledField;
    private bool isWorkflowEnabledFieldSpecified;
    private string keyPrefixField;
    private string labelField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string masterLabelField;
    private string namespacePrefixField;
    private string newUrlField;
    private QueryResult ownerChangeOptionsField;
    private QueryResult particlesField;
    private string pluralLabelField;
    private Publisher publisherField;
    private string publisherIdField;
    private string qualifiedApiNameField;
    private RecordTypeInfo[] recordTypesSupportedField;
    private QueryResult relationshipDomainsField;
    private UserEntityAccess runningUserEntityAccessField;
    private string runningUserEntityAccessIdField;
    private QueryResult searchLayoutsField;

    [XmlElement(IsNullable = true)]
    public QueryResult ChildRelationships
    {
      get => this.childRelationshipsField;
      set => this.childRelationshipsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultCompactLayoutId
    {
      get => this.defaultCompactLayoutIdField;
      set => this.defaultCompactLayoutIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DetailUrl
    {
      get => this.detailUrlField;
      set => this.detailUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EditDefinitionUrl
    {
      get => this.editDefinitionUrlField;
      set => this.editDefinitionUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EditUrl
    {
      get => this.editUrlField;
      set => this.editUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalSharingModel
    {
      get => this.externalSharingModelField;
      set => this.externalSharingModelField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Fields
    {
      get => this.fieldsField;
      set => this.fieldsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasSubtypes
    {
      get => this.hasSubtypesField;
      set => this.hasSubtypesField = value;
    }

    [XmlIgnore]
    public bool HasSubtypesSpecified
    {
      get => this.hasSubtypesFieldSpecified;
      set => this.hasSubtypesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string HelpSettingPageName
    {
      get => this.helpSettingPageNameField;
      set => this.helpSettingPageNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string HelpSettingPageUrl
    {
      get => this.helpSettingPageUrlField;
      set => this.helpSettingPageUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string InternalSharingModel
    {
      get => this.internalSharingModelField;
      set => this.internalSharingModelField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsApexTriggerable
    {
      get => this.isApexTriggerableField;
      set => this.isApexTriggerableField = value;
    }

    [XmlIgnore]
    public bool IsApexTriggerableSpecified
    {
      get => this.isApexTriggerableFieldSpecified;
      set => this.isApexTriggerableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsCompactLayoutable
    {
      get => this.isCompactLayoutableField;
      set => this.isCompactLayoutableField = value;
    }

    [XmlIgnore]
    public bool IsCompactLayoutableSpecified
    {
      get => this.isCompactLayoutableFieldSpecified;
      set => this.isCompactLayoutableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsCustomSetting
    {
      get => this.isCustomSettingField;
      set => this.isCustomSettingField = value;
    }

    [XmlIgnore]
    public bool IsCustomSettingSpecified
    {
      get => this.isCustomSettingFieldSpecified;
      set => this.isCustomSettingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsCustomizable
    {
      get => this.isCustomizableField;
      set => this.isCustomizableField = value;
    }

    [XmlIgnore]
    public bool IsCustomizableSpecified
    {
      get => this.isCustomizableFieldSpecified;
      set => this.isCustomizableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeprecatedAndHidden
    {
      get => this.isDeprecatedAndHiddenField;
      set => this.isDeprecatedAndHiddenField = value;
    }

    [XmlIgnore]
    public bool IsDeprecatedAndHiddenSpecified
    {
      get => this.isDeprecatedAndHiddenFieldSpecified;
      set => this.isDeprecatedAndHiddenFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsEverCreatable
    {
      get => this.isEverCreatableField;
      set => this.isEverCreatableField = value;
    }

    [XmlIgnore]
    public bool IsEverCreatableSpecified
    {
      get => this.isEverCreatableFieldSpecified;
      set => this.isEverCreatableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsEverDeletable
    {
      get => this.isEverDeletableField;
      set => this.isEverDeletableField = value;
    }

    [XmlIgnore]
    public bool IsEverDeletableSpecified
    {
      get => this.isEverDeletableFieldSpecified;
      set => this.isEverDeletableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsEverUpdatable
    {
      get => this.isEverUpdatableField;
      set => this.isEverUpdatableField = value;
    }

    [XmlIgnore]
    public bool IsEverUpdatableSpecified
    {
      get => this.isEverUpdatableFieldSpecified;
      set => this.isEverUpdatableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsFeedEnabled
    {
      get => this.isFeedEnabledField;
      set => this.isFeedEnabledField = value;
    }

    [XmlIgnore]
    public bool IsFeedEnabledSpecified
    {
      get => this.isFeedEnabledFieldSpecified;
      set => this.isFeedEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsIdEnabled
    {
      get => this.isIdEnabledField;
      set => this.isIdEnabledField = value;
    }

    [XmlIgnore]
    public bool IsIdEnabledSpecified
    {
      get => this.isIdEnabledFieldSpecified;
      set => this.isIdEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsLayoutable
    {
      get => this.isLayoutableField;
      set => this.isLayoutableField = value;
    }

    [XmlIgnore]
    public bool IsLayoutableSpecified
    {
      get => this.isLayoutableFieldSpecified;
      set => this.isLayoutableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsMruEnabled
    {
      get => this.isMruEnabledField;
      set => this.isMruEnabledField = value;
    }

    [XmlIgnore]
    public bool IsMruEnabledSpecified
    {
      get => this.isMruEnabledFieldSpecified;
      set => this.isMruEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsProcessEnabled
    {
      get => this.isProcessEnabledField;
      set => this.isProcessEnabledField = value;
    }

    [XmlIgnore]
    public bool IsProcessEnabledSpecified
    {
      get => this.isProcessEnabledFieldSpecified;
      set => this.isProcessEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsQueryable
    {
      get => this.isQueryableField;
      set => this.isQueryableField = value;
    }

    [XmlIgnore]
    public bool IsQueryableSpecified
    {
      get => this.isQueryableFieldSpecified;
      set => this.isQueryableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsReplicateable
    {
      get => this.isReplicateableField;
      set => this.isReplicateableField = value;
    }

    [XmlIgnore]
    public bool IsReplicateableSpecified
    {
      get => this.isReplicateableFieldSpecified;
      set => this.isReplicateableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsRetrieveable
    {
      get => this.isRetrieveableField;
      set => this.isRetrieveableField = value;
    }

    [XmlIgnore]
    public bool IsRetrieveableSpecified
    {
      get => this.isRetrieveableFieldSpecified;
      set => this.isRetrieveableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsSearchLayoutable
    {
      get => this.isSearchLayoutableField;
      set => this.isSearchLayoutableField = value;
    }

    [XmlIgnore]
    public bool IsSearchLayoutableSpecified
    {
      get => this.isSearchLayoutableFieldSpecified;
      set => this.isSearchLayoutableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsSearchable
    {
      get => this.isSearchableField;
      set => this.isSearchableField = value;
    }

    [XmlIgnore]
    public bool IsSearchableSpecified
    {
      get => this.isSearchableFieldSpecified;
      set => this.isSearchableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsSubtype
    {
      get => this.isSubtypeField;
      set => this.isSubtypeField = value;
    }

    [XmlIgnore]
    public bool IsSubtypeSpecified
    {
      get => this.isSubtypeFieldSpecified;
      set => this.isSubtypeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsTriggerable
    {
      get => this.isTriggerableField;
      set => this.isTriggerableField = value;
    }

    [XmlIgnore]
    public bool IsTriggerableSpecified
    {
      get => this.isTriggerableFieldSpecified;
      set => this.isTriggerableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsWorkflowEnabled
    {
      get => this.isWorkflowEnabledField;
      set => this.isWorkflowEnabledField = value;
    }

    [XmlIgnore]
    public bool IsWorkflowEnabledSpecified
    {
      get => this.isWorkflowEnabledFieldSpecified;
      set => this.isWorkflowEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string KeyPrefix
    {
      get => this.keyPrefixField;
      set => this.keyPrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Label
    {
      get => this.labelField;
      set => this.labelField = value;
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
    public string MasterLabel
    {
      get => this.masterLabelField;
      set => this.masterLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NewUrl
    {
      get => this.newUrlField;
      set => this.newUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OwnerChangeOptions
    {
      get => this.ownerChangeOptionsField;
      set => this.ownerChangeOptionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Particles
    {
      get => this.particlesField;
      set => this.particlesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PluralLabel
    {
      get => this.pluralLabelField;
      set => this.pluralLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public Publisher Publisher
    {
      get => this.publisherField;
      set => this.publisherField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PublisherId
    {
      get => this.publisherIdField;
      set => this.publisherIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string QualifiedApiName
    {
      get => this.qualifiedApiNameField;
      set => this.qualifiedApiNameField = value;
    }

    [XmlArrayItem("recordTypeInfos", Namespace = "urn:enterprise.soap.sforce.com", IsNullable = false)]
    [XmlArray(IsNullable = true)]
    public RecordTypeInfo[] RecordTypesSupported
    {
      get => this.recordTypesSupportedField;
      set => this.recordTypesSupportedField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RelationshipDomains
    {
      get => this.relationshipDomainsField;
      set => this.relationshipDomainsField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserEntityAccess RunningUserEntityAccess
    {
      get => this.runningUserEntityAccessField;
      set => this.runningUserEntityAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RunningUserEntityAccessId
    {
      get => this.runningUserEntityAccessIdField;
      set => this.runningUserEntityAccessIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SearchLayouts
    {
      get => this.searchLayoutsField;
      set => this.searchLayoutsField = value;
    }
  }
}
