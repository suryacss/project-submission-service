// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.CustomerHeldOrder
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  public class CustomerHeldOrder : INotifyPropertyChanged
  {
    private DateTime customerRequestDateField;
    private bool customerRequestDateFieldSpecified;
    private string customerNameField;
    private string productNameField;
    private string bandWidthField;
    private string regionCodeField;
    private Decimal totalMRCField;
    private bool totalMRCFieldSpecified;
    private Decimal totalNRCField;
    private bool totalNRCFieldSpecified;
    private string isSupplementOrderField;
    private string orderSystemServiceIdentifierField;
    private string orderSystemNameField;

    [XmlElement(DataType = "date", Order = 0)]
    public DateTime customerRequestDate
    {
      get => this.customerRequestDateField;
      set
      {
        this.customerRequestDateField = value;
        this.RaisePropertyChanged(nameof (customerRequestDate));
      }
    }

    [XmlIgnore]
    public bool customerRequestDateSpecified
    {
      get => this.customerRequestDateFieldSpecified;
      set
      {
        this.customerRequestDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (customerRequestDateSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public string customerName
    {
      get => this.customerNameField;
      set
      {
        this.customerNameField = value;
        this.RaisePropertyChanged(nameof (customerName));
      }
    }

    [XmlElement(Order = 2)]
    public string productName
    {
      get => this.productNameField;
      set
      {
        this.productNameField = value;
        this.RaisePropertyChanged(nameof (productName));
      }
    }

    [XmlElement(Order = 3)]
    public string bandWidth
    {
      get => this.bandWidthField;
      set
      {
        this.bandWidthField = value;
        this.RaisePropertyChanged(nameof (bandWidth));
      }
    }

    [XmlElement(Order = 4)]
    public string regionCode
    {
      get => this.regionCodeField;
      set
      {
        this.regionCodeField = value;
        this.RaisePropertyChanged(nameof (regionCode));
      }
    }

    [XmlElement(Order = 5)]
    public Decimal totalMRC
    {
      get => this.totalMRCField;
      set
      {
        this.totalMRCField = value;
        this.RaisePropertyChanged(nameof (totalMRC));
      }
    }

    [XmlIgnore]
    public bool totalMRCSpecified
    {
      get => this.totalMRCFieldSpecified;
      set
      {
        this.totalMRCFieldSpecified = value;
        this.RaisePropertyChanged(nameof (totalMRCSpecified));
      }
    }

    [XmlElement(Order = 6)]
    public Decimal totalNRC
    {
      get => this.totalNRCField;
      set
      {
        this.totalNRCField = value;
        this.RaisePropertyChanged(nameof (totalNRC));
      }
    }

    [XmlIgnore]
    public bool totalNRCSpecified
    {
      get => this.totalNRCFieldSpecified;
      set
      {
        this.totalNRCFieldSpecified = value;
        this.RaisePropertyChanged(nameof (totalNRCSpecified));
      }
    }

    [XmlElement(Order = 7)]
    public string isSupplementOrder
    {
      get => this.isSupplementOrderField;
      set
      {
        this.isSupplementOrderField = value;
        this.RaisePropertyChanged(nameof (isSupplementOrder));
      }
    }

    [XmlElement(Order = 8)]
    public string orderSystemServiceIdentifier
    {
      get => this.orderSystemServiceIdentifierField;
      set
      {
        this.orderSystemServiceIdentifierField = value;
        this.RaisePropertyChanged(nameof (orderSystemServiceIdentifier));
      }
    }

    [XmlElement(Order = 9)]
    public string orderSystemName
    {
      get => this.orderSystemNameField;
      set
      {
        this.orderSystemNameField = value;
        this.RaisePropertyChanged(nameof (orderSystemName));
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
