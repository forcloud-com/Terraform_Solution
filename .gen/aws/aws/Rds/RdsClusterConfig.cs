using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    /// <summary>AWS Relational Database Service.</summary>
    [JsiiByValue(fqn: "aws.rds.RdsClusterConfig")]
    public class RdsClusterConfig : aws.Rds.IRdsClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#apply_immediately RdsCluster#apply_immediately}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ApplyImmediately
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#availability_zones RdsCluster#availability_zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AvailabilityZones
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#backtrack_window RdsCluster#backtrack_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backtrackWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BacktrackWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#backup_retention_period RdsCluster#backup_retention_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupRetentionPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#cluster_identifier RdsCluster#cluster_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#cluster_identifier_prefix RdsCluster#cluster_identifier_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterIdentifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterIdentifierPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#cluster_members RdsCluster#cluster_members}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterMembers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ClusterMembers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#copy_tags_to_snapshot RdsCluster#copy_tags_to_snapshot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyTagsToSnapshot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CopyTagsToSnapshot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#database_name RdsCluster#database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#db_cluster_parameter_group_name RdsCluster#db_cluster_parameter_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbClusterParameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbClusterParameterGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#db_subnet_group_name RdsCluster#db_subnet_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbSubnetGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#deletion_protection RdsCluster#deletion_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeletionProtection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#enabled_cloudwatch_logs_exports RdsCluster#enabled_cloudwatch_logs_exports}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledCloudwatchLogsExports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EnabledCloudwatchLogsExports
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#enable_http_endpoint RdsCluster#enable_http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableHttpEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableHttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#engine RdsCluster#engine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Engine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#engine_mode RdsCluster#engine_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engineMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngineMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#engine_version RdsCluster#engine_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#final_snapshot_identifier RdsCluster#final_snapshot_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "finalSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FinalSnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#global_cluster_identifier RdsCluster#global_cluster_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "globalClusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GlobalClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#iam_database_authentication_enabled RdsCluster#iam_database_authentication_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamDatabaseAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IamDatabaseAuthenticationEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#iam_roles RdsCluster#iam_roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IamRoles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#kms_key_id RdsCluster#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#master_password RdsCluster#master_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#master_username RdsCluster#master_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#port RdsCluster#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#preferred_backup_window RdsCluster#preferred_backup_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredBackupWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#preferred_maintenance_window RdsCluster#preferred_maintenance_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredMaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#replication_source_identifier RdsCluster#replication_source_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationSourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicationSourceIdentifier
        {
            get;
            set;
        }

        /// <summary>s3_import block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#s3_import RdsCluster#s3_import}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Import", typeJson: "{\"fqn\":\"aws.rds.RdsClusterS3Import\"}", isOptional: true)]
        public aws.Rds.IRdsClusterS3Import? S3Import
        {
            get;
            set;
        }

        /// <summary>scaling_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#scaling_configuration RdsCluster#scaling_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scalingConfiguration", typeJson: "{\"fqn\":\"aws.rds.RdsClusterScalingConfiguration\"}", isOptional: true)]
        public aws.Rds.IRdsClusterScalingConfiguration? ScalingConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#skip_final_snapshot RdsCluster#skip_final_snapshot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipFinalSnapshot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SkipFinalSnapshot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#snapshot_identifier RdsCluster#snapshot_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#source_region RdsCluster#source_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#storage_encrypted RdsCluster#storage_encrypted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? StorageEncrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#tags RdsCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#timeouts RdsCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.rds.RdsClusterTimeouts\"}", isOptional: true)]
        public aws.Rds.IRdsClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#vpc_security_group_ids RdsCluster#vpc_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpcSecurityGroupIds
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
