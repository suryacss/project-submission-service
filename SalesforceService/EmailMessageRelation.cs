// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EmailMessageRelation
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class EmailMessageRelation : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private EmailMessage emailMessageField;
    private string emailMessageIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private Name relationField;
    private string relationAddressField;
    private string relationIdField;
    private string relationObjectTypeField;
    private string relationTypeField;
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
    public EmailMessage EmailMessage
    {
      get => this.emailMessageField;
      set => this.emailMessageField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EmailMessageId
    {
      get => this.emailMessageIdField;
      set => this.emailMessageIdField = value;
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
    public Name Relation
    {
      get => this.relationField;
      set => this.relationField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationAddress
    {
      get => this.relationAddressField;
      set => this.relationAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationId
    {
      get => this.relationIdField;
      set => this.relationIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationObjectType
    {
      get => this.relationObjectTypeField;
      set => this.relationObjectTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationType
    {
      get => this.relationTypeField;
      set => this.relationTypeField = value;
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
