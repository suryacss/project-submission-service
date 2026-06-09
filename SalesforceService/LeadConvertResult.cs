// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LeadConvertResult
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class LeadConvertResult
  {
    private string accountIdField;
    private string contactIdField;
    private Error[] errorsField;
    private string leadIdField;
    private string opportunityIdField;
    private bool successField;

    [XmlElement(IsNullable = true)]
    public string accountId
    {
      get => this.accountIdField;
      set => this.accountIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string contactId
    {
      get => this.contactIdField;
      set => this.contactIdField = value;
    }

    [XmlElement("errors")]
    public Error[] errors
    {
      get => this.errorsField;
      set => this.errorsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string leadId
    {
      get => this.leadIdField;
      set => this.leadIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string opportunityId
    {
      get => this.opportunityIdField;
      set => this.opportunityIdField = value;
    }

    public bool success
    {
      get => this.successField;
      set => this.successField = value;
    }
  }
}
