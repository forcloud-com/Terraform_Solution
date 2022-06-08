using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticache
{
    #pragma warning disable CS8618

    /// <summary>AWS ElastiCache.</summary>
    [JsiiByValue(fqn: "aws.elasticache.ElasticacheClusterConfig")]
    public class ElasticacheClusterConfig : aws.Elasticache.IElasticacheClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#cluster_id ElasticacheCluster#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#apply_immediately ElasticacheCluster#apply_immediately}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ApplyImmediately
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#availability_zone ElasticacheCluster#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#availability_zones ElasticacheCluster#availability_zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AvailabilityZones
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#az_mode ElasticacheCluster#az_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#engine ElasticacheCluster#engine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Engine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#engine_version ElasticacheCluster#engine_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#maintenance_window ElasticacheCluster#maintenance_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#node_type ElasticacheCluster#node_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#notification_topic_arn ElasticacheCluster#notification_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationTopicArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#num_cache_nodes ElasticacheCluster#num_cache_nodes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numCacheNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumCacheNodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#parameter_group_name ElasticacheCluster#parameter_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#port ElasticacheCluster#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#preferred_availability_zones ElasticacheCluster#preferred_availability_zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredAvailabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PreferredAvailabilityZones
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#replication_group_id ElasticacheCluster#replication_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicationGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#security_group_ids ElasticacheCluster#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#security_group_names ElasticacheCluster#security_group_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#snapshot_arns ElasticacheCluster#snapshot_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SnapshotArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#snapshot_name ElasticacheCluster#snapshot_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#snapshot_retention_limit ElasticacheCluster#snapshot_retention_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotRetentionLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SnapshotRetentionLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#snapshot_window ElasticacheCluster#snapshot_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#subnet_group_name ElasticacheCluster#subnet_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_cluster#tags ElasticacheCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
