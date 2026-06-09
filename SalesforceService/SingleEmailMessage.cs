// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SingleEmailMessage
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
  public class SingleEmailMessage : Email
  {
    private string[] bccAddressesField;
    private string[] ccAddressesField;
    private string charsetField;
    private string[] documentAttachmentsField;
    private string[] entityAttachmentsField;
    private EmailFileAttachment[] fileAttachmentsField;
    private string htmlBodyField;
    private string inReplyToField;
    private SendEmailOptOutPolicy? optOutPolicyField;
    private string orgWideEmailAddressIdField;
    private string plainTextBodyField;
    private string referencesField;
    private string targetObjectIdField;
    private string templateIdField;
    private string[] toAddressesField;
    private bool? treatBodiesAsTemplateField;
    private bool? treatTargetObjectAsRecipientField;
    private string whatIdField;

    [XmlElement("bccAddresses", IsNullable = true)]
    public string[] bccAddresses
    {
      get => this.bccAddressesField;
      set => this.bccAddressesField = value;
    }

    [XmlElement("ccAddresses", IsNullable = true)]
    public string[] ccAddresses
    {
      get => this.ccAddressesField;
      set => this.ccAddressesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string charset
    {
      get => this.charsetField;
      set => this.charsetField = value;
    }

    [XmlElement("documentAttachments")]
    public string[] documentAttachments
    {
      get => this.documentAttachmentsField;
      set => this.documentAttachmentsField = value;
    }

    [XmlElement("entityAttachments")]
    public string[] entityAttachments
    {
      get => this.entityAttachmentsField;
      set => this.entityAttachmentsField = value;
    }

    [XmlElement("fileAttachments")]
    public EmailFileAttachment[] fileAttachments
    {
      get => this.fileAttachmentsField;
      set => this.fileAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string htmlBody
    {
      get => this.htmlBodyField;
      set => this.htmlBodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string inReplyTo
    {
      get => this.inReplyToField;
      set => this.inReplyToField = value;
    }

    [XmlElement(IsNullable = true)]
    public SendEmailOptOutPolicy? optOutPolicy
    {
      get => this.optOutPolicyField;
      set => this.optOutPolicyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string orgWideEmailAddressId
    {
      get => this.orgWideEmailAddressIdField;
      set => this.orgWideEmailAddressIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string plainTextBody
    {
      get => this.plainTextBodyField;
      set => this.plainTextBodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string references
    {
      get => this.referencesField;
      set => this.referencesField = value;
    }

    [XmlElement(IsNullable = true)]
    public string targetObjectId
    {
      get => this.targetObjectIdField;
      set => this.targetObjectIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string templateId
    {
      get => this.templateIdField;
      set => this.templateIdField = value;
    }

    [XmlElement("toAddresses", IsNullable = true)]
    public string[] toAddresses
    {
      get => this.toAddressesField;
      set => this.toAddressesField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? treatBodiesAsTemplate
    {
      get => this.treatBodiesAsTemplateField;
      set => this.treatBodiesAsTemplateField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? treatTargetObjectAsRecipient
    {
      get => this.treatTargetObjectAsRecipientField;
      set => this.treatTargetObjectAsRecipientField = value;
    }

    [XmlElement(IsNullable = true)]
    public string whatId
    {
      get => this.whatIdField;
      set => this.whatIdField = value;
    }
  }
}
