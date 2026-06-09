// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.baseRequest
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
  [XmlInclude(typeof (findNetworkOrderItem))]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [XmlInclude(typeof (getSiteSurveyOrder))]
  [XmlInclude(typeof (getMaterialReplenishmentOrder))]
  [XmlInclude(typeof (createNetworkOrder))]
  [XmlInclude(typeof (getNetworkOrderItems))]
  [XmlInclude(typeof (getNetworkOrderItem))]
  [XmlInclude(typeof (getNetworkOrder))]
  [XmlInclude(typeof (getNetworkOrderItemComponent))]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [XmlInclude(typeof (getNetworkOrderShell))]
  [Serializable]
  public abstract class baseRequest : INotifyPropertyChanged
  {
    private Context contextField;
    private exception exceptionField;

    [XmlElement(Order = 0)]
    public Context context
    {
      get => this.contextField;
      set
      {
        this.contextField = value;
        this.RaisePropertyChanged(nameof (context));
      }
    }

    [XmlElement(Order = 1)]
    public exception exception
    {
      get => this.exceptionField;
      set
      {
        this.exceptionField = value;
        this.RaisePropertyChanged(nameof (exception));
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
