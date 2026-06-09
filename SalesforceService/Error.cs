// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Error
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [XmlInclude(typeof (DuplicateError))]
  [Serializable]
  public class Error
  {
    private ExtendedErrorDetails[] extendedErrorDetailsField;
    private string[] fieldsField;
    private string messageField;
    private StatusCode statusCodeField;

    [XmlElement("extendedErrorDetails", IsNullable = true)]
    public ExtendedErrorDetails[] extendedErrorDetails
    {
      get => this.extendedErrorDetailsField;
      set => this.extendedErrorDetailsField = value;
    }

    [XmlElement("fields", IsNullable = true)]
    public string[] fields
    {
      get => this.fieldsField;
      set => this.fieldsField = value;
    }

    public string message
    {
      get => this.messageField;
      set => this.messageField = value;
    }

    public StatusCode statusCode
    {
      get => this.statusCodeField;
      set => this.statusCodeField = value;
    }
  }
}
