// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ChatterActivity
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class ChatterActivity : sObject
  {
    private int? commentCountField;
    private bool commentCountFieldSpecified;
    private int? commentReceivedCountField;
    private bool commentReceivedCountFieldSpecified;
    private int? influenceRawRankField;
    private bool influenceRawRankFieldSpecified;
    private int? likeReceivedCountField;
    private bool likeReceivedCountFieldSpecified;
    private string parentIdField;
    private int? postCountField;
    private bool postCountFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

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
    public int? CommentReceivedCount
    {
      get => this.commentReceivedCountField;
      set => this.commentReceivedCountField = value;
    }

    [XmlIgnore]
    public bool CommentReceivedCountSpecified
    {
      get => this.commentReceivedCountFieldSpecified;
      set => this.commentReceivedCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? InfluenceRawRank
    {
      get => this.influenceRawRankField;
      set => this.influenceRawRankField = value;
    }

    [XmlIgnore]
    public bool InfluenceRawRankSpecified
    {
      get => this.influenceRawRankFieldSpecified;
      set => this.influenceRawRankFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? LikeReceivedCount
    {
      get => this.likeReceivedCountField;
      set => this.likeReceivedCountField = value;
    }

    [XmlIgnore]
    public bool LikeReceivedCountSpecified
    {
      get => this.likeReceivedCountFieldSpecified;
      set => this.likeReceivedCountFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentId
    {
      get => this.parentIdField;
      set => this.parentIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? PostCount
    {
      get => this.postCountField;
      set => this.postCountField = value;
    }

    [XmlIgnore]
    public bool PostCountSpecified
    {
      get => this.postCountFieldSpecified;
      set => this.postCountFieldSpecified = value;
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
