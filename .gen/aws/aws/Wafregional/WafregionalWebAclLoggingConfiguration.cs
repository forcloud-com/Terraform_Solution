using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregional.WafregionalWebAclLoggingConfiguration")]
    public class WafregionalWebAclLoggingConfiguration : aws.Wafregional.IWafregionalWebAclLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#log_destination WafregionalWebAcl#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        public string LogDestination
        {
            get;
            set;
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl#redacted_fields WafregionalWebAcl#redacted_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public aws.Wafregional.IWafregionalWebAclLoggingConfigurationRedactedFields? RedactedFields
        {
            get;
            set;
        }
    }
}
