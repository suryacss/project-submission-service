// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.LocalAddress
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
  public class LocalAddress : INotifyPropertyChanged
  {
    private PhysicalLocation campusField;
    private PhysicalLocation buildingField;
    private PhysicalLocation floorField;
    private PhysicalLocation roomField;
    private PhysicalLocation aisleField;
    private PhysicalLocation bayField;

    [XmlElement(Order = 0)]
    public PhysicalLocation campus
    {
      get => this.campusField;
      set
      {
        this.campusField = value;
        this.RaisePropertyChanged(nameof (campus));
      }
    }

    [XmlElement(Order = 1)]
    public PhysicalLocation building
    {
      get => this.buildingField;
      set
      {
        this.buildingField = value;
        this.RaisePropertyChanged(nameof (building));
      }
    }

    [XmlElement(Order = 2)]
    public PhysicalLocation floor
    {
      get => this.floorField;
      set
      {
        this.floorField = value;
        this.RaisePropertyChanged(nameof (floor));
      }
    }

    [XmlElement(Order = 3)]
    public PhysicalLocation room
    {
      get => this.roomField;
      set
      {
        this.roomField = value;
        this.RaisePropertyChanged(nameof (room));
      }
    }

    [XmlElement(Order = 4)]
    public PhysicalLocation aisle
    {
      get => this.aisleField;
      set
      {
        this.aisleField = value;
        this.RaisePropertyChanged(nameof (aisle));
      }
    }

    [XmlElement(Order = 5)]
    public PhysicalLocation bay
    {
      get => this.bayField;
      set
      {
        this.bayField = value;
        this.RaisePropertyChanged(nameof (bay));
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
