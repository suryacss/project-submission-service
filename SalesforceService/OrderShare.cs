// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OrderShare
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class OrderShare : sObject
  {
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private Order orderField;
    private string orderAccessLevelField;
    private string orderIdField;
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
    public Order Order
    {
      get => this.orderField;
      set => this.orderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OrderAccessLevel
    {
      get => this.orderAccessLevelField;
      set => this.orderAccessLevelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OrderId
    {
      get => this.orderIdField;
      set => this.orderIdField = value;
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
