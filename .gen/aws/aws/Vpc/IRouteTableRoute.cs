using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiInterface(nativeType: typeof(IRouteTableRoute), fullyQualifiedName: "aws.vpc.RouteTableRoute")]
    public interface IRouteTableRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#cidr_block RouteTable#cidr_block}.</summary>
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CidrBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#egress_only_gateway_id RouteTable#egress_only_gateway_id}.</summary>
        [JsiiProperty(name: "egressOnlyGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EgressOnlyGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#gateway_id RouteTable#gateway_id}.</summary>
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#instance_id RouteTable#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#ipv6_cidr_block RouteTable#ipv6_cidr_block}.</summary>
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6CidrBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#nat_gateway_id RouteTable#nat_gateway_id}.</summary>
        [JsiiProperty(name: "natGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NatGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#network_interface_id RouteTable#network_interface_id}.</summary>
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkInterfaceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#transit_gateway_id RouteTable#transit_gateway_id}.</summary>
        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#vpc_peering_connection_id RouteTable#vpc_peering_connection_id}.</summary>
        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcPeeringConnectionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRouteTableRoute), fullyQualifiedName: "aws.vpc.RouteTableRoute")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IRouteTableRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#cidr_block RouteTable#cidr_block}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CidrBlock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#egress_only_gateway_id RouteTable#egress_only_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "egressOnlyGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EgressOnlyGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#gateway_id RouteTable#gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#instance_id RouteTable#instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#ipv6_cidr_block RouteTable#ipv6_cidr_block}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6CidrBlock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#nat_gateway_id RouteTable#nat_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "natGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NatGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#network_interface_id RouteTable#network_interface_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkInterfaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#transit_gateway_id RouteTable#transit_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route_table#vpc_peering_connection_id RouteTable#vpc_peering_connection_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcPeeringConnectionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
