// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.MergeRequest
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class MergeRequest
  {
    private AdditionalInformationMap[] additionalInformationMapField;
    private sObject masterRecordField;
    private string[] recordToMergeIdsField;

    [XmlElement("additionalInformationMap")]
    public AdditionalInformationMap[] additionalInformationMap
    {
      get => this.additionalInformationMapField;
      set => this.additionalInformationMapField = value;
    }

    public sObject masterRecord
    {
      get => this.masterRecordField;
      set => this.masterRecordField = value;
    }

    [XmlElement("recordToMergeIds")]
    public string[] recordToMergeIds
    {
      get => this.recordToMergeIdsField;
      set => this.recordToMergeIdsField = value;
    }
  }
}
