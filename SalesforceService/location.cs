// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.location
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlInclude(typeof (address))]
  [Serializable]
  public class location
  {
    private double? latitudeField;
    private double? longitudeField;

    [XmlElement(IsNullable = true)]
    public double? latitude
    {
      get => this.latitudeField;
      set => this.latitudeField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? longitude
    {
      get => this.longitudeField;
      set => this.longitudeField = value;
    }
  }
}
