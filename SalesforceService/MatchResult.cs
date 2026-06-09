// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.MatchResult
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class MatchResult
  {
    private string entityTypeField;
    private Error[] errorsField;
    private string matchEngineField;
    private MatchRecord[] matchRecordsField;
    private string ruleField;
    private int sizeField;
    private bool successField;

    public string entityType
    {
      get => this.entityTypeField;
      set => this.entityTypeField = value;
    }

    [XmlElement("errors")]
    public Error[] errors
    {
      get => this.errorsField;
      set => this.errorsField = value;
    }

    public string matchEngine
    {
      get => this.matchEngineField;
      set => this.matchEngineField = value;
    }

    [XmlElement("matchRecords")]
    public MatchRecord[] matchRecords
    {
      get => this.matchRecordsField;
      set => this.matchRecordsField = value;
    }

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    public int size
    {
      get => this.sizeField;
      set => this.sizeField = value;
    }

    public bool success
    {
      get => this.successField;
      set => this.successField = value;
    }
  }
}
