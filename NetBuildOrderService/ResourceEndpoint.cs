// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.ResourceEndpoint
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  public class ResourceEndpoint : INotifyPropertyChanged
  {
    private string endpointTypeField;
    private Site siteField;
    private string siteTypeField;
    private Contact[] siteContactsField;
    private string dispatchGatewayField;
    private string siteDispositionField;
    private string isPrimaryLocationField;

    [XmlElement(Order = 0)]
    public string endpointType
    {
      get => this.endpointTypeField;
      set
      {
        this.endpointTypeField = value;
        this.RaisePropertyChanged(nameof (endpointType));
      }
    }

    [XmlElement(Order = 1)]
    public Site site
    {
      get => this.siteField;
      set
      {
        this.siteField = value;
        this.RaisePropertyChanged(nameof (site));
      }
    }

    [XmlElement(Order = 2)]
    public string siteType
    {
      get => this.siteTypeField;
      set
      {
        this.siteTypeField = value;
        this.RaisePropertyChanged(nameof (siteType));
      }
    }

    [XmlArrayItem("contact", IsNullable = false)]
    [XmlArray(Order = 3)]
    public Contact[] siteContacts
    {
      get => this.siteContactsField;
      set
      {
        this.siteContactsField = value;
        this.RaisePropertyChanged(nameof (siteContacts));
      }
    }

    [XmlElement(Order = 4)]
    public string dispatchGateway
    {
      get => this.dispatchGatewayField;
      set
      {
        this.dispatchGatewayField = value;
        this.RaisePropertyChanged(nameof (dispatchGateway));
      }
    }

    [XmlElement(Order = 5)]
    public string siteDisposition
    {
      get => this.siteDispositionField;
      set
      {
        this.siteDispositionField = value;
        this.RaisePropertyChanged(nameof (siteDisposition));
      }
    }

    [XmlElement(Order = 6)]
    public string isPrimaryLocation
    {
      get => this.isPrimaryLocationField;
      set
      {
        this.isPrimaryLocationField = value;
        this.RaisePropertyChanged(nameof (isPrimaryLocation));
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
