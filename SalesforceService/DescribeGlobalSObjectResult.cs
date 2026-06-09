// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeGlobalSObjectResult
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
  public class DescribeGlobalSObjectResult
  {
    private bool activateableField;
    private bool createableField;
    private bool customField;
    private bool customSettingField;
    private bool deletableField;
    private bool deprecatedAndHiddenField;
    private bool feedEnabledField;
    private bool hasSubtypesField;
    private bool idEnabledField;
    private bool isSubtypeField;
    private string keyPrefixField;
    private string labelField;
    private string labelPluralField;
    private bool layoutableField;
    private bool mergeableField;
    private bool mruEnabledField;
    private string nameField;
    private bool queryableField;
    private bool replicateableField;
    private bool retrieveableField;
    private bool searchableField;
    private bool triggerableField;
    private bool undeletableField;
    private bool updateableField;

    public bool activateable
    {
      get => this.activateableField;
      set => this.activateableField = value;
    }

    public bool createable
    {
      get => this.createableField;
      set => this.createableField = value;
    }

    public bool custom
    {
      get => this.customField;
      set => this.customField = value;
    }

    public bool customSetting
    {
      get => this.customSettingField;
      set => this.customSettingField = value;
    }

    public bool deletable
    {
      get => this.deletableField;
      set => this.deletableField = value;
    }

    public bool deprecatedAndHidden
    {
      get => this.deprecatedAndHiddenField;
      set => this.deprecatedAndHiddenField = value;
    }

    public bool feedEnabled
    {
      get => this.feedEnabledField;
      set => this.feedEnabledField = value;
    }

    public bool hasSubtypes
    {
      get => this.hasSubtypesField;
      set => this.hasSubtypesField = value;
    }

    public bool idEnabled
    {
      get => this.idEnabledField;
      set => this.idEnabledField = value;
    }

    public bool isSubtype
    {
      get => this.isSubtypeField;
      set => this.isSubtypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string keyPrefix
    {
      get => this.keyPrefixField;
      set => this.keyPrefixField = value;
    }

    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public string labelPlural
    {
      get => this.labelPluralField;
      set => this.labelPluralField = value;
    }

    public bool layoutable
    {
      get => this.layoutableField;
      set => this.layoutableField = value;
    }

    public bool mergeable
    {
      get => this.mergeableField;
      set => this.mergeableField = value;
    }

    public bool mruEnabled
    {
      get => this.mruEnabledField;
      set => this.mruEnabledField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public bool queryable
    {
      get => this.queryableField;
      set => this.queryableField = value;
    }

    public bool replicateable
    {
      get => this.replicateableField;
      set => this.replicateableField = value;
    }

    public bool retrieveable
    {
      get => this.retrieveableField;
      set => this.retrieveableField = value;
    }

    public bool searchable
    {
      get => this.searchableField;
      set => this.searchableField = value;
    }

    public bool triggerable
    {
      get => this.triggerableField;
      set => this.triggerableField = value;
    }

    public bool undeletable
    {
      get => this.undeletableField;
      set => this.undeletableField = value;
    }

    public bool updateable
    {
      get => this.updateableField;
      set => this.updateableField = value;
    }
  }
}
