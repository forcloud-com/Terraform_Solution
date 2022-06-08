using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension")]
    public interface IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#name AutoscalingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#value AutoscalingPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#name AutoscalingPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#value AutoscalingPolicy#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
