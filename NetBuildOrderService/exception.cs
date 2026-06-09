// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.exception
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class exception : INotifyPropertyChanged
  {
    private string codeField;
    private string messageField;
    private string detailField;
    private BusinessKey[] businessKeyField;
    private detailMessage[] subExceptionField;

    [XmlElement(Order = 0)]
    public string code
    {
      get => this.codeField;
      set
      {
        this.codeField = value;
        this.RaisePropertyChanged(nameof (code));
      }
    }

    [XmlElement(Order = 1)]
    public string message
    {
      get => this.messageField;
      set
      {
        this.messageField = value;
        this.RaisePropertyChanged(nameof (message));
      }
    }

    [XmlElement(Order = 2)]
    public string detail
    {
      get => this.detailField;
      set
      {
        this.detailField = value;
        this.RaisePropertyChanged(nameof (detail));
      }
    }

    [XmlElement("businessKey", Order = 3)]
    public BusinessKey[] businessKey
    {
      get => this.businessKeyField;
      set
      {
        this.businessKeyField = value;
        this.RaisePropertyChanged(nameof (businessKey));
      }
    }

    [XmlElement("subException", Order = 4)]
    public detailMessage[] subException
    {
      get => this.subExceptionField;
      set
      {
        this.subExceptionField = value;
        this.RaisePropertyChanged(nameof (subException));
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
