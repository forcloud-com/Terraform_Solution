using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsCapacityProviderAutoScalingGroupProvider")]
    public class EcsCapacityProviderAutoScalingGroupProvider : aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#auto_scaling_group_arn EcsCapacityProvider#auto_scaling_group_arn}.</summary>
        [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoScalingGroupArn
        {
            get;
            set;
        }

        /// <summary>managed_scaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#managed_scaling EcsCapacityProvider#managed_scaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedScaling", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}", isOptional: true)]
        public aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling? ManagedScaling
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#managed_termination_protection EcsCapacityProvider#managed_termination_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedTerminationProtection
        {
            get;
            set;
        }
    }
}
