using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    /// <summary>AWS VPC.</summary>
    [JsiiByValue(fqn: "aws.vpc.VpnConnectionConfig")]
    public class VpnConnectionConfig : aws.Vpc.IVpnConnectionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#customer_gateway_id VpnConnection#customer_gateway_id}.</summary>
        [JsiiProperty(name: "customerGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomerGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#type VpnConnection#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#static_routes_only VpnConnection#static_routes_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticRoutesOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? StaticRoutesOnly
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#tags VpnConnection#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#transit_gateway_id VpnConnection#transit_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransitGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#tunnel1_inside_cidr VpnConnection#tunnel1_inside_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tunnel1InsideCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tunnel1InsideCidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#tunnel1_preshared_key VpnConnection#tunnel1_preshared_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tunnel1PresharedKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tunnel1PresharedKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#tunnel2_inside_cidr VpnConnection#tunnel2_inside_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tunnel2InsideCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tunnel2InsideCidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#tunnel2_preshared_key VpnConnection#tunnel2_preshared_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tunnel2PresharedKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tunnel2PresharedKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection#vpn_gateway_id VpnConnection#vpn_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpnGatewayId
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
