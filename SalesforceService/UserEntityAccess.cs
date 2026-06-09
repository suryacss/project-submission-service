// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserEntityAccess
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class UserEntityAccess : sObject
  {
    private string durableIdField;
    private EntityDefinition entityDefinitionField;
    private string entityDefinitionIdField;
    private bool? isActivateableField;
    private bool isActivateableFieldSpecified;
    private bool? isCreatableField;
    private bool isCreatableFieldSpecified;
    private bool? isDeletableField;
    private bool isDeletableFieldSpecified;
    private bool? isEditableField;
    private bool isEditableFieldSpecified;
    private bool? isFlsUpdatableField;
    private bool isFlsUpdatableFieldSpecified;
    private bool? isMergeableField;
    private bool isMergeableFieldSpecified;
    private bool? isReadableField;
    private bool isReadableFieldSpecified;
    private bool? isUndeletableField;
    private bool isUndeletableFieldSpecified;
    private bool? isUpdatableField;
    private bool isUpdatableFieldSpecified;
    private User userField;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public EntityDefinition EntityDefinition
    {
      get => this.entityDefinitionField;
      set => this.entityDefinitionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string EntityDefinitionId
    {
      get => this.entityDefinitionIdField;
      set => this.entityDefinitionIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsActivateable
    {
      get => this.isActivateableField;
      set => this.isActivateableField = value;
    }

    [XmlIgnore]
    public bool IsActivateableSpecified
    {
      get => this.isActivateableFieldSpecified;
      set => this.isActivateableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsCreatable
    {
      get => this.isCreatableField;
      set => this.isCreatableField = value;
    }

    [XmlIgnore]
    public bool IsCreatableSpecified
    {
      get => this.isCreatableFieldSpecified;
      set => this.isCreatableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeletable
    {
      get => this.isDeletableField;
      set => this.isDeletableField = value;
    }

    [XmlIgnore]
    public bool IsDeletableSpecified
    {
      get => this.isDeletableFieldSpecified;
      set => this.isDeletableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsEditable
    {
      get => this.isEditableField;
      set => this.isEditableField = value;
    }

    [XmlIgnore]
    public bool IsEditableSpecified
    {
      get => this.isEditableFieldSpecified;
      set => this.isEditableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsFlsUpdatable
    {
      get => this.isFlsUpdatableField;
      set => this.isFlsUpdatableField = value;
    }

    [XmlIgnore]
    public bool IsFlsUpdatableSpecified
    {
      get => this.isFlsUpdatableFieldSpecified;
      set => this.isFlsUpdatableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsMergeable
    {
      get => this.isMergeableField;
      set => this.isMergeableField = value;
    }

    [XmlIgnore]
    public bool IsMergeableSpecified
    {
      get => this.isMergeableFieldSpecified;
      set => this.isMergeableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsReadable
    {
      get => this.isReadableField;
      set => this.isReadableField = value;
    }

    [XmlIgnore]
    public bool IsReadableSpecified
    {
      get => this.isReadableFieldSpecified;
      set => this.isReadableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsUndeletable
    {
      get => this.isUndeletableField;
      set => this.isUndeletableField = value;
    }

    [XmlIgnore]
    public bool IsUndeletableSpecified
    {
      get => this.isUndeletableFieldSpecified;
      set => this.isUndeletableFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsUpdatable
    {
      get => this.isUpdatableField;
      set => this.isUpdatableField = value;
    }

    [XmlIgnore]
    public bool IsUpdatableSpecified
    {
      get => this.isUpdatableFieldSpecified;
      set => this.isUpdatableFieldSpecified = value;
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
