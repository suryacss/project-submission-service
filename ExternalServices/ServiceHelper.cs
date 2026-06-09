// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.ExternalServices.ServiceHelper
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using ProjectSubmissionsSvcLib.NetBuildOrderService;
using ProjectSubmissionsSvcLib.SalesforceService;
using System;
using System.Configuration;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web.Services.Protocols;

#nullable disable
namespace ProjectSubmissionsSvcLib.ExternalServices
{
  public class ServiceHelper
  {
    private static BasicHttpBinding _orderBindingClientBinding;
    private static EndpointAddress _orderBindingClientEndPoint;

    internal static OrderBindingClient GetNetBuildOrderService(bool forceRefresh = false)
    {
      string netBuildUrl = ConfigurationManager.AppSettings["NetBuildOrderServiceURL"];
      bool isHttps = netBuildUrl != null && netBuildUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
      if (isHttps)
      {
        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | (SecurityProtocolType)768 | SecurityProtocolType.Tls;
        ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
      }
      if (ServiceHelper._orderBindingClientBinding == null || forceRefresh)
      {
        BasicHttpBinding basicHttpBinding = new BasicHttpBinding(isHttps ? BasicHttpSecurityMode.Transport : BasicHttpSecurityMode.None);
        basicHttpBinding.MaxReceivedMessageSize = (long) int.MaxValue;
        basicHttpBinding.MaxBufferSize = int.MaxValue;
        basicHttpBinding.ReceiveTimeout = new TimeSpan(0, 5, 0);
        basicHttpBinding.OpenTimeout = new TimeSpan(0, 5, 0);
        basicHttpBinding.CloseTimeout = new TimeSpan(0, 5, 0);
        basicHttpBinding.SendTimeout = new TimeSpan(0, 5, 0);
        ServiceHelper._orderBindingClientBinding = basicHttpBinding;
        ServiceHelper._orderBindingClientEndPoint = new EndpointAddress(new Uri(netBuildUrl), new AddressHeader[0]);
      }
      return new OrderBindingClient((Binding) ServiceHelper._orderBindingClientBinding, ServiceHelper._orderBindingClientEndPoint);
    }

    internal static SforceService GetSalesforceService()
    {
      string appSetting1 = ConfigurationManager.AppSettings["sfdcUserName"];
      string appSetting2 = ConfigurationManager.AppSettings["sfdcPassword"];
      string appSetting3 = ConfigurationManager.AppSettings["sfdcEndpoint"];
      SforceService sforceService = (SforceService) null;
      SforceService salesforceService = new SforceService();
      LoginResult loginResult;
      try
      {
        salesforceService.Url = appSetting3;
        loginResult = salesforceService.login(appSetting1, appSetting2);
      }
      catch (SoapException ex)
      {
        sforceService = (SforceService) null;
        throw;
      }
      catch (Exception ex)
      {
        sforceService = (SforceService) null;
        throw;
      }
      salesforceService.Url = loginResult.serverUrl;
      salesforceService.SessionHeaderValue = new SessionHeader()
      {
        sessionId = loginResult.sessionId
      };
      return salesforceService;
    }
  }
}
