using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    /// <summary>AWS Auto Scaling.</summary>
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupConfig")]
    public class AutoscalingGroupConfig : aws.Autoscaling.IAutoscalingGroupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#max_size AutoscalingGroup#max_size}.</summary>
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_size AutoscalingGroup#min_size}.</summary>
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MinSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#availability_zones AutoscalingGroup#availability_zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AvailabilityZones
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#default_cooldown AutoscalingGroup#default_cooldown}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultCooldown
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#desired_capacity AutoscalingGroup#desired_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DesiredCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#enabled_metrics AutoscalingGroup#enabled_metrics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EnabledMetrics
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#force_delete AutoscalingGroup#force_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForceDelete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#health_check_grace_period AutoscalingGroup#health_check_grace_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckGracePeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#health_check_type AutoscalingGroup#health_check_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckType
        {
            get;
            set;
        }

        /// <summary>initial_lifecycle_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#initial_lifecycle_hook AutoscalingGroup#initial_lifecycle_hook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initialLifecycleHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupInitialLifecycleHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InitialLifecycleHook
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_configuration AutoscalingGroup#launch_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LaunchConfiguration
        {
            get;
            set;
        }

        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template AutoscalingGroup#launch_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupLaunchTemplate\"}", isOptional: true)]
        public aws.Autoscaling.IAutoscalingGroupLaunchTemplate? LaunchTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#load_balancers AutoscalingGroup#load_balancers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LoadBalancers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#max_instance_lifetime AutoscalingGroup#max_instance_lifetime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxInstanceLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxInstanceLifetime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#metrics_granularity AutoscalingGroup#metrics_granularity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricsGranularity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricsGranularity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_elb_capacity AutoscalingGroup#min_elb_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minElbCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinElbCapacity
        {
            get;
            set;
        }

        /// <summary>mixed_instances_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#mixed_instances_policy AutoscalingGroup#mixed_instances_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mixedInstancesPolicy", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicy\"}", isOptional: true)]
        public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy? MixedInstancesPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#name AutoscalingGroup#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#name_prefix AutoscalingGroup#name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#placement_group AutoscalingGroup#placement_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlacementGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#protect_from_scale_in AutoscalingGroup#protect_from_scale_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protectFromScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ProtectFromScaleIn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#service_linked_role_arn AutoscalingGroup#service_linked_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceLinkedRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceLinkedRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#suspended_processes AutoscalingGroup#suspended_processes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "suspendedProcesses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SuspendedProcesses
        {
            get;
            set;
        }

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#tag AutoscalingGroup#tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#tags AutoscalingGroup#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#target_group_arns AutoscalingGroup#target_group_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetGroupArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#termination_policies AutoscalingGroup#termination_policies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminationPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TerminationPolicies
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#timeouts AutoscalingGroup#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupTimeouts\"}", isOptional: true)]
        public aws.Autoscaling.IAutoscalingGroupTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#vpc_zone_identifier AutoscalingGroup#vpc_zone_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcZoneIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpcZoneIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#wait_for_capacity_timeout AutoscalingGroup#wait_for_capacity_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitForCapacityTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WaitForCapacityTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#wait_for_elb_capacity AutoscalingGroup#wait_for_elb_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitForElbCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WaitForElbCapacity
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
