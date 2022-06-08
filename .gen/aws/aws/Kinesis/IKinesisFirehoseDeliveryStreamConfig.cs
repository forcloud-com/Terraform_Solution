using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    /// <summary>AWS Kinesis.</summary>
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamConfig), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamConfig")]
    public interface IKinesisFirehoseDeliveryStreamConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#destination KinesisFirehoseDeliveryStream#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#name KinesisFirehoseDeliveryStream#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#arn KinesisFirehoseDeliveryStream#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Arn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#destination_id KinesisFirehoseDeliveryStream#destination_id}.</summary>
        [JsiiProperty(name: "destinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#elasticsearch_configuration KinesisFirehoseDeliveryStream#elasticsearch_configuration}
        /// </remarks>
        [JsiiProperty(name: "elasticsearchConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration? ElasticsearchConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>extended_s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#extended_s3_configuration KinesisFirehoseDeliveryStream#extended_s3_configuration}
        /// </remarks>
        [JsiiProperty(name: "extendedS3Configuration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration? ExtendedS3Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_source_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kinesis_source_configuration KinesisFirehoseDeliveryStream#kinesis_source_configuration}
        /// </remarks>
        [JsiiProperty(name: "kinesisSourceConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration? KinesisSourceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#redshift_configuration KinesisFirehoseDeliveryStream#redshift_configuration}
        /// </remarks>
        [JsiiProperty(name: "redshiftConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration? RedshiftConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_configuration KinesisFirehoseDeliveryStream#s3_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3Configuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration? S3Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_side_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#server_side_encryption KinesisFirehoseDeliveryStream#server_side_encryption}
        /// </remarks>
        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamServerSideEncryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption? ServerSideEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>splunk_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#splunk_configuration KinesisFirehoseDeliveryStream#splunk_configuration}
        /// </remarks>
        [JsiiProperty(name: "splunkConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration? SplunkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#tags KinesisFirehoseDeliveryStream#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#version_id KinesisFirehoseDeliveryStream#version_id}.</summary>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Kinesis.</summary>
        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamConfig), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#destination KinesisFirehoseDeliveryStream#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#name KinesisFirehoseDeliveryStream#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#arn KinesisFirehoseDeliveryStream#arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Arn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#destination_id KinesisFirehoseDeliveryStream#destination_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>elasticsearch_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#elasticsearch_configuration KinesisFirehoseDeliveryStream#elasticsearch_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration? ElasticsearchConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration?>();
            }

            /// <summary>extended_s3_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#extended_s3_configuration KinesisFirehoseDeliveryStream#extended_s3_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extendedS3Configuration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration? ExtendedS3Configuration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration?>();
            }

            /// <summary>kinesis_source_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kinesis_source_configuration KinesisFirehoseDeliveryStream#kinesis_source_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisSourceConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration? KinesisSourceConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration?>();
            }

            /// <summary>redshift_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#redshift_configuration KinesisFirehoseDeliveryStream#redshift_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redshiftConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration? RedshiftConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration?>();
            }

            /// <summary>s3_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_configuration KinesisFirehoseDeliveryStream#s3_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3Configuration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration? S3Configuration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration?>();
            }

            /// <summary>server_side_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#server_side_encryption KinesisFirehoseDeliveryStream#server_side_encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamServerSideEncryption\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption? ServerSideEncryption
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption?>();
            }

            /// <summary>splunk_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#splunk_configuration KinesisFirehoseDeliveryStream#splunk_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "splunkConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration? SplunkConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#tags KinesisFirehoseDeliveryStream#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#version_id KinesisFirehoseDeliveryStream#version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
