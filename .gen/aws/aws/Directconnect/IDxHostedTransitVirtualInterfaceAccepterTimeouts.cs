using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    [JsiiInterface(nativeType: typeof(IDxHostedTransitVirtualInterfaceAccepterTimeouts), fullyQualifiedName: "aws.directconnect.DxHostedTransitVirtualInterfaceAccepterTimeouts")]
    public interface IDxHostedTransitVirtualInterfaceAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface_accepter#create DxHostedTransitVirtualInterfaceAccepter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface_accepter#delete DxHostedTransitVirtualInterfaceAccepter#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDxHostedTransitVirtualInterfaceAccepterTimeouts), fullyQualifiedName: "aws.directconnect.DxHostedTransitVirtualInterfaceAccepterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Directconnect.IDxHostedTransitVirtualInterfaceAccepterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface_accepter#create DxHostedTransitVirtualInterfaceAccepter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_transit_virtual_interface_accepter#delete DxHostedTransitVirtualInterfaceAccepter#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}