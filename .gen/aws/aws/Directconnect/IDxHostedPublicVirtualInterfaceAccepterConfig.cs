using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    /// <summary>AWS Direct Connect.</summary>
    [JsiiInterface(nativeType: typeof(IDxHostedPublicVirtualInterfaceAccepterConfig), fullyQualifiedName: "aws.directconnect.DxHostedPublicVirtualInterfaceAccepterConfig")]
    public interface IDxHostedPublicVirtualInterfaceAccepterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#virtual_interface_id DxHostedPublicVirtualInterfaceAccepter#virtual_interface_id}.</summary>
        [JsiiProperty(name: "virtualInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualInterfaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#tags DxHostedPublicVirtualInterfaceAccepter#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#timeouts DxHostedPublicVirtualInterfaceAccepter#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedPublicVirtualInterfaceAccepterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Direct Connect.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDxHostedPublicVirtualInterfaceAccepterConfig), fullyQualifiedName: "aws.directconnect.DxHostedPublicVirtualInterfaceAccepterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#virtual_interface_id DxHostedPublicVirtualInterfaceAccepter#virtual_interface_id}.</summary>
            [JsiiProperty(name: "virtualInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualInterfaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#tags DxHostedPublicVirtualInterfaceAccepter#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#timeouts DxHostedPublicVirtualInterfaceAccepter#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedPublicVirtualInterfaceAccepterTimeouts\"}", isOptional: true)]
            public aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterTimeouts?>();
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
