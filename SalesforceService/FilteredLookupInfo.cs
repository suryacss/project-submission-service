// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.FilteredLookupInfo
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [Serializable]
  public class FilteredLookupInfo
  {
    private string[] controllingFieldsField;
    private bool dependentField;
    private bool optionalFilterField;

    [XmlElement("controllingFields")]
    public string[] controllingFields
    {
      get => this.controllingFieldsField;
      set => this.controllingFieldsField = value;
    }

    public bool dependent
    {
      get => this.dependentField;
      set => this.dependentField = value;
    }

    public bool optionalFilter
    {
      get => this.optionalFilterField;
      set => this.optionalFilterField = value;
    }
  }
}
