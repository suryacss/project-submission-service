// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SearchLayout
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
  public class SearchLayout : sObject
  {
    private SearchLayoutButtonsDisplayed buttonsDisplayedField;
    private string durableIdField;
    private EntityDefinition entityDefinitionField;
    private string entityDefinitionIdField;
    private SearchLayoutFieldsDisplayed fieldsDisplayedField;
    private string labelField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string layoutTypeField;

    [XmlElement(IsNullable = true)]
    public SearchLayoutButtonsDisplayed ButtonsDisplayed
    {
      get => this.buttonsDisplayedField;
      set => this.buttonsDisplayedField = value;
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
    public SearchLayoutFieldsDisplayed FieldsDisplayed
    {
      get => this.fieldsDisplayedField;
      set => this.fieldsDisplayedField = value;
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
    public string LayoutType
    {
      get => this.layoutTypeField;
      set => this.layoutTypeField = value;
    }
  }
}
