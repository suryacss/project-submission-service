// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Field
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class Field
  {
    private bool aggregatableField;
    private bool autoNumberField;
    private int byteLengthField;
    private bool calculatedField;
    private string calculatedFormulaField;
    private bool cascadeDeleteField;
    private bool cascadeDeleteFieldSpecified;
    private bool caseSensitiveField;
    private string compoundFieldNameField;
    private string controllerNameField;
    private bool createableField;
    private bool customField;
    private object defaultValueField;
    private string defaultValueFormulaField;
    private bool defaultedOnCreateField;
    private bool dependentPicklistField;
    private bool dependentPicklistFieldSpecified;
    private bool deprecatedAndHiddenField;
    private int digitsField;
    private bool displayLocationInDecimalField;
    private bool displayLocationInDecimalFieldSpecified;
    private bool encryptedField;
    private bool encryptedFieldSpecified;
    private bool externalIdField;
    private bool externalIdFieldSpecified;
    private string extraTypeInfoField;
    private bool filterableField;
    private FilteredLookupInfo filteredLookupInfoField;
    private bool groupableField;
    private bool highScaleNumberField;
    private bool highScaleNumberFieldSpecified;
    private bool htmlFormattedField;
    private bool htmlFormattedFieldSpecified;
    private bool idLookupField;
    private string inlineHelpTextField;
    private string labelField;
    private int lengthField;
    private string maskField;
    private string maskTypeField;
    private string nameField1;
    private bool nameFieldField;
    private bool namePointingField;
    private bool namePointingFieldSpecified;
    private bool nillableField;
    private bool permissionableField;
    private PicklistEntry[] picklistValuesField;
    private int precisionField;
    private bool queryByDistanceField;
    private string referenceTargetFieldField;
    private string[] referenceToField;
    private string relationshipNameField;
    private int relationshipOrderField;
    private bool relationshipOrderFieldSpecified;
    private bool restrictedDeleteField;
    private bool restrictedDeleteFieldSpecified;
    private bool restrictedPicklistField;
    private int scaleField;
    private soapType soapTypeField;
    private bool sortableField;
    private bool sortableFieldSpecified;
    private fieldType typeField;
    private bool uniqueField;
    private bool updateableField;
    private bool writeRequiresMasterReadField;
    private bool writeRequiresMasterReadFieldSpecified;

    public bool aggregatable
    {
      get => this.aggregatableField;
      set => this.aggregatableField = value;
    }

    public bool autoNumber
    {
      get => this.autoNumberField;
      set => this.autoNumberField = value;
    }

    public int byteLength
    {
      get => this.byteLengthField;
      set => this.byteLengthField = value;
    }

    public bool calculated
    {
      get => this.calculatedField;
      set => this.calculatedField = value;
    }

    public string calculatedFormula
    {
      get => this.calculatedFormulaField;
      set => this.calculatedFormulaField = value;
    }

    public bool cascadeDelete
    {
      get => this.cascadeDeleteField;
      set => this.cascadeDeleteField = value;
    }

    [XmlIgnore]
    public bool cascadeDeleteSpecified
    {
      get => this.cascadeDeleteFieldSpecified;
      set => this.cascadeDeleteFieldSpecified = value;
    }

    public bool caseSensitive
    {
      get => this.caseSensitiveField;
      set => this.caseSensitiveField = value;
    }

    public string compoundFieldName
    {
      get => this.compoundFieldNameField;
      set => this.compoundFieldNameField = value;
    }

    public string controllerName
    {
      get => this.controllerNameField;
      set => this.controllerNameField = value;
    }

    public bool createable
    {
      get => this.createableField;
      set => this.createableField = value;
    }

    public bool custom
    {
      get => this.customField;
      set => this.customField = value;
    }

    public object defaultValue
    {
      get => this.defaultValueField;
      set => this.defaultValueField = value;
    }

    public string defaultValueFormula
    {
      get => this.defaultValueFormulaField;
      set => this.defaultValueFormulaField = value;
    }

    public bool defaultedOnCreate
    {
      get => this.defaultedOnCreateField;
      set => this.defaultedOnCreateField = value;
    }

    public bool dependentPicklist
    {
      get => this.dependentPicklistField;
      set => this.dependentPicklistField = value;
    }

    [XmlIgnore]
    public bool dependentPicklistSpecified
    {
      get => this.dependentPicklistFieldSpecified;
      set => this.dependentPicklistFieldSpecified = value;
    }

    public bool deprecatedAndHidden
    {
      get => this.deprecatedAndHiddenField;
      set => this.deprecatedAndHiddenField = value;
    }

    public int digits
    {
      get => this.digitsField;
      set => this.digitsField = value;
    }

    public bool displayLocationInDecimal
    {
      get => this.displayLocationInDecimalField;
      set => this.displayLocationInDecimalField = value;
    }

    [XmlIgnore]
    public bool displayLocationInDecimalSpecified
    {
      get => this.displayLocationInDecimalFieldSpecified;
      set => this.displayLocationInDecimalFieldSpecified = value;
    }

    public bool encrypted
    {
      get => this.encryptedField;
      set => this.encryptedField = value;
    }

    [XmlIgnore]
    public bool encryptedSpecified
    {
      get => this.encryptedFieldSpecified;
      set => this.encryptedFieldSpecified = value;
    }

    public bool externalId
    {
      get => this.externalIdField;
      set => this.externalIdField = value;
    }

    [XmlIgnore]
    public bool externalIdSpecified
    {
      get => this.externalIdFieldSpecified;
      set => this.externalIdFieldSpecified = value;
    }

    public string extraTypeInfo
    {
      get => this.extraTypeInfoField;
      set => this.extraTypeInfoField = value;
    }

    public bool filterable
    {
      get => this.filterableField;
      set => this.filterableField = value;
    }

    [XmlElement(IsNullable = true)]
    public FilteredLookupInfo filteredLookupInfo
    {
      get => this.filteredLookupInfoField;
      set => this.filteredLookupInfoField = value;
    }

    public bool groupable
    {
      get => this.groupableField;
      set => this.groupableField = value;
    }

    public bool highScaleNumber
    {
      get => this.highScaleNumberField;
      set => this.highScaleNumberField = value;
    }

    [XmlIgnore]
    public bool highScaleNumberSpecified
    {
      get => this.highScaleNumberFieldSpecified;
      set => this.highScaleNumberFieldSpecified = value;
    }

    public bool htmlFormatted
    {
      get => this.htmlFormattedField;
      set => this.htmlFormattedField = value;
    }

    [XmlIgnore]
    public bool htmlFormattedSpecified
    {
      get => this.htmlFormattedFieldSpecified;
      set => this.htmlFormattedFieldSpecified = value;
    }

    public bool idLookup
    {
      get => this.idLookupField;
      set => this.idLookupField = value;
    }

    public string inlineHelpText
    {
      get => this.inlineHelpTextField;
      set => this.inlineHelpTextField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public int length
    {
      get => this.lengthField;
      set => this.lengthField = value;
    }

    public string mask
    {
      get => this.maskField;
      set => this.maskField = value;
    }

    public string maskType
    {
      get => this.maskTypeField;
      set => this.maskTypeField = value;
    }

    public string name
    {
      get => this.nameField1;
      set => this.nameField1 = value;
    }

    public bool nameField
    {
      get => this.nameFieldField;
      set => this.nameFieldField = value;
    }

    public bool namePointing
    {
      get => this.namePointingField;
      set => this.namePointingField = value;
    }

    [XmlIgnore]
    public bool namePointingSpecified
    {
      get => this.namePointingFieldSpecified;
      set => this.namePointingFieldSpecified = value;
    }

    public bool nillable
    {
      get => this.nillableField;
      set => this.nillableField = value;
    }

    public bool permissionable
    {
      get => this.permissionableField;
      set => this.permissionableField = value;
    }

    [XmlElement("picklistValues", IsNullable = true)]
    public PicklistEntry[] picklistValues
    {
      get => this.picklistValuesField;
      set => this.picklistValuesField = value;
    }

    public int precision
    {
      get => this.precisionField;
      set => this.precisionField = value;
    }

    public bool queryByDistance
    {
      get => this.queryByDistanceField;
      set => this.queryByDistanceField = value;
    }

    public string referenceTargetField
    {
      get => this.referenceTargetFieldField;
      set => this.referenceTargetFieldField = value;
    }

    [XmlElement("referenceTo", IsNullable = true)]
    public string[] referenceTo
    {
      get => this.referenceToField;
      set => this.referenceToField = value;
    }

    public string relationshipName
    {
      get => this.relationshipNameField;
      set => this.relationshipNameField = value;
    }

    public int relationshipOrder
    {
      get => this.relationshipOrderField;
      set => this.relationshipOrderField = value;
    }

    [XmlIgnore]
    public bool relationshipOrderSpecified
    {
      get => this.relationshipOrderFieldSpecified;
      set => this.relationshipOrderFieldSpecified = value;
    }

    public bool restrictedDelete
    {
      get => this.restrictedDeleteField;
      set => this.restrictedDeleteField = value;
    }

    [XmlIgnore]
    public bool restrictedDeleteSpecified
    {
      get => this.restrictedDeleteFieldSpecified;
      set => this.restrictedDeleteFieldSpecified = value;
    }

    public bool restrictedPicklist
    {
      get => this.restrictedPicklistField;
      set => this.restrictedPicklistField = value;
    }

    public int scale
    {
      get => this.scaleField;
      set => this.scaleField = value;
    }

    public soapType soapType
    {
      get => this.soapTypeField;
      set => this.soapTypeField = value;
    }

    public bool sortable
    {
      get => this.sortableField;
      set => this.sortableField = value;
    }

    [XmlIgnore]
    public bool sortableSpecified
    {
      get => this.sortableFieldSpecified;
      set => this.sortableFieldSpecified = value;
    }

    public fieldType type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public bool unique
    {
      get => this.uniqueField;
      set => this.uniqueField = value;
    }

    public bool updateable
    {
      get => this.updateableField;
      set => this.updateableField = value;
    }

    public bool writeRequiresMasterRead
    {
      get => this.writeRequiresMasterReadField;
      set => this.writeRequiresMasterReadField = value;
    }

    [XmlIgnore]
    public bool writeRequiresMasterReadSpecified
    {
      get => this.writeRequiresMasterReadFieldSpecified;
      set => this.writeRequiresMasterReadFieldSpecified = value;
    }
  }
}
