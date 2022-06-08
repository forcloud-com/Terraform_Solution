using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    /// <summary>AWS Auto Scaling.</summary>
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingPolicyConfig")]
    public class AutoscalingPolicyConfig : aws.Autoscaling.IAutoscalingPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#autoscaling_group_name AutoscalingPolicy#autoscaling_group_name}.</summary>
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoscalingGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#name AutoscalingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#adjustment_type AutoscalingPolicy#adjustment_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdjustmentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#cooldown AutoscalingPolicy#cooldown}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Cooldown
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#estimated_instance_warmup AutoscalingPolicy#estimated_instance_warmup}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EstimatedInstanceWarmup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_aggregation_type AutoscalingPolicy#metric_aggregation_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricAggregationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#min_adjustment_magnitude AutoscalingPolicy#min_adjustment_magnitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinAdjustmentMagnitude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#min_adjustment_step AutoscalingPolicy#min_adjustment_step}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinAdjustmentStep
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#policy_type AutoscalingPolicy#policy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#scaling_adjustment AutoscalingPolicy#scaling_adjustment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScalingAdjustment
        {
            get;
            set;
        }

        /// <summary>step_adjustment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#step_adjustment AutoscalingPolicy#step_adjustment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StepAdjustment
        {
            get;
            set;
        }

        /// <summary>target_tracking_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#target_tracking_configuration AutoscalingPolicy#target_tracking_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfiguration\"}", isOptional: true)]
        public aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration? TargetTrackingConfiguration
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
