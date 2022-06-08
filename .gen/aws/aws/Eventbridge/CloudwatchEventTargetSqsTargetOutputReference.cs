using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventTargetSqsTargetOutputReference), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetSqsTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventTargetSqsTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventTargetSqsTargetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTargetSqsTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTargetSqsTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMessageGroupId")]
        public virtual void ResetMessageGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MessageGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetSqsTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetSqsTarget? InternalValue
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetSqsTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
