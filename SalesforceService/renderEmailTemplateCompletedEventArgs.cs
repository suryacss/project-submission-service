// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.SalesforceService.renderEmailTemplateCompletedEventArgs
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class renderEmailTemplateCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal renderEmailTemplateCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public RenderEmailTemplateResult[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (RenderEmailTemplateResult[]) this.results[0];
      }
    }
  }
}
