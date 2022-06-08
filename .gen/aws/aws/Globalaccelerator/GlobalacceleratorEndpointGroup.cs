using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group aws_globalaccelerator_endpoint_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Globalaccelerator.GlobalacceleratorEndpointGroup), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorEndpointGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorEndpointGroupConfig\"}}]")]
    public class GlobalacceleratorEndpointGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group aws_globalaccelerator_endpoint_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlobalacceleratorEndpointGroup(Constructs.Construct scope, string id, aws.Globalaccelerator.IGlobalacceleratorEndpointGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorEndpointGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorEndpointGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEndpointConfiguration")]
        public virtual void ResetEndpointConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointGroupRegion")]
        public virtual void ResetEndpointGroupRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckIntervalSeconds")]
        public virtual void ResetHealthCheckIntervalSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckPath")]
        public virtual void ResetHealthCheckPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckPort")]
        public virtual void ResetHealthCheckPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckProtocol")]
        public virtual void ResetHealthCheckProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThresholdCount")]
        public virtual void ResetThresholdCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrafficDialPercentage")]
        public virtual void ResetTrafficDialPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Globalaccelerator.GlobalacceleratorEndpointGroup))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorEndpointGroupEndpointConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EndpointConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointGroupRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointGroupRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckIntervalSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckIntervalSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ListenerArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThresholdCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficDialPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TrafficDialPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorEndpointGroupEndpointConfiguration\"},\"kind\":\"array\"}}]}}")]
        public virtual object EndpointConfiguration
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointGroupRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointGroupRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckIntervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckIntervalSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thresholdCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThresholdCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficDialPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrafficDialPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
