// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeLayoutResult
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
  public class DescribeLayoutResult
  {
    private DescribeLayout[] layoutsField;
    private RecordTypeMapping[] recordTypeMappingsField;
    private bool recordTypeSelectorRequiredField;

    [XmlElement("layouts")]
    public DescribeLayout[] layouts
    {
      get => this.layoutsField;
      set => this.layoutsField = value;
    }

    [XmlElement("recordTypeMappings")]
    public RecordTypeMapping[] recordTypeMappings
    {
      get => this.recordTypeMappingsField;
      set => this.recordTypeMappingsField = value;
    }

    public bool recordTypeSelectorRequired
    {
      get => this.recordTypeSelectorRequiredField;
      set => this.recordTypeSelectorRequiredField = value;
    }
  }
}
