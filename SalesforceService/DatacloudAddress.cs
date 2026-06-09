// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DatacloudAddress
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
  public class DatacloudAddress : sObject
  {
    private string addressLine1Field;
    private string addressLine2Field;
    private string cityField;
    private string countryField;
    private string externalIdField;
    private string geoAccuracyCodeField;
    private string geoAccuracyNumField;
    private string latitudeField;
    private string longitudeField;
    private string postalCodeField;
    private string stateField;

    [XmlElement(IsNullable = true)]
    public string AddressLine1
    {
      get => this.addressLine1Field;
      set => this.addressLine1Field = value;
    }

    [XmlElement(IsNullable = true)]
    public string AddressLine2
    {
      get => this.addressLine2Field;
      set => this.addressLine2Field = value;
    }

    [XmlElement(IsNullable = true)]
    public string City
    {
      get => this.cityField;
      set => this.cityField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Country
    {
      get => this.countryField;
      set => this.countryField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ExternalId
    {
      get => this.externalIdField;
      set => this.externalIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GeoAccuracyCode
    {
      get => this.geoAccuracyCodeField;
      set => this.geoAccuracyCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string GeoAccuracyNum
    {
      get => this.geoAccuracyNumField;
      set => this.geoAccuracyNumField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Latitude
    {
      get => this.latitudeField;
      set => this.latitudeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Longitude
    {
      get => this.longitudeField;
      set => this.longitudeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string PostalCode
    {
      get => this.postalCodeField;
      set => this.postalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string State
    {
      get => this.stateField;
      set => this.stateField = value;
    }
  }
}
