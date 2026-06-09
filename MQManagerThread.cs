// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.MQManagerThread
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Threading;

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public abstract class MQManagerThread
  {
    public static string lockString = "lock";
    private static int maxSequenceNumber = 1;
    private static ArrayList arrListOfAvailableNumber = new ArrayList();
    private static ArrayList arrListOfUsedNumber = new ArrayList();
    private MessageQueue messageQueue;
    private int numOfWorkerThread;
    private Thread thread;
    private ThreadPriority workerPriority;
    private string queuePath;

    protected MQManagerThread(
      string mgrThreadName,
      string queuePath,
      int numOfWorkerThread,
      string mgrPriority,
      string workerPriority)
    {
      this.queuePath = queuePath;
      this.messageQueue = new MessageQueue(queuePath);
      this.numOfWorkerThread = numOfWorkerThread;
      Thread thread = new Thread(new ThreadStart(this.start));
      this.Thread = thread;
      thread.Priority = MQManagerThread.getThreadPriority(mgrPriority);
      this.workerPriority = MQManagerThread.getThreadPriority(workerPriority);
      thread.Name = mgrThreadName;
      thread.Start();
    }

    ~MQManagerThread()
    {
      if (this.messageQueue != null)
      {
        this.messageQueue.Dispose();
        this.messageQueue = (MessageQueue) null;
      }
      if (this.thread == null)
        return;
      if (!this.thread.IsAlive)
        return;
      try
      {
        this.thread.Abort();
        this.thread = (Thread) null;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);
      }
    }

    private static ThreadPriority getThreadPriority(string priority)
    {
      ThreadPriority threadPriority = ThreadPriority.Normal;
      switch (priority.ToUpper())
      {
        case "ABOVENORMAL":
          threadPriority = ThreadPriority.AboveNormal;
          break;
        case "BELOWNORMAL":
          threadPriority = ThreadPriority.BelowNormal;
          break;
        case "HIGHEST":
          threadPriority = ThreadPriority.Highest;
          break;
        case "LOWEST":
          threadPriority = ThreadPriority.Lowest;
          break;
        case "NORMAL":
          threadPriority = ThreadPriority.Normal;
          break;
      }
      return threadPriority;
    }

    public static int popSequenceNumber()
    {
      int num = 1;
      lock (MQManagerThread.arrListOfAvailableNumber)
      {
        if (MQManagerThread.arrListOfAvailableNumber.Count == 0)
        {
          MQManagerThread.arrListOfAvailableNumber.Add((object) MQManagerThread.maxSequenceNumber);
          ++MQManagerThread.maxSequenceNumber;
        }
        MQManagerThread.arrListOfAvailableNumber.Sort();
        MQManagerThread.arrListOfUsedNumber.Sort();
        num = (int) MQManagerThread.arrListOfAvailableNumber[0];
        MQManagerThread.arrListOfAvailableNumber.Remove((object) num);
        MQManagerThread.arrListOfUsedNumber.Add((object) num);
      }
      return num;
    }

    public static void pushSequenceNumber(int sequenceNumber)
    {
      lock (MQManagerThread.arrListOfAvailableNumber)
      {
        MQManagerThread.arrListOfAvailableNumber.Add((object) sequenceNumber);
        MQManagerThread.arrListOfUsedNumber.Remove((object) sequenceNumber);
      }
    }

    public abstract MQWorkerThread getMQWorkerThread(string queuePath, long msgLookUpId, string id);

    public void start()
    {
      Dictionary<string, MQWorkerThread> dictionary1 = new Dictionary<string, MQWorkerThread>();
      Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
      MessageEnumerator messageEnumerator2 = this.messageQueue.GetMessageEnumerator2();
      TimeSpan timeout = new TimeSpan(0, 0, 0, 0, 50);
label_1:
      lock (MQManagerThread.lockString)
      {
        messageEnumerator2.Reset();
        while (ThreadManager.process())
        {
          if (messageEnumerator2.MoveNext(timeout))
          {
            if (dictionary1.Count < this.numOfWorkerThread)
            {
              System.Messaging.Message current = messageEnumerator2.Current;
              if ((current == null || !dictionary1.ContainsKey(current.Id)) && current != null)
              {
                MQWorkerThread mqWorkerThread = this.getMQWorkerThread(this.queuePath, current.LookupId, current.Id);
                Thread thread = new Thread(new ThreadStart(mqWorkerThread.start));
                mqWorkerThread.Thread = thread;
                dictionary1.Add(current.Id, mqWorkerThread);
                int num = MQManagerThread.popSequenceNumber();
                dictionary2.Add(current.Id, num);
                thread.Name = this.thread.Name + "-" + mqWorkerThread.GetType().Name + "-" + (object) num;
                thread.Priority = this.workerPriority;
                thread.Start();
              }
              current?.Dispose();
            }
            else
              break;
          }
          else
            break;
        }
      }
      if (!ThreadManager.process())
        return;
      int millisecondsTimeout = 500;
      if (dictionary1.Count > 0)
        millisecondsTimeout = 25 * dictionary1.Count;
      try
      {
        Thread.Sleep(millisecondsTimeout);
      }
      catch (Exception ex)
      {
        Logger.WriteLog(Logger.LogLevel.INFO, "Exception.Message => " + ex.Message);
        Logger.WriteLog(Logger.LogLevel.INFO, "Exception.StackTrace => " + ex.StackTrace);
      }
      using (List<string>.Enumerator enumerator = dictionary1.Values.Select(wt => new
      {
        wt = wt,
        t = wt.Thread
      }).Where(_param0 => !_param0.t.IsAlive).Select(_param0 => _param0.wt.ID).ToList<string>().GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          string current = enumerator.Current;
          dictionary1.Remove(current);
          MQManagerThread.pushSequenceNumber(dictionary2[current]);
          dictionary2.Remove(current);
        }
        goto label_1;
      }
    }

    internal Thread Thread
    {
      set => this.thread = value;
      get => this.thread;
    }
  }
}
