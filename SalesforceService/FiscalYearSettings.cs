// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FiscalYearSettings
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class FiscalYearSettings : sObject
  {
    private string descriptionField;
    private DateTime? endDateField;
    private bool endDateFieldSpecified;
    private bool? isStandardYearField;
    private bool isStandardYearFieldSpecified;
    private string nameField;
    private string periodIdField;
    private string periodLabelSchemeField;
    private string periodPrefixField;
    private QueryResult periodsField;
    private string quarterLabelSchemeField;
    private string quarterPrefixField;
    private DateTime? startDateField;
    private bool startDateFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string weekLabelSchemeField;
    private int? weekStartDayField;
    private bool weekStartDayFieldSpecified;
    private string yearTypeField;

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

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
    public bool? IsStandardYear
    {
      get => this.isStandardYearField;
      set => this.isStandardYearField = value;
    }

    [XmlIgnore]
    public bool IsStandardYearSpecified
    {
      get => this.isStandardYearFieldSpecified;
      set => this.isStandardYearFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PeriodId
    {
      get => this.periodIdField;
      set => this.periodIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PeriodLabelScheme
    {
      get => this.periodLabelSchemeField;
      set => this.periodLabelSchemeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PeriodPrefix
    {
      get => this.periodPrefixField;
      set => this.periodPrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Periods
    {
      get => this.periodsField;
      set => this.periodsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string QuarterLabelScheme
    {
      get => this.quarterLabelSchemeField;
      set => this.quarterLabelSchemeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string QuarterPrefix
    {
      get => this.quarterPrefixField;
      set => this.quarterPrefixField = value;
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
    public string WeekLabelScheme
    {
      get => this.weekLabelSchemeField;
      set => this.weekLabelSchemeField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? WeekStartDay
    {
      get => this.weekStartDayField;
      set => this.weekStartDayField = value;
    }

    [XmlIgnore]
    public bool WeekStartDaySpecified
    {
      get => this.weekStartDayFieldSpecified;
      set => this.weekStartDayFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string YearType
    {
      get => this.yearTypeField;
      set => this.yearTypeField = value;
    }
  }
}
