using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3Configuration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#bucket_arn KinesisFirehoseDeliveryStream#bucket_arn}.</summary>
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        string BucketArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#role_arn KinesisFirehoseDeliveryStream#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffer_interval KinesisFirehoseDeliveryStream#buffer_interval}.</summary>
        [JsiiProperty(name: "bufferInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffer_size KinesisFirehoseDeliveryStream#buffer_size}.</summary>
        [JsiiProperty(name: "bufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferSize
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
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#compression_format KinesisFirehoseDeliveryStream#compression_format}.</summary>
        [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_format_conversion_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#data_format_conversion_configuration KinesisFirehoseDeliveryStream#data_format_conversion_configuration}
        /// </remarks>
        [JsiiProperty(name: "dataFormatConversionConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration? DataFormatConversionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#error_output_prefix KinesisFirehoseDeliveryStream#error_output_prefix}.</summary>
        [JsiiProperty(name: "errorOutputPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ErrorOutputPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kms_key_arn KinesisFirehoseDeliveryStream#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#prefix KinesisFirehoseDeliveryStream#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
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
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration? ProcessingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_backup_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_backup_configuration KinesisFirehoseDeliveryStream#s3_backup_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration? S3BackupConfiguration
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

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3Configuration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#bucket_arn KinesisFirehoseDeliveryStream#bucket_arn}.</summary>
            [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#role_arn KinesisFirehoseDeliveryStream#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffer_interval KinesisFirehoseDeliveryStream#buffer_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bufferInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#buffer_size KinesisFirehoseDeliveryStream#buffer_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>cloudwatch_logging_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#compression_format KinesisFirehoseDeliveryStream#compression_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>data_format_conversion_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#data_format_conversion_configuration KinesisFirehoseDeliveryStream#data_format_conversion_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataFormatConversionConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration? DataFormatConversionConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#error_output_prefix KinesisFirehoseDeliveryStream#error_output_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorOutputPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ErrorOutputPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kms_key_arn KinesisFirehoseDeliveryStream#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#prefix KinesisFirehoseDeliveryStream#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>processing_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processing_configuration KinesisFirehoseDeliveryStream#processing_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration? ProcessingConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration?>();
            }

            /// <summary>s3_backup_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_backup_configuration KinesisFirehoseDeliveryStream#s3_backup_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration? S3BackupConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration?>();
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
