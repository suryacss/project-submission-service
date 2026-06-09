// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ConnectedApplication
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
  public class ConnectedApplication : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult installedMobileAppsField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string mobileSessionTimeoutField;
    private string mobileStartUrlField;
    private string nameField;
    private bool? optionsAllowAdminApprovedUsersOnlyField;
    private bool optionsAllowAdminApprovedUsersOnlyFieldSpecified;
    private bool? optionsHasSessionLevelPolicyField;
    private bool optionsHasSessionLevelPolicyFieldSpecified;
    private bool? optionsIsInternalField;
    private bool optionsIsInternalFieldSpecified;
    private bool? optionsRefreshTokenValidityMetricField;
    private bool optionsRefreshTokenValidityMetricFieldSpecified;
    private string pinLengthField;
    private int? refreshTokenValidityPeriodField;
    private bool refreshTokenValidityPeriodFieldSpecified;
    private QueryResult setupEntityAccessItemsField;
    private string startUrlField;
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
    public QueryResult InstalledMobileApps
    {
      get => this.installedMobileAppsField;
      set => this.installedMobileAppsField = value;
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
    public string MobileSessionTimeout
    {
      get => this.mobileSessionTimeoutField;
      set => this.mobileSessionTimeoutField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobileStartUrl
    {
      get => this.mobileStartUrlField;
      set => this.mobileStartUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsAllowAdminApprovedUsersOnly
    {
      get => this.optionsAllowAdminApprovedUsersOnlyField;
      set => this.optionsAllowAdminApprovedUsersOnlyField = value;
    }

    [XmlIgnore]
    public bool OptionsAllowAdminApprovedUsersOnlySpecified
    {
      get => this.optionsAllowAdminApprovedUsersOnlyFieldSpecified;
      set => this.optionsAllowAdminApprovedUsersOnlyFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsHasSessionLevelPolicy
    {
      get => this.optionsHasSessionLevelPolicyField;
      set => this.optionsHasSessionLevelPolicyField = value;
    }

    [XmlIgnore]
    public bool OptionsHasSessionLevelPolicySpecified
    {
      get => this.optionsHasSessionLevelPolicyFieldSpecified;
      set => this.optionsHasSessionLevelPolicyFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsIsInternal
    {
      get => this.optionsIsInternalField;
      set => this.optionsIsInternalField = value;
    }

    [XmlIgnore]
    public bool OptionsIsInternalSpecified
    {
      get => this.optionsIsInternalFieldSpecified;
      set => this.optionsIsInternalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? OptionsRefreshTokenValidityMetric
    {
      get => this.optionsRefreshTokenValidityMetricField;
      set => this.optionsRefreshTokenValidityMetricField = value;
    }

    [XmlIgnore]
    public bool OptionsRefreshTokenValidityMetricSpecified
    {
      get => this.optionsRefreshTokenValidityMetricFieldSpecified;
      set => this.optionsRefreshTokenValidityMetricFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PinLength
    {
      get => this.pinLengthField;
      set => this.pinLengthField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? RefreshTokenValidityPeriod
    {
      get => this.refreshTokenValidityPeriodField;
      set => this.refreshTokenValidityPeriodField = value;
    }

    [XmlIgnore]
    public bool RefreshTokenValidityPeriodSpecified
    {
      get => this.refreshTokenValidityPeriodFieldSpecified;
      set => this.refreshTokenValidityPeriodFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SetupEntityAccessItems
    {
      get => this.setupEntityAccessItemsField;
      set => this.setupEntityAccessItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string StartUrl
    {
      get => this.startUrlField;
      set => this.startUrlField = value;
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
