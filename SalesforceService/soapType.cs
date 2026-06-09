// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.soapType
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
  public enum soapType
  {
    [XmlEnum("tns:ID")] tnsID,
    [XmlEnum("xsd:base64Binary")] xsdbase64Binary,
    [XmlEnum("xsd:boolean")] xsdboolean,
    [XmlEnum("xsd:double")] xsddouble,
    [XmlEnum("xsd:int")] xsdint,
    [XmlEnum("xsd:string")] xsdstring,
    [XmlEnum("xsd:date")] xsddate,
    [XmlEnum("xsd:dateTime")] xsddateTime,
    [XmlEnum("xsd:time")] xsdtime,
    [XmlEnum("tns:location")] tnslocation,
    [XmlEnum("tns:address")] tnsaddress,
    [XmlEnum("xsd:anyType")] xsdanyType,
    [XmlEnum("urn:RelationshipReferenceTo")] urnRelationshipReferenceTo,
    [XmlEnum("urn:JunctionIdListNames")] urnJunctionIdListNames,
    [XmlEnum("urn:SearchLayoutFieldsDisplayed")] urnSearchLayoutFieldsDisplayed,
    [XmlEnum("urn:SearchLayoutField")] urnSearchLayoutField,
    [XmlEnum("urn:SearchLayoutButtonsDisplayed")] urnSearchLayoutButtonsDisplayed,
    [XmlEnum("urn:SearchLayoutButton")] urnSearchLayoutButton,
    [XmlEnum("urn:RecordTypesSupported")] urnRecordTypesSupported,
  }
}
