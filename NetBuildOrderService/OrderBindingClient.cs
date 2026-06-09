// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.OrderBindingClient
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

#nullable disable
namespace ProjectSubmissionsSvcLib.NetBuildOrderService
{
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [DebuggerStepThrough]
  public class OrderBindingClient : ClientBase<OrderBinding>, OrderBinding
  {
    public OrderBindingClient()
    {
    }

    public OrderBindingClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public OrderBindingClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public OrderBindingClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public OrderBindingClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    createNetworkOrderResponse1 OrderBinding.createNetworkOrder(createNetworkOrderRequest request)
    {
      return this.Channel.createNetworkOrder(request);
    }

    public createNetworkOrderResponse createNetworkOrder(ProjectSubmissionsSvcLib.NetBuildOrderService.createNetworkOrder createNetworkOrder1)
    {
      return ((OrderBinding) this).createNetworkOrder(new createNetworkOrderRequest()
      {
        createNetworkOrder = createNetworkOrder1
      }).createNetworkOrderResponse;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    getNetworkOrderResponse1 OrderBinding.getNetworkOrder(getNetworkOrderRequest request)
    {
      return this.Channel.getNetworkOrder(request);
    }

    public getNetworkOrderResponse getNetworkOrder(ProjectSubmissionsSvcLib.NetBuildOrderService.getNetworkOrder getNetworkOrder1)
    {
      return ((OrderBinding) this).getNetworkOrder(new getNetworkOrderRequest()
      {
        getNetworkOrder = getNetworkOrder1
      }).getNetworkOrderResponse;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    getNetworkOrderShellResponse1 OrderBinding.getNetworkOrderShell(
      getNetworkOrderShellRequest request)
    {
      return this.Channel.getNetworkOrderShell(request);
    }

    public getNetworkOrderShellResponse getNetworkOrderShell(
      ProjectSubmissionsSvcLib.NetBuildOrderService.getNetworkOrderShell getNetworkOrderShell1)
    {
      return ((OrderBinding) this).getNetworkOrderShell(new getNetworkOrderShellRequest()
      {
        getNetworkOrderShell = getNetworkOrderShell1
      }).getNetworkOrderShellResponse;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    getMaterialReplenishmentOrderResponse1 OrderBinding.getMaterialReplenishmentOrder(
      getMaterialReplenishmentOrderRequest request)
    {
      return this.Channel.getMaterialReplenishmentOrder(request);
    }

    public getMaterialReplenishmentOrderResponse getMaterialReplenishmentOrder(
      ProjectSubmissionsSvcLib.NetBuildOrderService.getMaterialReplenishmentOrder getMaterialReplenishmentOrder1)
    {
      return ((OrderBinding) this).getMaterialReplenishmentOrder(new getMaterialReplenishmentOrderRequest()
      {
        getMaterialReplenishmentOrder = getMaterialReplenishmentOrder1
      }).getMaterialReplenishmentOrderResponse;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    getSiteSurveyOrderResponse1 OrderBinding.getSiteSurveyOrder(getSiteSurveyOrderRequest request)
    {
      return this.Channel.getSiteSurveyOrder(request);
    }

    public getSiteSurveyOrderResponse getSiteSurveyOrder(ProjectSubmissionsSvcLib.NetBuildOrderService.getSiteSurveyOrder getSiteSurveyOrder1)
    {
      return ((OrderBinding) this).getSiteSurveyOrder(new getSiteSurveyOrderRequest()
      {
        getSiteSurveyOrder = getSiteSurveyOrder1
      }).getSiteSurveyOrderResponse;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    getNetworkOrderItemResponse1 OrderBinding.getNetworkOrderItem(getNetworkOrderItemRequest request)
    {
      return this.Channel.getNetworkOrderItem(request);
    }

    public getNetworkOrderItemResponse getNetworkOrderItem(ProjectSubmissionsSvcLib.NetBuildOrderService.getNetworkOrderItem getNetworkOrderItem1)
    {
      return ((OrderBinding) this).getNetworkOrderItem(new getNetworkOrderItemRequest()
      {
        getNetworkOrderItem = getNetworkOrderItem1
      }).getNetworkOrderItemResponse;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    findNetworkOrderItemResponse1 OrderBinding.findNetworkOrderItem(
      findNetworkOrderItemRequest request)
    {
      return this.Channel.findNetworkOrderItem(request);
    }

    public findNetworkOrderItemResponse findNetworkOrderItem(
      ProjectSubmissionsSvcLib.NetBuildOrderService.findNetworkOrderItem findNetworkOrderItem1)
    {
      return ((OrderBinding) this).findNetworkOrderItem(new findNetworkOrderItemRequest()
      {
        findNetworkOrderItem = findNetworkOrderItem1
      }).findNetworkOrderItemResponse;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    getNetworkOrderItemsResponse1 OrderBinding.getNetworkOrderItems(
      getNetworkOrderItemsRequest request)
    {
      return this.Channel.getNetworkOrderItems(request);
    }

    public getNetworkOrderItemsResponse getNetworkOrderItems(
      ProjectSubmissionsSvcLib.NetBuildOrderService.getNetworkOrderItems getNetworkOrderItems1)
    {
      return ((OrderBinding) this).getNetworkOrderItems(new getNetworkOrderItemsRequest()
      {
        getNetworkOrderItems = getNetworkOrderItems1
      }).getNetworkOrderItemsResponse;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    getNetworkOrderItemComponentResponse1 OrderBinding.getNetworkOrderItemComponent(
      getNetworkOrderItemComponentRequest request)
    {
      return this.Channel.getNetworkOrderItemComponent(request);
    }

    public getNetworkOrderItemComponentResponse getNetworkOrderItemComponent(
      ProjectSubmissionsSvcLib.NetBuildOrderService.getNetworkOrderItemComponent getNetworkOrderItemComponent1)
    {
      return ((OrderBinding) this).getNetworkOrderItemComponent(new getNetworkOrderItemComponentRequest()
      {
        getNetworkOrderItemComponent = getNetworkOrderItemComponent1
      }).getNetworkOrderItemComponentResponse;
    }
  }
}
