// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ChildRelationship
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class ChildRelationship
  {
    private bool cascadeDeleteField;
    private string childSObjectField;
    private bool deprecatedAndHiddenField;
    private string fieldField;
    private string[] junctionIdListNamesField;
    private string[] junctionReferenceToField;
    private string relationshipNameField;
    private bool restrictedDeleteField;
    private bool restrictedDeleteFieldSpecified;

    public bool cascadeDelete
    {
      get => this.cascadeDeleteField;
      set => this.cascadeDeleteField = value;
    }

    public string childSObject
    {
      get => this.childSObjectField;
      set => this.childSObjectField = value;
    }

    public bool deprecatedAndHidden
    {
      get => this.deprecatedAndHiddenField;
      set => this.deprecatedAndHiddenField = value;
    }

    public string field
    {
      get => this.fieldField;
      set => this.fieldField = value;
    }

    [XmlElement("junctionIdListNames", IsNullable = true)]
    public string[] junctionIdListNames
    {
      get => this.junctionIdListNamesField;
      set => this.junctionIdListNamesField = value;
    }

    [XmlElement("junctionReferenceTo", IsNullable = true)]
    public string[] junctionReferenceTo
    {
      get => this.junctionReferenceToField;
      set => this.junctionReferenceToField = value;
    }

    public string relationshipName
    {
      get => this.relationshipNameField;
      set => this.relationshipNameField = value;
    }

    public bool restrictedDelete
    {
      get => this.restrictedDeleteField;
      set => this.restrictedDeleteField = value;
    }

    [XmlIgnore]
    public bool restrictedDeleteSpecified
    {
      get => this.restrictedDeleteFieldSpecified;
      set => this.restrictedDeleteFieldSpecified = value;
    }
  }
}
