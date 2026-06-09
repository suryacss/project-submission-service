// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.GroomsResourceSearchCriteria
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
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class GroomsResourceSearchCriteria : INotifyPropertyChanged
  {
    private string actionTypeQualifierField;
    private string cutLevelIndicatorField;
    private bool isCPAIndicatorField;
    private bool isCPAIndicatorFieldSpecified;
    private string provisioningIDField;

    [XmlElement(Order = 0)]
    public string actionTypeQualifier
    {
      get => this.actionTypeQualifierField;
      set
      {
        this.actionTypeQualifierField = value;
        this.RaisePropertyChanged(nameof (actionTypeQualifier));
      }
    }

    [XmlElement(Order = 1)]
    public string cutLevelIndicator
    {
      get => this.cutLevelIndicatorField;
      set
      {
        this.cutLevelIndicatorField = value;
        this.RaisePropertyChanged(nameof (cutLevelIndicator));
      }
    }

    [XmlElement(Order = 2)]
    public bool isCPAIndicator
    {
      get => this.isCPAIndicatorField;
      set
      {
        this.isCPAIndicatorField = value;
        this.RaisePropertyChanged(nameof (isCPAIndicator));
      }
    }

    [XmlIgnore]
    public bool isCPAIndicatorSpecified
    {
      get => this.isCPAIndicatorFieldSpecified;
      set
      {
        this.isCPAIndicatorFieldSpecified = value;
        this.RaisePropertyChanged(nameof (isCPAIndicatorSpecified));
      }
    }

    [XmlElement(Order = 3)]
    public string provisioningID
    {
      get => this.provisioningIDField;
      set
      {
        this.provisioningIDField = value;
        this.RaisePropertyChanged(nameof (provisioningID));
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
