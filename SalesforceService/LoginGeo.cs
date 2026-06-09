// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LoginGeo
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class LoginGeo : sObject
  {
    private string cityField;
    private string countryField;
    private string countryIsoField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private double? latitudeField;
    private bool latitudeFieldSpecified;
    private DateTime? loginTimeField;
    private bool loginTimeFieldSpecified;
    private double? longitudeField;
    private bool longitudeFieldSpecified;
    private string postalCodeField;
    private string subdivisionField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

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
    public string CountryIso
    {
      get => this.countryIsoField;
      set => this.countryIsoField = value;
    }

    [XmlElement(IsNullable = true)]
    public User CreatedBy
    {
      get => this.createdByField;
      set => this.createdByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CreatedById
    {
      get => this.createdByIdField;
      set => this.createdByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? CreatedDate
    {
      get => this.createdDateField;
      set => this.createdDateField = value;
    }

    [XmlIgnore]
    public bool CreatedDateSpecified
    {
      get => this.createdDateFieldSpecified;
      set => this.createdDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeleted
    {
      get => this.isDeletedField;
      set => this.isDeletedField = value;
    }

    [XmlIgnore]
    public bool IsDeletedSpecified
    {
      get => this.isDeletedFieldSpecified;
      set => this.isDeletedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User LastModifiedBy
    {
      get => this.lastModifiedByField;
      set => this.lastModifiedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastModifiedById
    {
      get => this.lastModifiedByIdField;
      set => this.lastModifiedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastModifiedDate
    {
      get => this.lastModifiedDateField;
      set => this.lastModifiedDateField = value;
    }

    [XmlIgnore]
    public bool LastModifiedDateSpecified
    {
      get => this.lastModifiedDateFieldSpecified;
      set => this.lastModifiedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Latitude
    {
      get => this.latitudeField;
      set => this.latitudeField = value;
    }

    [XmlIgnore]
    public bool LatitudeSpecified
    {
      get => this.latitudeFieldSpecified;
      set => this.latitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LoginTime
    {
      get => this.loginTimeField;
      set => this.loginTimeField = value;
    }

    [XmlIgnore]
    public bool LoginTimeSpecified
    {
      get => this.loginTimeFieldSpecified;
      set => this.loginTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public double? Longitude
    {
      get => this.longitudeField;
      set => this.longitudeField = value;
    }

    [XmlIgnore]
    public bool LongitudeSpecified
    {
      get => this.longitudeFieldSpecified;
      set => this.longitudeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string PostalCode
    {
      get => this.postalCodeField;
      set => this.postalCodeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Subdivision
    {
      get => this.subdivisionField;
      set => this.subdivisionField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SystemModstamp
    {
      get => this.systemModstampField;
      set => this.systemModstampField = value;
    }

    [XmlIgnore]
    public bool SystemModstampSpecified
    {
      get => this.systemModstampFieldSpecified;
      set => this.systemModstampFieldSpecified = value;
    }
  }
}
