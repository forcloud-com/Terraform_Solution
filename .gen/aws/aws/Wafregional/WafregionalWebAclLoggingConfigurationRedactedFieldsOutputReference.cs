using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiClass(nativeType: typeof(aws.Wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference), fullyQualifiedName: "aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FieldToMatchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
        public virtual object FieldToMatch
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public virtual aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields? InternalValue
        {
            get => GetInstanceProperty<aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields?>();
            set => SetInstanceProperty(value);
        }
    }
}
