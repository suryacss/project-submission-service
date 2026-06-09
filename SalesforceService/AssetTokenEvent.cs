// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.AssetTokenEvent
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
  public class AssetTokenEvent : sObject
  {
    private string actorTokenPayloadField;
    private Asset assetField;
    private string assetIdField;
    private string assetNameField;
    private string assetSerialNumberField;
    private ConnectedApplication connectedAppField;
    private string connectedAppIdField;
    private User createdByField;
    private string createdByIdField;
    private DateTime? createdDateField;
    private bool createdDateFieldSpecified;
    private string deviceIdField;
    private string deviceKeyField;
    private DateTime? expirationField;
    private bool expirationFieldSpecified;
    private string nameField;
    private string replayIdField;
    private User userField;
    private string userIdField;

    [XmlElement(IsNullable = true)]
    public string ActorTokenPayload
    {
      get => this.actorTokenPayloadField;
      set => this.actorTokenPayloadField = value;
    }

    [XmlElement(IsNullable = true)]
    public Asset Asset
    {
      get => this.assetField;
      set => this.assetField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AssetId
    {
      get => this.assetIdField;
      set => this.assetIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AssetName
    {
      get => this.assetNameField;
      set => this.assetNameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string AssetSerialNumber
    {
      get => this.assetSerialNumberField;
      set => this.assetSerialNumberField = value;
    }

    [XmlElement(IsNullable = true)]
    public ConnectedApplication ConnectedApp
    {
      get => this.connectedAppField;
      set => this.connectedAppField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ConnectedAppId
    {
      get => this.connectedAppIdField;
      set => this.connectedAppIdField = value;
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
    public string DeviceId
    {
      get => this.deviceIdField;
      set => this.deviceIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public string DeviceKey
    {
      get => this.deviceKeyField;
      set => this.deviceKeyField = value;
    }

    [XmlElement(IsNullable = true)]
    public DateTime? Expiration
    {
      get => this.expirationField;
      set => this.expirationField = value;
    }

    [XmlIgnore]
    public bool ExpirationSpecified
    {
      get => this.expirationFieldSpecified;
      set => this.expirationFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string Name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [XmlElement(IsNullable = true)]
    public string ReplayId
    {
      get => this.replayIdField;
      set => this.replayIdField = value;
    }

    [XmlElement(IsNullable = true)]
    public User User
    {
      get => this.userField;
      set => this.userField = value;
    }

    [XmlElement(IsNullable = true)]
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }
  }
}
