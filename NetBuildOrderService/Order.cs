// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Order
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
  [XmlInclude(typeof (MaterialReplenishmentOrder))]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [XmlInclude(typeof (NetworkOrder))]
  [XmlInclude(typeof (SiteSurveyOrder))]
  [DebuggerStepThrough]
  [Serializable]
  public abstract class Order : INotifyPropertyChanged
  {
    private OrderIdentifier orderIdentifierField;
    private OrderRelationship[] relatedOrdersField;

    [XmlElement(Order = 0)]
    public OrderIdentifier orderIdentifier
    {
      get => this.orderIdentifierField;
      set
      {
        this.orderIdentifierField = value;
        this.RaisePropertyChanged(nameof (orderIdentifier));
      }
    }

    [XmlArray(Order = 1)]
    [XmlArrayItem("orderRelationship", IsNullable = false)]
    public OrderRelationship[] relatedOrders
    {
      get => this.relatedOrdersField;
      set
      {
        this.relatedOrdersField = value;
        this.RaisePropertyChanged(nameof (relatedOrders));
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
