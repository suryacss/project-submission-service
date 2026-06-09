// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeDataCategoryGroupStructureResult
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
  public class DescribeDataCategoryGroupStructureResult
  {
    private string descriptionField;
    private string labelField;
    private string nameField;
    private string sobjectField;
    private DataCategory[] topCategoriesField;

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

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string sobject
    {
      get => this.sobjectField;
      set => this.sobjectField = value;
    }

    [XmlElement("topCategories")]
    public DataCategory[] topCategories
    {
      get => this.topCategoriesField;
      set => this.topCategoriesField = value;
    }
  }
}
