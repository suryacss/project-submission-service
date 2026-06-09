// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserProvisioningRequest
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class UserProvisioningRequest : sObject
  {
    private string appNameField;
    private string approvalStatusField;
    private ConnectedApplication connectedAppField;
    private string connectedAppIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string externalUserIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private User managerField;
    private string managerIdField;
    private string nameField;
    private string operationField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private UserProvisioningRequest parentField;
    private string parentIdField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private int? retryCountField;
    private bool retryCountFieldSpecified;
    private User salesforceUserField;
    private string salesforceUserIdField;
    private DateTime? scheduleDateField;
    private bool scheduleDateFieldSpecified;
    private string stateField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private UserProvAccount userProvAccountField;
    private string userProvAccountIdField;
    private UserProvisioningConfig userProvConfigField;
    private string userProvConfigIdField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public string AppName
    {
      get => this.appNameField;
      set => this.appNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApprovalStatus
    {
      get => this.approvalStatusField;
      set => this.approvalStatusField = value;
    }

    [XmlElement(IsNullable = true)]
    public ConnectedApplication ConnectedApp
    {
      get => this.connectedAppField;
      set => this.connectedAppField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConnectedAppId
    {
      get => this.connectedAppIdField;
      set => this.connectedAppIdField = value;
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
    public string ExternalUserId
    {
      get => this.externalUserIdField;
      set => this.externalUserIdField = value;
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
    public User Manager
    {
      get => this.managerField;
      set => this.managerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ManagerId
    {
      get => this.managerIdField;
      set => this.managerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Operation
    {
      get => this.operationField;
      set => this.operationField = value;
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
    public UserProvisioningRequest Parent
    {
      get => this.parentField;
      set => this.parentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentId
    {
      get => this.parentIdField;
      set => this.parentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessInstances
    {
      get => this.processInstancesField;
      set => this.processInstancesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessSteps
    {
      get => this.processStepsField;
      set => this.processStepsField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RetryCount
    {
      get => this.retryCountField;
      set => this.retryCountField = value;
    }

    [XmlIgnore]
    public bool RetryCountSpecified
    {
      get => this.retryCountFieldSpecified;
      set => this.retryCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User SalesforceUser
    {
      get => this.salesforceUserField;
      set => this.salesforceUserField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SalesforceUserId
    {
      get => this.salesforceUserIdField;
      set => this.salesforceUserIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ScheduleDate
    {
      get => this.scheduleDateField;
      set => this.scheduleDateField = value;
    }

    [XmlIgnore]
    public bool ScheduleDateSpecified
    {
      get => this.scheduleDateFieldSpecified;
      set => this.scheduleDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string State
    {
      get => this.stateField;
      set => this.stateField = value;
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
    public UserProvAccount UserProvAccount
    {
      get => this.userProvAccountField;
      set => this.userProvAccountField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserProvAccountId
    {
      get => this.userProvAccountIdField;
      set => this.userProvAccountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserProvisioningConfig UserProvConfig
    {
      get => this.userProvConfigField;
      set => this.userProvConfigField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserProvConfigId
    {
      get => this.userProvConfigIdField;
      set => this.userProvConfigIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
