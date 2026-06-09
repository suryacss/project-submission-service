// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.GroomsCircuit
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
  public class GroomsCircuit : LeasedResource
  {
    private string hierarchyIndicatorField;
    private string actionTypeQualifierField;
    private string legacyCompanyNameField;
    private string termField;
    private string termLiabilityField;
    private string parentLECField;
    private string controllingVendorIndicatorField;
    private string aSCRepresentativeNameField;
    private string pCOContactNameField;
    private string customerContactEmailField;
    private string customerContactNameField;
    private string trunkDirectionField;
    private string huntTypeField;
    private string glareTypeField;
    private string protocolVariantField;
    private string trafficClassField;
    private string tandemField;
    private string muxLocField;
    private string pSLField;
    private string aLBRField;
    private string trkQuantityField;
    private string tcicRangeField;
    private string fACTLField;
    private string pSLIField;
    private string scenarioField;
    private string reqTypeField;
    private string signalingField;
    private string subtendingOfficesTSCField;
    private DateTime fOCDateField;
    private bool fOCDateFieldSpecified;
    private string lECField;
    private string bANField;
    private string eCCKTField;
    private string eCCKTRelatedIdentifierField;
    private string provisioningIDField;
    private string channelField;
    private string cFAField;
    private string pONField;
    private string tSCField;
    private string pIUField;
    private string pLUField;
    private string aCTLField;
    private string oldSPMField;
    private string customerNameField;
    private string cutPointDetailsField;
    private string level3ProductField;
    private string bandwidthField;
    private string dataRateField;
    private string meetPointIndicatorField;
    private string framingField;
    private string lineCodingField;
    private string channelizationIndicatorField;
    private string glCodeField;
    private string pIIDField;
    private string pNUMField;
    private string lTIDField;
    private string routerField;
    private string dCSCrossConnectField;
    private string orderStatusField;
    private string aSRStatusField;
    private string tSPCodeField;
    private string leasedTransportACLLIField;
    private string eccktACLLIField;
    private string ultimateACLLIField;
    private string leasedTransportZCLLIField;
    private string eccktZCLLIField;
    private string ultimateZCLLIField;
    private string level3CLLIField;
    private string tCILowField;
    private string tCIHighField;
    private string hubbingCompanyField;
    private string muxIndicatorField;
    private string overflowTSCField;
    private string swtLRNField;
    private string swtMarketField;
    private string swtLPCField;
    private string swtSwitchedOfficeField;
    private string swtSPMField;
    private string swtSPMPortField;
    private string swtSPMMembersField;
    private int numberSST1sField;
    private bool numberSST1sFieldSpecified;
    private int numberSAT1sField;
    private bool numberSAT1sFieldSpecified;
    private int numberTSCsField;
    private bool numberTSCsFieldSpecified;
    private string reservationIdentifierField;
    private string interconnectAssignmentField;
    private string tLTIDField;
    private string endUserCustomerField;
    private string cutLevelIndicatorField;
    private string gatewayLocNumField;
    private string addressNPANXXField;
    private string aEndEccktNPANXXField;
    private string zEndEccktNPANXXField;
    private string trunkGroupEIDField;
    private string trunkGroupTypeField;
    private string routeField;
    private string carrierIdentityField;
    private string companyCodeField;
    private string percentInterstateUsageField;
    private string percentLocalUsageField;
    private string accessPointOfTerminationField;
    private string secondaryLocationField;
    private string e911IncludedField;
    private string e911TrafficClassField;
    private string e911CarrierParityField;
    private string e911DefaultPSAPField;
    private string e911DefaultESNField;
    private string e911FIPSField;
    private string e911DFTNField;
    private string e911LocationField;
    private string e911TNField;
    private string e911HotCutField;
    private string aCNAField;
    private string cCNAField;
    private string iCSCField;
    private string meetPointVendorField;
    private string meetPointStatusField;
    private string fCKTField;
    private string sCFAField;
    private string sPECField;
    private DateTime lastInvoiceDateField;
    private bool lastInvoiceDateFieldSpecified;
    private DateTime serviceEstablishedDateField;
    private bool serviceEstablishedDateFieldSpecified;
    private Decimal mRCField;
    private bool mRCFieldSpecified;
    private Decimal mRCSavingsField;
    private bool mRCSavingsFieldSpecified;
    private Decimal nRCField;
    private bool nRCFieldSpecified;
    private string inventoryUsedForField;
    private string inventoryStatusField;
    private string eccktTermField;
    private string eccktTermVTAIField;
    private DateTime eccktTermStartDateField;
    private bool eccktTermStartDateFieldSpecified;
    private string customerTermField;
    private DateTime customerTermStartDateField;
    private bool customerTermStartDateFieldSpecified;
    private string segmentTypeField;
    private DateTime pONDueDateField;
    private bool pONDueDateFieldSpecified;
    private DateTime aSRDesiredDueDateField;
    private bool aSRDesiredDueDateFieldSpecified;
    private DateTime expectedTermEndDateField;
    private bool expectedTermEndDateFieldSpecified;
    private string uSOCField;
    private string cICSField;
    private string channelTermField;
    private string mileageField;
    private string lATAField;
    private string mSAField;
    private string aPOTField;
    private string channelStatusField;
    private string customerContactNumberField;
    private string logicalMemberEIDField;
    private string originatingCompanyNameField;
    private string protectionField;
    private string sCIDField;
    private string switchCLLIField;
    private string zip4Field;
    private string planItemIdentifierField;
    private string cFALetterofAuthorizationField;
    private string cPADeterminationField;
    private string lTPField;
    private string cCEAField;
    private string sCCEAField;
    private string localPointCodeField;
    private bool dualProvisioningCompleteIndicatorField;
    private bool dualProvisioningCompleteIndicatorFieldSpecified;

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
    public string actionTypeQualifier
    {
      get => this.actionTypeQualifierField;
      set
      {
        this.actionTypeQualifierField = value;
        this.RaisePropertyChanged(nameof (actionTypeQualifier));
      }
    }

    [XmlElement(Order = 2)]
    public string legacyCompanyName
    {
      get => this.legacyCompanyNameField;
      set
      {
        this.legacyCompanyNameField = value;
        this.RaisePropertyChanged(nameof (legacyCompanyName));
      }
    }

    [XmlElement(Order = 3)]
    public string term
    {
      get => this.termField;
      set
      {
        this.termField = value;
        this.RaisePropertyChanged(nameof (term));
      }
    }

    [XmlElement(Order = 4)]
    public string termLiability
    {
      get => this.termLiabilityField;
      set
      {
        this.termLiabilityField = value;
        this.RaisePropertyChanged(nameof (termLiability));
      }
    }

    [XmlElement(Order = 5)]
    public string parentLEC
    {
      get => this.parentLECField;
      set
      {
        this.parentLECField = value;
        this.RaisePropertyChanged(nameof (parentLEC));
      }
    }

    [XmlElement(Order = 6)]
    public string controllingVendorIndicator
    {
      get => this.controllingVendorIndicatorField;
      set
      {
        this.controllingVendorIndicatorField = value;
        this.RaisePropertyChanged(nameof (controllingVendorIndicator));
      }
    }

    [XmlElement(Order = 7)]
    public string ASCRepresentativeName
    {
      get => this.aSCRepresentativeNameField;
      set
      {
        this.aSCRepresentativeNameField = value;
        this.RaisePropertyChanged(nameof (ASCRepresentativeName));
      }
    }

    [XmlElement(Order = 8)]
    public string PCOContactName
    {
      get => this.pCOContactNameField;
      set
      {
        this.pCOContactNameField = value;
        this.RaisePropertyChanged(nameof (PCOContactName));
      }
    }

    [XmlElement(Order = 9)]
    public string customerContactEmail
    {
      get => this.customerContactEmailField;
      set
      {
        this.customerContactEmailField = value;
        this.RaisePropertyChanged(nameof (customerContactEmail));
      }
    }

    [XmlElement(Order = 10)]
    public string customerContactName
    {
      get => this.customerContactNameField;
      set
      {
        this.customerContactNameField = value;
        this.RaisePropertyChanged(nameof (customerContactName));
      }
    }

    [XmlElement(Order = 11)]
    public string trunkDirection
    {
      get => this.trunkDirectionField;
      set
      {
        this.trunkDirectionField = value;
        this.RaisePropertyChanged(nameof (trunkDirection));
      }
    }

    [XmlElement(Order = 12)]
    public string huntType
    {
      get => this.huntTypeField;
      set
      {
        this.huntTypeField = value;
        this.RaisePropertyChanged(nameof (huntType));
      }
    }

    [XmlElement(Order = 13)]
    public string glareType
    {
      get => this.glareTypeField;
      set
      {
        this.glareTypeField = value;
        this.RaisePropertyChanged(nameof (glareType));
      }
    }

    [XmlElement(Order = 14)]
    public string protocolVariant
    {
      get => this.protocolVariantField;
      set
      {
        this.protocolVariantField = value;
        this.RaisePropertyChanged(nameof (protocolVariant));
      }
    }

    [XmlElement(Order = 15)]
    public string trafficClass
    {
      get => this.trafficClassField;
      set
      {
        this.trafficClassField = value;
        this.RaisePropertyChanged(nameof (trafficClass));
      }
    }

    [XmlElement(Order = 16)]
    public string tandem
    {
      get => this.tandemField;
      set
      {
        this.tandemField = value;
        this.RaisePropertyChanged(nameof (tandem));
      }
    }

    [XmlElement(Order = 17)]
    public string muxLoc
    {
      get => this.muxLocField;
      set
      {
        this.muxLocField = value;
        this.RaisePropertyChanged(nameof (muxLoc));
      }
    }

    [XmlElement(Order = 18)]
    public string PSL
    {
      get => this.pSLField;
      set
      {
        this.pSLField = value;
        this.RaisePropertyChanged(nameof (PSL));
      }
    }

    [XmlElement(Order = 19)]
    public string ALBR
    {
      get => this.aLBRField;
      set
      {
        this.aLBRField = value;
        this.RaisePropertyChanged(nameof (ALBR));
      }
    }

    [XmlElement(Order = 20)]
    public string trkQuantity
    {
      get => this.trkQuantityField;
      set
      {
        this.trkQuantityField = value;
        this.RaisePropertyChanged(nameof (trkQuantity));
      }
    }

    [XmlElement(Order = 21)]
    public string tcicRange
    {
      get => this.tcicRangeField;
      set
      {
        this.tcicRangeField = value;
        this.RaisePropertyChanged(nameof (tcicRange));
      }
    }

    [XmlElement(Order = 22)]
    public string FACTL
    {
      get => this.fACTLField;
      set
      {
        this.fACTLField = value;
        this.RaisePropertyChanged(nameof (FACTL));
      }
    }

    [XmlElement(Order = 23)]
    public string PSLI
    {
      get => this.pSLIField;
      set
      {
        this.pSLIField = value;
        this.RaisePropertyChanged(nameof (PSLI));
      }
    }

    [XmlElement(Order = 24)]
    public string scenario
    {
      get => this.scenarioField;
      set
      {
        this.scenarioField = value;
        this.RaisePropertyChanged(nameof (scenario));
      }
    }

    [XmlElement(Order = 25)]
    public string reqType
    {
      get => this.reqTypeField;
      set
      {
        this.reqTypeField = value;
        this.RaisePropertyChanged(nameof (reqType));
      }
    }

    [XmlElement(Order = 26)]
    public string signaling
    {
      get => this.signalingField;
      set
      {
        this.signalingField = value;
        this.RaisePropertyChanged(nameof (signaling));
      }
    }

    [XmlElement(Order = 27)]
    public string subtendingOfficesTSC
    {
      get => this.subtendingOfficesTSCField;
      set
      {
        this.subtendingOfficesTSCField = value;
        this.RaisePropertyChanged(nameof (subtendingOfficesTSC));
      }
    }

    [XmlElement(DataType = "date", Order = 28)]
    public DateTime FOCDate
    {
      get => this.fOCDateField;
      set
      {
        this.fOCDateField = value;
        this.RaisePropertyChanged(nameof (FOCDate));
      }
    }

    [XmlIgnore]
    public bool FOCDateSpecified
    {
      get => this.fOCDateFieldSpecified;
      set
      {
        this.fOCDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (FOCDateSpecified));
      }
    }

    [XmlElement(Order = 29)]
    public string LEC
    {
      get => this.lECField;
      set
      {
        this.lECField = value;
        this.RaisePropertyChanged(nameof (LEC));
      }
    }

    [XmlElement(Order = 30)]
    public string BAN
    {
      get => this.bANField;
      set
      {
        this.bANField = value;
        this.RaisePropertyChanged(nameof (BAN));
      }
    }

    [XmlElement(Order = 31)]
    public string ECCKT
    {
      get => this.eCCKTField;
      set
      {
        this.eCCKTField = value;
        this.RaisePropertyChanged(nameof (ECCKT));
      }
    }

    [XmlElement(Order = 32)]
    public string ECCKTRelatedIdentifier
    {
      get => this.eCCKTRelatedIdentifierField;
      set
      {
        this.eCCKTRelatedIdentifierField = value;
        this.RaisePropertyChanged(nameof (ECCKTRelatedIdentifier));
      }
    }

    [XmlElement(Order = 33)]
    public string provisioningID
    {
      get => this.provisioningIDField;
      set
      {
        this.provisioningIDField = value;
        this.RaisePropertyChanged(nameof (provisioningID));
      }
    }

    [XmlElement(Order = 34)]
    public string channel
    {
      get => this.channelField;
      set
      {
        this.channelField = value;
        this.RaisePropertyChanged(nameof (channel));
      }
    }

    [XmlElement(Order = 35)]
    public string CFA
    {
      get => this.cFAField;
      set
      {
        this.cFAField = value;
        this.RaisePropertyChanged(nameof (CFA));
      }
    }

    [XmlElement(Order = 36)]
    public string PON
    {
      get => this.pONField;
      set
      {
        this.pONField = value;
        this.RaisePropertyChanged(nameof (PON));
      }
    }

    [XmlElement(Order = 37)]
    public string TSC
    {
      get => this.tSCField;
      set
      {
        this.tSCField = value;
        this.RaisePropertyChanged(nameof (TSC));
      }
    }

    [XmlElement(Order = 38)]
    public string PIU
    {
      get => this.pIUField;
      set
      {
        this.pIUField = value;
        this.RaisePropertyChanged(nameof (PIU));
      }
    }

    [XmlElement(Order = 39)]
    public string PLU
    {
      get => this.pLUField;
      set
      {
        this.pLUField = value;
        this.RaisePropertyChanged(nameof (PLU));
      }
    }

    [XmlElement(Order = 40)]
    public string ACTL
    {
      get => this.aCTLField;
      set
      {
        this.aCTLField = value;
        this.RaisePropertyChanged(nameof (ACTL));
      }
    }

    [XmlElement(Order = 41)]
    public string oldSPM
    {
      get => this.oldSPMField;
      set
      {
        this.oldSPMField = value;
        this.RaisePropertyChanged(nameof (oldSPM));
      }
    }

    [XmlElement(Order = 42)]
    public string customerName
    {
      get => this.customerNameField;
      set
      {
        this.customerNameField = value;
        this.RaisePropertyChanged(nameof (customerName));
      }
    }

    [XmlElement(Order = 43)]
    public string cutPointDetails
    {
      get => this.cutPointDetailsField;
      set
      {
        this.cutPointDetailsField = value;
        this.RaisePropertyChanged(nameof (cutPointDetails));
      }
    }

    [XmlElement(Order = 44)]
    public string level3Product
    {
      get => this.level3ProductField;
      set
      {
        this.level3ProductField = value;
        this.RaisePropertyChanged(nameof (level3Product));
      }
    }

    [XmlElement(Order = 45)]
    public string bandwidth
    {
      get => this.bandwidthField;
      set
      {
        this.bandwidthField = value;
        this.RaisePropertyChanged(nameof (bandwidth));
      }
    }

    [XmlElement(Order = 46)]
    public string dataRate
    {
      get => this.dataRateField;
      set
      {
        this.dataRateField = value;
        this.RaisePropertyChanged(nameof (dataRate));
      }
    }

    [XmlElement(Order = 47)]
    public string meetPointIndicator
    {
      get => this.meetPointIndicatorField;
      set
      {
        this.meetPointIndicatorField = value;
        this.RaisePropertyChanged(nameof (meetPointIndicator));
      }
    }

    [XmlElement(Order = 48)]
    public string framing
    {
      get => this.framingField;
      set
      {
        this.framingField = value;
        this.RaisePropertyChanged(nameof (framing));
      }
    }

    [XmlElement(Order = 49)]
    public string lineCoding
    {
      get => this.lineCodingField;
      set
      {
        this.lineCodingField = value;
        this.RaisePropertyChanged(nameof (lineCoding));
      }
    }

    [XmlElement(Order = 50)]
    public string channelizationIndicator
    {
      get => this.channelizationIndicatorField;
      set
      {
        this.channelizationIndicatorField = value;
        this.RaisePropertyChanged(nameof (channelizationIndicator));
      }
    }

    [XmlElement(Order = 51)]
    public string glCode
    {
      get => this.glCodeField;
      set
      {
        this.glCodeField = value;
        this.RaisePropertyChanged(nameof (glCode));
      }
    }

    [XmlElement(Order = 52)]
    public string PIID
    {
      get => this.pIIDField;
      set
      {
        this.pIIDField = value;
        this.RaisePropertyChanged(nameof (PIID));
      }
    }

    [XmlElement(Order = 53)]
    public string PNUM
    {
      get => this.pNUMField;
      set
      {
        this.pNUMField = value;
        this.RaisePropertyChanged(nameof (PNUM));
      }
    }

    [XmlElement(Order = 54)]
    public string LTID
    {
      get => this.lTIDField;
      set
      {
        this.lTIDField = value;
        this.RaisePropertyChanged(nameof (LTID));
      }
    }

    [XmlElement(Order = 55)]
    public string router
    {
      get => this.routerField;
      set
      {
        this.routerField = value;
        this.RaisePropertyChanged(nameof (router));
      }
    }

    [XmlElement(Order = 56)]
    public string DCSCrossConnect
    {
      get => this.dCSCrossConnectField;
      set
      {
        this.dCSCrossConnectField = value;
        this.RaisePropertyChanged(nameof (DCSCrossConnect));
      }
    }

    [XmlElement(Order = 57)]
    public string orderStatus
    {
      get => this.orderStatusField;
      set
      {
        this.orderStatusField = value;
        this.RaisePropertyChanged(nameof (orderStatus));
      }
    }

    [XmlElement(Order = 58)]
    public string ASRStatus
    {
      get => this.aSRStatusField;
      set
      {
        this.aSRStatusField = value;
        this.RaisePropertyChanged(nameof (ASRStatus));
      }
    }

    [XmlElement(Order = 59)]
    public string TSPCode
    {
      get => this.tSPCodeField;
      set
      {
        this.tSPCodeField = value;
        this.RaisePropertyChanged(nameof (TSPCode));
      }
    }

    [XmlElement(Order = 60)]
    public string leasedTransportACLLI
    {
      get => this.leasedTransportACLLIField;
      set
      {
        this.leasedTransportACLLIField = value;
        this.RaisePropertyChanged(nameof (leasedTransportACLLI));
      }
    }

    [XmlElement(Order = 61)]
    public string eccktACLLI
    {
      get => this.eccktACLLIField;
      set
      {
        this.eccktACLLIField = value;
        this.RaisePropertyChanged(nameof (eccktACLLI));
      }
    }

    [XmlElement(Order = 62)]
    public string ultimateACLLI
    {
      get => this.ultimateACLLIField;
      set
      {
        this.ultimateACLLIField = value;
        this.RaisePropertyChanged(nameof (ultimateACLLI));
      }
    }

    [XmlElement(Order = 63)]
    public string leasedTransportZCLLI
    {
      get => this.leasedTransportZCLLIField;
      set
      {
        this.leasedTransportZCLLIField = value;
        this.RaisePropertyChanged(nameof (leasedTransportZCLLI));
      }
    }

    [XmlElement(Order = 64)]
    public string eccktZCLLI
    {
      get => this.eccktZCLLIField;
      set
      {
        this.eccktZCLLIField = value;
        this.RaisePropertyChanged(nameof (eccktZCLLI));
      }
    }

    [XmlElement(Order = 65)]
    public string ultimateZCLLI
    {
      get => this.ultimateZCLLIField;
      set
      {
        this.ultimateZCLLIField = value;
        this.RaisePropertyChanged(nameof (ultimateZCLLI));
      }
    }

    [XmlElement(Order = 66)]
    public string level3CLLI
    {
      get => this.level3CLLIField;
      set
      {
        this.level3CLLIField = value;
        this.RaisePropertyChanged(nameof (level3CLLI));
      }
    }

    [XmlElement(Order = 67)]
    public string TCILow
    {
      get => this.tCILowField;
      set
      {
        this.tCILowField = value;
        this.RaisePropertyChanged(nameof (TCILow));
      }
    }

    [XmlElement(Order = 68)]
    public string TCIHigh
    {
      get => this.tCIHighField;
      set
      {
        this.tCIHighField = value;
        this.RaisePropertyChanged(nameof (TCIHigh));
      }
    }

    [XmlElement(Order = 69)]
    public string hubbingCompany
    {
      get => this.hubbingCompanyField;
      set
      {
        this.hubbingCompanyField = value;
        this.RaisePropertyChanged(nameof (hubbingCompany));
      }
    }

    [XmlElement(Order = 70)]
    public string muxIndicator
    {
      get => this.muxIndicatorField;
      set
      {
        this.muxIndicatorField = value;
        this.RaisePropertyChanged(nameof (muxIndicator));
      }
    }

    [XmlElement(Order = 71)]
    public string overflowTSC
    {
      get => this.overflowTSCField;
      set
      {
        this.overflowTSCField = value;
        this.RaisePropertyChanged(nameof (overflowTSC));
      }
    }

    [XmlElement(Order = 72)]
    public string swtLRN
    {
      get => this.swtLRNField;
      set
      {
        this.swtLRNField = value;
        this.RaisePropertyChanged(nameof (swtLRN));
      }
    }

    [XmlElement(Order = 73)]
    public string swtMarket
    {
      get => this.swtMarketField;
      set
      {
        this.swtMarketField = value;
        this.RaisePropertyChanged(nameof (swtMarket));
      }
    }

    [XmlElement(Order = 74)]
    public string swtLPC
    {
      get => this.swtLPCField;
      set
      {
        this.swtLPCField = value;
        this.RaisePropertyChanged(nameof (swtLPC));
      }
    }

    [XmlElement(Order = 75)]
    public string swtSwitchedOffice
    {
      get => this.swtSwitchedOfficeField;
      set
      {
        this.swtSwitchedOfficeField = value;
        this.RaisePropertyChanged(nameof (swtSwitchedOffice));
      }
    }

    [XmlElement(Order = 76)]
    public string swtSPM
    {
      get => this.swtSPMField;
      set
      {
        this.swtSPMField = value;
        this.RaisePropertyChanged(nameof (swtSPM));
      }
    }

    [XmlElement(Order = 77)]
    public string swtSPMPort
    {
      get => this.swtSPMPortField;
      set
      {
        this.swtSPMPortField = value;
        this.RaisePropertyChanged(nameof (swtSPMPort));
      }
    }

    [XmlElement(Order = 78)]
    public string swtSPMMembers
    {
      get => this.swtSPMMembersField;
      set
      {
        this.swtSPMMembersField = value;
        this.RaisePropertyChanged(nameof (swtSPMMembers));
      }
    }

    [XmlElement(Order = 79)]
    public int numberSST1s
    {
      get => this.numberSST1sField;
      set
      {
        this.numberSST1sField = value;
        this.RaisePropertyChanged(nameof (numberSST1s));
      }
    }

    [XmlIgnore]
    public bool numberSST1sSpecified
    {
      get => this.numberSST1sFieldSpecified;
      set
      {
        this.numberSST1sFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberSST1sSpecified));
      }
    }

    [XmlElement(Order = 80)]
    public int numberSAT1s
    {
      get => this.numberSAT1sField;
      set
      {
        this.numberSAT1sField = value;
        this.RaisePropertyChanged(nameof (numberSAT1s));
      }
    }

    [XmlIgnore]
    public bool numberSAT1sSpecified
    {
      get => this.numberSAT1sFieldSpecified;
      set
      {
        this.numberSAT1sFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberSAT1sSpecified));
      }
    }

    [XmlElement(Order = 81)]
    public int numberTSCs
    {
      get => this.numberTSCsField;
      set
      {
        this.numberTSCsField = value;
        this.RaisePropertyChanged(nameof (numberTSCs));
      }
    }

    [XmlIgnore]
    public bool numberTSCsSpecified
    {
      get => this.numberTSCsFieldSpecified;
      set
      {
        this.numberTSCsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberTSCsSpecified));
      }
    }

    [XmlElement(Order = 82)]
    public string reservationIdentifier
    {
      get => this.reservationIdentifierField;
      set
      {
        this.reservationIdentifierField = value;
        this.RaisePropertyChanged(nameof (reservationIdentifier));
      }
    }

    [XmlElement(Order = 83)]
    public string interconnectAssignment
    {
      get => this.interconnectAssignmentField;
      set
      {
        this.interconnectAssignmentField = value;
        this.RaisePropertyChanged(nameof (interconnectAssignment));
      }
    }

    [XmlElement(Order = 84)]
    public string TLTID
    {
      get => this.tLTIDField;
      set
      {
        this.tLTIDField = value;
        this.RaisePropertyChanged(nameof (TLTID));
      }
    }

    [XmlElement(Order = 85)]
    public string endUserCustomer
    {
      get => this.endUserCustomerField;
      set
      {
        this.endUserCustomerField = value;
        this.RaisePropertyChanged(nameof (endUserCustomer));
      }
    }

    [XmlElement(Order = 86)]
    public string cutLevelIndicator
    {
      get => this.cutLevelIndicatorField;
      set
      {
        this.cutLevelIndicatorField = value;
        this.RaisePropertyChanged(nameof (cutLevelIndicator));
      }
    }

    [XmlElement(Order = 87)]
    public string gatewayLocNum
    {
      get => this.gatewayLocNumField;
      set
      {
        this.gatewayLocNumField = value;
        this.RaisePropertyChanged(nameof (gatewayLocNum));
      }
    }

    [XmlElement(Order = 88)]
    public string addressNPANXX
    {
      get => this.addressNPANXXField;
      set
      {
        this.addressNPANXXField = value;
        this.RaisePropertyChanged(nameof (addressNPANXX));
      }
    }

    [XmlElement(Order = 89)]
    public string aEndEccktNPANXX
    {
      get => this.aEndEccktNPANXXField;
      set
      {
        this.aEndEccktNPANXXField = value;
        this.RaisePropertyChanged(nameof (aEndEccktNPANXX));
      }
    }

    [XmlElement(Order = 90)]
    public string zEndEccktNPANXX
    {
      get => this.zEndEccktNPANXXField;
      set
      {
        this.zEndEccktNPANXXField = value;
        this.RaisePropertyChanged(nameof (zEndEccktNPANXX));
      }
    }

    [XmlElement(Order = 91)]
    public string trunkGroupEID
    {
      get => this.trunkGroupEIDField;
      set
      {
        this.trunkGroupEIDField = value;
        this.RaisePropertyChanged(nameof (trunkGroupEID));
      }
    }

    [XmlElement(Order = 92)]
    public string trunkGroupType
    {
      get => this.trunkGroupTypeField;
      set
      {
        this.trunkGroupTypeField = value;
        this.RaisePropertyChanged(nameof (trunkGroupType));
      }
    }

    [XmlElement(Order = 93)]
    public string route
    {
      get => this.routeField;
      set
      {
        this.routeField = value;
        this.RaisePropertyChanged(nameof (route));
      }
    }

    [XmlElement(Order = 94)]
    public string carrierIdentity
    {
      get => this.carrierIdentityField;
      set
      {
        this.carrierIdentityField = value;
        this.RaisePropertyChanged(nameof (carrierIdentity));
      }
    }

    [XmlElement(Order = 95)]
    public string companyCode
    {
      get => this.companyCodeField;
      set
      {
        this.companyCodeField = value;
        this.RaisePropertyChanged(nameof (companyCode));
      }
    }

    [XmlElement(Order = 96)]
    public string percentInterstateUsage
    {
      get => this.percentInterstateUsageField;
      set
      {
        this.percentInterstateUsageField = value;
        this.RaisePropertyChanged(nameof (percentInterstateUsage));
      }
    }

    [XmlElement(Order = 97)]
    public string percentLocalUsage
    {
      get => this.percentLocalUsageField;
      set
      {
        this.percentLocalUsageField = value;
        this.RaisePropertyChanged(nameof (percentLocalUsage));
      }
    }

    [XmlElement(Order = 98)]
    public string accessPointOfTermination
    {
      get => this.accessPointOfTerminationField;
      set
      {
        this.accessPointOfTerminationField = value;
        this.RaisePropertyChanged(nameof (accessPointOfTermination));
      }
    }

    [XmlElement(Order = 99)]
    public string secondaryLocation
    {
      get => this.secondaryLocationField;
      set
      {
        this.secondaryLocationField = value;
        this.RaisePropertyChanged(nameof (secondaryLocation));
      }
    }

    [XmlElement(Order = 100)]
    public string e911Included
    {
      get => this.e911IncludedField;
      set
      {
        this.e911IncludedField = value;
        this.RaisePropertyChanged(nameof (e911Included));
      }
    }

    [XmlElement(Order = 101)]
    public string e911TrafficClass
    {
      get => this.e911TrafficClassField;
      set
      {
        this.e911TrafficClassField = value;
        this.RaisePropertyChanged(nameof (e911TrafficClass));
      }
    }

    [XmlElement(Order = 102)]
    public string e911CarrierParity
    {
      get => this.e911CarrierParityField;
      set
      {
        this.e911CarrierParityField = value;
        this.RaisePropertyChanged(nameof (e911CarrierParity));
      }
    }

    [XmlElement(Order = 103)]
    public string e911DefaultPSAP
    {
      get => this.e911DefaultPSAPField;
      set
      {
        this.e911DefaultPSAPField = value;
        this.RaisePropertyChanged(nameof (e911DefaultPSAP));
      }
    }

    [XmlElement(Order = 104)]
    public string e911DefaultESN
    {
      get => this.e911DefaultESNField;
      set
      {
        this.e911DefaultESNField = value;
        this.RaisePropertyChanged(nameof (e911DefaultESN));
      }
    }

    [XmlElement(Order = 105)]
    public string e911FIPS
    {
      get => this.e911FIPSField;
      set
      {
        this.e911FIPSField = value;
        this.RaisePropertyChanged(nameof (e911FIPS));
      }
    }

    [XmlElement(Order = 106)]
    public string e911DFTN
    {
      get => this.e911DFTNField;
      set
      {
        this.e911DFTNField = value;
        this.RaisePropertyChanged(nameof (e911DFTN));
      }
    }

    [XmlElement(Order = 107)]
    public string e911Location
    {
      get => this.e911LocationField;
      set
      {
        this.e911LocationField = value;
        this.RaisePropertyChanged(nameof (e911Location));
      }
    }

    [XmlElement(Order = 108)]
    public string e911TN
    {
      get => this.e911TNField;
      set
      {
        this.e911TNField = value;
        this.RaisePropertyChanged(nameof (e911TN));
      }
    }

    [XmlElement(Order = 109)]
    public string e911HotCut
    {
      get => this.e911HotCutField;
      set
      {
        this.e911HotCutField = value;
        this.RaisePropertyChanged(nameof (e911HotCut));
      }
    }

    [XmlElement(Order = 110)]
    public string ACNA
    {
      get => this.aCNAField;
      set
      {
        this.aCNAField = value;
        this.RaisePropertyChanged(nameof (ACNA));
      }
    }

    [XmlElement(Order = 111)]
    public string CCNA
    {
      get => this.cCNAField;
      set
      {
        this.cCNAField = value;
        this.RaisePropertyChanged(nameof (CCNA));
      }
    }

    [XmlElement(Order = 112)]
    public string ICSC
    {
      get => this.iCSCField;
      set
      {
        this.iCSCField = value;
        this.RaisePropertyChanged(nameof (ICSC));
      }
    }

    [XmlElement(Order = 113)]
    public string meetPointVendor
    {
      get => this.meetPointVendorField;
      set
      {
        this.meetPointVendorField = value;
        this.RaisePropertyChanged(nameof (meetPointVendor));
      }
    }

    [XmlElement(Order = 114)]
    public string meetPointStatus
    {
      get => this.meetPointStatusField;
      set
      {
        this.meetPointStatusField = value;
        this.RaisePropertyChanged(nameof (meetPointStatus));
      }
    }

    [XmlElement(Order = 115)]
    public string FCKT
    {
      get => this.fCKTField;
      set
      {
        this.fCKTField = value;
        this.RaisePropertyChanged(nameof (FCKT));
      }
    }

    [XmlElement(Order = 116)]
    public string SCFA
    {
      get => this.sCFAField;
      set
      {
        this.sCFAField = value;
        this.RaisePropertyChanged(nameof (SCFA));
      }
    }

    [XmlElement(Order = 117)]
    public string SPEC
    {
      get => this.sPECField;
      set
      {
        this.sPECField = value;
        this.RaisePropertyChanged(nameof (SPEC));
      }
    }

    [XmlElement(DataType = "date", Order = 118)]
    public DateTime lastInvoiceDate
    {
      get => this.lastInvoiceDateField;
      set
      {
        this.lastInvoiceDateField = value;
        this.RaisePropertyChanged(nameof (lastInvoiceDate));
      }
    }

    [XmlIgnore]
    public bool lastInvoiceDateSpecified
    {
      get => this.lastInvoiceDateFieldSpecified;
      set
      {
        this.lastInvoiceDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (lastInvoiceDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 119)]
    public DateTime serviceEstablishedDate
    {
      get => this.serviceEstablishedDateField;
      set
      {
        this.serviceEstablishedDateField = value;
        this.RaisePropertyChanged(nameof (serviceEstablishedDate));
      }
    }

    [XmlIgnore]
    public bool serviceEstablishedDateSpecified
    {
      get => this.serviceEstablishedDateFieldSpecified;
      set
      {
        this.serviceEstablishedDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (serviceEstablishedDateSpecified));
      }
    }

    [XmlElement(Order = 120)]
    public Decimal MRC
    {
      get => this.mRCField;
      set
      {
        this.mRCField = value;
        this.RaisePropertyChanged(nameof (MRC));
      }
    }

    [XmlIgnore]
    public bool MRCSpecified
    {
      get => this.mRCFieldSpecified;
      set
      {
        this.mRCFieldSpecified = value;
        this.RaisePropertyChanged(nameof (MRCSpecified));
      }
    }

    [XmlElement(Order = 121)]
    public Decimal MRCSavings
    {
      get => this.mRCSavingsField;
      set
      {
        this.mRCSavingsField = value;
        this.RaisePropertyChanged(nameof (MRCSavings));
      }
    }

    [XmlIgnore]
    public bool MRCSavingsSpecified
    {
      get => this.mRCSavingsFieldSpecified;
      set
      {
        this.mRCSavingsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (MRCSavingsSpecified));
      }
    }

    [XmlElement(Order = 122)]
    public Decimal NRC
    {
      get => this.nRCField;
      set
      {
        this.nRCField = value;
        this.RaisePropertyChanged(nameof (NRC));
      }
    }

    [XmlIgnore]
    public bool NRCSpecified
    {
      get => this.nRCFieldSpecified;
      set
      {
        this.nRCFieldSpecified = value;
        this.RaisePropertyChanged(nameof (NRCSpecified));
      }
    }

    [XmlElement(Order = 123)]
    public string inventoryUsedFor
    {
      get => this.inventoryUsedForField;
      set
      {
        this.inventoryUsedForField = value;
        this.RaisePropertyChanged(nameof (inventoryUsedFor));
      }
    }

    [XmlElement(Order = 124)]
    public string inventoryStatus
    {
      get => this.inventoryStatusField;
      set
      {
        this.inventoryStatusField = value;
        this.RaisePropertyChanged(nameof (inventoryStatus));
      }
    }

    [XmlElement(Order = 125)]
    public string eccktTerm
    {
      get => this.eccktTermField;
      set
      {
        this.eccktTermField = value;
        this.RaisePropertyChanged(nameof (eccktTerm));
      }
    }

    [XmlElement(Order = 126)]
    public string eccktTermVTAI
    {
      get => this.eccktTermVTAIField;
      set
      {
        this.eccktTermVTAIField = value;
        this.RaisePropertyChanged(nameof (eccktTermVTAI));
      }
    }

    [XmlElement(DataType = "date", Order = 127)]
    public DateTime eccktTermStartDate
    {
      get => this.eccktTermStartDateField;
      set
      {
        this.eccktTermStartDateField = value;
        this.RaisePropertyChanged(nameof (eccktTermStartDate));
      }
    }

    [XmlIgnore]
    public bool eccktTermStartDateSpecified
    {
      get => this.eccktTermStartDateFieldSpecified;
      set
      {
        this.eccktTermStartDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (eccktTermStartDateSpecified));
      }
    }

    [XmlElement(Order = 128)]
    public string customerTerm
    {
      get => this.customerTermField;
      set
      {
        this.customerTermField = value;
        this.RaisePropertyChanged(nameof (customerTerm));
      }
    }

    [XmlElement(DataType = "date", Order = 129)]
    public DateTime customerTermStartDate
    {
      get => this.customerTermStartDateField;
      set
      {
        this.customerTermStartDateField = value;
        this.RaisePropertyChanged(nameof (customerTermStartDate));
      }
    }

    [XmlIgnore]
    public bool customerTermStartDateSpecified
    {
      get => this.customerTermStartDateFieldSpecified;
      set
      {
        this.customerTermStartDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (customerTermStartDateSpecified));
      }
    }

    [XmlElement(Order = 130)]
    public string segmentType
    {
      get => this.segmentTypeField;
      set
      {
        this.segmentTypeField = value;
        this.RaisePropertyChanged(nameof (segmentType));
      }
    }

    [XmlElement(DataType = "date", Order = 131)]
    public DateTime PONDueDate
    {
      get => this.pONDueDateField;
      set
      {
        this.pONDueDateField = value;
        this.RaisePropertyChanged(nameof (PONDueDate));
      }
    }

    [XmlIgnore]
    public bool PONDueDateSpecified
    {
      get => this.pONDueDateFieldSpecified;
      set
      {
        this.pONDueDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (PONDueDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 132)]
    public DateTime ASRDesiredDueDate
    {
      get => this.aSRDesiredDueDateField;
      set
      {
        this.aSRDesiredDueDateField = value;
        this.RaisePropertyChanged(nameof (ASRDesiredDueDate));
      }
    }

    [XmlIgnore]
    public bool ASRDesiredDueDateSpecified
    {
      get => this.aSRDesiredDueDateFieldSpecified;
      set
      {
        this.aSRDesiredDueDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (ASRDesiredDueDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 133)]
    public DateTime expectedTermEndDate
    {
      get => this.expectedTermEndDateField;
      set
      {
        this.expectedTermEndDateField = value;
        this.RaisePropertyChanged(nameof (expectedTermEndDate));
      }
    }

    [XmlIgnore]
    public bool expectedTermEndDateSpecified
    {
      get => this.expectedTermEndDateFieldSpecified;
      set
      {
        this.expectedTermEndDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (expectedTermEndDateSpecified));
      }
    }

    [XmlElement(Order = 134)]
    public string USOC
    {
      get => this.uSOCField;
      set
      {
        this.uSOCField = value;
        this.RaisePropertyChanged(nameof (USOC));
      }
    }

    [XmlElement(Order = 135)]
    public string CICS
    {
      get => this.cICSField;
      set
      {
        this.cICSField = value;
        this.RaisePropertyChanged(nameof (CICS));
      }
    }

    [XmlElement(Order = 136)]
    public string channelTerm
    {
      get => this.channelTermField;
      set
      {
        this.channelTermField = value;
        this.RaisePropertyChanged(nameof (channelTerm));
      }
    }

    [XmlElement(Order = 137)]
    public string mileage
    {
      get => this.mileageField;
      set
      {
        this.mileageField = value;
        this.RaisePropertyChanged(nameof (mileage));
      }
    }

    [XmlElement(Order = 138)]
    public string LATA
    {
      get => this.lATAField;
      set
      {
        this.lATAField = value;
        this.RaisePropertyChanged(nameof (LATA));
      }
    }

    [XmlElement(Order = 139)]
    public string MSA
    {
      get => this.mSAField;
      set
      {
        this.mSAField = value;
        this.RaisePropertyChanged(nameof (MSA));
      }
    }

    [XmlElement(Order = 140)]
    public string APOT
    {
      get => this.aPOTField;
      set
      {
        this.aPOTField = value;
        this.RaisePropertyChanged(nameof (APOT));
      }
    }

    [XmlElement(Order = 141)]
    public string channelStatus
    {
      get => this.channelStatusField;
      set
      {
        this.channelStatusField = value;
        this.RaisePropertyChanged(nameof (channelStatus));
      }
    }

    [XmlElement(Order = 142)]
    public string customerContactNumber
    {
      get => this.customerContactNumberField;
      set
      {
        this.customerContactNumberField = value;
        this.RaisePropertyChanged(nameof (customerContactNumber));
      }
    }

    [XmlElement(Order = 143)]
    public string logicalMemberEID
    {
      get => this.logicalMemberEIDField;
      set
      {
        this.logicalMemberEIDField = value;
        this.RaisePropertyChanged(nameof (logicalMemberEID));
      }
    }

    [XmlElement(Order = 144)]
    public string originatingCompanyName
    {
      get => this.originatingCompanyNameField;
      set
      {
        this.originatingCompanyNameField = value;
        this.RaisePropertyChanged(nameof (originatingCompanyName));
      }
    }

    [XmlElement(Order = 145)]
    public string protection
    {
      get => this.protectionField;
      set
      {
        this.protectionField = value;
        this.RaisePropertyChanged(nameof (protection));
      }
    }

    [XmlElement(Order = 146)]
    public string SCID
    {
      get => this.sCIDField;
      set
      {
        this.sCIDField = value;
        this.RaisePropertyChanged(nameof (SCID));
      }
    }

    [XmlElement(Order = 147)]
    public string switchCLLI
    {
      get => this.switchCLLIField;
      set
      {
        this.switchCLLIField = value;
        this.RaisePropertyChanged(nameof (switchCLLI));
      }
    }

    [XmlElement(Order = 148)]
    public string zip4
    {
      get => this.zip4Field;
      set
      {
        this.zip4Field = value;
        this.RaisePropertyChanged(nameof (zip4));
      }
    }

    [XmlElement(Order = 149)]
    public string planItemIdentifier
    {
      get => this.planItemIdentifierField;
      set
      {
        this.planItemIdentifierField = value;
        this.RaisePropertyChanged(nameof (planItemIdentifier));
      }
    }

    [XmlElement(Order = 150)]
    public string CFALetterofAuthorization
    {
      get => this.cFALetterofAuthorizationField;
      set
      {
        this.cFALetterofAuthorizationField = value;
        this.RaisePropertyChanged(nameof (CFALetterofAuthorization));
      }
    }

    [XmlElement(Order = 151)]
    public string CPADetermination
    {
      get => this.cPADeterminationField;
      set
      {
        this.cPADeterminationField = value;
        this.RaisePropertyChanged(nameof (CPADetermination));
      }
    }

    [XmlElement(Order = 152)]
    public string LTP
    {
      get => this.lTPField;
      set
      {
        this.lTPField = value;
        this.RaisePropertyChanged(nameof (LTP));
      }
    }

    [XmlElement(Order = 153)]
    public string CCEA
    {
      get => this.cCEAField;
      set
      {
        this.cCEAField = value;
        this.RaisePropertyChanged(nameof (CCEA));
      }
    }

    [XmlElement(Order = 154)]
    public string SCCEA
    {
      get => this.sCCEAField;
      set
      {
        this.sCCEAField = value;
        this.RaisePropertyChanged(nameof (SCCEA));
      }
    }

    [XmlElement(Order = 155)]
    public string localPointCode
    {
      get => this.localPointCodeField;
      set
      {
        this.localPointCodeField = value;
        this.RaisePropertyChanged(nameof (localPointCode));
      }
    }

    [XmlElement(Order = 156)]
    public bool dualProvisioningCompleteIndicator
    {
      get => this.dualProvisioningCompleteIndicatorField;
      set
      {
        this.dualProvisioningCompleteIndicatorField = value;
        this.RaisePropertyChanged(nameof (dualProvisioningCompleteIndicator));
      }
    }

    [XmlIgnore]
    public bool dualProvisioningCompleteIndicatorSpecified
    {
      get => this.dualProvisioningCompleteIndicatorFieldSpecified;
      set
      {
        this.dualProvisioningCompleteIndicatorFieldSpecified = value;
        this.RaisePropertyChanged(nameof (dualProvisioningCompleteIndicatorSpecified));
      }
    }
  }
}
