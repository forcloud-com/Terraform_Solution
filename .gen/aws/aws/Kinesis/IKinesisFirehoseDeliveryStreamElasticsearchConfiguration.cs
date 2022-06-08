using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamElasticsearchConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#domain_arn KinesisFirehoseDeliveryStream#domain_arn}.</summary>
        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
        string DomainArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#index_name KinesisFirehoseDeliveryStream#index_name}.</summary>
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
        string IndexName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#role_arn KinesisFirehoseDeliveryStream#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffering_interval KinesisFirehoseDeliveryStream#buffering_interval}.</summary>
        [JsiiProperty(name: "bufferingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferingInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffering_size KinesisFirehoseDeliveryStream#buffering_size}.</summary>
        [JsiiProperty(name: "bufferingSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferingSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#index_rotation_period KinesisFirehoseDeliveryStream#index_rotation_period}.</summary>
        [JsiiProperty(name: "indexRotationPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexRotationPeriod
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
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration? ProcessingConfiguration
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#type_name KinesisFirehoseDeliveryStream#type_name}.</summary>
        [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TypeName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#domain_arn KinesisFirehoseDeliveryStream#domain_arn}.</summary>
            [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#index_name KinesisFirehoseDeliveryStream#index_name}.</summary>
            [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
            public string IndexName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#role_arn KinesisFirehoseDeliveryStream#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffering_interval KinesisFirehoseDeliveryStream#buffering_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bufferingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferingInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffering_size KinesisFirehoseDeliveryStream#buffering_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bufferingSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferingSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>cloudwatch_logging_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#index_rotation_period KinesisFirehoseDeliveryStream#index_rotation_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indexRotationPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexRotationPeriod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>processing_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processing_configuration KinesisFirehoseDeliveryStream#processing_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration? ProcessingConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration?>();
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#type_name KinesisFirehoseDeliveryStream#type_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TypeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
