// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.Project
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib.NetBuildOrderService
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DesignerCategory("code")]
  [XmlInclude(typeof (NetworkProject))]
  [XmlType(Namespace = "http://level3/service/order/network/api_v1_0")]
  [Serializable]
  public class Project : INotifyPropertyChanged
  {
    private string programNameField;
    private string projectNameField;
    private string projectTypeField;
    private string projectSubTypeField;
    private string projectScopeField;
    private string projectIdentifierField;
    private DateTime projectInitiationDateField;
    private bool projectInitiationDateFieldSpecified;
    private DateTime projectDueDateField;
    private bool projectDueDateFieldSpecified;
    private string projectCommentsField;
    private Contact[] projectContactsField;
    private ProjectBid projectBidField;
    private ProjectPermit projectPermittingField;
    private ProjectProcurement projectProcurementField;
    private ProjectAccounting projectAccountingField;

    [XmlElement(Order = 0)]
    public string programName
    {
      get => this.programNameField;
      set
      {
        this.programNameField = value;
        this.RaisePropertyChanged(nameof (programName));
      }
    }

    [XmlElement(Order = 1)]
    public string projectName
    {
      get => this.projectNameField;
      set
      {
        this.projectNameField = value;
        this.RaisePropertyChanged(nameof (projectName));
      }
    }

    [XmlElement(Order = 2)]
    public string projectType
    {
      get => this.projectTypeField;
      set
      {
        this.projectTypeField = value;
        this.RaisePropertyChanged(nameof (projectType));
      }
    }

    [XmlElement(Order = 3)]
    public string projectSubType
    {
      get => this.projectSubTypeField;
      set
      {
        this.projectSubTypeField = value;
        this.RaisePropertyChanged(nameof (projectSubType));
      }
    }

    [XmlElement(Order = 4)]
    public string projectScope
    {
      get => this.projectScopeField;
      set
      {
        this.projectScopeField = value;
        this.RaisePropertyChanged(nameof (projectScope));
      }
    }

    [XmlElement(Order = 5)]
    public string projectIdentifier
    {
      get => this.projectIdentifierField;
      set
      {
        this.projectIdentifierField = value;
        this.RaisePropertyChanged(nameof (projectIdentifier));
      }
    }

    [XmlElement(DataType = "date", Order = 6)]
    public DateTime projectInitiationDate
    {
      get => this.projectInitiationDateField;
      set
      {
        this.projectInitiationDateField = value;
        this.RaisePropertyChanged(nameof (projectInitiationDate));
      }
    }

    [XmlIgnore]
    public bool projectInitiationDateSpecified
    {
      get => this.projectInitiationDateFieldSpecified;
      set
      {
        this.projectInitiationDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (projectInitiationDateSpecified));
      }
    }

    [XmlElement(Order = 7)]
    public DateTime projectDueDate
    {
      get => this.projectDueDateField;
      set
      {
        this.projectDueDateField = value;
        this.RaisePropertyChanged(nameof (projectDueDate));
      }
    }

    [XmlIgnore]
    public bool projectDueDateSpecified
    {
      get => this.projectDueDateFieldSpecified;
      set
      {
        this.projectDueDateFieldSpecified = value;
        this.RaisePropertyChanged(nameof (projectDueDateSpecified));
      }
    }

    [XmlElement(Order = 8)]
    public string projectComments
    {
      get => this.projectCommentsField;
      set
      {
        this.projectCommentsField = value;
        this.RaisePropertyChanged(nameof (projectComments));
      }
    }

    [XmlArrayItem("contact", IsNullable = false)]
    [XmlArray(Order = 9)]
    public Contact[] projectContacts
    {
      get => this.projectContactsField;
      set
      {
        this.projectContactsField = value;
        this.RaisePropertyChanged(nameof (projectContacts));
      }
    }

    [XmlElement(Order = 10)]
    public ProjectBid projectBid
    {
      get => this.projectBidField;
      set
      {
        this.projectBidField = value;
        this.RaisePropertyChanged(nameof (projectBid));
      }
    }

    [XmlElement(Order = 11)]
    public ProjectPermit projectPermitting
    {
      get => this.projectPermittingField;
      set
      {
        this.projectPermittingField = value;
        this.RaisePropertyChanged(nameof (projectPermitting));
      }
    }

    [XmlElement(Order = 12)]
    public ProjectProcurement projectProcurement
    {
      get => this.projectProcurementField;
      set
      {
        this.projectProcurementField = value;
        this.RaisePropertyChanged(nameof (projectProcurement));
      }
    }

    [XmlElement(Order = 13)]
    public ProjectAccounting projectAccounting
    {
      get => this.projectAccountingField;
      set
      {
        this.projectAccountingField = value;
        this.RaisePropertyChanged(nameof (projectAccounting));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
