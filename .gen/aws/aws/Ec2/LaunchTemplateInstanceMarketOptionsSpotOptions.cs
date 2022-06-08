using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateInstanceMarketOptionsSpotOptions")]
    public class LaunchTemplateInstanceMarketOptionsSpotOptions : aws.Ec2.ILaunchTemplateInstanceMarketOptionsSpotOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#block_duration_minutes LaunchTemplate#block_duration_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BlockDurationMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#instance_interruption_behavior LaunchTemplate#instance_interruption_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceInterruptionBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#max_price LaunchTemplate#max_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxPrice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#spot_instance_type LaunchTemplate#spot_instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpotInstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#valid_until LaunchTemplate#valid_until}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValidUntil
        {
            get;
            set;
        }
    }
}
