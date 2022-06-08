using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiClass(nativeType: typeof(aws.Waf.WafWebAclLoggingConfigurationOutputReference), fullyQualifiedName: "aws.waf.WafWebAclLoggingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WafWebAclLoggingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WafWebAclLoggingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAclLoggingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAclLoggingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRedactedFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFields\"}}]")]
        public virtual void PutRedactedFields(aws.Waf.IWafWebAclLoggingConfigurationRedactedFields @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Waf.IWafWebAclLoggingConfigurationRedactedFields)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRedactedFields")]
        public virtual void ResetRedactedFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFieldsOutputReference\"}")]
        public virtual aws.Waf.WafWebAclLoggingConfigurationRedactedFieldsOutputReference RedactedFields
        {
            get => GetInstanceProperty<aws.Waf.WafWebAclLoggingConfigurationRedactedFieldsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDestinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogDestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redactedFieldsInput", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public virtual aws.Waf.IWafWebAclLoggingConfigurationRedactedFields? RedactedFieldsInput
        {
            get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfigurationRedactedFields?>();
        }

        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogDestination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Waf.IWafWebAclLoggingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
