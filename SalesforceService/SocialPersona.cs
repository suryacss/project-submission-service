// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SocialPersona
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
  public class SocialPersona : sObject
  {
    private bool? areWeFollowingField;
    private bool areWeFollowingFieldSpecified;
    private string bioField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string externalIdField;
    private string externalPictureURLField;
    private int? followersField;
    private bool followersFieldSpecified;
    private int? followingField;
    private bool followingFieldSpecified;
    private QueryResult historiesField;
    private bool? isBlacklistedField;
    private bool isBlacklistedFieldSpecified;
    private bool? isDefaultField;
    private bool isDefaultFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isFollowingUsField;
    private bool isFollowingUsFieldSpecified;
    private double? kloutField;
    private bool kloutFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private int? listedCountField;
    private bool listedCountFieldSpecified;
    private string mediaProviderField;
    private string mediaTypeField;
    private string nameField;
    private int? numberOfFriendsField;
    private bool numberOfFriendsFieldSpecified;
    private int? numberOfTweetsField;
    private bool numberOfTweetsFieldSpecified;
    private ProjectSubmissionsSvcLib.SalesforceService.Name parentField;
    private string parentIdField;
    private QueryResult postsField;
    private string profileTypeField;
    private string profileUrlField;
    private string providerField;
    private string r6SourceIdField;
    private string realNameField;
    private string sourceAppField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string topicTypeField;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public bool? AreWeFollowing
    {
      get => this.areWeFollowingField;
      set => this.areWeFollowingField = value;
    }

    [XmlIgnore]
    public bool AreWeFollowingSpecified
    {
      get => this.areWeFollowingFieldSpecified;
      set => this.areWeFollowingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Bio
    {
      get => this.bioField;
      set => this.bioField = value;
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
    public string ExternalId
    {
      get => this.externalIdField;
      set => this.externalIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalPictureURL
    {
      get => this.externalPictureURLField;
      set => this.externalPictureURLField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Followers
    {
      get => this.followersField;
      set => this.followersField = value;
    }

    [XmlIgnore]
    public bool FollowersSpecified
    {
      get => this.followersFieldSpecified;
      set => this.followersFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Following
    {
      get => this.followingField;
      set => this.followingField = value;
    }

    [XmlIgnore]
    public bool FollowingSpecified
    {
      get => this.followingFieldSpecified;
      set => this.followingFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Histories
    {
      get => this.historiesField;
      set => this.historiesField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsBlacklisted
    {
      get => this.isBlacklistedField;
      set => this.isBlacklistedField = value;
    }

    [XmlIgnore]
    public bool IsBlacklistedSpecified
    {
      get => this.isBlacklistedFieldSpecified;
      set => this.isBlacklistedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDefault
    {
      get => this.isDefaultField;
      set => this.isDefaultField = value;
    }

    [XmlIgnore]
    public bool IsDefaultSpecified
    {
      get => this.isDefaultFieldSpecified;
      set => this.isDefaultFieldSpecified = value;
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
    public bool? IsFollowingUs
    {
      get => this.isFollowingUsField;
      set => this.isFollowingUsField = value;
    }

    [XmlIgnore]
    public bool IsFollowingUsSpecified
    {
      get => this.isFollowingUsFieldSpecified;
      set => this.isFollowingUsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Klout
    {
      get => this.kloutField;
      set => this.kloutField = value;
    }

    [XmlIgnore]
    public bool KloutSpecified
    {
      get => this.kloutFieldSpecified;
      set => this.kloutFieldSpecified = value;
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
    public int? ListedCount
    {
      get => this.listedCountField;
      set => this.listedCountField = value;
    }

    [XmlIgnore]
    public bool ListedCountSpecified
    {
      get => this.listedCountFieldSpecified;
      set => this.listedCountFieldSpecified = value;
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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfFriends
    {
      get => this.numberOfFriendsField;
      set => this.numberOfFriendsField = value;
    }

    [XmlIgnore]
    public bool NumberOfFriendsSpecified
    {
      get => this.numberOfFriendsFieldSpecified;
      set => this.numberOfFriendsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? NumberOfTweets
    {
      get => this.numberOfTweetsField;
      set => this.numberOfTweetsField = value;
    }

    [XmlIgnore]
    public bool NumberOfTweetsSpecified
    {
      get => this.numberOfTweetsFieldSpecified;
      set => this.numberOfTweetsFieldSpecified = value;
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
    public QueryResult Posts
    {
      get => this.postsField;
      set => this.postsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProfileType
    {
      get => this.profileTypeField;
      set => this.profileTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ProfileUrl
    {
      get => this.profileUrlField;
      set => this.profileUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Provider
    {
      get => this.providerField;
      set => this.providerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string R6SourceId
    {
      get => this.r6SourceIdField;
      set => this.r6SourceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RealName
    {
      get => this.realNameField;
      set => this.realNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SourceApp
    {
      get => this.sourceAppField;
      set => this.sourceAppField = value;
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
    public string TopicType
    {
      get => this.topicTypeField;
      set => this.topicTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
