// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ForecastShare
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class ForecastShare : sObject
  {
    private string accessLevelField;
    private bool? canSubmitField;
    private bool canSubmitFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string rowCauseField;
    private string userOrGroupIdField;
    private string userRoleIdField;

    [XmlElement(IsNullable = true)]
    public string AccessLevel
    {
      get => this.accessLevelField;
      set => this.accessLevelField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? CanSubmit
    {
      get => this.canSubmitField;
      set => this.canSubmitField = value;
    }

    [XmlIgnore]
    public bool CanSubmitSpecified
    {
      get => this.canSubmitFieldSpecified;
      set => this.canSubmitFieldSpecified = value;
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
    public string RowCause
    {
      get => this.rowCauseField;
      set => this.rowCauseField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserOrGroupId
    {
      get => this.userOrGroupIdField;
      set => this.userOrGroupIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserRoleId
    {
      get => this.userRoleIdField;
      set => this.userRoleIdField = value;
    }
  }
}
