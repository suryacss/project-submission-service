// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeLayoutSaveOption
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class DescribeLayoutSaveOption
  {
    private bool defaultValueField;
    private bool isDisplayedField;
    private string labelField;
    private string nameField;
    private string restHeaderNameField;
    private string soapHeaderNameField;

    public bool defaultValue
    {
      get => this.defaultValueField;
      set => this.defaultValueField = value;
    }

    public bool isDisplayed
    {
      get => this.isDisplayedField;
      set => this.isDisplayedField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string restHeaderName
    {
      get => this.restHeaderNameField;
      set => this.restHeaderNameField = value;
    }

    public string soapHeaderName
    {
      get => this.soapHeaderNameField;
      set => this.soapHeaderNameField = value;
    }
  }
}
