// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FindDuplicatesResult
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
  public class FindDuplicatesResult
  {
    private DuplicateResult[] duplicateResultsField;
    private Error[] errorsField;
    private bool successField;

    [XmlElement("duplicateResults")]
    public DuplicateResult[] duplicateResults
    {
      get => this.duplicateResultsField;
      set => this.duplicateResultsField = value;
    }

    [XmlElement("errors")]
    public Error[] errors
    {
      get => this.errorsField;
      set => this.errorsField = value;
    }

    public bool success
    {
      get => this.successField;
      set => this.successField = value;
    }
  }
}
