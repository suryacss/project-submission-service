// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.SoqlCondition
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
  public class SoqlCondition : SoqlWhereCondition
  {
    private string fieldField;
    private soqlOperator operatorField;
    private string[] valuesField;

    public string field
    {
      get => this.fieldField;
      set => this.fieldField = value;
    }

    public soqlOperator @operator
    {
      get => this.operatorField;
      set => this.operatorField = value;
    }

    [XmlElement("values")]
    public string[] values
    {
      get => this.valuesField;
      set => this.valuesField = value;
    }
  }
}
