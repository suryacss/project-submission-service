// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserRecordAccess
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
  public class UserRecordAccess : sObject
  {
    private bool? hasAllAccessField;
    private bool hasAllAccessFieldSpecified;
    private bool? hasDeleteAccessField;
    private bool hasDeleteAccessFieldSpecified;
    private bool? hasEditAccessField;
    private bool hasEditAccessFieldSpecified;
    private bool? hasReadAccessField;
    private bool hasReadAccessFieldSpecified;
    private bool? hasTransferAccessField;
    private bool hasTransferAccessFieldSpecified;
    private string maxAccessLevelField;
    private string recordIdField;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public bool? HasAllAccess
    {
      get => this.hasAllAccessField;
      set => this.hasAllAccessField = value;
    }

    [XmlIgnore]
    public bool HasAllAccessSpecified
    {
      get => this.hasAllAccessFieldSpecified;
      set => this.hasAllAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasDeleteAccess
    {
      get => this.hasDeleteAccessField;
      set => this.hasDeleteAccessField = value;
    }

    [XmlIgnore]
    public bool HasDeleteAccessSpecified
    {
      get => this.hasDeleteAccessFieldSpecified;
      set => this.hasDeleteAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasEditAccess
    {
      get => this.hasEditAccessField;
      set => this.hasEditAccessField = value;
    }

    [XmlIgnore]
    public bool HasEditAccessSpecified
    {
      get => this.hasEditAccessFieldSpecified;
      set => this.hasEditAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasReadAccess
    {
      get => this.hasReadAccessField;
      set => this.hasReadAccessField = value;
    }

    [XmlIgnore]
    public bool HasReadAccessSpecified
    {
      get => this.hasReadAccessFieldSpecified;
      set => this.hasReadAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? HasTransferAccess
    {
      get => this.hasTransferAccessField;
      set => this.hasTransferAccessField = value;
    }

    [XmlIgnore]
    public bool HasTransferAccessSpecified
    {
      get => this.hasTransferAccessFieldSpecified;
      set => this.hasTransferAccessFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MaxAccessLevel
    {
      get => this.maxAccessLevelField;
      set => this.maxAccessLevelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RecordId
    {
      get => this.recordIdField;
      set => this.recordIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }
  }
}
