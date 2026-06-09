// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.BackgroundOperation
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
  public class BackgroundOperation : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string errorField;
    private string executionGroupField;
    private DateTime? expiresAtField;
    private bool expiresAtFieldSpecified;
    private DateTime? finishedAtField;
    private bool finishedAtFieldSpecified;
    private BackgroundOperation groupLeaderField;
    private string groupLeaderIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private QueryResult mergedOperationsField;
    private string nameField;
    private int? numFollowersField;
    private bool numFollowersFieldSpecified;
    private string parentKeyField;
    private DateTime? processAfterField;
    private bool processAfterFieldSpecified;
    private int? retryBackoffField;
    private bool retryBackoffFieldSpecified;
    private int? retryCountField;
    private bool retryCountFieldSpecified;
    private int? retryLimitField;
    private bool retryLimitFieldSpecified;
    private string sequenceGroupField;
    private int? sequenceNumberField;
    private bool sequenceNumberFieldSpecified;
    private DateTime? startedAtField;
    private bool startedAtFieldSpecified;
    private string statusField;
    private DateTime? submittedAtField;
    private bool submittedAtFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private int? timeoutField;
    private bool timeoutFieldSpecified;
    private UserRecordAccess userRecordAccessField;
    private string workerUriField;

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
    public string Error
    {
      get => this.errorField;
      set => this.errorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExecutionGroup
    {
      get => this.executionGroupField;
      set => this.executionGroupField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ExpiresAt
    {
      get => this.expiresAtField;
      set => this.expiresAtField = value;
    }

    [XmlIgnore]
    public bool ExpiresAtSpecified
    {
      get => this.expiresAtFieldSpecified;
      set => this.expiresAtFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? FinishedAt
    {
      get => this.finishedAtField;
      set => this.finishedAtField = value;
    }

    [XmlIgnore]
    public bool FinishedAtSpecified
    {
      get => this.finishedAtFieldSpecified;
      set => this.finishedAtFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public BackgroundOperation GroupLeader
    {
      get => this.groupLeaderField;
      set => this.groupLeaderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GroupLeaderId
    {
      get => this.groupLeaderIdField;
      set => this.groupLeaderIdField = value;
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
    public QueryResult MergedOperations
    {
      get => this.mergedOperationsField;
      set => this.mergedOperationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumFollowers
    {
      get => this.numFollowersField;
      set => this.numFollowersField = value;
    }

    [XmlIgnore]
    public bool NumFollowersSpecified
    {
      get => this.numFollowersFieldSpecified;
      set => this.numFollowersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentKey
    {
      get => this.parentKeyField;
      set => this.parentKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? ProcessAfter
    {
      get => this.processAfterField;
      set => this.processAfterField = value;
    }

    [XmlIgnore]
    public bool ProcessAfterSpecified
    {
      get => this.processAfterFieldSpecified;
      set => this.processAfterFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RetryBackoff
    {
      get => this.retryBackoffField;
      set => this.retryBackoffField = value;
    }

    [XmlIgnore]
    public bool RetryBackoffSpecified
    {
      get => this.retryBackoffFieldSpecified;
      set => this.retryBackoffFieldSpecified = value;
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
    public int? RetryLimit
    {
      get => this.retryLimitField;
      set => this.retryLimitField = value;
    }

    [XmlIgnore]
    public bool RetryLimitSpecified
    {
      get => this.retryLimitFieldSpecified;
      set => this.retryLimitFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SequenceGroup
    {
      get => this.sequenceGroupField;
      set => this.sequenceGroupField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? SequenceNumber
    {
      get => this.sequenceNumberField;
      set => this.sequenceNumberField = value;
    }

    [XmlIgnore]
    public bool SequenceNumberSpecified
    {
      get => this.sequenceNumberFieldSpecified;
      set => this.sequenceNumberFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? StartedAt
    {
      get => this.startedAtField;
      set => this.startedAtField = value;
    }

    [XmlIgnore]
    public bool StartedAtSpecified
    {
      get => this.startedAtFieldSpecified;
      set => this.startedAtFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SubmittedAt
    {
      get => this.submittedAtField;
      set => this.submittedAtField = value;
    }

    [XmlIgnore]
    public bool SubmittedAtSpecified
    {
      get => this.submittedAtFieldSpecified;
      set => this.submittedAtFieldSpecified = value;
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
    public int? Timeout
    {
      get => this.timeoutField;
      set => this.timeoutField = value;
    }

    [XmlIgnore]
    public bool TimeoutSpecified
    {
      get => this.timeoutFieldSpecified;
      set => this.timeoutFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public string WorkerUri
    {
      get => this.workerUriField;
      set => this.workerUriField = value;
    }
  }
}
