// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApexClass
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class ApexClass : sObject
  {
    private double? apiVersionField;
    private bool apiVersionFieldSpecified;
    private string bodyField;
    private double? bodyCrcField;
    private bool bodyCrcFieldSpecified;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private bool? isValidField;
    private bool isValidFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private int? lengthWithoutCommentsField;
    private bool lengthWithoutCommentsFieldSpecified;
    private string nameField;
    private string namespacePrefixField;
    private QueryResult setupEntityAccessItemsField;
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;

    [XmlElement(IsNullable = true)]
    public double? ApiVersion
    {
      get => this.apiVersionField;
      set => this.apiVersionField = value;
    }

    [XmlIgnore]
    public bool ApiVersionSpecified
    {
      get => this.apiVersionFieldSpecified;
      set => this.apiVersionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Body
    {
      get => this.bodyField;
      set => this.bodyField = value;
    }

    [XmlElement(IsNullable = true)]
    public double? BodyCrc
    {
      get => this.bodyCrcField;
      set => this.bodyCrcField = value;
    }

    [XmlIgnore]
    public bool BodyCrcSpecified
    {
      get => this.bodyCrcFieldSpecified;
      set => this.bodyCrcFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User CreatedBy
    {
      get => this.createdByField;
      set => this.createdByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CreatedById
    {
      get => this.createdByIdField;
      set => this.createdByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? CreatedDate
    {
      get => this.createdDateField;
      set => this.createdDateField = value;
    }

    [XmlIgnore]
    public bool CreatedDateSpecified
    {
      get => this.createdDateFieldSpecified;
      set => this.createdDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsValid
    {
      get => this.isValidField;
      set => this.isValidField = value;
    }

    [XmlIgnore]
    public bool IsValidSpecified
    {
      get => this.isValidFieldSpecified;
      set => this.isValidFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public User LastModifiedBy
    {
      get => this.lastModifiedByField;
      set => this.lastModifiedByField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LastModifiedById
    {
      get => this.lastModifiedByIdField;
      set => this.lastModifiedByIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? LastModifiedDate
    {
      get => this.lastModifiedDateField;
      set => this.lastModifiedDateField = value;
    }

    [XmlIgnore]
    public bool LastModifiedDateSpecified
    {
      get => this.lastModifiedDateFieldSpecified;
      set => this.lastModifiedDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public int? LengthWithoutComments
    {
      get => this.lengthWithoutCommentsField;
      set => this.lengthWithoutCommentsField = value;
    }

    [XmlIgnore]
    public bool LengthWithoutCommentsSpecified
    {
      get => this.lengthWithoutCommentsFieldSpecified;
      set => this.lengthWithoutCommentsFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
    }

    [XmlElement(IsNullable = true)]
    public QueryResult SetupEntityAccessItems
    {
      get => this.setupEntityAccessItemsField;
      set => this.setupEntityAccessItemsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? SystemModstamp
    {
      get => this.systemModstampField;
      set => this.systemModstampField = value;
    }

    [XmlIgnore]
    public bool SystemModstampSpecified
    {
      get => this.systemModstampFieldSpecified;
      set => this.systemModstampFieldSpecified = value;
    }
  }
}
