// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RenderEmailTemplateResult
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class RenderEmailTemplateResult
  {
    private RenderEmailTemplateBodyResult[] bodyResultsField;
    private Error[] errorsField;
    private bool successField;

    [XmlElement("bodyResults")]
    public RenderEmailTemplateBodyResult[] bodyResults
    {
      get => this.bodyResultsField;
      set => this.bodyResultsField = value;
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
