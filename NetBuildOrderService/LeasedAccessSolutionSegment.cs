// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.LeasedAccessSolutionSegment
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
  public class LeasedAccessSolutionSegment : LeasedResource
  {
    private string segmentIdentifierField;
    private string segmentTypeField;
    private Vendor primaryVendorField;
    private Vendor[] secondaryVendorField;
    private string termField;
    private string termLiabilityField;
    private string framingField;
    private string lineCodingField;
    private string signalingField;
    private string protectionTypeField;
    private string signalingTypeField;
    private string eCCKTField;
    private string lTIDField;
    private string mRCField;
    private string nRCField;

    [XmlElement(Order = 0)]
    public string segmentIdentifier
    {
      get => this.segmentIdentifierField;
      set
      {
        this.segmentIdentifierField = value;
        this.RaisePropertyChanged(nameof (segmentIdentifier));
      }
    }

    [XmlElement(Order = 1)]
    public string segmentType
    {
      get => this.segmentTypeField;
      set
      {
        this.segmentTypeField = value;
        this.RaisePropertyChanged(nameof (segmentType));
      }
    }

    [XmlElement(Order = 2)]
    public Vendor primaryVendor
    {
      get => this.primaryVendorField;
      set
      {
        this.primaryVendorField = value;
        this.RaisePropertyChanged(nameof (primaryVendor));
      }
    }

    [XmlElement("secondaryVendor", Order = 3)]
    public Vendor[] secondaryVendor
    {
      get => this.secondaryVendorField;
      set
      {
        this.secondaryVendorField = value;
        this.RaisePropertyChanged(nameof (secondaryVendor));
      }
    }

    [XmlElement(Order = 4)]
    public string term
    {
      get => this.termField;
      set
      {
        this.termField = value;
        this.RaisePropertyChanged(nameof (term));
      }
    }

    [XmlElement(Order = 5)]
    public string termLiability
    {
      get => this.termLiabilityField;
      set
      {
        this.termLiabilityField = value;
        this.RaisePropertyChanged(nameof (termLiability));
      }
    }

    [XmlElement(Order = 6)]
    public string framing
    {
      get => this.framingField;
      set
      {
        this.framingField = value;
        this.RaisePropertyChanged(nameof (framing));
      }
    }

    [XmlElement(Order = 7)]
    public string lineCoding
    {
      get => this.lineCodingField;
      set
      {
        this.lineCodingField = value;
        this.RaisePropertyChanged(nameof (lineCoding));
      }
    }

    [XmlElement(Order = 8)]
    public string signaling
    {
      get => this.signalingField;
      set
      {
        this.signalingField = value;
        this.RaisePropertyChanged(nameof (signaling));
      }
    }

    [XmlElement(Order = 9)]
    public string protectionType
    {
      get => this.protectionTypeField;
      set
      {
        this.protectionTypeField = value;
        this.RaisePropertyChanged(nameof (protectionType));
      }
    }

    [XmlElement(Order = 10)]
    public string signalingType
    {
      get => this.signalingTypeField;
      set
      {
        this.signalingTypeField = value;
        this.RaisePropertyChanged(nameof (signalingType));
      }
    }

    [XmlElement(Order = 11)]
    public string ECCKT
    {
      get => this.eCCKTField;
      set
      {
        this.eCCKTField = value;
        this.RaisePropertyChanged(nameof (ECCKT));
      }
    }

    [XmlElement(Order = 12)]
    public string LTID
    {
      get => this.lTIDField;
      set
      {
        this.lTIDField = value;
        this.RaisePropertyChanged(nameof (LTID));
      }
    }

    [XmlElement(Order = 13)]
    public string MRC
    {
      get => this.mRCField;
      set
      {
        this.mRCField = value;
        this.RaisePropertyChanged(nameof (MRC));
      }
    }

    [XmlElement(Order = 14)]
    public string NRC
    {
      get => this.nRCField;
      set
      {
        this.nRCField = value;
        this.RaisePropertyChanged(nameof (NRC));
      }
    }
  }
}
