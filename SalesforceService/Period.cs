// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Period
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class Period : sObject
  {
    private DateTime? endDateField;
    private bool endDateFieldSpecified;
    private FiscalYearSettings fiscalYearSettingsField;
    private string fiscalYearSettingsIdField;
    private string fullyQualifiedLabelField;
    private bool? isForecastPeriodField;
    private bool isForecastPeriodFieldSpecified;
    private int? numberField;
    private bool numberFieldSpecified;
    private string periodLabelField;
    private string quarterLabelField;
    private DateTime? startDateField;
    private bool startDateFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string typeField;

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? EndDate
    {
      get => this.endDateField;
      set => this.endDateField = value;
    }

    [XmlIgnore]
    public bool EndDateSpecified
    {
      get => this.endDateFieldSpecified;
      set => this.endDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public FiscalYearSettings FiscalYearSettings
    {
      get => this.fiscalYearSettingsField;
      set => this.fiscalYearSettingsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FiscalYearSettingsId
    {
      get => this.fiscalYearSettingsIdField;
      set => this.fiscalYearSettingsIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FullyQualifiedLabel
    {
      get => this.fullyQualifiedLabelField;
      set => this.fullyQualifiedLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsForecastPeriod
    {
      get => this.isForecastPeriodField;
      set => this.isForecastPeriodField = value;
    }

    [XmlIgnore]
    public bool IsForecastPeriodSpecified
    {
      get => this.isForecastPeriodFieldSpecified;
      set => this.isForecastPeriodFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Number
    {
      get => this.numberField;
      set => this.numberField = value;
    }

    [XmlIgnore]
    public bool NumberSpecified
    {
      get => this.numberFieldSpecified;
      set => this.numberFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PeriodLabel
    {
      get => this.periodLabelField;
      set => this.periodLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string QuarterLabel
    {
      get => this.quarterLabelField;
      set => this.quarterLabelField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? StartDate
    {
      get => this.startDateField;
      set => this.startDateField = value;
    }

    [XmlIgnore]
    public bool StartDateSpecified
    {
      get => this.startDateFieldSpecified;
      set => this.startDateFieldSpecified = value;
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
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }
  }
}
