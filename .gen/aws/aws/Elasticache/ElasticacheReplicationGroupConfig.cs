using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticache
{
    #pragma warning disable CS8618

    /// <summary>AWS ElastiCache.</summary>
    [JsiiByValue(fqn: "aws.elasticache.ElasticacheReplicationGroupConfig")]
    public class ElasticacheReplicationGroupConfig : aws.Elasticache.IElasticacheReplicationGroupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#replication_group_description ElasticacheReplicationGroup#replication_group_description}.</summary>
        [JsiiProperty(name: "replicationGroupDescription", typeJson: "{\"primitive\":\"string\"}")]
        public string ReplicationGroupDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#replication_group_id ElasticacheReplicationGroup#replication_group_id}.</summary>
        [JsiiProperty(name: "replicationGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string ReplicationGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#apply_immediately ElasticacheReplicationGroup#apply_immediately}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ApplyImmediately
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#at_rest_encryption_enabled ElasticacheReplicationGroup#at_rest_encryption_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "atRestEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AtRestEncryptionEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#auth_token ElasticacheReplicationGroup#auth_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#automatic_failover_enabled ElasticacheReplicationGroup#automatic_failover_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automaticFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutomaticFailoverEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#auto_minor_version_upgrade ElasticacheReplicationGroup#auto_minor_version_upgrade}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoMinorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#availability_zones ElasticacheReplicationGroup#availability_zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AvailabilityZones
        {
            get;
            set;
        }

        /// <summary>cluster_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#cluster_mode ElasticacheReplicationGroup#cluster_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterMode", typeJson: "{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupClusterMode\"}", isOptional: true)]
        public aws.Elasticache.IElasticacheReplicationGroupClusterMode? ClusterMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#engine ElasticacheReplicationGroup#engine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Engine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#engine_version ElasticacheReplicationGroup#engine_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#kms_key_id ElasticacheReplicationGroup#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#maintenance_window ElasticacheReplicationGroup#maintenance_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#node_type ElasticacheReplicationGroup#node_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#notification_topic_arn ElasticacheReplicationGroup#notification_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationTopicArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#number_cache_clusters ElasticacheReplicationGroup#number_cache_clusters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberCacheClusters", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberCacheClusters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#parameter_group_name ElasticacheReplicationGroup#parameter_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#port ElasticacheReplicationGroup#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#security_group_ids ElasticacheReplicationGroup#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#security_group_names ElasticacheReplicationGroup#security_group_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#snapshot_arns ElasticacheReplicationGroup#snapshot_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SnapshotArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#snapshot_name ElasticacheReplicationGroup#snapshot_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#snapshot_retention_limit ElasticacheReplicationGroup#snapshot_retention_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotRetentionLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SnapshotRetentionLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#snapshot_window ElasticacheReplicationGroup#snapshot_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#subnet_group_name ElasticacheReplicationGroup#subnet_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#tags ElasticacheReplicationGroup#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#timeouts ElasticacheReplicationGroup#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticache.ElasticacheReplicationGroupTimeouts\"}", isOptional: true)]
        public aws.Elasticache.IElasticacheReplicationGroupTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_replication_group#transit_encryption_enabled ElasticacheReplicationGroup#transit_encryption_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TransitEncryptionEnabled
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
