// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.IdeaComment
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class IdeaComment : sObject
  {
    private string commentBodyField;
    private string communityIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string creatorFullPhotoUrlField;
    private string creatorNameField;
    private string creatorSmallPhotoUrlField;
    private Idea ideaField;
    private string ideaIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isHtmlField;
    private bool isHtmlFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private int? upVotesField;
    private bool upVotesFieldSpecified;
    private QueryResult votesField;

    [XmlElement(IsNullable = true)]
    public string CommentBody
    {
      get => this.commentBodyField;
      set => this.commentBodyField = value;
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
    public Idea Idea
    {
      get => this.ideaField;
      set => this.ideaField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IdeaId
    {
      get => this.ideaIdField;
      set => this.ideaIdField = value;
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
    public int? UpVotes
    {
      get => this.upVotesField;
      set => this.upVotesField = value;
    }

    [XmlIgnore]
    public bool UpVotesSpecified
    {
      get => this.upVotesFieldSpecified;
      set => this.upVotesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult Votes
    {
      get => this.votesField;
      set => this.votesField = value;
    }
  }
}
