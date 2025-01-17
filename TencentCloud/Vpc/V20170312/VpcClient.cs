/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vpc.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vpc.V20170312.Models;

   public class VpcClient : AbstractClient{

       private const string endpoint = "vpc.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public VpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public VpcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（AcceptAttachCcnInstances）用于跨账号关联实例时，云联网所有者接受并同意关联操作。
        /// </summary>
        /// <param name="req">参考<see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns>参考<see cref="AcceptAttachCcnInstancesResponse"/>实例</returns>
        public async Task<AcceptAttachCcnInstancesResponse> AcceptAttachCcnInstances(AcceptAttachCcnInstancesRequest req)
        {
             JsonResponseModel<AcceptAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcceptAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于添加带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req">参考<see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns>参考<see cref="AddBandwidthPackageResourcesResponse"/>实例</returns>
        public async Task<AddBandwidthPackageResourcesResponse> AddBandwidthPackageResources(AddBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<AddBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于在转换实例下添加IPV6转换规则。
        /// 2. 支持在同一个转换实例下批量添加转换规则，一个账户在一个地域最多50个。
        /// 3. 一个完整的转换规则包括vip6:vport6:protocol:vip:vport，其中vip6:vport6:protocol必须是唯一。
        /// </summary>
        /// <param name="req">参考<see cref="AddIp6RulesRequest"/></param>
        /// <returns>参考<see cref="AddIp6RulesResponse"/>实例</returns>
        public async Task<AddIp6RulesResponse> AddIp6Rules(AddIp6RulesRequest req)
        {
             JsonResponseModel<AddIp6RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddIp6Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddIp6RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AllocateAddresses) 用于申请一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * EIP 是专为动态云计算设计的静态 IP 地址。借助 EIP，您可以快速将 EIP 重新映射到您的另一个实例上，从而屏蔽实例故障。
        /// * 您的 EIP 与腾讯云账户相关联，而不是与某个实例相关联。在您选择显式释放该地址，或欠费超过七天之前，它会一直与您的腾讯云账户保持关联。
        /// * 平台对用户每地域能申请的 EIP 最大配额有所限制，可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)，上述配额可通过 DescribeAddressQuota 接口获取。
        /// </summary>
        /// <param name="req">参考<see cref="AllocateAddressesRequest"/></param>
        /// <returns>参考<see cref="AllocateAddressesResponse"/>实例</returns>
        public async Task<AllocateAddressesResponse> AllocateAddresses(AllocateAddressesRequest req)
        {
             JsonResponseModel<AllocateAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssignIpv6Addresses）用于弹性网卡申请`IPv6`地址。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 可以指定`IPv6`地址申请，地址类型不能为主`IP`，`IPv6`地址暂时只支持作为辅助`IP`。
        /// * 地址必须要在弹性网卡所在子网内，而且不能被占用。
        /// * 在弹性网卡上申请一个到多个辅助`IPv6`地址，接口会在弹性网卡所在子网段内返回指定数量的辅助`IPv6`地址。
        /// </summary>
        /// <param name="req">参考<see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns>参考<see cref="AssignIpv6AddressesResponse"/>实例</returns>
        public async Task<AssignIpv6AddressesResponse> AssignIpv6Addresses(AssignIpv6AddressesRequest req)
        {
             JsonResponseModel<AssignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssignIpv6CidrBlock）用于分配IPv6网段。
        /// * 使用本接口前，你需要已有VPC实例，如果没有可通过接口<a href="https://cloud.tencent.com/document/api/215/15774" title="CreateVpc" target="_blank">CreateVpc</a>创建。
        /// * 每个VPC只能申请一个IPv6网段
        /// </summary>
        /// <param name="req">参考<see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns>参考<see cref="AssignIpv6CidrBlockResponse"/>实例</returns>
        public async Task<AssignIpv6CidrBlockResponse> AssignIpv6CidrBlock(AssignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<AssignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssignIpv6SubnetCidrBlock）用于分配IPv6子网段。
        /// * 给子网分配 `IPv6` 网段，要求子网所属 `VPC` 已获得 `IPv6` 网段。如果尚未分配，请先通过接口 `AssignIpv6CidrBlock` 给子网所属 `VPC` 分配一个 `IPv6` 网段。否则无法分配 `IPv6` 子网段。
        /// * 每个子网只能分配一个IPv6网段。
        /// </summary>
        /// <param name="req">参考<see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns>参考<see cref="AssignIpv6SubnetCidrBlockResponse"/>实例</returns>
        public async Task<AssignIpv6SubnetCidrBlockResponse> AssignIpv6SubnetCidrBlock(AssignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<AssignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssignPrivateIpAddresses）用于弹性网卡申请内网 IP。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 可以指定内网IP地址申请，内网IP地址类型不能为主IP，主IP已存在，不能修改，内网IP必须要弹性网卡所在子网内，而且不能被占用。
        /// * 在弹性网卡上申请一个到多个辅助内网IP，接口会在弹性网卡所在子网网段内返回指定数量的辅助内网IP。
        /// </summary>
        /// <param name="req">参考<see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns>参考<see cref="AssignPrivateIpAddressesResponse"/>实例</returns>
        public async Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<AssignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AssociateAddress) 用于将[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）绑定到实例或弹性网卡的指定内网 IP 上。
        /// * 将 EIP 绑定到实例（CVM）上，其本质是将 EIP 绑定到实例上主网卡的主内网 IP 上。
        /// * 将 EIP 绑定到主网卡的主内网IP上，绑定过程会把其上绑定的普通公网 IP 自动解绑并释放。
        /// * 将 EIP 绑定到指定网卡的内网 IP上（非主网卡的主内网IP），则必须先解绑该 EIP，才能再绑定新的。
        /// * 将 EIP 绑定到NAT网关，请使用接口[EipBindNatGateway](https://cloud.tencent.com/document/product/215/4093)
        /// * EIP 如果欠费或被封堵，则不能被绑定。
        /// * 只有状态为 UNBIND 的 EIP 才能够被绑定。
        /// </summary>
        /// <param name="req">参考<see cref="AssociateAddressRequest"/></param>
        /// <returns>参考<see cref="AssociateAddressResponse"/>实例</returns>
        public async Task<AssociateAddressResponse> AssociateAddress(AssociateAddressRequest req)
        {
             JsonResponseModel<AssociateAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachCcnInstances）用于将网络实例加载到云联网实例中，网络实例包括VPC和专线网关。<br />
        /// 每个云联网能够关联的网络实例个数是有限的，详请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req">参考<see cref="AttachCcnInstancesRequest"/></param>
        /// <returns>参考<see cref="AttachCcnInstancesResponse"/>实例</returns>
        public async Task<AttachCcnInstancesResponse> AttachCcnInstances(AttachCcnInstancesRequest req)
        {
             JsonResponseModel<AttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AttachClassicLinkVpc)用于创建私有网络和基础网络设备互通。
        /// * 私有网络和基础网络设备必须在同一个地域。
        /// * 私有网络和基础网络的区别详见vpc产品文档-<a href="https://cloud.tencent.com/document/product/215/535#2.-.E7.A7.81.E6.9C.89.E7.BD.91.E7.BB.9C.E4.B8.8E.E5.9F.BA.E7.A1.80.E7.BD.91.E7.BB.9C">私有网络与基础网络</a>。
        /// </summary>
        /// <param name="req">参考<see cref="AttachClassicLinkVpcRequest"/></param>
        /// <returns>参考<see cref="AttachClassicLinkVpcResponse"/>实例</returns>
        public async Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpc(AttachClassicLinkVpcRequest req)
        {
             JsonResponseModel<AttachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachNetworkInterface）用于弹性网卡绑定云主机。
        /// * 一个云主机可以绑定多个弹性网卡，但只能绑定一个主网卡。更多限制信息详见<a href="https://cloud.tencent.com/document/product/215/6513">弹性网卡使用限制</a>。
        /// * 一个弹性网卡只能同时绑定一个云主机。
        /// * 只有运行中或者已关机状态的云主机才能绑定弹性网卡，查看云主机状态详见<a href="https://cloud.tencent.com/document/api/213/9452#instance_state">腾讯云主机信息</a>。
        /// * 弹性网卡绑定的云主机必须是私有网络的，而且云主机所在可用区必须和弹性网卡子网的可用区相同。
        /// </summary>
        /// <param name="req">参考<see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns>参考<see cref="AttachNetworkInterfaceResponse"/>实例</returns>
        public async Task<AttachNetworkInterfaceResponse> AttachNetworkInterface(AttachNetworkInterfaceRequest req)
        {
             JsonResponseModel<AttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAddressTemplate）用于创建IP地址模版
        /// </summary>
        /// <param name="req">参考<see cref="CreateAddressTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateAddressTemplateResponse"/>实例</returns>
        public async Task<CreateAddressTemplateResponse> CreateAddressTemplate(CreateAddressTemplateRequest req)
        {
             JsonResponseModel<CreateAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAddressTemplateGroup）用于创建IP地址模版集合
        /// </summary>
        /// <param name="req">参考<see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns>参考<see cref="CreateAddressTemplateGroupResponse"/>实例</returns>
        public async Task<CreateAddressTemplateGroupResponse> CreateAddressTemplateGroup(CreateAddressTemplateGroupRequest req)
        {
             JsonResponseModel<CreateAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口支持创建[设备带宽包](https://cloud.tencent.com/document/product/684/15246#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85)和[ip带宽包](https://cloud.tencent.com/document/product/684/15246#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85)
        /// </summary>
        /// <param name="req">参考<see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns>参考<see cref="CreateBandwidthPackageResponse"/>实例</returns>
        public async Task<CreateBandwidthPackageResponse> CreateBandwidthPackage(CreateBandwidthPackageRequest req)
        {
             JsonResponseModel<CreateBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCcn）用于创建云联网（CCN）。<br />
        /// 每个账号能创建的云联网实例个数是有限的，详请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req">参考<see cref="CreateCcnRequest"/></param>
        /// <returns>参考<see cref="CreateCcnResponse"/>实例</returns>
        public async Task<CreateCcnResponse> CreateCcn(CreateCcnRequest req)
        {
             JsonResponseModel<CreateCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCustomerGateway）用于创建对端网关。
        /// </summary>
        /// <param name="req">参考<see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns>参考<see cref="CreateCustomerGatewayResponse"/>实例</returns>
        public async Task<CreateCustomerGatewayResponse> CreateCustomerGateway(CreateCustomerGatewayRequest req)
        {
             JsonResponseModel<CreateCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomerGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDefaultVpc）用于创建默认私有网络(VPC）。
        /// 
        /// 默认VPC适用于快速入门和启动公共实例，您可以像使用任何其他VPC一样使用默认VPC。如果你想创建标准VPC，即指定VPC名称、VPC网段、子网网段、子网可用区，请使用常规创建VPC接口（CreateVpc）
        /// 
        /// 正常情况，本接口并不一定生产默认VPC，而是根据用户账号的网络属性（DescribeAccountAttributes）来决定的
        /// * 支持基础网络、VPC，返回VpcId为0
        /// * 只支持VPC，返回默认VPC信息
        /// 
        /// 你也可以通过 Force 参数，强制返回默认VPC
        /// </summary>
        /// <param name="req">参考<see cref="CreateDefaultVpcRequest"/></param>
        /// <returns>参考<see cref="CreateDefaultVpcResponse"/>实例</returns>
        public async Task<CreateDefaultVpcResponse> CreateDefaultVpc(CreateDefaultVpcRequest req)
        {
             JsonResponseModel<CreateDefaultVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefaultVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGateway）用于创建专线网关。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns>参考<see cref="CreateDirectConnectGatewayResponse"/>实例</returns>
        public async Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGateway(CreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGatewayCcnRoutes）用于创建专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req">参考<see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns>参考<see cref="CreateDirectConnectGatewayCcnRoutesResponse"/>实例</returns>
        public async Task<CreateDirectConnectGatewayCcnRoutesResponse> CreateDirectConnectGatewayCcnRoutes(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateFlowLog）用于创建流日志
        /// </summary>
        /// <param name="req">参考<see cref="CreateFlowLogRequest"/></param>
        /// <returns>参考<see cref="CreateFlowLogResponse"/>实例</returns>
        public async Task<CreateFlowLogResponse> CreateFlowLog(CreateFlowLogRequest req)
        {
             JsonResponseModel<CreateFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req">参考<see cref="CreateHaVipRequest"/></param>
        /// <returns>参考<see cref="CreateHaVipResponse"/>实例</returns>
        public async Task<CreateHaVipResponse> CreateHaVip(CreateHaVipRequest req)
        {
             JsonResponseModel<CreateHaVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于创建IPV6转换IPV4实例，支持批量
        /// 2. 同一个账户在在一个地域最多允许创建10个转换实例
        /// </summary>
        /// <param name="req">参考<see cref="CreateIp6TranslatorsRequest"/></param>
        /// <returns>参考<see cref="CreateIp6TranslatorsResponse"/>实例</returns>
        public async Task<CreateIp6TranslatorsResponse> CreateIp6Translators(CreateIp6TranslatorsRequest req)
        {
             JsonResponseModel<CreateIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNetworkInterface）用于创建弹性网卡。
        /// * 创建弹性网卡时可以指定内网IP，并且可以指定一个主IP，指定的内网IP必须在弹性网卡所在子网内，而且不能被占用。
        /// * 创建弹性网卡时可以指定需要申请的内网IP数量，系统会随机生成内网IP地址。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 创建弹性网卡同时可以绑定已有安全组。
        /// </summary>
        /// <param name="req">参考<see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns>参考<see cref="CreateNetworkInterfaceResponse"/>实例</returns>
        public async Task<CreateNetworkInterfaceResponse> CreateNetworkInterface(CreateNetworkInterfaceRequest req)
        {
             JsonResponseModel<CreateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateRouteTable)用于创建路由表。
        /// * 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// </summary>
        /// <param name="req">参考<see cref="CreateRouteTableRequest"/></param>
        /// <returns>参考<see cref="CreateRouteTableResponse"/>实例</returns>
        public async Task<CreateRouteTableResponse> CreateRouteTable(CreateRouteTableRequest req)
        {
             JsonResponseModel<CreateRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateRoutes)用于创建路由策略。
        /// * 向指定路由表批量新增路由策略。
        /// </summary>
        /// <param name="req">参考<see cref="CreateRoutesRequest"/></param>
        /// <returns>参考<see cref="CreateRoutesResponse"/>实例</returns>
        public async Task<CreateRoutesResponse> CreateRoutes(CreateRoutesRequest req)
        {
             JsonResponseModel<CreateRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSecurityGroup）用于创建新的安全组（SecurityGroup）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/500#2.-.E5.AE.89.E5.85.A8.E7.BB.84.E7.9A.84.E9.99.90.E5.88.B6">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSecurityGroupRequest"/></param>
        /// <returns>参考<see cref="CreateSecurityGroupResponse"/>实例</returns>
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest req)
        {
             JsonResponseModel<CreateSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSecurityGroupPolicies）用于创建安全组规则（SecurityGroupPolicy）。
        /// 
        /// * Version安全组规则版本号，用户每次更新安全规则版本会自动加1，防止你更新的路由规则已过期，不填不考虑冲突。
        /// * Protocol字段支持输入TCP, UDP, ICMP, GRE, ALL。
        /// * CidrBlock字段允许输入符合cidr格式标准的任意字符串。(展开)在基础网络中，如果CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * SecurityGroupId字段允许输入与待修改的安全组位于相同项目中的安全组ID，包括这个安全组ID本身，代表安全组下所有云服务器的内网IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。
        /// * Port字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当Protocol字段是TCP或UDP时，Port字段才被接受，即Protocol字段不是TCP或UDP时，Protocol和Port排他关系，不允许同时输入，否则会接口报错。
        /// * Action字段只允许输入ACCEPT或DROP。
        /// * CidrBlock, SecurityGroupId, AddressTemplate三者是排他关系，不允许同时输入，Protocol + Port和ServiceTemplate二者是排他关系，不允许同时输入。
        /// * 一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSecurityGroupPoliciesRequest"/></param>
        /// <returns>参考<see cref="CreateSecurityGroupPoliciesResponse"/>实例</returns>
        public async Task<CreateSecurityGroupPoliciesResponse> CreateSecurityGroupPolicies(CreateSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateServiceTemplate）用于创建协议端口模板
        /// </summary>
        /// <param name="req">参考<see cref="CreateServiceTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateServiceTemplateResponse"/>实例</returns>
        public async Task<CreateServiceTemplateResponse> CreateServiceTemplate(CreateServiceTemplateRequest req)
        {
             JsonResponseModel<CreateServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateServiceTemplateGroup）用于创建协议端口模板集合
        /// </summary>
        /// <param name="req">参考<see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns>参考<see cref="CreateServiceTemplateGroupResponse"/>实例</returns>
        public async Task<CreateServiceTemplateGroupResponse> CreateServiceTemplateGroup(CreateServiceTemplateGroupRequest req)
        {
             JsonResponseModel<CreateServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateSubnet)用于创建子网。
        /// * 创建子网前必须创建好 VPC。
        /// * 子网创建成功后，子网网段不能修改。子网网段必须在VPC网段内，可以和VPC网段相同（VPC有且只有一个子网时），建议子网网段在VPC网段内，预留网段给其他子网使用。
        /// * 你可以创建的最小网段子网掩码为28（有16个IP地址），最大网段子网掩码为16（65,536个IP地址）。
        /// * 同一个VPC内，多个子网的网段不能重叠。
        /// * 子网创建后会自动关联到默认路由表。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSubnetRequest"/></param>
        /// <returns>参考<see cref="CreateSubnetResponse"/>实例</returns>
        public async Task<CreateSubnetResponse> CreateSubnet(CreateSubnetRequest req)
        {
             JsonResponseModel<CreateSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateSubnets)用于批量创建子网。
        /// * 创建子网前必须创建好 VPC。
        /// * 子网创建成功后，子网网段不能修改。子网网段必须在VPC网段内，可以和VPC网段相同（VPC有且只有一个子网时），建议子网网段在VPC网段内，预留网段给其他子网使用。
        /// * 你可以创建的最小网段子网掩码为28（有16个IP地址），最大网段子网掩码为16（65,536个IP地址）。
        /// * 同一个VPC内，多个子网的网段不能重叠。
        /// * 子网创建后会自动关联到默认路由表。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSubnetsRequest"/></param>
        /// <returns>参考<see cref="CreateSubnetsResponse"/>实例</returns>
        public async Task<CreateSubnetsResponse> CreateSubnets(CreateSubnetsRequest req)
        {
             JsonResponseModel<CreateSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateVpc)用于创建私有网络(VPC)。
        /// * 用户可以创建的最小网段子网掩码为28（有16个IP地址），最大网段子网掩码为16（65,536个IP地址）,如果规划VPC网段请参见VPC网段规划说明。
        /// * 同一个地域能创建的VPC资源个数也是有限制的，详见 <a href="https://cloud.tencent.com/doc/product/215/537" title="VPC使用限制">VPC使用限制</a>,如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req">参考<see cref="CreateVpcRequest"/></param>
        /// <returns>参考<see cref="CreateVpcResponse"/>实例</returns>
        public async Task<CreateVpcResponse> CreateVpc(CreateVpcRequest req)
        {
             JsonResponseModel<CreateVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpnConnection）用于创建VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="CreateVpnConnectionRequest"/></param>
        /// <returns>参考<see cref="CreateVpnConnectionResponse"/>实例</returns>
        public async Task<CreateVpnConnectionResponse> CreateVpnConnection(CreateVpnConnectionRequest req)
        {
             JsonResponseModel<CreateVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpnGateway）用于创建VPN网关。
        /// </summary>
        /// <param name="req">参考<see cref="CreateVpnGatewayRequest"/></param>
        /// <returns>参考<see cref="CreateVpnGatewayResponse"/>实例</returns>
        public async Task<CreateVpnGatewayResponse> CreateVpnGateway(CreateVpnGatewayRequest req)
        {
             JsonResponseModel<CreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplate）用于删除IP地址模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteAddressTemplateResponse"/>实例</returns>
        public async Task<DeleteAddressTemplateResponse> DeleteAddressTemplate(DeleteAddressTemplateRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplateGroup）用于删除IP地址模板集合
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteAddressTemplateGroupResponse"/>实例</returns>
        public async Task<DeleteAddressTemplateGroupResponse> DeleteAddressTemplateGroup(DeleteAddressTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口支持删除共享带宽包，包括[设备带宽包](https://cloud.tencent.com/document/product/684/15246#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85)和[ip带宽包](https://cloud.tencent.com/document/product/684/15246#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85)
        /// </summary>
        /// <param name="req">参考<see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns>参考<see cref="DeleteBandwidthPackageResponse"/>实例</returns>
        public async Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackage(DeleteBandwidthPackageRequest req)
        {
             JsonResponseModel<DeleteBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCcn）用于删除云联网。
        /// * 删除后，云联网关联的所有实例间路由将被删除，网络将会中断，请务必确认
        /// * 删除云联网是不可逆的操作，请谨慎处理。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCcnRequest"/></param>
        /// <returns>参考<see cref="DeleteCcnResponse"/>实例</returns>
        public async Task<DeleteCcnResponse> DeleteCcn(DeleteCcnRequest req)
        {
             JsonResponseModel<DeleteCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCustomerGateway）用于删除对端网关。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteCustomerGatewayResponse"/>实例</returns>
        public async Task<DeleteCustomerGatewayResponse> DeleteCustomerGateway(DeleteCustomerGatewayRequest req)
        {
             JsonResponseModel<DeleteCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomerGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGateway）用于删除专线网关。
        /// <li>如果是 NAT 网关，删除专线网关后，NAT 规则以及 ACL 策略都被清理了。</li>
        /// <li>删除专线网关后，系统会删除路由表中跟该专线网关相关的路由策略。</li>
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDirectConnectGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteDirectConnectGatewayResponse"/>实例</returns>
        public async Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGatewayCcnRoutes）用于删除专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns>参考<see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/>实例</returns>
        public async Task<DeleteDirectConnectGatewayCcnRoutesResponse> DeleteDirectConnectGatewayCcnRoutes(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteFlowLog）用于删除流日志
        /// </summary>
        /// <param name="req">参考<see cref="DeleteFlowLogRequest"/></param>
        /// <returns>参考<see cref="DeleteFlowLogResponse"/>实例</returns>
        public async Task<DeleteFlowLogResponse> DeleteFlowLog(DeleteFlowLogRequest req)
        {
             JsonResponseModel<DeleteFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteHaVip）用于删除高可用虚拟IP（HAVIP）<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口
        /// </summary>
        /// <param name="req">参考<see cref="DeleteHaVipRequest"/></param>
        /// <returns>参考<see cref="DeleteHaVipResponse"/>实例</returns>
        public async Task<DeleteHaVipResponse> DeleteHaVip(DeleteHaVipRequest req)
        {
             JsonResponseModel<DeleteHaVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于释放IPV6转换实例，支持批量。
        /// 2.  如果IPV6转换实例建立有转换规则，会一并删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteIp6TranslatorsRequest"/></param>
        /// <returns>参考<see cref="DeleteIp6TranslatorsResponse"/>实例</returns>
        public async Task<DeleteIp6TranslatorsResponse> DeleteIp6Translators(DeleteIp6TranslatorsRequest req)
        {
             JsonResponseModel<DeleteIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNetworkInterface）用于删除弹性网卡。
        /// * 弹性网卡上绑定了云主机时，不能被删除。
        /// * 删除指定弹性网卡，弹性网卡必须先和子机解绑才能删除。删除之后弹性网卡上所有内网IP都将被退还。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns>参考<see cref="DeleteNetworkInterfaceResponse"/>实例</returns>
        public async Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterface(DeleteNetworkInterfaceRequest req)
        {
             JsonResponseModel<DeleteNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除路由表
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRouteTableRequest"/></param>
        /// <returns>参考<see cref="DeleteRouteTableResponse"/>实例</returns>
        public async Task<DeleteRouteTableResponse> DeleteRouteTable(DeleteRouteTableRequest req)
        {
             JsonResponseModel<DeleteRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteRoutes)用于对某个路由表批量删除路由策略（Route）。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRoutesRequest"/></param>
        /// <returns>参考<see cref="DeleteRoutesResponse"/>实例</returns>
        public async Task<DeleteRoutesResponse> DeleteRoutes(DeleteRoutesRequest req)
        {
             JsonResponseModel<DeleteRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSecurityGroup）用于删除安全组（SecurityGroup）。
        /// * 只有当前账号下的安全组允许被删除。
        /// * 安全组实例ID如果在其他安全组的规则中被引用，则无法直接删除。这种情况下，需要先进行规则修改，再删除安全组。
        /// * 删除的安全组无法再找回，请谨慎调用。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteSecurityGroupResponse"/>实例</returns>
        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroup(DeleteSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSecurityGroupPolicies）用于用于删除安全组规则（SecurityGroupPolicy）。
        /// * SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns>参考<see cref="DeleteSecurityGroupPoliciesResponse"/>实例</returns>
        public async Task<DeleteSecurityGroupPoliciesResponse> DeleteSecurityGroupPolicies(DeleteSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplate）用于删除协议端口模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteServiceTemplateResponse"/>实例</returns>
        public async Task<DeleteServiceTemplateResponse> DeleteServiceTemplate(DeleteServiceTemplateRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplateGroup）用于删除协议端口模板集合
        /// </summary>
        /// <param name="req">参考<see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteServiceTemplateGroupResponse"/>实例</returns>
        public async Task<DeleteServiceTemplateGroupResponse> DeleteServiceTemplateGroup(DeleteServiceTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSubnet）用于用于删除子网(Subnet)。
        /// * 删除子网前，请清理该子网下所有资源，包括云主机、负载均衡、云数据、noSql、弹性网卡等资源。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSubnetRequest"/></param>
        /// <returns>参考<see cref="DeleteSubnetResponse"/>实例</returns>
        public async Task<DeleteSubnetResponse> DeleteSubnet(DeleteSubnetRequest req)
        {
             JsonResponseModel<DeleteSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpc）用于删除私有网络。
        /// * 删除前请确保 VPC 内已经没有相关资源，例如云主机、云数据库、NoSQL、VPN网关、专线网关、负载均衡、对等连接、与之互通的基础网络设备等。
        /// * 删除私有网络是不可逆的操作，请谨慎处理。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpcRequest"/></param>
        /// <returns>参考<see cref="DeleteVpcResponse"/>实例</returns>
        public async Task<DeleteVpcResponse> DeleteVpc(DeleteVpcRequest req)
        {
             JsonResponseModel<DeleteVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteVpnConnection)用于删除VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns>参考<see cref="DeleteVpnConnectionResponse"/>实例</returns>
        public async Task<DeleteVpnConnectionResponse> DeleteVpnConnection(DeleteVpnConnectionRequest req)
        {
             JsonResponseModel<DeleteVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpnGateway）用于删除VPN网关。目前只支持删除运行中的按量计费的IPSEC网关实例。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteVpnGatewayResponse"/>实例</returns>
        public async Task<DeleteVpnGatewayResponse> DeleteVpnGateway(DeleteVpnGatewayRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccountAttributes）用于查询用户账号私有属性。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountAttributesResponse"/>实例</returns>
        public async Task<DescribeAccountAttributesResponse> DescribeAccountAttributes(DescribeAccountAttributesRequest req)
        {
             JsonResponseModel<DescribeAccountAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAddressQuota) 用于查询您账户的[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）在当前地域的配额信息。配额详情可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeAddressQuotaResponse"/>实例</returns>
        public async Task<DescribeAddressQuotaResponse> DescribeAddressQuota(DescribeAddressQuotaRequest req)
        {
             JsonResponseModel<DescribeAddressQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplateGroups）用于查询IP地址模板集合
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeAddressTemplateGroupsResponse"/>实例</returns>
        public async Task<DescribeAddressTemplateGroupsResponse> DescribeAddressTemplateGroups(DescribeAddressTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeAddressTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplates）用于查询IP地址模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeAddressTemplatesResponse"/>实例</returns>
        public async Task<DescribeAddressTemplatesResponse> DescribeAddressTemplates(DescribeAddressTemplatesRequest req)
        {
             JsonResponseModel<DescribeAddressTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAddresses) 用于查询一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的详细信息。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的 EIP。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAddressesRequest"/></param>
        /// <returns>参考<see cref="DescribeAddressesResponse"/>实例</returns>
        public async Task<DescribeAddressesResponse> DescribeAddresses(DescribeAddressesRequest req)
        {
             JsonResponseModel<DescribeAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询账户在当前地域的带宽包上限数量以及使用数量
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeBandwidthPackageQuotaResponse"/>实例</returns>
        public async Task<DescribeBandwidthPackageQuotaResponse> DescribeBandwidthPackageQuota(DescribeBandwidthPackageQuotaRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询带宽包详细信息，包括带宽包唯一标识ID，类型，计费模式，名称，资源信息等
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns>参考<see cref="DescribeBandwidthPackagesResponse"/>实例</returns>
        public async Task<DescribeBandwidthPackagesResponse> DescribeBandwidthPackages(DescribeBandwidthPackagesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnAttachedInstances）用于查询云联网实例下已关联的网络实例。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeCcnAttachedInstancesResponse"/>实例</returns>
        public async Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnRegionBandwidthLimits）用于查询云联网各地域出带宽上限，该接口只返回已关联网络实例包含的地域
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns>参考<see cref="DescribeCcnRegionBandwidthLimitsResponse"/>实例</returns>
        public async Task<DescribeCcnRegionBandwidthLimitsResponse> DescribeCcnRegionBandwidthLimits(DescribeCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnRoutes）用于查询已加入云联网（CCN）的路由
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns>参考<see cref="DescribeCcnRoutesResponse"/>实例</returns>
        public async Task<DescribeCcnRoutesResponse> DescribeCcnRoutes(DescribeCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcns）用于查询云联网（CCN）列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCcnsRequest"/></param>
        /// <returns>参考<see cref="DescribeCcnsResponse"/>实例</returns>
        public async Task<DescribeCcnsResponse> DescribeCcns(DescribeCcnsRequest req)
        {
             JsonResponseModel<DescribeCcnsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeClassicLinkInstances)用于查询私有网络和基础网络设备互通列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeClassicLinkInstancesResponse"/>实例</returns>
        public async Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest req)
        {
             JsonResponseModel<DescribeClassicLinkInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicLinkInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicLinkInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCustomerGatewayVendors）用于查询可支持的对端网关厂商信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns>参考<see cref="DescribeCustomerGatewayVendorsResponse"/>实例</returns>
        public async Task<DescribeCustomerGatewayVendorsResponse> DescribeCustomerGatewayVendors(DescribeCustomerGatewayVendorsRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewayVendorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomerGatewayVendors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewayVendorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCustomerGateways）用于查询对端网关列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeCustomerGatewaysResponse"/>实例</returns>
        public async Task<DescribeCustomerGatewaysResponse> DescribeCustomerGateways(DescribeCustomerGatewaysRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomerGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGatewayCcnRoutes）用于查询专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns>参考<see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/>实例</returns>
        public async Task<DescribeDirectConnectGatewayCcnRoutesResponse> DescribeDirectConnectGatewayCcnRoutes(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGateways）用于查询专线网关。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeDirectConnectGatewaysResponse"/>实例</returns>
        public async Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlowLog）用于查询流日志实例信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFlowLogRequest"/></param>
        /// <returns>参考<see cref="DescribeFlowLogResponse"/>实例</returns>
        public async Task<DescribeFlowLogResponse> DescribeFlowLog(DescribeFlowLogRequest req)
        {
             JsonResponseModel<DescribeFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlowLogs）用于查询获取流日志集合
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFlowLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeFlowLogsResponse"/>实例</returns>
        public async Task<DescribeFlowLogsResponse> DescribeFlowLogs(DescribeFlowLogsRequest req)
        {
             JsonResponseModel<DescribeFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGatewayFlowMonitorDetail）用于查询网关流量监控明细。
        /// * 只支持单个网关实例查询。即入参 `VpnId` `DirectConnectGatewayId` `PeeringConnectionId` `NatId` 最多只支持传一个，且必须传一个。
        /// * 如果网关有流量，但调用本接口没有返回数据，请在控制台对应网关详情页确认是否开启网关流量监控。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGatewayFlowMonitorDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeGatewayFlowMonitorDetailResponse"/>实例</returns>
        public async Task<DescribeGatewayFlowMonitorDetailResponse> DescribeGatewayFlowMonitorDetail(DescribeGatewayFlowMonitorDetailRequest req)
        {
             JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayFlowMonitorDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeHaVips）用于查询高可用虚拟IP（HAVIP）列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHaVipsRequest"/></param>
        /// <returns>参考<see cref="DescribeHaVipsResponse"/>实例</returns>
        public async Task<DescribeHaVipsResponse> DescribeHaVips(DescribeHaVipsRequest req)
        {
             JsonResponseModel<DescribeHaVipsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHaVips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHaVipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账户在指定地域IPV6转换实例和规则的配额
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIp6TranslatorQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeIp6TranslatorQuotaResponse"/>实例</returns>
        public async Task<DescribeIp6TranslatorQuotaResponse> DescribeIp6TranslatorQuota(DescribeIp6TranslatorQuotaRequest req)
        {
             JsonResponseModel<DescribeIp6TranslatorQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIp6TranslatorQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIp6TranslatorQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于查询账户下的IPV6转换实例及其绑定的转换规则信息
        /// 2. 支持过滤查询
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIp6TranslatorsRequest"/></param>
        /// <returns>参考<see cref="DescribeIp6TranslatorsResponse"/>实例</returns>
        public async Task<DescribeIp6TranslatorsResponse> DescribeIp6Translators(DescribeIp6TranslatorsRequest req)
        {
             JsonResponseModel<DescribeIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNatGateways）用于查询 NAT 网关。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeNatGatewaysResponse"/>实例</returns>
        public async Task<DescribeNatGatewaysResponse> DescribeNatGateways(DescribeNatGatewaysRequest req)
        {
             JsonResponseModel<DescribeNatGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetworkInterfaces）用于查询弹性网卡列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns>参考<see cref="DescribeNetworkInterfacesResponse"/>实例</returns>
        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRouteConflicts）用于查询自定义路由策略与云联网路由策略冲突列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns>参考<see cref="DescribeRouteConflictsResponse"/>实例</returns>
        public async Task<DescribeRouteConflictsResponse> DescribeRouteConflicts(DescribeRouteConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteConflictsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  本接口（DescribeRouteTables）用于查询路由表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRouteTablesRequest"/></param>
        /// <returns>参考<see cref="DescribeRouteTablesResponse"/>实例</returns>
        public async Task<DescribeRouteTablesResponse> DescribeRouteTables(DescribeRouteTablesRequest req)
        {
             JsonResponseModel<DescribeRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroupAssociationStatistics）用于查询安全组关联的实例统计。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeSecurityGroupAssociationStatisticsResponse"/>实例</returns>
        public async Task<DescribeSecurityGroupAssociationStatisticsResponse> DescribeSecurityGroupAssociationStatistics(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupAssociationStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroupPolicies）用于查询安全组规则。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns>参考<see cref="DescribeSecurityGroupPoliciesResponse"/>实例</returns>
        public async Task<DescribeSecurityGroupPoliciesResponse> DescribeSecurityGroupPolicies(DescribeSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroups）用于查询安全组。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeSecurityGroupsResponse"/>实例</returns>
        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroups(DescribeSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplateGroups）用于查询协议端口模板集合
        /// </summary>
        /// <param name="req">参考<see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeServiceTemplateGroupsResponse"/>实例</returns>
        public async Task<DescribeServiceTemplateGroupsResponse> DescribeServiceTemplateGroups(DescribeServiceTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeServiceTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplates）用于查询协议端口模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeServiceTemplatesResponse"/>实例</returns>
        public async Task<DescribeServiceTemplatesResponse> DescribeServiceTemplates(DescribeServiceTemplatesRequest req)
        {
             JsonResponseModel<DescribeServiceTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSubnets）用于查询子网列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetsRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetsResponse"/>实例</returns>
        public async Task<DescribeSubnetsResponse> DescribeSubnets(DescribeSubnetsRequest req)
        {
             JsonResponseModel<DescribeSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcIpv6Addresses）用于查询 `VPC` `IPv6` 信息。
        /// 只能查询已使用的`IPv6`信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcIpv6AddressesResponse"/>实例</returns>
        public async Task<DescribeVpcIpv6AddressesResponse> DescribeVpcIpv6Addresses(DescribeVpcIpv6AddressesRequest req)
        {
             JsonResponseModel<DescribeVpcIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcPrivateIpAddresses）用于查询VPC内网IP信息。<br />
        /// 只能查询已使用的IP信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcPrivateIpAddressesResponse"/>实例</returns>
        public async Task<DescribeVpcPrivateIpAddressesResponse> DescribeVpcPrivateIpAddresses(DescribeVpcPrivateIpAddressesRequest req)
        {
             JsonResponseModel<DescribeVpcPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcs）用于查询私有网络列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcsRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcsResponse"/>实例</returns>
        public async Task<DescribeVpcsResponse> DescribeVpcs(DescribeVpcsRequest req)
        {
             JsonResponseModel<DescribeVpcsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  本接口（DescribeVpnConnections）查询VPN通道列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns>参考<see cref="DescribeVpnConnectionsResponse"/>实例</returns>
        public async Task<DescribeVpnConnectionsResponse> DescribeVpnConnections(DescribeVpnConnectionsRequest req)
        {
             JsonResponseModel<DescribeVpnConnectionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpnGateways）用于查询VPN网关列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeVpnGatewaysResponse"/>实例</returns>
        public async Task<DescribeVpnGatewaysResponse> DescribeVpnGateways(DescribeVpnGatewaysRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachCcnInstances）用于从云联网实例中解关联指定的网络实例。<br />
        /// 解关联网络实例后，相应的路由策略会一并删除。
        /// </summary>
        /// <param name="req">参考<see cref="DetachCcnInstancesRequest"/></param>
        /// <returns>参考<see cref="DetachCcnInstancesResponse"/>实例</returns>
        public async Task<DetachCcnInstancesResponse> DetachCcnInstances(DetachCcnInstancesRequest req)
        {
             JsonResponseModel<DetachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DetachClassicLinkVpc)用于删除私有网络和基础网络设备互通。
        /// </summary>
        /// <param name="req">参考<see cref="DetachClassicLinkVpcRequest"/></param>
        /// <returns>参考<see cref="DetachClassicLinkVpcResponse"/>实例</returns>
        public async Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpc(DetachClassicLinkVpcRequest req)
        {
             JsonResponseModel<DetachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachNetworkInterface）用于弹性网卡解绑云主机。
        /// </summary>
        /// <param name="req">参考<see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns>参考<see cref="DetachNetworkInterfaceResponse"/>实例</returns>
        public async Task<DetachNetworkInterfaceResponse> DetachNetworkInterface(DetachNetworkInterfaceRequest req)
        {
             JsonResponseModel<DetachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableCcnRoutes）用于禁用已经启用的云联网（CCN）路由
        /// </summary>
        /// <param name="req">参考<see cref="DisableCcnRoutesRequest"/></param>
        /// <returns>参考<see cref="DisableCcnRoutesResponse"/>实例</returns>
        public async Task<DisableCcnRoutesResponse> DisableCcnRoutes(DisableCcnRoutesRequest req)
        {
             JsonResponseModel<DisableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableRoutes）用于禁用已启用的子网路由
        /// </summary>
        /// <param name="req">参考<see cref="DisableRoutesRequest"/></param>
        /// <returns>参考<see cref="DisableRoutesResponse"/>实例</returns>
        public async Task<DisableRoutesResponse> DisableRoutes(DisableRoutesRequest req)
        {
             JsonResponseModel<DisableRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DisassociateAddress) 用于解绑[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 支持CVM实例，弹性网卡上的EIP解绑
        /// * 不支持NAT上的EIP解绑。NAT上的EIP解绑请参考[EipUnBindNatGateway](https://cloud.tencent.com/document/product/215/4092)
        /// * 只有状态为 BIND 和 BIND_ENI 的 EIP 才能进行解绑定操作。
        /// * EIP 如果被封堵，则不能进行解绑定操作。
        /// </summary>
        /// <param name="req">参考<see cref="DisassociateAddressRequest"/></param>
        /// <returns>参考<see cref="DisassociateAddressResponse"/>实例</returns>
        public async Task<DisassociateAddressResponse> DisassociateAddress(DisassociateAddressRequest req)
        {
             JsonResponseModel<DisassociateAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DownloadCustomerGatewayConfiguration)用于下载VPN通道配置。
        /// </summary>
        /// <param name="req">参考<see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns>参考<see cref="DownloadCustomerGatewayConfigurationResponse"/>实例</returns>
        public async Task<DownloadCustomerGatewayConfigurationResponse> DownloadCustomerGatewayConfiguration(DownloadCustomerGatewayConfigurationRequest req)
        {
             JsonResponseModel<DownloadCustomerGatewayConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadCustomerGatewayConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadCustomerGatewayConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableCcnRoutes）用于启用已经加入云联网（CCN）的路由。<br />
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req">参考<see cref="EnableCcnRoutesRequest"/></param>
        /// <returns>参考<see cref="EnableCcnRoutesResponse"/>实例</returns>
        public async Task<EnableCcnRoutesResponse> EnableCcnRoutes(EnableCcnRoutesRequest req)
        {
             JsonResponseModel<EnableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableRoutes）用于启用已禁用的子网路由。<br />
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req">参考<see cref="EnableRoutesRequest"/></param>
        /// <returns>参考<see cref="EnableRoutesResponse"/>实例</returns>
        public async Task<EnableRoutesResponse> EnableRoutes(EnableRoutesRequest req)
        {
             JsonResponseModel<EnableRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（HaVipAssociateAddressIp）用于高可用虚拟IP（HAVIP）绑定弹性公网IP（EIP）<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口
        /// </summary>
        /// <param name="req">参考<see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns>参考<see cref="HaVipAssociateAddressIpResponse"/>实例</returns>
        public async Task<HaVipAssociateAddressIpResponse> HaVipAssociateAddressIp(HaVipAssociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipAssociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HaVipAssociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipAssociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（HaVipDisassociateAddressIp）用于将高可用虚拟IP（HAVIP）已绑定的弹性公网IP（EIP）解除绑定<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口
        /// </summary>
        /// <param name="req">参考<see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns>参考<see cref="HaVipDisassociateAddressIpResponse"/>实例</returns>
        public async Task<HaVipDisassociateAddressIpResponse> HaVipDisassociateAddressIp(HaVipDisassociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipDisassociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HaVipDisassociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipDisassociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateVpnGateway）用于创建VPN网关询价。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceCreateVpnGatewayRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceCreateVpnGatewayResponse"/>实例</returns>
        public async Task<InquiryPriceCreateVpnGatewayResponse> InquiryPriceCreateVpnGateway(InquiryPriceCreateVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceCreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewVpnGateway）用于续费VPN网关询价。目前仅支持IPSEC类型网关的询价。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceRenewVpnGatewayResponse"/>实例</returns>
        public async Task<InquiryPriceRenewVpnGatewayResponse> InquiryPriceRenewVpnGateway(InquiryPriceRenewVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceRenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceResetVpnGatewayInternetMaxBandwidth）调整VPN网关带宽上限询价。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/>实例</returns>
        public async Task<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> InquiryPriceResetVpnGatewayInternetMaxBandwidth(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（MigrateNetworkInterface）用于弹性网卡迁移。
        /// </summary>
        /// <param name="req">参考<see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns>参考<see cref="MigrateNetworkInterfaceResponse"/>实例</returns>
        public async Task<MigrateNetworkInterfaceResponse> MigrateNetworkInterface(MigrateNetworkInterfaceRequest req)
        {
             JsonResponseModel<MigrateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigrateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  本接口（MigratePrivateIpAddress）用于弹性网卡内网IP迁移。
        /// 
        /// * 该接口用于将一个内网IP从一个弹性网卡上迁移到另外一个弹性网卡，主IP地址不支持迁移。
        /// * 迁移前后的弹性网卡必须在同一个子网内。
        /// </summary>
        /// <param name="req">参考<see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns>参考<see cref="MigratePrivateIpAddressResponse"/>实例</returns>
        public async Task<MigratePrivateIpAddressResponse> MigratePrivateIpAddress(MigratePrivateIpAddressRequest req)
        {
             JsonResponseModel<MigratePrivateIpAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigratePrivateIpAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigratePrivateIpAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyAddressAttribute) 用于修改[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的名称。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyAddressAttributeResponse"/>实例</returns>
        public async Task<ModifyAddressAttributeResponse> ModifyAddressAttribute(ModifyAddressAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateAttribute）用于修改IP地址模板
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyAddressTemplateAttributeResponse"/>实例</returns>
        public async Task<ModifyAddressTemplateAttributeResponse> ModifyAddressTemplateAttribute(ModifyAddressTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateGroupAttribute）用于修改IP地址模板集合
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyAddressTemplateGroupAttributeResponse"/>实例</returns>
        public async Task<ModifyAddressTemplateGroupAttributeResponse> ModifyAddressTemplateGroupAttribute(ModifyAddressTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAddressesBandwidth）用于调整[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)(简称EIP)带宽，包括后付费EIP, 预付费EIP和带宽包EIP
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns>参考<see cref="ModifyAddressesBandwidthResponse"/>实例</returns>
        public async Task<ModifyAddressesBandwidthResponse> ModifyAddressesBandwidth(ModifyAddressesBandwidthRequest req)
        {
             JsonResponseModel<ModifyAddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于修改带宽包属性，包括带宽包名字等
        /// </summary>
        /// <param name="req">参考<see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyBandwidthPackageAttributeResponse"/>实例</returns>
        public async Task<ModifyBandwidthPackageAttributeResponse> ModifyBandwidthPackageAttribute(ModifyBandwidthPackageAttributeRequest req)
        {
             JsonResponseModel<ModifyBandwidthPackageAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBandwidthPackageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBandwidthPackageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCcnAttribute）用于修改云联网（CCN）的相关属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyCcnAttributeResponse"/>实例</returns>
        public async Task<ModifyCcnAttributeResponse> ModifyCcnAttribute(ModifyCcnAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcnAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCustomerGatewayAttribute）用于修改对端网关信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyCustomerGatewayAttributeResponse"/>实例</returns>
        public async Task<ModifyCustomerGatewayAttributeResponse> ModifyCustomerGatewayAttribute(ModifyCustomerGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyCustomerGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomerGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomerGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDirectConnectGatewayAttribute）用于修改专线网关属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyDirectConnectGatewayAttributeResponse"/>实例</returns>
        public async Task<ModifyDirectConnectGatewayAttributeResponse> ModifyDirectConnectGatewayAttribute(ModifyDirectConnectGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDirectConnectGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyFlowLogAttribute）用于修改流日志属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyFlowLogAttributeResponse"/>实例</returns>
        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest req)
        {
             JsonResponseModel<ModifyFlowLogAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFlowLogAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlowLogAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyHaVipAttribute）用于修改高可用虚拟IP（HAVIP）属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyHaVipAttributeResponse"/>实例</returns>
        public async Task<ModifyHaVipAttributeResponse> ModifyHaVipAttribute(ModifyHaVipAttributeRequest req)
        {
             JsonResponseModel<ModifyHaVipAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHaVipAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHaVipAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改IPV6转换规则，当前仅支持修改转换规则名称，IPV4地址和IPV4端口号
        /// </summary>
        /// <param name="req">参考<see cref="ModifyIp6RuleRequest"/></param>
        /// <returns>参考<see cref="ModifyIp6RuleResponse"/>实例</returns>
        public async Task<ModifyIp6RuleResponse> ModifyIp6Rule(ModifyIp6RuleRequest req)
        {
             JsonResponseModel<ModifyIp6RuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIp6Rule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIp6RuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改IP6转换实例属性，当前仅支持修改实例名称。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyIp6TranslatorRequest"/></param>
        /// <returns>参考<see cref="ModifyIp6TranslatorResponse"/>实例</returns>
        public async Task<ModifyIp6TranslatorResponse> ModifyIp6Translator(ModifyIp6TranslatorRequest req)
        {
             JsonResponseModel<ModifyIp6TranslatorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIp6Translator");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIp6TranslatorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡内网IPv6地址属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyIpv6AddressesAttributeResponse"/>实例</returns>
        public async Task<ModifyIpv6AddressesAttributeResponse> ModifyIpv6AddressesAttribute(ModifyIpv6AddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyIpv6AddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIpv6AddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIpv6AddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceAttribute）用于修改弹性网卡属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyNetworkInterfaceAttributeResponse"/>实例</returns>
        public async Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkInterfaceAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkInterfaceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkInterfaceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyPrivateIpAddressesAttribute）用于修改弹性网卡内网IP属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyPrivateIpAddressesAttributeResponse"/>实例</returns>
        public async Task<ModifyPrivateIpAddressesAttributeResponse> ModifyPrivateIpAddressesAttribute(ModifyPrivateIpAddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateIpAddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyRouteTableAttribute）用于修改路由表（RouteTable）属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyRouteTableAttributeResponse"/>实例</returns>
        public async Task<ModifyRouteTableAttributeResponse> ModifyRouteTableAttribute(ModifyRouteTableAttributeRequest req)
        {
             JsonResponseModel<ModifyRouteTableAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRouteTableAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRouteTableAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySecurityGroupAttribute）用于修改安全组（SecurityGroupPolicy）属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifySecurityGroupAttributeResponse"/>实例</returns>
        public async Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttribute(ModifySecurityGroupAttributeRequest req)
        {
             JsonResponseModel<ModifySecurityGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySecurityGroupPolicies）用于重置安全组出站和入站规则（SecurityGroupPolicy）。
        /// 
        /// * 接口是先删除当前所有的出入站规则，然后再添加 Egress 和 Ingress 规则，不支持自定义索引 PolicyIndex 。
        /// * 如果指定 SecurityGroupPolicySet.Version 为0, 表示清空所有规则，并忽略Egress和Ingress。
        /// * Protocol字段支持输入TCP, UDP, ICMP, GRE, ALL。
        /// * CidrBlock字段允许输入符合cidr格式标准的任意字符串。(展开)在基础网络中，如果CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * SecurityGroupId字段允许输入与待修改的安全组位于相同项目中的安全组ID，包括这个安全组ID本身，代表安全组下所有云服务器的内网IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。
        /// * Port字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当Protocol字段是TCP或UDP时，Port字段才被接受。
        /// * Action字段只允许输入ACCEPT或DROP。
        /// * CidrBlock, SecurityGroupId, AddressTemplate三者是排他关系，不允许同时输入，Protocol + Port和ServiceTemplate二者是排他关系，不允许同时输入。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns>参考<see cref="ModifySecurityGroupPoliciesResponse"/>实例</returns>
        public async Task<ModifySecurityGroupPoliciesResponse> ModifySecurityGroupPolicies(ModifySecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateAttribute）用于修改协议端口模板
        /// </summary>
        /// <param name="req">参考<see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyServiceTemplateAttributeResponse"/>实例</returns>
        public async Task<ModifyServiceTemplateAttributeResponse> ModifyServiceTemplateAttribute(ModifyServiceTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateGroupAttribute）用于修改协议端口模板集合。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyServiceTemplateGroupAttributeResponse"/>实例</returns>
        public async Task<ModifyServiceTemplateGroupAttributeResponse> ModifyServiceTemplateGroupAttribute(ModifyServiceTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySubnetAttribute）用于修改子网属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifySubnetAttributeResponse"/>实例</returns>
        public async Task<ModifySubnetAttributeResponse> ModifySubnetAttribute(ModifySubnetAttributeRequest req)
        {
             JsonResponseModel<ModifySubnetAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubnetAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubnetAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpcAttribute）用于修改私有网络（VPC）的相关属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpcAttributeResponse"/>实例</returns>
        public async Task<ModifyVpcAttributeResponse> ModifyVpcAttribute(ModifyVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpnConnectionAttribute）用于修改VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpnConnectionAttributeResponse"/>实例</returns>
        public async Task<ModifyVpnConnectionAttributeResponse> ModifyVpnConnectionAttribute(ModifyVpnConnectionAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnConnectionAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnConnectionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnConnectionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpnGatewayAttribute）用于修改VPN网关属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpnGatewayAttributeResponse"/>实例</returns>
        public async Task<ModifyVpnGatewayAttributeResponse> ModifyVpnGatewayAttribute(ModifyVpnGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RejectAttachCcnInstances）用于跨账号关联实例时，云联网所有者拒绝关联操作。
        /// </summary>
        /// <param name="req">参考<see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns>参考<see cref="RejectAttachCcnInstancesResponse"/>实例</returns>
        public async Task<RejectAttachCcnInstancesResponse> RejectAttachCcnInstances(RejectAttachCcnInstancesRequest req)
        {
             JsonResponseModel<RejectAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RejectAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ReleaseAddresses) 用于释放一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 该操作不可逆，释放后 EIP 关联的 IP 地址将不再属于您的名下。
        /// * 只有状态为 UNBIND 的 EIP 才能进行释放操作。
        /// </summary>
        /// <param name="req">参考<see cref="ReleaseAddressesRequest"/></param>
        /// <returns>参考<see cref="ReleaseAddressesResponse"/>实例</returns>
        public async Task<ReleaseAddressesResponse> ReleaseAddresses(ReleaseAddressesRequest req)
        {
             JsonResponseModel<ReleaseAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于删除带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req">参考<see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns>参考<see cref="RemoveBandwidthPackageResourcesResponse"/>实例</returns>
        public async Task<RemoveBandwidthPackageResourcesResponse> RemoveBandwidthPackageResources(RemoveBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<RemoveBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于删除IPV6转换规则
        /// 2. 支持批量删除同一个转换实例下的多个转换规则
        /// </summary>
        /// <param name="req">参考<see cref="RemoveIp6RulesRequest"/></param>
        /// <returns>参考<see cref="RemoveIp6RulesResponse"/>实例</returns>
        public async Task<RemoveIp6RulesResponse> RemoveIp6Rules(RemoveIp6RulesRequest req)
        {
             JsonResponseModel<RemoveIp6RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveIp6Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveIp6RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewVpnGateway）用于预付费（包年包月）VPN网关续费。目前只支持IPSEC网关。
        /// </summary>
        /// <param name="req">参考<see cref="RenewVpnGatewayRequest"/></param>
        /// <returns>参考<see cref="RenewVpnGatewayResponse"/>实例</returns>
        public async Task<RenewVpnGatewayResponse> RenewVpnGateway(RenewVpnGatewayRequest req)
        {
             JsonResponseModel<RenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceDirectConnectGatewayCcnRoutes）根据路由ID（RouteId）修改指定的路由（Route），支持批量修改。
        /// </summary>
        /// <param name="req">参考<see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns>参考<see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/>实例</returns>
        public async Task<ReplaceDirectConnectGatewayCcnRoutesResponse> ReplaceDirectConnectGatewayCcnRoutes(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceRouteTableAssociation)用于修改子网（Subnet）关联的路由表（RouteTable）。
        /// * 一个子网只能关联一个路由表。
        /// </summary>
        /// <param name="req">参考<see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns>参考<see cref="ReplaceRouteTableAssociationResponse"/>实例</returns>
        public async Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest req)
        {
             JsonResponseModel<ReplaceRouteTableAssociationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceRouteTableAssociation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRouteTableAssociationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceRoutes）根据路由策略ID（RouteId）修改指定的路由策略（Route），支持批量修改。
        /// </summary>
        /// <param name="req">参考<see cref="ReplaceRoutesRequest"/></param>
        /// <returns>参考<see cref="ReplaceRoutesResponse"/>实例</returns>
        public async Task<ReplaceRoutesResponse> ReplaceRoutes(ReplaceRoutesRequest req)
        {
             JsonResponseModel<ReplaceRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceSecurityGroupPolicy）用于替换单条安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req">参考<see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns>参考<see cref="ReplaceSecurityGroupPolicyResponse"/>实例</returns>
        public async Task<ReplaceSecurityGroupPolicyResponse> ReplaceSecurityGroupPolicy(ReplaceSecurityGroupPolicyRequest req)
        {
             JsonResponseModel<ReplaceSecurityGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceSecurityGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceSecurityGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetAttachCcnInstances）用于跨账号关联实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req">参考<see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns>参考<see cref="ResetAttachCcnInstancesResponse"/>实例</returns>
        public async Task<ResetAttachCcnInstancesResponse> ResetAttachCcnInstances(ResetAttachCcnInstancesRequest req)
        {
             JsonResponseModel<ResetAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetRoutes）用于对某个路由表名称和所有路由策略（Route）进行重新设置。<br />
        /// 注意: 调用本接口是先删除当前路由表中所有路由策略, 再保存新提交的路由策略内容, 会引起网络中断。
        /// </summary>
        /// <param name="req">参考<see cref="ResetRoutesRequest"/></param>
        /// <returns>参考<see cref="ResetRoutesResponse"/>实例</returns>
        public async Task<ResetRoutesResponse> ResetRoutes(ResetRoutesRequest req)
        {
             JsonResponseModel<ResetRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ResetVpnConnection)用于重置VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="ResetVpnConnectionRequest"/></param>
        /// <returns>参考<see cref="ResetVpnConnectionResponse"/>实例</returns>
        public async Task<ResetVpnConnectionResponse> ResetVpnConnection(ResetVpnConnectionRequest req)
        {
             JsonResponseModel<ResetVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetVpnGatewayInternetMaxBandwidth）调整VPN网关带宽上限。目前支持升级配置，如果是包年包月VPN网关需要在有效期内。
        /// </summary>
        /// <param name="req">参考<see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns>参考<see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/>实例</returns>
        public async Task<ResetVpnGatewayInternetMaxBandwidthResponse> ResetVpnGatewayInternetMaxBandwidth(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetCcnRegionBandwidthLimits）用于设置云联网（CCN）各地域出带宽上限，该接口只能设置已关联网络实例包含的地域的出带宽上限
        /// </summary>
        /// <param name="req">参考<see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns>参考<see cref="SetCcnRegionBandwidthLimitsResponse"/>实例</returns>
        public async Task<SetCcnRegionBandwidthLimitsResponse> SetCcnRegionBandwidthLimits(SetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<SetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TransformAddress) 用于将实例的普通公网 IP 转换为[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 平台对用户每地域每日解绑 EIP 重新分配普通公网 IP 次数有所限制（可参见 [EIP 产品简介](/document/product/213/1941)）。上述配额可通过 [DescribeAddressQuota](https://cloud.tencent.com/document/api/213/1378) 接口获取。
        /// </summary>
        /// <param name="req">参考<see cref="TransformAddressRequest"/></param>
        /// <returns>参考<see cref="TransformAddressResponse"/>实例</returns>
        public async Task<TransformAddressResponse> TransformAddress(TransformAddressRequest req)
        {
             JsonResponseModel<TransformAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransformAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransformAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡`IPv6`地址。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口。
        /// </summary>
        /// <param name="req">参考<see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns>参考<see cref="UnassignIpv6AddressesResponse"/>实例</returns>
        public async Task<UnassignIpv6AddressesResponse> UnassignIpv6Addresses(UnassignIpv6AddressesRequest req)
        {
             JsonResponseModel<UnassignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6CidrBlock）用于释放IPv6网段。<br />
        /// 网段如果还有IP占用且未回收，则网段无法释放。
        /// </summary>
        /// <param name="req">参考<see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns>参考<see cref="UnassignIpv6CidrBlockResponse"/>实例</returns>
        public async Task<UnassignIpv6CidrBlockResponse> UnassignIpv6CidrBlock(UnassignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6SubnetCidrBlock）用于释放IPv6子网段。<br />
        /// 子网段如果还有IP占用且未回收，则子网段无法释放。
        /// </summary>
        /// <param name="req">参考<see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns>参考<see cref="UnassignIpv6SubnetCidrBlockResponse"/>实例</returns>
        public async Task<UnassignIpv6SubnetCidrBlockResponse> UnassignIpv6SubnetCidrBlock(UnassignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignPrivateIpAddresses）用于弹性网卡退还内网 IP。
        /// * 退还弹性网卡上的辅助内网IP，接口自动解关联弹性公网 IP。不能退还弹性网卡的主内网IP。
        /// </summary>
        /// <param name="req">参考<see cref="UnassignPrivateIpAddressesRequest"/></param>
        /// <returns>参考<see cref="UnassignPrivateIpAddressesResponse"/>实例</returns>
        public async Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<UnassignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
