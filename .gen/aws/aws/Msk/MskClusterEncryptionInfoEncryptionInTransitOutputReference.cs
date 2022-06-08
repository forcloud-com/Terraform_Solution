using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskClusterEncryptionInfoEncryptionInTransitOutputReference), fullyQualifiedName: "aws.msk.MskClusterEncryptionInfoEncryptionInTransitOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterEncryptionInfoEncryptionInTransitOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterEncryptionInfoEncryptionInTransitOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterEncryptionInfoEncryptionInTransitOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterEncryptionInfoEncryptionInTransitOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClientBroker")]
        public virtual void ResetClientBroker()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInCluster")]
        public virtual void ResetInCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientBrokerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientBrokerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inClusterInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InClusterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clientBroker", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientBroker
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InCluster
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfoEncryptionInTransit\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit?>();
            set => SetInstanceProperty(value);
        }
    }
}
