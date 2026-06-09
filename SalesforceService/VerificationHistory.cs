// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.VerificationHistory
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
  public class VerificationHistory : sObject
  {
    private string activityField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private int? eventGroupField;
    private bool eventGroupFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private LoginGeo loginGeoField;
    private string loginGeoIdField;
    private LoginHistory loginHistoryField;
    private string loginHistoryIdField;
    private string policyField;
    private string remarksField;
    private ConnectedApplication resourceField;
    private string resourceIdField;
    private string sourceIpField;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private User userField;
    private string userIdField;
    private string verificationMethodField;
    private DateTime? verificationTimeField;
    private bool verificationTimeFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string Activity
    {
      get => this.activityField;
      set => this.activityField = value;
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
    public int? EventGroup
    {
      get => this.eventGroupField;
      set => this.eventGroupField = value;
    }

    [XmlIgnore]
    public bool EventGroupSpecified
    {
      get => this.eventGroupFieldSpecified;
      set => this.eventGroupFieldSpecified = value;
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
    public LoginGeo LoginGeo
    {
      get => this.loginGeoField;
      set => this.loginGeoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LoginGeoId
    {
      get => this.loginGeoIdField;
      set => this.loginGeoIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public LoginHistory LoginHistory
    {
      get => this.loginHistoryField;
      set => this.loginHistoryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LoginHistoryId
    {
      get => this.loginHistoryIdField;
      set => this.loginHistoryIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Policy
    {
      get => this.policyField;
      set => this.policyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Remarks
    {
      get => this.remarksField;
      set => this.remarksField = value;
    }

    [XmlElement(IsNullable = true)]
    public ConnectedApplication Resource
    {
      get => this.resourceField;
      set => this.resourceField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ResourceId
    {
      get => this.resourceIdField;
      set => this.resourceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceIp
    {
      get => this.sourceIpField;
      set => this.sourceIpField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
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
    public User User
    {
      get => this.userField;
      set => this.userField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string VerificationMethod
    {
      get => this.verificationMethodField;
      set => this.verificationMethodField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? VerificationTime
    {
      get => this.verificationTimeField;
      set => this.verificationTimeField = value;
    }

    [XmlIgnore]
    public bool VerificationTimeSpecified
    {
      get => this.verificationTimeFieldSpecified;
      set => this.verificationTimeFieldSpecified = value;
    }
  }
}
