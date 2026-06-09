// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DuplicateRuleHeader
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
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "urn:enterprise.soap.sforce.com")]
  [XmlRoot(Namespace = "urn:enterprise.soap.sforce.com", IsNullable = false)]
  [Serializable]
  public class DuplicateRuleHeader : SoapHeader
  {
    private bool allowSaveField;
    private bool includeRecordDetailsField;
    private bool runAsCurrentUserField;

    public bool allowSave
    {
      get => this.allowSaveField;
      set => this.allowSaveField = value;
    }

    public bool includeRecordDetails
    {
      get => this.includeRecordDetailsField;
      set => this.includeRecordDetailsField = value;
    }

    public bool runAsCurrentUser
    {
      get => this.runAsCurrentUserField;
      set => this.runAsCurrentUserField = value;
    }
  }
}
