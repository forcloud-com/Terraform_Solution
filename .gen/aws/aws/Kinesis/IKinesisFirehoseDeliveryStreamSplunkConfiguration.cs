using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamSplunkConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamSplunkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_endpoint KinesisFirehoseDeliveryStream#hec_endpoint}.</summary>
        [JsiiProperty(name: "hecEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string HecEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_token KinesisFirehoseDeliveryStream#hec_token}.</summary>
        [JsiiProperty(name: "hecToken", typeJson: "{\"primitive\":\"string\"}")]
        string HecToken
        {
            get;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_acknowledgment_timeout KinesisFirehoseDeliveryStream#hec_acknowledgment_timeout}.</summary>
        [JsiiProperty(name: "hecAcknowledgmentTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HecAcknowledgmentTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_endpoint_type KinesisFirehoseDeliveryStream#hec_endpoint_type}.</summary>
        [JsiiProperty(name: "hecEndpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HecEndpointType
        {
            get
            {
                return null;
            }
        }

        /// <summary>processing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processing_configuration KinesisFirehoseDeliveryStream#processing_configuration}
        /// </remarks>
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration? ProcessingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#retry_duration KinesisFirehoseDeliveryStream#retry_duration}.</summary>
        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_backup_mode KinesisFirehoseDeliveryStream#s3_backup_mode}.</summary>
        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BackupMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamSplunkConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_endpoint KinesisFirehoseDeliveryStream#hec_endpoint}.</summary>
            [JsiiProperty(name: "hecEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string HecEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_token KinesisFirehoseDeliveryStream#hec_token}.</summary>
            [JsiiProperty(name: "hecToken", typeJson: "{\"primitive\":\"string\"}")]
            public string HecToken
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloudwatch_logging_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_acknowledgment_timeout KinesisFirehoseDeliveryStream#hec_acknowledgment_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hecAcknowledgmentTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HecAcknowledgmentTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_endpoint_type KinesisFirehoseDeliveryStream#hec_endpoint_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hecEndpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HecEndpointType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>processing_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processing_configuration KinesisFirehoseDeliveryStream#processing_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration? ProcessingConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#retry_duration KinesisFirehoseDeliveryStream#retry_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_backup_mode KinesisFirehoseDeliveryStream#s3_backup_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BackupMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
