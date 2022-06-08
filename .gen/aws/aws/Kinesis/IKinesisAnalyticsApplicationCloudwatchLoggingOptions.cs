using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationCloudwatchLoggingOptions), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptions")]
    public interface IKinesisAnalyticsApplicationCloudwatchLoggingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#log_stream_arn KinesisAnalyticsApplication#log_stream_arn}.</summary>
        [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogStreamArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#role_arn KinesisAnalyticsApplication#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationCloudwatchLoggingOptions), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#log_stream_arn KinesisAnalyticsApplication#log_stream_arn}.</summary>
            [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogStreamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#role_arn KinesisAnalyticsApplication#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
