// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Contact
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
  public class Contact : INotifyPropertyChanged
  {
    private ContactRole[] contactRolesField;
    private string organizationNameField;
    private string prefixField;
    private string contactFirstNameField;
    private string contactLastNameField;
    private ContactMediums contactedViaField;
    private string timeZoneField;

    [XmlArrayItem("contactRole", IsNullable = false)]
    [XmlArray(Order = 0)]
    public ContactRole[] contactRoles
    {
      get => this.contactRolesField;
      set
      {
        this.contactRolesField = value;
        this.RaisePropertyChanged(nameof (contactRoles));
      }
    }

    [XmlElement(Order = 1)]
    public string organizationName
    {
      get => this.organizationNameField;
      set
      {
        this.organizationNameField = value;
        this.RaisePropertyChanged(nameof (organizationName));
      }
    }

    [XmlElement(Order = 2)]
    public string prefix
    {
      get => this.prefixField;
      set
      {
        this.prefixField = value;
        this.RaisePropertyChanged(nameof (prefix));
      }
    }

    [XmlElement(Order = 3)]
    public string contactFirstName
    {
      get => this.contactFirstNameField;
      set
      {
        this.contactFirstNameField = value;
        this.RaisePropertyChanged(nameof (contactFirstName));
      }
    }

    [XmlElement(Order = 4)]
    public string contactLastName
    {
      get => this.contactLastNameField;
      set
      {
        this.contactLastNameField = value;
        this.RaisePropertyChanged(nameof (contactLastName));
      }
    }

    [XmlElement(Order = 5)]
    public ContactMediums contactedVia
    {
      get => this.contactedViaField;
      set
      {
        this.contactedViaField = value;
        this.RaisePropertyChanged(nameof (contactedVia));
      }
    }

    [XmlElement(Order = 6)]
    public string timeZone
    {
      get => this.timeZoneField;
      set
      {
        this.timeZoneField = value;
        this.RaisePropertyChanged(nameof (timeZone));
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
