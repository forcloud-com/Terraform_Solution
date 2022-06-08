using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet aws_ec2_fleet}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2Fleet), fullyQualifiedName: "aws.ec2.Ec2Fleet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2.Ec2FleetConfig\"}}]")]
    public class Ec2Fleet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet aws_ec2_fleet} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Ec2Fleet(Constructs.Construct scope, string id, aws.Ec2.IEc2FleetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2Fleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2Fleet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLaunchTemplateConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfig\"}}]")]
        public virtual void PutLaunchTemplateConfig(aws.Ec2.IEc2FleetLaunchTemplateConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2FleetLaunchTemplateConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnDemandOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2FleetOnDemandOptions\"}}]")]
        public virtual void PutOnDemandOptions(aws.Ec2.IEc2FleetOnDemandOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2FleetOnDemandOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpotOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2FleetSpotOptions\"}}]")]
        public virtual void PutSpotOptions(aws.Ec2.IEc2FleetSpotOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2FleetSpotOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetCapacitySpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2FleetTargetCapacitySpecification\"}}]")]
        public virtual void PutTargetCapacitySpecification(aws.Ec2.IEc2FleetTargetCapacitySpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2FleetTargetCapacitySpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2FleetTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ec2.IEc2FleetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2FleetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcessCapacityTerminationPolicy")]
        public virtual void ResetExcessCapacityTerminationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemandOptions")]
        public virtual void ResetOnDemandOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplaceUnhealthyInstances")]
        public virtual void ResetReplaceUnhealthyInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotOptions")]
        public virtual void ResetSpotOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminateInstances")]
        public virtual void ResetTerminateInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminateInstancesWithExpiration")]
        public virtual void ResetTerminateInstancesWithExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(aws.Ec2.Ec2Fleet))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigOutputReference\"}")]
        public virtual aws.Ec2.Ec2FleetLaunchTemplateConfigOutputReference LaunchTemplateConfig
        {
            get => GetInstanceProperty<aws.Ec2.Ec2FleetLaunchTemplateConfigOutputReference>()!;
        }

        [JsiiProperty(name: "onDemandOptions", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetOnDemandOptionsOutputReference\"}")]
        public virtual aws.Ec2.Ec2FleetOnDemandOptionsOutputReference OnDemandOptions
        {
            get => GetInstanceProperty<aws.Ec2.Ec2FleetOnDemandOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptionsOutputReference\"}")]
        public virtual aws.Ec2.Ec2FleetSpotOptionsOutputReference SpotOptions
        {
            get => GetInstanceProperty<aws.Ec2.Ec2FleetSpotOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "targetCapacitySpecification", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTargetCapacitySpecificationOutputReference\"}")]
        public virtual aws.Ec2.Ec2FleetTargetCapacitySpecificationOutputReference TargetCapacitySpecification
        {
            get => GetInstanceProperty<aws.Ec2.Ec2FleetTargetCapacitySpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTimeoutsOutputReference\"}")]
        public virtual aws.Ec2.Ec2FleetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ec2.Ec2FleetTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excessCapacityTerminationPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExcessCapacityTerminationPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateConfigInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfig\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetLaunchTemplateConfig? LaunchTemplateConfigInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetLaunchTemplateConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandOptionsInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetOnDemandOptions\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetOnDemandOptions? OnDemandOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetOnDemandOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replaceUnhealthyInstancesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReplaceUnhealthyInstancesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotOptionsInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptions\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetSpotOptions? SpotOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetSpotOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCapacitySpecificationInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTargetCapacitySpecification\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetTargetCapacitySpecification? TargetCapacitySpecificationInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetTargetCapacitySpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateInstancesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TerminateInstancesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateInstancesWithExpirationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TerminateInstancesWithExpirationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetTimeouts\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExcessCapacityTerminationPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ReplaceUnhealthyInstances
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminateInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TerminateInstances
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TerminateInstancesWithExpiration
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
