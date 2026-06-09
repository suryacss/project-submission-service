// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.address
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
  public class address : location
  {
    private string cityField;
    private string countryField;
    private string countryCodeField;
    private string geocodeAccuracyField;
    private string postalCodeField;
    private string stateField;
    private string stateCodeField;
    private string streetField;

    [XmlElement(IsNullable = true)]
    public string city
    {
      get => this.cityField;
      set => this.cityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string country
    {
      get => this.countryField;
      set => this.countryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string countryCode
    {
      get => this.countryCodeField;
      set => this.countryCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string geocodeAccuracy
    {
      get => this.geocodeAccuracyField;
      set => this.geocodeAccuracyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string postalCode
    {
      get => this.postalCodeField;
      set => this.postalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    [XmlElement(IsNullable = true)]
    public string stateCode
    {
      get => this.stateCodeField;
      set => this.stateCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string street
    {
      get => this.streetField;
      set => this.streetField = value;
    }
  }
}
