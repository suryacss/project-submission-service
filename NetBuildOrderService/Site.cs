// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Site
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
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class Site : INotifyPropertyChanged
  {
    private string siteIdentifierField;
    private string siteNameField;
    private AltKeys altKeysField;
    private string clliField;
    private GeographicAddress addressField;
    private LocalAddress localAddressField;
    private LatLongCoordinate latlongField;
    private VHCoordinate vhCoordField;

    [XmlElement(Order = 0)]
    public string siteIdentifier
    {
      get => this.siteIdentifierField;
      set
      {
        this.siteIdentifierField = value;
        this.RaisePropertyChanged(nameof (siteIdentifier));
      }
    }

    [XmlElement(Order = 1)]
    public string siteName
    {
      get => this.siteNameField;
      set
      {
        this.siteNameField = value;
        this.RaisePropertyChanged(nameof (siteName));
      }
    }

    [XmlElement(Order = 2)]
    public AltKeys altKeys
    {
      get => this.altKeysField;
      set
      {
        this.altKeysField = value;
        this.RaisePropertyChanged(nameof (altKeys));
      }
    }

    [XmlElement(Order = 3)]
    public string clli
    {
      get => this.clliField;
      set
      {
        this.clliField = value;
        this.RaisePropertyChanged(nameof (clli));
      }
    }

    [XmlElement(Order = 4)]
    public GeographicAddress address
    {
      get => this.addressField;
      set
      {
        this.addressField = value;
        this.RaisePropertyChanged(nameof (address));
      }
    }

    [XmlElement(Order = 5)]
    public LocalAddress localAddress
    {
      get => this.localAddressField;
      set
      {
        this.localAddressField = value;
        this.RaisePropertyChanged(nameof (localAddress));
      }
    }

    [XmlElement(Order = 6)]
    public LatLongCoordinate latlong
    {
      get => this.latlongField;
      set
      {
        this.latlongField = value;
        this.RaisePropertyChanged(nameof (latlong));
      }
    }

    [XmlElement(Order = 7)]
    public VHCoordinate vhCoord
    {
      get => this.vhCoordField;
      set
      {
        this.vhCoordField = value;
        this.RaisePropertyChanged(nameof (vhCoord));
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
