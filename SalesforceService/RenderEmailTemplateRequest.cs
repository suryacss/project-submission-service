// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.RenderEmailTemplateRequest
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class RenderEmailTemplateRequest
  {
    private string[] templateBodiesField;
    private string whatIdField;
    private string whoIdField;

    [XmlElement("templateBodies")]
    public string[] templateBodies
    {
      get => this.templateBodiesField;
      set => this.templateBodiesField = value;
    }

    public string whatId
    {
      get => this.whatIdField;
      set => this.whatIdField = value;
    }

    public string whoId
    {
      get => this.whoIdField;
      set => this.whoIdField = value;
    }
  }
}
