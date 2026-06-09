// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.EmailFileAttachment
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public class EmailFileAttachment
  {
    private byte[] bodyField;
    private string contentTypeField;
    private string fileNameField;
    private bool inlineField;
    private bool inlineFieldSpecified;

    [XmlElement(DataType = "base64Binary", IsNullable = true)]
    public byte[] body
    {
      get => this.bodyField;
      set => this.bodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public string contentType
    {
      get => this.contentTypeField;
      set => this.contentTypeField = value;
    }

    public string fileName
    {
      get => this.fileNameField;
      set => this.fileNameField = value;
    }

    public bool inline
    {
      get => this.inlineField;
      set => this.inlineField = value;
    }

    [XmlIgnore]
    public bool inlineSpecified
    {
      get => this.inlineFieldSpecified;
      set => this.inlineFieldSpecified = value;
    }
  }
}
