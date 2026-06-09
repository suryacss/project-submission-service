// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeSoftphoneLayoutSection
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class DescribeSoftphoneLayoutSection
  {
    private string entityApiNameField;
    private DescribeSoftphoneLayoutItem[] itemsField;

    public string entityApiName
    {
      get => this.entityApiNameField;
      set => this.entityApiNameField = value;
    }

    [XmlElement("items")]
    public DescribeSoftphoneLayoutItem[] items
    {
      get => this.itemsField;
      set => this.itemsField = value;
    }
  }
}
