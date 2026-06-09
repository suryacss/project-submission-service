// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.IFO_Win_Rate__History
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class IFO_Win_Rate__History : sObject
  {
    private Name createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string fieldField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private object newValueField;
    private object oldValueField;
    private IFO_Win_Rate__c parentField;
    private string parentIdField;

    [XmlElement(IsNullable = true)]
    public Name CreatedBy
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
    public string Field
    {
      get => this.fieldField;
      set => this.fieldField = value;
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
    public object NewValue
    {
      get => this.newValueField;
      set => this.newValueField = value;
    }

    [XmlElement(IsNullable = true)]
    public object OldValue
    {
      get => this.oldValueField;
      set => this.oldValueField = value;
    }

    [XmlElement(IsNullable = true)]
    public IFO_Win_Rate__c Parent
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
  }
}
