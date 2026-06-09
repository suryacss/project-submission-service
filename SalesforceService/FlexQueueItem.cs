// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FlexQueueItem
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
  public class FlexQueueItem : sObject
  {
    private AsyncApexJob asyncApexJobField;
    private string asyncApexJobIdField;
    private string flexQueueItemIdField;
    private int? jobPositionField;
    private bool jobPositionFieldSpecified;
    private string jobTypeField;

    [XmlElement(IsNullable = true)]
    public AsyncApexJob AsyncApexJob
    {
      get => this.asyncApexJobField;
      set => this.asyncApexJobField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AsyncApexJobId
    {
      get => this.asyncApexJobIdField;
      set => this.asyncApexJobIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FlexQueueItemId
    {
      get => this.flexQueueItemIdField;
      set => this.flexQueueItemIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? JobPosition
    {
      get => this.jobPositionField;
      set => this.jobPositionField = value;
    }

    [XmlIgnore]
    public bool JobPositionSpecified
    {
      get => this.jobPositionFieldSpecified;
      set => this.jobPositionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string JobType
    {
      get => this.jobTypeField;
      set => this.jobTypeField = value;
    }
  }
}
