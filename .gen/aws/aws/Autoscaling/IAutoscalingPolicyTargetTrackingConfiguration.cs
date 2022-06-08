using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfiguration), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfiguration")]
    public interface IAutoscalingPolicyTargetTrackingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#target_value AutoscalingPolicy#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        double TargetValue
        {
            get;
        }

        /// <summary>customized_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#customized_metric_specification AutoscalingPolicy#customized_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#disable_scale_in AutoscalingPolicy#disable_scale_in}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_metric_specification AutoscalingPolicy#predefined_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfiguration), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#target_value AutoscalingPolicy#target_value}.</summary>
            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetValue
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>customized_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#customized_metric_specification AutoscalingPolicy#customized_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#disable_scale_in AutoscalingPolicy#disable_scale_in}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableScaleIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>predefined_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_metric_specification AutoscalingPolicy#predefined_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification?>();
            }
        }
    }
}
