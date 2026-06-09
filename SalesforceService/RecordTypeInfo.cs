// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RecordTypeInfo
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class RecordTypeInfo
  {
    private bool availableField;
    private bool defaultRecordTypeMappingField;
    private bool masterField;
    private string nameField;
    private string recordTypeIdField;

    public bool available
    {
      get => this.availableField;
      set => this.availableField = value;
    }

    public bool defaultRecordTypeMapping
    {
      get => this.defaultRecordTypeMappingField;
      set => this.defaultRecordTypeMappingField = value;
    }

    public bool master
    {
      get => this.masterField;
      set => this.masterField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string recordTypeId
    {
      get => this.recordTypeIdField;
      set => this.recordTypeIdField = value;
    }
  }
}
