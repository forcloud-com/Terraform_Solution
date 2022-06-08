using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    #pragma warning disable CS8618

    /// <summary>AWS Direct Connect.</summary>
    [JsiiByValue(fqn: "aws.directconnect.DxPrivateVirtualInterfaceConfig")]
    public class DxPrivateVirtualInterfaceConfig : aws.Directconnect.IDxPrivateVirtualInterfaceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#address_family DxPrivateVirtualInterface#address_family}.</summary>
        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressFamily
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#bgp_asn DxPrivateVirtualInterface#bgp_asn}.</summary>
        [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        public double BgpAsn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#connection_id DxPrivateVirtualInterface#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#name DxPrivateVirtualInterface#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#vlan DxPrivateVirtualInterface#vlan}.</summary>
        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
        public double Vlan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#amazon_address DxPrivateVirtualInterface#amazon_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmazonAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#bgp_auth_key DxPrivateVirtualInterface#bgp_auth_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BgpAuthKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#customer_address DxPrivateVirtualInterface#customer_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#dx_gateway_id DxPrivateVirtualInterface#dx_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DxGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#mtu DxPrivateVirtualInterface#mtu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Mtu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#tags DxPrivateVirtualInterface#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#timeouts DxPrivateVirtualInterface#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxPrivateVirtualInterfaceTimeouts\"}", isOptional: true)]
        public aws.Directconnect.IDxPrivateVirtualInterfaceTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_private_virtual_interface#vpn_gateway_id DxPrivateVirtualInterface#vpn_gateway_id}.</summary>
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
