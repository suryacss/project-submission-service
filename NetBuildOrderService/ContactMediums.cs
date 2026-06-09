// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.ContactMediums
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
  public class ContactMediums : INotifyPropertyChanged
  {
    private string telephoneNumberContactField;
    private string faxNumberContactField;
    private string pagerNumberContactField;
    private string emailAddressContactField;
    private string cellularNumberContactField;

    [XmlElement(Order = 0)]
    public string telephoneNumberContact
    {
      get => this.telephoneNumberContactField;
      set
      {
        this.telephoneNumberContactField = value;
        this.RaisePropertyChanged(nameof (telephoneNumberContact));
      }
    }

    [XmlElement(Order = 1)]
    public string faxNumberContact
    {
      get => this.faxNumberContactField;
      set
      {
        this.faxNumberContactField = value;
        this.RaisePropertyChanged(nameof (faxNumberContact));
      }
    }

    [XmlElement(Order = 2)]
    public string pagerNumberContact
    {
      get => this.pagerNumberContactField;
      set
      {
        this.pagerNumberContactField = value;
        this.RaisePropertyChanged(nameof (pagerNumberContact));
      }
    }

    [XmlElement(Order = 3)]
    public string emailAddressContact
    {
      get => this.emailAddressContactField;
      set
      {
        this.emailAddressContactField = value;
        this.RaisePropertyChanged(nameof (emailAddressContact));
      }
    }

    [XmlElement(Order = 4)]
    public string cellularNumberContact
    {
      get => this.cellularNumberContactField;
      set
      {
        this.cellularNumberContactField = value;
        this.RaisePropertyChanged(nameof (cellularNumberContact));
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
