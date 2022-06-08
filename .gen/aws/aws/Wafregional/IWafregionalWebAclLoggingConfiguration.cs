using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclLoggingConfiguration), fullyQualifiedName: "aws.wafregional.WafregionalWebAclLoggingConfiguration")]
    public interface IWafregionalWebAclLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#log_destination WafregionalWebAcl#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        string LogDestination
        {
            get;
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#redacted_fields WafregionalWebAcl#redacted_fields}
        /// </remarks>
        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields? RedactedFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclLoggingConfiguration), fullyQualifiedName: "aws.wafregional.WafregionalWebAclLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalWebAclLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#log_destination WafregionalWebAcl#log_destination}.</summary>
            [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
            public string LogDestination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>redacted_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#redacted_fields WafregionalWebAcl#redacted_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
            public aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields? RedactedFields
            {
                get => GetInstanceProperty<aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields?>();
            }
        }
    }
}
