using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.Ec2FleetLaunchTemplateConfig")]
    public class Ec2FleetLaunchTemplateConfig : aws.Ec2.IEc2FleetLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#launch_template_specification Ec2Fleet#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"}")]
        public aws.Ec2.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification LaunchTemplateSpecification
        {
            get;
            set;
        }

        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#override Ec2Fleet#override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Override
        {
            get;
            set;
        }
    }
}
