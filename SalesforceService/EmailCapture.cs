// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EmailCapture
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class EmailCapture : sObject
  {
    private DateTime? captureDateField;
    private bool captureDateFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string fromPatternField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private byte[] rawMessageField;
    private int? rawMessageLengthField;
    private bool rawMessageLengthFieldSpecified;
    private string recipientField;
    private string senderField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string toPatternField;

    [XmlElement(IsNullable = true)]
    public DateTime? CaptureDate
    {
      get => this.captureDateField;
      set => this.captureDateField = value;
    }

    [XmlIgnore]
    public bool CaptureDateSpecified
    {
      get => this.captureDateFieldSpecified;
      set => this.captureDateFieldSpecified = value;
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
    public string FromPattern
    {
      get => this.fromPatternField;
      set => this.fromPatternField = value;
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

    [XmlElement(DataType = "base64Binary", IsNullable = true)]
    public byte[] RawMessage
    {
      get => this.rawMessageField;
      set => this.rawMessageField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RawMessageLength
    {
      get => this.rawMessageLengthField;
      set => this.rawMessageLengthField = value;
    }

    [XmlIgnore]
    public bool RawMessageLengthSpecified
    {
      get => this.rawMessageLengthFieldSpecified;
      set => this.rawMessageLengthFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Recipient
    {
      get => this.recipientField;
      set => this.recipientField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Sender
    {
      get => this.senderField;
      set => this.senderField = value;
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
    public string ToPattern
    {
      get => this.toPatternField;
      set => this.toPatternField = value;
    }
  }
}
