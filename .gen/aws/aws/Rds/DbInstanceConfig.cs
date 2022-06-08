using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    #pragma warning disable CS8618

    /// <summary>AWS Relational Database Service.</summary>
    [JsiiByValue(fqn: "aws.rds.DbInstanceConfig")]
    public class DbInstanceConfig : aws.Rds.IDbInstanceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#instance_class DbInstance#instance_class}.</summary>
        [JsiiProperty(name: "instanceClass", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#allocated_storage DbInstance#allocated_storage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocatedStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AllocatedStorage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#allow_major_version_upgrade DbInstance#allow_major_version_upgrade}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowMajorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowMajorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#apply_immediately DbInstance#apply_immediately}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ApplyImmediately
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#auto_minor_version_upgrade DbInstance#auto_minor_version_upgrade}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoMinorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#availability_zone DbInstance#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#backup_retention_period DbInstance#backup_retention_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupRetentionPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#backup_window DbInstance#backup_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#ca_cert_identifier DbInstance#ca_cert_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caCertIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaCertIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#character_set_name DbInstance#character_set_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "characterSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CharacterSetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#copy_tags_to_snapshot DbInstance#copy_tags_to_snapshot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyTagsToSnapshot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CopyTagsToSnapshot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#db_subnet_group_name DbInstance#db_subnet_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbSubnetGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#delete_automated_backups DbInstance#delete_automated_backups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteAutomatedBackups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteAutomatedBackups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#deletion_protection DbInstance#deletion_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeletionProtection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#domain DbInstance#domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#domain_iam_role_name DbInstance#domain_iam_role_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainIamRoleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainIamRoleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#enabled_cloudwatch_logs_exports DbInstance#enabled_cloudwatch_logs_exports}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledCloudwatchLogsExports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EnabledCloudwatchLogsExports
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#engine DbInstance#engine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Engine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#engine_version DbInstance#engine_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#final_snapshot_identifier DbInstance#final_snapshot_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "finalSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FinalSnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#iam_database_authentication_enabled DbInstance#iam_database_authentication_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamDatabaseAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IamDatabaseAuthenticationEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#identifier DbInstance#identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#identifier_prefix DbInstance#identifier_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentifierPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#iops DbInstance#iops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Iops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#kms_key_id DbInstance#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#license_model DbInstance#license_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#maintenance_window DbInstance#maintenance_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#max_allocated_storage DbInstance#max_allocated_storage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAllocatedStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAllocatedStorage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#monitoring_interval DbInstance#monitoring_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monitoringInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MonitoringInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#monitoring_role_arn DbInstance#monitoring_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monitoringRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MonitoringRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#multi_az DbInstance#multi_az}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multiAz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MultiAz
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#name DbInstance#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#option_group_name DbInstance#option_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "optionGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OptionGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#parameter_group_name DbInstance#parameter_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#password DbInstance#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#performance_insights_enabled DbInstance#performance_insights_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "performanceInsightsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PerformanceInsightsEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#performance_insights_kms_key_id DbInstance#performance_insights_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "performanceInsightsKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PerformanceInsightsKmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#performance_insights_retention_period DbInstance#performance_insights_retention_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "performanceInsightsRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PerformanceInsightsRetentionPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#port DbInstance#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#publicly_accessible DbInstance#publicly_accessible}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PubliclyAccessible
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#replicate_source_db DbInstance#replicate_source_db}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicateSourceDb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicateSourceDb
        {
            get;
            set;
        }

        /// <summary>s3_import block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#s3_import DbInstance#s3_import}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Import", typeJson: "{\"fqn\":\"aws.rds.DbInstanceS3Import\"}", isOptional: true)]
        public aws.Rds.IDbInstanceS3Import? S3Import
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#security_group_names DbInstance#security_group_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#skip_final_snapshot DbInstance#skip_final_snapshot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipFinalSnapshot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SkipFinalSnapshot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#snapshot_identifier DbInstance#snapshot_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#storage_encrypted DbInstance#storage_encrypted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? StorageEncrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#storage_type DbInstance#storage_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#tags DbInstance#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#timeouts DbInstance#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.rds.DbInstanceTimeouts\"}", isOptional: true)]
        public aws.Rds.IDbInstanceTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#timezone DbInstance#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#username DbInstance#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_instance#vpc_security_group_ids DbInstance#vpc_security_group_ids}.</summary>
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
