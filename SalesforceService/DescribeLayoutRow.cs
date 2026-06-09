// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeLayoutRow
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class DescribeLayoutRow
  {
    private DescribeLayoutItem[] layoutItemsField;
    private int numItemsField;

    [XmlElement("layoutItems")]
    public DescribeLayoutItem[] layoutItems
    {
      get => this.layoutItemsField;
      set => this.layoutItemsField = value;
    }

    public int numItems
    {
      get => this.numItemsField;
      set => this.numItemsField = value;
    }
  }
}
