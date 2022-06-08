using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyStepScalingPolicyConfiguration), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfiguration")]
    public interface IAppautoscalingPolicyStepScalingPolicyConfiguration
    {
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

        /// <summary>step_adjustment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_adjustment AppautoscalingPolicy#step_adjustment}
        /// </remarks>
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StepAdjustment
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyStepScalingPolicyConfiguration), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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

            /// <summary>step_adjustment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_adjustment AppautoscalingPolicy#step_adjustment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StepAdjustment
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
