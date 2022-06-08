using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiClass(nativeType: typeof(aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNotificationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig\"}}]")]
        public virtual void PutNotificationConfig(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComment")]
        public virtual void ResetComment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocumentHash")]
        public virtual void ResetDocumentHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocumentHashType")]
        public virtual void ResetDocumentHashType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationConfig")]
        public virtual void ResetNotificationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputS3Bucket")]
        public virtual void ResetOutputS3Bucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputS3KeyPrefix")]
        public virtual void ResetOutputS3KeyPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameter")]
        public virtual void ResetParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRoleArn")]
        public virtual void ResetServiceRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutSeconds")]
        public virtual void ResetTimeoutSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "notificationConfig", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfigOutputReference\"}")]
        public virtual aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfigOutputReference NotificationConfig
        {
            get => GetInstanceProperty<aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentHashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocumentHashInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentHashTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocumentHashTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationConfigInput", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig? NotificationConfigInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputS3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputS3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputS3KeyPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputS3KeyPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ParameterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "documentHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentHash
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "documentHashType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentHashType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputS3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputS3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputS3KeyPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputS3KeyPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter\"},\"kind\":\"array\"}}]}}")]
        public virtual object Parameter
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
