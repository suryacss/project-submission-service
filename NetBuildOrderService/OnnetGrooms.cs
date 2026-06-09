// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.OnnetGrooms
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DebuggerStepThrough]
  [Serializable]
  public class OnnetGrooms : LogicalResource
  {
    private string projectTypeField;
    private string priorityField;
    private int circuitQuantityField;
    private bool circuitQuantityFieldSpecified;
    private DateTimePeriod groomWindowField;
    private string groomWindowTimeZoneField;

    [XmlElement(Order = 0)]
    public string projectType
    {
      get => this.projectTypeField;
      set
      {
        this.projectTypeField = value;
        this.RaisePropertyChanged(nameof (projectType));
      }
    }

    [XmlElement(Order = 1)]
    public string priority
    {
      get => this.priorityField;
      set
      {
        this.priorityField = value;
        this.RaisePropertyChanged(nameof (priority));
      }
    }

    [XmlElement(Order = 2)]
    public int circuitQuantity
    {
      get => this.circuitQuantityField;
      set
      {
        this.circuitQuantityField = value;
        this.RaisePropertyChanged(nameof (circuitQuantity));
      }
    }

    [XmlIgnore]
    public bool circuitQuantitySpecified
    {
      get => this.circuitQuantityFieldSpecified;
      set
      {
        this.circuitQuantityFieldSpecified = value;
        this.RaisePropertyChanged(nameof (circuitQuantitySpecified));
      }
    }

    [XmlElement(Order = 3)]
    public DateTimePeriod groomWindow
    {
      get => this.groomWindowField;
      set
      {
        this.groomWindowField = value;
        this.RaisePropertyChanged(nameof (groomWindow));
      }
    }

    [XmlElement(Order = 4)]
    public string groomWindowTimeZone
    {
      get => this.groomWindowTimeZoneField;
      set
      {
        this.groomWindowTimeZoneField = value;
        this.RaisePropertyChanged(nameof (groomWindowTimeZone));
      }
    }
  }
}
