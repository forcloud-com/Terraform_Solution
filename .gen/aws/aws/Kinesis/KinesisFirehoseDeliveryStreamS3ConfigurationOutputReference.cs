using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamS3ConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLoggingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions\"}}]")]
        public virtual void PutCloudwatchLoggingOptions(aws.Kinesis.IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBufferInterval")]
        public virtual void ResetBufferInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBufferSize")]
        public virtual void ResetBufferSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchLoggingOptions")]
        public virtual void ResetCloudwatchLoggingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompressionFormat")]
        public virtual void ResetCompressionFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptionsOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptionsOutputReference CloudwatchLoggingOptions
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufferIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BufferIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufferSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BufferSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptionsInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptionsInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompressionFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bufferInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BufferInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bufferSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BufferSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompressionFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamS3Configuration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamS3Configuration?>();
            set => SetInstanceProperty(value);
        }
    }
}
