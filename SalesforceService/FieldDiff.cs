// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FieldDiff
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class FieldDiff
  {
    private differenceType differenceField;
    private string nameField;

    public differenceType difference
    {
      get => this.differenceField;
      set => this.differenceField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }
  }
}
