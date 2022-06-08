using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    /// <summary>AWS Auto Scaling.</summary>
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupConfig), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupConfig")]
    public interface IAutoscalingGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#max_size AutoscalingGroup#max_size}.</summary>
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        double MaxSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_size AutoscalingGroup#min_size}.</summary>
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        double MinSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#availability_zones AutoscalingGroup#availability_zones}.</summary>
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AvailabilityZones
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#default_cooldown AutoscalingGroup#default_cooldown}.</summary>
        [JsiiProperty(name: "defaultCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultCooldown
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#desired_capacity AutoscalingGroup#desired_capacity}.</summary>
        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#enabled_metrics AutoscalingGroup#enabled_metrics}.</summary>
        [JsiiProperty(name: "enabledMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EnabledMetrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#force_delete AutoscalingGroup#force_delete}.</summary>
        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#health_check_grace_period AutoscalingGroup#health_check_grace_period}.</summary>
        [JsiiProperty(name: "healthCheckGracePeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckGracePeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#health_check_type AutoscalingGroup#health_check_type}.</summary>
        [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckType
        {
            get
            {
                return null;
            }
        }

        /// <summary>initial_lifecycle_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#initial_lifecycle_hook AutoscalingGroup#initial_lifecycle_hook}
        /// </remarks>
        [JsiiProperty(name: "initialLifecycleHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupInitialLifecycleHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InitialLifecycleHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_configuration AutoscalingGroup#launch_configuration}.</summary>
        [JsiiProperty(name: "launchConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template AutoscalingGroup#launch_template}
        /// </remarks>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupLaunchTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingGroupLaunchTemplate? LaunchTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#load_balancers AutoscalingGroup#load_balancers}.</summary>
        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LoadBalancers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#max_instance_lifetime AutoscalingGroup#max_instance_lifetime}.</summary>
        [JsiiProperty(name: "maxInstanceLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxInstanceLifetime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#metrics_granularity AutoscalingGroup#metrics_granularity}.</summary>
        [JsiiProperty(name: "metricsGranularity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricsGranularity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_elb_capacity AutoscalingGroup#min_elb_capacity}.</summary>
        [JsiiProperty(name: "minElbCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinElbCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>mixed_instances_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#mixed_instances_policy AutoscalingGroup#mixed_instances_policy}
        /// </remarks>
        [JsiiProperty(name: "mixedInstancesPolicy", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy? MixedInstancesPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#name AutoscalingGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#name_prefix AutoscalingGroup#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#placement_group AutoscalingGroup#placement_group}.</summary>
        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#protect_from_scale_in AutoscalingGroup#protect_from_scale_in}.</summary>
        [JsiiProperty(name: "protectFromScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProtectFromScaleIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#service_linked_role_arn AutoscalingGroup#service_linked_role_arn}.</summary>
        [JsiiProperty(name: "serviceLinkedRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceLinkedRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#suspended_processes AutoscalingGroup#suspended_processes}.</summary>
        [JsiiProperty(name: "suspendedProcesses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SuspendedProcesses
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#tag AutoscalingGroup#tag}
        /// </remarks>
        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#tags AutoscalingGroup#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#target_group_arns AutoscalingGroup#target_group_arns}.</summary>
        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetGroupArns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#termination_policies AutoscalingGroup#termination_policies}.</summary>
        [JsiiProperty(name: "terminationPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TerminationPolicies
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#timeouts AutoscalingGroup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#vpc_zone_identifier AutoscalingGroup#vpc_zone_identifier}.</summary>
        [JsiiProperty(name: "vpcZoneIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcZoneIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#wait_for_capacity_timeout AutoscalingGroup#wait_for_capacity_timeout}.</summary>
        [JsiiProperty(name: "waitForCapacityTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WaitForCapacityTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#wait_for_elb_capacity AutoscalingGroup#wait_for_elb_capacity}.</summary>
        [JsiiProperty(name: "waitForElbCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitForElbCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Auto Scaling.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupConfig), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#max_size AutoscalingGroup#max_size}.</summary>
            [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_size AutoscalingGroup#min_size}.</summary>
            [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MinSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#availability_zones AutoscalingGroup#availability_zones}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AvailabilityZones
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#default_cooldown AutoscalingGroup#default_cooldown}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultCooldown
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#desired_capacity AutoscalingGroup#desired_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#enabled_metrics AutoscalingGroup#enabled_metrics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabledMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EnabledMetrics
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#force_delete AutoscalingGroup#force_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ForceDelete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#health_check_grace_period AutoscalingGroup#health_check_grace_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckGracePeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckGracePeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#health_check_type AutoscalingGroup#health_check_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>initial_lifecycle_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#initial_lifecycle_hook AutoscalingGroup#initial_lifecycle_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initialLifecycleHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupInitialLifecycleHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InitialLifecycleHook
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_configuration AutoscalingGroup#launch_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>launch_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template AutoscalingGroup#launch_template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupLaunchTemplate\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingGroupLaunchTemplate? LaunchTemplate
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupLaunchTemplate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#load_balancers AutoscalingGroup#load_balancers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LoadBalancers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#max_instance_lifetime AutoscalingGroup#max_instance_lifetime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxInstanceLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxInstanceLifetime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#metrics_granularity AutoscalingGroup#metrics_granularity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricsGranularity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricsGranularity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_elb_capacity AutoscalingGroup#min_elb_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minElbCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinElbCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>mixed_instances_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#mixed_instances_policy AutoscalingGroup#mixed_instances_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mixedInstancesPolicy", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicy\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy? MixedInstancesPolicy
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#name AutoscalingGroup#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#name_prefix AutoscalingGroup#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#placement_group AutoscalingGroup#placement_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#protect_from_scale_in AutoscalingGroup#protect_from_scale_in}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protectFromScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ProtectFromScaleIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#service_linked_role_arn AutoscalingGroup#service_linked_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceLinkedRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceLinkedRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#suspended_processes AutoscalingGroup#suspended_processes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "suspendedProcesses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SuspendedProcesses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#tag AutoscalingGroup#tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#tags AutoscalingGroup#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#target_group_arns AutoscalingGroup#target_group_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetGroupArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#termination_policies AutoscalingGroup#termination_policies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminationPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TerminationPolicies
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#timeouts AutoscalingGroup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupTimeouts\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#vpc_zone_identifier AutoscalingGroup#vpc_zone_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcZoneIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcZoneIdentifier
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#wait_for_capacity_timeout AutoscalingGroup#wait_for_capacity_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitForCapacityTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WaitForCapacityTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#wait_for_elb_capacity AutoscalingGroup#wait_for_elb_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitForElbCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitForElbCapacity
            {
                get => GetInstanceProperty<double?>();
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
