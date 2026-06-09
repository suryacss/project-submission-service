// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.AssignmentRuleHeader
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib.SalesforceService
{
  [DesignerCategory("code")]
  [XmlRoot(Namespace = "urn:enterprise.soap.sforce.com", IsNullable = false)]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [XmlType(AnonymousType = true, Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class AssignmentRuleHeader : SoapHeader
  {
    private string assignmentRuleIdField;
    private bool? useDefaultRuleField;

    [XmlElement(IsNullable = true)]
    public string assignmentRuleId
    {
      get => this.assignmentRuleIdField;
      set => this.assignmentRuleIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? useDefaultRule
    {
      get => this.useDefaultRuleField;
      set => this.useDefaultRuleField = value;
    }
  }
}
