using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    /// <summary>AWS EC2.</summary>
    [JsiiByValue(fqn: "aws.ec2.Ec2TransitGatewayVpcAttachmentConfig")]
    public class Ec2TransitGatewayVpcAttachmentConfig : aws.Ec2.IEc2TransitGatewayVpcAttachmentConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_vpc_attachment#subnet_ids Ec2TransitGatewayVpcAttachment#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_vpc_attachment#transit_gateway_id Ec2TransitGatewayVpcAttachment#transit_gateway_id}.</summary>
        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public string TransitGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_vpc_attachment#vpc_id Ec2TransitGatewayVpcAttachment#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_vpc_attachment#dns_support Ec2TransitGatewayVpcAttachment#dns_support}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsSupport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsSupport
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_vpc_attachment#ipv6_support Ec2TransitGatewayVpcAttachment#ipv6_support}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Support", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6Support
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_vpc_attachment#tags Ec2TransitGatewayVpcAttachment#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_vpc_attachment#transit_gateway_default_route_table_association Ec2TransitGatewayVpcAttachment#transit_gateway_default_route_table_association}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayDefaultRouteTableAssociation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TransitGatewayDefaultRouteTableAssociation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_transit_gateway_vpc_attachment#transit_gateway_default_route_table_propagation Ec2TransitGatewayVpcAttachment#transit_gateway_default_route_table_propagation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayDefaultRouteTablePropagation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TransitGatewayDefaultRouteTablePropagation
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
