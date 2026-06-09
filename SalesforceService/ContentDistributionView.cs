// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ContentDistributionView
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
  public class ContentDistributionView : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private ContentDistribution distributionField;
    private string distributionIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isDownloadField;
    private bool isDownloadFieldSpecified;
    private bool? isInternalField;
    private bool isInternalFieldSpecified;
    private string parentViewIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

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
    public ContentDistribution Distribution
    {
      get => this.distributionField;
      set => this.distributionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DistributionId
    {
      get => this.distributionIdField;
      set => this.distributionIdField = value;
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
    public bool? IsDownload
    {
      get => this.isDownloadField;
      set => this.isDownloadField = value;
    }

    [XmlIgnore]
    public bool IsDownloadSpecified
    {
      get => this.isDownloadFieldSpecified;
      set => this.isDownloadFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsInternal
    {
      get => this.isInternalField;
      set => this.isInternalField = value;
    }

    [XmlIgnore]
    public bool IsInternalSpecified
    {
      get => this.isInternalFieldSpecified;
      set => this.isInternalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentViewId
    {
      get => this.parentViewIdField;
      set => this.parentViewIdField = value;
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
