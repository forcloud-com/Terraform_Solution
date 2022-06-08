using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    /// <summary>AWS Direct Connect.</summary>
    [JsiiInterface(nativeType: typeof(IDxHostedTransitVirtualInterfaceConfig), fullyQualifiedName: "aws.directconnect.DxHostedTransitVirtualInterfaceConfig")]
    public interface IDxHostedTransitVirtualInterfaceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#address_family DxHostedTransitVirtualInterface#address_family}.</summary>
        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        string AddressFamily
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#bgp_asn DxHostedTransitVirtualInterface#bgp_asn}.</summary>
        [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        double BgpAsn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#connection_id DxHostedTransitVirtualInterface#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#name DxHostedTransitVirtualInterface#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#owner_account_id DxHostedTransitVirtualInterface#owner_account_id}.</summary>
        [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string OwnerAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#vlan DxHostedTransitVirtualInterface#vlan}.</summary>
        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
        double Vlan
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#amazon_address DxHostedTransitVirtualInterface#amazon_address}.</summary>
        [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmazonAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#bgp_auth_key DxHostedTransitVirtualInterface#bgp_auth_key}.</summary>
        [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BgpAuthKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#customer_address DxHostedTransitVirtualInterface#customer_address}.</summary>
        [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#mtu DxHostedTransitVirtualInterface#mtu}.</summary>
        [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Mtu
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#timeouts DxHostedTransitVirtualInterface#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedTransitVirtualInterfaceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Directconnect.IDxHostedTransitVirtualInterfaceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Direct Connect.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDxHostedTransitVirtualInterfaceConfig), fullyQualifiedName: "aws.directconnect.DxHostedTransitVirtualInterfaceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Directconnect.IDxHostedTransitVirtualInterfaceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#address_family DxHostedTransitVirtualInterface#address_family}.</summary>
            [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressFamily
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#bgp_asn DxHostedTransitVirtualInterface#bgp_asn}.</summary>
            [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
            public double BgpAsn
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#connection_id DxHostedTransitVirtualInterface#connection_id}.</summary>
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#name DxHostedTransitVirtualInterface#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#owner_account_id DxHostedTransitVirtualInterface#owner_account_id}.</summary>
            [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string OwnerAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#vlan DxHostedTransitVirtualInterface#vlan}.</summary>
            [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
            public double Vlan
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#amazon_address DxHostedTransitVirtualInterface#amazon_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmazonAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#bgp_auth_key DxHostedTransitVirtualInterface#bgp_auth_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BgpAuthKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#customer_address DxHostedTransitVirtualInterface#customer_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#mtu DxHostedTransitVirtualInterface#mtu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Mtu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface#timeouts DxHostedTransitVirtualInterface#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedTransitVirtualInterfaceTimeouts\"}", isOptional: true)]
            public aws.Directconnect.IDxHostedTransitVirtualInterfaceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Directconnect.IDxHostedTransitVirtualInterfaceTimeouts?>();
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
