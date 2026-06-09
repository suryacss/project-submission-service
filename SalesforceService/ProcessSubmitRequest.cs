// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ProcessSubmitRequest
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class ProcessSubmitRequest : ProcessRequest
  {
    private string objectIdField;
    private string submitterIdField;
    private string processDefinitionNameOrIdField;
    private bool? skipEntryCriteriaField;

    public string objectId
    {
      get => this.objectIdField;
      set => this.objectIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string submitterId
    {
      get => this.submitterIdField;
      set => this.submitterIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string processDefinitionNameOrId
    {
      get => this.processDefinitionNameOrIdField;
      set => this.processDefinitionNameOrIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? skipEntryCriteria
    {
      get => this.skipEntryCriteriaField;
      set => this.skipEntryCriteriaField = value;
    }
  }
}
