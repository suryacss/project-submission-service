// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Infrastructure
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  public class Infrastructure : PhysicalResource
  {
    private bool criticalAssetUpdateRequiredField;
    private bool criticalAssetUpdateRequiredFieldSpecified;
    private bool fieldProjectOversightNeededField;
    private bool fieldProjectOversightNeededFieldSpecified;
    private bool environmentalAlarmTestRequiredField;
    private bool environmentalAlarmTestRequiredFieldSpecified;
    private string infrastructureManagerNameField;
    private string engineerTypeField;
    private bool drawings100PercentCompleteField;
    private bool drawings100PercentCompleteFieldSpecified;

    [XmlElement(Order = 0)]
    public bool criticalAssetUpdateRequired
    {
      get => this.criticalAssetUpdateRequiredField;
      set
      {
        this.criticalAssetUpdateRequiredField = value;
        this.RaisePropertyChanged(nameof (criticalAssetUpdateRequired));
      }
    }

    [XmlIgnore]
    public bool criticalAssetUpdateRequiredSpecified
    {
      get => this.criticalAssetUpdateRequiredFieldSpecified;
      set
      {
        this.criticalAssetUpdateRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (criticalAssetUpdateRequiredSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public bool fieldProjectOversightNeeded
    {
      get => this.fieldProjectOversightNeededField;
      set
      {
        this.fieldProjectOversightNeededField = value;
        this.RaisePropertyChanged(nameof (fieldProjectOversightNeeded));
      }
    }

    [XmlIgnore]
    public bool fieldProjectOversightNeededSpecified
    {
      get => this.fieldProjectOversightNeededFieldSpecified;
      set
      {
        this.fieldProjectOversightNeededFieldSpecified = value;
        this.RaisePropertyChanged(nameof (fieldProjectOversightNeededSpecified));
      }
    }

    [XmlElement(Order = 2)]
    public bool environmentalAlarmTestRequired
    {
      get => this.environmentalAlarmTestRequiredField;
      set
      {
        this.environmentalAlarmTestRequiredField = value;
        this.RaisePropertyChanged(nameof (environmentalAlarmTestRequired));
      }
    }

    [XmlIgnore]
    public bool environmentalAlarmTestRequiredSpecified
    {
      get => this.environmentalAlarmTestRequiredFieldSpecified;
      set
      {
        this.environmentalAlarmTestRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (environmentalAlarmTestRequiredSpecified));
      }
    }

    [XmlElement(Order = 3)]
    public string infrastructureManagerName
    {
      get => this.infrastructureManagerNameField;
      set
      {
        this.infrastructureManagerNameField = value;
        this.RaisePropertyChanged(nameof (infrastructureManagerName));
      }
    }

    [XmlElement(Order = 4)]
    public string engineerType
    {
      get => this.engineerTypeField;
      set
      {
        this.engineerTypeField = value;
        this.RaisePropertyChanged(nameof (engineerType));
      }
    }

    [XmlElement(Order = 5)]
    public bool drawings100PercentComplete
    {
      get => this.drawings100PercentCompleteField;
      set
      {
        this.drawings100PercentCompleteField = value;
        this.RaisePropertyChanged(nameof (drawings100PercentComplete));
      }
    }

    [XmlIgnore]
    public bool drawings100PercentCompleteSpecified
    {
      get => this.drawings100PercentCompleteFieldSpecified;
      set
      {
        this.drawings100PercentCompleteFieldSpecified = value;
        this.RaisePropertyChanged(nameof (drawings100PercentCompleteSpecified));
      }
    }
  }
}
