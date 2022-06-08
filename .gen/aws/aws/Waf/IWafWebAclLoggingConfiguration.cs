using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafWebAclLoggingConfiguration), fullyQualifiedName: "aws.waf.WafWebAclLoggingConfiguration")]
    public interface IWafWebAclLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#log_destination WafWebAcl#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        string LogDestination
        {
            get;
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#redacted_fields WafWebAcl#redacted_fields}
        /// </remarks>
        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Waf.IWafWebAclLoggingConfigurationRedactedFields? RedactedFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclLoggingConfiguration), fullyQualifiedName: "aws.waf.WafWebAclLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafWebAclLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#log_destination WafWebAcl#log_destination}.</summary>
            [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
            public string LogDestination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>redacted_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#redacted_fields WafWebAcl#redacted_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
            public aws.Waf.IWafWebAclLoggingConfigurationRedactedFields? RedactedFields
            {
                get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfigurationRedactedFields?>();
            }
        }
    }
}
