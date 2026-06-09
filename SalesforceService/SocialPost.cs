// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SocialPost
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class SocialPost : sObject
  {
    private double? analyzerScoreField;
    private bool analyzerScoreFieldSpecified;
    private string assignedToField;
    private QueryResult attachedContentDocumentsField;
    private string attachmentTypeField;
    private string attachmentUrlField;
    private QueryResult attachmentsField;
    private string classificationField;
    private QueryResult combinedAttachmentsField;
    private int? commentCountField;
    private bool commentCountFieldSpecified;
    private string contentField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private User deletedByField;
    private string deletedByIdField;
    private string engagementLevelField;
    private string externalPostIdField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private string handleField;
    private DateTime? harvestDateField;
    private bool harvestDateFieldSpecified;
    private string headlineField;
    private QueryResult historiesField;
    private int? inboundLinkCountField;
    private bool inboundLinkCountFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isOutboundField;
    private bool isOutboundFieldSpecified;
    private string keywordGroupNameField;
    private string languageField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private string likedByField;
    private int? likesAndVotesField;
    private bool likesAndVotesFieldSpecified;
    private string mediaProviderField;
    private string mediaTypeField;
    private string messageTypeField;
    private string nameField;
    private QueryResult notesField;
    private QueryResult notesAndAttachmentsField;
    private ExternalSocialAccount outboundSocialAccountField;
    private string outboundSocialAccountIdField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name ownerField;
    private string ownerIdField;
    private ProjectSubmissionsSvcLib.SalesforceService.Name parentField;
    private string parentIdField;
    private SocialPersona personaField;
    private string personaIdField;
    private QueryResult personasField;
    private string postPriorityField;
    private string postTagsField;
    private string postUrlField;
    private DateTime? postedField;
    private bool postedFieldSpecified;
    private QueryResult processInstancesField;
    private QueryResult processStepsField;
    private string providerField;
    private string r6PostIdField;
    private string r6SourceIdField;
    private string r6TopicIdField;
    private string recipientField;
    private string recipientTypeField;
    private QueryResult repliesField;
    private SocialPost replyToField;
    private string replyToIdField;
    private string responseContextExternalIdField;
    private double? reviewScaleField;
    private bool reviewScaleFieldSpecified;
    private double? reviewScoreField;
    private bool reviewScoreFieldSpecified;
    private string sentimentField;
    private int? sharesField;
    private bool sharesFieldSpecified;
    private string sourceTagsField;
    private string spamRatingField;
    private string statusField;
    private string statusMessageField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private int? threadSizeField;
    private bool threadSizeFieldSpecified;
    private string topicProfileNameField;
    private string topicTypeField;
    private string truncatedContentField;
    private int? uniqueCommentorsField;
    private bool uniqueCommentorsFieldSpecified;
    private UserRecordAccess userRecordAccessField;
    private int? viewCountField;
    private bool viewCountFieldSpecified;
    private ProjectSubmissionsSvcLib.SalesforceService.Name whoField;
    private string whoIdField;

    [XmlElement(IsNullable = true)]
    public double? AnalyzerScore
    {
      get => this.analyzerScoreField;
      set => this.analyzerScoreField = value;
    }

    [XmlIgnore]
    public bool AnalyzerScoreSpecified
    {
      get => this.analyzerScoreFieldSpecified;
      set => this.analyzerScoreFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string AssignedTo
    {
      get => this.assignedToField;
      set => this.assignedToField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AttachmentType
    {
      get => this.attachmentTypeField;
      set => this.attachmentTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AttachmentUrl
    {
      get => this.attachmentUrlField;
      set => this.attachmentUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Attachments
    {
      get => this.attachmentsField;
      set => this.attachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Classification
    {
      get => this.classificationField;
      set => this.classificationField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
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
    public string Content
    {
      get => this.contentField;
      set => this.contentField = value;
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
    public User DeletedBy
    {
      get => this.deletedByField;
      set => this.deletedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeletedById
    {
      get => this.deletedByIdField;
      set => this.deletedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EngagementLevel
    {
      get => this.engagementLevelField;
      set => this.engagementLevelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalPostId
    {
      get => this.externalPostIdField;
      set => this.externalPostIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedSubscriptionsForEntity
    {
      get => this.feedSubscriptionsForEntityField;
      set => this.feedSubscriptionsForEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Feeds
    {
      get => this.feedsField;
      set => this.feedsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Handle
    {
      get => this.handleField;
      set => this.handleField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? HarvestDate
    {
      get => this.harvestDateField;
      set => this.harvestDateField = value;
    }

    [XmlIgnore]
    public bool HarvestDateSpecified
    {
      get => this.harvestDateFieldSpecified;
      set => this.harvestDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Headline
    {
      get => this.headlineField;
      set => this.headlineField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? InboundLinkCount
    {
      get => this.inboundLinkCountField;
      set => this.inboundLinkCountField = value;
    }

    [XmlIgnore]
    public bool InboundLinkCountSpecified
    {
      get => this.inboundLinkCountFieldSpecified;
      set => this.inboundLinkCountFieldSpecified = value;
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
    public bool? IsOutbound
    {
      get => this.isOutboundField;
      set => this.isOutboundField = value;
    }

    [XmlIgnore]
    public bool IsOutboundSpecified
    {
      get => this.isOutboundFieldSpecified;
      set => this.isOutboundFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string KeywordGroupName
    {
      get => this.keywordGroupNameField;
      set => this.keywordGroupNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Language
    {
      get => this.languageField;
      set => this.languageField = value;
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
    public string LikedBy
    {
      get => this.likedByField;
      set => this.likedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? LikesAndVotes
    {
      get => this.likesAndVotesField;
      set => this.likesAndVotesField = value;
    }

    [XmlIgnore]
    public bool LikesAndVotesSpecified
    {
      get => this.likesAndVotesFieldSpecified;
      set => this.likesAndVotesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MediaProvider
    {
      get => this.mediaProviderField;
      set => this.mediaProviderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MediaType
    {
      get => this.mediaTypeField;
      set => this.mediaTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MessageType
    {
      get => this.messageTypeField;
      set => this.messageTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Notes
    {
      get => this.notesField;
      set => this.notesField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult NotesAndAttachments
    {
      get => this.notesAndAttachmentsField;
      set => this.notesAndAttachmentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public ExternalSocialAccount OutboundSocialAccount
    {
      get => this.outboundSocialAccountField;
      set => this.outboundSocialAccountField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OutboundSocialAccountId
    {
      get => this.outboundSocialAccountIdField;
      set => this.outboundSocialAccountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name Owner
    {
      get => this.ownerField;
      set => this.ownerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OwnerId
    {
      get => this.ownerIdField;
      set => this.ownerIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name Parent
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
    public SocialPersona Persona
    {
      get => this.personaField;
      set => this.personaField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PersonaId
    {
      get => this.personaIdField;
      set => this.personaIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Personas
    {
      get => this.personasField;
      set => this.personasField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PostPriority
    {
      get => this.postPriorityField;
      set => this.postPriorityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PostTags
    {
      get => this.postTagsField;
      set => this.postTagsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PostUrl
    {
      get => this.postUrlField;
      set => this.postUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? Posted
    {
      get => this.postedField;
      set => this.postedField = value;
    }

    [XmlIgnore]
    public bool PostedSpecified
    {
      get => this.postedFieldSpecified;
      set => this.postedFieldSpecified = value;
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
    public string Provider
    {
      get => this.providerField;
      set => this.providerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string R6PostId
    {
      get => this.r6PostIdField;
      set => this.r6PostIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string R6SourceId
    {
      get => this.r6SourceIdField;
      set => this.r6SourceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string R6TopicId
    {
      get => this.r6TopicIdField;
      set => this.r6TopicIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Recipient
    {
      get => this.recipientField;
      set => this.recipientField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecipientType
    {
      get => this.recipientTypeField;
      set => this.recipientTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Replies
    {
      get => this.repliesField;
      set => this.repliesField = value;
    }

    [XmlElement(IsNullable = true)]
    public SocialPost ReplyTo
    {
      get => this.replyToField;
      set => this.replyToField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ReplyToId
    {
      get => this.replyToIdField;
      set => this.replyToIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ResponseContextExternalId
    {
      get => this.responseContextExternalIdField;
      set => this.responseContextExternalIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ReviewScale
    {
      get => this.reviewScaleField;
      set => this.reviewScaleField = value;
    }

    [XmlIgnore]
    public bool ReviewScaleSpecified
    {
      get => this.reviewScaleFieldSpecified;
      set => this.reviewScaleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ReviewScore
    {
      get => this.reviewScoreField;
      set => this.reviewScoreField = value;
    }

    [XmlIgnore]
    public bool ReviewScoreSpecified
    {
      get => this.reviewScoreFieldSpecified;
      set => this.reviewScoreFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Sentiment
    {
      get => this.sentimentField;
      set => this.sentimentField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Shares
    {
      get => this.sharesField;
      set => this.sharesField = value;
    }

    [XmlIgnore]
    public bool SharesSpecified
    {
      get => this.sharesFieldSpecified;
      set => this.sharesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceTags
    {
      get => this.sourceTagsField;
      set => this.sourceTagsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SpamRating
    {
      get => this.spamRatingField;
      set => this.spamRatingField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string StatusMessage
    {
      get => this.statusMessageField;
      set => this.statusMessageField = value;
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
    public int? ThreadSize
    {
      get => this.threadSizeField;
      set => this.threadSizeField = value;
    }

    [XmlIgnore]
    public bool ThreadSizeSpecified
    {
      get => this.threadSizeFieldSpecified;
      set => this.threadSizeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TopicProfileName
    {
      get => this.topicProfileNameField;
      set => this.topicProfileNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TopicType
    {
      get => this.topicTypeField;
      set => this.topicTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string TruncatedContent
    {
      get => this.truncatedContentField;
      set => this.truncatedContentField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? UniqueCommentors
    {
      get => this.uniqueCommentorsField;
      set => this.uniqueCommentorsField = value;
    }

    [XmlIgnore]
    public bool UniqueCommentorsSpecified
    {
      get => this.uniqueCommentorsFieldSpecified;
      set => this.uniqueCommentorsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? ViewCount
    {
      get => this.viewCountField;
      set => this.viewCountField = value;
    }

    [XmlIgnore]
    public bool ViewCountSpecified
    {
      get => this.viewCountFieldSpecified;
      set => this.viewCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public ProjectSubmissionsSvcLib.SalesforceService.Name Who
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
