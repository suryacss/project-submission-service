// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Resource
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
  [XmlInclude(typeof (OutsidePlant))]
  [DebuggerStepThrough]
  [XmlInclude(typeof (POP))]
  [XmlInclude(typeof (Electronics))]
  [XmlInclude(typeof (Infrastructure))]
  [XmlInclude(typeof (BulkCable))]
  [XmlInclude(typeof (LeasedResource))]
  [XmlInclude(typeof (GroomsCircuitLight))]
  [XmlInclude(typeof (ThirdPartyResource))]
  [XmlInclude(typeof (LeasedAccessSolutionSegment))]
  [XmlInclude(typeof (LeasedAccessConnection))]
  [XmlInclude(typeof (LeasedAccess))]
  [XmlInclude(typeof (GroomsCircuit))]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [XmlInclude(typeof (IMT))]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [XmlInclude(typeof (LogicalResource))]
  [XmlInclude(typeof (OnnetGrooms))]
  [XmlInclude(typeof (SystemPlan))]
  [XmlInclude(typeof (TNOCEntranceCriteria))]
  [XmlInclude(typeof (SiteSurvey))]
  [XmlInclude(typeof (TestAlarm))]
  [XmlInclude(typeof (CompoundResource))]
  [XmlInclude(typeof (Ring))]
  [XmlInclude(typeof (PhysicalResource))]
  [XmlInclude(typeof (RackMatrix))]
  [Serializable]
  public abstract class Resource : INotifyPropertyChanged
  {
    private string parentResourceIdentifierField;
    private string resourceIdentifierField;
    private string resourceNameField;
    private string resourceTypeNameField;
    private string resourceWorkGroupField;
    private ResourceEndpoint[] resourceEndpointsField;

    [XmlElement(Order = 0)]
    public string parentResourceIdentifier
    {
      get => this.parentResourceIdentifierField;
      set
      {
        this.parentResourceIdentifierField = value;
        this.RaisePropertyChanged(nameof (parentResourceIdentifier));
      }
    }

    [XmlElement(Order = 1)]
    public string resourceIdentifier
    {
      get => this.resourceIdentifierField;
      set
      {
        this.resourceIdentifierField = value;
        this.RaisePropertyChanged(nameof (resourceIdentifier));
      }
    }

    [XmlElement(Order = 2)]
    public string resourceName
    {
      get => this.resourceNameField;
      set
      {
        this.resourceNameField = value;
        this.RaisePropertyChanged(nameof (resourceName));
      }
    }

    [XmlElement(Order = 3)]
    public string resourceTypeName
    {
      get => this.resourceTypeNameField;
      set
      {
        this.resourceTypeNameField = value;
        this.RaisePropertyChanged(nameof (resourceTypeName));
      }
    }

    [XmlElement(Order = 4)]
    public string resourceWorkGroup
    {
      get => this.resourceWorkGroupField;
      set
      {
        this.resourceWorkGroupField = value;
        this.RaisePropertyChanged(nameof (resourceWorkGroup));
      }
    }

    [XmlArrayItem("endpoint", IsNullable = false)]
    [XmlArray(Order = 5)]
    public ResourceEndpoint[] resourceEndpoints
    {
      get => this.resourceEndpointsField;
      set
      {
        this.resourceEndpointsField = value;
        this.RaisePropertyChanged(nameof (resourceEndpoints));
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
