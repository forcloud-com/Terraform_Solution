using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventTargetBatchTargetOutputReference), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetBatchTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventTargetBatchTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventTargetBatchTargetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTargetBatchTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTargetBatchTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetArraySize")]
        public virtual void ResetArraySize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobAttempts")]
        public virtual void ResetJobAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "arraySizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ArraySizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? JobAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arraySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ArraySize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JobAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetBatchTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetBatchTarget? InternalValue
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetBatchTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
