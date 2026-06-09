// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrderItemComponentSearchCriteria
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
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class NetworkOrderItemComponentSearchCriteria : INotifyPropertyChanged
  {
    private MatchType matchTypeField;
    private bool matchTypeFieldSpecified;
    private string networkOrderItemComponentNumberField;
    private string networkOrderItemComponentVersionField;
    private string networkOrderItemComponentActionTypeField;

    [XmlElement(Order = 0)]
    public MatchType matchType
    {
      get => this.matchTypeField;
      set
      {
        this.matchTypeField = value;
        this.RaisePropertyChanged(nameof (matchType));
      }
    }

    [XmlIgnore]
    public bool matchTypeSpecified
    {
      get => this.matchTypeFieldSpecified;
      set
      {
        this.matchTypeFieldSpecified = value;
        this.RaisePropertyChanged(nameof (matchTypeSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public string networkOrderItemComponentNumber
    {
      get => this.networkOrderItemComponentNumberField;
      set
      {
        this.networkOrderItemComponentNumberField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentNumber));
      }
    }

    [XmlElement(Order = 2)]
    public string networkOrderItemComponentVersion
    {
      get => this.networkOrderItemComponentVersionField;
      set
      {
        this.networkOrderItemComponentVersionField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentVersion));
      }
    }

    [XmlElement(Order = 3)]
    public string networkOrderItemComponentActionType
    {
      get => this.networkOrderItemComponentActionTypeField;
      set
      {
        this.networkOrderItemComponentActionTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponentActionType));
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
