// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SocialPostHistory
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
  public class SocialPostHistory : sObject
  {
    private Name createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string fieldField;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private object newValueField;
    private object oldValueField;
    private SocialPost socialPostField;
    private string socialPostIdField;

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
    public string Field
    {
      get => this.fieldField;
      set => this.fieldField = value;
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
    public object NewValue
    {
      get => this.newValueField;
      set => this.newValueField = value;
    }

    [XmlElement(IsNullable = true)]
    public object OldValue
    {
      get => this.oldValueField;
      set => this.oldValueField = value;
    }

    [XmlElement(IsNullable = true)]
    public SocialPost SocialPost
    {
      get => this.socialPostField;
      set => this.socialPostField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SocialPostId
    {
      get => this.socialPostIdField;
      set => this.socialPostIdField = value;
    }
  }
}
