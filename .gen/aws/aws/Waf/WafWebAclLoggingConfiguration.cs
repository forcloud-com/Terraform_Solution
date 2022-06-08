using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.waf.WafWebAclLoggingConfiguration")]
    public class WafWebAclLoggingConfiguration : aws.Waf.IWafWebAclLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#log_destination WafWebAcl#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        public string LogDestination
        {
            get;
            set;
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#redacted_fields WafWebAcl#redacted_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public aws.Waf.IWafWebAclLoggingConfigurationRedactedFields? RedactedFields
        {
            get;
            set;
        }
    }
}
