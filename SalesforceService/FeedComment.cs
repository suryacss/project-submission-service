// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FeedComment
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class FeedComment : sObject
  {
    private string commentBodyField;
    private string commentTypeField;
    private Name createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult feedAttachmentsField;
    private string feedItemIdField;
    private QueryResult feedRevisionsField;
    private User insertedByField;
    private string insertedByIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isRichTextField;
    private bool isRichTextFieldSpecified;
    private string lastEditByIdField;
    private DateTime? lastEditDateField;
    private bool lastEditDateFieldSpecified;
    private string parentIdField;
    private string relatedRecordIdField;
    private int? revisionField;
    private bool revisionFieldSpecified;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string CommentBody
    {
      get => this.commentBodyField;
      set => this.commentBodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CommentType
    {
      get => this.commentTypeField;
      set => this.commentTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name CreatedBy
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
    public QueryResult FeedAttachments
    {
      get => this.feedAttachmentsField;
      set => this.feedAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FeedItemId
    {
      get => this.feedItemIdField;
      set => this.feedItemIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedRevisions
    {
      get => this.feedRevisionsField;
      set => this.feedRevisionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public User InsertedBy
    {
      get => this.insertedByField;
      set => this.insertedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string InsertedById
    {
      get => this.insertedByIdField;
      set => this.insertedByIdField = value;
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
    public bool? IsRichText
    {
      get => this.isRichTextField;
      set => this.isRichTextField = value;
    }

    [XmlIgnore]
    public bool IsRichTextSpecified
    {
      get => this.isRichTextFieldSpecified;
      set => this.isRichTextFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastEditById
    {
      get => this.lastEditByIdField;
      set => this.lastEditByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastEditDate
    {
      get => this.lastEditDateField;
      set => this.lastEditDateField = value;
    }

    [XmlIgnore]
    public bool LastEditDateSpecified
    {
      get => this.lastEditDateFieldSpecified;
      set => this.lastEditDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentId
    {
      get => this.parentIdField;
      set => this.parentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelatedRecordId
    {
      get => this.relatedRecordIdField;
      set => this.relatedRecordIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Revision
    {
      get => this.revisionField;
      set => this.revisionField = value;
    }

    [XmlIgnore]
    public bool RevisionSpecified
    {
      get => this.revisionFieldSpecified;
      set => this.revisionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
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
  }
}
