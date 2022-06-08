using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    [JsiiClass(nativeType: typeof(aws.Gamelift.GameliftFleetRuntimeConfigurationOutputReference), fullyQualifiedName: "aws.gamelift.GameliftFleetRuntimeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GameliftFleetRuntimeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GameliftFleetRuntimeConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleetRuntimeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleetRuntimeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGameSessionActivationTimeoutSeconds")]
        public virtual void ResetGameSessionActivationTimeoutSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConcurrentGameSessionActivations")]
        public virtual void ResetMaxConcurrentGameSessionActivations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerProcess")]
        public virtual void ResetServerProcess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "gameSessionActivationTimeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GameSessionActivationTimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentGameSessionActivationsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConcurrentGameSessionActivationsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverProcessInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfigurationServerProcess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ServerProcessInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "gameSessionActivationTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GameSessionActivationTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConcurrentGameSessionActivations", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentGameSessionActivations
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverProcess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfigurationServerProcess\"},\"kind\":\"array\"}}]}}")]
        public virtual object ServerProcess
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfiguration\"}", isOptional: true)]
        public virtual aws.Gamelift.IGameliftFleetRuntimeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Gamelift.IGameliftFleetRuntimeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
