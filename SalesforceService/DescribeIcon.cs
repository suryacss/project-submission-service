// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.DescribeIcon
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
  public class DescribeIcon
  {
    private string contentTypeField;
    private int? heightField;
    private string themeField;
    private string urlField;
    private int? widthField;

    public string contentType
    {
      get => this.contentTypeField;
      set => this.contentTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? height
    {
      get => this.heightField;
      set => this.heightField = value;
    }

    public string theme
    {
      get => this.themeField;
      set => this.themeField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? width
    {
      get => this.widthField;
      set => this.widthField = value;
    }
  }
}
