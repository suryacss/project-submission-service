// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.Dashboard
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
  public class Dashboard : sObject
  {
    private QueryResult attachedContentDocumentsField;
    private string backgroundDirectionField;
    private int? backgroundEndField;
    private bool backgroundEndFieldSpecified;
    private int? backgroundStartField;
    private bool backgroundStartFieldSpecified;
    private QueryResult combinedAttachmentsField;
    private QueryResult contentDocumentLinksField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private QueryResult dashboardComponentsField;
    private string dashboardResultRefreshedDateField;
    private string dashboardResultRunningUserField;
    private string descriptionField;
    private string developerNameField;
    private QueryResult feedSubscriptionsForEntityField;
    private QueryResult feedsField;
    private Folder folderField;
    private string folderIdField;
    private string folderNameField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? lastReferencedDateField;
    private bool lastReferencedDateFieldSpecified;
    private DateTime? lastViewedDateField;
    private bool lastViewedDateFieldSpecified;
    private string leftSizeField;
    private string middleSizeField;
    private string namespacePrefixField;
    private string rightSizeField;
    private User runningUserField;
    private string runningUserIdField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private int? textColorField;
    private bool textColorFieldSpecified;
    private string titleField;
    private int? titleColorField;
    private bool titleColorFieldSpecified;
    private int? titleSizeField;
    private bool titleSizeFieldSpecified;
    private string typeField;

    [XmlElement(IsNullable = true)]
    public QueryResult AttachedContentDocuments
    {
      get => this.attachedContentDocumentsField;
      set => this.attachedContentDocumentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string BackgroundDirection
    {
      get => this.backgroundDirectionField;
      set => this.backgroundDirectionField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? BackgroundEnd
    {
      get => this.backgroundEndField;
      set => this.backgroundEndField = value;
    }

    [XmlIgnore]
    public bool BackgroundEndSpecified
    {
      get => this.backgroundEndFieldSpecified;
      set => this.backgroundEndFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? BackgroundStart
    {
      get => this.backgroundStartField;
      set => this.backgroundStartField = value;
    }

    [XmlIgnore]
    public bool BackgroundStartSpecified
    {
      get => this.backgroundStartFieldSpecified;
      set => this.backgroundStartFieldSpecified = value;
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
    public QueryResult DashboardComponents
    {
      get => this.dashboardComponentsField;
      set => this.dashboardComponentsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DashboardResultRefreshedDate
    {
      get => this.dashboardResultRefreshedDateField;
      set => this.dashboardResultRefreshedDateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DashboardResultRunningUser
    {
      get => this.dashboardResultRunningUserField;
      set => this.dashboardResultRunningUserField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
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
    public Folder Folder
    {
      get => this.folderField;
      set => this.folderField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FolderId
    {
      get => this.folderIdField;
      set => this.folderIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FolderName
    {
      get => this.folderNameField;
      set => this.folderNameField = value;
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
    public string LeftSize
    {
      get => this.leftSizeField;
      set => this.leftSizeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MiddleSize
    {
      get => this.middleSizeField;
      set => this.middleSizeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RightSize
    {
      get => this.rightSizeField;
      set => this.rightSizeField = value;
    }

    [XmlElement(IsNullable = true)]
    public User RunningUser
    {
      get => this.runningUserField;
      set => this.runningUserField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RunningUserId
    {
      get => this.runningUserIdField;
      set => this.runningUserIdField = value;
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
    public int? TextColor
    {
      get => this.textColorField;
      set => this.textColorField = value;
    }

    [XmlIgnore]
    public bool TextColorSpecified
    {
      get => this.textColorFieldSpecified;
      set => this.textColorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Title
    {
      get => this.titleField;
      set => this.titleField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? TitleColor
    {
      get => this.titleColorField;
      set => this.titleColorField = value;
    }

    [XmlIgnore]
    public bool TitleColorSpecified
    {
      get => this.titleColorFieldSpecified;
      set => this.titleColorFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? TitleSize
    {
      get => this.titleSizeField;
      set => this.titleSizeField = value;
    }

    [XmlIgnore]
    public bool TitleSizeSpecified
    {
      get => this.titleSizeFieldSpecified;
      set => this.titleSizeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }
  }
}
