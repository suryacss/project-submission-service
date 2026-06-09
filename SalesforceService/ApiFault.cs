// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApiFault
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib.SalesforceService
{
  [XmlInclude(typeof (InvalidNewPasswordFault))]
  [XmlInclude(typeof (InvalidSObjectFault))]
  [XmlInclude(typeof (UnexpectedErrorFault))]
  [XmlType(Namespace = "urn:fault.enterprise.soap.sforce.com")]
  [XmlInclude(typeof (InvalidQueryLocatorFault))]
  [XmlInclude(typeof (LoginFault))]
  [XmlInclude(typeof (ApiQueryFault))]
  [XmlInclude(typeof (MalformedSearchFault))]
  [XmlInclude(typeof (MalformedQueryFault))]
  [XmlInclude(typeof (InvalidIdFault))]
  [XmlInclude(typeof (InvalidFieldFault))]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ApiFault
  {
    private ExceptionCode exceptionCodeField;
    private string exceptionMessageField;
    private ExtendedErrorDetails[] extendedErrorDetailsField;

    public ExceptionCode exceptionCode
    {
      get => this.exceptionCodeField;
      set => this.exceptionCodeField = value;
    }

    public string exceptionMessage
    {
      get => this.exceptionMessageField;
      set => this.exceptionMessageField = value;
    }

    [XmlElement("extendedErrorDetails", IsNullable = true)]
    public ExtendedErrorDetails[] extendedErrorDetails
    {
      get => this.extendedErrorDetailsField;
      set => this.extendedErrorDetailsField = value;
    }
  }
}
