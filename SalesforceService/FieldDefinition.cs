// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FieldDefinition
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
  public class FieldDefinition : sObject
  {
    private QueryResult controlledFieldsField;
    private FieldDefinition controllingFieldDefinitionField;
    private string controllingFieldDefinitionIdField;
    private string dataTypeField;
    private string developerNameField;
    private string durableIdField;
    private EntityDefinition entityDefinitionField;
    private string entityDefinitionIdField;
    private string extraTypeInfoField;
    private bool? isApiFilterableField;
    private bool isApiFilterableFieldSpecified;
    private bool? isApiGroupableField;
    private bool isApiGroupableFieldSpecified;
    private bool? isApiSortableField;
    private bool isApiSortableFieldSpecified;
    private bool? isCalculatedField;
    private bool isCalculatedFieldSpecified;
    private bool? isCompactLayoutableField;
    private bool isCompactLayoutableFieldSpecified;
    private bool? isCompoundField;
    private bool isCompoundFieldSpecified;
    private bool? isFieldHistoryTrackedField;
    private bool isFieldHistoryTrackedFieldSpecified;
    private bool? isHighScaleNumberField;
    private bool isHighScaleNumberFieldSpecified;
    private bool? isHtmlFormattedField;
    private bool isHtmlFormattedFieldSpecified;
    private bool? isIndexedField;
    private bool isIndexedFieldSpecified;
    private bool? isListFilterableField;
    private bool isListFilterableFieldSpecified;
    private bool? isListSortableField;
    private bool isListSortableFieldSpecified;
    private bool? isListVisibleField;
    private bool isListVisibleFieldSpecified;
    private bool? isNameFieldField;
    private bool isNameFieldFieldSpecified;
    private bool? isNillableField;
    private bool isNillableFieldSpecified;
    private bool? isWorkflowFilterableField;
    private bool isWorkflowFilterableFieldSpecified;
    private string labelField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private int? lengthField;
    private bool lengthFieldSpecified;
    private string masterLabelField;
    private string namespacePrefixField;
    private QueryResult particlesField;
    private int? precisionField;
    private bool precisionFieldSpecified;
    private Publisher publisherField;
    private string publisherIdField;
    private string qualifiedApiNameField;
    private string referenceTargetFieldField;
    private string[] referenceToField;
    private QueryResult relationshipDomainsField;
    private string relationshipNameField;
    private UserFieldAccess runningUserFieldAccessField;
    private string runningUserFieldAccessIdField;
    private int? scaleField;
    private bool scaleFieldSpecified;
    private ProjectSubmissionsSvcLib.SalesforceService.DataType serviceDataTypeField;
    private string serviceDataTypeIdField;
    private ProjectSubmissionsSvcLib.SalesforceService.DataType valueTypeField;
    private string valueTypeIdField;

    [XmlElement(IsNullable = true)]
    public QueryResult ControlledFields
    {
      get => this.controlledFieldsField;
      set => this.controlledFieldsField = value;
    }

    [XmlElement(IsNullable = true)]
    public FieldDefinition ControllingFieldDefinition
    {
      get => this.controllingFieldDefinitionField;
      set => this.controllingFieldDefinitionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ControllingFieldDefinitionId
    {
      get => this.controllingFieldDefinitionIdField;
      set => this.controllingFieldDefinitionIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DataType
    {
      get => this.dataTypeField;
      set => this.dataTypeField = value;
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
    public EntityDefinition EntityDefinition
    {
      get => this.entityDefinitionField;
      set => this.entityDefinitionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EntityDefinitionId
    {
      get => this.entityDefinitionIdField;
      set => this.entityDefinitionIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExtraTypeInfo
    {
      get => this.extraTypeInfoField;
      set => this.extraTypeInfoField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsApiFilterable
    {
      get => this.isApiFilterableField;
      set => this.isApiFilterableField = value;
    }

    [XmlIgnore]
    public bool IsApiFilterableSpecified
    {
      get => this.isApiFilterableFieldSpecified;
      set => this.isApiFilterableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsApiGroupable
    {
      get => this.isApiGroupableField;
      set => this.isApiGroupableField = value;
    }

    [XmlIgnore]
    public bool IsApiGroupableSpecified
    {
      get => this.isApiGroupableFieldSpecified;
      set => this.isApiGroupableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsApiSortable
    {
      get => this.isApiSortableField;
      set => this.isApiSortableField = value;
    }

    [XmlIgnore]
    public bool IsApiSortableSpecified
    {
      get => this.isApiSortableFieldSpecified;
      set => this.isApiSortableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsCalculated
    {
      get => this.isCalculatedField;
      set => this.isCalculatedField = value;
    }

    [XmlIgnore]
    public bool IsCalculatedSpecified
    {
      get => this.isCalculatedFieldSpecified;
      set => this.isCalculatedFieldSpecified = value;
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
    public bool? IsCompound
    {
      get => this.isCompoundField;
      set => this.isCompoundField = value;
    }

    [XmlIgnore]
    public bool IsCompoundSpecified
    {
      get => this.isCompoundFieldSpecified;
      set => this.isCompoundFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsFieldHistoryTracked
    {
      get => this.isFieldHistoryTrackedField;
      set => this.isFieldHistoryTrackedField = value;
    }

    [XmlIgnore]
    public bool IsFieldHistoryTrackedSpecified
    {
      get => this.isFieldHistoryTrackedFieldSpecified;
      set => this.isFieldHistoryTrackedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsHighScaleNumber
    {
      get => this.isHighScaleNumberField;
      set => this.isHighScaleNumberField = value;
    }

    [XmlIgnore]
    public bool IsHighScaleNumberSpecified
    {
      get => this.isHighScaleNumberFieldSpecified;
      set => this.isHighScaleNumberFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsHtmlFormatted
    {
      get => this.isHtmlFormattedField;
      set => this.isHtmlFormattedField = value;
    }

    [XmlIgnore]
    public bool IsHtmlFormattedSpecified
    {
      get => this.isHtmlFormattedFieldSpecified;
      set => this.isHtmlFormattedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsIndexed
    {
      get => this.isIndexedField;
      set => this.isIndexedField = value;
    }

    [XmlIgnore]
    public bool IsIndexedSpecified
    {
      get => this.isIndexedFieldSpecified;
      set => this.isIndexedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsListFilterable
    {
      get => this.isListFilterableField;
      set => this.isListFilterableField = value;
    }

    [XmlIgnore]
    public bool IsListFilterableSpecified
    {
      get => this.isListFilterableFieldSpecified;
      set => this.isListFilterableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsListSortable
    {
      get => this.isListSortableField;
      set => this.isListSortableField = value;
    }

    [XmlIgnore]
    public bool IsListSortableSpecified
    {
      get => this.isListSortableFieldSpecified;
      set => this.isListSortableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsListVisible
    {
      get => this.isListVisibleField;
      set => this.isListVisibleField = value;
    }

    [XmlIgnore]
    public bool IsListVisibleSpecified
    {
      get => this.isListVisibleFieldSpecified;
      set => this.isListVisibleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsNameField
    {
      get => this.isNameFieldField;
      set => this.isNameFieldField = value;
    }

    [XmlIgnore]
    public bool IsNameFieldSpecified
    {
      get => this.isNameFieldFieldSpecified;
      set => this.isNameFieldFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsNillable
    {
      get => this.isNillableField;
      set => this.isNillableField = value;
    }

    [XmlIgnore]
    public bool IsNillableSpecified
    {
      get => this.isNillableFieldSpecified;
      set => this.isNillableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsWorkflowFilterable
    {
      get => this.isWorkflowFilterableField;
      set => this.isWorkflowFilterableField = value;
    }

    [XmlIgnore]
    public bool IsWorkflowFilterableSpecified
    {
      get => this.isWorkflowFilterableFieldSpecified;
      set => this.isWorkflowFilterableFieldSpecified = value;
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
    public int? Length
    {
      get => this.lengthField;
      set => this.lengthField = value;
    }

    [XmlIgnore]
    public bool LengthSpecified
    {
      get => this.lengthFieldSpecified;
      set => this.lengthFieldSpecified = value;
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
    public QueryResult Particles
    {
      get => this.particlesField;
      set => this.particlesField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Precision
    {
      get => this.precisionField;
      set => this.precisionField = value;
    }

    [XmlIgnore]
    public bool PrecisionSpecified
    {
      get => this.precisionFieldSpecified;
      set => this.precisionFieldSpecified = value;
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

    [XmlElement(IsNullable = true)]
    public string ReferenceTargetField
    {
      get => this.referenceTargetFieldField;
      set => this.referenceTargetFieldField = value;
    }

    [XmlArrayItem("referenceTo", Namespace = "urn:enterprise.soap.sforce.com", IsNullable = false)]
    [XmlArray(IsNullable = true)]
    public string[] ReferenceTo
    {
      get => this.referenceToField;
      set => this.referenceToField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult RelationshipDomains
    {
      get => this.relationshipDomainsField;
      set => this.relationshipDomainsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationshipName
    {
      get => this.relationshipNameField;
      set => this.relationshipNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserFieldAccess RunningUserFieldAccess
    {
      get => this.runningUserFieldAccessField;
      set => this.runningUserFieldAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RunningUserFieldAccessId
    {
      get => this.runningUserFieldAccessIdField;
      set => this.runningUserFieldAccessIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Scale
    {
      get => this.scaleField;
      set => this.scaleField = value;
    }

    [XmlIgnore]
    public bool ScaleSpecified
    {
      get => this.scaleFieldSpecified;
      set => this.scaleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.DataType ServiceDataType
    {
      get => this.serviceDataTypeField;
      set => this.serviceDataTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ServiceDataTypeId
    {
      get => this.serviceDataTypeIdField;
      set => this.serviceDataTypeIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.DataType ValueType
    {
      get => this.valueTypeField;
      set => this.valueTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ValueTypeId
    {
      get => this.valueTypeIdField;
      set => this.valueTypeIdField = value;
    }
  }
}
