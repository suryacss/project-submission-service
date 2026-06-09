// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.ContentContext
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  public class ContentContext : INotifyPropertyChanged
  {
    private string targetSystemIdentificationField;
    private string originatingSystemIdentificationField;
    private string processIdentificationField;

    [XmlElement(Order = 0)]
    public string targetSystemIdentification
    {
      get => this.targetSystemIdentificationField;
      set
      {
        this.targetSystemIdentificationField = value;
        this.RaisePropertyChanged(nameof (targetSystemIdentification));
      }
    }

    [XmlElement(Order = 1)]
    public string originatingSystemIdentification
    {
      get => this.originatingSystemIdentificationField;
      set
      {
        this.originatingSystemIdentificationField = value;
        this.RaisePropertyChanged(nameof (originatingSystemIdentification));
      }
    }

    [XmlElement(Order = 2)]
    public string processIdentification
    {
      get => this.processIdentificationField;
      set
      {
        this.processIdentificationField = value;
        this.RaisePropertyChanged(nameof (processIdentification));
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
