// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.CampaignMemberStatus
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
  public class CampaignMemberStatus : sObject
  {
    private string campaignIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private bool? hasRespondedField;
    private bool hasRespondedFieldSpecified;
    private bool? isDefaultField;
    private bool isDefaultFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string labelField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private int? sortOrderField;
    private bool sortOrderFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string CampaignId
    {
      get => this.campaignIdField;
      set => this.campaignIdField = value;
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
    public bool? HasResponded
    {
      get => this.hasRespondedField;
      set => this.hasRespondedField = value;
    }

    [XmlIgnore]
    public bool HasRespondedSpecified
    {
      get => this.hasRespondedFieldSpecified;
      set => this.hasRespondedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDefault
    {
      get => this.isDefaultField;
      set => this.isDefaultField = value;
    }

    [XmlIgnore]
    public bool IsDefaultSpecified
    {
      get => this.isDefaultFieldSpecified;
      set => this.isDefaultFieldSpecified = value;
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
