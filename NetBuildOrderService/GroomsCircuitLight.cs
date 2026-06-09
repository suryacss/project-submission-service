// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.GroomsCircuitLight
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
  public class GroomsCircuitLight : LeasedResource
  {
    private string hierarchyIndicatorField;
    private string eCCKTRelatedIdentifierField;
    private string cutLevelIndicatorField;
    private string planItemIdentifierField;
    private string bandwidthField;
    private string dataRateField;
    private string actionTypeQualifierField;
    private string pIIDField;
    private string dCSCrossConnectField;
    private string lTIDField;
    private string lECField;
    private string eCCKTField;
    private string provisioningIDField;
    private string customerNameField;

    [XmlElement(Order = 0)]
    public string hierarchyIndicator
    {
      get => this.hierarchyIndicatorField;
      set
      {
        this.hierarchyIndicatorField = value;
        this.RaisePropertyChanged(nameof (hierarchyIndicator));
      }
    }

    [XmlElement(Order = 1)]
    public string ECCKTRelatedIdentifier
    {
      get => this.eCCKTRelatedIdentifierField;
      set
      {
        this.eCCKTRelatedIdentifierField = value;
        this.RaisePropertyChanged(nameof (ECCKTRelatedIdentifier));
      }
    }

    [XmlElement(Order = 2)]
    public string cutLevelIndicator
    {
      get => this.cutLevelIndicatorField;
      set
      {
        this.cutLevelIndicatorField = value;
        this.RaisePropertyChanged(nameof (cutLevelIndicator));
      }
    }

    [XmlElement(Order = 3)]
    public string planItemIdentifier
    {
      get => this.planItemIdentifierField;
      set
      {
        this.planItemIdentifierField = value;
        this.RaisePropertyChanged(nameof (planItemIdentifier));
      }
    }

    [XmlElement(Order = 4)]
    public string bandwidth
    {
      get => this.bandwidthField;
      set
      {
        this.bandwidthField = value;
        this.RaisePropertyChanged(nameof (bandwidth));
      }
    }

    [XmlElement(Order = 5)]
    public string dataRate
    {
      get => this.dataRateField;
      set
      {
        this.dataRateField = value;
        this.RaisePropertyChanged(nameof (dataRate));
      }
    }

    [XmlElement(Order = 6)]
    public string actionTypeQualifier
    {
      get => this.actionTypeQualifierField;
      set
      {
        this.actionTypeQualifierField = value;
        this.RaisePropertyChanged(nameof (actionTypeQualifier));
      }
    }

    [XmlElement(Order = 7)]
    public string PIID
    {
      get => this.pIIDField;
      set
      {
        this.pIIDField = value;
        this.RaisePropertyChanged(nameof (PIID));
      }
    }

    [XmlElement(Order = 8)]
    public string DCSCrossConnect
    {
      get => this.dCSCrossConnectField;
      set
      {
        this.dCSCrossConnectField = value;
        this.RaisePropertyChanged(nameof (DCSCrossConnect));
      }
    }

    [XmlElement(Order = 9)]
    public string LTID
    {
      get => this.lTIDField;
      set
      {
        this.lTIDField = value;
        this.RaisePropertyChanged(nameof (LTID));
      }
    }

    [XmlElement(Order = 10)]
    public string LEC
    {
      get => this.lECField;
      set
      {
        this.lECField = value;
        this.RaisePropertyChanged(nameof (LEC));
      }
    }

    [XmlElement(Order = 11)]
    public string ECCKT
    {
      get => this.eCCKTField;
      set
      {
        this.eCCKTField = value;
        this.RaisePropertyChanged(nameof (ECCKT));
      }
    }

    [XmlElement(Order = 12)]
    public string provisioningID
    {
      get => this.provisioningIDField;
      set
      {
        this.provisioningIDField = value;
        this.RaisePropertyChanged(nameof (provisioningID));
      }
    }

    [XmlElement(Order = 13)]
    public string customerName
    {
      get => this.customerNameField;
      set
      {
        this.customerNameField = value;
        this.RaisePropertyChanged(nameof (customerName));
      }
    }
  }
}
