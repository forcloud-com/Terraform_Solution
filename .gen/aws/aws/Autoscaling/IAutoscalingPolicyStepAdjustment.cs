using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyStepAdjustment), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyStepAdjustment")]
    public interface IAutoscalingPolicyStepAdjustment
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#scaling_adjustment AutoscalingPolicy#scaling_adjustment}.</summary>
        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}")]
        double ScalingAdjustment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_interval_lower_bound AutoscalingPolicy#metric_interval_lower_bound}.</summary>
        [JsiiProperty(name: "metricIntervalLowerBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricIntervalLowerBound
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_interval_upper_bound AutoscalingPolicy#metric_interval_upper_bound}.</summary>
        [JsiiProperty(name: "metricIntervalUpperBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricIntervalUpperBound
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyStepAdjustment), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyStepAdjustment")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingPolicyStepAdjustment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#scaling_adjustment AutoscalingPolicy#scaling_adjustment}.</summary>
            [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}")]
            public double ScalingAdjustment
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_interval_lower_bound AutoscalingPolicy#metric_interval_lower_bound}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricIntervalLowerBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricIntervalLowerBound
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_interval_upper_bound AutoscalingPolicy#metric_interval_upper_bound}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricIntervalUpperBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricIntervalUpperBound
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
