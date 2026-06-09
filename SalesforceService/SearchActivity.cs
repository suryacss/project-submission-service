// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SearchActivity
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
  public class SearchActivity : sObject
  {
    private double? avgNumResultsField;
    private bool avgNumResultsFieldSpecified;
    private double? clickRankField;
    private bool clickRankFieldSpecified;
    private string clickedRecordNameField;
    private int? countQueriesField;
    private bool countQueriesFieldSpecified;
    private int? countUsersField;
    private bool countUsersFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private string kbChannelField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string nameField;
    private string periodField;
    private DateTime? queryDateField;
    private bool queryDateFieldSpecified;
    private string queryLanguageField;
    private string searchTermField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private UserRecordAccess userRecordAccessField;

    [XmlElement(IsNullable = true)]
    public double? AvgNumResults
    {
      get => this.avgNumResultsField;
      set => this.avgNumResultsField = value;
    }

    [XmlIgnore]
    public bool AvgNumResultsSpecified
    {
      get => this.avgNumResultsFieldSpecified;
      set => this.avgNumResultsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ClickRank
    {
      get => this.clickRankField;
      set => this.clickRankField = value;
    }

    [XmlIgnore]
    public bool ClickRankSpecified
    {
      get => this.clickRankFieldSpecified;
      set => this.clickRankFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string ClickedRecordName
    {
      get => this.clickedRecordNameField;
      set => this.clickedRecordNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? CountQueries
    {
      get => this.countQueriesField;
      set => this.countQueriesField = value;
    }

    [XmlIgnore]
    public bool CountQueriesSpecified
    {
      get => this.countQueriesFieldSpecified;
      set => this.countQueriesFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? CountUsers
    {
      get => this.countUsersField;
      set => this.countUsersField = value;
    }

    [XmlIgnore]
    public bool CountUsersSpecified
    {
      get => this.countUsersFieldSpecified;
      set => this.countUsersFieldSpecified = value;
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
    public string KbChannel
    {
      get => this.kbChannelField;
      set => this.kbChannelField = value;
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
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Period
    {
      get => this.periodField;
      set => this.periodField = value;
    }

    [XmlElement(DataType = "date", IsNullable = true)]
    public DateTime? QueryDate
    {
      get => this.queryDateField;
      set => this.queryDateField = value;
    }

    [XmlIgnore]
    public bool QueryDateSpecified
    {
      get => this.queryDateFieldSpecified;
      set => this.queryDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string QueryLanguage
    {
      get => this.queryLanguageField;
      set => this.queryLanguageField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SearchTerm
    {
      get => this.searchTermField;
      set => this.searchTermField = value;
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
    public UserRecordAccess UserRecordAccess
    {
      get => this.userRecordAccessField;
      set => this.userRecordAccessField = value;
    }
  }
}
