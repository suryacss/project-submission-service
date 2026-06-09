// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ProcessRequest
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
  [XmlInclude(typeof (ProcessWorkitemRequest))]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [XmlInclude(typeof (ProcessSubmitRequest))]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class ProcessRequest
  {
    private string commentsField;
    private string[] nextApproverIdsField;

    [XmlElement(IsNullable = true)]
    public string comments
    {
      get => this.commentsField;
      set => this.commentsField = value;
    }

    [XmlElement("nextApproverIds", IsNullable = true)]
    public string[] nextApproverIds
    {
      get => this.nextApproverIdsField;
      set => this.nextApproverIdsField = value;
    }
  }
}
