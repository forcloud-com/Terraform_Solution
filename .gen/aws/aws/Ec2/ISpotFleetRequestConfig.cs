using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestConfig), fullyQualifiedName: "aws.ec2.SpotFleetRequestConfig")]
    public interface ISpotFleetRequestConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#iam_fleet_role SpotFleetRequest#iam_fleet_role}.</summary>
        [JsiiProperty(name: "iamFleetRole", typeJson: "{\"primitive\":\"string\"}")]
        string IamFleetRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#target_capacity SpotFleetRequest#target_capacity}.</summary>
        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double TargetCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#allocation_strategy SpotFleetRequest#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#excess_capacity_termination_policy SpotFleetRequest#excess_capacity_termination_policy}.</summary>
        [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExcessCapacityTerminationPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#fleet_type SpotFleetRequest#fleet_type}.</summary>
        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FleetType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#instance_interruption_behaviour SpotFleetRequest#instance_interruption_behaviour}.</summary>
        [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceInterruptionBehaviour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#instance_pools_to_use_count SpotFleetRequest#instance_pools_to_use_count}.</summary>
        [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstancePoolsToUseCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#launch_specification SpotFleetRequest#launch_specification}
        /// </remarks>
        [JsiiProperty(name: "launchSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LaunchSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_template_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#launch_template_config SpotFleetRequest#launch_template_config}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LaunchTemplateConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#load_balancers SpotFleetRequest#load_balancers}.</summary>
        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LoadBalancers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#replace_unhealthy_instances SpotFleetRequest#replace_unhealthy_instances}.</summary>
        [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReplaceUnhealthyInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#spot_price SpotFleetRequest#spot_price}.</summary>
        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#tags SpotFleetRequest#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#target_group_arns SpotFleetRequest#target_group_arns}.</summary>
        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetGroupArns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#terminate_instances_with_expiration SpotFleetRequest#terminate_instances_with_expiration}.</summary>
        [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TerminateInstancesWithExpiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#timeouts SpotFleetRequest#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ISpotFleetRequestTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#valid_from SpotFleetRequest#valid_from}.</summary>
        [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#valid_until SpotFleetRequest#valid_until}.</summary>
        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidUntil
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#wait_for_fulfillment SpotFleetRequest#wait_for_fulfillment}.</summary>
        [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WaitForFulfillment
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestConfig), fullyQualifiedName: "aws.ec2.SpotFleetRequestConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotFleetRequestConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#iam_fleet_role SpotFleetRequest#iam_fleet_role}.</summary>
            [JsiiProperty(name: "iamFleetRole", typeJson: "{\"primitive\":\"string\"}")]
            public string IamFleetRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#target_capacity SpotFleetRequest#target_capacity}.</summary>
            [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#allocation_strategy SpotFleetRequest#allocation_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#excess_capacity_termination_policy SpotFleetRequest#excess_capacity_termination_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcessCapacityTerminationPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#fleet_type SpotFleetRequest#fleet_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FleetType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#instance_interruption_behaviour SpotFleetRequest#instance_interruption_behaviour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceInterruptionBehaviour
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#instance_pools_to_use_count SpotFleetRequest#instance_pools_to_use_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstancePoolsToUseCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>launch_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#launch_specification SpotFleetRequest#launch_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LaunchSpecification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>launch_template_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#launch_template_config SpotFleetRequest#launch_template_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LaunchTemplateConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#load_balancers SpotFleetRequest#load_balancers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LoadBalancers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#replace_unhealthy_instances SpotFleetRequest#replace_unhealthy_instances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReplaceUnhealthyInstances
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#spot_price SpotFleetRequest#spot_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#tags SpotFleetRequest#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#target_group_arns SpotFleetRequest#target_group_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetGroupArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#terminate_instances_with_expiration SpotFleetRequest#terminate_instances_with_expiration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TerminateInstancesWithExpiration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#timeouts SpotFleetRequest#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestTimeouts\"}", isOptional: true)]
            public aws.Ec2.ISpotFleetRequestTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Ec2.ISpotFleetRequestTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#valid_from SpotFleetRequest#valid_from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidFrom
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#valid_until SpotFleetRequest#valid_until}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidUntil
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#wait_for_fulfillment SpotFleetRequest#wait_for_fulfillment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WaitForFulfillment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
