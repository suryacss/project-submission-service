// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PlatformCachePartitionType
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class PlatformCachePartitionType : sObject
  {
    private int? allocatedCapacityField;
    private bool allocatedCapacityFieldSpecified;
    private int? allocatedPurchasedCapacityField;
    private bool allocatedPurchasedCapacityFieldSpecified;
    private int? allocatedTrialCapacityField;
    private bool allocatedTrialCapacityFieldSpecified;
    private string cacheTypeField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private PlatformCachePartition platformCachePartitionField;
    private string platformCachePartitionIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public int? AllocatedCapacity
    {
      get => this.allocatedCapacityField;
      set => this.allocatedCapacityField = value;
    }

    [XmlIgnore]
    public bool AllocatedCapacitySpecified
    {
      get => this.allocatedCapacityFieldSpecified;
      set => this.allocatedCapacityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? AllocatedPurchasedCapacity
    {
      get => this.allocatedPurchasedCapacityField;
      set => this.allocatedPurchasedCapacityField = value;
    }

    [XmlIgnore]
    public bool AllocatedPurchasedCapacitySpecified
    {
      get => this.allocatedPurchasedCapacityFieldSpecified;
      set => this.allocatedPurchasedCapacityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? AllocatedTrialCapacity
    {
      get => this.allocatedTrialCapacityField;
      set => this.allocatedTrialCapacityField = value;
    }

    [XmlIgnore]
    public bool AllocatedTrialCapacitySpecified
    {
      get => this.allocatedTrialCapacityFieldSpecified;
      set => this.allocatedTrialCapacityFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CacheType
    {
      get => this.cacheTypeField;
      set => this.cacheTypeField = value;
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
    public PlatformCachePartition PlatformCachePartition
    {
      get => this.platformCachePartitionField;
      set => this.platformCachePartitionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PlatformCachePartitionId
    {
      get => this.platformCachePartitionIdField;
      set => this.platformCachePartitionIdField = value;
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
