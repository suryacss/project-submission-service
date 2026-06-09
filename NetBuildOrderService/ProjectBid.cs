// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.ProjectBid
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
  public class ProjectBid : INotifyPropertyChanged
  {
    private Decimal awardedAmountField;
    private bool awardedAmountFieldSpecified;
    private string awardedContractorNameField;
    private string competitiveBidField;
    private string contractorNameField;
    private string commentsTextField;
    private string bidJobDescriptionField;
    private Contact[] bidContactsField;
    private string bidPurchaseOrderNumberField;
    private string bidProposalAmountField;

    [XmlElement(Order = 0)]
    public Decimal awardedAmount
    {
      get => this.awardedAmountField;
      set
      {
        this.awardedAmountField = value;
        this.RaisePropertyChanged(nameof (awardedAmount));
      }
    }

    [XmlIgnore]
    public bool awardedAmountSpecified
    {
      get => this.awardedAmountFieldSpecified;
      set
      {
        this.awardedAmountFieldSpecified = value;
        this.RaisePropertyChanged(nameof (awardedAmountSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public string awardedContractorName
    {
      get => this.awardedContractorNameField;
      set
      {
        this.awardedContractorNameField = value;
        this.RaisePropertyChanged(nameof (awardedContractorName));
      }
    }

    [XmlElement(Order = 2)]
    public string competitiveBid
    {
      get => this.competitiveBidField;
      set
      {
        this.competitiveBidField = value;
        this.RaisePropertyChanged(nameof (competitiveBid));
      }
    }

    [XmlElement(Order = 3)]
    public string contractorName
    {
      get => this.contractorNameField;
      set
      {
        this.contractorNameField = value;
        this.RaisePropertyChanged(nameof (contractorName));
      }
    }

    [XmlElement(Order = 4)]
    public string commentsText
    {
      get => this.commentsTextField;
      set
      {
        this.commentsTextField = value;
        this.RaisePropertyChanged(nameof (commentsText));
      }
    }

    [XmlElement(Order = 5)]
    public string bidJobDescription
    {
      get => this.bidJobDescriptionField;
      set
      {
        this.bidJobDescriptionField = value;
        this.RaisePropertyChanged(nameof (bidJobDescription));
      }
    }

    [XmlArrayItem("contact", IsNullable = false)]
    [XmlArray(Order = 6)]
    public Contact[] bidContacts
    {
      get => this.bidContactsField;
      set
      {
        this.bidContactsField = value;
        this.RaisePropertyChanged(nameof (bidContacts));
      }
    }

    [XmlElement(Order = 7)]
    public string bidPurchaseOrderNumber
    {
      get => this.bidPurchaseOrderNumberField;
      set
      {
        this.bidPurchaseOrderNumberField = value;
        this.RaisePropertyChanged(nameof (bidPurchaseOrderNumber));
      }
    }

    [XmlElement(Order = 8)]
    public string bidProposalAmount
    {
      get => this.bidProposalAmountField;
      set
      {
        this.bidProposalAmountField = value;
        this.RaisePropertyChanged(nameof (bidProposalAmount));
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
