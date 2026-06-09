// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribePathAssistant
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
  public class DescribePathAssistant
  {
    private bool activeField;
    private string apiNameField;
    private string labelField;
    private string pathPicklistFieldField;
    private PicklistForRecordType[] picklistsForRecordTypeField;
    private string recordTypeIdField;
    private DescribePathAssistantStep[] stepsField;

    public bool active
    {
      get => this.activeField;
      set => this.activeField = value;
    }

    public string apiName
    {
      get => this.apiNameField;
      set => this.apiNameField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public string pathPicklistField
    {
      get => this.pathPicklistFieldField;
      set => this.pathPicklistFieldField = value;
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

    [XmlElement("steps")]
    public DescribePathAssistantStep[] steps
    {
      get => this.stepsField;
      set => this.stepsField = value;
    }
  }
}
