using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiByValue(fqn: "aws.msk.MskClusterEncryptionInfoEncryptionInTransit")]
    public class MskClusterEncryptionInfoEncryptionInTransit : aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#client_broker MskCluster#client_broker}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientBroker", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientBroker
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#in_cluster MskCluster#in_cluster}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InCluster
        {
            get;
            set;
        }
    }
}
