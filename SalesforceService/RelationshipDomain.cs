// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RelationshipDomain
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
  public class RelationshipDomain : sObject
  {
    private EntityDefinition childSobjectField;
    private string childSobjectIdField;
    private string durableIdField;
    private FieldDefinition fieldField;
    private string fieldIdField;
    private bool? isCascadeDeleteField;
    private bool isCascadeDeleteFieldSpecified;
    private bool? isDeprecatedAndHiddenField;
    private bool isDeprecatedAndHiddenFieldSpecified;
    private bool? isRestrictedDeleteField;
    private bool isRestrictedDeleteFieldSpecified;
    private string[] junctionIdListNamesField;
    private EntityDefinition parentSobjectField;
    private string parentSobjectIdField;
    private RelationshipInfo relationshipInfoField;
    private string relationshipInfoIdField;
    private string relationshipNameField;

    [XmlElement(IsNullable = true)]
    public EntityDefinition ChildSobject
    {
      get => this.childSobjectField;
      set => this.childSobjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ChildSobjectId
    {
      get => this.childSobjectIdField;
      set => this.childSobjectIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public FieldDefinition Field
    {
      get => this.fieldField;
      set => this.fieldField = value;
    }

    [XmlElement(IsNullable = true)]
    public string FieldId
    {
      get => this.fieldIdField;
      set => this.fieldIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsCascadeDelete
    {
      get => this.isCascadeDeleteField;
      set => this.isCascadeDeleteField = value;
    }

    [XmlIgnore]
    public bool IsCascadeDeleteSpecified
    {
      get => this.isCascadeDeleteFieldSpecified;
      set => this.isCascadeDeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeprecatedAndHidden
    {
      get => this.isDeprecatedAndHiddenField;
      set => this.isDeprecatedAndHiddenField = value;
    }

    [XmlIgnore]
    public bool IsDeprecatedAndHiddenSpecified
    {
      get => this.isDeprecatedAndHiddenFieldSpecified;
      set => this.isDeprecatedAndHiddenFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsRestrictedDelete
    {
      get => this.isRestrictedDeleteField;
      set => this.isRestrictedDeleteField = value;
    }

    [XmlIgnore]
    public bool IsRestrictedDeleteSpecified
    {
      get => this.isRestrictedDeleteFieldSpecified;
      set => this.isRestrictedDeleteFieldSpecified = value;
    }

    [XmlArrayItem("names", Namespace = "urn:enterprise.soap.sforce.com", IsNullable = false)]
    [XmlArray(IsNullable = true)]
    public string[] JunctionIdListNames
    {
      get => this.junctionIdListNamesField;
      set => this.junctionIdListNamesField = value;
    }

    [XmlElement(IsNullable = true)]
    public EntityDefinition ParentSobject
    {
      get => this.parentSobjectField;
      set => this.parentSobjectField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ParentSobjectId
    {
      get => this.parentSobjectIdField;
      set => this.parentSobjectIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public RelationshipInfo RelationshipInfo
    {
      get => this.relationshipInfoField;
      set => this.relationshipInfoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationshipInfoId
    {
      get => this.relationshipInfoIdField;
      set => this.relationshipInfoIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationshipName
    {
      get => this.relationshipNameField;
      set => this.relationshipNameField = value;
    }
  }
}
