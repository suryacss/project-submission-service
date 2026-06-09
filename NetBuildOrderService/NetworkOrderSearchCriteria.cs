// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.NetworkOrderSearchCriteria
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
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [Serializable]
  public class NetworkOrderSearchCriteria : INotifyPropertyChanged
  {
    private MatchType matchTypeField;
    private bool matchTypeFieldSpecified;
    private string orderNumberField;
    private string orderVersionNumberField;
    private string networkOrderTypeNameField;
    private string projectIdentifierField;

    [XmlElement(Order = 0)]
    public MatchType matchType
    {
      get => this.matchTypeField;
      set
      {
        this.matchTypeField = value;
        this.RaisePropertyChanged(nameof (matchType));
      }
    }

    [XmlIgnore]
    public bool matchTypeSpecified
    {
      get => this.matchTypeFieldSpecified;
      set
      {
        this.matchTypeFieldSpecified = value;
        this.RaisePropertyChanged(nameof (matchTypeSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public string orderNumber
    {
      get => this.orderNumberField;
      set
      {
        this.orderNumberField = value;
        this.RaisePropertyChanged(nameof (orderNumber));
      }
    }

    [XmlElement(Order = 2)]
    public string orderVersionNumber
    {
      get => this.orderVersionNumberField;
      set
      {
        this.orderVersionNumberField = value;
        this.RaisePropertyChanged(nameof (orderVersionNumber));
      }
    }

    [XmlElement(Order = 3)]
    public string networkOrderTypeName
    {
      get => this.networkOrderTypeNameField;
      set
      {
        this.networkOrderTypeNameField = value;
        this.RaisePropertyChanged(nameof (networkOrderTypeName));
      }
    }

    [XmlElement(Order = 4)]
    public string projectIdentifier
    {
      get => this.projectIdentifierField;
      set
      {
        this.projectIdentifierField = value;
        this.RaisePropertyChanged(nameof (projectIdentifier));
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
