// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.SiteSurvey
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
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class SiteSurvey : LogicalResource
  {
    private string siteSurveyNameField;
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

    [XmlElement(DataType = "date", Order = 1)]
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
