// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PicklistEntry
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
  public class PicklistEntry
  {
    private bool activeField;
    private bool defaultValueField;
    private string labelField;
    private byte[] validForField;
    private string valueField;

    public bool active
    {
      get => this.activeField;
      set => this.activeField = value;
    }

    public bool defaultValue
    {
      get => this.defaultValueField;
      set => this.defaultValueField = value;
    }

    [XmlElement(IsNullable = true)]
    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(DataType = "base64Binary")]
    public byte[] validFor
    {
      get => this.validForField;
      set => this.validForField = value;
    }

    public string value
    {
      get => this.valueField;
      set => this.valueField = value;
    }
  }
}
