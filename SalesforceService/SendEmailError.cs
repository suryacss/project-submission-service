// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SendEmailError
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class SendEmailError
  {
    private string[] fieldsField;
    private string messageField;
    private StatusCode statusCodeField;
    private string targetObjectIdField;

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

    [XmlElement(IsNullable = true)]
    public string targetObjectId
    {
      get => this.targetObjectIdField;
      set => this.targetObjectIdField = value;
    }
  }
}
