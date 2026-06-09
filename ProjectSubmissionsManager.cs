// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.ProjectSubmissionsManager
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public class ProjectSubmissionsManager : MQManagerThread
  {
    private string logDir;
    private string dbConnectionString;
    private string processName;

    public ProjectSubmissionsManager(
      string mgrThreadName,
      string queuePath,
      int numOfWorkerThread,
      string mgrPriority,
      string workerPriority,
      string logDir,
      string dbConnectionString,
      string processName)
      : base(mgrThreadName, queuePath, numOfWorkerThread, mgrPriority, workerPriority)
    {
      this.logDir = logDir;
      this.dbConnectionString = dbConnectionString;
      this.processName = processName;
    }

    public override MQWorkerThread getMQWorkerThread(string queuePath, long msgLookUpId, string id)
    {
      return (MQWorkerThread) new ProjectSubmissionsWorker(queuePath, msgLookUpId, id, this.logDir, this.dbConnectionString, this.processName);
    }
  }
}
