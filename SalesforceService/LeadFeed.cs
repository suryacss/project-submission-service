// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LeadFeed
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class LeadFeed : sObject
  {
    private string bodyField;
    private int? commentCountField;
    private bool commentCountFieldSpecified;
    private Name createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult feedAttachmentsField;
    private QueryResult feedCommentsField;
    private QueryResult feedLikesField;
    private QueryResult feedTrackedChangesField;
    private Name insertedByField;
    private string insertedByIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isRichTextField;
    private bool isRichTextFieldSpecified;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private int? likeCountField;
    private bool likeCountFieldSpecified;
    private string linkUrlField;
    private Lead parentField;
    private string parentIdField;
    private string relatedRecordIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string titleField;
    private string typeField;

    [XmlElement(IsNullable = true)]
    public string Body
    {
      get => this.bodyField;
      set => this.bodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? CommentCount
    {
      get => this.commentCountField;
      set => this.commentCountField = value;
    }

    [XmlIgnore]
    public bool CommentCountSpecified
    {
      get => this.commentCountFieldSpecified;
      set => this.commentCountFieldSpecified = value;
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
    public QueryResult FeedComments
    {
      get => this.feedCommentsField;
      set => this.feedCommentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedLikes
    {
      get => this.feedLikesField;
      set => this.feedLikesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedTrackedChanges
    {
      get => this.feedTrackedChangesField;
      set => this.feedTrackedChangesField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name InsertedBy
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
    public int? LikeCount
    {
      get => this.likeCountField;
      set => this.likeCountField = value;
    }

    [XmlIgnore]
    public bool LikeCountSpecified
    {
      get => this.likeCountFieldSpecified;
      set => this.likeCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LinkUrl
    {
      get => this.linkUrlField;
      set => this.linkUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public Lead Parent
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
    public string RelatedRecordId
    {
      get => this.relatedRecordIdField;
      set => this.relatedRecordIdField = value;
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
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }
  }
}
