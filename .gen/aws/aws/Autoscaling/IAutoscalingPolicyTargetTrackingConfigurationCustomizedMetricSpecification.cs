using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification")]
    public interface IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_name AutoscalingPolicy#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#namespace AutoscalingPolicy#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#statistic AutoscalingPolicy#statistic}.</summary>
        [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}")]
        string Statistic
        {
            get;
        }

        /// <summary>metric_dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_dimension AutoscalingPolicy#metric_dimension}
        /// </remarks>
        [JsiiProperty(name: "metricDimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetricDimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#unit AutoscalingPolicy#unit}.</summary>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Unit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_name AutoscalingPolicy#metric_name}.</summary>
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#namespace AutoscalingPolicy#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#statistic AutoscalingPolicy#statistic}.</summary>
            [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}")]
            public string Statistic
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>metric_dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_dimension AutoscalingPolicy#metric_dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricDimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MetricDimension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#unit AutoscalingPolicy#unit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Unit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
