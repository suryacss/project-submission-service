// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LeadConvert
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class LeadConvert
  {
    private string accountIdField;
    private string contactIdField;
    private string convertedStatusField;
    private bool doNotCreateOpportunityField;
    private string leadIdField;
    private string opportunityNameField;
    private bool overwriteLeadSourceField;
    private string ownerIdField;
    private bool sendNotificationEmailField;

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

    public string convertedStatus
    {
      get => this.convertedStatusField;
      set => this.convertedStatusField = value;
    }

    public bool doNotCreateOpportunity
    {
      get => this.doNotCreateOpportunityField;
      set => this.doNotCreateOpportunityField = value;
    }

    public string leadId
    {
      get => this.leadIdField;
      set => this.leadIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string opportunityName
    {
      get => this.opportunityNameField;
      set => this.opportunityNameField = value;
    }

    public bool overwriteLeadSource
    {
      get => this.overwriteLeadSourceField;
      set => this.overwriteLeadSourceField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ownerId
    {
      get => this.ownerIdField;
      set => this.ownerIdField = value;
    }

    public bool sendNotificationEmail
    {
      get => this.sendNotificationEmailField;
      set => this.sendNotificationEmailField = value;
    }
  }
}
