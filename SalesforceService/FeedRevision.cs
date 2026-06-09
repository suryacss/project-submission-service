// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FeedRevision
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class FeedRevision : sObject
  {
    private string actionField;
    private Name createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string editedAttributeField;
    private string feedEntityIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isValueRichTextField;
    private bool isValueRichTextFieldSpecified;
    private int? revisionField;
    private bool revisionFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string valueField;

    [XmlElement(IsNullable = true)]
    public string Action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name CreatedBy
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
    public string EditedAttribute
    {
      get => this.editedAttributeField;
      set => this.editedAttributeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FeedEntityId
    {
      get => this.feedEntityIdField;
      set => this.feedEntityIdField = value;
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
    public bool? IsValueRichText
    {
      get => this.isValueRichTextField;
      set => this.isValueRichTextField = value;
    }

    [XmlIgnore]
    public bool IsValueRichTextSpecified
    {
      get => this.isValueRichTextFieldSpecified;
      set => this.isValueRichTextFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? Revision
    {
      get => this.revisionField;
      set => this.revisionField = value;
    }

    [XmlIgnore]
    public bool RevisionSpecified
    {
      get => this.revisionFieldSpecified;
      set => this.revisionFieldSpecified = value;
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
    public string Value
    {
      get => this.valueField;
      set => this.valueField = value;
    }
  }
}
