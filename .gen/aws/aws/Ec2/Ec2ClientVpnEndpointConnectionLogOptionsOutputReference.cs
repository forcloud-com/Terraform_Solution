using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2ClientVpnEndpointConnectionLogOptionsOutputReference), fullyQualifiedName: "aws.ec2.Ec2ClientVpnEndpointConnectionLogOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Ec2ClientVpnEndpointConnectionLogOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Ec2ClientVpnEndpointConnectionLogOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2ClientVpnEndpointConnectionLogOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2ClientVpnEndpointConnectionLogOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCloudwatchLogGroup")]
        public virtual void ResetCloudwatchLogGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchLogStream")]
        public virtual void ResetCloudwatchLogStream()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudwatchLogGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogStreamInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudwatchLogStreamInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cloudwatchLogGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLogGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudwatchLogStream", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLogStream
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.Ec2ClientVpnEndpointConnectionLogOptions\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2ClientVpnEndpointConnectionLogOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEc2ClientVpnEndpointConnectionLogOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
