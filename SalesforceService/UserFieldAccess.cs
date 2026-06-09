// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserFieldAccess
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class UserFieldAccess : sObject
  {
    private string durableIdField;
    private EntityDefinition entityDefinitionField;
    private string entityDefinitionIdField;
    private FieldDefinition fieldDefinitionField;
    private string fieldDefinitionIdField;
    private bool? isAccessibleField;
    private bool isAccessibleFieldSpecified;
    private bool? isCreatableField;
    private bool isCreatableFieldSpecified;
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
    public FieldDefinition FieldDefinition
    {
      get => this.fieldDefinitionField;
      set => this.fieldDefinitionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FieldDefinitionId
    {
      get => this.fieldDefinitionIdField;
      set => this.fieldDefinitionIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsAccessible
    {
      get => this.isAccessibleField;
      set => this.isAccessibleField = value;
    }

    [XmlIgnore]
    public bool IsAccessibleSpecified
    {
      get => this.isAccessibleFieldSpecified;
      set => this.isAccessibleFieldSpecified = value;
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
