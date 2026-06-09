// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Group
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class Group : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult delegatedUsersField;
    private string developerNameField;
    private bool? doesIncludeBossesField;
    private bool doesIncludeBossesFieldSpecified;
    private bool? doesSendEmailToMembersField;
    private bool doesSendEmailToMembersFieldSpecified;
    private string emailField;
    private QueryResult groupMembersField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string nameField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private QueryResult queueSobjectsField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name relatedField;
    private string relatedIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string typeField;

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
    public QueryResult DelegatedUsers
    {
      get => this.delegatedUsersField;
      set => this.delegatedUsersField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? DoesIncludeBosses
    {
      get => this.doesIncludeBossesField;
      set => this.doesIncludeBossesField = value;
    }

    [XmlIgnore]
    public bool DoesIncludeBossesSpecified
    {
      get => this.doesIncludeBossesFieldSpecified;
      set => this.doesIncludeBossesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? DoesSendEmailToMembers
    {
      get => this.doesSendEmailToMembersField;
      set => this.doesSendEmailToMembersField = value;
    }

    [XmlIgnore]
    public bool DoesSendEmailToMembersSpecified
    {
      get => this.doesSendEmailToMembersFieldSpecified;
      set => this.doesSendEmailToMembersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Email
    {
      get => this.emailField;
      set => this.emailField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult GroupMembers
    {
      get => this.groupMembersField;
      set => this.groupMembersField = value;
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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name Owner
    {
      get => this.ownerField;
      set => this.ownerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OwnerId
    {
      get => this.ownerIdField;
      set => this.ownerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult QueueSobjects
    {
      get => this.queueSobjectsField;
      set => this.queueSobjectsField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name Related
    {
      get => this.relatedField;
      set => this.relatedField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelatedId
    {
      get => this.relatedIdField;
      set => this.relatedIdField = value;
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
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }
  }
}
