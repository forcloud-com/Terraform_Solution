using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy aws_autoscaling_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingPolicy), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyConfig\"}}]")]
    public class AutoscalingPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy aws_autoscaling_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AutoscalingPolicy(Constructs.Construct scope, string id, aws.Autoscaling.IAutoscalingPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTargetTrackingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfiguration\"}}]")]
        public virtual void PutTargetTrackingConfiguration(aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdjustmentType")]
        public virtual void ResetAdjustmentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCooldown")]
        public virtual void ResetCooldown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEstimatedInstanceWarmup")]
        public virtual void ResetEstimatedInstanceWarmup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricAggregationType")]
        public virtual void ResetMetricAggregationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinAdjustmentMagnitude")]
        public virtual void ResetMinAdjustmentMagnitude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinAdjustmentStep")]
        public virtual void ResetMinAdjustmentStep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyType")]
        public virtual void ResetPolicyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalingAdjustment")]
        public virtual void ResetScalingAdjustment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepAdjustment")]
        public virtual void ResetStepAdjustment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetTrackingConfiguration")]
        public virtual void ResetTargetTrackingConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.Autoscaling.AutoscalingPolicy))!;

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

        [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingPolicyTargetTrackingConfigurationOutputReference TargetTrackingConfiguration
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingPolicyTargetTrackingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adjustmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdjustmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoscalingGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cooldownInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CooldownInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "estimatedInstanceWarmupInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EstimatedInstanceWarmupInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricAggregationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricAggregationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentMagnitudeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinAdjustmentMagnitudeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentStepInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinAdjustmentStepInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingAdjustmentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScalingAdjustmentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepAdjustmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingConfigurationInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfiguration\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration? TargetTrackingConfigurationInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration?>();
        }

        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdjustmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoscalingGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cooldown
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EstimatedInstanceWarmup
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricAggregationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAdjustmentMagnitude
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minAdjustmentStep", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAdjustmentStep
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

        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScalingAdjustment
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}]}}")]
        public virtual object StepAdjustment
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
