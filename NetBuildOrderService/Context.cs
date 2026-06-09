// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Context
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [Serializable]
  public class Context : INotifyPropertyChanged
  {
    private string sourceField;
    private string performerField;
    private string correlationIdField;
    private string transactionIdField;
    private ContentContext contentContextField;

    [XmlElement(Order = 0)]
    public string source
    {
      get => this.sourceField;
      set
      {
        this.sourceField = value;
        this.RaisePropertyChanged(nameof (source));
      }
    }

    [XmlElement(Order = 1)]
    public string performer
    {
      get => this.performerField;
      set
      {
        this.performerField = value;
        this.RaisePropertyChanged(nameof (performer));
      }
    }

    [XmlElement(Order = 2)]
    public string correlationId
    {
      get => this.correlationIdField;
      set
      {
        this.correlationIdField = value;
        this.RaisePropertyChanged(nameof (correlationId));
      }
    }

    [XmlElement(Order = 3)]
    public string transactionId
    {
      get => this.transactionIdField;
      set
      {
        this.transactionIdField = value;
        this.RaisePropertyChanged(nameof (transactionId));
      }
    }

    [XmlElement(Order = 4)]
    public ContentContext contentContext
    {
      get => this.contentContextField;
      set
      {
        this.contentContextField = value;
        this.RaisePropertyChanged(nameof (contentContext));
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
