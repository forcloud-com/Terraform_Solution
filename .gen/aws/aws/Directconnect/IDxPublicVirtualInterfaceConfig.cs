using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    /// <summary>AWS Direct Connect.</summary>
    [JsiiInterface(nativeType: typeof(IDxPublicVirtualInterfaceConfig), fullyQualifiedName: "aws.directconnect.DxPublicVirtualInterfaceConfig")]
    public interface IDxPublicVirtualInterfaceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#address_family DxPublicVirtualInterface#address_family}.</summary>
        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        string AddressFamily
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#bgp_asn DxPublicVirtualInterface#bgp_asn}.</summary>
        [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        double BgpAsn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#connection_id DxPublicVirtualInterface#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#name DxPublicVirtualInterface#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#route_filter_prefixes DxPublicVirtualInterface#route_filter_prefixes}.</summary>
        [JsiiProperty(name: "routeFilterPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RouteFilterPrefixes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#vlan DxPublicVirtualInterface#vlan}.</summary>
        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
        double Vlan
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#amazon_address DxPublicVirtualInterface#amazon_address}.</summary>
        [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmazonAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#bgp_auth_key DxPublicVirtualInterface#bgp_auth_key}.</summary>
        [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BgpAuthKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#customer_address DxPublicVirtualInterface#customer_address}.</summary>
        [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#tags DxPublicVirtualInterface#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#timeouts DxPublicVirtualInterface#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxPublicVirtualInterfaceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Directconnect.IDxPublicVirtualInterfaceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Direct Connect.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDxPublicVirtualInterfaceConfig), fullyQualifiedName: "aws.directconnect.DxPublicVirtualInterfaceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Directconnect.IDxPublicVirtualInterfaceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#address_family DxPublicVirtualInterface#address_family}.</summary>
            [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressFamily
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#bgp_asn DxPublicVirtualInterface#bgp_asn}.</summary>
            [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
            public double BgpAsn
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#connection_id DxPublicVirtualInterface#connection_id}.</summary>
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#name DxPublicVirtualInterface#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#route_filter_prefixes DxPublicVirtualInterface#route_filter_prefixes}.</summary>
            [JsiiProperty(name: "routeFilterPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RouteFilterPrefixes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#vlan DxPublicVirtualInterface#vlan}.</summary>
            [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
            public double Vlan
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#amazon_address DxPublicVirtualInterface#amazon_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmazonAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#bgp_auth_key DxPublicVirtualInterface#bgp_auth_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BgpAuthKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#customer_address DxPublicVirtualInterface#customer_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#tags DxPublicVirtualInterface#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_public_virtual_interface#timeouts DxPublicVirtualInterface#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxPublicVirtualInterfaceTimeouts\"}", isOptional: true)]
            public aws.Directconnect.IDxPublicVirtualInterfaceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Directconnect.IDxPublicVirtualInterfaceTimeouts?>();
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
