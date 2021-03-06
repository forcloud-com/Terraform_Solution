using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderAutoScalingGroupProviderManagedScaling), fullyQualifiedName: "aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScaling")]
    public interface IEcsCapacityProviderAutoScalingGroupProviderManagedScaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#maximum_scaling_step_size EcsCapacityProvider#maximum_scaling_step_size}.</summary>
        [JsiiProperty(name: "maximumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumScalingStepSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#minimum_scaling_step_size EcsCapacityProvider#minimum_scaling_step_size}.</summary>
        [JsiiProperty(name: "minimumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumScalingStepSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#status EcsCapacityProvider#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#target_capacity EcsCapacityProvider#target_capacity}.</summary>
        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderAutoScalingGroupProviderManagedScaling), fullyQualifiedName: "aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScaling")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#maximum_scaling_step_size EcsCapacityProvider#maximum_scaling_step_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumScalingStepSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#minimum_scaling_step_size EcsCapacityProvider#minimum_scaling_step_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumScalingStepSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#status EcsCapacityProvider#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#target_capacity EcsCapacityProvider#target_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetCapacity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
