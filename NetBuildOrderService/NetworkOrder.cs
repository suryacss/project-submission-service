// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrder
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
  [XmlInclude(typeof (MaterialReplenishmentOrder))]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [XmlInclude(typeof (SiteSurveyOrder))]
  [Serializable]
  public class NetworkOrder : Order
  {
    private DateTime networkOrderCreatedDateField;
    private bool networkOrderCreatedDateFieldSpecified;
    private DateTime networkOrderSubmittedDateField;
    private bool networkOrderSubmittedDateFieldSpecified;
    private DateTime networkOrderCompletedDateField;
    private bool networkOrderCompletedDateFieldSpecified;
    private string networkOrderNameField;
    private bool purchaseRequiredField;
    private bool purchaseRequiredFieldSpecified;
    private DateTime materialOnSiteDateField;
    private string networkOrderTypeNameField;
    private string networkOrderTypeField;
    private string networkOrderCustomerServiceTypeNameField;
    private string networkOrderCreatedByField;
    private string networkOrderSubmittedByField;
    private string networkOrderCreatorGroupField;
    private string networkOrderDescriptionField;
    private string[] networkOrderCommentsTextField;
    private string networkOrderStatusCodeField;
    private DateTime networkOrderCommitDateField;
    private bool networkOrderCommitDateFieldSpecified;
    private DateTime networkOrderRevisedCommitDateField;
    private bool networkOrderRevisedCommitDateFieldSpecified;
    private string networkOrderProductGroupField;
    private NetworkOrderHandlingCode networkOrderHandlingCodeField;
    private bool networkOrderHandlingCodeFieldSpecified;
    private string networkOrderWorkGroupField;
    private Decimal totalMRCSavingsField;
    private bool totalMRCSavingsFieldSpecified;
    private Contact[] networkOrderContactsField;
    private NetworkProject networkOrderProjectField;
    private string eIdField;
    private string rfaIdField;

    [XmlElement(Order = 0)]
    public DateTime networkOrderCreatedDate
    {
      get => this.networkOrderCreatedDateField;
      set
      {
        this.networkOrderCreatedDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderCreatedDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderCreatedDateSpecified
    {
      get => this.networkOrderCreatedDateFieldSpecified;
      set
      {
        this.networkOrderCreatedDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderCreatedDateSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public DateTime networkOrderSubmittedDate
    {
      get => this.networkOrderSubmittedDateField;
      set
      {
        this.networkOrderSubmittedDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderSubmittedDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderSubmittedDateSpecified
    {
      get => this.networkOrderSubmittedDateFieldSpecified;
      set
      {
        this.networkOrderSubmittedDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderSubmittedDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 2)]
    public DateTime networkOrderCompletedDate
    {
      get => this.networkOrderCompletedDateField;
      set
      {
        this.networkOrderCompletedDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderCompletedDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderCompletedDateSpecified
    {
      get => this.networkOrderCompletedDateFieldSpecified;
      set
      {
        this.networkOrderCompletedDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderCompletedDateSpecified));
      }
    }

    [XmlElement(Order = 3)]
    public string networkOrderName
    {
      get => this.networkOrderNameField;
      set
      {
        this.networkOrderNameField = value;
        this.RaisePropertyChanged(nameof (networkOrderName));
      }
    }

    [XmlElement(Order = 4)]
    public bool PurchaseRequired
    {
      get => this.purchaseRequiredField;
      set
      {
        this.purchaseRequiredField = value;
        this.RaisePropertyChanged(nameof (PurchaseRequired));
      }
    }

    [XmlIgnore]
    public bool PurchaseRequiredSpecified
    {
      get => this.purchaseRequiredFieldSpecified;
      set
      {
        this.purchaseRequiredFieldSpecified = value;
        this.RaisePropertyChanged(nameof (PurchaseRequiredSpecified));
      }
    }

    [XmlElement(Order = 5)]
    public DateTime MaterialOnSiteDate
    {
      get => this.materialOnSiteDateField;
      set
      {
        this.materialOnSiteDateField = value;
        this.RaisePropertyChanged(nameof (MaterialOnSiteDate));
      }
    }

    [XmlElement(Order = 6)]
    public string networkOrderTypeName
    {
      get => this.networkOrderTypeNameField;
      set
      {
        this.networkOrderTypeNameField = value;
        this.RaisePropertyChanged(nameof (networkOrderTypeName));
      }
    }

    [XmlElement(Order = 7)]
    public string networkOrderType
    {
      get => this.networkOrderTypeField;
      set
      {
        this.networkOrderTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderType));
      }
    }

    [XmlElement(Order = 8)]
    public string networkOrderCustomerServiceTypeName
    {
      get => this.networkOrderCustomerServiceTypeNameField;
      set
      {
        this.networkOrderCustomerServiceTypeNameField = value;
        this.RaisePropertyChanged(nameof (networkOrderCustomerServiceTypeName));
      }
    }

    [XmlElement(Order = 9)]
    public string networkOrderCreatedBy
    {
      get => this.networkOrderCreatedByField;
      set
      {
        this.networkOrderCreatedByField = value;
        this.RaisePropertyChanged(nameof (networkOrderCreatedBy));
      }
    }

    [XmlElement(Order = 10)]
    public string networkOrderSubmittedBy
    {
      get => this.networkOrderSubmittedByField;
      set
      {
        this.networkOrderSubmittedByField = value;
        this.RaisePropertyChanged(nameof (networkOrderSubmittedBy));
      }
    }

    [XmlElement(Order = 11)]
    public string networkOrderCreatorGroup
    {
      get => this.networkOrderCreatorGroupField;
      set
      {
        this.networkOrderCreatorGroupField = value;
        this.RaisePropertyChanged(nameof (networkOrderCreatorGroup));
      }
    }

    [XmlElement(Order = 12)]
    public string networkOrderDescription
    {
      get => this.networkOrderDescriptionField;
      set
      {
        this.networkOrderDescriptionField = value;
        this.RaisePropertyChanged(nameof (networkOrderDescription));
      }
    }

    [XmlElement("networkOrderCommentsText", Order = 13)]
    public string[] networkOrderCommentsText
    {
      get => this.networkOrderCommentsTextField;
      set
      {
        this.networkOrderCommentsTextField = value;
        this.RaisePropertyChanged(nameof (networkOrderCommentsText));
      }
    }

    [XmlElement(Order = 14)]
    public string networkOrderStatusCode
    {
      get => this.networkOrderStatusCodeField;
      set
      {
        this.networkOrderStatusCodeField = value;
        this.RaisePropertyChanged(nameof (networkOrderStatusCode));
      }
    }

    [XmlElement(DataType = "date", Order = 15)]
    public DateTime networkOrderCommitDate
    {
      get => this.networkOrderCommitDateField;
      set
      {
        this.networkOrderCommitDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderCommitDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderCommitDateSpecified
    {
      get => this.networkOrderCommitDateFieldSpecified;
      set
      {
        this.networkOrderCommitDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderCommitDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 16)]
    public DateTime networkOrderRevisedCommitDate
    {
      get => this.networkOrderRevisedCommitDateField;
      set
      {
        this.networkOrderRevisedCommitDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderRevisedCommitDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderRevisedCommitDateSpecified
    {
      get => this.networkOrderRevisedCommitDateFieldSpecified;
      set
      {
        this.networkOrderRevisedCommitDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderRevisedCommitDateSpecified));
      }
    }

    [XmlElement(Order = 17)]
    public string networkOrderProductGroup
    {
      get => this.networkOrderProductGroupField;
      set
      {
        this.networkOrderProductGroupField = value;
        this.RaisePropertyChanged(nameof (networkOrderProductGroup));
      }
    }

    [XmlElement(Order = 18)]
    public NetworkOrderHandlingCode networkOrderHandlingCode
    {
      get => this.networkOrderHandlingCodeField;
      set
      {
        this.networkOrderHandlingCodeField = value;
        this.RaisePropertyChanged(nameof (networkOrderHandlingCode));
      }
    }

    [XmlIgnore]
    public bool networkOrderHandlingCodeSpecified
    {
      get => this.networkOrderHandlingCodeFieldSpecified;
      set
      {
        this.networkOrderHandlingCodeFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderHandlingCodeSpecified));
      }
    }

    [XmlElement(Order = 19)]
    public string networkOrderWorkGroup
    {
      get => this.networkOrderWorkGroupField;
      set
      {
        this.networkOrderWorkGroupField = value;
        this.RaisePropertyChanged(nameof (networkOrderWorkGroup));
      }
    }

    [XmlElement(Order = 20)]
    public Decimal totalMRCSavings
    {
      get => this.totalMRCSavingsField;
      set
      {
        this.totalMRCSavingsField = value;
        this.RaisePropertyChanged(nameof (totalMRCSavings));
      }
    }

    [XmlIgnore]
    public bool totalMRCSavingsSpecified
    {
      get => this.totalMRCSavingsFieldSpecified;
      set
      {
        this.totalMRCSavingsFieldSpecified = value;
        this.RaisePropertyChanged(nameof (totalMRCSavingsSpecified));
      }
    }

    [XmlArrayItem("contact", IsNullable = false)]
    [XmlArray(Order = 21)]
    public Contact[] networkOrderContacts
    {
      get => this.networkOrderContactsField;
      set
      {
        this.networkOrderContactsField = value;
        this.RaisePropertyChanged(nameof (networkOrderContacts));
      }
    }

    [XmlElement(Order = 22)]
    public NetworkProject networkOrderProject
    {
      get => this.networkOrderProjectField;
      set
      {
        this.networkOrderProjectField = value;
        this.RaisePropertyChanged(nameof (networkOrderProject));
      }
    }

    [XmlElement(Order = 23)]
    public string eId
    {
      get => this.eIdField;
      set
      {
        this.eIdField = value;
        this.RaisePropertyChanged(nameof (eId));
      }
    }

    [XmlElement(Order = 24)]
    public string rfaId
    {
      get => this.rfaIdField;
      set
      {
        this.rfaIdField = value;
        this.RaisePropertyChanged(nameof (rfaId));
      }
    }
  }
}
