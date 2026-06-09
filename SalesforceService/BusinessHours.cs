// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.BusinessHours
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
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class BusinessHours : sObject
  {
    private QueryResult casesField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private DateTime? fridayEndTimeField;
    private bool fridayEndTimeFieldSpecified;
    private DateTime? fridayStartTimeField;
    private bool fridayStartTimeFieldSpecified;
    private bool? isActiveField;
    private bool isActiveFieldSpecified;
    private bool? isDefaultField;
    private bool isDefaultFieldSpecified;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private DateTime? mondayEndTimeField;
    private bool mondayEndTimeFieldSpecified;
    private DateTime? mondayStartTimeField;
    private bool mondayStartTimeFieldSpecified;
    private string nameField;
    private DateTime? saturdayEndTimeField;
    private bool saturdayEndTimeFieldSpecified;
    private DateTime? saturdayStartTimeField;
    private bool saturdayStartTimeFieldSpecified;
    private DateTime? sundayEndTimeField;
    private bool sundayEndTimeFieldSpecified;
    private DateTime? sundayStartTimeField;
    private bool sundayStartTimeFieldSpecified;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private DateTime? thursdayEndTimeField;
    private bool thursdayEndTimeFieldSpecified;
    private DateTime? thursdayStartTimeField;
    private bool thursdayStartTimeFieldSpecified;
    private string timeZoneSidKeyField;
    private DateTime? tuesdayEndTimeField;
    private bool tuesdayEndTimeFieldSpecified;
    private DateTime? tuesdayStartTimeField;
    private bool tuesdayStartTimeFieldSpecified;
    private DateTime? wednesdayEndTimeField;
    private bool wednesdayEndTimeFieldSpecified;
    private DateTime? wednesdayStartTimeField;
    private bool wednesdayStartTimeFieldSpecified;

    [XmlElement(IsNullable = true)]
    public QueryResult Cases
    {
      get => this.casesField;
      set => this.casesField = value;
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

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? FridayEndTime
    {
      get => this.fridayEndTimeField;
      set => this.fridayEndTimeField = value;
    }

    [XmlIgnore]
    public bool FridayEndTimeSpecified
    {
      get => this.fridayEndTimeFieldSpecified;
      set => this.fridayEndTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? FridayStartTime
    {
      get => this.fridayStartTimeField;
      set => this.fridayStartTimeField = value;
    }

    [XmlIgnore]
    public bool FridayStartTimeSpecified
    {
      get => this.fridayStartTimeFieldSpecified;
      set => this.fridayStartTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsActive
    {
      get => this.isActiveField;
      set => this.isActiveField = value;
    }

    [XmlIgnore]
    public bool IsActiveSpecified
    {
      get => this.isActiveFieldSpecified;
      set => this.isActiveFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDefault
    {
      get => this.isDefaultField;
      set => this.isDefaultField = value;
    }

    [XmlIgnore]
    public bool IsDefaultSpecified
    {
      get => this.isDefaultFieldSpecified;
      set => this.isDefaultFieldSpecified = value;
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

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? MondayEndTime
    {
      get => this.mondayEndTimeField;
      set => this.mondayEndTimeField = value;
    }

    [XmlIgnore]
    public bool MondayEndTimeSpecified
    {
      get => this.mondayEndTimeFieldSpecified;
      set => this.mondayEndTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? MondayStartTime
    {
      get => this.mondayStartTimeField;
      set => this.mondayStartTimeField = value;
    }

    [XmlIgnore]
    public bool MondayStartTimeSpecified
    {
      get => this.mondayStartTimeFieldSpecified;
      set => this.mondayStartTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? SaturdayEndTime
    {
      get => this.saturdayEndTimeField;
      set => this.saturdayEndTimeField = value;
    }

    [XmlIgnore]
    public bool SaturdayEndTimeSpecified
    {
      get => this.saturdayEndTimeFieldSpecified;
      set => this.saturdayEndTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? SaturdayStartTime
    {
      get => this.saturdayStartTimeField;
      set => this.saturdayStartTimeField = value;
    }

    [XmlIgnore]
    public bool SaturdayStartTimeSpecified
    {
      get => this.saturdayStartTimeFieldSpecified;
      set => this.saturdayStartTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? SundayEndTime
    {
      get => this.sundayEndTimeField;
      set => this.sundayEndTimeField = value;
    }

    [XmlIgnore]
    public bool SundayEndTimeSpecified
    {
      get => this.sundayEndTimeFieldSpecified;
      set => this.sundayEndTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? SundayStartTime
    {
      get => this.sundayStartTimeField;
      set => this.sundayStartTimeField = value;
    }

    [XmlIgnore]
    public bool SundayStartTimeSpecified
    {
      get => this.sundayStartTimeFieldSpecified;
      set => this.sundayStartTimeFieldSpecified = value;
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

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? ThursdayEndTime
    {
      get => this.thursdayEndTimeField;
      set => this.thursdayEndTimeField = value;
    }

    [XmlIgnore]
    public bool ThursdayEndTimeSpecified
    {
      get => this.thursdayEndTimeFieldSpecified;
      set => this.thursdayEndTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? ThursdayStartTime
    {
      get => this.thursdayStartTimeField;
      set => this.thursdayStartTimeField = value;
    }

    [XmlIgnore]
    public bool ThursdayStartTimeSpecified
    {
      get => this.thursdayStartTimeFieldSpecified;
      set => this.thursdayStartTimeFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string TimeZoneSidKey
    {
      get => this.timeZoneSidKeyField;
      set => this.timeZoneSidKeyField = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? TuesdayEndTime
    {
      get => this.tuesdayEndTimeField;
      set => this.tuesdayEndTimeField = value;
    }

    [XmlIgnore]
    public bool TuesdayEndTimeSpecified
    {
      get => this.tuesdayEndTimeFieldSpecified;
      set => this.tuesdayEndTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? TuesdayStartTime
    {
      get => this.tuesdayStartTimeField;
      set => this.tuesdayStartTimeField = value;
    }

    [XmlIgnore]
    public bool TuesdayStartTimeSpecified
    {
      get => this.tuesdayStartTimeFieldSpecified;
      set => this.tuesdayStartTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? WednesdayEndTime
    {
      get => this.wednesdayEndTimeField;
      set => this.wednesdayEndTimeField = value;
    }

    [XmlIgnore]
    public bool WednesdayEndTimeSpecified
    {
      get => this.wednesdayEndTimeFieldSpecified;
      set => this.wednesdayEndTimeFieldSpecified = value;
    }

    [XmlElement(DataType = "time", IsNullable = true)]
    public DateTime? WednesdayStartTime
    {
      get => this.wednesdayStartTimeField;
      set => this.wednesdayStartTimeField = value;
    }

    [XmlIgnore]
    public bool WednesdayStartTimeSpecified
    {
      get => this.wednesdayStartTimeFieldSpecified;
      set => this.wednesdayStartTimeFieldSpecified = value;
    }
  }
}
