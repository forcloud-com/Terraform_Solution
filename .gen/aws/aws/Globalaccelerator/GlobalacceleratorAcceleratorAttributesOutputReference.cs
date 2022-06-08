using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    [JsiiClass(nativeType: typeof(aws.Globalaccelerator.GlobalacceleratorAcceleratorAttributesOutputReference), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorAcceleratorAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlobalacceleratorAcceleratorAttributesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlobalacceleratorAcceleratorAttributesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorAcceleratorAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorAcceleratorAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFlowLogsEnabled")]
        public virtual void ResetFlowLogsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlowLogsS3Bucket")]
        public virtual void ResetFlowLogsS3Bucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlowLogsS3Prefix")]
        public virtual void ResetFlowLogsS3Prefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowLogsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FlowLogsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowLogsS3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FlowLogsS3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowLogsS3PrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FlowLogsS3PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "flowLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FlowLogsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "flowLogsS3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowLogsS3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "flowLogsS3Prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowLogsS3Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorAcceleratorAttributes\"}", isOptional: true)]
        public virtual aws.Globalaccelerator.IGlobalacceleratorAcceleratorAttributes? InternalValue
        {
            get => GetInstanceProperty<aws.Globalaccelerator.IGlobalacceleratorAcceleratorAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
