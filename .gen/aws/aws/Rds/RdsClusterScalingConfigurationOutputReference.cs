using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    [JsiiClass(nativeType: typeof(aws.Rds.RdsClusterScalingConfigurationOutputReference), fullyQualifiedName: "aws.rds.RdsClusterScalingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RdsClusterScalingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RdsClusterScalingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RdsClusterScalingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RdsClusterScalingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAutoPause")]
        public virtual void ResetAutoPause()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxCapacity")]
        public virtual void ResetMaxCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinCapacity")]
        public virtual void ResetMinCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondsUntilAutoPause")]
        public virtual void ResetSecondsUntilAutoPause()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutAction")]
        public virtual void ResetTimeoutAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoPauseInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoPauseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondsUntilAutoPauseInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SecondsUntilAutoPauseInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeoutActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoPause", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoPause
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecondsUntilAutoPause
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.rds.RdsClusterScalingConfiguration\"}", isOptional: true)]
        public virtual aws.Rds.IRdsClusterScalingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Rds.IRdsClusterScalingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
