using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet aws_gamelift_fleet}.</summary>
    [JsiiClass(nativeType: typeof(aws.Gamelift.GameliftFleet), fullyQualifiedName: "aws.gamelift.GameliftFleet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.gamelift.GameliftFleetConfig\"}}]")]
    public class GameliftFleet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet aws_gamelift_fleet} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GameliftFleet(Constructs.Construct scope, string id, aws.Gamelift.IGameliftFleetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResourceCreationLimitPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gamelift.GameliftFleetResourceCreationLimitPolicy\"}}]")]
        public virtual void PutResourceCreationLimitPolicy(aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuntimeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfiguration\"}}]")]
        public virtual void PutRuntimeConfiguration(aws.Gamelift.IGameliftFleetRuntimeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Gamelift.IGameliftFleetRuntimeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gamelift.GameliftFleetTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Gamelift.IGameliftFleetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Gamelift.IGameliftFleetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2InboundPermission")]
        public virtual void ResetEc2InboundPermission()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFleetType")]
        public virtual void ResetFleetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceRoleArn")]
        public virtual void ResetInstanceRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricGroups")]
        public virtual void ResetMetricGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNewGameSessionProtectionPolicy")]
        public virtual void ResetNewGameSessionProtectionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceCreationLimitPolicy")]
        public virtual void ResetResourceCreationLimitPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeConfiguration")]
        public virtual void ResetRuntimeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Gamelift.GameliftFleet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LogPaths
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetResourceCreationLimitPolicyOutputReference\"}")]
        public virtual aws.Gamelift.GameliftFleetResourceCreationLimitPolicyOutputReference ResourceCreationLimitPolicy
        {
            get => GetInstanceProperty<aws.Gamelift.GameliftFleetResourceCreationLimitPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfigurationOutputReference\"}")]
        public virtual aws.Gamelift.GameliftFleetRuntimeConfigurationOutputReference RuntimeConfiguration
        {
            get => GetInstanceProperty<aws.Gamelift.GameliftFleetRuntimeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetTimeoutsOutputReference\"}")]
        public virtual aws.Gamelift.GameliftFleetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Gamelift.GameliftFleetTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InboundPermissionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2InboundPermissionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ec2InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MetricGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionProtectionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NewGameSessionProtectionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceCreationLimitPolicyInput", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetResourceCreationLimitPolicy\"}", isOptional: true)]
        public virtual aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy? ResourceCreationLimitPolicyInput
        {
            get => GetInstanceProperty<aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfigurationInput", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfiguration\"}", isOptional: true)]
        public virtual aws.Gamelift.IGameliftFleetRuntimeConfiguration? RuntimeConfigurationInput
        {
            get => GetInstanceProperty<aws.Gamelift.IGameliftFleetRuntimeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetTimeouts\"}", isOptional: true)]
        public virtual aws.Gamelift.IGameliftFleetTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Gamelift.IGameliftFleetTimeouts?>();
        }

        [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}]}}")]
        public virtual object Ec2InboundPermission
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MetricGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NewGameSessionProtectionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
