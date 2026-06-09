// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.fieldType
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib.SalesforceService
{
  [GeneratedCode("System.Xml", "4.7.3221.0")]
  [XmlType(Namespace = "urn:enterprise.soap.sforce.com")]
  [Serializable]
  public enum fieldType
  {
    @string,
    picklist,
    multipicklist,
    combobox,
    reference,
    base64,
    boolean,
    currency,
    textarea,
    @int,
    @double,
    percent,
    phone,
    id,
    date,
    datetime,
    time,
    url,
    email,
    encryptedstring,
    datacategorygroupreference,
    location,
    address,
    anyType,
    complexvalue,
  }
}
