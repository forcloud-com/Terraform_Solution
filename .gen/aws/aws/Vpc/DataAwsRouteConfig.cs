using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    /// <summary>AWS VPC.</summary>
    [JsiiByValue(fqn: "aws.vpc.DataAwsRouteConfig")]
    public class DataAwsRouteConfig : aws.Vpc.IDataAwsRouteConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#route_table_id DataAwsRoute#route_table_id}.</summary>
        [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}")]
        public string RouteTableId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#destination_cidr_block DataAwsRoute#destination_cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationCidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#destination_ipv6_cidr_block DataAwsRoute#destination_ipv6_cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationIpv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationIpv6CidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#egress_only_gateway_id DataAwsRoute#egress_only_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egressOnlyGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EgressOnlyGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#gateway_id DataAwsRoute#gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#instance_id DataAwsRoute#instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#nat_gateway_id DataAwsRoute#nat_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "natGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NatGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#network_interface_id DataAwsRoute#network_interface_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkInterfaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#transit_gateway_id DataAwsRoute#transit_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransitGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route#vpc_peering_connection_id DataAwsRoute#vpc_peering_connection_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcPeeringConnectionId
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
