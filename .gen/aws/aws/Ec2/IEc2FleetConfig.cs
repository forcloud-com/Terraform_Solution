using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(IEc2FleetConfig), fullyQualifiedName: "aws.ec2.Ec2FleetConfig")]
    public interface IEc2FleetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>launch_template_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#launch_template_config Ec2Fleet#launch_template_config}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfig\"}")]
        aws.Ec2.IEc2FleetLaunchTemplateConfig LaunchTemplateConfig
        {
            get;
        }

        /// <summary>target_capacity_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#target_capacity_specification Ec2Fleet#target_capacity_specification}
        /// </remarks>
        [JsiiProperty(name: "targetCapacitySpecification", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTargetCapacitySpecification\"}")]
        aws.Ec2.IEc2FleetTargetCapacitySpecification TargetCapacitySpecification
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#excess_capacity_termination_policy Ec2Fleet#excess_capacity_termination_policy}.</summary>
        [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExcessCapacityTerminationPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_demand_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#on_demand_options Ec2Fleet#on_demand_options}
        /// </remarks>
        [JsiiProperty(name: "onDemandOptions", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetOnDemandOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IEc2FleetOnDemandOptions? OnDemandOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#replace_unhealthy_instances Ec2Fleet#replace_unhealthy_instances}.</summary>
        [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReplaceUnhealthyInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>spot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#spot_options Ec2Fleet#spot_options}
        /// </remarks>
        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IEc2FleetSpotOptions? SpotOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#tags Ec2Fleet#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#terminate_instances Ec2Fleet#terminate_instances}.</summary>
        [JsiiProperty(name: "terminateInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TerminateInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#terminate_instances_with_expiration Ec2Fleet#terminate_instances_with_expiration}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#timeouts Ec2Fleet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IEc2FleetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#type Ec2Fleet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEc2FleetConfig), fullyQualifiedName: "aws.ec2.Ec2FleetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IEc2FleetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#launch_template_config Ec2Fleet#launch_template_config}
            /// </remarks>
            [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfig\"}")]
            public aws.Ec2.IEc2FleetLaunchTemplateConfig LaunchTemplateConfig
            {
                get => GetInstanceProperty<aws.Ec2.IEc2FleetLaunchTemplateConfig>()!;
            }

            /// <summary>target_capacity_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#target_capacity_specification Ec2Fleet#target_capacity_specification}
            /// </remarks>
            [JsiiProperty(name: "targetCapacitySpecification", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTargetCapacitySpecification\"}")]
            public aws.Ec2.IEc2FleetTargetCapacitySpecification TargetCapacitySpecification
            {
                get => GetInstanceProperty<aws.Ec2.IEc2FleetTargetCapacitySpecification>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#excess_capacity_termination_policy Ec2Fleet#excess_capacity_termination_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcessCapacityTerminationPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>on_demand_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#on_demand_options Ec2Fleet#on_demand_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandOptions", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetOnDemandOptions\"}", isOptional: true)]
            public aws.Ec2.IEc2FleetOnDemandOptions? OnDemandOptions
            {
                get => GetInstanceProperty<aws.Ec2.IEc2FleetOnDemandOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#replace_unhealthy_instances Ec2Fleet#replace_unhealthy_instances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReplaceUnhealthyInstances
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>spot_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#spot_options Ec2Fleet#spot_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptions\"}", isOptional: true)]
            public aws.Ec2.IEc2FleetSpotOptions? SpotOptions
            {
                get => GetInstanceProperty<aws.Ec2.IEc2FleetSpotOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#tags Ec2Fleet#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#terminate_instances Ec2Fleet#terminate_instances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminateInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TerminateInstances
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#terminate_instances_with_expiration Ec2Fleet#terminate_instances_with_expiration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TerminateInstancesWithExpiration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#timeouts Ec2Fleet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTimeouts\"}", isOptional: true)]
            public aws.Ec2.IEc2FleetTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Ec2.IEc2FleetTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#type Ec2Fleet#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
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
