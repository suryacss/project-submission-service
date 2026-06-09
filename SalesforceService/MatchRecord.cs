// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.MatchRecord
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class MatchRecord
  {
    private AdditionalInformationMap[] additionalInformationField;
    private FieldDiff[] fieldDiffsField;
    private double matchConfidenceField;
    private sObject recordField;

    [XmlElement("additionalInformation")]
    public AdditionalInformationMap[] additionalInformation
    {
      get => this.additionalInformationField;
      set => this.additionalInformationField = value;
    }

    [XmlElement("fieldDiffs")]
    public FieldDiff[] fieldDiffs
    {
      get => this.fieldDiffsField;
      set => this.fieldDiffsField = value;
    }

    public double matchConfidence
    {
      get => this.matchConfidenceField;
      set => this.matchConfidenceField = value;
    }

    public sObject record
    {
      get => this.recordField;
      set => this.recordField = value;
    }
  }
}
