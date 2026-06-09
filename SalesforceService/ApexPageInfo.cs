// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApexPageInfo
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class ApexPageInfo : sObject
  {
    private string apexPageIdField;
    private double? apiVersionField;
    private bool apiVersionFieldSpecified;
    private string descriptionField;
    private string durableIdField;
    private bool? isAvailableInTouchField;
    private bool isAvailableInTouchFieldSpecified;
    private string masterLabelField;
    private string nameField;
    private string nameSpacePrefixField;

    [XmlElement(IsNullable = true)]
    public string ApexPageId
    {
      get => this.apexPageIdField;
      set => this.apexPageIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? ApiVersion
    {
      get => this.apiVersionField;
      set => this.apiVersionField = value;
    }

    [XmlIgnore]
    public bool ApiVersionSpecified
    {
      get => this.apiVersionFieldSpecified;
      set => this.apiVersionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsAvailableInTouch
    {
      get => this.isAvailableInTouchField;
      set => this.isAvailableInTouchField = value;
    }

    [XmlIgnore]
    public bool IsAvailableInTouchSpecified
    {
      get => this.isAvailableInTouchFieldSpecified;
      set => this.isAvailableInTouchFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MasterLabel
    {
      get => this.masterLabelField;
      set => this.masterLabelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NameSpacePrefix
    {
      get => this.nameSpacePrefixField;
      set => this.nameSpacePrefixField = value;
    }
  }
}
