// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Idea
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
  public class Idea : sObject
  {
    private string bodyField;
    private string categoriesField;
    private QueryResult commentsField;
    private Community communityField;
    private string communityIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string creatorFullPhotoUrlField;
    private string creatorNameField;
    private string creatorSmallPhotoUrlField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isHtmlField;
    private bool isHtmlFieldSpecified;
    private bool? isMergedField;
    private bool isMergedFieldSpecified;
    private IdeaComment lastCommentField;
    private DateTime? lastCommentDateField;
    private bool lastCommentDateFieldSpecified;
    private string lastCommentIdField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private int? numCommentsField;
    private bool numCommentsFieldSpecified;
    private Idea parentIdeaField;
    private string parentIdeaIdField;
    private RecordType recordTypeField;
    private string recordTypeIdField;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string titleField;
    private UserRecordAccess userRecordAccessField;
    private double? voteScoreField;
    private bool voteScoreFieldSpecified;
    private double? voteTotalField;
    private bool voteTotalFieldSpecified;
    private QueryResult votesField;

    [XmlElement(IsNullable = true)]
    public string Body
    {
      get => this.bodyField;
      set => this.bodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Categories
    {
      get => this.categoriesField;
      set => this.categoriesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Comments
    {
      get => this.commentsField;
      set => this.commentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public Community Community
    {
      get => this.communityField;
      set => this.communityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CommunityId
    {
      get => this.communityIdField;
      set => this.communityIdField = value;
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
    public string CreatorFullPhotoUrl
    {
      get => this.creatorFullPhotoUrlField;
      set => this.creatorFullPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CreatorName
    {
      get => this.creatorNameField;
      set => this.creatorNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CreatorSmallPhotoUrl
    {
      get => this.creatorSmallPhotoUrlField;
      set => this.creatorSmallPhotoUrlField = value;
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
    public bool? IsHtml
    {
      get => this.isHtmlField;
      set => this.isHtmlField = value;
    }

    [XmlIgnore]
    public bool IsHtmlSpecified
    {
      get => this.isHtmlFieldSpecified;
      set => this.isHtmlFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsMerged
    {
      get => this.isMergedField;
      set => this.isMergedField = value;
    }

    [XmlIgnore]
    public bool IsMergedSpecified
    {
      get => this.isMergedFieldSpecified;
      set => this.isMergedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public IdeaComment LastComment
    {
      get => this.lastCommentField;
      set => this.lastCommentField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastCommentDate
    {
      get => this.lastCommentDateField;
      set => this.lastCommentDateField = value;
    }

    [XmlIgnore]
    public bool LastCommentDateSpecified
    {
      get => this.lastCommentDateFieldSpecified;
      set => this.lastCommentDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastCommentId
    {
      get => this.lastCommentIdField;
      set => this.lastCommentIdField = value;
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
    public DateTime? LastReferencedDate
    {
      get => this.lastReferencedDateField;
      set => this.lastReferencedDateField = value;
    }

    [XmlIgnore]
    public bool LastReferencedDateSpecified
    {
      get => this.lastReferencedDateFieldSpecified;
      set => this.lastReferencedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastViewedDate
    {
      get => this.lastViewedDateField;
      set => this.lastViewedDateField = value;
    }

    [XmlIgnore]
    public bool LastViewedDateSpecified
    {
      get => this.lastViewedDateFieldSpecified;
      set => this.lastViewedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumComments
    {
      get => this.numCommentsField;
      set => this.numCommentsField = value;
    }

    [XmlIgnore]
    public bool NumCommentsSpecified
    {
      get => this.numCommentsFieldSpecified;
      set => this.numCommentsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public Idea ParentIdea
    {
      get => this.parentIdeaField;
      set => this.parentIdeaField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentIdeaId
    {
      get => this.parentIdeaIdField;
      set => this.parentIdeaIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public RecordType RecordType
    {
      get => this.recordTypeField;
      set => this.recordTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecordTypeId
    {
      get => this.recordTypeIdField;
      set => this.recordTypeIdField = value;
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

    [XmlElement(IsNullable = true)]
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? VoteScore
    {
      get => this.voteScoreField;
      set => this.voteScoreField = value;
    }

    [XmlIgnore]
    public bool VoteScoreSpecified
    {
      get => this.voteScoreFieldSpecified;
      set => this.voteScoreFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? VoteTotal
    {
      get => this.voteTotalField;
      set => this.voteTotalField = value;
    }

    [XmlIgnore]
    public bool VoteTotalSpecified
    {
      get => this.voteTotalFieldSpecified;
      set => this.voteTotalFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Votes
    {
      get => this.votesField;
      set => this.votesField = value;
    }
  }
}
