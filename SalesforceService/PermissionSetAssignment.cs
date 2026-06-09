// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PermissionSetAssignment
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
  public class PermissionSetAssignment : sObject
  {
    private User assigneeField;
    private string assigneeIdField;
    private PermissionSet permissionSetField;
    private string permissionSetIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public User Assignee
    {
      get => this.assigneeField;
      set => this.assigneeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AssigneeId
    {
      get => this.assigneeIdField;
      set => this.assigneeIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public PermissionSet PermissionSet
    {
      get => this.permissionSetField;
      set => this.permissionSetField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PermissionSetId
    {
      get => this.permissionSetIdField;
      set => this.permissionSetIdField = value;
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
