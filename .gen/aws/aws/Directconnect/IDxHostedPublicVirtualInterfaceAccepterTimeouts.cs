using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    [JsiiInterface(nativeType: typeof(IDxHostedPublicVirtualInterfaceAccepterTimeouts), fullyQualifiedName: "aws.directconnect.DxHostedPublicVirtualInterfaceAccepterTimeouts")]
    public interface IDxHostedPublicVirtualInterfaceAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#create DxHostedPublicVirtualInterfaceAccepter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#delete DxHostedPublicVirtualInterfaceAccepter#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDxHostedPublicVirtualInterfaceAccepterTimeouts), fullyQualifiedName: "aws.directconnect.DxHostedPublicVirtualInterfaceAccepterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#create DxHostedPublicVirtualInterfaceAccepter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter#delete DxHostedPublicVirtualInterfaceAccepter#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
