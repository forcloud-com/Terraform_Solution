using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiByValue(fqn: "aws.msk.MskClusterLoggingInfoBrokerLogs")]
    public class MskClusterLoggingInfoBrokerLogs : aws.Msk.IMskClusterLoggingInfoBrokerLogs
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#cloudwatch_logs MskCluster#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}", isOptional: true)]
        public aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#firehose MskCluster#firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsFirehose\"}", isOptional: true)]
        public aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose? Firehose
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#s3 MskCluster#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsS3\"}", isOptional: true)]
        public aws.Msk.IMskClusterLoggingInfoBrokerLogsS3? S3
        {
            get;
            set;
        }
    }
}
