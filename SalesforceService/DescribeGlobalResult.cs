// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeGlobalResult
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
  public class DescribeGlobalResult
  {
    private string encodingField;
    private int maxBatchSizeField;
    private DescribeGlobalSObjectResult[] sobjectsField;

    [XmlElement(IsNullable = true)]
    public string encoding
    {
      get => this.encodingField;
      set => this.encodingField = value;
    }

    public int maxBatchSize
    {
      get => this.maxBatchSizeField;
      set => this.maxBatchSizeField = value;
    }

    [XmlElement("sobjects")]
    public DescribeGlobalSObjectResult[] sobjects
    {
      get => this.sobjectsField;
      set => this.sobjectsField = value;
    }
  }
}
