using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    /// <summary>AWS Kinesis.</summary>
    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamConfig")]
    public class KinesisFirehoseDeliveryStreamConfig : aws.Kinesis.IKinesisFirehoseDeliveryStreamConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#destination KinesisFirehoseDeliveryStream#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#name KinesisFirehoseDeliveryStream#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#arn KinesisFirehoseDeliveryStream#arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#destination_id KinesisFirehoseDeliveryStream#destination_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationId
        {
            get;
            set;
        }

        /// <summary>elasticsearch_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#elasticsearch_configuration KinesisFirehoseDeliveryStream#elasticsearch_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration? ElasticsearchConfiguration
        {
            get;
            set;
        }

        /// <summary>extended_s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#extended_s3_configuration KinesisFirehoseDeliveryStream#extended_s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extendedS3Configuration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration? ExtendedS3Configuration
        {
            get;
            set;
        }

        /// <summary>kinesis_source_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kinesis_source_configuration KinesisFirehoseDeliveryStream#kinesis_source_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisSourceConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration? KinesisSourceConfiguration
        {
            get;
            set;
        }

        /// <summary>redshift_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#redshift_configuration KinesisFirehoseDeliveryStream#redshift_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redshiftConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration? RedshiftConfiguration
        {
            get;
            set;
        }

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_configuration KinesisFirehoseDeliveryStream#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3Configuration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration? S3Configuration
        {
            get;
            set;
        }

        /// <summary>server_side_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#server_side_encryption KinesisFirehoseDeliveryStream#server_side_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamServerSideEncryption\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption? ServerSideEncryption
        {
            get;
            set;
        }

        /// <summary>splunk_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#splunk_configuration KinesisFirehoseDeliveryStream#splunk_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "splunkConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration? SplunkConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#tags KinesisFirehoseDeliveryStream#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#version_id KinesisFirehoseDeliveryStream#version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionId
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
