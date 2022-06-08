using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader")]
    public class Wafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader : aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#name Wafv2WebAclLoggingConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
