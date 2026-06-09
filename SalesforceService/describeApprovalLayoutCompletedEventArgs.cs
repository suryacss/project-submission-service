// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.describeApprovalLayoutCompletedEventArgs
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

#nullable disable
namespace ProjectSubmissionsSvcLib.SalesforceService
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "4.6.1099.0")]
  [DebuggerStepThrough]
  public class describeApprovalLayoutCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal describeApprovalLayoutCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DescribeApprovalLayout[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DescribeApprovalLayout[]) this.results[0];
      }
    }
  }
}
