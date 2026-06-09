// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PerformQuickActionResult
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class PerformQuickActionResult
  {
    private string contextIdField;
    private bool createdField;
    private Error[] errorsField;
    private string[] feedItemIdsField;
    private string[] idsField;
    private bool successField;
    private string successMessageField;

    [XmlElement(IsNullable = true)]
    public string contextId
    {
      get => this.contextIdField;
      set => this.contextIdField = value;
    }

    public bool created
    {
      get => this.createdField;
      set => this.createdField = value;
    }

    [XmlElement("errors")]
    public Error[] errors
    {
      get => this.errorsField;
      set => this.errorsField = value;
    }

    [XmlElement("feedItemIds", IsNullable = true)]
    public string[] feedItemIds
    {
      get => this.feedItemIdsField;
      set => this.feedItemIdsField = value;
    }

    [XmlElement("ids", IsNullable = true)]
    public string[] ids
    {
      get => this.idsField;
      set => this.idsField = value;
    }

    public bool success
    {
      get => this.successField;
      set => this.successField = value;
    }

    [XmlElement(IsNullable = true)]
    public string successMessage
    {
      get => this.successMessageField;
      set => this.successMessageField = value;
    }
  }
}
