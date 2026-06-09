// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ObjectPermissions
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
  public class ObjectPermissions : sObject
  {
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private PermissionSet parentField;
    private string parentIdField;
    private bool? permissionsCreateField;
    private bool permissionsCreateFieldSpecified;
    private bool? permissionsDeleteField;
    private bool permissionsDeleteFieldSpecified;
    private bool? permissionsEditField;
    private bool permissionsEditFieldSpecified;
    private bool? permissionsModifyAllRecordsField;
    private bool permissionsModifyAllRecordsFieldSpecified;
    private bool? permissionsReadField;
    private bool permissionsReadFieldSpecified;
    private bool? permissionsViewAllRecordsField;
    private bool permissionsViewAllRecordsFieldSpecified;
    private string sobjectTypeField;
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
    public PermissionSet Parent
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
    public bool? PermissionsCreate
    {
      get => this.permissionsCreateField;
      set => this.permissionsCreateField = value;
    }

    [XmlIgnore]
    public bool PermissionsCreateSpecified
    {
      get => this.permissionsCreateFieldSpecified;
      set => this.permissionsCreateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsDelete
    {
      get => this.permissionsDeleteField;
      set => this.permissionsDeleteField = value;
    }

    [XmlIgnore]
    public bool PermissionsDeleteSpecified
    {
      get => this.permissionsDeleteFieldSpecified;
      set => this.permissionsDeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsEdit
    {
      get => this.permissionsEditField;
      set => this.permissionsEditField = value;
    }

    [XmlIgnore]
    public bool PermissionsEditSpecified
    {
      get => this.permissionsEditFieldSpecified;
      set => this.permissionsEditFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsModifyAllRecords
    {
      get => this.permissionsModifyAllRecordsField;
      set => this.permissionsModifyAllRecordsField = value;
    }

    [XmlIgnore]
    public bool PermissionsModifyAllRecordsSpecified
    {
      get => this.permissionsModifyAllRecordsFieldSpecified;
      set => this.permissionsModifyAllRecordsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsRead
    {
      get => this.permissionsReadField;
      set => this.permissionsReadField = value;
    }

    [XmlIgnore]
    public bool PermissionsReadSpecified
    {
      get => this.permissionsReadFieldSpecified;
      set => this.permissionsReadFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? PermissionsViewAllRecords
    {
      get => this.permissionsViewAllRecordsField;
      set => this.permissionsViewAllRecordsField = value;
    }

    [XmlIgnore]
    public bool PermissionsViewAllRecordsSpecified
    {
      get => this.permissionsViewAllRecordsFieldSpecified;
      set => this.permissionsViewAllRecordsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SobjectType
    {
      get => this.sobjectTypeField;
      set => this.sobjectTypeField = value;
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
