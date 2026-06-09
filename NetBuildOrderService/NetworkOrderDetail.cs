// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrderDetail
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
  public class NetworkOrderDetail : INotifyPropertyChanged
  {
    private NetworkOrder networkOrderField;
    private NetworkOrderItemDetail[] networkOrderItemsField;
    private NetworkOrderItemDependency[] networkOrderItemDependenciesField;

    [XmlElement(Order = 0)]
    public NetworkOrder networkOrder
    {
      get => this.networkOrderField;
      set
      {
        this.networkOrderField = value;
        this.RaisePropertyChanged(nameof (networkOrder));
      }
    }

    [XmlArrayItem("networkOrderItemDetail", IsNullable = false)]
    [XmlArray(Order = 1)]
    public NetworkOrderItemDetail[] networkOrderItems
    {
      get => this.networkOrderItemsField;
      set
      {
        this.networkOrderItemsField = value;
        this.RaisePropertyChanged(nameof (networkOrderItems));
      }
    }

    [XmlArray(Order = 2)]
    [XmlArrayItem("networkOrderItemDependency", IsNullable = false)]
    public NetworkOrderItemDependency[] networkOrderItemDependencies
    {
      get => this.networkOrderItemDependenciesField;
      set
      {
        this.networkOrderItemDependenciesField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemDependencies));
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
