// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.GroupMember
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
  public class GroupMember : sObject
  {
    private Group groupField;
    private string groupIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string userOrGroupIdField;

    [XmlElement(IsNullable = true)]
    public Group Group
    {
      get => this.groupField;
      set => this.groupField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GroupId
    {
      get => this.groupIdField;
      set => this.groupIdField = value;
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
    public string UserOrGroupId
    {
      get => this.userOrGroupIdField;
      set => this.userOrGroupIdField = value;
    }
  }
}
