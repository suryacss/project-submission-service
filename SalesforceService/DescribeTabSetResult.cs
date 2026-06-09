// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeTabSetResult
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class DescribeTabSetResult
  {
    private string descriptionField;
    private string labelField;
    private string logoUrlField;
    private string namespaceField;
    private bool selectedField;
    private string tabSetIdField;
    private DescribeTab[] tabsField;

    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public string logoUrl
    {
      get => this.logoUrlField;
      set => this.logoUrlField = value;
    }

    public string @namespace
    {
      get => this.namespaceField;
      set => this.namespaceField = value;
    }

    public bool selected
    {
      get => this.selectedField;
      set => this.selectedField = value;
    }

    public string tabSetId
    {
      get => this.tabSetIdField;
      set => this.tabSetIdField = value;
    }

    [XmlElement("tabs")]
    public DescribeTab[] tabs
    {
      get => this.tabsField;
      set => this.tabsField = value;
    }
  }
}
