// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.BuildGroup
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
  public class BuildGroup : INotifyPropertyChanged
  {
    private string buildGroupIdentifierField;
    private string buildGroupNameField;
    private string buildGroupMarketField;
    private Contact[] buildGroupContactsField;
    private DateTime fieldCommitDateField;
    private bool fieldCommitDateFieldSpecified;
    private DateTime planningRequestDateField;
    private bool planningRequestDateFieldSpecified;
    private DateTime revisedPlanningRequestDateField;
    private bool revisedPlanningRequestDateFieldSpecified;
    private DateTime actualCompleteDateField;
    private bool actualCompleteDateFieldSpecified;
    private bool fiberAssignmentsRequiredField;
    private bool fiberAssignmentsRequiredFieldSpecified;
    private string impactedNetworkField;
    private bool testAssistRequiredField;
    private bool testAssistRequiredFieldSpecified;
    private bool updateCADRequiredField;
    private bool updateCADRequiredFieldSpecified;
    private bool isLogiclIMTRingRequiredField;
    private bool isLogiclIMTRingRequiredFieldSpecified;
    private bool isRightOfWayRequiredField;
    private bool isRightOfWayRequiredFieldSpecified;
    private string rightofWayQtyField;
    private bool isBuildingAccessRequiredField;
    private bool isBuildingAccessRequiredFieldSpecified;
    private string buildingAccessQtyField;
    private bool isThirdPartyFiberOrConduitRequiredField;
    private bool isThirdPartyFiberOrConduitRequiredFieldSpecified;
    private string fiberOrConduitQtyField;
    private bool isThirdPartyColoRequiredField;
    private bool isThirdPartyColoRequiredFieldSpecified;
    private string coloQtyField;
    private bool isILECColoRequiredField;
    private bool isILECColoRequiredFieldSpecified;
    private string iLECColoQtyField;
    private bool isIXCColoRequiredField;
    private bool isIXCColoRequiredFieldSpecified;
    private string iXCColoQtyField;
    private bool metroEthernetHotCutFlagField;
    private bool metroEthernetHotCutFlagFieldSpecified;
    private GlobalChangeRequest[] gCRsField;
    private CustomerHeldOrder[] customerHeldOrdersField;
    private bool liveTrafficIndicatorField;
    private bool liveTrafficIndicatorFieldSpecified;

    [XmlElement(Order = 0)]
    public string buildGroupIdentifier
    {
      get => this.buildGroupIdentifierField;
      set
      {
        this.buildGroupIdentifierField = value;
        this.RaisePropertyChanged(nameof (buildGroupIdentifier));
      }
    }

    [XmlElement(Order = 1)]
    public string buildGroupName
    {
      get => this.buildGroupNameField;
      set
      {
        this.buildGroupNameField = value;
        this.RaisePropertyChanged(nameof (buildGroupName));
      }
    }

    [XmlElement(Order = 2)]
    public string buildGroupMarket
    {
      get => this.buildGroupMarketField;
      set
      {
        this.buildGroupMarketField = value;
        this.RaisePropertyChanged(nameof (buildGroupMarket));
      }
    }

    [XmlArray(Order = 3)]
    [XmlArrayItem("contact", IsNullable = false)]
    public Contact[] buildGroupContacts
    {
      get => this.buildGroupContactsField;
      set
      {
        this.buildGroupContactsField = value;
        this.RaisePropertyChanged(nameof (buildGroupContacts));
      }
    }

    [XmlElement(DataType = "date", Order = 4)]
    public DateTime fieldCommitDate
    {
      get => this.fieldCommitDateField;
      set
      {
        this.fieldCommitDateField = value;
        this.RaisePropertyChanged(nameof (fieldCommitDate));
      }
    }

    [XmlIgnore]
    public bool fieldCommitDateSpecified
    {
      get => this.fieldCommitDateFieldSpecified;
      set
      {
        this.fieldCommitDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (fieldCommitDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 5)]
    public DateTime planningRequestDate
    {
      get => this.planningRequestDateField;
      set
      {
        this.planningRequestDateField = value;
        this.RaisePropertyChanged(nameof (planningRequestDate));
      }
    }

    [XmlIgnore]
    public bool planningRequestDateSpecified
    {
      get => this.planningRequestDateFieldSpecified;
      set
      {
        this.planningRequestDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (planningRequestDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 6)]
    public DateTime revisedPlanningRequestDate
    {
      get => this.revisedPlanningRequestDateField;
      set
      {
        this.revisedPlanningRequestDateField = value;
        this.RaisePropertyChanged(nameof (revisedPlanningRequestDate));
      }
    }

    [XmlIgnore]
    public bool revisedPlanningRequestDateSpecified
    {
      get => this.revisedPlanningRequestDateFieldSpecified;
      set
      {
        this.revisedPlanningRequestDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (revisedPlanningRequestDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 7)]
    public DateTime actualCompleteDate
    {
      get => this.actualCompleteDateField;
      set
      {
        this.actualCompleteDateField = value;
        this.RaisePropertyChanged(nameof (actualCompleteDate));
      }
    }

    [XmlIgnore]
    public bool actualCompleteDateSpecified
    {
      get => this.actualCompleteDateFieldSpecified;
      set
      {
        this.actualCompleteDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (actualCompleteDateSpecified));
      }
    }

    [XmlElement(Order = 8)]
    public bool fiberAssignmentsRequired
    {
      get => this.fiberAssignmentsRequiredField;
      set
      {
        this.fiberAssignmentsRequiredField = value;
        this.RaisePropertyChanged(nameof (fiberAssignmentsRequired));
      }
    }

    [XmlIgnore]
    public bool fiberAssignmentsRequiredSpecified
    {
      get => this.fiberAssignmentsRequiredFieldSpecified;
      set
      {
        this.fiberAssignmentsRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (fiberAssignmentsRequiredSpecified));
      }
    }

    [XmlElement(Order = 9)]
    public string impactedNetwork
    {
      get => this.impactedNetworkField;
      set
      {
        this.impactedNetworkField = value;
        this.RaisePropertyChanged(nameof (impactedNetwork));
      }
    }

    [XmlElement(Order = 10)]
    public bool testAssistRequired
    {
      get => this.testAssistRequiredField;
      set
      {
        this.testAssistRequiredField = value;
        this.RaisePropertyChanged(nameof (testAssistRequired));
      }
    }

    [XmlIgnore]
    public bool testAssistRequiredSpecified
    {
      get => this.testAssistRequiredFieldSpecified;
      set
      {
        this.testAssistRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (testAssistRequiredSpecified));
      }
    }

    [XmlElement(Order = 11)]
    public bool updateCADRequired
    {
      get => this.updateCADRequiredField;
      set
      {
        this.updateCADRequiredField = value;
        this.RaisePropertyChanged(nameof (updateCADRequired));
      }
    }

    [XmlIgnore]
    public bool updateCADRequiredSpecified
    {
      get => this.updateCADRequiredFieldSpecified;
      set
      {
        this.updateCADRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (updateCADRequiredSpecified));
      }
    }

    [XmlElement(Order = 12)]
    public bool isLogiclIMTRingRequired
    {
      get => this.isLogiclIMTRingRequiredField;
      set
      {
        this.isLogiclIMTRingRequiredField = value;
        this.RaisePropertyChanged(nameof (isLogiclIMTRingRequired));
      }
    }

    [XmlIgnore]
    public bool isLogiclIMTRingRequiredSpecified
    {
      get => this.isLogiclIMTRingRequiredFieldSpecified;
      set
      {
        this.isLogiclIMTRingRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (isLogiclIMTRingRequiredSpecified));
      }
    }

    [XmlElement(Order = 13)]
    public bool isRightOfWayRequired
    {
      get => this.isRightOfWayRequiredField;
      set
      {
        this.isRightOfWayRequiredField = value;
        this.RaisePropertyChanged(nameof (isRightOfWayRequired));
      }
    }

    [XmlIgnore]
    public bool isRightOfWayRequiredSpecified
    {
      get => this.isRightOfWayRequiredFieldSpecified;
      set
      {
        this.isRightOfWayRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (isRightOfWayRequiredSpecified));
      }
    }

    [XmlElement(Order = 14)]
    public string rightofWayQty
    {
      get => this.rightofWayQtyField;
      set
      {
        this.rightofWayQtyField = value;
        this.RaisePropertyChanged(nameof (rightofWayQty));
      }
    }

    [XmlElement(Order = 15)]
    public bool isBuildingAccessRequired
    {
      get => this.isBuildingAccessRequiredField;
      set
      {
        this.isBuildingAccessRequiredField = value;
        this.RaisePropertyChanged(nameof (isBuildingAccessRequired));
      }
    }

    [XmlIgnore]
    public bool isBuildingAccessRequiredSpecified
    {
      get => this.isBuildingAccessRequiredFieldSpecified;
      set
      {
        this.isBuildingAccessRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (isBuildingAccessRequiredSpecified));
      }
    }

    [XmlElement(Order = 16)]
    public string buildingAccessQty
    {
      get => this.buildingAccessQtyField;
      set
      {
        this.buildingAccessQtyField = value;
        this.RaisePropertyChanged(nameof (buildingAccessQty));
      }
    }

    [XmlElement(Order = 17)]
    public bool isThirdPartyFiberOrConduitRequired
    {
      get => this.isThirdPartyFiberOrConduitRequiredField;
      set
      {
        this.isThirdPartyFiberOrConduitRequiredField = value;
        this.RaisePropertyChanged(nameof (isThirdPartyFiberOrConduitRequired));
      }
    }

    [XmlIgnore]
    public bool isThirdPartyFiberOrConduitRequiredSpecified
    {
      get => this.isThirdPartyFiberOrConduitRequiredFieldSpecified;
      set
      {
        this.isThirdPartyFiberOrConduitRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (isThirdPartyFiberOrConduitRequiredSpecified));
      }
    }

    [XmlElement(Order = 18)]
    public string fiberOrConduitQty
    {
      get => this.fiberOrConduitQtyField;
      set
      {
        this.fiberOrConduitQtyField = value;
        this.RaisePropertyChanged(nameof (fiberOrConduitQty));
      }
    }

    [XmlElement(Order = 19)]
    public bool isThirdPartyColoRequired
    {
      get => this.isThirdPartyColoRequiredField;
      set
      {
        this.isThirdPartyColoRequiredField = value;
        this.RaisePropertyChanged(nameof (isThirdPartyColoRequired));
      }
    }

    [XmlIgnore]
    public bool isThirdPartyColoRequiredSpecified
    {
      get => this.isThirdPartyColoRequiredFieldSpecified;
      set
      {
        this.isThirdPartyColoRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (isThirdPartyColoRequiredSpecified));
      }
    }

    [XmlElement(Order = 20)]
    public string coloQty
    {
      get => this.coloQtyField;
      set
      {
        this.coloQtyField = value;
        this.RaisePropertyChanged(nameof (coloQty));
      }
    }

    [XmlElement(Order = 21)]
    public bool isILECColoRequired
    {
      get => this.isILECColoRequiredField;
      set
      {
        this.isILECColoRequiredField = value;
        this.RaisePropertyChanged(nameof (isILECColoRequired));
      }
    }

    [XmlIgnore]
    public bool isILECColoRequiredSpecified
    {
      get => this.isILECColoRequiredFieldSpecified;
      set
      {
        this.isILECColoRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (isILECColoRequiredSpecified));
      }
    }

    [XmlElement(Order = 22)]
    public string ILECColoQty
    {
      get => this.iLECColoQtyField;
      set
      {
        this.iLECColoQtyField = value;
        this.RaisePropertyChanged(nameof (ILECColoQty));
      }
    }

    [XmlElement(Order = 23)]
    public bool isIXCColoRequired
    {
      get => this.isIXCColoRequiredField;
      set
      {
        this.isIXCColoRequiredField = value;
        this.RaisePropertyChanged(nameof (isIXCColoRequired));
      }
    }

    [XmlIgnore]
    public bool isIXCColoRequiredSpecified
    {
      get => this.isIXCColoRequiredFieldSpecified;
      set
      {
        this.isIXCColoRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (isIXCColoRequiredSpecified));
      }
    }

    [XmlElement(Order = 24)]
    public string IXCColoQty
    {
      get => this.iXCColoQtyField;
      set
      {
        this.iXCColoQtyField = value;
        this.RaisePropertyChanged(nameof (IXCColoQty));
      }
    }

    [XmlElement(Order = 25)]
    public bool MetroEthernetHotCutFlag
    {
      get => this.metroEthernetHotCutFlagField;
      set
      {
        this.metroEthernetHotCutFlagField = value;
        this.RaisePropertyChanged(nameof (MetroEthernetHotCutFlag));
      }
    }

    [XmlIgnore]
    public bool MetroEthernetHotCutFlagSpecified
    {
      get => this.metroEthernetHotCutFlagFieldSpecified;
      set
      {
        this.metroEthernetHotCutFlagFieldSpecified = value;
        this.RaisePropertyChanged(nameof (MetroEthernetHotCutFlagSpecified));
      }
    }

    [XmlArrayItem("GCR", IsNullable = false)]
    [XmlArray(Order = 26)]
    public GlobalChangeRequest[] GCRs
    {
      get => this.gCRsField;
      set
      {
        this.gCRsField = value;
        this.RaisePropertyChanged(nameof (GCRs));
      }
    }

    [XmlArrayItem("heldOrder", IsNullable = false)]
    [XmlArray(Order = 27)]
    public CustomerHeldOrder[] customerHeldOrders
    {
      get => this.customerHeldOrdersField;
      set
      {
        this.customerHeldOrdersField = value;
        this.RaisePropertyChanged(nameof (customerHeldOrders));
      }
    }

    [XmlElement(Order = 28)]
    public bool liveTrafficIndicator
    {
      get => this.liveTrafficIndicatorField;
      set
      {
        this.liveTrafficIndicatorField = value;
        this.RaisePropertyChanged(nameof (liveTrafficIndicator));
      }
    }

    [XmlIgnore]
    public bool liveTrafficIndicatorSpecified
    {
      get => this.liveTrafficIndicatorFieldSpecified;
      set
      {
        this.liveTrafficIndicatorFieldSpecified = value;
        this.RaisePropertyChanged(nameof (liveTrafficIndicatorSpecified));
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
