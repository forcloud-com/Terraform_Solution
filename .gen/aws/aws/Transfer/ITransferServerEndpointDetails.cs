using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    [JsiiInterface(nativeType: typeof(ITransferServerEndpointDetails), fullyQualifiedName: "aws.transfer.TransferServerEndpointDetails")]
    public interface ITransferServerEndpointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#vpc_endpoint_id TransferServer#vpc_endpoint_id}.</summary>
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcEndpointId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferServerEndpointDetails), fullyQualifiedName: "aws.transfer.TransferServerEndpointDetails")]
        internal sealed class _Proxy : DeputyBase, aws.Transfer.ITransferServerEndpointDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#vpc_endpoint_id TransferServer#vpc_endpoint_id}.</summary>
            [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
