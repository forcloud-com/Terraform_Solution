using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(IEc2TransitGatewayRouteTableAssociationConfig), fullyQualifiedName: "aws.ec2.Ec2TransitGatewayRouteTableAssociationConfig")]
    public interface IEc2TransitGatewayRouteTableAssociationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_route_table_association#transit_gateway_attachment_id Ec2TransitGatewayRouteTableAssociation#transit_gateway_attachment_id}.</summary>
        [JsiiProperty(name: "transitGatewayAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
        string TransitGatewayAttachmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_route_table_association#transit_gateway_route_table_id Ec2TransitGatewayRouteTableAssociation#transit_gateway_route_table_id}.</summary>
        [JsiiProperty(name: "transitGatewayRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        string TransitGatewayRouteTableId
        {
            get;
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEc2TransitGatewayRouteTableAssociationConfig), fullyQualifiedName: "aws.ec2.Ec2TransitGatewayRouteTableAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IEc2TransitGatewayRouteTableAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_route_table_association#transit_gateway_attachment_id Ec2TransitGatewayRouteTableAssociation#transit_gateway_attachment_id}.</summary>
            [JsiiProperty(name: "transitGatewayAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitGatewayAttachmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_route_table_association#transit_gateway_route_table_id Ec2TransitGatewayRouteTableAssociation#transit_gateway_route_table_id}.</summary>
            [JsiiProperty(name: "transitGatewayRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitGatewayRouteTableId
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
