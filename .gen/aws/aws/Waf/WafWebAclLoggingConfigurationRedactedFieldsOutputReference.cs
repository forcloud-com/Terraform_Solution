using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiClass(nativeType: typeof(aws.Waf.WafWebAclLoggingConfigurationRedactedFieldsOutputReference), fullyQualifiedName: "aws.waf.WafWebAclLoggingConfigurationRedactedFieldsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WafWebAclLoggingConfigurationRedactedFieldsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WafWebAclLoggingConfigurationRedactedFieldsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAclLoggingConfigurationRedactedFieldsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAclLoggingConfigurationRedactedFieldsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FieldToMatchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
        public virtual object FieldToMatch
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public virtual aws.Waf.IWafWebAclLoggingConfigurationRedactedFields? InternalValue
        {
            get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfigurationRedactedFields?>();
            set => SetInstanceProperty(value);
        }
    }
}
