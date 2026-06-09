// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.TopicAssignment
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
  public class TopicAssignment : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private Contract entityField;
    private string entityIdField;
    private string entityKeyPrefixField;
    private string entityTypeField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private Topic topicField;
    private string topicIdField;

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
    public Contract Entity
    {
      get => this.entityField;
      set => this.entityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EntityId
    {
      get => this.entityIdField;
      set => this.entityIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EntityKeyPrefix
    {
      get => this.entityKeyPrefixField;
      set => this.entityKeyPrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EntityType
    {
      get => this.entityTypeField;
      set => this.entityTypeField = value;
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
    public Topic Topic
    {
      get => this.topicField;
      set => this.topicField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TopicId
    {
      get => this.topicIdField;
      set => this.topicIdField = value;
    }
  }
}
