using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLoggingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions\"}}]")]
        public virtual void PutCloudwatchLoggingOptions(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataFormatConversionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration\"}}]")]
        public virtual void PutDataFormatConversionConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration\"}}]")]
        public virtual void PutProcessingConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3BackupConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration\"}}]")]
        public virtual void PutS3BackupConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration)}, new object[]{@value});
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

        [JsiiMethod(name: "resetDataFormatConversionConfiguration")]
        public virtual void ResetDataFormatConversionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetErrorOutputPrefix")]
        public virtual void ResetErrorOutputPrefix()
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

        [JsiiMethod(name: "resetProcessingConfiguration")]
        public virtual void ResetProcessingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3BackupConfiguration")]
        public virtual void ResetS3BackupConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3BackupMode")]
        public virtual void ResetS3BackupMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptionsOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptionsOutputReference CloudwatchLoggingOptions
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "dataFormatConversionConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputReference DataFormatConversionConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationOutputReference ProcessingConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationOutputReference S3BackupConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationOutputReference>()!;
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
        [JsiiProperty(name: "cloudwatchLoggingOptionsInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptionsInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompressionFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataFormatConversionConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration? DataFormatConversionConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorOutputPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorOutputPrefixInput
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
        [JsiiProperty(name: "processingConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration? ProcessingConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration? S3BackupConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BackupModeInput
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

        [JsiiProperty(name: "errorOutputPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorOutputPrefix
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

        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3BackupMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3Configuration?>();
            set => SetInstanceProperty(value);
        }
    }
}
