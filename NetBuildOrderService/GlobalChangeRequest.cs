// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.GlobalChangeRequest
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DebuggerStepThrough]
  [Serializable]
  public class GlobalChangeRequest : INotifyPropertyChanged
  {
    private string gCRIdentifierField;
    private string gCRTypeNameField;
    private bool gCRRequiredIndicatorField;
    private bool gCRRequiredIndicatorFieldSpecified;
    private DateTime gCRScheduleDateField;
    private bool gCRScheduleDateFieldSpecified;
    private string gCRNameField;
    private string gCRSubmittedByField;

    [XmlElement(Order = 0)]
    public string GCRIdentifier
    {
      get => this.gCRIdentifierField;
      set
      {
        this.gCRIdentifierField = value;
        this.RaisePropertyChanged(nameof (GCRIdentifier));
      }
    }

    [XmlElement(Order = 1)]
    public string GCRTypeName
    {
      get => this.gCRTypeNameField;
      set
      {
        this.gCRTypeNameField = value;
        this.RaisePropertyChanged(nameof (GCRTypeName));
      }
    }

    [XmlElement(Order = 2)]
    public bool GCRRequiredIndicator
    {
      get => this.gCRRequiredIndicatorField;
      set
      {
        this.gCRRequiredIndicatorField = value;
        this.RaisePropertyChanged(nameof (GCRRequiredIndicator));
      }
    }

    [XmlIgnore]
    public bool GCRRequiredIndicatorSpecified
    {
      get => this.gCRRequiredIndicatorFieldSpecified;
      set
      {
        this.gCRRequiredIndicatorFieldSpecified = value;
        this.RaisePropertyChanged(nameof (GCRRequiredIndicatorSpecified));
      }
    }

    [XmlElement(DataType = "date", Order = 3)]
    public DateTime GCRScheduleDate
    {
      get => this.gCRScheduleDateField;
      set
      {
        this.gCRScheduleDateField = value;
        this.RaisePropertyChanged(nameof (GCRScheduleDate));
      }
    }

    [XmlIgnore]
    public bool GCRScheduleDateSpecified
    {
      get => this.gCRScheduleDateFieldSpecified;
      set
      {
        this.gCRScheduleDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (GCRScheduleDateSpecified));
      }
    }

    [XmlElement(Order = 4)]
    public string GCRName
    {
      get => this.gCRNameField;
      set
      {
        this.gCRNameField = value;
        this.RaisePropertyChanged(nameof (GCRName));
      }
    }

    [XmlElement(Order = 5)]
    public string GCRSubmittedBy
    {
      get => this.gCRSubmittedByField;
      set
      {
        this.gCRSubmittedByField = value;
        this.RaisePropertyChanged(nameof (GCRSubmittedBy));
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
