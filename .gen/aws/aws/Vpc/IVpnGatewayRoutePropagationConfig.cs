using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>AWS VPC.</summary>
    [JsiiInterface(nativeType: typeof(IVpnGatewayRoutePropagationConfig), fullyQualifiedName: "aws.vpc.VpnGatewayRoutePropagationConfig")]
    public interface IVpnGatewayRoutePropagationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_gateway_route_propagation#route_table_id VpnGatewayRoutePropagation#route_table_id}.</summary>
        [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}")]
        string RouteTableId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_gateway_route_propagation#vpn_gateway_id VpnGatewayRoutePropagation#vpn_gateway_id}.</summary>
        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        string VpnGatewayId
        {
            get;
        }

        /// <summary>AWS VPC.</summary>
        [JsiiTypeProxy(nativeType: typeof(IVpnGatewayRoutePropagationConfig), fullyQualifiedName: "aws.vpc.VpnGatewayRoutePropagationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IVpnGatewayRoutePropagationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_gateway_route_propagation#route_table_id VpnGatewayRoutePropagation#route_table_id}.</summary>
            [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}")]
            public string RouteTableId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_gateway_route_propagation#vpn_gateway_id VpnGatewayRoutePropagation#vpn_gateway_id}.</summary>
            [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpnGatewayId
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
