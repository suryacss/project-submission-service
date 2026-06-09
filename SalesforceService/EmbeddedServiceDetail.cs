// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EmbeddedServiceDetail
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class EmbeddedServiceDetail : sObject
  {
    private string contrastPrimaryColorField;
    private string durableIdField;
    private string fontField;
    private bool? isPrechatEnabledField;
    private bool isPrechatEnabledFieldSpecified;
    private string navBarColorField;
    private string primaryColorField;
    private string secondaryColorField;
    private string siteField;

    [XmlElement(IsNullable = true)]
    public string ContrastPrimaryColor
    {
      get => this.contrastPrimaryColorField;
      set => this.contrastPrimaryColorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DurableId
    {
      get => this.durableIdField;
      set => this.durableIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Font
    {
      get => this.fontField;
      set => this.fontField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsPrechatEnabled
    {
      get => this.isPrechatEnabledField;
      set => this.isPrechatEnabledField = value;
    }

    [XmlIgnore]
    public bool IsPrechatEnabledSpecified
    {
      get => this.isPrechatEnabledFieldSpecified;
      set => this.isPrechatEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string NavBarColor
    {
      get => this.navBarColorField;
      set => this.navBarColorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PrimaryColor
    {
      get => this.primaryColorField;
      set => this.primaryColorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string SecondaryColor
    {
      get => this.secondaryColorField;
      set => this.secondaryColorField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Site
    {
      get => this.siteField;
      set => this.siteField = value;
    }
  }
}
