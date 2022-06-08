using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.SpotFleetRequestLaunchTemplateConfig")]
    public class SpotFleetRequestLaunchTemplateConfig : aws.Ec2.ISpotFleetRequestLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#launch_template_specification SpotFleetRequest#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"}")]
        public aws.Ec2.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification LaunchTemplateSpecification
        {
            get;
            set;
        }

        /// <summary>overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#overrides SpotFleetRequest#overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Overrides
        {
            get;
            set;
        }
    }
}
