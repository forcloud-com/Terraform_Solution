using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.msk.MskClusterLoggingInfoBrokerLogsFirehose")]
    public class MskClusterLoggingInfoBrokerLogsFirehose : aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enabled MskCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#delivery_stream MskCluster#delivery_stream}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeliveryStream
        {
            get;
            set;
        }
    }
}
