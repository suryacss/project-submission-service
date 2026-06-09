// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.GroomsProjectDetail
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
  public class GroomsProjectDetail : INotifyPropertyChanged
  {
    private string groomsPerformedByField;
    private int installASRCountField;
    private bool installASRCountFieldSpecified;
    private int discoASRCountField;
    private bool discoASRCountFieldSpecified;
    private int changeASRCountField;
    private bool changeASRCountFieldSpecified;
    private int totalASRCountField;
    private bool totalASRCountFieldSpecified;
    private int numberT3CircuitsField;
    private bool numberT3CircuitsFieldSpecified;
    private int numberT1CircuitsField;
    private bool numberT1CircuitsFieldSpecified;
    private int numberDS0CircuitsField;
    private bool numberDS0CircuitsFieldSpecified;
    private int numberTSCField;
    private bool numberTSCFieldSpecified;
    private int numberCutLevelCircuitsField;
    private bool numberCutLevelCircuitsFieldSpecified;
    private int numberMigrationASRsField;
    private bool numberMigrationASRsFieldSpecified;
    private int numberPostMigrationDiscosField;
    private bool numberPostMigrationDiscosFieldSpecified;
    private string mitigationPlanField;

    [XmlElement(Order = 0)]
    public string groomsPerformedBy
    {
      get => this.groomsPerformedByField;
      set
      {
        this.groomsPerformedByField = value;
        this.RaisePropertyChanged(nameof (groomsPerformedBy));
      }
    }

    [XmlElement(Order = 1)]
    public int installASRCount
    {
      get => this.installASRCountField;
      set
      {
        this.installASRCountField = value;
        this.RaisePropertyChanged(nameof (installASRCount));
      }
    }

    [XmlIgnore]
    public bool installASRCountSpecified
    {
      get => this.installASRCountFieldSpecified;
      set
      {
        this.installASRCountFieldSpecified = value;
        this.RaisePropertyChanged(nameof (installASRCountSpecified));
      }
    }

    [XmlElement(Order = 2)]
    public int discoASRCount
    {
      get => this.discoASRCountField;
      set
      {
        this.discoASRCountField = value;
        this.RaisePropertyChanged(nameof (discoASRCount));
      }
    }

    [XmlIgnore]
    public bool discoASRCountSpecified
    {
      get => this.discoASRCountFieldSpecified;
      set
      {
        this.discoASRCountFieldSpecified = value;
        this.RaisePropertyChanged(nameof (discoASRCountSpecified));
      }
    }

    [XmlElement(Order = 3)]
    public int changeASRCount
    {
      get => this.changeASRCountField;
      set
      {
        this.changeASRCountField = value;
        this.RaisePropertyChanged(nameof (changeASRCount));
      }
    }

    [XmlIgnore]
    public bool changeASRCountSpecified
    {
      get => this.changeASRCountFieldSpecified;
      set
      {
        this.changeASRCountFieldSpecified = value;
        this.RaisePropertyChanged(nameof (changeASRCountSpecified));
      }
    }

    [XmlElement(Order = 4)]
    public int totalASRCount
    {
      get => this.totalASRCountField;
      set
      {
        this.totalASRCountField = value;
        this.RaisePropertyChanged(nameof (totalASRCount));
      }
    }

    [XmlIgnore]
    public bool totalASRCountSpecified
    {
      get => this.totalASRCountFieldSpecified;
      set
      {
        this.totalASRCountFieldSpecified = value;
        this.RaisePropertyChanged(nameof (totalASRCountSpecified));
      }
    }

    [XmlElement(Order = 5)]
    public int numberT3Circuits
    {
      get => this.numberT3CircuitsField;
      set
      {
        this.numberT3CircuitsField = value;
        this.RaisePropertyChanged(nameof (numberT3Circuits));
      }
    }

    [XmlIgnore]
    public bool numberT3CircuitsSpecified
    {
      get => this.numberT3CircuitsFieldSpecified;
      set
      {
        this.numberT3CircuitsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberT3CircuitsSpecified));
      }
    }

    [XmlElement(Order = 6)]
    public int numberT1Circuits
    {
      get => this.numberT1CircuitsField;
      set
      {
        this.numberT1CircuitsField = value;
        this.RaisePropertyChanged(nameof (numberT1Circuits));
      }
    }

    [XmlIgnore]
    public bool numberT1CircuitsSpecified
    {
      get => this.numberT1CircuitsFieldSpecified;
      set
      {
        this.numberT1CircuitsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberT1CircuitsSpecified));
      }
    }

    [XmlElement(Order = 7)]
    public int numberDS0Circuits
    {
      get => this.numberDS0CircuitsField;
      set
      {
        this.numberDS0CircuitsField = value;
        this.RaisePropertyChanged(nameof (numberDS0Circuits));
      }
    }

    [XmlIgnore]
    public bool numberDS0CircuitsSpecified
    {
      get => this.numberDS0CircuitsFieldSpecified;
      set
      {
        this.numberDS0CircuitsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberDS0CircuitsSpecified));
      }
    }

    [XmlElement(Order = 8)]
    public int numberTSC
    {
      get => this.numberTSCField;
      set
      {
        this.numberTSCField = value;
        this.RaisePropertyChanged(nameof (numberTSC));
      }
    }

    [XmlIgnore]
    public bool numberTSCSpecified
    {
      get => this.numberTSCFieldSpecified;
      set
      {
        this.numberTSCFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberTSCSpecified));
      }
    }

    [XmlElement(Order = 9)]
    public int numberCutLevelCircuits
    {
      get => this.numberCutLevelCircuitsField;
      set
      {
        this.numberCutLevelCircuitsField = value;
        this.RaisePropertyChanged(nameof (numberCutLevelCircuits));
      }
    }

    [XmlIgnore]
    public bool numberCutLevelCircuitsSpecified
    {
      get => this.numberCutLevelCircuitsFieldSpecified;
      set
      {
        this.numberCutLevelCircuitsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberCutLevelCircuitsSpecified));
      }
    }

    [XmlElement(Order = 10)]
    public int numberMigrationASRs
    {
      get => this.numberMigrationASRsField;
      set
      {
        this.numberMigrationASRsField = value;
        this.RaisePropertyChanged(nameof (numberMigrationASRs));
      }
    }

    [XmlIgnore]
    public bool numberMigrationASRsSpecified
    {
      get => this.numberMigrationASRsFieldSpecified;
      set
      {
        this.numberMigrationASRsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberMigrationASRsSpecified));
      }
    }

    [XmlElement(Order = 11)]
    public int numberPostMigrationDiscos
    {
      get => this.numberPostMigrationDiscosField;
      set
      {
        this.numberPostMigrationDiscosField = value;
        this.RaisePropertyChanged(nameof (numberPostMigrationDiscos));
      }
    }

    [XmlIgnore]
    public bool numberPostMigrationDiscosSpecified
    {
      get => this.numberPostMigrationDiscosFieldSpecified;
      set
      {
        this.numberPostMigrationDiscosFieldSpecified = value;
        this.RaisePropertyChanged(nameof (numberPostMigrationDiscosSpecified));
      }
    }

    [XmlElement(Order = 12)]
    public string mitigationPlan
    {
      get => this.mitigationPlanField;
      set
      {
        this.mitigationPlanField = value;
        this.RaisePropertyChanged(nameof (mitigationPlan));
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
