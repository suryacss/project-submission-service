// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrderItem
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [XmlInclude(typeof (NetworkOrderItemDetail))]
  [Serializable]
  public class NetworkOrderItem : INotifyPropertyChanged
  {
    private OrderIdentifier networkOrderField;
    private string networkOrderItemNameField;
    private string networkOrderItemTypeNameField;
    private DateTime networkOrderItemCreatedDateField;
    private bool networkOrderItemCreatedDateFieldSpecified;
    private DateTime networkOrderItemRequestedDateField;
    private bool networkOrderItemRequestedDateFieldSpecified;
    private DateTime networkOrderItemCommitDateField;
    private bool networkOrderItemCommitDateFieldSpecified;
    private DateTime networkOrderItemRevisedCommitDateField;
    private bool networkOrderItemRevisedCommitDateFieldSpecified;
    private string networkOrderItemActionTypeField;
    private string networkOrderItemTypeField;
    private string networkOrderItemNumberField;
    private string networkOrderItemVersionField;
    private string networkOrderItemStatusCodeField;
    private bool networkOrderItemExpediteIndicatorField;
    private bool networkOrderItemExpediteIndicatorFieldSpecified;
    private bool networkOrderItemEscalationIndicatorField;
    private bool networkOrderItemEscalationIndicatorFieldSpecified;
    private string networkOrderItemExpediteLevelField;
    private string networkOrderItemNotesField;
    private Contact[] networkOrderItemContactsField;
    private BuildGroup networkOrderItemBuildGroupField;
    private string networkOrderItemRegionCodeField;
    private string networkOrderItemProductGroupField;

    [XmlElement(Order = 0)]
    public OrderIdentifier networkOrder
    {
      get => this.networkOrderField;
      set
      {
        this.networkOrderField = value;
        this.RaisePropertyChanged(nameof (networkOrder));
      }
    }

    [XmlElement(Order = 1)]
    public string networkOrderItemName
    {
      get => this.networkOrderItemNameField;
      set
      {
        this.networkOrderItemNameField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemName));
      }
    }

    [XmlElement(Order = 2)]
    public string networkOrderItemTypeName
    {
      get => this.networkOrderItemTypeNameField;
      set
      {
        this.networkOrderItemTypeNameField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemTypeName));
      }
    }

    [XmlElement(Order = 3)]
    public DateTime networkOrderItemCreatedDate
    {
      get => this.networkOrderItemCreatedDateField;
      set
      {
        this.networkOrderItemCreatedDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemCreatedDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderItemCreatedDateSpecified
    {
      get => this.networkOrderItemCreatedDateFieldSpecified;
      set
      {
        this.networkOrderItemCreatedDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderItemCreatedDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 4)]
    public DateTime networkOrderItemRequestedDate
    {
      get => this.networkOrderItemRequestedDateField;
      set
      {
        this.networkOrderItemRequestedDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemRequestedDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderItemRequestedDateSpecified
    {
      get => this.networkOrderItemRequestedDateFieldSpecified;
      set
      {
        this.networkOrderItemRequestedDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderItemRequestedDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 5)]
    public DateTime networkOrderItemCommitDate
    {
      get => this.networkOrderItemCommitDateField;
      set
      {
        this.networkOrderItemCommitDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemCommitDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderItemCommitDateSpecified
    {
      get => this.networkOrderItemCommitDateFieldSpecified;
      set
      {
        this.networkOrderItemCommitDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderItemCommitDateSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 6)]
    public DateTime networkOrderItemRevisedCommitDate
    {
      get => this.networkOrderItemRevisedCommitDateField;
      set
      {
        this.networkOrderItemRevisedCommitDateField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemRevisedCommitDate));
      }
    }

    [XmlIgnore]
    public bool networkOrderItemRevisedCommitDateSpecified
    {
      get => this.networkOrderItemRevisedCommitDateFieldSpecified;
      set
      {
        this.networkOrderItemRevisedCommitDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderItemRevisedCommitDateSpecified));
      }
    }

    [XmlElement(Order = 7)]
    public string networkOrderItemActionType
    {
      get => this.networkOrderItemActionTypeField;
      set
      {
        this.networkOrderItemActionTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemActionType));
      }
    }

    [XmlElement(Order = 8)]
    public string networkOrderItemType
    {
      get => this.networkOrderItemTypeField;
      set
      {
        this.networkOrderItemTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemType));
      }
    }

    [XmlElement(Order = 9)]
    public string networkOrderItemNumber
    {
      get => this.networkOrderItemNumberField;
      set
      {
        this.networkOrderItemNumberField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemNumber));
      }
    }

    [XmlElement(Order = 10)]
    public string networkOrderItemVersion
    {
      get => this.networkOrderItemVersionField;
      set
      {
        this.networkOrderItemVersionField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemVersion));
      }
    }

    [XmlElement(Order = 11)]
    public string networkOrderItemStatusCode
    {
      get => this.networkOrderItemStatusCodeField;
      set
      {
        this.networkOrderItemStatusCodeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemStatusCode));
      }
    }

    [XmlElement(Order = 12)]
    public bool networkOrderItemExpediteIndicator
    {
      get => this.networkOrderItemExpediteIndicatorField;
      set
      {
        this.networkOrderItemExpediteIndicatorField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemExpediteIndicator));
      }
    }

    [XmlIgnore]
    public bool networkOrderItemExpediteIndicatorSpecified
    {
      get => this.networkOrderItemExpediteIndicatorFieldSpecified;
      set
      {
        this.networkOrderItemExpediteIndicatorFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderItemExpediteIndicatorSpecified));
      }
    }

    [XmlElement(Order = 13)]
    public bool networkOrderItemEscalationIndicator
    {
      get => this.networkOrderItemEscalationIndicatorField;
      set
      {
        this.networkOrderItemEscalationIndicatorField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemEscalationIndicator));
      }
    }

    [XmlIgnore]
    public bool networkOrderItemEscalationIndicatorSpecified
    {
      get => this.networkOrderItemEscalationIndicatorFieldSpecified;
      set
      {
        this.networkOrderItemEscalationIndicatorFieldSpecified = value;
        this.RaisePropertyChanged(nameof (networkOrderItemEscalationIndicatorSpecified));
      }
    }

    [XmlElement(Order = 14)]
    public string networkOrderItemExpediteLevel
    {
      get => this.networkOrderItemExpediteLevelField;
      set
      {
        this.networkOrderItemExpediteLevelField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemExpediteLevel));
      }
    }

    [XmlElement(Order = 15)]
    public string networkOrderItemNotes
    {
      get => this.networkOrderItemNotesField;
      set
      {
        this.networkOrderItemNotesField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemNotes));
      }
    }

    [XmlArray(Order = 16)]
    [XmlArrayItem("contact", IsNullable = false)]
    public Contact[] networkOrderItemContacts
    {
      get => this.networkOrderItemContactsField;
      set
      {
        this.networkOrderItemContactsField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemContacts));
      }
    }

    [XmlElement(Order = 17)]
    public BuildGroup networkOrderItemBuildGroup
    {
      get => this.networkOrderItemBuildGroupField;
      set
      {
        this.networkOrderItemBuildGroupField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemBuildGroup));
      }
    }

    [XmlElement(Order = 18)]
    public string networkOrderItemRegionCode
    {
      get => this.networkOrderItemRegionCodeField;
      set
      {
        this.networkOrderItemRegionCodeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemRegionCode));
      }
    }

    [XmlElement(Order = 19)]
    public string networkOrderItemProductGroup
    {
      get => this.networkOrderItemProductGroupField;
      set
      {
        this.networkOrderItemProductGroupField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemProductGroup));
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
