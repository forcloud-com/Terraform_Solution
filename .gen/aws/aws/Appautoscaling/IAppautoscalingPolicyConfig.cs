using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    /// <summary>AWS AppAutoScaling.</summary>
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyConfig), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyConfig")]
    public interface IAppautoscalingPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#name AppautoscalingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#resource_id AppautoscalingPolicy#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scalable_dimension AppautoscalingPolicy#scalable_dimension}.</summary>
        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
        string ScalableDimension
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#service_namespace AppautoscalingPolicy#service_namespace}.</summary>
        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceNamespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#adjustment_type AppautoscalingPolicy#adjustment_type}.</summary>
        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdjustmentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#cooldown AppautoscalingPolicy#cooldown}.</summary>
        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cooldown
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#metric_aggregation_type AppautoscalingPolicy#metric_aggregation_type}.</summary>
        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricAggregationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#min_adjustment_magnitude AppautoscalingPolicy#min_adjustment_magnitude}.</summary>
        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinAdjustmentMagnitude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#policy_type AppautoscalingPolicy#policy_type}.</summary>
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_adjustment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_adjustment AppautoscalingPolicy#step_adjustment}
        /// </remarks>
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StepAdjustment
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_scaling_policy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_scaling_policy_configuration AppautoscalingPolicy#step_scaling_policy_configuration}
        /// </remarks>
        [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration? StepScalingPolicyConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_tracking_scaling_policy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#target_tracking_scaling_policy_configuration AppautoscalingPolicy#target_tracking_scaling_policy_configuration}
        /// </remarks>
        [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS AppAutoScaling.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyConfig), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appautoscaling.IAppautoscalingPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#name AppautoscalingPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#resource_id AppautoscalingPolicy#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scalable_dimension AppautoscalingPolicy#scalable_dimension}.</summary>
            [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
            public string ScalableDimension
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#service_namespace AppautoscalingPolicy#service_namespace}.</summary>
            [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#adjustment_type AppautoscalingPolicy#adjustment_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdjustmentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#cooldown AppautoscalingPolicy#cooldown}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cooldown
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#metric_aggregation_type AppautoscalingPolicy#metric_aggregation_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricAggregationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#min_adjustment_magnitude AppautoscalingPolicy#min_adjustment_magnitude}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinAdjustmentMagnitude
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#policy_type AppautoscalingPolicy#policy_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>step_adjustment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_adjustment AppautoscalingPolicy#step_adjustment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StepAdjustment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>step_scaling_policy_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_scaling_policy_configuration AppautoscalingPolicy#step_scaling_policy_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfiguration\"}", isOptional: true)]
            public aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration? StepScalingPolicyConfiguration
            {
                get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration?>();
            }

            /// <summary>target_tracking_scaling_policy_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#target_tracking_scaling_policy_configuration AppautoscalingPolicy#target_tracking_scaling_policy_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"}", isOptional: true)]
            public aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration
            {
                get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration?>();
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
