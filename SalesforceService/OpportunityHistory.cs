// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OpportunityHistory
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class OpportunityHistory : sObject
  {
    private double? amountField;
    private bool amountFieldSpecified;
    private DateTime? closeDateField;
    private bool closeDateFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private double? expectedRevenueField;
    private bool expectedRevenueFieldSpecified;
    private string forecastCategoryField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private Opportunity opportunityField;
    private string opportunityIdField;
    private double? probabilityField;
    private bool probabilityFieldSpecified;
    private string stageNameField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public double? Amount
    {
      get => this.amountField;
      set => this.amountField = value;
    }

    [XmlIgnore]
    public bool AmountSpecified
    {
      get => this.amountFieldSpecified;
      set => this.amountFieldSpecified = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? CloseDate
    {
      get => this.closeDateField;
      set => this.closeDateField = value;
    }

    [XmlIgnore]
    public bool CloseDateSpecified
    {
      get => this.closeDateFieldSpecified;
      set => this.closeDateFieldSpecified = value;
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
    public double? ExpectedRevenue
    {
      get => this.expectedRevenueField;
      set => this.expectedRevenueField = value;
    }

    [XmlIgnore]
    public bool ExpectedRevenueSpecified
    {
      get => this.expectedRevenueFieldSpecified;
      set => this.expectedRevenueFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ForecastCategory
    {
      get => this.forecastCategoryField;
      set => this.forecastCategoryField = value;
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

    [XmlElement(IsNullable = true)]
    public Opportunity Opportunity
    {
      get => this.opportunityField;
      set => this.opportunityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OpportunityId
    {
      get => this.opportunityIdField;
      set => this.opportunityIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Probability
    {
      get => this.probabilityField;
      set => this.probabilityField = value;
    }

    [XmlIgnore]
    public bool ProbabilitySpecified
    {
      get => this.probabilityFieldSpecified;
      set => this.probabilityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string StageName
    {
      get => this.stageNameField;
      set => this.stageNameField = value;
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
  }
}
