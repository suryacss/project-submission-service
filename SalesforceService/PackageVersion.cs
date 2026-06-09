// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.PackageVersion
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class PackageVersion
  {
    private int majorNumberField;
    private int minorNumberField;
    private string namespaceField;

    public int majorNumber
    {
      get => this.majorNumberField;
      set => this.majorNumberField = value;
    }

    public int minorNumber
    {
      get => this.minorNumberField;
      set => this.minorNumberField = value;
    }

    public string @namespace
    {
      get => this.namespaceField;
      set => this.namespaceField = value;
    }
  }
}
