using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.config.ConfigConfigurationAggregatorOrganizationAggregationSource")]
    public class ConfigConfigurationAggregatorOrganizationAggregationSource : aws.Config.IConfigConfigurationAggregatorOrganizationAggregationSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#role_arn ConfigConfigurationAggregator#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
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
