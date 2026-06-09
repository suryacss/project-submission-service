// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RecordTypeMapping
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class RecordTypeMapping
  {
    private bool availableField;
    private bool defaultRecordTypeMappingField;
    private string layoutIdField;
    private bool masterField;
    private string nameField;
    private PicklistForRecordType[] picklistsForRecordTypeField;
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

    public string layoutId
    {
      get => this.layoutIdField;
      set => this.layoutIdField = value;
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

    [XmlElement("picklistsForRecordType", IsNullable = true)]
    public PicklistForRecordType[] picklistsForRecordType
    {
      get => this.picklistsForRecordTypeField;
      set => this.picklistsForRecordTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string recordTypeId
    {
      get => this.recordTypeIdField;
      set => this.recordTypeIdField = value;
    }
  }
}
