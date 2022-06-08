using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiClass(nativeType: typeof(aws.Wafregional.WafregionalWebAclLoggingConfigurationOutputReference), fullyQualifiedName: "aws.wafregional.WafregionalWebAclLoggingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WafregionalWebAclLoggingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WafregionalWebAclLoggingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAclLoggingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAclLoggingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRedactedFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFields\"}}]")]
        public virtual void PutRedactedFields(aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRedactedFields")]
        public virtual void ResetRedactedFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference\"}")]
        public virtual aws.Wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference RedactedFields
        {
            get => GetInstanceProperty<aws.Wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDestinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogDestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redactedFieldsInput", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public virtual aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields? RedactedFieldsInput
        {
            get => GetInstanceProperty<aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields?>();
        }

        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogDestination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Wafregional.IWafregionalWebAclLoggingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Wafregional.IWafregionalWebAclLoggingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
