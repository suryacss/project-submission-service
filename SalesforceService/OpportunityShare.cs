// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OpportunityShare
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
  public class OpportunityShare : sObject
  {
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private Opportunity opportunityField;
    private string opportunityAccessLevelField;
    private string opportunityIdField;
    private string rowCauseField;
    private Name userOrGroupField;
    private string userOrGroupIdField;

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
    public Opportunity Opportunity
    {
      get => this.opportunityField;
      set => this.opportunityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OpportunityAccessLevel
    {
      get => this.opportunityAccessLevelField;
      set => this.opportunityAccessLevelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OpportunityId
    {
      get => this.opportunityIdField;
      set => this.opportunityIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RowCause
    {
      get => this.rowCauseField;
      set => this.rowCauseField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name UserOrGroup
    {
      get => this.userOrGroupField;
      set => this.userOrGroupField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserOrGroupId
    {
      get => this.userOrGroupIdField;
      set => this.userOrGroupIdField = value;
    }
  }
}
