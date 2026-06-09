// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.CollaborationGroup
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class CollaborationGroup : sObject
  {
    private Announcement announcementField;
    private string announcementIdField;
    private QueryResult attachedContentDocumentsField;
    private string bannerPhotoUrlField;
    private bool? canHaveGuestsField;
    private bool canHaveGuestsFieldSpecified;
    private QueryResult collaborationGroupRecordsField;
    private string collaborationTypeField;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private string fullPhotoUrlField;
    private QueryResult groupMemberRequestsField;
    private QueryResult groupMembersField;
    private bool? hasPrivateFieldsAccessField;
    private bool hasPrivateFieldsAccessFieldSpecified;
    private string informationBodyField;
    private string informationTitleField;
    private bool? isArchivedField;
    private bool isArchivedFieldSpecified;
    private bool? isAutoArchiveDisabledField;
    private bool isAutoArchiveDisabledFieldSpecified;
    private bool? isBroadcastField;
    private bool isBroadcastFieldSpecified;
    private DateTime? lastFeedModifiedDateField;
    private bool lastFeedModifiedDateFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private string mediumPhotoUrlField;
    private int? memberCountField;
    private bool memberCountFieldSpecified;
    private string nameField;
    private User ownerField;
    private string ownerIdField;
    private string smallPhotoUrlField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public Announcement Announcement
    {
      get => this.announcementField;
      set => this.announcementField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AnnouncementId
    {
      get => this.announcementIdField;
      set => this.announcementIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BannerPhotoUrl
    {
      get => this.bannerPhotoUrlField;
      set => this.bannerPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? CanHaveGuests
    {
      get => this.canHaveGuestsField;
      set => this.canHaveGuestsField = value;
    }

    [XmlIgnore]
    public bool CanHaveGuestsSpecified
    {
      get => this.canHaveGuestsFieldSpecified;
      set => this.canHaveGuestsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CollaborationGroupRecords
    {
      get => this.collaborationGroupRecordsField;
      set => this.collaborationGroupRecordsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CollaborationType
    {
      get => this.collaborationTypeField;
      set => this.collaborationTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult CombinedAttachments
    {
      get => this.combinedAttachmentsField;
      set => this.combinedAttachmentsField = value;
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
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
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
    public string FullPhotoUrl
    {
      get => this.fullPhotoUrlField;
      set => this.fullPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult GroupMemberRequests
    {
      get => this.groupMemberRequestsField;
      set => this.groupMemberRequestsField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult GroupMembers
    {
      get => this.groupMembersField;
      set => this.groupMembersField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasPrivateFieldsAccess
    {
      get => this.hasPrivateFieldsAccessField;
      set => this.hasPrivateFieldsAccessField = value;
    }

    [XmlIgnore]
    public bool HasPrivateFieldsAccessSpecified
    {
      get => this.hasPrivateFieldsAccessFieldSpecified;
      set => this.hasPrivateFieldsAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string InformationBody
    {
      get => this.informationBodyField;
      set => this.informationBodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string InformationTitle
    {
      get => this.informationTitleField;
      set => this.informationTitleField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsArchived
    {
      get => this.isArchivedField;
      set => this.isArchivedField = value;
    }

    [XmlIgnore]
    public bool IsArchivedSpecified
    {
      get => this.isArchivedFieldSpecified;
      set => this.isArchivedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsAutoArchiveDisabled
    {
      get => this.isAutoArchiveDisabledField;
      set => this.isAutoArchiveDisabledField = value;
    }

    [XmlIgnore]
    public bool IsAutoArchiveDisabledSpecified
    {
      get => this.isAutoArchiveDisabledFieldSpecified;
      set => this.isAutoArchiveDisabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsBroadcast
    {
      get => this.isBroadcastField;
      set => this.isBroadcastField = value;
    }

    [XmlIgnore]
    public bool IsBroadcastSpecified
    {
      get => this.isBroadcastFieldSpecified;
      set => this.isBroadcastFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastFeedModifiedDate
    {
      get => this.lastFeedModifiedDateField;
      set => this.lastFeedModifiedDateField = value;
    }

    [XmlIgnore]
    public bool LastFeedModifiedDateSpecified
    {
      get => this.lastFeedModifiedDateFieldSpecified;
      set => this.lastFeedModifiedDateFieldSpecified = value;
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
    public string MediumPhotoUrl
    {
      get => this.mediumPhotoUrlField;
      set => this.mediumPhotoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? MemberCount
    {
      get => this.memberCountField;
      set => this.memberCountField = value;
    }

    [XmlIgnore]
    public bool MemberCountSpecified
    {
      get => this.memberCountFieldSpecified;
      set => this.memberCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public User Owner
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
    public string SmallPhotoUrl
    {
      get => this.smallPhotoUrlField;
      set => this.smallPhotoUrlField = value;
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
