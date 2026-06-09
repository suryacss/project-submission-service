// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ProcessResult
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class ProcessResult
  {
    private string[] actorIdsField;
    private string entityIdField;
    private Error[] errorsField;
    private string instanceIdField;
    private string instanceStatusField;
    private string[] newWorkitemIdsField;
    private bool successField;

    [XmlElement("actorIds")]
    public string[] actorIds
    {
      get => this.actorIdsField;
      set => this.actorIdsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string entityId
    {
      get => this.entityIdField;
      set => this.entityIdField = value;
    }

    [XmlElement("errors")]
    public Error[] errors
    {
      get => this.errorsField;
      set => this.errorsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string instanceId
    {
      get => this.instanceIdField;
      set => this.instanceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string instanceStatus
    {
      get => this.instanceStatusField;
      set => this.instanceStatusField = value;
    }

    [XmlElement("newWorkitemIds", IsNullable = true)]
    public string[] newWorkitemIds
    {
      get => this.newWorkitemIdsField;
      set => this.newWorkitemIdsField = value;
    }

    public bool success
    {
      get => this.successField;
      set => this.successField = value;
    }
  }
}
