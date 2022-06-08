using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    [JsiiClass(nativeType: typeof(aws.Appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference), fullyQualifiedName: "aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomizedMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification\"}}]")]
        public virtual void PutCustomizedMetricSpecification(aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredefinedMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification\"}}]")]
        public virtual void PutPredefinedMetricSpecification(aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification)}, new object[]{@value});
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

        [JsiiMethod(name: "resetScaleInCooldown")]
        public virtual void ResetScaleInCooldown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleOutCooldown")]
        public virtual void ResetScaleOutCooldown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationOutputReference\"}")]
        public virtual aws.Appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationOutputReference CustomizedMetricSpecification
        {
            get => GetInstanceProperty<aws.Appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecificationOutputReference\"}")]
        public virtual aws.Appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecificationOutputReference PredefinedMetricSpecification
        {
            get => GetInstanceProperty<aws.Appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customizedMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification\"}", isOptional: true)]
        public virtual aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableScaleInInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableScaleInInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification\"}", isOptional: true)]
        public virtual aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInCooldownInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScaleInCooldownInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleOutCooldownInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScaleOutCooldownInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScaleInCooldown
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScaleOutCooldown
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetValue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"}", isOptional: true)]
        public virtual aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
