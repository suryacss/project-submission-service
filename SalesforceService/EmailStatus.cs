// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EmailStatus
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class EmailStatus : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string emailTemplateNameField;
    private DateTime? firstOpenDateField;
    private bool firstOpenDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastOpenDateField;
    private bool lastOpenDateFieldSpecified;
    private Task taskField;
    private string taskIdField;
    private int? timesOpenedField;
    private bool timesOpenedFieldSpecified;
    private Name whoField;
    private string whoIdField;

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
    public string EmailTemplateName
    {
      get => this.emailTemplateNameField;
      set => this.emailTemplateNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? FirstOpenDate
    {
      get => this.firstOpenDateField;
      set => this.firstOpenDateField = value;
    }

    [XmlIgnore]
    public bool FirstOpenDateSpecified
    {
      get => this.firstOpenDateFieldSpecified;
      set => this.firstOpenDateFieldSpecified = value;
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
    public DateTime? LastOpenDate
    {
      get => this.lastOpenDateField;
      set => this.lastOpenDateField = value;
    }

    [XmlIgnore]
    public bool LastOpenDateSpecified
    {
      get => this.lastOpenDateFieldSpecified;
      set => this.lastOpenDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public Task Task
    {
      get => this.taskField;
      set => this.taskField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TaskId
    {
      get => this.taskIdField;
      set => this.taskIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? TimesOpened
    {
      get => this.timesOpenedField;
      set => this.timesOpenedField = value;
    }

    [XmlIgnore]
    public bool TimesOpenedSpecified
    {
      get => this.timesOpenedFieldSpecified;
      set => this.timesOpenedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public Name Who
    {
      get => this.whoField;
      set => this.whoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string WhoId
    {
      get => this.whoIdField;
      set => this.whoIdField = value;
    }
  }
}
