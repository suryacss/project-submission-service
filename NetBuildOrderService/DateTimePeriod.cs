// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.DateTimePeriod
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  public class DateTimePeriod : INotifyPropertyChanged
  {
    private DateTime startDateTimeField;
    private DateTime endDateTimeField;
    private bool endDateTimeFieldSpecified;

    [XmlElement(Order = 0)]
    public DateTime startDateTime
    {
      get => this.startDateTimeField;
      set
      {
        this.startDateTimeField = value;
        this.RaisePropertyChanged(nameof (startDateTime));
      }
    }

    [XmlElement(Order = 1)]
    public DateTime endDateTime
    {
      get => this.endDateTimeField;
      set
      {
        this.endDateTimeField = value;
        this.RaisePropertyChanged(nameof (endDateTime));
      }
    }

    [XmlIgnore]
    public bool endDateTimeSpecified
    {
      get => this.endDateTimeFieldSpecified;
      set
      {
        this.endDateTimeFieldSpecified = value;
        this.RaisePropertyChanged(nameof (endDateTimeSpecified));
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
