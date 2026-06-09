// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.ContactRole
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [Serializable]
  public class ContactRole : INotifyPropertyChanged
  {
    private string roleTypeField;
    private string roleDescriptionField;

    [XmlElement(Order = 0)]
    public string roleType
    {
      get => this.roleTypeField;
      set
      {
        this.roleTypeField = value;
        this.RaisePropertyChanged(nameof (roleType));
      }
    }

    [XmlElement(Order = 1)]
    public string roleDescription
    {
      get => this.roleDescriptionField;
      set
      {
        this.roleDescriptionField = value;
        this.RaisePropertyChanged(nameof (roleDescription));
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
