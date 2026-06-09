// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DebuggingInfo
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
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [XmlType(AnonymousType = true, Namespace = "urn:enterprise.soap.sforce.com")]
  [XmlRoot(Namespace = "urn:enterprise.soap.sforce.com", IsNullable = false)]
  [Serializable]
  public class DebuggingInfo : SoapHeader
  {
    private string debugLogField;

    public string debugLog
    {
      get => this.debugLogField;
      set => this.debugLogField = value;
    }
  }
}
