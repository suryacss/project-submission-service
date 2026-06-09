// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.AppMenuItem
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
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "urn:sobject.enterprise.soap.sforce.com")]
  [Serializable]
  public class AppMenuItem : sObject
  {
    private string applicationIdField;
    private string canvasAccessMethodField;
    private bool? canvasEnabledField;
    private bool canvasEnabledFieldSpecified;
    private string canvasOptionsField;
    private string canvasReferenceIdField;
    private string canvasSelectedLocationsField;
    private string canvasUrlField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string descriptionField;
    private string iconUrlField;
    private string infoUrlField;
    private bool? isAccessibleField;
    private bool isAccessibleFieldSpecified;
    private bool? isDeletedField;
    private bool isDeletedFieldSpecified;
    private bool? isRegisteredDeviceOnlyField;
    private bool isRegisteredDeviceOnlyFieldSpecified;
    private bool? isUsingAdminAuthorizationField;
    private bool isUsingAdminAuthorizationFieldSpecified;
    private bool? isVisibleField;
    private bool isVisibleFieldSpecified;
    private string labelField;
    private User lastModifiedByField;
    private string lastModifiedByIdField;
    private DateTime? lastModifiedDateField;
    private bool lastModifiedDateFieldSpecified;
    private string logoUrlField;
    private string mobileAppBinaryIdField;
    private string mobileAppInstallUrlField;
    private DateTime? mobileAppInstalledDateField;
    private bool mobileAppInstalledDateFieldSpecified;
    private string mobileAppInstalledVersionField;
    private string mobileAppVerField;
    private string mobileDeviceTypeField;
    private string mobileMinOsVerField;
    private string mobilePlatformField;
    private string mobileStartUrlField;
    private string nameField;
    private string namespacePrefixField;
    private int? sortOrderField;
    private bool sortOrderFieldSpecified;
    private string startUrlField;
    private DateTime? systemModstampField;
    private bool systemModstampFieldSpecified;
    private string typeField;
    private int? userSortOrderField;
    private bool userSortOrderFieldSpecified;

    [XmlElement(IsNullable = true)]
    public string ApplicationId
    {
      get => this.applicationIdField;
      set => this.applicationIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CanvasAccessMethod
    {
      get => this.canvasAccessMethodField;
      set => this.canvasAccessMethodField = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? CanvasEnabled
    {
      get => this.canvasEnabledField;
      set => this.canvasEnabledField = value;
    }

    [XmlIgnore]
    public bool CanvasEnabledSpecified
    {
      get => this.canvasEnabledFieldSpecified;
      set => this.canvasEnabledFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string CanvasOptions
    {
      get => this.canvasOptionsField;
      set => this.canvasOptionsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CanvasReferenceId
    {
      get => this.canvasReferenceIdField;
      set => this.canvasReferenceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CanvasSelectedLocations
    {
      get => this.canvasSelectedLocationsField;
      set => this.canvasSelectedLocationsField = value;
    }

    [XmlElement(IsNullable = true)]
    public string CanvasUrl
    {
      get => this.canvasUrlField;
      set => this.canvasUrlField = value;
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
    public bool? IsAccessible
    {
      get => this.isAccessibleField;
      set => this.isAccessibleField = value;
    }

    [XmlIgnore]
    public bool IsAccessibleSpecified
    {
      get => this.isAccessibleFieldSpecified;
      set => this.isAccessibleFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsDeleted
    {
      get => this.isDeletedField;
      set => this.isDeletedField = value;
    }

    [XmlIgnore]
    public bool IsDeletedSpecified
    {
      get => this.isDeletedFieldSpecified;
      set => this.isDeletedFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public bool? IsRegisteredDeviceOnly
    {
      get => this.isRegisteredDeviceOnlyField;
      set => this.isRegisteredDeviceOnlyField = value;
    }

    [XmlIgnore]
    public bool IsRegisteredDeviceOnlySpecified
    {
      get => this.isRegisteredDeviceOnlyFieldSpecified;
      set => this.isRegisteredDeviceOnlyFieldSpecified = value;
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
    public string LogoUrl
    {
      get => this.logoUrlField;
      set => this.logoUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobileAppBinaryId
    {
      get => this.mobileAppBinaryIdField;
      set => this.mobileAppBinaryIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobileAppInstallUrl
    {
      get => this.mobileAppInstallUrlField;
      set => this.mobileAppInstallUrlField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? MobileAppInstalledDate
    {
      get => this.mobileAppInstalledDateField;
      set => this.mobileAppInstalledDateField = value;
    }

    [XmlIgnore]
    public bool MobileAppInstalledDateSpecified
    {
      get => this.mobileAppInstalledDateFieldSpecified;
      set => this.mobileAppInstalledDateFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobileAppInstalledVersion
    {
      get => this.mobileAppInstalledVersionField;
      set => this.mobileAppInstalledVersionField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobileAppVer
    {
      get => this.mobileAppVerField;
      set => this.mobileAppVerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobileDeviceType
    {
      get => this.mobileDeviceTypeField;
      set => this.mobileDeviceTypeField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobileMinOsVer
    {
      get => this.mobileMinOsVerField;
      set => this.mobileMinOsVerField = value;
    }

    [XmlElement(IsNullable = true)]
    public string MobilePlatform
    {
      get => this.mobilePlatformField;
      set => this.mobilePlatformField = value;
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
    public string NamespacePrefix
    {
      get => this.namespacePrefixField;
      set => this.namespacePrefixField = value;
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
