// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OpportunityStage
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
  public class OpportunityStage : sObject
  {
    private string apiNameField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private double? defaultProbabilityField;
    private bool defaultProbabilityFieldSpecified;
    private string descriptionField;
    private string forecastCategoryField;
    private string forecastCategoryNameField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isClosedField;
    private bool isClosedFieldSpecified;
    private bool? isWonField;
    private bool isWonFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string masterLabelField;
    private int? sortOrderField;
    private bool sortOrderFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string ApiName
    {
      get => this.apiNameField;
      set => this.apiNameField = value;
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
    public double? DefaultProbability
    {
      get => this.defaultProbabilityField;
      set => this.defaultProbabilityField = value;
    }

    [XmlIgnore]
    public bool DefaultProbabilitySpecified
    {
      get => this.defaultProbabilityFieldSpecified;
      set => this.defaultProbabilityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ForecastCategory
    {
      get => this.forecastCategoryField;
      set => this.forecastCategoryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ForecastCategoryName
    {
      get => this.forecastCategoryNameField;
      set => this.forecastCategoryNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsActive
    {
      get => this.isActiveField;
      set => this.isActiveField = value;
    }

    [XmlIgnore]
    public bool IsActiveSpecified
    {
      get => this.isActiveFieldSpecified;
      set => this.isActiveFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsClosed
    {
      get => this.isClosedField;
      set => this.isClosedField = value;
    }

    [XmlIgnore]
    public bool IsClosedSpecified
    {
      get => this.isClosedFieldSpecified;
      set => this.isClosedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsWon
    {
      get => this.isWonField;
      set => this.isWonField = value;
    }

    [XmlIgnore]
    public bool IsWonSpecified
    {
      get => this.isWonFieldSpecified;
      set => this.isWonFieldSpecified = value;
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
    public int? SortOrder
    {
      get => this.sortOrderField;
      set => this.sortOrderField = value;
    }

    [XmlIgnore]
    public bool SortOrderSpecified
    {
      get => this.sortOrderFieldSpecified;
      set => this.sortOrderFieldSpecified = value;
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
