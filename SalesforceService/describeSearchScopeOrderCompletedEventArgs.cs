// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.describeSearchScopeOrderCompletedEventArgs
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
  [GeneratedCode("System.Web.Services", "4.6.1099.0")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class describeSearchScopeOrderCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal describeSearchScopeOrderCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DescribeSearchScopeOrderResult[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DescribeSearchScopeOrderResult[]) this.results[0];
      }
    }
  }
}
