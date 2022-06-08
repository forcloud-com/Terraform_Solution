using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.LaunchTemplateInstanceMarketOptionsOutputReference), fullyQualifiedName: "aws.ec2.LaunchTemplateInstanceMarketOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LaunchTemplateInstanceMarketOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LaunchTemplateInstanceMarketOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateInstanceMarketOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateInstanceMarketOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSpotOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptionsSpotOptions\"}}]")]
        public virtual void PutSpotOptions(aws.Ec2.ILaunchTemplateInstanceMarketOptionsSpotOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateInstanceMarketOptionsSpotOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMarketType")]
        public virtual void ResetMarketType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotOptions")]
        public virtual void ResetSpotOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference SpotOptions
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MarketTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotOptionsInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateInstanceMarketOptionsSpotOptions? SpotOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateInstanceMarketOptionsSpotOptions?>();
        }

        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MarketType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptions\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateInstanceMarketOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateInstanceMarketOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
