using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfoBrokerLogs), fullyQualifiedName: "aws.msk.MskClusterLoggingInfoBrokerLogs")]
    public interface IMskClusterLoggingInfoBrokerLogs
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#cloudwatch_logs MskCluster#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#firehose MskCluster#firehose}
        /// </remarks>
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#s3 MskCluster#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterLoggingInfoBrokerLogsS3? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfoBrokerLogs), fullyQualifiedName: "aws.msk.MskClusterLoggingInfoBrokerLogs")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterLoggingInfoBrokerLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#cloudwatch_logs MskCluster#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}", isOptional: true)]
            public aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs?>();
            }

            /// <summary>firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#firehose MskCluster#firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsFirehose\"}", isOptional: true)]
            public aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose? Firehose
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#s3 MskCluster#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsS3\"}", isOptional: true)]
            public aws.Msk.IMskClusterLoggingInfoBrokerLogsS3? S3
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogsS3?>();
            }
        }
    }
}
