// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.PhysicalLocation
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
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DebuggerStepThrough]
  [Serializable]
  public class PhysicalLocation : INotifyPropertyChanged
  {
    private string nameField;
    private Decimal idField;
    private bool idFieldSpecified;

    [XmlElement(Order = 0)]
    public string name
    {
      get => this.nameField;
      set
      {
        this.nameField = value;
        this.RaisePropertyChanged(nameof (name));
      }
    }

    [XmlElement(Order = 1)]
    public Decimal id
    {
      get => this.idField;
      set
      {
        this.idField = value;
        this.RaisePropertyChanged(nameof (id));
      }
    }

    [XmlIgnore]
    public bool idSpecified
    {
      get => this.idFieldSpecified;
      set
      {
        this.idFieldSpecified = value;
        this.RaisePropertyChanged(nameof (idSpecified));
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
