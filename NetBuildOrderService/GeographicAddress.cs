// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.GeographicAddress
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib.NetBuildOrderService
{
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class GeographicAddress : INotifyPropertyChanged
  {
    private string address1Field;
    private string address2Field;
    private string cityField;
    private string stateField;
    private string postalCodeField;
    private string countryField;

    [XmlElement(Order = 0)]
    public string address1
    {
      get => this.address1Field;
      set
      {
        this.address1Field = value;
        this.RaisePropertyChanged(nameof (address1));
      }
    }

    [XmlElement(Order = 1)]
    public string address2
    {
      get => this.address2Field;
      set
      {
        this.address2Field = value;
        this.RaisePropertyChanged(nameof (address2));
      }
    }

    [XmlElement(Order = 2)]
    public string city
    {
      get => this.cityField;
      set
      {
        this.cityField = value;
        this.RaisePropertyChanged(nameof (city));
      }
    }

    [XmlElement(Order = 3)]
    public string state
    {
      get => this.stateField;
      set
      {
        this.stateField = value;
        this.RaisePropertyChanged(nameof (state));
      }
    }

    [XmlElement(Order = 4)]
    public string postalCode
    {
      get => this.postalCodeField;
      set
      {
        this.postalCodeField = value;
        this.RaisePropertyChanged(nameof (postalCode));
      }
    }

    [XmlElement(Order = 5)]
    public string country
    {
      get => this.countryField;
      set
      {
        this.countryField = value;
        this.RaisePropertyChanged(nameof (country));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
