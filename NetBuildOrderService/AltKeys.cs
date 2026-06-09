// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.AltKeys
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class AltKeys : INotifyPropertyChanged
  {
    private string locNumField;
    private string redLineLocNumField;
    private string physicalSiteEIDField;
    private string locationEIDField;
    private string uUIDField;

    [XmlElement(Order = 0)]
    public string locNum
    {
      get => this.locNumField;
      set
      {
        this.locNumField = value;
        this.RaisePropertyChanged(nameof (locNum));
      }
    }

    [XmlElement(Order = 1)]
    public string redLineLocNum
    {
      get => this.redLineLocNumField;
      set
      {
        this.redLineLocNumField = value;
        this.RaisePropertyChanged(nameof (redLineLocNum));
      }
    }

    [XmlElement(Order = 2)]
    public string physicalSiteEID
    {
      get => this.physicalSiteEIDField;
      set
      {
        this.physicalSiteEIDField = value;
        this.RaisePropertyChanged(nameof (physicalSiteEID));
      }
    }

    [XmlElement(Order = 3)]
    public string locationEID
    {
      get => this.locationEIDField;
      set
      {
        this.locationEIDField = value;
        this.RaisePropertyChanged(nameof (locationEID));
      }
    }

    [XmlElement(Order = 4)]
    public string UUID
    {
      get => this.uUIDField;
      set
      {
        this.uUIDField = value;
        this.RaisePropertyChanged(nameof (UUID));
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
