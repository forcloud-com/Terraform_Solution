using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    #pragma warning disable CS8618

    /// <summary>AWS Direct Connect.</summary>
    [JsiiByValue(fqn: "aws.directconnect.DxHostedPublicVirtualInterfaceConfig")]
    public class DxHostedPublicVirtualInterfaceConfig : aws.Directconnect.IDxHostedPublicVirtualInterfaceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#address_family DxHostedPublicVirtualInterface#address_family}.</summary>
        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressFamily
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#bgp_asn DxHostedPublicVirtualInterface#bgp_asn}.</summary>
        [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        public double BgpAsn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#connection_id DxHostedPublicVirtualInterface#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#name DxHostedPublicVirtualInterface#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#owner_account_id DxHostedPublicVirtualInterface#owner_account_id}.</summary>
        [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string OwnerAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#route_filter_prefixes DxHostedPublicVirtualInterface#route_filter_prefixes}.</summary>
        [JsiiProperty(name: "routeFilterPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] RouteFilterPrefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#vlan DxHostedPublicVirtualInterface#vlan}.</summary>
        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
        public double Vlan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#amazon_address DxHostedPublicVirtualInterface#amazon_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmazonAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#bgp_auth_key DxHostedPublicVirtualInterface#bgp_auth_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BgpAuthKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#customer_address DxHostedPublicVirtualInterface#customer_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerAddress
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface#timeouts DxHostedPublicVirtualInterface#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedPublicVirtualInterfaceTimeouts\"}", isOptional: true)]
        public aws.Directconnect.IDxHostedPublicVirtualInterfaceTimeouts? Timeouts
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
