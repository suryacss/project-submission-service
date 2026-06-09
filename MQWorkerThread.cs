// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.MQWorkerThread
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using ProjectSubmissionsSvcLib.Message;
using System;
using System.Messaging;
using System.Threading;

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public abstract class MQWorkerThread
  {
    public string queuePath;
    private long msgLookUpId;

    protected MQWorkerThread(string queuePath, long msgLookUpId, string id)
    {
      this.queuePath = queuePath;
      this.msgLookUpId = msgLookUpId;
      this.ID = id;
    }

    ~MQWorkerThread()
    {
      this.queuePath = (string) null;
      this.ID = (string) null;
      if (this.Thread == null)
        return;
      if (!this.Thread.IsAlive)
        return;
      try
      {
        this.Thread.Abort();
        this.Thread = (Thread) null;
      }
      catch (Exception ex)
      {
        Logger.WriteLog(Logger.LogLevel.INFO, "Error => " + ex.Message);
        Logger.WriteLog(Logger.LogLevel.INFO, "StackTrace => " + ex.StackTrace);
      }
    }

    public abstract void doActualWork(string msgString);

    internal void start()
    {
      if (!ThreadManager.process())
        return;
      MessageQueue messageQueue = (MessageQueue) null;
      System.Messaging.Message message = (System.Messaging.Message) null;
      string str = (string) null;
      try
      {
        messageQueue = new MessageQueue(this.queuePath)
        {
          Formatter = (IMessageFormatter) new CompressMsgFormatter((IMessageFormatter) new BinaryMessageFormatter())
        };
        message = messageQueue.PeekByLookupId(this.msgLookUpId);
        this.doActualWork(message.Body.ToString());
        lock (MQManagerThread.lockString)
          messageQueue.ReceiveByLookupId(message.LookupId);
      }
      catch (Exception ex)
      {
        Logger.WriteLog(Logger.LogLevel.INFO, "Error => " + ex.Message);
        Logger.WriteLog(Logger.LogLevel.INFO, "StackTrace => " + ex.StackTrace);
        Misc.Email("Fail to process MSMQ Message", "Exception Error => {" + ex.Message + "}\n\nException StackTrace => {" + ex.StackTrace + "}\n\nMSMQ LookUpId => " + (object) this.msgLookUpId + " in queue " + this.queuePath);
        ThreadManager.incrementErrorCounter();
      }
      finally
      {
        message?.Dispose();
        if (messageQueue != null)
        {
          messageQueue.Close();
          messageQueue.Dispose();
        }
        str = (string) null;
      }
    }

    internal Thread Thread { get; set; }

    internal string ID { get; private set; }
  }
}
