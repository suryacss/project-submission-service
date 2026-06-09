// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.UserAppMenuItem
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
  public class UserAppMenuItem : sObject
  {
    private string appMenuItemIdField;
    private string applicationIdField;
    private string descriptionField;
    private string iconUrlField;
    private string infoUrlField;
    private bool? isUsingAdminAuthorizationField;
    private bool isUsingAdminAuthorizationFieldSpecified;
    private bool? isVisibleField;
    private bool isVisibleFieldSpecified;
    private string labelField;
    private string logoUrlField;
    private string mobileStartUrlField;
    private string nameField;
    private int? sortOrderField;
    private bool sortOrderFieldSpecified;
    private string startUrlField;
    private string typeField;
    private int? userSortOrderField;
    private bool userSortOrderFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string AppMenuItemId
    {
      get => this.appMenuItemIdField;
      set => this.appMenuItemIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ApplicationId
    {
      get => this.applicationIdField;
      set => this.applicationIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string IconUrl
    {
      get => this.iconUrlField;
      set => this.iconUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string InfoUrl
    {
      get => this.infoUrlField;
      set => this.infoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsUsingAdminAuthorization
    {
      get => this.isUsingAdminAuthorizationField;
      set => this.isUsingAdminAuthorizationField = value;
    }

    [XmlIgnore]
    public bool IsUsingAdminAuthorizationSpecified
    {
      get => this.isUsingAdminAuthorizationFieldSpecified;
      set => this.isUsingAdminAuthorizationFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsVisible
    {
      get => this.isVisibleField;
      set => this.isVisibleField = value;
    }

    [XmlIgnore]
    public bool IsVisibleSpecified
    {
      get => this.isVisibleFieldSpecified;
      set => this.isVisibleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    [XmlElement(IsNullable = true)]
    public string LogoUrl
    {
      get => this.logoUrlField;
      set => this.logoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobileStartUrl
    {
      get => this.mobileStartUrlField;
      set => this.mobileStartUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? SortOrder
    {
      get => this.sortOrderField;
      set => this.sortOrderField = value;
    }

    [XmlIgnore]
    public bool SortOrderSpecified
    {
      get => this.sortOrderFieldSpecified;
      set => this.sortOrderFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string StartUrl
    {
      get => this.startUrlField;
      set => this.startUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string Type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    [XmlElement(IsNullable = true)]
    public int? UserSortOrder
    {
      get => this.userSortOrderField;
      set => this.userSortOrderField = value;
    }

    [XmlIgnore]
    public bool UserSortOrderSpecified
    {
      get => this.userSortOrderFieldSpecified;
      set => this.userSortOrderFieldSpecified = value;
    }
  }
}
