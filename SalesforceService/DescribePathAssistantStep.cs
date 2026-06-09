// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribePathAssistantStep
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class DescribePathAssistantStep
  {
    private bool closedField;
    private bool convertedField;
    private DescribePathAssistantField[] fieldsField;
    private string infoField;
    private DescribeLayoutSection layoutSectionField;
    private string picklistLabelField;
    private string picklistValueField;
    private bool wonField;

    public bool closed
    {
      get => this.closedField;
      set => this.closedField = value;
    }

    public bool converted
    {
      get => this.convertedField;
      set => this.convertedField = value;
    }

    [XmlElement("fields")]
    public DescribePathAssistantField[] fields
    {
      get => this.fieldsField;
      set => this.fieldsField = value;
    }

    public string info
    {
      get => this.infoField;
      set => this.infoField = value;
    }

    public DescribeLayoutSection layoutSection
    {
      get => this.layoutSectionField;
      set => this.layoutSectionField = value;
    }

    public string picklistLabel
    {
      get => this.picklistLabelField;
      set => this.picklistLabelField = value;
    }

    public string picklistValue
    {
      get => this.picklistValueField;
      set => this.picklistValueField = value;
    }

    public bool won
    {
      get => this.wonField;
      set => this.wonField = value;
    }
  }
}
