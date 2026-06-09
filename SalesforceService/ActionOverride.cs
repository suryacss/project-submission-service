// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ActionOverride
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class ActionOverride
  {
    private string formFactorField;
    private bool isAvailableInTouchField;
    private string nameField;
    private string pageIdField;
    private string urlField;

    public string formFactor
    {
      get => this.formFactorField;
      set => this.formFactorField = value;
    }

    public bool isAvailableInTouch
    {
      get => this.isAvailableInTouchField;
      set => this.isAvailableInTouchField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string pageId
    {
      get => this.pageIdField;
      set => this.pageIdField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }
  }
}
