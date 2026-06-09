// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.getSiteSurveyOrderRequest
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

#nullable disable
namespace ProjectSubmissionsSvcLib.NetBuildOrderService
{
  [DebuggerStepThrough]
  [MessageContract(IsWrapped = false)]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public class getSiteSurveyOrderRequest
  {
    [MessageBodyMember(Namespace = "http://level3/service/order/network/api_v1_0", Order = 0)]
    public getSiteSurveyOrder getSiteSurveyOrder;

    public getSiteSurveyOrderRequest()
    {
    }

    public getSiteSurveyOrderRequest(getSiteSurveyOrder getSiteSurveyOrder)
    {
      this.getSiteSurveyOrder = getSiteSurveyOrder;
    }
  }
}
