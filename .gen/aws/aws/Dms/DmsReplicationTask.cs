using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task aws_dms_replication_task}.</summary>
    [JsiiClass(nativeType: typeof(aws.Dms.DmsReplicationTask), fullyQualifiedName: "aws.dms.DmsReplicationTask", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dms.DmsReplicationTaskConfig\"}}]")]
    public class DmsReplicationTask : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task aws_dms_replication_task} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DmsReplicationTask(Constructs.Construct scope, string id, aws.Dms.IDmsReplicationTaskConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsReplicationTask(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsReplicationTask(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCdcStartTime")]
        public virtual void ResetCdcStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationTaskSettings")]
        public virtual void ResetReplicationTaskSettings()
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
        = GetStaticProperty<string>(typeof(aws.Dms.DmsReplicationTask))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationTaskArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationTaskArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdcStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CdcStartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "migrationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MigrationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationInstanceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationInstanceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationTaskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationTaskIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationTaskSettingsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationTaskSettingsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceEndpointArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceEndpointArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableMappingsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableMappingsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetEndpointArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetEndpointArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cdcStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdcStartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "migrationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationInstanceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationTaskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationTaskId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationTaskSettings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationTaskSettings
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceEndpointArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableMappings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableMappings
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

        [JsiiProperty(name: "targetEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetEndpointArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
