// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeSoftphoneLayoutCallType
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
  public class DescribeSoftphoneLayoutCallType
  {
    private DescribeSoftphoneLayoutInfoField[] infoFieldsField;
    private string nameField;
    private DescribeSoftphoneScreenPopOption[] screenPopOptionsField;
    private string screenPopsOpenWithinField;
    private DescribeSoftphoneLayoutSection[] sectionsField;

    [XmlElement("infoFields")]
    public DescribeSoftphoneLayoutInfoField[] infoFields
    {
      get => this.infoFieldsField;
      set => this.infoFieldsField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement("screenPopOptions")]
    public DescribeSoftphoneScreenPopOption[] screenPopOptions
    {
      get => this.screenPopOptionsField;
      set => this.screenPopOptionsField = value;
    }

    public string screenPopsOpenWithin
    {
      get => this.screenPopsOpenWithinField;
      set => this.screenPopsOpenWithinField = value;
    }

    [XmlElement("sections")]
    public DescribeSoftphoneLayoutSection[] sections
    {
      get => this.sectionsField;
      set => this.sectionsField = value;
    }
  }
}
