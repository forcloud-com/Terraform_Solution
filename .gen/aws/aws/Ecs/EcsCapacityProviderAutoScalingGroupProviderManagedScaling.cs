using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiByValue(fqn: "aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScaling")]
    public class EcsCapacityProviderAutoScalingGroupProviderManagedScaling : aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#maximum_scaling_step_size EcsCapacityProvider#maximum_scaling_step_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumScalingStepSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#minimum_scaling_step_size EcsCapacityProvider#minimum_scaling_step_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumScalingStepSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#status EcsCapacityProvider#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#target_capacity EcsCapacityProvider#target_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetCapacity
        {
            get;
            set;
        }
    }
}
