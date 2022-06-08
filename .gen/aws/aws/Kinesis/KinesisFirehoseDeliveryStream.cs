using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream aws_kinesis_firehose_delivery_stream}.</summary>
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisFirehoseDeliveryStream), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStream", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamConfig\"}}]")]
    public class KinesisFirehoseDeliveryStream : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream aws_kinesis_firehose_delivery_stream} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KinesisFirehoseDeliveryStream(Constructs.Construct scope, string id, aws.Kinesis.IKinesisFirehoseDeliveryStreamConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStream(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStream(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putElasticsearchConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"}}]")]
        public virtual void PutElasticsearchConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtendedS3Configuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"}}]")]
        public virtual void PutExtendedS3Configuration(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisSourceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"}}]")]
        public virtual void PutKinesisSourceConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshiftConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}}]")]
        public virtual void PutRedshiftConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Configuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3Configuration\"}}]")]
        public virtual void PutS3Configuration(aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerSideEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamServerSideEncryption\"}}]")]
        public virtual void PutServerSideEncryption(aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSplunkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration\"}}]")]
        public virtual void PutSplunkConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArn")]
        public virtual void ResetArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationId")]
        public virtual void ResetDestinationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchConfiguration")]
        public virtual void ResetElasticsearchConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtendedS3Configuration")]
        public virtual void ResetExtendedS3Configuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisSourceConfiguration")]
        public virtual void ResetKinesisSourceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshiftConfiguration")]
        public virtual void ResetRedshiftConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Configuration")]
        public virtual void ResetS3Configuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSplunkConfiguration")]
        public virtual void ResetSplunkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionId")]
        public virtual void ResetVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Kinesis.KinesisFirehoseDeliveryStream))!;

        [JsiiProperty(name: "elasticsearchConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationOutputReference ElasticsearchConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "extendedS3Configuration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference ExtendedS3Configuration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kinesisSourceConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfigurationOutputReference KinesisSourceConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "redshiftConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference RedshiftConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference S3Configuration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamServerSideEncryptionOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamServerSideEncryptionOutputReference ServerSideEncryption
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamServerSideEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "splunkConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference SplunkConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration? ElasticsearchConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendedS3ConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration? ExtendedS3ConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisSourceConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration? KinesisSourceConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration? RedshiftConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3Configuration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration? S3ConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamServerSideEncryption\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "splunkConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration? SplunkConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Destination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
