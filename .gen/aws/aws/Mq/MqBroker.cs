using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/mq_broker aws_mq_broker}.</summary>
    [JsiiClass(nativeType: typeof(aws.Mq.MqBroker), fullyQualifiedName: "aws.mq.MqBroker", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.mq.MqBrokerConfig\"}}]")]
    public class MqBroker : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/mq_broker aws_mq_broker} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MqBroker(Constructs.Construct scope, string id, aws.Mq.IMqBrokerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MqBroker(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MqBroker(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mq.MqBrokerConfiguration\"}}]")]
        public virtual void PutConfiguration(aws.Mq.IMqBrokerConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mq.IMqBrokerConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mq.MqBrokerEncryptionOptions\"}}]")]
        public virtual void PutEncryptionOptions(aws.Mq.IMqBrokerEncryptionOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mq.IMqBrokerEncryptionOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mq.MqBrokerLogs\"}}]")]
        public virtual void PutLogs(aws.Mq.IMqBrokerLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mq.IMqBrokerLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindowStartTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mq.MqBrokerMaintenanceWindowStartTime\"}}]")]
        public virtual void PutMaintenanceWindowStartTime(aws.Mq.IMqBrokerMaintenanceWindowStartTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mq.IMqBrokerMaintenanceWindowStartTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplyImmediately")]
        public virtual void ResetApplyImmediately()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoMinorVersionUpgrade")]
        public virtual void ResetAutoMinorVersionUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentMode")]
        public virtual void ResetDeploymentMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionOptions")]
        public virtual void ResetEncryptionOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindowStartTime")]
        public virtual void ResetMaintenanceWindowStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPubliclyAccessible")]
        public virtual void ResetPubliclyAccessible()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetIds")]
        public virtual void ResetSubnetIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Mq.MqBroker))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.mq.MqBrokerConfigurationOutputReference\"}")]
        public virtual aws.Mq.MqBrokerConfigurationOutputReference Configuration
        {
            get => GetInstanceProperty<aws.Mq.MqBrokerConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "encryptionOptions", typeJson: "{\"fqn\":\"aws.mq.MqBrokerEncryptionOptionsOutputReference\"}")]
        public virtual aws.Mq.MqBrokerEncryptionOptionsOutputReference EncryptionOptions
        {
            get => GetInstanceProperty<aws.Mq.MqBrokerEncryptionOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"aws.mq.MqBrokerInstancesList\"}")]
        public virtual aws.Mq.MqBrokerInstancesList Instances
        {
            get => GetInstanceProperty<aws.Mq.MqBrokerInstancesList>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"aws.mq.MqBrokerLogsOutputReference\"}")]
        public virtual aws.Mq.MqBrokerLogsOutputReference Logs
        {
            get => GetInstanceProperty<aws.Mq.MqBrokerLogsOutputReference>()!;
        }

        [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"fqn\":\"aws.mq.MqBrokerMaintenanceWindowStartTimeOutputReference\"}")]
        public virtual aws.Mq.MqBrokerMaintenanceWindowStartTimeOutputReference MaintenanceWindowStartTime
        {
            get => GetInstanceProperty<aws.Mq.MqBrokerMaintenanceWindowStartTimeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyImmediatelyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ApplyImmediatelyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoMinorVersionUpgradeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoMinorVersionUpgradeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrokerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"fqn\":\"aws.mq.MqBrokerConfiguration\"}", isOptional: true)]
        public virtual aws.Mq.IMqBrokerConfiguration? ConfigurationInput
        {
            get => GetInstanceProperty<aws.Mq.IMqBrokerConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionOptionsInput", typeJson: "{\"fqn\":\"aws.mq.MqBrokerEncryptionOptions\"}", isOptional: true)]
        public virtual aws.Mq.IMqBrokerEncryptionOptions? EncryptionOptionsInput
        {
            get => GetInstanceProperty<aws.Mq.IMqBrokerEncryptionOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostInstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostInstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsInput", typeJson: "{\"fqn\":\"aws.mq.MqBrokerLogs\"}", isOptional: true)]
        public virtual aws.Mq.IMqBrokerLogs? LogsInput
        {
            get => GetInstanceProperty<aws.Mq.IMqBrokerLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowStartTimeInput", typeJson: "{\"fqn\":\"aws.mq.MqBrokerMaintenanceWindowStartTime\"}", isOptional: true)]
        public virtual aws.Mq.IMqBrokerMaintenanceWindowStartTime? MaintenanceWindowStartTimeInput
        {
            get => GetInstanceProperty<aws.Mq.IMqBrokerMaintenanceWindowStartTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessibleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PubliclyAccessibleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mq.MqBrokerUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UserInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ApplyImmediately
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoMinorVersionUpgrade
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostInstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PubliclyAccessible
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "user", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mq.MqBrokerUser\"},\"kind\":\"array\"}}]}}")]
        public virtual object User
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
