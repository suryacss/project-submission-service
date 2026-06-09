// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FeedTrackedChange
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class FeedTrackedChange : sObject
  {
    private string feedItemIdField;
    private string fieldNameField;
    private object newValueField;
    private object oldValueField;

    [XmlElement(IsNullable = true)]
    public string FeedItemId
    {
      get => this.feedItemIdField;
      set => this.feedItemIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FieldName
    {
      get => this.fieldNameField;
      set => this.fieldNameField = value;
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
  }
}
