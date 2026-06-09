// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeCompactLayoutsResult
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
  public class DescribeCompactLayoutsResult
  {
    private DescribeCompactLayout[] compactLayoutsField;
    private string defaultCompactLayoutIdField;
    private RecordTypeCompactLayoutMapping[] recordTypeCompactLayoutMappingsField;

    [XmlElement("compactLayouts")]
    public DescribeCompactLayout[] compactLayouts
    {
      get => this.compactLayoutsField;
      set => this.compactLayoutsField = value;
    }

    public string defaultCompactLayoutId
    {
      get => this.defaultCompactLayoutIdField;
      set => this.defaultCompactLayoutIdField = value;
    }

    [XmlElement("recordTypeCompactLayoutMappings")]
    public RecordTypeCompactLayoutMapping[] recordTypeCompactLayoutMappings
    {
      get => this.recordTypeCompactLayoutMappingsField;
      set => this.recordTypeCompactLayoutMappingsField = value;
    }
  }
}
