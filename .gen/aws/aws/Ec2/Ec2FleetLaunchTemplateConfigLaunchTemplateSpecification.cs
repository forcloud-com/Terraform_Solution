using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification")]
    public class Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification : aws.Ec2.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#version Ec2Fleet#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#launch_template_id Ec2Fleet#launch_template_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LaunchTemplateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#launch_template_name Ec2Fleet#launch_template_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LaunchTemplateName
        {
            get;
            set;
        }
    }
}
