using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    /// <summary>AWS Direct Connect.</summary>
    [JsiiInterface(nativeType: typeof(IDxHostedPrivateVirtualInterfaceAccepterConfig), fullyQualifiedName: "aws.directconnect.DxHostedPrivateVirtualInterfaceAccepterConfig")]
    public interface IDxHostedPrivateVirtualInterfaceAccepterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#virtual_interface_id DxHostedPrivateVirtualInterfaceAccepter#virtual_interface_id}.</summary>
        [JsiiProperty(name: "virtualInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualInterfaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#dx_gateway_id DxHostedPrivateVirtualInterfaceAccepter#dx_gateway_id}.</summary>
        [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DxGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#tags DxHostedPrivateVirtualInterfaceAccepter#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#timeouts DxHostedPrivateVirtualInterfaceAccepter#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedPrivateVirtualInterfaceAccepterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Directconnect.IDxHostedPrivateVirtualInterfaceAccepterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#vpn_gateway_id DxHostedPrivateVirtualInterfaceAccepter#vpn_gateway_id}.</summary>
        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpnGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Direct Connect.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDxHostedPrivateVirtualInterfaceAccepterConfig), fullyQualifiedName: "aws.directconnect.DxHostedPrivateVirtualInterfaceAccepterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Directconnect.IDxHostedPrivateVirtualInterfaceAccepterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#virtual_interface_id DxHostedPrivateVirtualInterfaceAccepter#virtual_interface_id}.</summary>
            [JsiiProperty(name: "virtualInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualInterfaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#dx_gateway_id DxHostedPrivateVirtualInterfaceAccepter#dx_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DxGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#tags DxHostedPrivateVirtualInterfaceAccepter#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#timeouts DxHostedPrivateVirtualInterfaceAccepter#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedPrivateVirtualInterfaceAccepterTimeouts\"}", isOptional: true)]
            public aws.Directconnect.IDxHostedPrivateVirtualInterfaceAccepterTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Directconnect.IDxHostedPrivateVirtualInterfaceAccepterTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#vpn_gateway_id DxHostedPrivateVirtualInterfaceAccepter#vpn_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpnGatewayId
            {
                get => GetInstanceProperty<string?>();
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
