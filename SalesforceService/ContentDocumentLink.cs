// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ContentDocumentLink
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
  public class ContentDocumentLink : sObject
  {
    private ContentDocument contentDocumentField;
    private string contentDocumentIdField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private Name linkedEntityField;
    private string linkedEntityIdField;
    private string shareTypeField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string visibilityField;

    [XmlElement(IsNullable = true)]
    public ContentDocument ContentDocument
    {
      get => this.contentDocumentField;
      set => this.contentDocumentField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContentDocumentId
    {
      get => this.contentDocumentIdField;
      set => this.contentDocumentIdField = value;
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
    public Name LinkedEntity
    {
      get => this.linkedEntityField;
      set => this.linkedEntityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LinkedEntityId
    {
      get => this.linkedEntityIdField;
      set => this.linkedEntityIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ShareType
    {
      get => this.shareTypeField;
      set => this.shareTypeField = value;
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
    public string Visibility
    {
      get => this.visibilityField;
      set => this.visibilityField = value;
    }
  }
}
