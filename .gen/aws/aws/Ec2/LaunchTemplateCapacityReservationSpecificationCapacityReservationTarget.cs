using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget")]
    public class LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget : aws.Ec2.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#capacity_reservation_id LaunchTemplate#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }
    }
}
