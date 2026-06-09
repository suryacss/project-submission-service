// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.ThreadManager
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public class ThreadManager
  {
    private const string lockString = "lock";
    private static int errCount;
    private static List<MQManagerThread> listOfMQManager = new List<MQManagerThread>();
    private static bool stopProcessOnConsecutiveError = ConfigurationManager.AppSettings.Get(nameof (stopProcessOnConsecutiveError)).ToUpper().Equals("Y");
    private static int numOfConsecutiveError = int.Parse(ConfigurationManager.AppSettings.Get(nameof (numOfConsecutiveError)));
    private static bool stopProcess;
    private static Thread t;
    private static bool stopProcessRequestDue2ConsecutiveError;

    public ThreadManager()
    {
      ThreadManager.t = new Thread(new ThreadStart(this.start))
      {
        Name = nameof (ThreadManager)
      };
      ThreadManager.t.Start();
    }

    public static void incrementErrorCounter()
    {
      lock ("lock")
      {
        ++ThreadManager.errCount;
        if (ThreadManager.stopProcessOnConsecutiveError && ThreadManager.errCount > ThreadManager.numOfConsecutiveError && !ThreadManager.stopProcess)
        {
          ThreadManager.stopProcess = true;
          ThreadManager.stopProcessRequestDue2ConsecutiveError = true;
          try
          {
            ThreadManager.t.Interrupt();
          }
          catch (Exception ex)
          {
            Logger.WriteLog(Logger.LogLevel.INFO, "Exception.Message => " + ex.Message);
            Logger.WriteLog(Logger.LogLevel.INFO, "Exception.StackTrace => " + ex.StackTrace);
          }
        }
        Logger.WriteLog(Logger.LogLevel.DEBUG, "ThreadManager.errCount => " + (object) ThreadManager.errCount);
      }
    }

    public static void decrementErrorCounter()
    {
      lock ("lock")
      {
        if (ThreadManager.errCount > 0)
          ThreadManager.errCount = 0;
        Logger.WriteLog(Logger.LogLevel.DEBUG, "ThreadManager.errCount => " + (object) ThreadManager.errCount);
      }
    }

    public static void monitorThread(MQManagerThread mqt) => ThreadManager.listOfMQManager.Add(mqt);

    public static bool process() => !ThreadManager.stopProcess;

    public void stop()
    {
      lock ("lock")
      {
        if (ThreadManager.stopProcess)
          return;
        ThreadManager.stopProcess = true;
        try
        {
          ThreadManager.t.Interrupt();
        }
        catch (Exception ex)
        {
          Logger.WriteLog(Logger.LogLevel.INFO, "Exception.Message => " + ex.Message);
          Logger.WriteLog(Logger.LogLevel.INFO, "Exception.StackTrace => " + ex.StackTrace);
        }
      }
    }

    public void start()
    {
      int millisecondsTimeout = 60000;
      while (true)
      {
        try
        {
          Thread.Sleep(millisecondsTimeout);
        }
        catch (Exception ex)
        {
          Logger.WriteLog(Logger.LogLevel.INFO, "Exception.Message => " + ex.Message);
          Logger.WriteLog(Logger.LogLevel.INFO, "Exception.StackTrace => " + ex.StackTrace);
        }
        if (ThreadManager.stopProcess)
        {
          if (ThreadManager.listOfMQManager.Count > 0)
          {
            List<MQManagerThread> mqManagerThreadList = new List<MQManagerThread>();
            foreach (MQManagerThread mqManagerThread in ThreadManager.listOfMQManager)
            {
              if (mqManagerThread.Thread.IsAlive)
              {
                Logger.WriteLog(Logger.LogLevel.INFO, "Request to MQManager " + mqManagerThread.Thread.Name + " to stop");
                try
                {
                  mqManagerThread.Thread.Interrupt();
                }
                catch (Exception ex)
                {
                  Logger.WriteLog(Logger.LogLevel.INFO, "Exception.Message => " + ex.Message);
                  Logger.WriteLog(Logger.LogLevel.INFO, "Exception.StackTrace => " + ex.StackTrace);
                }
              }
              else
              {
                Logger.WriteLog(Logger.LogLevel.INFO, "MQManager " + mqManagerThread.Thread.Name + " is dead");
                mqManagerThreadList.Add(mqManagerThread);
              }
            }
            foreach (MQManagerThread mqManagerThread in mqManagerThreadList)
              ThreadManager.listOfMQManager.Remove(mqManagerThread);
            millisecondsTimeout = 1000;
          }
          else if (ThreadManager.stopProcessRequestDue2ConsecutiveError)
          {
            Misc.Email("Process going to stop in 60 seconds", "Crossed threshold limit of continuous " + (object) ThreadManager.numOfConsecutiveError + " errors");
            try
            {
              Thread.Sleep(60000);
            }
            catch (Exception ex)
            {
              Logger.WriteLog(Logger.LogLevel.INFO, "Exception.Message => " + ex.Message);
              Logger.WriteLog(Logger.LogLevel.INFO, "Exception.StackTrace => " + ex.StackTrace);
            }
            Environment.Exit(1);
          }
          else
            break;
        }
        GC.Collect();
      }
    }
  }
}
