using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    /// <summary>AWS EC2.</summary>
    [JsiiByValue(fqn: "aws.ec2.Ec2LocalGatewayRouteConfig")]
    public class Ec2LocalGatewayRouteConfig : aws.Ec2.IEc2LocalGatewayRouteConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#destination_cidr_block Ec2LocalGatewayRoute#destination_cidr_block}.</summary>
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationCidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#local_gateway_route_table_id Ec2LocalGatewayRoute#local_gateway_route_table_id}.</summary>
        [JsiiProperty(name: "localGatewayRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public string LocalGatewayRouteTableId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route#local_gateway_virtual_interface_group_id Ec2LocalGatewayRoute#local_gateway_virtual_interface_group_id}.</summary>
        [JsiiProperty(name: "localGatewayVirtualInterfaceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string LocalGatewayVirtualInterfaceGroupId
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
