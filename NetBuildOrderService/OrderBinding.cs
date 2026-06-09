// Decompiled with JetBrains decompiler
// Type: ProjectSubmissionsSvcLib.NetBuildOrderService.OrderBinding
// Assembly: ProjectSubmissionsSvcLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C49EF5E2-CFE2-4E60-A941-945EBC1CD82F
// Assembly location: C:\Users\AD43784\OneDrive - Lumen\Desktop\ProjectSubmissionsSvcLib.dll

using System.CodeDom.Compiler;
using System.ServiceModel;

#nullable disable
namespace ProjectSubmissionsSvcLib.NetBuildOrderService
{
  [ServiceContract(Namespace = "http://level3/service/order/network/api_v1_0", ConfigurationName = "NetBuildOrderService.OrderBinding")]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  public interface OrderBinding
  {
    [ServiceKnownType(typeof (baseResponse))]
    [OperationContract(Action = "createNetworkOrder_v1_0", ReplyAction = "*")]
    [XmlSerializerFormat(SupportFaults = true)]
    [ServiceKnownType(typeof (Resources))]
    [ServiceKnownType(typeof (NetworkOrderItem))]
    [ServiceKnownType(typeof (Resource))]
    [ServiceKnownType(typeof (Project))]
    [ServiceKnownType(typeof (Order))]
    [ServiceKnownType(typeof (baseRequest))]
    createNetworkOrderResponse1 createNetworkOrder(createNetworkOrderRequest request);

    [ServiceKnownType(typeof (NetworkOrderItem))]
    [ServiceKnownType(typeof (baseResponse))]
    [ServiceKnownType(typeof (Resource))]
    [ServiceKnownType(typeof (baseRequest))]
    [ServiceKnownType(typeof (Resources))]
    [ServiceKnownType(typeof (Project))]
    [ServiceKnownType(typeof (Order))]
    [OperationContract(Action = "getNetworkOrder_v1_0", ReplyAction = "*")]
    [XmlSerializerFormat(SupportFaults = true)]
    getNetworkOrderResponse1 getNetworkOrder(getNetworkOrderRequest request);

    [ServiceKnownType(typeof (baseRequest))]
    [ServiceKnownType(typeof (NetworkOrderItem))]
    [ServiceKnownType(typeof (Project))]
    [ServiceKnownType(typeof (Order))]
    [OperationContract(Action = "getNetworkOrderShell_v1_0", ReplyAction = "*")]
    [XmlSerializerFormat(SupportFaults = true)]
    [ServiceKnownType(typeof (Resources))]
    [ServiceKnownType(typeof (baseResponse))]
    [ServiceKnownType(typeof (Resource))]
    getNetworkOrderShellResponse1 getNetworkOrderShell(getNetworkOrderShellRequest request);

    [ServiceKnownType(typeof (Project))]
    [ServiceKnownType(typeof (Order))]
    [ServiceKnownType(typeof (baseResponse))]
    [ServiceKnownType(typeof (Resource))]
    [ServiceKnownType(typeof (NetworkOrderItem))]
    [OperationContract(Action = "getMaterialReplenishmentOrder_v1_0", ReplyAction = "*")]
    [ServiceKnownType(typeof (baseRequest))]
    [XmlSerializerFormat(SupportFaults = true)]
    [ServiceKnownType(typeof (Resources))]
    getMaterialReplenishmentOrderResponse1 getMaterialReplenishmentOrder(
      getMaterialReplenishmentOrderRequest request);

    [ServiceKnownType(typeof (Resource))]
    [ServiceKnownType(typeof (baseResponse))]
    [ServiceKnownType(typeof (baseRequest))]
    [OperationContract(Action = "getSiteSurveyOrder_v1_0", ReplyAction = "*")]
    [ServiceKnownType(typeof (NetworkOrderItem))]
    [XmlSerializerFormat(SupportFaults = true)]
    [ServiceKnownType(typeof (Resources))]
    [ServiceKnownType(typeof (Project))]
    [ServiceKnownType(typeof (Order))]
    getSiteSurveyOrderResponse1 getSiteSurveyOrder(getSiteSurveyOrderRequest request);

    [ServiceKnownType(typeof (Resource))]
    [ServiceKnownType(typeof (baseRequest))]
    [ServiceKnownType(typeof (NetworkOrderItem))]
    [ServiceKnownType(typeof (Project))]
    [ServiceKnownType(typeof (Order))]
    [XmlSerializerFormat(SupportFaults = true)]
    [ServiceKnownType(typeof (Resources))]
    [ServiceKnownType(typeof (baseResponse))]
    [OperationContract(Action = "getNetworkOrderItem_v1_0", ReplyAction = "*")]
    getNetworkOrderItemResponse1 getNetworkOrderItem(getNetworkOrderItemRequest request);

    [ServiceKnownType(typeof (baseResponse))]
    [ServiceKnownType(typeof (Resources))]
    [ServiceKnownType(typeof (Project))]
    [ServiceKnownType(typeof (Order))]
    [ServiceKnownType(typeof (baseRequest))]
    [XmlSerializerFormat(SupportFaults = true)]
    [OperationContract(Action = "findNetworkOrderItem_v1_0", ReplyAction = "*")]
    [ServiceKnownType(typeof (Resource))]
    [ServiceKnownType(typeof (NetworkOrderItem))]
    findNetworkOrderItemResponse1 findNetworkOrderItem(findNetworkOrderItemRequest request);

    [OperationContract(Action = "getNetworkOrderItems_v1_0", ReplyAction = "*")]
    [ServiceKnownType(typeof (Order))]
    [ServiceKnownType(typeof (baseRequest))]
    [XmlSerializerFormat(SupportFaults = true)]
    [ServiceKnownType(typeof (Project))]
    [ServiceKnownType(typeof (baseResponse))]
    [ServiceKnownType(typeof (Resource))]
    [ServiceKnownType(typeof (Resources))]
    [ServiceKnownType(typeof (NetworkOrderItem))]
    getNetworkOrderItemsResponse1 getNetworkOrderItems(getNetworkOrderItemsRequest request);

    [XmlSerializerFormat(SupportFaults = true)]
    [OperationContract(Action = "getNetworkOrderItemComponent_v1_0", ReplyAction = "*")]
    [ServiceKnownType(typeof (baseRequest))]
    [ServiceKnownType(typeof (Resources))]
    [ServiceKnownType(typeof (Order))]
    [ServiceKnownType(typeof (baseResponse))]
    [ServiceKnownType(typeof (Resource))]
    [ServiceKnownType(typeof (NetworkOrderItem))]
    [ServiceKnownType(typeof (Project))]
    getNetworkOrderItemComponentResponse1 getNetworkOrderItemComponent(
      getNetworkOrderItemComponentRequest request);
  }
}
