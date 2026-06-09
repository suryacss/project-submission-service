// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OutgoingEmail
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class OutgoingEmail : sObject
  {
    private string bccAddressField;
    private string[] bccIdsField;
    private string ccAddressField;
    private string[] ccIdsField;
    private string[] contentDocumentIdsField;
    private QueryResult contentDocumentLinksField;
    private string externalIdField;
    private string htmlBodyField;
    private QueryResult outgoingEmailRelationsField;
    private Name relatedToField;
    private string relatedToIdField;
    private string subjectField;
    private string textBodyField;
    private string toAddressField;
    private string[] toIdsField;
    private string validatedFromAddressField;
    private Name whoField;
    private string whoIdField;

    [XmlElement(IsNullable = true)]
    public string BccAddress
    {
      get => this.bccAddressField;
      set => this.bccAddressField = value;
    }

    [XmlElement("BccIds", IsNullable = true)]
    public string[] BccIds
    {
      get => this.bccIdsField;
      set => this.bccIdsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CcAddress
    {
      get => this.ccAddressField;
      set => this.ccAddressField = value;
    }

    [XmlElement("CcIds", IsNullable = true)]
    public string[] CcIds
    {
      get => this.ccIdsField;
      set => this.ccIdsField = value;
    }

    [XmlElement("ContentDocumentIds", IsNullable = true)]
    public string[] ContentDocumentIds
    {
      get => this.contentDocumentIdsField;
      set => this.contentDocumentIdsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ContentDocumentLinks
    {
      get => this.contentDocumentLinksField;
      set => this.contentDocumentLinksField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalId
    {
      get => this.externalIdField;
      set => this.externalIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string HtmlBody
    {
      get => this.htmlBodyField;
      set => this.htmlBodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult OutgoingEmailRelations
    {
      get => this.outgoingEmailRelationsField;
      set => this.outgoingEmailRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name RelatedTo
    {
      get => this.relatedToField;
      set => this.relatedToField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelatedToId
    {
      get => this.relatedToIdField;
      set => this.relatedToIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Subject
    {
      get => this.subjectField;
      set => this.subjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TextBody
    {
      get => this.textBodyField;
      set => this.textBodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ToAddress
    {
      get => this.toAddressField;
      set => this.toAddressField = value;
    }

    [XmlElement("ToIds", IsNullable = true)]
    public string[] ToIds
    {
      get => this.toIdsField;
      set => this.toIdsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ValidatedFromAddress
    {
      get => this.validatedFromAddressField;
      set => this.validatedFromAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name Who
    {
      get => this.whoField;
      set => this.whoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string WhoId
    {
      get => this.whoIdField;
      set => this.whoIdField = value;
    }
  }
}
