// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeSoftphoneScreenPopOption
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
  public class DescribeSoftphoneScreenPopOption
  {
    private string matchTypeField;
    private string screenPopDataField;
    private string screenPopTypeField;

    public string matchType
    {
      get => this.matchTypeField;
      set => this.matchTypeField = value;
    }

    public string screenPopData
    {
      get => this.screenPopDataField;
      set => this.screenPopDataField = value;
    }

    public string screenPopType
    {
      get => this.screenPopTypeField;
      set => this.screenPopTypeField = value;
    }
  }
}
