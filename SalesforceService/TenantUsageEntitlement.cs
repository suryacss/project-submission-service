// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.TenantUsageEntitlement
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class TenantUsageEntitlement : sObject
  {
    private double? amountUsedField;
    private bool amountUsedFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private double? currentAmountAllowedField;
    private bool currentAmountAllowedFieldSpecified;
    private DateTime? endDateField;
    private bool endDateFieldSpecified;
    private string frequencyField;
    private bool? hasRolloverField;
    private bool hasRolloverFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isPersistentResourceField;
    private bool isPersistentResourceFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string masterLabelField;
    private double? overageGraceField;
    private bool overageGraceFieldSpecified;
    private string resourceGroupKeyField;
    private string settingField;
    private DateTime? startDateField;
    private bool startDateFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private DateTime? usageDateField;
    private bool usageDateFieldSpecified;

    [XmlElement(IsNullable = true)]
    public double? AmountUsed
    {
      get => this.amountUsedField;
      set => this.amountUsedField = value;
    }

    [XmlIgnore]
    public bool AmountUsedSpecified
    {
      get => this.amountUsedFieldSpecified;
      set => this.amountUsedFieldSpecified = value;
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
    public double? CurrentAmountAllowed
    {
      get => this.currentAmountAllowedField;
      set => this.currentAmountAllowedField = value;
    }

    [XmlIgnore]
    public bool CurrentAmountAllowedSpecified
    {
      get => this.currentAmountAllowedFieldSpecified;
      set => this.currentAmountAllowedFieldSpecified = value;
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
    public string Frequency
    {
      get => this.frequencyField;
      set => this.frequencyField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasRollover
    {
      get => this.hasRolloverField;
      set => this.hasRolloverField = value;
    }

    [XmlIgnore]
    public bool HasRolloverSpecified
    {
      get => this.hasRolloverFieldSpecified;
      set => this.hasRolloverFieldSpecified = value;
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
    public bool? IsPersistentResource
    {
      get => this.isPersistentResourceField;
      set => this.isPersistentResourceField = value;
    }

    [XmlIgnore]
    public bool IsPersistentResourceSpecified
    {
      get => this.isPersistentResourceFieldSpecified;
      set => this.isPersistentResourceFieldSpecified = value;
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
    public double? OverageGrace
    {
      get => this.overageGraceField;
      set => this.overageGraceField = value;
    }

    [XmlIgnore]
    public bool OverageGraceSpecified
    {
      get => this.overageGraceFieldSpecified;
      set => this.overageGraceFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ResourceGroupKey
    {
      get => this.resourceGroupKeyField;
      set => this.resourceGroupKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Setting
    {
      get => this.settingField;
      set => this.settingField = value;
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
    public DateTime? UsageDate
    {
      get => this.usageDateField;
      set => this.usageDateField = value;
    }

    [XmlIgnore]
    public bool UsageDateSpecified
    {
      get => this.usageDateFieldSpecified;
      set => this.usageDateFieldSpecified = value;
    }
  }
}
