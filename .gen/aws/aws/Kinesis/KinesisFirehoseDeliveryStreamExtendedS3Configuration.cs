using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration")]
    public class KinesisFirehoseDeliveryStreamExtendedS3Configuration : aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#bucket_arn KinesisFirehoseDeliveryStream#bucket_arn}.</summary>
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketArn
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffer_interval KinesisFirehoseDeliveryStream#buffer_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffer_size KinesisFirehoseDeliveryStream#buffer_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferSize
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#compression_format KinesisFirehoseDeliveryStream#compression_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionFormat
        {
            get;
            set;
        }

        /// <summary>data_format_conversion_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#data_format_conversion_configuration KinesisFirehoseDeliveryStream#data_format_conversion_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataFormatConversionConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration? DataFormatConversionConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#error_output_prefix KinesisFirehoseDeliveryStream#error_output_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorOutputPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ErrorOutputPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kms_key_arn KinesisFirehoseDeliveryStream#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#prefix KinesisFirehoseDeliveryStream#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processing_configuration KinesisFirehoseDeliveryStream#processing_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration? ProcessingConfiguration
        {
            get;
            set;
        }

        /// <summary>s3_backup_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_backup_configuration KinesisFirehoseDeliveryStream#s3_backup_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration? S3BackupConfiguration
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
    }
}
