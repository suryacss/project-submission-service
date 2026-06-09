// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeLayout
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class DescribeLayout
  {
    private DescribeLayoutButton[] buttonLayoutSectionField;
    private DescribeLayoutSection[] detailLayoutSectionsField;
    private DescribeLayoutSection[] editLayoutSectionsField;
    private DescribeLayoutFeedFilter[] feedViewField;
    private DescribeLayoutSection highlightsPanelLayoutSectionField;
    private string idField;
    private DescribeQuickActionListItemResult[] quickActionListField;
    private DescribeRelatedContentItem[] relatedContentField;
    private RelatedList[] relatedListsField;
    private DescribeLayoutSaveOption[] saveOptionsField;

    [XmlArrayItem("detailButtons", IsNullable = false)]
    public DescribeLayoutButton[] buttonLayoutSection
    {
      get => this.buttonLayoutSectionField;
      set => this.buttonLayoutSectionField = value;
    }

    [XmlElement("detailLayoutSections")]
    public DescribeLayoutSection[] detailLayoutSections
    {
      get => this.detailLayoutSectionsField;
      set => this.detailLayoutSectionsField = value;
    }

    [XmlElement("editLayoutSections")]
    public DescribeLayoutSection[] editLayoutSections
    {
      get => this.editLayoutSectionsField;
      set => this.editLayoutSectionsField = value;
    }

    [XmlArrayItem("feedFilters", IsNullable = false)]
    public DescribeLayoutFeedFilter[] feedView
    {
      get => this.feedViewField;
      set => this.feedViewField = value;
    }

    public DescribeLayoutSection highlightsPanelLayoutSection
    {
      get => this.highlightsPanelLayoutSectionField;
      set => this.highlightsPanelLayoutSectionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [XmlArrayItem("quickActionListItems", IsNullable = false)]
    public DescribeQuickActionListItemResult[] quickActionList
    {
      get => this.quickActionListField;
      set => this.quickActionListField = value;
    }

    [XmlArrayItem("relatedContentItems", IsNullable = false)]
    public DescribeRelatedContentItem[] relatedContent
    {
      get => this.relatedContentField;
      set => this.relatedContentField = value;
    }

    [XmlElement("relatedLists")]
    public RelatedList[] relatedLists
    {
      get => this.relatedListsField;
      set => this.relatedListsField = value;
    }

    [XmlElement("saveOptions")]
    public DescribeLayoutSaveOption[] saveOptions
    {
      get => this.saveOptionsField;
      set => this.saveOptionsField = value;
    }
  }
}
