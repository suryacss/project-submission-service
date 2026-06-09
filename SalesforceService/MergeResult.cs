// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.MergeResult
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
  public class MergeResult
  {
    private Error[] errorsField;
    private string idField;
    private string[] mergedRecordIdsField;
    private bool successField;
    private string[] updatedRelatedIdsField;

    [XmlElement("errors")]
    public Error[] errors
    {
      get => this.errorsField;
      set => this.errorsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [XmlElement("mergedRecordIds")]
    public string[] mergedRecordIds
    {
      get => this.mergedRecordIdsField;
      set => this.mergedRecordIdsField = value;
    }

    public bool success
    {
      get => this.successField;
      set => this.successField = value;
    }

    [XmlElement("updatedRelatedIds")]
    public string[] updatedRelatedIds
    {
      get => this.updatedRelatedIdsField;
      set => this.updatedRelatedIdsField = value;
    }
  }
}
