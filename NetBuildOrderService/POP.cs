// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.POP
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
  public class POP : PhysicalResource
  {
    private bool buildingAccessAgreementField;
    private bool buildingAccessAgreementFieldSpecified;
    private bool contractedLaborField;
    private bool contractedLaborFieldSpecified;
    private string contractingGroupField;

    [XmlElement(Order = 0)]
    public bool buildingAccessAgreement
    {
      get => this.buildingAccessAgreementField;
      set
      {
        this.buildingAccessAgreementField = value;
        this.RaisePropertyChanged(nameof (buildingAccessAgreement));
      }
    }

    [XmlIgnore]
    public bool buildingAccessAgreementSpecified
    {
      get => this.buildingAccessAgreementFieldSpecified;
      set
      {
        this.buildingAccessAgreementFieldSpecified = value;
        this.RaisePropertyChanged(nameof (buildingAccessAgreementSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public bool contractedLabor
    {
      get => this.contractedLaborField;
      set
      {
        this.contractedLaborField = value;
        this.RaisePropertyChanged(nameof (contractedLabor));
      }
    }

    [XmlIgnore]
    public bool contractedLaborSpecified
    {
      get => this.contractedLaborFieldSpecified;
      set
      {
        this.contractedLaborFieldSpecified = value;
        this.RaisePropertyChanged(nameof (contractedLaborSpecified));
      }
    }

    [XmlElement(Order = 2)]
    public string contractingGroup
    {
      get => this.contractingGroupField;
      set
      {
        this.contractingGroupField = value;
        this.RaisePropertyChanged(nameof (contractingGroup));
      }
    }
  }
}
