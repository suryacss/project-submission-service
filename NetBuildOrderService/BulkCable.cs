// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.BulkCable
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  public class BulkCable : PhysicalResource
  {
    private int bundleNumberField;
    private bool bundleNumberFieldSpecified;
    private string abamCableSizeField;
    private string fiberRunSupportField;

    [XmlElement(Order = 0)]
    public int bundleNumber
    {
      get => this.bundleNumberField;
      set
      {
        this.bundleNumberField = value;
        this.RaisePropertyChanged(nameof (bundleNumber));
      }
    }

    [XmlIgnore]
    public bool bundleNumberSpecified
    {
      get => this.bundleNumberFieldSpecified;
      set
      {
        this.bundleNumberFieldSpecified = value;
        this.RaisePropertyChanged(nameof (bundleNumberSpecified));
      }
    }

    [XmlElement(Order = 1)]
    public string abamCableSize
    {
      get => this.abamCableSizeField;
      set
      {
        this.abamCableSizeField = value;
        this.RaisePropertyChanged(nameof (abamCableSize));
      }
    }

    [XmlElement(Order = 2)]
    public string fiberRunSupport
    {
      get => this.fiberRunSupportField;
      set
      {
        this.fiberRunSupportField = value;
        this.RaisePropertyChanged(nameof (fiberRunSupport));
      }
    }
  }
}
