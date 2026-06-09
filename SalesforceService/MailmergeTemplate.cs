// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.MailmergeTemplate
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
  public class MailmergeTemplate : sObject
  {
    private byte[] bodyField;
    private int? bodyLengthField;
    private bool bodyLengthFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private string filenameField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastUsedDateField;
    private bool lastUsedDateFieldSpecified;
    private string nameField;
    private bool? securityOptionsAttachmentHasFlashField;
    private bool securityOptionsAttachmentHasFlashFieldSpecified;
    private bool? securityOptionsAttachmentHasXSSThreatField;
    private bool securityOptionsAttachmentHasXSSThreatFieldSpecified;
    private bool? securityOptionsAttachmentScannedForXSSField;
    private bool securityOptionsAttachmentScannedForXSSFieldSpecified;
    private bool? securityOptionsAttachmentScannedforFlashField;
    private bool securityOptionsAttachmentScannedforFlashFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(DataType = "base64Binary", IsNullable = true)]
    public byte[] Body
    {
      get => this.bodyField;
      set => this.bodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? BodyLength
    {
      get => this.bodyLengthField;
      set => this.bodyLengthField = value;
    }

    [XmlIgnore]
    public bool BodyLengthSpecified
    {
      get => this.bodyLengthFieldSpecified;
      set => this.bodyLengthFieldSpecified = value;
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
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
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
    public DateTime? LastUsedDate
    {
      get => this.lastUsedDateField;
      set => this.lastUsedDateField = value;
    }

    [XmlIgnore]
    public bool LastUsedDateSpecified
    {
      get => this.lastUsedDateFieldSpecified;
      set => this.lastUsedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? SecurityOptionsAttachmentHasFlash
    {
      get => this.securityOptionsAttachmentHasFlashField;
      set => this.securityOptionsAttachmentHasFlashField = value;
    }

    [XmlIgnore]
    public bool SecurityOptionsAttachmentHasFlashSpecified
    {
      get => this.securityOptionsAttachmentHasFlashFieldSpecified;
      set => this.securityOptionsAttachmentHasFlashFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? SecurityOptionsAttachmentHasXSSThreat
    {
      get => this.securityOptionsAttachmentHasXSSThreatField;
      set => this.securityOptionsAttachmentHasXSSThreatField = value;
    }

    [XmlIgnore]
    public bool SecurityOptionsAttachmentHasXSSThreatSpecified
    {
      get => this.securityOptionsAttachmentHasXSSThreatFieldSpecified;
      set => this.securityOptionsAttachmentHasXSSThreatFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? SecurityOptionsAttachmentScannedForXSS
    {
      get => this.securityOptionsAttachmentScannedForXSSField;
      set => this.securityOptionsAttachmentScannedForXSSField = value;
    }

    [XmlIgnore]
    public bool SecurityOptionsAttachmentScannedForXSSSpecified
    {
      get => this.securityOptionsAttachmentScannedForXSSFieldSpecified;
      set => this.securityOptionsAttachmentScannedForXSSFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? SecurityOptionsAttachmentScannedforFlash
    {
      get => this.securityOptionsAttachmentScannedforFlashField;
      set => this.securityOptionsAttachmentScannedforFlashField = value;
    }

    [XmlIgnore]
    public bool SecurityOptionsAttachmentScannedforFlashSpecified
    {
      get => this.securityOptionsAttachmentScannedforFlashFieldSpecified;
      set => this.securityOptionsAttachmentScannedforFlashFieldSpecified = value;
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
