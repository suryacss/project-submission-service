// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RecordTypeCompactLayoutMapping
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class RecordTypeCompactLayoutMapping
  {
    private bool availableField;
    private string compactLayoutIdField;
    private string compactLayoutNameField;
    private string recordTypeIdField;
    private string recordTypeNameField;

    public bool available
    {
      get => this.availableField;
      set => this.availableField = value;
    }

    [XmlElement(IsNullable = true)]
    public string compactLayoutId
    {
      get => this.compactLayoutIdField;
      set => this.compactLayoutIdField = value;
    }

    public string compactLayoutName
    {
      get => this.compactLayoutNameField;
      set => this.compactLayoutNameField = value;
    }

    public string recordTypeId
    {
      get => this.recordTypeIdField;
      set => this.recordTypeIdField = value;
    }

    public string recordTypeName
    {
      get => this.recordTypeNameField;
      set => this.recordTypeNameField = value;
    }
  }
}
