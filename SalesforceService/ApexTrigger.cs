// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.ApexTrigger
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [Serializable]
  public class ApexTrigger : sObject
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
    private string statusField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string tableEnumOrIdField;
    private bool? usageAfterDeleteField;
    private bool usageAfterDeleteFieldSpecified;
    private bool? usageAfterInsertField;
    private bool usageAfterInsertFieldSpecified;
    private bool? usageAfterUndeleteField;
    private bool usageAfterUndeleteFieldSpecified;
    private bool? usageAfterUpdateField;
    private bool usageAfterUpdateFieldSpecified;
    private bool? usageBeforeDeleteField;
    private bool usageBeforeDeleteFieldSpecified;
    private bool? usageBeforeInsertField;
    private bool usageBeforeInsertFieldSpecified;
    private bool? usageBeforeUpdateField;
    private bool usageBeforeUpdateFieldSpecified;
    private bool? usageIsBulkField;
    private bool usageIsBulkFieldSpecified;

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

    [XmlElement(IsNullable = true)]
    public string TableEnumOrId
    {
      get => this.tableEnumOrIdField;
      set => this.tableEnumOrIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsageAfterDelete
    {
      get => this.usageAfterDeleteField;
      set => this.usageAfterDeleteField = value;
    }

    [XmlIgnore]
    public bool UsageAfterDeleteSpecified
    {
      get => this.usageAfterDeleteFieldSpecified;
      set => this.usageAfterDeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsageAfterInsert
    {
      get => this.usageAfterInsertField;
      set => this.usageAfterInsertField = value;
    }

    [XmlIgnore]
    public bool UsageAfterInsertSpecified
    {
      get => this.usageAfterInsertFieldSpecified;
      set => this.usageAfterInsertFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsageAfterUndelete
    {
      get => this.usageAfterUndeleteField;
      set => this.usageAfterUndeleteField = value;
    }

    [XmlIgnore]
    public bool UsageAfterUndeleteSpecified
    {
      get => this.usageAfterUndeleteFieldSpecified;
      set => this.usageAfterUndeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsageAfterUpdate
    {
      get => this.usageAfterUpdateField;
      set => this.usageAfterUpdateField = value;
    }

    [XmlIgnore]
    public bool UsageAfterUpdateSpecified
    {
      get => this.usageAfterUpdateFieldSpecified;
      set => this.usageAfterUpdateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsageBeforeDelete
    {
      get => this.usageBeforeDeleteField;
      set => this.usageBeforeDeleteField = value;
    }

    [XmlIgnore]
    public bool UsageBeforeDeleteSpecified
    {
      get => this.usageBeforeDeleteFieldSpecified;
      set => this.usageBeforeDeleteFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsageBeforeInsert
    {
      get => this.usageBeforeInsertField;
      set => this.usageBeforeInsertField = value;
    }

    [XmlIgnore]
    public bool UsageBeforeInsertSpecified
    {
      get => this.usageBeforeInsertFieldSpecified;
      set => this.usageBeforeInsertFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsageBeforeUpdate
    {
      get => this.usageBeforeUpdateField;
      set => this.usageBeforeUpdateField = value;
    }

    [XmlIgnore]
    public bool UsageBeforeUpdateSpecified
    {
      get => this.usageBeforeUpdateFieldSpecified;
      set => this.usageBeforeUpdateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? UsageIsBulk
    {
      get => this.usageIsBulkField;
      set => this.usageIsBulkField = value;
    }

    [XmlIgnore]
    public bool UsageIsBulkSpecified
    {
      get => this.usageIsBulkFieldSpecified;
      set => this.usageIsBulkFieldSpecified = value;
    }
  }
}
