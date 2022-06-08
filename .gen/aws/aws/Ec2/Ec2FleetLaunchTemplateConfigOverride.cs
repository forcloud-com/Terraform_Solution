using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.Ec2FleetLaunchTemplateConfigOverride")]
    public class Ec2FleetLaunchTemplateConfigOverride : aws.Ec2.IEc2FleetLaunchTemplateConfigOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#availability_zone Ec2Fleet#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#instance_type Ec2Fleet#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#max_price Ec2Fleet#max_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxPrice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#priority Ec2Fleet#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#subnet_id Ec2Fleet#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#weighted_capacity Ec2Fleet#weighted_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WeightedCapacity
        {
            get;
            set;
        }
    }
}
