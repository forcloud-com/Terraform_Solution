using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.Ec2FleetOnDemandOptions")]
    public class Ec2FleetOnDemandOptions : aws.Ec2.IEc2FleetOnDemandOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#allocation_strategy Ec2Fleet#allocation_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllocationStrategy
        {
            get;
            set;
        }
    }
}
