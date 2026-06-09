// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.QueryResult
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
  public class QueryResult
  {
    private bool doneField;
    private string queryLocatorField;
    private sObject[] recordsField;
    private int sizeField;

    public bool done
    {
      get => this.doneField;
      set => this.doneField = value;
    }

    [XmlElement(IsNullable = true)]
    public string queryLocator
    {
      get => this.queryLocatorField;
      set => this.queryLocatorField = value;
    }

    [XmlElement("records", IsNullable = true)]
    public sObject[] records
    {
      get => this.recordsField;
      set => this.recordsField = value;
    }

    public int size
    {
      get => this.sizeField;
      set => this.sizeField = value;
    }
  }
}
