// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrderItemDependency
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DebuggerStepThrough]
  [Serializable]
  public class NetworkOrderItemDependency : INotifyPropertyChanged
  {
    private OrderIdentifier networkOrderItemIdentifierField;
    private OrderIdentifier dependentNetworkOrderItemIdentifierField;

    [XmlElement(Order = 0)]
    public OrderIdentifier networkOrderItemIdentifier
    {
      get => this.networkOrderItemIdentifierField;
      set
      {
        this.networkOrderItemIdentifierField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemIdentifier));
      }
    }

    [XmlElement(Order = 1)]
    public OrderIdentifier dependentNetworkOrderItemIdentifier
    {
      get => this.dependentNetworkOrderItemIdentifierField;
      set
      {
        this.dependentNetworkOrderItemIdentifierField = value;
        this.RaisePropertyChanged(nameof (dependentNetworkOrderItemIdentifier));
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
