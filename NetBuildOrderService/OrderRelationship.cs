// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.OrderRelationship
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
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class OrderRelationship : INotifyPropertyChanged
  {
    private string relationshipTypeField;
    private OrderIdentifier relatedOrderIdentifierField;
    private string relationshipTypeDescriptionField;

    [XmlElement(Order = 0)]
    public string relationshipType
    {
      get => this.relationshipTypeField;
      set
      {
        this.relationshipTypeField = value;
        this.RaisePropertyChanged(nameof (relationshipType));
      }
    }

    [XmlElement(Order = 1)]
    public OrderIdentifier relatedOrderIdentifier
    {
      get => this.relatedOrderIdentifierField;
      set
      {
        this.relatedOrderIdentifierField = value;
        this.RaisePropertyChanged(nameof (relatedOrderIdentifier));
      }
    }

    [XmlElement(Order = 2)]
    public string relationshipTypeDescription
    {
      get => this.relationshipTypeDescriptionField;
      set
      {
        this.relationshipTypeDescriptionField = value;
        this.RaisePropertyChanged(nameof (relationshipTypeDescription));
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
