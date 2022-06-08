using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/mq_broker aws_mq_broker}.</summary>
    [JsiiClass(nativeType: typeof(aws.Mq.DataAwsMqBroker), fullyQualifiedName: "aws.mq.DataAwsMqBroker", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerConfig\"}}]")]
    public class DataAwsMqBroker : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/mq_broker aws_mq_broker} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsMqBroker(Constructs.Construct scope, string id, aws.Mq.IDataAwsMqBrokerConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBroker(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBroker(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerLogs\"}}]")]
        public virtual void PutLogs(aws.Mq.IDataAwsMqBrokerLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mq.IDataAwsMqBrokerLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBrokerId")]
        public virtual void ResetBrokerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBrokerName")]
        public virtual void ResetBrokerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
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
        = GetStaticProperty<string>(typeof(aws.Mq.DataAwsMqBroker))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AutoMinorVersionUpgrade
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerConfigurationList\"}")]
        public virtual aws.Mq.DataAwsMqBrokerConfigurationList Configuration
        {
            get => GetInstanceProperty<aws.Mq.DataAwsMqBrokerConfigurationList>()!;
        }

        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionOptions", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerEncryptionOptionsList\"}")]
        public virtual aws.Mq.DataAwsMqBrokerEncryptionOptionsList EncryptionOptions
        {
            get => GetInstanceProperty<aws.Mq.DataAwsMqBrokerEncryptionOptionsList>()!;
        }

        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostInstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerInstancesList\"}")]
        public virtual aws.Mq.DataAwsMqBrokerInstancesList Instances
        {
            get => GetInstanceProperty<aws.Mq.DataAwsMqBrokerInstancesList>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerLogsOutputReference\"}")]
        public virtual aws.Mq.DataAwsMqBrokerLogsOutputReference Logs
        {
            get => GetInstanceProperty<aws.Mq.DataAwsMqBrokerLogsOutputReference>()!;
        }

        [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerMaintenanceWindowStartTimeList\"}")]
        public virtual aws.Mq.DataAwsMqBrokerMaintenanceWindowStartTimeList MaintenanceWindowStartTime
        {
            get => GetInstanceProperty<aws.Mq.DataAwsMqBrokerMaintenanceWindowStartTimeList>()!;
        }

        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PubliclyAccessible
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerUserList\"}")]
        public virtual aws.Mq.DataAwsMqBrokerUserList User
        {
            get => GetInstanceProperty<aws.Mq.DataAwsMqBrokerUserList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrokerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrokerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsInput", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerLogs\"}", isOptional: true)]
        public virtual aws.Mq.IDataAwsMqBrokerLogs? LogsInput
        {
            get => GetInstanceProperty<aws.Mq.IDataAwsMqBrokerLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerName
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
