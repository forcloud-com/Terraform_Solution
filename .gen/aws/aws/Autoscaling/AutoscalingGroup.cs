using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group aws_autoscaling_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingGroup), fullyQualifiedName: "aws.autoscaling.AutoscalingGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupConfig\"}}]")]
    public class AutoscalingGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group aws_autoscaling_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AutoscalingGroup(Constructs.Construct scope, string id, aws.Autoscaling.IAutoscalingGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLaunchTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupLaunchTemplate\"}}]")]
        public virtual void PutLaunchTemplate(aws.Autoscaling.IAutoscalingGroupLaunchTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingGroupLaunchTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMixedInstancesPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicy\"}}]")]
        public virtual void PutMixedInstancesPolicy(aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Autoscaling.IAutoscalingGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilityZones")]
        public virtual void ResetAvailabilityZones()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultCooldown")]
        public virtual void ResetDefaultCooldown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredCapacity")]
        public virtual void ResetDesiredCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabledMetrics")]
        public virtual void ResetEnabledMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDelete")]
        public virtual void ResetForceDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckGracePeriod")]
        public virtual void ResetHealthCheckGracePeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckType")]
        public virtual void ResetHealthCheckType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialLifecycleHook")]
        public virtual void ResetInitialLifecycleHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchConfiguration")]
        public virtual void ResetLaunchConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplate")]
        public virtual void ResetLaunchTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancers")]
        public virtual void ResetLoadBalancers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxInstanceLifetime")]
        public virtual void ResetMaxInstanceLifetime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricsGranularity")]
        public virtual void ResetMetricsGranularity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinElbCapacity")]
        public virtual void ResetMinElbCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMixedInstancesPolicy")]
        public virtual void ResetMixedInstancesPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementGroup")]
        public virtual void ResetPlacementGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectFromScaleIn")]
        public virtual void ResetProtectFromScaleIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceLinkedRoleArn")]
        public virtual void ResetServiceLinkedRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuspendedProcesses")]
        public virtual void ResetSuspendedProcesses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTag")]
        public virtual void ResetTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetGroupArns")]
        public virtual void ResetTargetGroupArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminationPolicies")]
        public virtual void ResetTerminationPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcZoneIdentifier")]
        public virtual void ResetVpcZoneIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForCapacityTimeout")]
        public virtual void ResetWaitForCapacityTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForElbCapacity")]
        public virtual void ResetWaitForElbCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Autoscaling.AutoscalingGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupLaunchTemplateOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingGroupLaunchTemplateOutputReference LaunchTemplate
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingGroupLaunchTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "mixedInstancesPolicy", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyOutputReference MixedInstancesPolicy
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupTimeoutsOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AvailabilityZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultCooldownInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultCooldownInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledMetricsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledMetricsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDeleteInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDeleteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckGracePeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialLifecycleHookInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupInitialLifecycleHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InitialLifecycleHookInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupLaunchTemplate\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupLaunchTemplate? LaunchTemplateInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupLaunchTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LoadBalancersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxInstanceLifetimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxInstanceLifetimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsGranularityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricsGranularityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minElbCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinElbCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mixedInstancesPolicyInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicy\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy? MixedInstancesPolicyInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlacementGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectFromScaleInInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ProtectFromScaleInInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceLinkedRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceLinkedRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "suspendedProcessesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SuspendedProcessesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetGroupArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminationPoliciesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TerminationPoliciesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupTimeouts\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcZoneIdentifierInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcZoneIdentifierInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForCapacityTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WaitForCapacityTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForElbCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitForElbCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultCooldown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultCooldown
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabledMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledMetrics
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDelete
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckGracePeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckGracePeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialLifecycleHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupInitialLifecycleHook\"},\"kind\":\"array\"}}]}}")]
        public virtual object InitialLifecycleHook
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LoadBalancers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxInstanceLifetime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxInstanceLifetime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricsGranularity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricsGranularity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minElbCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinElbCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protectFromScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ProtectFromScaleIn
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceLinkedRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLinkedRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "suspendedProcesses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SuspendedProcesses
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupTag\"},\"kind\":\"array\"}}]}}")]
        public virtual object Tag
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetGroupArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminationPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TerminationPolicies
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcZoneIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcZoneIdentifier
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForCapacityTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WaitForCapacityTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForElbCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitForElbCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
