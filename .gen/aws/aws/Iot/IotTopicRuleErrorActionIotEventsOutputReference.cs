using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiClass(nativeType: typeof(aws.Iot.IotTopicRuleErrorActionIotEventsOutputReference), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionIotEventsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotTopicRuleErrorActionIotEventsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotTopicRuleErrorActionIotEventsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionIotEventsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionIotEventsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMessageId")]
        public virtual void ResetMessageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MessageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "inputName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageId
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionIotEvents? InternalValue
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionIotEvents?>();
            set => SetInstanceProperty(value);
        }
    }
}
