using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiClass(nativeType: typeof(aws.Config.ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference), fullyQualifiedName: "aws.config.ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDeliveryFrequency")]
        public virtual void ResetDeliveryFrequency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryFrequencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeliveryFrequencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deliveryFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeliveryFrequency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.config.ConfigDeliveryChannelSnapshotDeliveryProperties\"}", isOptional: true)]
        public virtual aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties? InternalValue
        {
            get => GetInstanceProperty<aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
