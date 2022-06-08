using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLoggingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions\"}}]")]
        public virtual void PutCloudwatchLoggingOptions(aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration\"}}]")]
        public virtual void PutProcessingConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3BackupConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration\"}}]")]
        public virtual void PutS3BackupConfiguration(aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLoggingOptions")]
        public virtual void ResetCloudwatchLoggingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCopyOptions")]
        public virtual void ResetCopyOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataTableColumns")]
        public virtual void ResetDataTableColumns()
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

        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptionsOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptionsOutputReference CloudwatchLoggingOptions
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationOutputReference ProcessingConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationOutputReference S3BackupConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptionsInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptionsInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterJdbcurlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterJdbcurlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyOptionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CopyOptionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTableColumnsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataTableColumnsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataTableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processingConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration? ProcessingConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetryDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration? S3BackupConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BackupModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterJdbcurl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterJdbcurl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "copyOptions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CopyOptions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataTableColumns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataTableColumns
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataTableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataTableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
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

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
