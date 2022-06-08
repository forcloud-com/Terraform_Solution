using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiClass(nativeType: typeof(aws.Iot.IotTopicRuleErrorActionFirehoseOutputReference), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionFirehoseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotTopicRuleErrorActionFirehoseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotTopicRuleErrorActionFirehoseOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionFirehoseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionFirehoseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSeparator")]
        public virtual void ResetSeparator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryStreamNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeliveryStreamNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "separatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SeparatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeliveryStreamName
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

        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Separator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionFirehose? InternalValue
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionFirehose?>();
            set => SetInstanceProperty(value);
        }
    }
}
