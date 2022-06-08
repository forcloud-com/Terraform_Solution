using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    [JsiiByValue(fqn: "aws.directconnect.DxHostedPrivateVirtualInterfaceAccepterTimeouts")]
    public class DxHostedPrivateVirtualInterfaceAccepterTimeouts : aws.Directconnect.IDxHostedPrivateVirtualInterfaceAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#create DxHostedPrivateVirtualInterfaceAccepter#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_private_virtual_interface_accepter#delete DxHostedPrivateVirtualInterfaceAccepter#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
