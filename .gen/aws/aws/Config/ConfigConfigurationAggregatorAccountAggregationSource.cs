using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.config.ConfigConfigurationAggregatorAccountAggregationSource")]
    public class ConfigConfigurationAggregatorAccountAggregationSource : aws.Config.IConfigConfigurationAggregatorAccountAggregationSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#account_ids ConfigConfigurationAggregator#account_ids}.</summary>
        [JsiiProperty(name: "accountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AccountIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#all_regions ConfigConfigurationAggregator#all_regions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allRegions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllRegions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#regions ConfigConfigurationAggregator#regions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Regions
        {
            get;
            set;
        }
    }
}
