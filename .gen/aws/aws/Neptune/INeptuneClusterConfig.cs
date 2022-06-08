using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Neptune
{
    /// <summary>AWS Neptune.</summary>
    [JsiiInterface(nativeType: typeof(INeptuneClusterConfig), fullyQualifiedName: "aws.neptune.NeptuneClusterConfig")]
    public interface INeptuneClusterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#apply_immediately NeptuneCluster#apply_immediately}.</summary>
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplyImmediately
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#availability_zones NeptuneCluster#availability_zones}.</summary>
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AvailabilityZones
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#backup_retention_period NeptuneCluster#backup_retention_period}.</summary>
        [JsiiProperty(name: "backupRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupRetentionPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#cluster_identifier NeptuneCluster#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#cluster_identifier_prefix NeptuneCluster#cluster_identifier_prefix}.</summary>
        [JsiiProperty(name: "clusterIdentifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterIdentifierPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#deletion_protection NeptuneCluster#deletion_protection}.</summary>
        [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeletionProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#enable_cloudwatch_logs_exports NeptuneCluster#enable_cloudwatch_logs_exports}.</summary>
        [JsiiProperty(name: "enableCloudwatchLogsExports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EnableCloudwatchLogsExports
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#engine NeptuneCluster#engine}.</summary>
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Engine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#engine_version NeptuneCluster#engine_version}.</summary>
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EngineVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#final_snapshot_identifier NeptuneCluster#final_snapshot_identifier}.</summary>
        [JsiiProperty(name: "finalSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FinalSnapshotIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#iam_database_authentication_enabled NeptuneCluster#iam_database_authentication_enabled}.</summary>
        [JsiiProperty(name: "iamDatabaseAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IamDatabaseAuthenticationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#iam_roles NeptuneCluster#iam_roles}.</summary>
        [JsiiProperty(name: "iamRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IamRoles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#kms_key_arn NeptuneCluster#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#neptune_cluster_parameter_group_name NeptuneCluster#neptune_cluster_parameter_group_name}.</summary>
        [JsiiProperty(name: "neptuneClusterParameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NeptuneClusterParameterGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#neptune_subnet_group_name NeptuneCluster#neptune_subnet_group_name}.</summary>
        [JsiiProperty(name: "neptuneSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NeptuneSubnetGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#port NeptuneCluster#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#preferred_backup_window NeptuneCluster#preferred_backup_window}.</summary>
        [JsiiProperty(name: "preferredBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredBackupWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#preferred_maintenance_window NeptuneCluster#preferred_maintenance_window}.</summary>
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredMaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#replication_source_identifier NeptuneCluster#replication_source_identifier}.</summary>
        [JsiiProperty(name: "replicationSourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicationSourceIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#skip_final_snapshot NeptuneCluster#skip_final_snapshot}.</summary>
        [JsiiProperty(name: "skipFinalSnapshot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipFinalSnapshot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#snapshot_identifier NeptuneCluster#snapshot_identifier}.</summary>
        [JsiiProperty(name: "snapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnapshotIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#storage_encrypted NeptuneCluster#storage_encrypted}.</summary>
        [JsiiProperty(name: "storageEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageEncrypted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#tags NeptuneCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#timeouts NeptuneCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.neptune.NeptuneClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Neptune.INeptuneClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#vpc_security_group_ids NeptuneCluster#vpc_security_group_ids}.</summary>
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Neptune.</summary>
        [JsiiTypeProxy(nativeType: typeof(INeptuneClusterConfig), fullyQualifiedName: "aws.neptune.NeptuneClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Neptune.INeptuneClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#apply_immediately NeptuneCluster#apply_immediately}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ApplyImmediately
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#availability_zones NeptuneCluster#availability_zones}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AvailabilityZones
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#backup_retention_period NeptuneCluster#backup_retention_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupRetentionPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#cluster_identifier NeptuneCluster#cluster_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#cluster_identifier_prefix NeptuneCluster#cluster_identifier_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterIdentifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterIdentifierPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#deletion_protection NeptuneCluster#deletion_protection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DeletionProtection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#enable_cloudwatch_logs_exports NeptuneCluster#enable_cloudwatch_logs_exports}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableCloudwatchLogsExports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EnableCloudwatchLogsExports
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#engine NeptuneCluster#engine}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Engine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#engine_version NeptuneCluster#engine_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EngineVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#final_snapshot_identifier NeptuneCluster#final_snapshot_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "finalSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FinalSnapshotIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#iam_database_authentication_enabled NeptuneCluster#iam_database_authentication_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamDatabaseAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IamDatabaseAuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#iam_roles NeptuneCluster#iam_roles}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IamRoles
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#kms_key_arn NeptuneCluster#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#neptune_cluster_parameter_group_name NeptuneCluster#neptune_cluster_parameter_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "neptuneClusterParameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NeptuneClusterParameterGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#neptune_subnet_group_name NeptuneCluster#neptune_subnet_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "neptuneSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NeptuneSubnetGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#port NeptuneCluster#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#preferred_backup_window NeptuneCluster#preferred_backup_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredBackupWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#preferred_maintenance_window NeptuneCluster#preferred_maintenance_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredMaintenanceWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#replication_source_identifier NeptuneCluster#replication_source_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationSourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicationSourceIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#skip_final_snapshot NeptuneCluster#skip_final_snapshot}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipFinalSnapshot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipFinalSnapshot
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#snapshot_identifier NeptuneCluster#snapshot_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnapshotIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#storage_encrypted NeptuneCluster#storage_encrypted}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? StorageEncrypted
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#tags NeptuneCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#timeouts NeptuneCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.neptune.NeptuneClusterTimeouts\"}", isOptional: true)]
            public aws.Neptune.INeptuneClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Neptune.INeptuneClusterTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster#vpc_security_group_ids NeptuneCluster#vpc_security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
