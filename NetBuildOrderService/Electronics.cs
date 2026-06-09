// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Electronics
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class Electronics : PhysicalResource
  {
    private int dSX1Field;
    private bool dSX1FieldSpecified;
    private object groupShelfLocationField;
    private string interfaceSpeedField;
    private string tribOrLineSideField;
    private string dCSWaveCheckField;
    private string equipmentPlatformTypeField;
    private bool neTiedToEnvironmentField;
    private bool neTiedToEnvironmentFieldSpecified;
    private bool networkManagementRemoveReqField;
    private bool networkManagementRemoveReqFieldSpecified;
    private string electronicsProjectCodeField;
    private string tIDField;
    private bool testAlarmNeededField;
    private string iNEorDNEField;
    private bool providingSiteEnvironmentalsField;
    private bool replacementEnvironmentalsAtLocationField;
    private string mESDNSNameField;
    private bool waveOrderField;
    private bool networkOrderField;
    private bool houseKeepingMoveField;
    private bool timingOpcMoveField;
    private bool mesField;
    private bool mediaConverterField;
    private bool totalSiteExitField;
    private bool opcLocationField;
    private ResourceEndpoint opcLocationEndPointsField;

    [XmlElement(Order = 0)]
    public int DSX1
    {
      get => this.dSX1Field;
      set
      {
        this.dSX1Field = value;
        this.RaisePropertyChanged(nameof (DSX1));
      }
    }

    [XmlIgnore]
    public bool DSX1Specified
    {
      get => this.dSX1FieldSpecified;
      set
      {
        this.dSX1FieldSpecified = value;
        this.RaisePropertyChanged(nameof (DSX1Specified));
      }
    }

    [XmlElement(Order = 1)]
    public object groupShelfLocation
    {
      get => this.groupShelfLocationField;
      set
      {
        this.groupShelfLocationField = value;
        this.RaisePropertyChanged(nameof (groupShelfLocation));
      }
    }

    [XmlElement(Order = 2)]
    public string interfaceSpeed
    {
      get => this.interfaceSpeedField;
      set
      {
        this.interfaceSpeedField = value;
        this.RaisePropertyChanged(nameof (interfaceSpeed));
      }
    }

    [XmlElement(Order = 3)]
    public string tribOrLineSide
    {
      get => this.tribOrLineSideField;
      set
      {
        this.tribOrLineSideField = value;
        this.RaisePropertyChanged(nameof (tribOrLineSide));
      }
    }

    [XmlElement(Order = 4)]
    public string DCSWaveCheck
    {
      get => this.dCSWaveCheckField;
      set
      {
        this.dCSWaveCheckField = value;
        this.RaisePropertyChanged(nameof (DCSWaveCheck));
      }
    }

    [XmlElement(Order = 5)]
    public string equipmentPlatformType
    {
      get => this.equipmentPlatformTypeField;
      set
      {
        this.equipmentPlatformTypeField = value;
        this.RaisePropertyChanged(nameof (equipmentPlatformType));
      }
    }

    [XmlElement(Order = 6)]
    public bool neTiedToEnvironment
    {
      get => this.neTiedToEnvironmentField;
      set
      {
        this.neTiedToEnvironmentField = value;
        this.RaisePropertyChanged(nameof (neTiedToEnvironment));
      }
    }

    [XmlIgnore]
    public bool neTiedToEnvironmentSpecified
    {
      get => this.neTiedToEnvironmentFieldSpecified;
      set
      {
        this.neTiedToEnvironmentFieldSpecified = value;
        this.RaisePropertyChanged(nameof (neTiedToEnvironmentSpecified));
      }
    }

    [XmlElement(Order = 7)]
    public bool networkManagementRemoveReq
    {
      get => this.networkManagementRemoveReqField;
      set
      {
        this.networkManagementRemoveReqField = value;
        this.RaisePropertyChanged(nameof (networkManagementRemoveReq));
      }
    }

    [XmlIgnore]
    public bool networkManagementRemoveReqSpecified
    {
      get => this.networkManagementRemoveReqFieldSpecified;
      set
      {
        this.networkManagementRemoveReqFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkManagementRemoveReqSpecified));
      }
    }

    [XmlElement(Order = 8)]
    public string electronicsProjectCode
    {
      get => this.electronicsProjectCodeField;
      set
      {
        this.electronicsProjectCodeField = value;
        this.RaisePropertyChanged(nameof (electronicsProjectCode));
      }
    }

    [XmlElement(Order = 9)]
    public string TID
    {
      get => this.tIDField;
      set
      {
        this.tIDField = value;
        this.RaisePropertyChanged(nameof (TID));
      }
    }

    [XmlElement(Order = 10)]
    public bool testAlarmNeeded
    {
      get => this.testAlarmNeededField;
      set
      {
        this.testAlarmNeededField = value;
        this.RaisePropertyChanged(nameof (testAlarmNeeded));
      }
    }

    [XmlElement(Order = 11)]
    public string INEorDNE
    {
      get => this.iNEorDNEField;
      set
      {
        this.iNEorDNEField = value;
        this.RaisePropertyChanged(nameof (INEorDNE));
      }
    }

    [XmlElement(Order = 12)]
    public bool providingSiteEnvironmentals
    {
      get => this.providingSiteEnvironmentalsField;
      set
      {
        this.providingSiteEnvironmentalsField = value;
        this.RaisePropertyChanged(nameof (providingSiteEnvironmentals));
      }
    }

    [XmlElement(Order = 13)]
    public bool replacementEnvironmentalsAtLocation
    {
      get => this.replacementEnvironmentalsAtLocationField;
      set
      {
        this.replacementEnvironmentalsAtLocationField = value;
        this.RaisePropertyChanged(nameof (replacementEnvironmentalsAtLocation));
      }
    }

    [XmlElement(Order = 14)]
    public string MESDNSName
    {
      get => this.mESDNSNameField;
      set
      {
        this.mESDNSNameField = value;
        this.RaisePropertyChanged(nameof (MESDNSName));
      }
    }

    [XmlElement(Order = 15)]
    public bool WaveOrder
    {
      get => this.waveOrderField;
      set
      {
        this.waveOrderField = value;
        this.RaisePropertyChanged(nameof (WaveOrder));
      }
    }

    [XmlElement(Order = 16)]
    public bool NetworkOrder
    {
      get => this.networkOrderField;
      set
      {
        this.networkOrderField = value;
        this.RaisePropertyChanged(nameof (NetworkOrder));
      }
    }

    [XmlElement(Order = 17)]
    public bool HouseKeepingMove
    {
      get => this.houseKeepingMoveField;
      set
      {
        this.houseKeepingMoveField = value;
        this.RaisePropertyChanged(nameof (HouseKeepingMove));
      }
    }

    [XmlElement(Order = 18)]
    public bool TimingOpcMove
    {
      get => this.timingOpcMoveField;
      set
      {
        this.timingOpcMoveField = value;
        this.RaisePropertyChanged(nameof (TimingOpcMove));
      }
    }

    [XmlElement(Order = 19)]
    public bool Mes
    {
      get => this.mesField;
      set
      {
        this.mesField = value;
        this.RaisePropertyChanged(nameof (Mes));
      }
    }

    [XmlElement(Order = 20)]
    public bool MediaConverter
    {
      get => this.mediaConverterField;
      set
      {
        this.mediaConverterField = value;
        this.RaisePropertyChanged(nameof (MediaConverter));
      }
    }

    [XmlElement(Order = 21)]
    public bool TotalSiteExit
    {
      get => this.totalSiteExitField;
      set
      {
        this.totalSiteExitField = value;
        this.RaisePropertyChanged(nameof (TotalSiteExit));
      }
    }

    [XmlElement(Order = 22)]
    public bool OpcLocation
    {
      get => this.opcLocationField;
      set
      {
        this.opcLocationField = value;
        this.RaisePropertyChanged(nameof (OpcLocation));
      }
    }

    [XmlElement(Order = 23)]
    public ResourceEndpoint OpcLocationEndPoints
    {
      get => this.opcLocationEndPointsField;
      set
      {
        this.opcLocationEndPointsField = value;
        this.RaisePropertyChanged(nameof (OpcLocationEndPoints));
      }
    }
  }
}
