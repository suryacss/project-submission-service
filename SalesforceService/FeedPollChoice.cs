// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FeedPollChoice
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
  public class FeedPollChoice : sObject
  {
    private string choiceBodyField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string feedItemIdField;
    private QueryResult feedPollVotesField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private int? positionField;
    private bool positionFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string ChoiceBody
    {
      get => this.choiceBodyField;
      set => this.choiceBodyField = value;
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
    public string FeedItemId
    {
      get => this.feedItemIdField;
      set => this.feedItemIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult FeedPollVotes
    {
      get => this.feedPollVotesField;
      set => this.feedPollVotesField = value;
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
    public int? Position
    {
      get => this.positionField;
      set => this.positionField = value;
    }

    [XmlIgnore]
    public bool PositionSpecified
    {
      get => this.positionFieldSpecified;
      set => this.positionFieldSpecified = value;
    }
  }
}
