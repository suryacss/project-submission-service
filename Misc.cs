// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.Misc
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public class Misc
  {
    private const string file_lock = "file_lock";

    public static void Email(string subject, string body)
    {
      LddiClient_4_0.Configuration.Load("ToAddr");
      string toAddr = ConfigurationManager.AppSettings.Get("ToAddr");
      Misc.Email(subject, body, toAddr);
    }

    public static void Email(string subject, string body, string toAddr)
    {
      string from = ConfigurationManager.AppSettings.Get("FromAddr");
      LddiClient_4_0.Configuration.Load("SmtpHost");
      string host = ConfigurationManager.AppSettings.Get("SmtpHost");
      if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(toAddr) || string.IsNullOrEmpty(host))
        return;
      subject = subject + " (Server=" + Dns.GetHostName() + ")";
      SmtpClient smtpClient = (SmtpClient) null;
      try
      {
        new SmtpClient(host).Send(from, toAddr, subject, body);
      }
      catch (Exception ex)
      {
        Logger.WriteLog(Logger.LogLevel.INFO, "Exception Message => " + ex.Message);
        Logger.WriteLog(Logger.LogLevel.INFO, "Exception StackTrace => " + ex.StackTrace);
      }
      finally
      {
        smtpClient = (SmtpClient) null;
      }
    }

    public static void save2File(string logDir, string filePrefix, string content)
    {
      TextWriter textWriter = (TextWriter) null;
      lock ("file_lock")
      {
        try
        {
          if (!Directory.Exists(logDir))
            Directory.CreateDirectory(logDir);
          textWriter = (TextWriter) new StreamWriter(logDir + "\\" + filePrefix + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss_ffff") + ".xml");
          if (!string.IsNullOrEmpty(content))
            textWriter.WriteLine(content);
          textWriter.Close();
          textWriter.Dispose();
          textWriter = (TextWriter) null;
        }
        catch (Exception ex)
        {
          Logger.WriteLog(Logger.LogLevel.INFO, "Exception Message => " + ex.Message);
          Logger.WriteLog(Logger.LogLevel.INFO, "Exception StackTrace => " + ex.StackTrace);
        }
        finally
        {
          textWriter?.Dispose();
        }
      }
    }

    public static string getSerializeData(object obj)
    {
      XmlSerializer xmlSerializer1 = (XmlSerializer) null;
      StringBuilder stringBuilder = (StringBuilder) null;
      StringWriter stringWriter1 = (StringWriter) null;
      try
      {
        XmlSerializer xmlSerializer2 = new XmlSerializer(obj.GetType());
        StringWriter stringWriter2 = new StringWriter(new StringBuilder());
        xmlSerializer2.Serialize((TextWriter) stringWriter2, obj);
        return stringWriter2.ToString();
      }
      finally
      {
        stringWriter1 = (StringWriter) null;
        stringBuilder = (StringBuilder) null;
        xmlSerializer1 = (XmlSerializer) null;
      }
    }

    public static object getDeserializeData(string xml, Type t)
    {
      object deserializeData = (object) null;
      XmlDocument xmlDocument1 = (XmlDocument) null;
      XmlNodeReader xmlNodeReader1 = (XmlNodeReader) null;
      XmlSerializer xmlSerializer = (XmlSerializer) null;
      try
      {
        XmlDocument xmlDocument2 = new XmlDocument();
        xmlDocument2.LoadXml(xml);
        if (xmlDocument2.DocumentElement != null)
        {
          XmlNodeReader xmlNodeReader2 = new XmlNodeReader((XmlNode) xmlDocument2.DocumentElement);
          deserializeData = new XmlSerializer(t).Deserialize((XmlReader) xmlNodeReader2);
        }
      }
      finally
      {
        xmlSerializer = (XmlSerializer) null;
        xmlNodeReader1 = (XmlNodeReader) null;
        xmlDocument1 = (XmlDocument) null;
      }
      return deserializeData;
    }

    public static string getXmlWithNoNameSpaceAndHeader(string xmlString)
    {
      return Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(xmlString, "\\s+xmlns[^=]*=\"[^\"]*\"", "", RegexOptions.Multiline), "<\\?xml[^>]*\\?>", "", RegexOptions.Multiline), "<[a-zA-Z0-9]*:", "<", RegexOptions.Multiline), "</[a-zA-Z0-9]*:", "</", RegexOptions.Multiline), "\\s+xsi[^=]*=\"[^\"]*\"", "", RegexOptions.Multiline);
    }

    public static string substring(string s, int len)
    {
      string str = (string) null;
      if (s != null)
        str = s.Length > len ? s.Substring(0, len) : s;
      return str;
    }

    public static DateTime? getDateTimeFromAsrDate(string asrDate)
    {
      DateTime? dateTimeFromAsrDate = new DateTime?();
      try
      {
        if (asrDate != null)
        {
          if (asrDate.Length == 8 && Regex.IsMatch(asrDate, "^[0-9]+$"))
            dateTimeFromAsrDate = new DateTime?(DateTime.ParseExact(asrDate, "yyyyMMdd", (IFormatProvider) null));
          else if (asrDate.Length == 6 && Regex.IsMatch(asrDate, "^[0-9]+$"))
            dateTimeFromAsrDate = new DateTime?(DateTime.ParseExact(asrDate, "MMddyy", (IFormatProvider) null));
          else if (Regex.IsMatch(asrDate, "^([0-9]{1,2})[/-]{1}([0-9]{1,2})[/-]{1}([0-9]{2}|[0-9]{4})$"))
          {
            string[] strArray = asrDate.Split('-', '/');
            if (strArray.Length == 3)
            {
              if (strArray[0].Length == 1)
                strArray[0] = '0'.ToString() + strArray[0];
              if (strArray[1].Length == 1)
                strArray[1] = '0'.ToString() + strArray[1];
              dateTimeFromAsrDate = Misc.getDateTimeFromAsrDate(strArray[2].Length == 2 ? string.Format("{0}{1}{2}", (object) strArray[0], (object) strArray[1], (object) strArray[2]) : string.Format("{0}{1}{2}", (object) strArray[2], (object) strArray[0], (object) strArray[1]));
            }
          }
        }
      }
      catch (Exception ex)
      {
        dateTimeFromAsrDate = new DateTime?();
      }
      return dateTimeFromAsrDate;
    }
  }
}
