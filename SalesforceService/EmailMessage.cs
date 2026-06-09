// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EmailMessage
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class EmailMessage : sObject
  {
    private string activityIdField;
    private QueryResult attachedContentDocumentsField;
    private QueryResult attachmentsField;
    private string bccAddressField;
    private string[] bccIdsField;
    private string ccAddressField;
    private string[] ccIdsField;
    private QueryResult combinedAttachmentsField;
    private string[] contentDocumentIdsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult emailMessageRelationsField;
    private string fromAddressField;
    private string fromNameField;
    private bool? hasAttachmentField;
    private bool hasAttachmentFieldSpecified;
    private string headersField;
    private string htmlBodyField;
    private bool? incomingField;
    private bool incomingFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isExternallyVisibleField;
    private bool isExternallyVisibleFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? messageDateField;
    private bool messageDateFieldSpecified;
    private string messageIdentifierField;
    private Case parentField;
    private string parentIdField;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private Name relatedToField;
    private string relatedToIdField;
    private EmailMessage replyToEmailMessageField;
    private string replyToEmailMessageIdField;
    private string statusField;
    private string subjectField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string textBodyField;
    private string threadIdentifierField;
    private string toAddressField;
    private string[] toIdsField;
    private string validatedFromAddressField;

    [XmlElement(IsNullable = true)]
    public string ActivityId
    {
      get => this.activityIdField;
      set => this.activityIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Attachments
    {
      get => this.attachmentsField;
      set => this.attachmentsField = value;
    }

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

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
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
    public User CreatedBy
    {
      get => this.createdByField;
      set => this.createdByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CreatedById
    {
      get => this.createdByIdField;
      set => this.createdByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? CreatedDate
    {
      get => this.createdDateField;
      set => this.createdDateField = value;
    }

    [XmlIgnore]
    public bool CreatedDateSpecified
    {
      get => this.createdDateFieldSpecified;
      set => this.createdDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult EmailMessageRelations
    {
      get => this.emailMessageRelationsField;
      set => this.emailMessageRelationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FromAddress
    {
      get => this.fromAddressField;
      set => this.fromAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FromName
    {
      get => this.fromNameField;
      set => this.fromNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasAttachment
    {
      get => this.hasAttachmentField;
      set => this.hasAttachmentField = value;
    }

    [XmlIgnore]
    public bool HasAttachmentSpecified
    {
      get => this.hasAttachmentFieldSpecified;
      set => this.hasAttachmentFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Headers
    {
      get => this.headersField;
      set => this.headersField = value;
    }

    [XmlElement(IsNullable = true)]
    public string HtmlBody
    {
      get => this.htmlBodyField;
      set => this.htmlBodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? Incoming
    {
      get => this.incomingField;
      set => this.incomingField = value;
    }

    [XmlIgnore]
    public bool IncomingSpecified
    {
      get => this.incomingFieldSpecified;
      set => this.incomingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeleted
    {
      get => this.isDeletedField;
      set => this.isDeletedField = value;
    }

    [XmlIgnore]
    public bool IsDeletedSpecified
    {
      get => this.isDeletedFieldSpecified;
      set => this.isDeletedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsExternallyVisible
    {
      get => this.isExternallyVisibleField;
      set => this.isExternallyVisibleField = value;
    }

    [XmlIgnore]
    public bool IsExternallyVisibleSpecified
    {
      get => this.isExternallyVisibleFieldSpecified;
      set => this.isExternallyVisibleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User LastModifiedBy
    {
      get => this.lastModifiedByField;
      set => this.lastModifiedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastModifiedById
    {
      get => this.lastModifiedByIdField;
      set => this.lastModifiedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastModifiedDate
    {
      get => this.lastModifiedDateField;
      set => this.lastModifiedDateField = value;
    }

    [XmlIgnore]
    public bool LastModifiedDateSpecified
    {
      get => this.lastModifiedDateFieldSpecified;
      set => this.lastModifiedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? MessageDate
    {
      get => this.messageDateField;
      set => this.messageDateField = value;
    }

    [XmlIgnore]
    public bool MessageDateSpecified
    {
      get => this.messageDateFieldSpecified;
      set => this.messageDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MessageIdentifier
    {
      get => this.messageIdentifierField;
      set => this.messageIdentifierField = value;
    }

    [XmlElement(IsNullable = true)]
    public Case Parent
    {
      get => this.parentField;
      set => this.parentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentId
    {
      get => this.parentIdField;
      set => this.parentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessInstances
    {
      get => this.processInstancesField;
      set => this.processInstancesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult ProcessSteps
    {
      get => this.processStepsField;
      set => this.processStepsField = value;
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
    public EmailMessage ReplyToEmailMessage
    {
      get => this.replyToEmailMessageField;
      set => this.replyToEmailMessageField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ReplyToEmailMessageId
    {
      get => this.replyToEmailMessageIdField;
      set => this.replyToEmailMessageIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Subject
    {
      get => this.subjectField;
      set => this.subjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SystemModstamp
    {
      get => this.systemModstampField;
      set => this.systemModstampField = value;
    }

    [XmlIgnore]
    public bool SystemModstampSpecified
    {
      get => this.systemModstampFieldSpecified;
      set => this.systemModstampFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TextBody
    {
      get => this.textBodyField;
      set => this.textBodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ThreadIdentifier
    {
      get => this.threadIdentifierField;
      set => this.threadIdentifierField = value;
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
  }
}
