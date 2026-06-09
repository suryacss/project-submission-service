// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.findNetworkOrderItem
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [Serializable]
  public class findNetworkOrderItem : baseRequest
  {
    private NetworkOrderSearchCriteria orderSearchCriteriaField;
    private NetworkOrderItemSearchCriteria orderItemSearchCriteriaField;
    private NetworkOrderItemComponentSearchCriteria orderItemComponentSearchCriteriaField;
    private ResourceSearchCriteria resourceSearchCriteriaField;
    private int maxResultsField;
    private bool maxResultsFieldSpecified;

    [XmlElement(Order = 0)]
    public NetworkOrderSearchCriteria orderSearchCriteria
    {
      get => this.orderSearchCriteriaField;
      set
      {
        this.orderSearchCriteriaField = value;
        this.RaisePropertyChanged(nameof (orderSearchCriteria));
      }
    }

    [XmlElement(Order = 1)]
    public NetworkOrderItemSearchCriteria orderItemSearchCriteria
    {
      get => this.orderItemSearchCriteriaField;
      set
      {
        this.orderItemSearchCriteriaField = value;
        this.RaisePropertyChanged(nameof (orderItemSearchCriteria));
      }
    }

    [XmlElement(Order = 2)]
    public NetworkOrderItemComponentSearchCriteria orderItemComponentSearchCriteria
    {
      get => this.orderItemComponentSearchCriteriaField;
      set
      {
        this.orderItemComponentSearchCriteriaField = value;
        this.RaisePropertyChanged(nameof (orderItemComponentSearchCriteria));
      }
    }

    [XmlElement(Order = 3)]
    public ResourceSearchCriteria resourceSearchCriteria
    {
      get => this.resourceSearchCriteriaField;
      set
      {
        this.resourceSearchCriteriaField = value;
        this.RaisePropertyChanged(nameof (resourceSearchCriteria));
      }
    }

    [XmlElement(Order = 4)]
    public int maxResults
    {
      get => this.maxResultsField;
      set
      {
        this.maxResultsField = value;
        this.RaisePropertyChanged(nameof (maxResults));
      }
    }

    [XmlIgnore]
    public bool maxResultsSpecified
    {
      get => this.maxResultsFieldSpecified;
      set
      {
        this.maxResultsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (maxResultsSpecified));
      }
    }
  }
}
