using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy aws_appautoscaling_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Appautoscaling.AppautoscalingPolicy), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyConfig\"}}]")]
    public class AppautoscalingPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy aws_appautoscaling_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppautoscalingPolicy(Constructs.Construct scope, string id, aws.Appautoscaling.IAppautoscalingPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStepScalingPolicyConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfiguration\"}}]")]
        public virtual void PutStepScalingPolicyConfiguration(aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetTrackingScalingPolicyConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"}}]")]
        public virtual void PutTargetTrackingScalingPolicyConfiguration(aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration)}, new object[]{@value});
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

        [JsiiMethod(name: "resetPolicyType")]
        public virtual void ResetPolicyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepAdjustment")]
        public virtual void ResetStepAdjustment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepScalingPolicyConfiguration")]
        public virtual void ResetStepScalingPolicyConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetTrackingScalingPolicyConfiguration")]
        public virtual void ResetTargetTrackingScalingPolicyConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.Appautoscaling.AppautoscalingPolicy))!;

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

        [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfigurationOutputReference\"}")]
        public virtual aws.Appautoscaling.AppautoscalingPolicyStepScalingPolicyConfigurationOutputReference StepScalingPolicyConfiguration
        {
            get => GetInstanceProperty<aws.Appautoscaling.AppautoscalingPolicyStepScalingPolicyConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference\"}")]
        public virtual aws.Appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference TargetTrackingScalingPolicyConfiguration
        {
            get => GetInstanceProperty<aws.Appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adjustmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdjustmentTypeInput
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
        [JsiiProperty(name: "resourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalableDimensionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScalableDimensionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNamespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepAdjustmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepScalingPolicyConfigurationInput", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfiguration\"}", isOptional: true)]
        public virtual aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration? StepScalingPolicyConfigurationInput
        {
            get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingScalingPolicyConfigurationInput", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"}", isOptional: true)]
        public virtual aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfigurationInput
        {
            get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration?>();
        }

        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdjustmentType
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

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalableDimension
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNamespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}]}}")]
        public virtual object StepAdjustment
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
