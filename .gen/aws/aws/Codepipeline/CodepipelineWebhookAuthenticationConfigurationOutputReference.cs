using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineWebhookAuthenticationConfigurationOutputReference), fullyQualifiedName: "aws.codepipeline.CodepipelineWebhookAuthenticationConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodepipelineWebhookAuthenticationConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodepipelineWebhookAuthenticationConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineWebhookAuthenticationConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineWebhookAuthenticationConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowedIpRange")]
        public virtual void ResetAllowedIpRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretToken")]
        public virtual void ResetSecretToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedIpRangeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllowedIpRangeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedIpRange
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineWebhookAuthenticationConfiguration\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
