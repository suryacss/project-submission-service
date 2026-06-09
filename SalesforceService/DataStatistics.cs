// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DataStatistics
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class DataStatistics : sObject
  {
    private string externalIdField;
    private string statTypeField;
    private int? statValueField;
    private bool statValueFieldSpecified;
    private string typeField;
    private User userField;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public string ExternalId
    {
      get => this.externalIdField;
      set => this.externalIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string StatType
    {
      get => this.statTypeField;
      set => this.statTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? StatValue
    {
      get => this.statValueField;
      set => this.statValueField = value;
    }

    [XmlIgnore]
    public bool StatValueSpecified
    {
      get => this.statValueFieldSpecified;
      set => this.statValueFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public User User
    {
      get => this.userField;
      set => this.userField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }
  }
}
