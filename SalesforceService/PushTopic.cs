// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PushTopic
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
  public class PushTopic : sObject
  {
    private double? apiVersionField;
    private bool apiVersionFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string nameField;
    private string notifyForFieldsField;
    private bool? notifyForOperationCreateField;
    private bool notifyForOperationCreateFieldSpecified;
    private bool? notifyForOperationDeleteField;
    private bool notifyForOperationDeleteFieldSpecified;
    private bool? notifyForOperationUndeleteField;
    private bool notifyForOperationUndeleteFieldSpecified;
    private bool? notifyForOperationUpdateField;
    private bool notifyForOperationUpdateFieldSpecified;
    private string notifyForOperationsField;
    private string queryField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public double? ApiVersion
    {
      get => this.apiVersionField;
      set => this.apiVersionField = value;
    }

    [XmlIgnore]
    public bool ApiVersionSpecified
    {
      get => this.apiVersionFieldSpecified;
      set => this.apiVersionFieldSpecified = value;
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

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NotifyForFields
    {
      get => this.notifyForFieldsField;
      set => this.notifyForFieldsField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? NotifyForOperationCreate
    {
      get => this.notifyForOperationCreateField;
      set => this.notifyForOperationCreateField = value;
    }

    [XmlIgnore]
    public bool NotifyForOperationCreateSpecified
    {
      get => this.notifyForOperationCreateFieldSpecified;
      set => this.notifyForOperationCreateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? NotifyForOperationDelete
    {
      get => this.notifyForOperationDeleteField;
      set => this.notifyForOperationDeleteField = value;
    }

    [XmlIgnore]
    public bool NotifyForOperationDeleteSpecified
    {
      get => this.notifyForOperationDeleteFieldSpecified;
      set => this.notifyForOperationDeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? NotifyForOperationUndelete
    {
      get => this.notifyForOperationUndeleteField;
      set => this.notifyForOperationUndeleteField = value;
    }

    [XmlIgnore]
    public bool NotifyForOperationUndeleteSpecified
    {
      get => this.notifyForOperationUndeleteFieldSpecified;
      set => this.notifyForOperationUndeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? NotifyForOperationUpdate
    {
      get => this.notifyForOperationUpdateField;
      set => this.notifyForOperationUpdateField = value;
    }

    [XmlIgnore]
    public bool NotifyForOperationUpdateSpecified
    {
      get => this.notifyForOperationUpdateFieldSpecified;
      set => this.notifyForOperationUpdateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string NotifyForOperations
    {
      get => this.notifyForOperationsField;
      set => this.notifyForOperationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Query
    {
      get => this.queryField;
      set => this.queryField = value;
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
