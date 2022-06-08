using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    #pragma warning disable CS8618

    /// <summary>AWS AppAutoScaling.</summary>
    [JsiiByValue(fqn: "aws.appautoscaling.AppautoscalingPolicyConfig")]
    public class AppautoscalingPolicyConfig : aws.Appautoscaling.IAppautoscalingPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#name AppautoscalingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#resource_id AppautoscalingPolicy#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scalable_dimension AppautoscalingPolicy#scalable_dimension}.</summary>
        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
        public string ScalableDimension
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#service_namespace AppautoscalingPolicy#service_namespace}.</summary>
        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceNamespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#adjustment_type AppautoscalingPolicy#adjustment_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdjustmentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#cooldown AppautoscalingPolicy#cooldown}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Cooldown
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#metric_aggregation_type AppautoscalingPolicy#metric_aggregation_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricAggregationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#min_adjustment_magnitude AppautoscalingPolicy#min_adjustment_magnitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinAdjustmentMagnitude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#policy_type AppautoscalingPolicy#policy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyType
        {
            get;
            set;
        }

        /// <summary>step_adjustment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_adjustment AppautoscalingPolicy#step_adjustment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StepAdjustment
        {
            get;
            set;
        }

        /// <summary>step_scaling_policy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#step_scaling_policy_configuration AppautoscalingPolicy#step_scaling_policy_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyStepScalingPolicyConfiguration\"}", isOptional: true)]
        public aws.Appautoscaling.IAppautoscalingPolicyStepScalingPolicyConfiguration? StepScalingPolicyConfiguration
        {
            get;
            set;
        }

        /// <summary>target_tracking_scaling_policy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#target_tracking_scaling_policy_configuration AppautoscalingPolicy#target_tracking_scaling_policy_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"}", isOptional: true)]
        public aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration
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
