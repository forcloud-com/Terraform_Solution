using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiClass(nativeType: typeof(aws.Dms.DmsEndpointKafkaSettingsOutputReference), fullyQualifiedName: "aws.dms.DmsEndpointKafkaSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DmsEndpointKafkaSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DmsEndpointKafkaSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointKafkaSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointKafkaSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTopic")]
        public virtual void ResetTopic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrokerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TopicInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "broker", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Broker
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Topic
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKafkaSettings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointKafkaSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointKafkaSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
