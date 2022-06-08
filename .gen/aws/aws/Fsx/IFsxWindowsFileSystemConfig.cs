using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    /// <summary>AWS File System FSx.</summary>
    [JsiiInterface(nativeType: typeof(IFsxWindowsFileSystemConfig), fullyQualifiedName: "aws.fsx.FsxWindowsFileSystemConfig")]
    public interface IFsxWindowsFileSystemConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#storage_capacity FsxWindowsFileSystem#storage_capacity}.</summary>
        [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double StorageCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#subnet_ids FsxWindowsFileSystem#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#throughput_capacity FsxWindowsFileSystem#throughput_capacity}.</summary>
        [JsiiProperty(name: "throughputCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double ThroughputCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#active_directory_id FsxWindowsFileSystem#active_directory_id}.</summary>
        [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActiveDirectoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#automatic_backup_retention_days FsxWindowsFileSystem#automatic_backup_retention_days}.</summary>
        [JsiiProperty(name: "automaticBackupRetentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutomaticBackupRetentionDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#copy_tags_to_backups FsxWindowsFileSystem#copy_tags_to_backups}.</summary>
        [JsiiProperty(name: "copyTagsToBackups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CopyTagsToBackups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#daily_automatic_backup_start_time FsxWindowsFileSystem#daily_automatic_backup_start_time}.</summary>
        [JsiiProperty(name: "dailyAutomaticBackupStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DailyAutomaticBackupStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#kms_key_id FsxWindowsFileSystem#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#security_group_ids FsxWindowsFileSystem#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>self_managed_active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#self_managed_active_directory FsxWindowsFileSystem#self_managed_active_directory}
        /// </remarks>
        [JsiiProperty(name: "selfManagedActiveDirectory", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemSelfManagedActiveDirectory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Fsx.IFsxWindowsFileSystemSelfManagedActiveDirectory? SelfManagedActiveDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#skip_final_backup FsxWindowsFileSystem#skip_final_backup}.</summary>
        [JsiiProperty(name: "skipFinalBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipFinalBackup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#tags FsxWindowsFileSystem#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#timeouts FsxWindowsFileSystem#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Fsx.IFsxWindowsFileSystemTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#weekly_maintenance_start_time FsxWindowsFileSystem#weekly_maintenance_start_time}.</summary>
        [JsiiProperty(name: "weeklyMaintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeeklyMaintenanceStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS File System FSx.</summary>
        [JsiiTypeProxy(nativeType: typeof(IFsxWindowsFileSystemConfig), fullyQualifiedName: "aws.fsx.FsxWindowsFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxWindowsFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#storage_capacity FsxWindowsFileSystem#storage_capacity}.</summary>
            [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double StorageCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#subnet_ids FsxWindowsFileSystem#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#throughput_capacity FsxWindowsFileSystem#throughput_capacity}.</summary>
            [JsiiProperty(name: "throughputCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double ThroughputCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#active_directory_id FsxWindowsFileSystem#active_directory_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActiveDirectoryId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#automatic_backup_retention_days FsxWindowsFileSystem#automatic_backup_retention_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticBackupRetentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutomaticBackupRetentionDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#copy_tags_to_backups FsxWindowsFileSystem#copy_tags_to_backups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copyTagsToBackups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CopyTagsToBackups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#daily_automatic_backup_start_time FsxWindowsFileSystem#daily_automatic_backup_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dailyAutomaticBackupStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DailyAutomaticBackupStartTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#kms_key_id FsxWindowsFileSystem#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#security_group_ids FsxWindowsFileSystem#security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>self_managed_active_directory block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#self_managed_active_directory FsxWindowsFileSystem#self_managed_active_directory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfManagedActiveDirectory", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemSelfManagedActiveDirectory\"}", isOptional: true)]
            public aws.Fsx.IFsxWindowsFileSystemSelfManagedActiveDirectory? SelfManagedActiveDirectory
            {
                get => GetInstanceProperty<aws.Fsx.IFsxWindowsFileSystemSelfManagedActiveDirectory?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#skip_final_backup FsxWindowsFileSystem#skip_final_backup}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipFinalBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipFinalBackup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#tags FsxWindowsFileSystem#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#timeouts FsxWindowsFileSystem#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemTimeouts\"}", isOptional: true)]
            public aws.Fsx.IFsxWindowsFileSystemTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Fsx.IFsxWindowsFileSystemTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#weekly_maintenance_start_time FsxWindowsFileSystem#weekly_maintenance_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weeklyMaintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeeklyMaintenanceStartTime
            {
                get => GetInstanceProperty<string?>();
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
