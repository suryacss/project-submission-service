// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.LeasedAccess
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
  public class LeasedAccess : LeasedResource
  {
    private string accessBandwidthField;
    private string provisioningIDField;
    private string orderComplexityField;
    private string glCodeField;
    private string totalTermField;
    private string totalMRCField;
    private string totalNRCField;

    [XmlElement(Order = 0)]
    public string accessBandwidth
    {
      get => this.accessBandwidthField;
      set
      {
        this.accessBandwidthField = value;
        this.RaisePropertyChanged(nameof (accessBandwidth));
      }
    }

    [XmlElement(Order = 1)]
    public string provisioningID
    {
      get => this.provisioningIDField;
      set
      {
        this.provisioningIDField = value;
        this.RaisePropertyChanged(nameof (provisioningID));
      }
    }

    [XmlElement(Order = 2)]
    public string orderComplexity
    {
      get => this.orderComplexityField;
      set
      {
        this.orderComplexityField = value;
        this.RaisePropertyChanged(nameof (orderComplexity));
      }
    }

    [XmlElement(Order = 3)]
    public string glCode
    {
      get => this.glCodeField;
      set
      {
        this.glCodeField = value;
        this.RaisePropertyChanged(nameof (glCode));
      }
    }

    [XmlElement(Order = 4)]
    public string totalTerm
    {
      get => this.totalTermField;
      set
      {
        this.totalTermField = value;
        this.RaisePropertyChanged(nameof (totalTerm));
      }
    }

    [XmlElement(Order = 5)]
    public string totalMRC
    {
      get => this.totalMRCField;
      set
      {
        this.totalMRCField = value;
        this.RaisePropertyChanged(nameof (totalMRC));
      }
    }

    [XmlElement(Order = 6)]
    public string totalNRC
    {
      get => this.totalNRCField;
      set
      {
        this.totalNRCField = value;
        this.RaisePropertyChanged(nameof (totalNRC));
      }
    }
  }
}
