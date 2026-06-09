// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Email
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
  [XmlInclude(typeof (SingleEmailMessage))]
  [XmlInclude(typeof (MassEmailMessage))]
  [Serializable]
  public class Email
  {
    private bool? bccSenderField;
    private EmailPriority? emailPriorityField;
    private string replyToField;
    private bool? saveAsActivityField;
    private string senderDisplayNameField;
    private string subjectField;
    private bool? useSignatureField;

    [XmlElement(IsNullable = true)]
    public bool? bccSender
    {
      get => this.bccSenderField;
      set => this.bccSenderField = value;
    }

    [XmlElement(IsNullable = true)]
    public EmailPriority? emailPriority
    {
      get => this.emailPriorityField;
      set => this.emailPriorityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string replyTo
    {
      get => this.replyToField;
      set => this.replyToField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? saveAsActivity
    {
      get => this.saveAsActivityField;
      set => this.saveAsActivityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string senderDisplayName
    {
      get => this.senderDisplayNameField;
      set => this.senderDisplayNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string subject
    {
      get => this.subjectField;
      set => this.subjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? useSignature
    {
      get => this.useSignatureField;
      set => this.useSignatureField = value;
    }
  }
}
