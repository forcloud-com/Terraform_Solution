using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiByValue(fqn: "aws.config.ConfigConfigRuleSourceSourceDetail")]
    public class ConfigConfigRuleSourceSourceDetail : aws.Config.IConfigConfigRuleSourceSourceDetail
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#event_source ConfigConfigRule#event_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#maximum_execution_frequency ConfigConfigRule#maximum_execution_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumExecutionFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#message_type ConfigConfigRule#message_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageType
        {
            get;
            set;
        }
    }
}
