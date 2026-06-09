// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.MassEmailMessage
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class MassEmailMessage : Email
  {
    private string descriptionField;
    private string[] targetObjectIdsField;
    private string templateIdField;
    private string[] whatIdsField;

    [XmlElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement("targetObjectIds")]
    public string[] targetObjectIds
    {
      get => this.targetObjectIdsField;
      set => this.targetObjectIdsField = value;
    }

    public string templateId
    {
      get => this.templateIdField;
      set => this.templateIdField = value;
    }

    [XmlElement("whatIds")]
    public string[] whatIds
    {
      get => this.whatIdsField;
      set => this.whatIdsField = value;
    }
  }
}
