// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.SiteSurveyOrder
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
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  public class SiteSurveyOrder : NetworkOrder
  {
    private string siteSurveyNameField;
    private string workSiteField;
    private string dispatchGatewayField;
    private string siteDispositionField;
    private string clliCodeField;
    private string siteTypeField;
    private DateTime fieldCommitDateField;
    private bool fieldCommitDateFieldSpecified;

    [XmlElement(Order = 0)]
    public string siteSurveyName
    {
      get => this.siteSurveyNameField;
      set
      {
        this.siteSurveyNameField = value;
        this.RaisePropertyChanged(nameof (siteSurveyName));
      }
    }

    [XmlElement(Order = 1)]
    public string workSite
    {
      get => this.workSiteField;
      set
      {
        this.workSiteField = value;
        this.RaisePropertyChanged(nameof (workSite));
      }
    }

    [XmlElement(Order = 2)]
    public string dispatchGateway
    {
      get => this.dispatchGatewayField;
      set
      {
        this.dispatchGatewayField = value;
        this.RaisePropertyChanged(nameof (dispatchGateway));
      }
    }

    [XmlElement(Order = 3)]
    public string siteDisposition
    {
      get => this.siteDispositionField;
      set
      {
        this.siteDispositionField = value;
        this.RaisePropertyChanged(nameof (siteDisposition));
      }
    }

    [XmlElement(Order = 4)]
    public string clliCode
    {
      get => this.clliCodeField;
      set
      {
        this.clliCodeField = value;
        this.RaisePropertyChanged(nameof (clliCode));
      }
    }

    [XmlElement(Order = 5)]
    public string siteType
    {
      get => this.siteTypeField;
      set
      {
        this.siteTypeField = value;
        this.RaisePropertyChanged(nameof (siteType));
      }
    }

    [XmlElement(DataType = "date", Order = 6)]
    public DateTime fieldCommitDate
    {
      get => this.fieldCommitDateField;
      set
      {
        this.fieldCommitDateField = value;
        this.RaisePropertyChanged(nameof (fieldCommitDate));
      }
    }

    [XmlIgnore]
    public bool fieldCommitDateSpecified
    {
      get => this.fieldCommitDateFieldSpecified;
      set
      {
        this.fieldCommitDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (fieldCommitDateSpecified));
      }
    }
  }
}
