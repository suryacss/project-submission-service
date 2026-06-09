// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OwnerChangeOptionInfo
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class OwnerChangeOptionInfo : sObject
  {
    private bool? defaultValueField;
    private bool defaultValueFieldSpecified;
    private string durableIdField;
    private EntityDefinition entityDefinitionField;
    private string entityDefinitionIdField;
    private bool? isEditableField;
    private bool isEditableFieldSpecified;
    private string labelField;
    private string nameField;

    [XmlElement(IsNullable = true)]
    public bool? DefaultValue
    {
      get => this.defaultValueField;
      set => this.defaultValueField = value;
    }

    [XmlIgnore]
    public bool DefaultValueSpecified
    {
      get => this.defaultValueFieldSpecified;
      set => this.defaultValueFieldSpecified = value;
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
    public bool? IsEditable
    {
      get => this.isEditableField;
      set => this.isEditableField = value;
    }

    [XmlIgnore]
    public bool IsEditableSpecified
    {
      get => this.isEditableFieldSpecified;
      set => this.isEditableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }
  }
}
