using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.InstanceMetadataOptionsOutputReference), fullyQualifiedName: "aws.ec2.InstanceMetadataOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InstanceMetadataOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InstanceMetadataOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstanceMetadataOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstanceMetadataOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHttpEndpoint")]
        public virtual void ResetHttpEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpPutResponseHopLimit")]
        public virtual void ResetHttpPutResponseHopLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpTokens")]
        public virtual void ResetHttpTokens()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpPutResponseHopLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpPutResponseHopLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpTokensInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpTokensInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPutResponseHopLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpTokens
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.InstanceMetadataOptions\"}", isOptional: true)]
        public virtual aws.Ec2.IInstanceMetadataOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IInstanceMetadataOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
