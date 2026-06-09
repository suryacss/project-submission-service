// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.Logger
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public class Logger
  {
    private const string LockString = "lock";
    private static string _logDir;
    private static string _processName;

    public static void SetLogDir(string processName, string logDir)
    {
      Logger._processName = processName;
      if (!Directory.Exists(logDir))
        Directory.CreateDirectory(logDir);
      Logger._logDir = logDir;
    }

    public static void WriteLog(
      Logger.LogLevel logLevel,
      string message,
      string source = null,
      string fileNameSuffix = null)
    {
      if (string.IsNullOrEmpty(source))
      {
        MethodBase method = new StackTrace().GetFrame(1).GetMethod();
        source = Thread.CurrentThread.Name + "." + method.ReflectedType.Name + "." + method.Name;
      }
      Logger.Write2File(DateTime.Now, logLevel, source, message, fileNameSuffix);
    }

    private static void Write2File(
      DateTime dt,
      Logger.LogLevel logLevel,
      string source,
      string message,
      string fileNameSuffix = null)
    {
      TextWriter textWriter = (TextWriter) null;
      lock ("lock")
      {
        try
        {
          string path;
          if (string.IsNullOrEmpty(fileNameSuffix))
            path = Logger._logDir + "\\" + Logger._processName + "_" + DateTime.Now.ToString("yyyyMMdd") + ".log";
          else
            path = Logger._logDir + "\\" + Logger._processName + "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + fileNameSuffix + ".log";
          textWriter = (TextWriter) new StreamWriter(path, true);
          textWriter.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss.ffff") + "\t" + message);
          textWriter.Close();
          textWriter.Dispose();
          textWriter = (TextWriter) null;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
        finally
        {
          textWriter?.Dispose();
        }
      }
    }

    public enum LogLevel
    {
      INFO,
      DEBUG,
    }
  }
}
