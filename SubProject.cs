// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SubProject
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using ProjectSubmissionsSvcLib.NetBuildOrderService;

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public class SubProject
  {
    public string projectSfdcId { get; set; }

    public string projectIdentifier { get; set; }

    public string subProjectSfdcId { get; set; }

    public string subProjectIdentifier { get; set; }

    public int subPrjSubmissionSequence { get; set; }

    public string subPrjJsonMsg { get; set; }

    public createNetworkOrder subPrjRequest { get; set; }

    public string subProjectGroomsOrderNumber { get; set; }
  }
}
