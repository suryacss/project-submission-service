// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.ReplenishmentItem
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
  public class ReplenishmentItem : INotifyPropertyChanged
  {
    private Decimal budgetField;
    private bool budgetFieldSpecified;
    private string descriptionField;
    private string procurementCommentsField;
    private string equipmentModelField;
    private string equipmentTypeField;
    private string equipmentSpecificCommentsField;
    private string onPlanNumberField;
    private string programNumberField;
    private string projectCodeField;
    private string requestorNameField;
    private string requestorPhoneField;
    private string statementOfWorkCommentsField;
    private string updateAccrualsCommentsField;

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
    public string description
    {
      get => this.descriptionField;
      set
      {
        this.descriptionField = value;
        this.RaisePropertyChanged(nameof (description));
      }
    }

    [XmlElement(Order = 2)]
    public string procurementComments
    {
      get => this.procurementCommentsField;
      set
      {
        this.procurementCommentsField = value;
        this.RaisePropertyChanged(nameof (procurementComments));
      }
    }

    [XmlElement(Order = 3)]
    public string equipmentModel
    {
      get => this.equipmentModelField;
      set
      {
        this.equipmentModelField = value;
        this.RaisePropertyChanged(nameof (equipmentModel));
      }
    }

    [XmlElement(Order = 4)]
    public string equipmentType
    {
      get => this.equipmentTypeField;
      set
      {
        this.equipmentTypeField = value;
        this.RaisePropertyChanged(nameof (equipmentType));
      }
    }

    [XmlElement(Order = 5)]
    public string equipmentSpecificComments
    {
      get => this.equipmentSpecificCommentsField;
      set
      {
        this.equipmentSpecificCommentsField = value;
        this.RaisePropertyChanged(nameof (equipmentSpecificComments));
      }
    }

    [XmlElement(Order = 6)]
    public string onPlanNumber
    {
      get => this.onPlanNumberField;
      set
      {
        this.onPlanNumberField = value;
        this.RaisePropertyChanged(nameof (onPlanNumber));
      }
    }

    [XmlElement(Order = 7)]
    public string programNumber
    {
      get => this.programNumberField;
      set
      {
        this.programNumberField = value;
        this.RaisePropertyChanged(nameof (programNumber));
      }
    }

    [XmlElement(Order = 8)]
    public string projectCode
    {
      get => this.projectCodeField;
      set
      {
        this.projectCodeField = value;
        this.RaisePropertyChanged(nameof (projectCode));
      }
    }

    [XmlElement(Order = 9)]
    public string requestorName
    {
      get => this.requestorNameField;
      set
      {
        this.requestorNameField = value;
        this.RaisePropertyChanged(nameof (requestorName));
      }
    }

    [XmlElement(Order = 10)]
    public string requestorPhone
    {
      get => this.requestorPhoneField;
      set
      {
        this.requestorPhoneField = value;
        this.RaisePropertyChanged(nameof (requestorPhone));
      }
    }

    [XmlElement(Order = 11)]
    public string statementOfWorkComments
    {
      get => this.statementOfWorkCommentsField;
      set
      {
        this.statementOfWorkCommentsField = value;
        this.RaisePropertyChanged(nameof (statementOfWorkComments));
      }
    }

    [XmlElement(Order = 12)]
    public string updateAccrualsComments
    {
      get => this.updateAccrualsCommentsField;
      set
      {
        this.updateAccrualsCommentsField = value;
        this.RaisePropertyChanged(nameof (updateAccrualsComments));
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
