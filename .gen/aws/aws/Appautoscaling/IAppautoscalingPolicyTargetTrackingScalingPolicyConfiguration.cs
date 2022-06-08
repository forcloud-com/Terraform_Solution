using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration")]
    public interface IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#target_value AppautoscalingPolicy#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        double TargetValue
        {
            get;
        }

        /// <summary>customized_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#customized_metric_specification AppautoscalingPolicy#customized_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#disable_scale_in AppautoscalingPolicy#disable_scale_in}.</summary>
        [JsiiProperty(name: "disableScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableScaleIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#predefined_metric_specification AppautoscalingPolicy#predefined_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scale_in_cooldown AppautoscalingPolicy#scale_in_cooldown}.</summary>
        [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleInCooldown
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scale_out_cooldown AppautoscalingPolicy#scale_out_cooldown}.</summary>
        [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleOutCooldown
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#target_value AppautoscalingPolicy#target_value}.</summary>
            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetValue
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>customized_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#customized_metric_specification AppautoscalingPolicy#customized_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification\"}", isOptional: true)]
            public aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification
            {
                get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#disable_scale_in AppautoscalingPolicy#disable_scale_in}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableScaleIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>predefined_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#predefined_metric_specification AppautoscalingPolicy#predefined_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification\"}", isOptional: true)]
            public aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification
            {
                get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scale_in_cooldown AppautoscalingPolicy#scale_in_cooldown}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleInCooldown
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_policy#scale_out_cooldown AppautoscalingPolicy#scale_out_cooldown}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleOutCooldown
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
