using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFields")]
    public interface IWafregionalWebAclLoggingConfigurationRedactedFields
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#field_to_match WafregionalWebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
        object FieldToMatch
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#field_to_match WafregionalWebAcl#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
            public object FieldToMatch
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
