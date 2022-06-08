using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>AWS VPC.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsRouteConfig), fullyQualifiedName: "aws.vpc.DataAwsRouteConfig")]
    public interface IDataAwsRouteConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#route_table_id DataAwsRoute#route_table_id}.</summary>
        [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}")]
        string RouteTableId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#destination_cidr_block DataAwsRoute#destination_cidr_block}.</summary>
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationCidrBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#destination_ipv6_cidr_block DataAwsRoute#destination_ipv6_cidr_block}.</summary>
        [JsiiProperty(name: "destinationIpv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationIpv6CidrBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#egress_only_gateway_id DataAwsRoute#egress_only_gateway_id}.</summary>
        [JsiiProperty(name: "egressOnlyGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EgressOnlyGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#gateway_id DataAwsRoute#gateway_id}.</summary>
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#instance_id DataAwsRoute#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#nat_gateway_id DataAwsRoute#nat_gateway_id}.</summary>
        [JsiiProperty(name: "natGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NatGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#network_interface_id DataAwsRoute#network_interface_id}.</summary>
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkInterfaceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#transit_gateway_id DataAwsRoute#transit_gateway_id}.</summary>
        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#vpc_peering_connection_id DataAwsRoute#vpc_peering_connection_id}.</summary>
        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcPeeringConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS VPC.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsRouteConfig), fullyQualifiedName: "aws.vpc.DataAwsRouteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IDataAwsRouteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#route_table_id DataAwsRoute#route_table_id}.</summary>
            [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}")]
            public string RouteTableId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#destination_cidr_block DataAwsRoute#destination_cidr_block}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationCidrBlock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#destination_ipv6_cidr_block DataAwsRoute#destination_ipv6_cidr_block}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationIpv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationIpv6CidrBlock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#egress_only_gateway_id DataAwsRoute#egress_only_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "egressOnlyGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EgressOnlyGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#gateway_id DataAwsRoute#gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#instance_id DataAwsRoute#instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#nat_gateway_id DataAwsRoute#nat_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "natGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NatGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#network_interface_id DataAwsRoute#network_interface_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkInterfaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#transit_gateway_id DataAwsRoute#transit_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#vpc_peering_connection_id DataAwsRoute#vpc_peering_connection_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcPeeringConnectionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
