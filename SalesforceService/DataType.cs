// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DataType
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class DataType : sObject
  {
    private string contextServiceDataTypeIdField;
    private string contextWsdlDataTypeIdField;
    private string developerNameField;
    private string durableIdField;
    private bool? isComplexField;
    private bool isComplexFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string ContextServiceDataTypeId
    {
      get => this.contextServiceDataTypeIdField;
      set => this.contextServiceDataTypeIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ContextWsdlDataTypeId
    {
      get => this.contextWsdlDataTypeIdField;
      set => this.contextWsdlDataTypeIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeveloperName
    {
      get => this.developerNameField;
      set => this.developerNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsComplex
    {
      get => this.isComplexField;
      set => this.isComplexField = value;
    }

    [XmlIgnore]
    public bool IsComplexSpecified
    {
      get => this.isComplexFieldSpecified;
      set => this.isComplexFieldSpecified = value;
    }
  }
}
