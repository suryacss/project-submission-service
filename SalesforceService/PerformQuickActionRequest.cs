// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PerformQuickActionRequest
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class PerformQuickActionRequest
  {
    private string contextIdField;
    private string quickActionNameField;
    private sObject[] recordsField;

    [XmlElement(IsNullable = true)]
    public string contextId
    {
      get => this.contextIdField;
      set => this.contextIdField = value;
    }

    public string quickActionName
    {
      get => this.quickActionNameField;
      set => this.quickActionNameField = value;
    }

    [XmlElement("records", IsNullable = true)]
    public sObject[] records
    {
      get => this.recordsField;
      set => this.recordsField = value;
    }
  }
}
