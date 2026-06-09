// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.BusinessKey
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
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class BusinessKey : INotifyPropertyChanged
  {
    private string businessKeyNameField;
    private string businessKeyValueField;

    [XmlElement(Order = 0)]
    public string businessKeyName
    {
      get => this.businessKeyNameField;
      set
      {
        this.businessKeyNameField = value;
        this.RaisePropertyChanged(nameof (businessKeyName));
      }
    }

    [XmlElement(Order = 1)]
    public string businessKeyValue
    {
      get => this.businessKeyValueField;
      set
      {
        this.businessKeyValueField = value;
        this.RaisePropertyChanged(nameof (businessKeyValue));
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
