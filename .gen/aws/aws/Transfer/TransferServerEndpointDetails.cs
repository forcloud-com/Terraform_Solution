using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transfer.TransferServerEndpointDetails")]
    public class TransferServerEndpointDetails : aws.Transfer.ITransferServerEndpointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#vpc_endpoint_id TransferServer#vpc_endpoint_id}.</summary>
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcEndpointId
        {
            get;
            set;
        }
    }
}
