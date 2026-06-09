// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.GetDeletedResult
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class GetDeletedResult
  {
    private DeletedRecord[] deletedRecordsField;
    private DateTime earliestDateAvailableField;
    private DateTime latestDateCoveredField;

    [XmlElement("deletedRecords")]
    public DeletedRecord[] deletedRecords
    {
      get => this.deletedRecordsField;
      set => this.deletedRecordsField = value;
    }

    public DateTime earliestDateAvailable
    {
      get => this.earliestDateAvailableField;
      set => this.earliestDateAvailableField = value;
    }

    public DateTime latestDateCovered
    {
      get => this.latestDateCoveredField;
      set => this.latestDateCoveredField = value;
    }
  }
}
