// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EntityParticle
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
  public class EntityParticle : sObject
  {
    private int? byteLengthField;
    private bool byteLengthFieldSpecified;
    private string dataTypeField;
    private string defaultValueFormulaField;
    private string developerNameField;
    private int? digitsField;
    private bool digitsFieldSpecified;
    private string durableIdField;
    private EntityDefinition entityDefinitionField;
    private string entityDefinitionIdField;
    private string extraTypeInfoField;
    private FieldDefinition fieldDefinitionField;
    private string fieldDefinitionIdField;
    private string inlineHelpTextField;
    private bool? isApiFilterableField;
    private bool isApiFilterableFieldSpecified;
    private bool? isApiGroupableField;
    private bool isApiGroupableFieldSpecified;
    private bool? isApiSortableField;
    private bool isApiSortableFieldSpecified;
    private bool? isAutonumberField;
    private bool isAutonumberFieldSpecified;
    private bool? isCalculatedField;
    private bool isCalculatedFieldSpecified;
    private bool? isCaseSensitiveField;
    private bool isCaseSensitiveFieldSpecified;
    private bool? isCompactLayoutableField;
    private bool isCompactLayoutableFieldSpecified;
    private bool? isComponentField;
    private bool isComponentFieldSpecified;
    private bool? isCompoundField;
    private bool isCompoundFieldSpecified;
    private bool? isCreatableField;
    private bool isCreatableFieldSpecified;
    private bool? isDefaultedOnCreateField;
    private bool isDefaultedOnCreateFieldSpecified;
    private bool? isDependentPicklistField;
    private bool isDependentPicklistFieldSpecified;
    private bool? isDeprecatedAndHiddenField;
    private bool isDeprecatedAndHiddenFieldSpecified;
    private bool? isDisplayLocationInDecimalField;
    private bool isDisplayLocationInDecimalFieldSpecified;
    private bool? isEncryptedField;
    private bool isEncryptedFieldSpecified;
    private bool? isFieldHistoryTrackedField;
    private bool isFieldHistoryTrackedFieldSpecified;
    private bool? isHighScaleNumberField;
    private bool isHighScaleNumberFieldSpecified;
    private bool? isHtmlFormattedField;
    private bool isHtmlFormattedFieldSpecified;
    private bool? isIdLookupField;
    private bool isIdLookupFieldSpecified;
    private bool? isLayoutableField;
    private bool isLayoutableFieldSpecified;
    private bool? isListVisibleField;
    private bool isListVisibleFieldSpecified;
    private bool? isNameFieldField;
    private bool isNameFieldFieldSpecified;
    private bool? isNamePointingField;
    private bool isNamePointingFieldSpecified;
    private bool? isNillableField;
    private bool isNillableFieldSpecified;
    private bool? isPermissionableField;
    private bool isPermissionableFieldSpecified;
    private bool? isUniqueField;
    private bool isUniqueFieldSpecified;
    private bool? isUpdatableField;
    private bool isUpdatableFieldSpecified;
    private bool? isWorkflowFilterableField;
    private bool isWorkflowFilterableFieldSpecified;
    private bool? isWriteRequiresMasterReadField;
    private bool isWriteRequiresMasterReadFieldSpecified;
    private string labelField;
    private int? lengthField;
    private bool lengthFieldSpecified;
    private string maskField;
    private string maskTypeField;
    private string masterLabelField;
    private string nameField;
    private string namespacePrefixField;
    private QueryResult picklistValuesField;
    private int? precisionField;
    private bool precisionFieldSpecified;
    private string qualifiedApiNameField;
    private string referenceTargetFieldField;
    private string[] referenceToField;
    private string relationshipNameField;
    private int? relationshipOrderField;
    private bool relationshipOrderFieldSpecified;
    private int? scaleField;
    private bool scaleFieldSpecified;
    private ProjectSubmissionsSvcLib.SalesforceService.DataType serviceDataTypeField;
    private string serviceDataTypeIdField;
    private ProjectSubmissionsSvcLib.SalesforceService.DataType valueTypeField;
    private string valueTypeIdField;

    [XmlElement(IsNullable = true)]
    public int? ByteLength
    {
      get => this.byteLengthField;
      set => this.byteLengthField = value;
    }

    [XmlIgnore]
    public bool ByteLengthSpecified
    {
      get => this.byteLengthFieldSpecified;
      set => this.byteLengthFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string DataType
    {
      get => this.dataTypeField;
      set => this.dataTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DefaultValueFormula
    {
      get => this.defaultValueFormulaField;
      set => this.defaultValueFormulaField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Digits
    {
      get => this.digitsField;
      set => this.digitsField = value;
    }

    [XmlIgnore]
    public bool DigitsSpecified
    {
      get => this.digitsFieldSpecified;
      set => this.digitsFieldSpecified = value;
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
    public FieldDefinition FieldDefinition
    {
      get => this.fieldDefinitionField;
      set => this.fieldDefinitionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FieldDefinitionId
    {
      get => this.fieldDefinitionIdField;
      set => this.fieldDefinitionIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string InlineHelpText
    {
      get => this.inlineHelpTextField;
      set => this.inlineHelpTextField = value;
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
    public bool? IsAutonumber
    {
      get => this.isAutonumberField;
      set => this.isAutonumberField = value;
    }

    [XmlIgnore]
    public bool IsAutonumberSpecified
    {
      get => this.isAutonumberFieldSpecified;
      set => this.isAutonumberFieldSpecified = value;
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
    public bool? IsCaseSensitive
    {
      get => this.isCaseSensitiveField;
      set => this.isCaseSensitiveField = value;
    }

    [XmlIgnore]
    public bool IsCaseSensitiveSpecified
    {
      get => this.isCaseSensitiveFieldSpecified;
      set => this.isCaseSensitiveFieldSpecified = value;
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
    public bool? IsComponent
    {
      get => this.isComponentField;
      set => this.isComponentField = value;
    }

    [XmlIgnore]
    public bool IsComponentSpecified
    {
      get => this.isComponentFieldSpecified;
      set => this.isComponentFieldSpecified = value;
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
    public bool? IsCreatable
    {
      get => this.isCreatableField;
      set => this.isCreatableField = value;
    }

    [XmlIgnore]
    public bool IsCreatableSpecified
    {
      get => this.isCreatableFieldSpecified;
      set => this.isCreatableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDefaultedOnCreate
    {
      get => this.isDefaultedOnCreateField;
      set => this.isDefaultedOnCreateField = value;
    }

    [XmlIgnore]
    public bool IsDefaultedOnCreateSpecified
    {
      get => this.isDefaultedOnCreateFieldSpecified;
      set => this.isDefaultedOnCreateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDependentPicklist
    {
      get => this.isDependentPicklistField;
      set => this.isDependentPicklistField = value;
    }

    [XmlIgnore]
    public bool IsDependentPicklistSpecified
    {
      get => this.isDependentPicklistFieldSpecified;
      set => this.isDependentPicklistFieldSpecified = value;
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
    public bool? IsDisplayLocationInDecimal
    {
      get => this.isDisplayLocationInDecimalField;
      set => this.isDisplayLocationInDecimalField = value;
    }

    [XmlIgnore]
    public bool IsDisplayLocationInDecimalSpecified
    {
      get => this.isDisplayLocationInDecimalFieldSpecified;
      set => this.isDisplayLocationInDecimalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsEncrypted
    {
      get => this.isEncryptedField;
      set => this.isEncryptedField = value;
    }

    [XmlIgnore]
    public bool IsEncryptedSpecified
    {
      get => this.isEncryptedFieldSpecified;
      set => this.isEncryptedFieldSpecified = value;
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
    public bool? IsIdLookup
    {
      get => this.isIdLookupField;
      set => this.isIdLookupField = value;
    }

    [XmlIgnore]
    public bool IsIdLookupSpecified
    {
      get => this.isIdLookupFieldSpecified;
      set => this.isIdLookupFieldSpecified = value;
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
    public bool? IsNamePointing
    {
      get => this.isNamePointingField;
      set => this.isNamePointingField = value;
    }

    [XmlIgnore]
    public bool IsNamePointingSpecified
    {
      get => this.isNamePointingFieldSpecified;
      set => this.isNamePointingFieldSpecified = value;
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
    public bool? IsPermissionable
    {
      get => this.isPermissionableField;
      set => this.isPermissionableField = value;
    }

    [XmlIgnore]
    public bool IsPermissionableSpecified
    {
      get => this.isPermissionableFieldSpecified;
      set => this.isPermissionableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsUnique
    {
      get => this.isUniqueField;
      set => this.isUniqueField = value;
    }

    [XmlIgnore]
    public bool IsUniqueSpecified
    {
      get => this.isUniqueFieldSpecified;
      set => this.isUniqueFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsUpdatable
    {
      get => this.isUpdatableField;
      set => this.isUpdatableField = value;
    }

    [XmlIgnore]
    public bool IsUpdatableSpecified
    {
      get => this.isUpdatableFieldSpecified;
      set => this.isUpdatableFieldSpecified = value;
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
    public bool? IsWriteRequiresMasterRead
    {
      get => this.isWriteRequiresMasterReadField;
      set => this.isWriteRequiresMasterReadField = value;
    }

    [XmlIgnore]
    public bool IsWriteRequiresMasterReadSpecified
    {
      get => this.isWriteRequiresMasterReadFieldSpecified;
      set => this.isWriteRequiresMasterReadFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Label
    {
      get => this.labelField;
      set => this.labelField = value;
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
    public string Mask
    {
      get => this.maskField;
      set => this.maskField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MaskType
    {
      get => this.maskTypeField;
      set => this.maskTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MasterLabel
    {
      get => this.masterLabelField;
      set => this.masterLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult PicklistValues
    {
      get => this.picklistValuesField;
      set => this.picklistValuesField = value;
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
    public string RelationshipName
    {
      get => this.relationshipNameField;
      set => this.relationshipNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RelationshipOrder
    {
      get => this.relationshipOrderField;
      set => this.relationshipOrderField = value;
    }

    [XmlIgnore]
    public bool RelationshipOrderSpecified
    {
      get => this.relationshipOrderFieldSpecified;
      set => this.relationshipOrderFieldSpecified = value;
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
