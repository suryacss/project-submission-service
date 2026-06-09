// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.ProjectAccounting
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
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ProjectAccounting : INotifyPropertyChanged
  {
    private Decimal budgetField;
    private bool budgetFieldSpecified;
    private Decimal totalSavingsField;
    private bool totalSavingsFieldSpecified;
    private string onPlanNumberField;

    [XmlElement(Order = 0)]
    public Decimal budget
    {
      get => this.budgetField;
      set
      {
        this.budgetField = value;
        this.RaisePropertyChanged(nameof (budget));
      }
    }

    [XmlIgnore]
    public bool budgetSpecified
    {
      get => this.budgetFieldSpecified;
      set
      {
        this.budgetFieldSpecified = value;
        this.RaisePropertyChanged(nameof (budgetSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public Decimal totalSavings
    {
      get => this.totalSavingsField;
      set
      {
        this.totalSavingsField = value;
        this.RaisePropertyChanged(nameof (totalSavings));
      }
    }

    [XmlIgnore]
    public bool totalSavingsSpecified
    {
      get => this.totalSavingsFieldSpecified;
      set
      {
        this.totalSavingsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (totalSavingsSpecified));
      }
    }

    [XmlElement(Order = 2)]
    public string onPlanNumber
    {
      get => this.onPlanNumberField;
      set
      {
        this.onPlanNumberField = value;
        this.RaisePropertyChanged(nameof (onPlanNumber));
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
