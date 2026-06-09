// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ListViewChartInstance
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
  public class ListViewChartInstance : sObject
  {
    private string aggregateFieldField;
    private string aggregateTypeField;
    private string chartTypeField;
    private string dataQueryField;
    private string developerNameField;
    private string externalIdField;
    private string groupingFieldField;
    private bool? isDeletableField;
    private bool isDeletableFieldSpecified;
    private bool? isEditableField;
    private bool isEditableFieldSpecified;
    private bool? isLastViewedField;
    private bool isLastViewedFieldSpecified;
    private string labelField;
    private ListViewChart listViewChartField;
    private string listViewChartIdField;
    private ListView listViewContextField;
    private string listViewContextIdField;
    private string sourceEntityField;

    [XmlElement(IsNullable = true)]
    public string AggregateField
    {
      get => this.aggregateFieldField;
      set => this.aggregateFieldField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AggregateType
    {
      get => this.aggregateTypeField;
      set => this.aggregateTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ChartType
    {
      get => this.chartTypeField;
      set => this.chartTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DataQuery
    {
      get => this.dataQueryField;
      set => this.dataQueryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalId
    {
      get => this.externalIdField;
      set => this.externalIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GroupingField
    {
      get => this.groupingFieldField;
      set => this.groupingFieldField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeletable
    {
      get => this.isDeletableField;
      set => this.isDeletableField = value;
    }

    [XmlIgnore]
    public bool IsDeletableSpecified
    {
      get => this.isDeletableFieldSpecified;
      set => this.isDeletableFieldSpecified = value;
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
    public bool? IsLastViewed
    {
      get => this.isLastViewedField;
      set => this.isLastViewedField = value;
    }

    [XmlIgnore]
    public bool IsLastViewedSpecified
    {
      get => this.isLastViewedFieldSpecified;
      set => this.isLastViewedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(IsNullable = true)]
    public ListViewChart ListViewChart
    {
      get => this.listViewChartField;
      set => this.listViewChartField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ListViewChartId
    {
      get => this.listViewChartIdField;
      set => this.listViewChartIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ListView ListViewContext
    {
      get => this.listViewContextField;
      set => this.listViewContextField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ListViewContextId
    {
      get => this.listViewContextIdField;
      set => this.listViewContextIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceEntity
    {
      get => this.sourceEntityField;
      set => this.sourceEntityField = value;
    }
  }
}
