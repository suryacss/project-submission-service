// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.LocaleOptions
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib.SalesforceService
{
  [XmlRoot(Namespace = "urn:enterprise.soap.sforce.com", IsNullable = false)]
  [DebuggerStepThrough]
  [XmlType(AnonymousType = true, Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class LocaleOptions : SoapHeader
  {
    private string languageField;
    private bool localizeErrorsField;
    private bool localizeErrorsFieldSpecified;

    public string language
    {
      get => this.languageField;
      set => this.languageField = value;
    }

    public bool localizeErrors
    {
      get => this.localizeErrorsField;
      set => this.localizeErrorsField = value;
    }

    [XmlIgnore]
    public bool localizeErrorsSpecified
    {
      get => this.localizeErrorsFieldSpecified;
      set => this.localizeErrorsFieldSpecified = value;
    }
  }
}
