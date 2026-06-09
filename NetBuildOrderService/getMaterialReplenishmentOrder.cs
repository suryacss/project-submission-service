// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.getMaterialReplenishmentOrder
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
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class getMaterialReplenishmentOrder : baseRequest
  {
    private OrderIdentifier materialReplenishmentOrderIdentifierField;

    [XmlElement(Order = 0)]
    public OrderIdentifier materialReplenishmentOrderIdentifier
    {
      get => this.materialReplenishmentOrderIdentifierField;
      set
      {
        this.materialReplenishmentOrderIdentifierField = value;
        this.RaisePropertyChanged(nameof (materialReplenishmentOrderIdentifier));
      }
    }
  }
}
