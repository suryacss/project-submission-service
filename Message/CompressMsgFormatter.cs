// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.Message.CompressMsgFormatter
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.IO;
using System.IO.Compression;
using System.Messaging;

#nullable disable
namespace ProjectSubmissionsSvcLib.Message
{
  public class CompressMsgFormatter : IMessageFormatter, ICloneable
  {
    private IMessageFormatter m_BaseFormatter;

    public CompressMsgFormatter(IMessageFormatter BaseFormatter)
    {
      this.m_BaseFormatter = BaseFormatter;
    }

    public object Clone()
    {
      return (object) new CompressMsgFormatter((IMessageFormatter) this.m_BaseFormatter.Clone());
    }

    public bool CanRead(System.Messaging.Message message) => message.BodyStream != null;

    public object Read(System.Messaging.Message message)
    {
      byte[] buffer1 = new byte[4];
      message.BodyStream.Read(buffer1, 0, buffer1.Length);
      int int32 = BitConverter.ToInt32(buffer1, 0);
      int length = buffer1.Length;
      long count = message.BodyStream.Length - (long) length;
      byte[] buffer2 = new byte[count];
      message.BodyStream.Read(buffer2, 0, (int) count);
      MemoryStream memoryStream = new MemoryStream(buffer2);
      memoryStream.Position = 0L;
      DeflateStream deflateStream = new DeflateStream((Stream) memoryStream, CompressionMode.Decompress);
      byte[] buffer3 = new byte[int32];
      deflateStream.Read(buffer3, 0, int32);
      System.Messaging.Message message1 = new System.Messaging.Message()
      {
        BodyType = message.BodyType
      };
      message1.BodyStream.Write(buffer3, 0, buffer3.Length);
      message1.BodyStream.Position = 0L;
      return this.m_BaseFormatter.Read(message1);
    }

    public void Write(System.Messaging.Message message, object obj)
    {
      System.Messaging.Message message1 = new System.Messaging.Message();
      this.m_BaseFormatter.Write(message1, obj);
      message.BodyType = message1.BodyType;
      MemoryStream memoryStream = new MemoryStream();
      int int32 = Convert.ToInt32(message1.BodyStream.Length);
      byte[] buffer = new byte[int32];
      message1.BodyStream.Position = 0L;
      message1.BodyStream.Read(buffer, 0, int32);
      memoryStream.Write(BitConverter.GetBytes(buffer.Length), 0, 4);
      DeflateStream deflateStream = new DeflateStream((Stream) memoryStream, CompressionMode.Compress, true);
      deflateStream.Write(buffer, 0, buffer.Length);
      deflateStream.Close();
      memoryStream.Position = 0L;
      message.BodyStream = (Stream) memoryStream;
    }
  }
}
