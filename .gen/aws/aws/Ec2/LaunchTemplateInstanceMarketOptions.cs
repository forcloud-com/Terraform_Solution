using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateInstanceMarketOptions")]
    public class LaunchTemplateInstanceMarketOptions : aws.Ec2.ILaunchTemplateInstanceMarketOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#market_type LaunchTemplate#market_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MarketType
        {
            get;
            set;
        }

        /// <summary>spot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#spot_options LaunchTemplate#spot_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateInstanceMarketOptionsSpotOptions? SpotOptions
        {
            get;
            set;
        }
    }
}
