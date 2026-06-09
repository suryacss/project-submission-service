// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ListViewOrderBy
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class ListViewOrderBy
  {
    private string fieldNameOrPathField;
    private orderByNullsPosition? nullsPositionField;
    private orderByDirection? sortDirectionField;

    public string fieldNameOrPath
    {
      get => this.fieldNameOrPathField;
      set => this.fieldNameOrPathField = value;
    }

    [XmlElement(IsNullable = true)]
    public orderByNullsPosition? nullsPosition
    {
      get => this.nullsPositionField;
      set => this.nullsPositionField = value;
    }

    [XmlElement(IsNullable = true)]
    public orderByDirection? sortDirection
    {
      get => this.sortDirectionField;
      set => this.sortDirectionField = value;
    }
  }
}
