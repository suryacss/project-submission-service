// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RenderEmailTemplateError
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class RenderEmailTemplateError
  {
    private string fieldNameField;
    private string messageField;
    private int offsetField;
    private StatusCode statusCodeField;

    public string fieldName
    {
      get => this.fieldNameField;
      set => this.fieldNameField = value;
    }

    public string message
    {
      get => this.messageField;
      set => this.messageField = value;
    }

    public int offset
    {
      get => this.offsetField;
      set => this.offsetField = value;
    }

    public StatusCode statusCode
    {
      get => this.statusCodeField;
      set => this.statusCodeField = value;
    }
  }
}
