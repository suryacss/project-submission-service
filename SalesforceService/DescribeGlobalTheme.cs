// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeGlobalTheme
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
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class DescribeGlobalTheme
  {
    private DescribeGlobalResult globalField;
    private DescribeThemeItem[] themeField;

    public DescribeGlobalResult global
    {
      get => this.globalField;
      set => this.globalField = value;
    }

    [XmlArrayItem("themeItems", IsNullable = false)]
    public DescribeThemeItem[] theme
    {
      get => this.themeField;
      set => this.themeField = value;
    }
  }
}
