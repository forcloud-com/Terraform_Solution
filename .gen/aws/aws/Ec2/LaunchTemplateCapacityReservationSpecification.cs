using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateCapacityReservationSpecification")]
    public class LaunchTemplateCapacityReservationSpecification : aws.Ec2.ILaunchTemplateCapacityReservationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#capacity_reservation_preference LaunchTemplate#capacity_reservation_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationPreference
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#capacity_reservation_target LaunchTemplate#capacity_reservation_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        public aws.Ec2.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
        {
            get;
            set;
        }
    }
}
