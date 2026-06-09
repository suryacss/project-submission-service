// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.OutgoingEmailRelation
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
  public class OutgoingEmailRelation : sObject
  {
    private string externalIdField;
    private OutgoingEmail outgoingEmailField;
    private string outgoingEmailIdField;
    private Name relationField;
    private string relationAddressField;
    private string relationIdField;

    [XmlElement(IsNullable = true)]
    public string ExternalId
    {
      get => this.externalIdField;
      set => this.externalIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public OutgoingEmail OutgoingEmail
    {
      get => this.outgoingEmailField;
      set => this.outgoingEmailField = value;
    }

    [XmlElement(IsNullable = true)]
    public string OutgoingEmailId
    {
      get => this.outgoingEmailIdField;
      set => this.outgoingEmailIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public Name Relation
    {
      get => this.relationField;
      set => this.relationField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationAddress
    {
      get => this.relationAddressField;
      set => this.relationAddressField = value;
    }

    [XmlElement(IsNullable = true)]
    public string RelationId
    {
      get => this.relationIdField;
      set => this.relationIdField = value;
    }
  }
}
