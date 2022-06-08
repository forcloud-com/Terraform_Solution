using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.Ec2FleetSpotOptions")]
    public class Ec2FleetSpotOptions : aws.Ec2.IEc2FleetSpotOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#allocation_strategy Ec2Fleet#allocation_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllocationStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#instance_interruption_behavior Ec2Fleet#instance_interruption_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceInterruptionBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#instance_pools_to_use_count Ec2Fleet#instance_pools_to_use_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstancePoolsToUseCount
        {
            get;
            set;
        }
    }
}
