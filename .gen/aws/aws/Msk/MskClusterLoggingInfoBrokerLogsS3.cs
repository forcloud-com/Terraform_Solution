using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.msk.MskClusterLoggingInfoBrokerLogsS3")]
    public class MskClusterLoggingInfoBrokerLogsS3 : aws.Msk.IMskClusterLoggingInfoBrokerLogsS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enabled MskCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#bucket MskCluster#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#prefix MskCluster#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
