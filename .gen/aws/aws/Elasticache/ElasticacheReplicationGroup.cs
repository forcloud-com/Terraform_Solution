using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticache
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group aws_elasticache_replication_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elasticache.ElasticacheReplicationGroup), fullyQualifiedName: "aws.elasticache.ElasticacheReplicationGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupConfig\"}}]")]
    public class ElasticacheReplicationGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group aws_elasticache_replication_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticacheReplicationGroup(Constructs.Construct scope, string id, aws.Elasticache.IElasticacheReplicationGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticacheReplicationGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticacheReplicationGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClusterMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupClusterMode\"}}]")]
        public virtual void PutClusterMode(aws.Elasticache.IElasticacheReplicationGroupClusterMode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticache.IElasticacheReplicationGroupClusterMode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Elasticache.IElasticacheReplicationGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticache.IElasticacheReplicationGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplyImmediately")]
        public virtual void ResetApplyImmediately()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAtRestEncryptionEnabled")]
        public virtual void ResetAtRestEncryptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthToken")]
        public virtual void ResetAuthToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticFailoverEnabled")]
        public virtual void ResetAutomaticFailoverEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoMinorVersionUpgrade")]
        public virtual void ResetAutoMinorVersionUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZones")]
        public virtual void ResetAvailabilityZones()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterMode")]
        public virtual void ResetClusterMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEngine")]
        public virtual void ResetEngine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEngineVersion")]
        public virtual void ResetEngineVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindow")]
        public virtual void ResetMaintenanceWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeType")]
        public virtual void ResetNodeType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationTopicArn")]
        public virtual void ResetNotificationTopicArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberCacheClusters")]
        public virtual void ResetNumberCacheClusters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameterGroupName")]
        public virtual void ResetParameterGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupNames")]
        public virtual void ResetSecurityGroupNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotArns")]
        public virtual void ResetSnapshotArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotName")]
        public virtual void ResetSnapshotName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotRetentionLimit")]
        public virtual void ResetSnapshotRetentionLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotWindow")]
        public virtual void ResetSnapshotWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetGroupName")]
        public virtual void ResetSubnetGroupName()
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

        [JsiiMethod(name: "resetTransitEncryptionEnabled")]
        public virtual void ResetTransitEncryptionEnabled()
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
        = GetStaticProperty<string>(typeof(aws.Elasticache.ElasticacheReplicationGroup))!;

        [JsiiProperty(name: "clusterMode", typeJson: "{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupClusterModeOutputReference\"}")]
        public virtual aws.Elasticache.ElasticacheReplicationGroupClusterModeOutputReference ClusterMode
        {
            get => GetInstanceProperty<aws.Elasticache.ElasticacheReplicationGroupClusterModeOutputReference>()!;
        }

        [JsiiProperty(name: "configurationEndpointAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationEndpointAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memberClusters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MemberClusters
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "primaryEndpointAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryEndpointAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupTimeoutsOutputReference\"}")]
        public virtual aws.Elasticache.ElasticacheReplicationGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Elasticache.ElasticacheReplicationGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyImmediatelyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ApplyImmediatelyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "atRestEncryptionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AtRestEncryptionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticFailoverEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutomaticFailoverEnabledInput
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
        [JsiiProperty(name: "availabilityZonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AvailabilityZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterModeInput", typeJson: "{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupClusterMode\"}", isOptional: true)]
        public virtual aws.Elasticache.IElasticacheReplicationGroupClusterMode? ClusterModeInput
        {
            get => GetInstanceProperty<aws.Elasticache.IElasticacheReplicationGroupClusterMode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineInput
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
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceWindowInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotificationTopicArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberCacheClustersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberCacheClustersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParameterGroupNameInput
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
        [JsiiProperty(name: "replicationGroupDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationGroupDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SnapshotArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotRetentionLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SnapshotRetentionLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotWindowInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotWindowInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetGroupNameInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupTimeouts\"}", isOptional: true)]
        public virtual aws.Elasticache.IElasticacheReplicationGroupTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Elasticache.IElasticacheReplicationGroupTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TransitEncryptionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ApplyImmediately
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "atRestEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AtRestEncryptionEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "automaticFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutomaticFailoverEnabled
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

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Engine
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

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceWindow
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationTopicArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberCacheClusters", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberCacheClusters
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameterGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParameterGroupName
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

        [JsiiProperty(name: "replicationGroupDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationGroupDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SnapshotArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotRetentionLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotRetentionLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotWindow
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetGroupName
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

        [JsiiProperty(name: "transitEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TransitEncryptionEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
