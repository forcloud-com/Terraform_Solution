using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfiguration")]
    public class KinesisFirehoseDeliveryStreamElasticsearchConfiguration : aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#domain_arn KinesisFirehoseDeliveryStream#domain_arn}.</summary>
        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#index_name KinesisFirehoseDeliveryStream#index_name}.</summary>
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
        public string IndexName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#role_arn KinesisFirehoseDeliveryStream#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffering_interval KinesisFirehoseDeliveryStream#buffering_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferingInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffering_size KinesisFirehoseDeliveryStream#buffering_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferingSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferingSize
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#index_rotation_period KinesisFirehoseDeliveryStream#index_rotation_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexRotationPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexRotationPeriod
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processing_configuration KinesisFirehoseDeliveryStream#processing_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration? ProcessingConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#retry_duration KinesisFirehoseDeliveryStream#retry_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_backup_mode KinesisFirehoseDeliveryStream#s3_backup_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3BackupMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#type_name KinesisFirehoseDeliveryStream#type_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TypeName
        {
            get;
            set;
        }
    }
}
