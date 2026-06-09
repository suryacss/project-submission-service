// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.OutsidePlant
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class OutsidePlant : PhysicalResource
  {
    private bool associateTNEtoGISField;
    private bool associateTNEtoGISFieldSpecified;
    private bool buildingAccessRequiredField;
    private bool buildingAccessRequiredFieldSpecified;
    private bool rOWRequiredField;
    private bool rOWRequiredFieldSpecified;
    private bool thirdPartyAgreementRequiredField;
    private bool thirdPartyAgreementRequiredFieldSpecified;
    private bool pFOGRequiredField;
    private bool pFOGRequiredFieldSpecified;
    private bool fieldEngineeringRequiredField;
    private bool fieldEngineeringRequiredFieldSpecified;
    private bool gISUpdateAsBuiltNeededField;
    private bool gISUpdateAsBuiltNeededFieldSpecified;
    private bool darkFiberTestingRequiredField;
    private bool darkFiberTestingRequiredFieldSpecified;
    private string flowField;
    private string buildingTypeField;
    private string managedByField;
    private string vendorNameField;

    [XmlElement(Order = 0)]
    public bool associateTNEtoGIS
    {
      get => this.associateTNEtoGISField;
      set
      {
        this.associateTNEtoGISField = value;
        this.RaisePropertyChanged(nameof (associateTNEtoGIS));
      }
    }

    [XmlIgnore]
    public bool associateTNEtoGISSpecified
    {
      get => this.associateTNEtoGISFieldSpecified;
      set
      {
        this.associateTNEtoGISFieldSpecified = value;
        this.RaisePropertyChanged(nameof (associateTNEtoGISSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public bool buildingAccessRequired
    {
      get => this.buildingAccessRequiredField;
      set
      {
        this.buildingAccessRequiredField = value;
        this.RaisePropertyChanged(nameof (buildingAccessRequired));
      }
    }

    [XmlIgnore]
    public bool buildingAccessRequiredSpecified
    {
      get => this.buildingAccessRequiredFieldSpecified;
      set
      {
        this.buildingAccessRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (buildingAccessRequiredSpecified));
      }
    }

    [XmlElement(Order = 2)]
    public bool ROWRequired
    {
      get => this.rOWRequiredField;
      set
      {
        this.rOWRequiredField = value;
        this.RaisePropertyChanged(nameof (ROWRequired));
      }
    }

    [XmlIgnore]
    public bool ROWRequiredSpecified
    {
      get => this.rOWRequiredFieldSpecified;
      set
      {
        this.rOWRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (ROWRequiredSpecified));
      }
    }

    [XmlElement(Order = 3)]
    public bool thirdPartyAgreementRequired
    {
      get => this.thirdPartyAgreementRequiredField;
      set
      {
        this.thirdPartyAgreementRequiredField = value;
        this.RaisePropertyChanged(nameof (thirdPartyAgreementRequired));
      }
    }

    [XmlIgnore]
    public bool thirdPartyAgreementRequiredSpecified
    {
      get => this.thirdPartyAgreementRequiredFieldSpecified;
      set
      {
        this.thirdPartyAgreementRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (thirdPartyAgreementRequiredSpecified));
      }
    }

    [XmlElement(Order = 4)]
    public bool PFOGRequired
    {
      get => this.pFOGRequiredField;
      set
      {
        this.pFOGRequiredField = value;
        this.RaisePropertyChanged(nameof (PFOGRequired));
      }
    }

    [XmlIgnore]
    public bool PFOGRequiredSpecified
    {
      get => this.pFOGRequiredFieldSpecified;
      set
      {
        this.pFOGRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (PFOGRequiredSpecified));
      }
    }

    [XmlElement(Order = 5)]
    public bool fieldEngineeringRequired
    {
      get => this.fieldEngineeringRequiredField;
      set
      {
        this.fieldEngineeringRequiredField = value;
        this.RaisePropertyChanged(nameof (fieldEngineeringRequired));
      }
    }

    [XmlIgnore]
    public bool fieldEngineeringRequiredSpecified
    {
      get => this.fieldEngineeringRequiredFieldSpecified;
      set
      {
        this.fieldEngineeringRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (fieldEngineeringRequiredSpecified));
      }
    }

    [XmlElement(Order = 6)]
    public bool GISUpdateAsBuiltNeeded
    {
      get => this.gISUpdateAsBuiltNeededField;
      set
      {
        this.gISUpdateAsBuiltNeededField = value;
        this.RaisePropertyChanged(nameof (GISUpdateAsBuiltNeeded));
      }
    }

    [XmlIgnore]
    public bool GISUpdateAsBuiltNeededSpecified
    {
      get => this.gISUpdateAsBuiltNeededFieldSpecified;
      set
      {
        this.gISUpdateAsBuiltNeededFieldSpecified = value;
        this.RaisePropertyChanged(nameof (GISUpdateAsBuiltNeededSpecified));
      }
    }

    [XmlElement(Order = 7)]
    public bool DarkFiberTestingRequired
    {
      get => this.darkFiberTestingRequiredField;
      set
      {
        this.darkFiberTestingRequiredField = value;
        this.RaisePropertyChanged(nameof (DarkFiberTestingRequired));
      }
    }

    [XmlIgnore]
    public bool DarkFiberTestingRequiredSpecified
    {
      get => this.darkFiberTestingRequiredFieldSpecified;
      set
      {
        this.darkFiberTestingRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (DarkFiberTestingRequiredSpecified));
      }
    }

    [XmlElement(Order = 8)]
    public string flow
    {
      get => this.flowField;
      set
      {
        this.flowField = value;
        this.RaisePropertyChanged(nameof (flow));
      }
    }

    [XmlElement(Order = 9)]
    public string buildingType
    {
      get => this.buildingTypeField;
      set
      {
        this.buildingTypeField = value;
        this.RaisePropertyChanged(nameof (buildingType));
      }
    }

    [XmlElement(Order = 10)]
    public string managedBy
    {
      get => this.managedByField;
      set
      {
        this.managedByField = value;
        this.RaisePropertyChanged(nameof (managedBy));
      }
    }

    [XmlElement(Order = 11)]
    public string vendorName
    {
      get => this.vendorNameField;
      set
      {
        this.vendorNameField = value;
        this.RaisePropertyChanged(nameof (vendorName));
      }
    }
  }
}
