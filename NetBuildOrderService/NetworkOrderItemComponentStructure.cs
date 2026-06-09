// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrderItemComponentStructure
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
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DebuggerStepThrough]
  [Serializable]
  public class NetworkOrderItemComponentStructure : INotifyPropertyChanged
  {
    private string networkOrderItemComponentNumberField;
    private string networkOrderItemComponentVersionField;
    private string networkOrderItemComponentActionTypeField;
    private string networkOrderItemComponentTypeField;
    private string networkOrderItemComponentStatusCodeField;
    private ActionableResourceStructure networkOrderItemComponentResourceField;

    [XmlElement(Order = 0)]
    public string networkOrderItemComponentNumber
    {
      get => this.networkOrderItemComponentNumberField;
      set
      {
        this.networkOrderItemComponentNumberField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentNumber));
      }
    }

    [XmlElement(Order = 1)]
    public string networkOrderItemComponentVersion
    {
      get => this.networkOrderItemComponentVersionField;
      set
      {
        this.networkOrderItemComponentVersionField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentVersion));
      }
    }

    [XmlElement(Order = 2)]
    public string networkOrderItemComponentActionType
    {
      get => this.networkOrderItemComponentActionTypeField;
      set
      {
        this.networkOrderItemComponentActionTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentActionType));
      }
    }

    [XmlElement(Order = 3)]
    public string networkOrderItemComponentType
    {
      get => this.networkOrderItemComponentTypeField;
      set
      {
        this.networkOrderItemComponentTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentType));
      }
    }

    [XmlElement(Order = 4)]
    public string networkOrderItemComponentStatusCode
    {
      get => this.networkOrderItemComponentStatusCodeField;
      set
      {
        this.networkOrderItemComponentStatusCodeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentStatusCode));
      }
    }

    [XmlElement(Order = 5)]
    public ActionableResourceStructure networkOrderItemComponentResource
    {
      get => this.networkOrderItemComponentResourceField;
      set
      {
        this.networkOrderItemComponentResourceField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentResource));
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
