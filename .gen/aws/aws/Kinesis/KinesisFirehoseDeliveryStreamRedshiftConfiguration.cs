using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfiguration")]
    public class KinesisFirehoseDeliveryStreamRedshiftConfiguration : aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cluster_jdbcurl KinesisFirehoseDeliveryStream#cluster_jdbcurl}.</summary>
        [JsiiProperty(name: "clusterJdbcurl", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterJdbcurl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#data_table_name KinesisFirehoseDeliveryStream#data_table_name}.</summary>
        [JsiiProperty(name: "dataTableName", typeJson: "{\"primitive\":\"string\"}")]
        public string DataTableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#password KinesisFirehoseDeliveryStream#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#username KinesisFirehoseDeliveryStream#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#copy_options KinesisFirehoseDeliveryStream#copy_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CopyOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#data_table_columns KinesisFirehoseDeliveryStream#data_table_columns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataTableColumns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataTableColumns
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processing_configuration KinesisFirehoseDeliveryStream#processing_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration? ProcessingConfiguration
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

        /// <summary>s3_backup_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_backup_configuration KinesisFirehoseDeliveryStream#s3_backup_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration? S3BackupConfiguration
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
