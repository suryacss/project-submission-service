// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrderItemSearchCriteria
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
  public class NetworkOrderItemSearchCriteria : INotifyPropertyChanged
  {
    private MatchType matchTypeField;
    private bool matchTypeFieldSpecified;
    private string networkOrderItemNumberField;
    private string networkOrderItemVersionField;
    private string networkOrderItemActionTypeField;

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
    public string networkOrderItemNumber
    {
      get => this.networkOrderItemNumberField;
      set
      {
        this.networkOrderItemNumberField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemNumber));
      }
    }

    [XmlElement(Order = 2)]
    public string networkOrderItemVersion
    {
      get => this.networkOrderItemVersionField;
      set
      {
        this.networkOrderItemVersionField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemVersion));
      }
    }

    [XmlElement(Order = 3)]
    public string networkOrderItemActionType
    {
      get => this.networkOrderItemActionTypeField;
      set
      {
        this.networkOrderItemActionTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemActionType));
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
