using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingPolicyTargetTrackingConfigurationOutputReference), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingPolicyTargetTrackingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingPolicyTargetTrackingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicyTargetTrackingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicyTargetTrackingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomizedMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification\"}}]")]
        public virtual void PutCustomizedMetricSpecification(aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredefinedMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification\"}}]")]
        public virtual void PutPredefinedMetricSpecification(aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomizedMetricSpecification")]
        public virtual void ResetCustomizedMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableScaleIn")]
        public virtual void ResetDisableScaleIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredefinedMetricSpecification")]
        public virtual void ResetPredefinedMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationOutputReference CustomizedMetricSpecification
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecificationOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecificationOutputReference PredefinedMetricSpecification
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customizedMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableScaleInInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableScaleInInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetValueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "disableScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DisableScaleIn
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetValue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyTargetTrackingConfiguration\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyTargetTrackingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
