using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.SpotFleetRequestLaunchTemplateConfigOverrides")]
    public class SpotFleetRequestLaunchTemplateConfigOverrides : aws.Ec2.ISpotFleetRequestLaunchTemplateConfigOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#availability_zone SpotFleetRequest#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#instance_type SpotFleetRequest#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#priority SpotFleetRequest#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#spot_price SpotFleetRequest#spot_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpotPrice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#subnet_id SpotFleetRequest#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#weighted_capacity SpotFleetRequest#weighted_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WeightedCapacity
        {
            get;
            set;
        }
    }
}
