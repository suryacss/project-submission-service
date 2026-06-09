// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FieldPermissions
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
  public class FieldPermissions : sObject
  {
    private string fieldField;
    private PermissionSet parentField;
    private string parentIdField;
    private bool? permissionsEditField;
    private bool permissionsEditFieldSpecified;
    private bool? permissionsReadField;
    private bool permissionsReadFieldSpecified;
    private string sobjectTypeField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string Field
    {
      get => this.fieldField;
      set => this.fieldField = value;
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
