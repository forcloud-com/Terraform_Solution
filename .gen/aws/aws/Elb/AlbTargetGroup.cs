using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group aws_alb_target_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elb.AlbTargetGroup), fullyQualifiedName: "aws.elb.AlbTargetGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.elb.AlbTargetGroupConfig\"}}]")]
    public class AlbTargetGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group aws_alb_target_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AlbTargetGroup(Constructs.Construct scope, string id, aws.Elb.IAlbTargetGroupConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbTargetGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbTargetGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elb.AlbTargetGroupHealthCheck\"}}]")]
        public virtual void PutHealthCheck(aws.Elb.IAlbTargetGroupHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elb.IAlbTargetGroupHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStickiness", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elb.AlbTargetGroupStickiness\"}}]")]
        public virtual void PutStickiness(aws.Elb.IAlbTargetGroupStickiness @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elb.IAlbTargetGroupStickiness)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeregistrationDelay")]
        public virtual void ResetDeregistrationDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaMultiValueHeadersEnabled")]
        public virtual void ResetLambdaMultiValueHeadersEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancingAlgorithmType")]
        public virtual void ResetLoadBalancingAlgorithmType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxyProtocolV2")]
        public virtual void ResetProxyProtocolV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlowStart")]
        public virtual void ResetSlowStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStickiness")]
        public virtual void ResetStickiness()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetType")]
        public virtual void ResetTargetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcId")]
        public virtual void ResetVpcId()
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
        = GetStaticProperty<string>(typeof(aws.Elb.AlbTargetGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arnSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArnSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.elb.AlbTargetGroupHealthCheckOutputReference\"}")]
        public virtual aws.Elb.AlbTargetGroupHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<aws.Elb.AlbTargetGroupHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbTargetGroupStickinessOutputReference\"}")]
        public virtual aws.Elb.AlbTargetGroupStickinessOutputReference Stickiness
        {
            get => GetInstanceProperty<aws.Elb.AlbTargetGroupStickinessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deregistrationDelayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeregistrationDelayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"aws.elb.AlbTargetGroupHealthCheck\"}", isOptional: true)]
        public virtual aws.Elb.IAlbTargetGroupHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<aws.Elb.IAlbTargetGroupHealthCheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaMultiValueHeadersEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LambdaMultiValueHeadersEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingAlgorithmTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancingAlgorithmTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyProtocolV2Input", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ProxyProtocolV2Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowStartInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SlowStartInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickinessInput", typeJson: "{\"fqn\":\"aws.elb.AlbTargetGroupStickiness\"}", isOptional: true)]
        public virtual aws.Elb.IAlbTargetGroupStickiness? StickinessInput
        {
            get => GetInstanceProperty<aws.Elb.IAlbTargetGroupStickiness?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deregistrationDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeregistrationDelay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaMultiValueHeadersEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LambdaMultiValueHeadersEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancingAlgorithmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancingAlgorithmType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "proxyProtocolV2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ProxyProtocolV2
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "slowStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SlowStart
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
