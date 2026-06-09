// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.createNetworkOrder
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
  public class createNetworkOrder : baseRequest
  {
    private NetworkOrderDetail networkOrderDetailField;

    [XmlElement(Order = 0)]
    public NetworkOrderDetail networkOrderDetail
    {
      get => this.networkOrderDetailField;
      set
      {
        this.networkOrderDetailField = value;
        this.RaisePropertyChanged(nameof (networkOrderDetail));
      }
    }
  }
}
