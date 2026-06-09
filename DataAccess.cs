// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.DataAccess
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;

#nullable disable
namespace ProjectSubmissionsSvcLib
{
  public class DataAccess
  {
    private const string lockString = "lock";
    protected string connectionString;

    public DataAccess(string connectionString) => this.connectionString = connectionString;

    public DataSet getData(string sql)
    {
      DataSet dataSet = (DataSet) null;
      OracleConnection oracleConnection = (OracleConnection) null;
      OracleDataAdapter oraAdaptor = (OracleDataAdapter) null;
      lock ("lock")
      {
        try
        {
          oracleConnection = new OracleConnection(this.connectionString);
          oracleConnection.Open();
          oraAdaptor = new OracleDataAdapter(sql, oracleConnection);
          dataSet = new DataSet();
          oraAdaptor.Fill(dataSet);
          oracleConnection.Close();
        }
        catch (Exception ex)
        {
          Logger.WriteLog(Logger.LogLevel.DEBUG, "getDataSql: " + sql);
          throw;
        }
        finally
        {
          this.close(oraAdaptor, oracleConnection);
        }
      }
      return dataSet;
    }

    public int insertData(string insertStatement)
    {
      OracleConnection connection = (OracleConnection) null;
      OracleCommand oracleCommand = (OracleCommand) null;
      int num = 0;
      try
      {
        connection = new OracleConnection(this.connectionString);
        connection.Open();
        num = new OracleCommand(insertStatement, connection).ExecuteNonQuery();
        connection.Close();
      }
      catch (Exception ex)
      {
        Logger.WriteLog(Logger.LogLevel.DEBUG, "insertSql: " + insertStatement);
        num = -1;
        throw;
      }
      finally
      {
        connection?.Close();
        oracleCommand = (OracleCommand) null;
      }
      return num;
    }

    public int Insert(string tableName, Hashtable dataHash)
    {
      OracleConnection oracleConnection = (OracleConnection) null;
      OracleCommand oracleCommand1 = (OracleCommand) null;
      int num = -1;
      StringBuilder stringBuilder1 = (StringBuilder) null;
      List<string> stringList1 = (List<string>) null;
      List<string> stringList2 = (List<string>) null;
      try
      {
        if (dataHash == null || dataHash.Count <= 0)
          throw new Exception("Received a Null dataHash object");
        oracleConnection = new OracleConnection(this.connectionString);
        OracleCommand oracleCommand2 = new OracleCommand();
        StringBuilder stringBuilder2 = new StringBuilder();
        stringBuilder2.Append("INSERT INTO ").Append(tableName).Append("(");
        List<string> stringList3 = new List<string>();
        List<string> stringList4 = new List<string>();
        string[] array = new string[6]
        {
          "Prime_Request",
          "Sub_Project_Request",
          "Netbuild_Get_Request",
          "Netbuild_Get_Response",
          "NetBuild_Create_Request",
          "NetBuild_Create_Response"
        };
        foreach (object key in (IEnumerable) dataHash.Keys)
        {
          stringList3.Add(key.ToString());
          stringList4.Add(":" + key.ToString());
          OracleParameter oracleParameter = new OracleParameter(key.ToString(), dataHash[key]);
          if (Array.IndexOf<string>(array, key.ToString()) > -1)
            oracleParameter.OracleType = OracleType.Clob;
          else if (key.Equals((object) "Timestamp"))
            oracleParameter.OracleType = OracleType.DateTime;
          oracleCommand2.Parameters.Add(oracleParameter);
        }
        stringBuilder2.Append(string.Join(",", stringList3.ToArray())).Append(") VALUES(");
        stringBuilder2.Append(string.Join(",", stringList4.ToArray())).Append(")");
        string str = stringBuilder2.ToString();
        oracleConnection.Open();
        oracleCommand2.Connection = oracleConnection;
        oracleCommand2.CommandType = CommandType.Text;
        oracleCommand2.CommandText = str;
        num = oracleCommand2.ExecuteNonQuery();
        oracleConnection.Close();
      }
      catch (Exception ex)
      {
        num = -1;
        throw;
      }
      finally
      {
        oracleConnection?.Close();
        oracleCommand1 = (OracleCommand) null;
        stringBuilder1 = (StringBuilder) null;
        stringList1 = (List<string>) null;
        stringList2 = (List<string>) null;
      }
      return num;
    }

    public int updateData(string sql)
    {
      OracleConnection connection = (OracleConnection) null;
      lock ("lock")
      {
        OracleCommand oracleCommand = (OracleCommand) null;
        try
        {
          connection = new OracleConnection(this.connectionString);
          connection.Open();
          return new OracleCommand(sql, connection).ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          Logger.WriteLog(Logger.LogLevel.DEBUG, "updateSql: " + sql);
          throw;
        }
        finally
        {
          connection?.Close();
          oracleCommand = (OracleCommand) null;
        }
      }
    }

    public int deleteData(string sql)
    {
      OracleConnection connection = (OracleConnection) null;
      lock ("lock")
      {
        OracleCommand oracleCommand = (OracleCommand) null;
        try
        {
          connection = new OracleConnection(this.connectionString);
          connection.Open();
          return new OracleCommand(sql, connection).ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          Logger.WriteLog(Logger.LogLevel.DEBUG, "deleteSql: " + sql);
          throw;
        }
        finally
        {
          connection?.Close();
          oracleCommand = (OracleCommand) null;
        }
      }
    }

    protected void close(
      OracleCommand oraCommand,
      OracleDataAdapter oraAdaptor,
      OracleConnection oraConnection)
    {
      this.close(oraCommand);
      this.close(oraAdaptor);
      this.close(oraConnection);
    }

    protected void close(OracleDataAdapter oraAdaptor, OracleConnection oraConnection)
    {
      this.close(oraAdaptor);
      this.close(oraConnection);
    }

    protected void close(OracleCommand oraCommand)
    {
      oraCommand?.Dispose();
      oraCommand = (OracleCommand) null;
    }

    protected void close(OracleDataAdapter oraAdaptor)
    {
      oraAdaptor?.Dispose();
      oraAdaptor = (OracleDataAdapter) null;
    }

    protected void close(OracleConnection oraConnection)
    {
      try
      {
        if (oraConnection == null)
          return;
        if (oraConnection.State != ConnectionState.Closed)
          oraConnection.Close();
        oraConnection.Dispose();
      }
      finally
      {
        oraConnection = (OracleConnection) null;
      }
    }
  }
}
