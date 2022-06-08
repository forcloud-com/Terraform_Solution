using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget")]
    public interface ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#capacity_reservation_id LaunchTemplate#capacity_reservation_id}.</summary>
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.ec2.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#capacity_reservation_id LaunchTemplate#capacity_reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
