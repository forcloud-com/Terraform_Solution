using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(IEc2LocalGatewayRouteConfig), fullyQualifiedName: "aws.ec2.Ec2LocalGatewayRouteConfig")]
    public interface IEc2LocalGatewayRouteConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#destination_cidr_block Ec2LocalGatewayRoute#destination_cidr_block}.</summary>
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationCidrBlock
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#local_gateway_route_table_id Ec2LocalGatewayRoute#local_gateway_route_table_id}.</summary>
        [JsiiProperty(name: "localGatewayRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        string LocalGatewayRouteTableId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#local_gateway_virtual_interface_group_id Ec2LocalGatewayRoute#local_gateway_virtual_interface_group_id}.</summary>
        [JsiiProperty(name: "localGatewayVirtualInterfaceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string LocalGatewayVirtualInterfaceGroupId
        {
            get;
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEc2LocalGatewayRouteConfig), fullyQualifiedName: "aws.ec2.Ec2LocalGatewayRouteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IEc2LocalGatewayRouteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#destination_cidr_block Ec2LocalGatewayRoute#destination_cidr_block}.</summary>
            [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationCidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#local_gateway_route_table_id Ec2LocalGatewayRoute#local_gateway_route_table_id}.</summary>
            [JsiiProperty(name: "localGatewayRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
            public string LocalGatewayRouteTableId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#local_gateway_virtual_interface_group_id Ec2LocalGatewayRoute#local_gateway_virtual_interface_group_id}.</summary>
            [JsiiProperty(name: "localGatewayVirtualInterfaceGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string LocalGatewayVirtualInterfaceGroupId
            {
                get => GetInstanceProperty<string>()!;
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
