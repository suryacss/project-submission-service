// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Resources
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  public class Resources : INotifyPropertyChanged
  {
    private GroomsCircuit[] groomsCircuitField;
    private BulkCable[] bulkCableField;
    private Electronics[] electronicsField;
    private IMT[] intraMachineTrunkField;
    private OutsidePlant[] outsidePlantField;
    private ProjectSubmissionsSvcLib.NetBuildOrderService.POP[] pOPField;
    private RackMatrix[] rackMatrixField;
    private Ring[] ringField;
    private TestAlarm[] testAlarmField;
    private SiteSurvey siteSurveyField;
    private TNOCEntranceCriteria[] tNOCCriteriaField;
    private ThirdPartyResource[] thirdPartyResourceField;
    private SystemPlan[] systemPlanField;
    private OnnetGrooms[] onnetGroomsField;
    private Infrastructure[] infrastructureField;
    private LeasedAccessConnection[] leasedAccessConnectionField;
    private LeasedAccess[] leasedAccessField;

    [XmlElement("groomsCircuit", Order = 0)]
    public GroomsCircuit[] groomsCircuit
    {
      get => this.groomsCircuitField;
      set
      {
        this.groomsCircuitField = value;
        this.RaisePropertyChanged(nameof (groomsCircuit));
      }
    }

    [XmlElement("bulkCable", Order = 1)]
    public BulkCable[] bulkCable
    {
      get => this.bulkCableField;
      set
      {
        this.bulkCableField = value;
        this.RaisePropertyChanged(nameof (bulkCable));
      }
    }

    [XmlElement("electronics", Order = 2)]
    public Electronics[] electronics
    {
      get => this.electronicsField;
      set
      {
        this.electronicsField = value;
        this.RaisePropertyChanged(nameof (electronics));
      }
    }

    [XmlElement("intraMachineTrunk", Order = 3)]
    public IMT[] intraMachineTrunk
    {
      get => this.intraMachineTrunkField;
      set
      {
        this.intraMachineTrunkField = value;
        this.RaisePropertyChanged(nameof (intraMachineTrunk));
      }
    }

    [XmlElement("outsidePlant", Order = 4)]
    public OutsidePlant[] outsidePlant
    {
      get => this.outsidePlantField;
      set
      {
        this.outsidePlantField = value;
        this.RaisePropertyChanged(nameof (outsidePlant));
      }
    }

    [XmlElement("POP", Order = 5)]
    public ProjectSubmissionsSvcLib.NetBuildOrderService.POP[] POP
    {
      get => this.pOPField;
      set
      {
        this.pOPField = value;
        this.RaisePropertyChanged(nameof (POP));
      }
    }

    [XmlElement("rackMatrix", Order = 6)]
    public RackMatrix[] rackMatrix
    {
      get => this.rackMatrixField;
      set
      {
        this.rackMatrixField = value;
        this.RaisePropertyChanged(nameof (rackMatrix));
      }
    }

    [XmlElement("ring", Order = 7)]
    public Ring[] ring
    {
      get => this.ringField;
      set
      {
        this.ringField = value;
        this.RaisePropertyChanged(nameof (ring));
      }
    }

    [XmlElement("testAlarm", Order = 8)]
    public TestAlarm[] testAlarm
    {
      get => this.testAlarmField;
      set
      {
        this.testAlarmField = value;
        this.RaisePropertyChanged(nameof (testAlarm));
      }
    }

    [XmlElement(Order = 9)]
    public SiteSurvey siteSurvey
    {
      get => this.siteSurveyField;
      set
      {
        this.siteSurveyField = value;
        this.RaisePropertyChanged(nameof (siteSurvey));
      }
    }

    [XmlElement("TNOCCriteria", Order = 10)]
    public TNOCEntranceCriteria[] TNOCCriteria
    {
      get => this.tNOCCriteriaField;
      set
      {
        this.tNOCCriteriaField = value;
        this.RaisePropertyChanged(nameof (TNOCCriteria));
      }
    }

    [XmlElement("thirdPartyResource", Order = 11)]
    public ThirdPartyResource[] thirdPartyResource
    {
      get => this.thirdPartyResourceField;
      set
      {
        this.thirdPartyResourceField = value;
        this.RaisePropertyChanged(nameof (thirdPartyResource));
      }
    }

    [XmlElement("systemPlan", Order = 12)]
    public SystemPlan[] systemPlan
    {
      get => this.systemPlanField;
      set
      {
        this.systemPlanField = value;
        this.RaisePropertyChanged(nameof (systemPlan));
      }
    }

    [XmlElement("onnetGrooms", Order = 13)]
    public OnnetGrooms[] onnetGrooms
    {
      get => this.onnetGroomsField;
      set
      {
        this.onnetGroomsField = value;
        this.RaisePropertyChanged(nameof (onnetGrooms));
      }
    }

    [XmlElement("infrastructure", Order = 14)]
    public Infrastructure[] infrastructure
    {
      get => this.infrastructureField;
      set
      {
        this.infrastructureField = value;
        this.RaisePropertyChanged(nameof (infrastructure));
      }
    }

    [XmlElement("leasedAccessConnection", Order = 15)]
    public LeasedAccessConnection[] leasedAccessConnection
    {
      get => this.leasedAccessConnectionField;
      set
      {
        this.leasedAccessConnectionField = value;
        this.RaisePropertyChanged(nameof (leasedAccessConnection));
      }
    }

    [XmlElement("leasedAccess", Order = 16)]
    public LeasedAccess[] leasedAccess
    {
      get => this.leasedAccessField;
      set
      {
        this.leasedAccessField = value;
        this.RaisePropertyChanged(nameof (leasedAccess));
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
