// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.Properties.Settings
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace ProjectSubmissionsSvcLib.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default => Settings.defaultInstance;

    [DebuggerNonUserCode]
    [DefaultSettingValue("https://test.salesforce.com/services/Soap/c/39.0/0DFg00000004D81")]
    [ApplicationScopedSetting]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    public string ProjectSubmissionsSvcLib_SalesforceService_SforceService
    {
      get => (string) this[nameof (ProjectSubmissionsSvcLib_SalesforceService_SforceService)];
    }
  }
}
