// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribePathAssistantField
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class DescribePathAssistantField
  {
    private string apiNameField;
    private string labelField;
    private bool readOnlyField;
    private bool requiredField;

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

    public bool readOnly
    {
      get => this.readOnlyField;
      set => this.readOnlyField = value;
    }

    public bool required
    {
      get => this.requiredField;
      set => this.requiredField = value;
    }
  }
}
