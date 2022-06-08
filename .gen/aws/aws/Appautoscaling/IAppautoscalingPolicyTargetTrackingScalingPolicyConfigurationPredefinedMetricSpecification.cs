using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification")]
    public interface IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#predefined_metric_type AppautoscalingPolicy#predefined_metric_type}.</summary>
        [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}")]
        string PredefinedMetricType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#resource_label AppautoscalingPolicy#resource_label}.</summary>
        [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#predefined_metric_type AppautoscalingPolicy#predefined_metric_type}.</summary>
            [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}")]
            public string PredefinedMetricType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#resource_label AppautoscalingPolicy#resource_label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceLabel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
