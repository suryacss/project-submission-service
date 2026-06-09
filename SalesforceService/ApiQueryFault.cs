// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApiQueryFault
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
  [XmlInclude(typeof (MalformedQueryFault))]
  [XmlInclude(typeof (MalformedSearchFault))]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [XmlType(Namespace = "urn:fault.enterprise.soap.sforce.com")]
  [XmlInclude(typeof (InvalidFieldFault))]
  [XmlInclude(typeof (InvalidSObjectFault))]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ApiQueryFault : ApiFault
  {
    private int rowField;
    private int columnField;

    public int row
    {
      get => this.rowField;
      set => this.rowField = value;
    }

    public int column
    {
      get => this.columnField;
      set => this.columnField = value;
    }
  }
}
