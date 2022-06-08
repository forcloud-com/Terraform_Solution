using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLoggingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions\"}}]")]
        public virtual void PutCloudwatchLoggingOptions(aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration\"}}]")]
        public virtual void PutProcessingConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLoggingOptions")]
        public virtual void ResetCloudwatchLoggingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHecAcknowledgmentTimeout")]
        public virtual void ResetHecAcknowledgmentTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHecEndpointType")]
        public virtual void ResetHecEndpointType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessingConfiguration")]
        public virtual void ResetProcessingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryDuration")]
        public virtual void ResetRetryDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3BackupMode")]
        public virtual void ResetS3BackupMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptionsOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptionsOutputReference CloudwatchLoggingOptions
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationOutputReference ProcessingConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptionsInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptionsInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hecAcknowledgmentTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HecAcknowledgmentTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hecEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HecEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hecEndpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HecEndpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hecTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HecTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processingConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration? ProcessingConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetryDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BackupModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hecAcknowledgmentTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HecAcknowledgmentTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hecEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HecEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hecEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HecEndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hecToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HecToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3BackupMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
