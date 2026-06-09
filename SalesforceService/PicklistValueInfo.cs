// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PicklistValueInfo
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
  public class PicklistValueInfo : sObject
  {
    private string durableIdField;
    private EntityParticle entityParticleField;
    private string entityParticleIdField;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isDefaultValueField;
    private bool isDefaultValueFieldSpecified;
    private string labelField;
    private string validForField;
    private string valueField;

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public EntityParticle EntityParticle
    {
      get => this.entityParticleField;
      set => this.entityParticleField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EntityParticleId
    {
      get => this.entityParticleIdField;
      set => this.entityParticleIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsActive
    {
      get => this.isActiveField;
      set => this.isActiveField = value;
    }

    [XmlIgnore]
    public bool IsActiveSpecified
    {
      get => this.isActiveFieldSpecified;
      set => this.isActiveFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDefaultValue
    {
      get => this.isDefaultValueField;
      set => this.isDefaultValueField = value;
    }

    [XmlIgnore]
    public bool IsDefaultValueSpecified
    {
      get => this.isDefaultValueFieldSpecified;
      set => this.isDefaultValueFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ValidFor
    {
      get => this.validForField;
      set => this.validForField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Value
    {
      get => this.valueField;
      set => this.valueField = value;
    }
  }
}
