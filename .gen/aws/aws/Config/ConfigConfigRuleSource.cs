using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.config.ConfigConfigRuleSource")]
    public class ConfigConfigRuleSource : aws.Config.IConfigConfigRuleSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#owner ConfigConfigRule#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public string Owner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#source_identifier ConfigConfigRule#source_identifier}.</summary>
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceIdentifier
        {
            get;
            set;
        }

        /// <summary>source_detail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#source_detail ConfigConfigRule#source_detail}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDetail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.config.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceDetail
        {
            get;
            set;
        }
    }
}
