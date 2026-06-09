// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrderItemStructure
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
  [Serializable]
  public class NetworkOrderItemStructure : INotifyPropertyChanged
  {
    private string networkOrderItemNumberField;
    private string networkOrderItemVersionField;
    private DateTime networkOrderItemCommitDateField;
    private bool networkOrderItemCommitDateFieldSpecified;
    private DateTime networkOrderItemRevisedCommitDateField;
    private bool networkOrderItemRevisedCommitDateFieldSpecified;
    private DateTime networkOrderItemCreatedDateField;
    private bool networkOrderItemCreatedDateFieldSpecified;
    private string networkOrderItemActionTypeField;
    private string networkOrderItemTypeField;
    private string networkOrderItemTypeNameField;
    private string networkOrderItemNotesField;
    private string networkOrderItemStatusCodeField;
    private CustomerHeldOrder[] customerHeldOrdersField;
    private NetworkOrderItemComponentStructure[] networkOrderItemComponentsField;

    [XmlElement(Order = 0)]
    public string networkOrderItemNumber
    {
      get => this.networkOrderItemNumberField;
      set
      {
        this.networkOrderItemNumberField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemNumber));
      }
    }

    [XmlElement(Order = 1)]
    public string networkOrderItemVersion
    {
      get => this.networkOrderItemVersionField;
      set
      {
        this.networkOrderItemVersionField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemVersion));
      }
    }

    [XmlElement(DataType = "date", Order = 2)]
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

    [XmlElement(DataType = "date", Order = 3)]
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

    [XmlElement(Order = 4)]
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

    [XmlElement(Order = 5)]
    public string networkOrderItemActionType
    {
      get => this.networkOrderItemActionTypeField;
      set
      {
        this.networkOrderItemActionTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemActionType));
      }
    }

    [XmlElement(Order = 6)]
    public string networkOrderItemType
    {
      get => this.networkOrderItemTypeField;
      set
      {
        this.networkOrderItemTypeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemType));
      }
    }

    [XmlElement(Order = 7)]
    public string networkOrderItemTypeName
    {
      get => this.networkOrderItemTypeNameField;
      set
      {
        this.networkOrderItemTypeNameField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemTypeName));
      }
    }

    [XmlElement(Order = 8)]
    public string networkOrderItemNotes
    {
      get => this.networkOrderItemNotesField;
      set
      {
        this.networkOrderItemNotesField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemNotes));
      }
    }

    [XmlElement(Order = 9)]
    public string networkOrderItemStatusCode
    {
      get => this.networkOrderItemStatusCodeField;
      set
      {
        this.networkOrderItemStatusCodeField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemStatusCode));
      }
    }

    [XmlArray(Order = 10)]
    [XmlArrayItem("heldOrder", IsNullable = false)]
    public CustomerHeldOrder[] customerHeldOrders
    {
      get => this.customerHeldOrdersField;
      set
      {
        this.customerHeldOrdersField = value;
        this.RaisePropertyChanged(nameof (customerHeldOrders));
      }
    }

    [XmlElement("networkOrderItemComponents", Order = 11)]
    public NetworkOrderItemComponentStructure[] networkOrderItemComponents
    {
      get => this.networkOrderItemComponentsField;
      set
      {
        this.networkOrderItemComponentsField = value;
        this.RaisePropertyChanged(nameof (networkOrderItemComponents));
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
