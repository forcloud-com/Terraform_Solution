using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system aws_fsx_windows_file_system}.</summary>
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxWindowsFileSystem), fullyQualifiedName: "aws.fsx.FsxWindowsFileSystem", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.fsx.FsxWindowsFileSystemConfig\"}}]")]
    public class FsxWindowsFileSystem : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system aws_fsx_windows_file_system} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FsxWindowsFileSystem(Constructs.Construct scope, string id, aws.Fsx.IFsxWindowsFileSystemConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxWindowsFileSystem(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxWindowsFileSystem(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSelfManagedActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxWindowsFileSystemSelfManagedActiveDirectory\"}}]")]
        public virtual void PutSelfManagedActiveDirectory(aws.Fsx.IFsxWindowsFileSystemSelfManagedActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxWindowsFileSystemSelfManagedActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxWindowsFileSystemTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Fsx.IFsxWindowsFileSystemTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxWindowsFileSystemTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectoryId")]
        public virtual void ResetActiveDirectoryId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticBackupRetentionDays")]
        public virtual void ResetAutomaticBackupRetentionDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCopyTagsToBackups")]
        public virtual void ResetCopyTagsToBackups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDailyAutomaticBackupStartTime")]
        public virtual void ResetDailyAutomaticBackupStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelfManagedActiveDirectory")]
        public virtual void ResetSelfManagedActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipFinalBackup")]
        public virtual void ResetSkipFinalBackup()
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

        [JsiiMethod(name: "resetWeeklyMaintenanceStartTime")]
        public virtual void ResetWeeklyMaintenanceStartTime()
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
        = GetStaticProperty<string>(typeof(aws.Fsx.FsxWindowsFileSystem))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkInterfaceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkInterfaceIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selfManagedActiveDirectory", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemSelfManagedActiveDirectoryOutputReference\"}")]
        public virtual aws.Fsx.FsxWindowsFileSystemSelfManagedActiveDirectoryOutputReference SelfManagedActiveDirectory
        {
            get => GetInstanceProperty<aws.Fsx.FsxWindowsFileSystemSelfManagedActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemTimeoutsOutputReference\"}")]
        public virtual aws.Fsx.FsxWindowsFileSystemTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Fsx.FsxWindowsFileSystemTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActiveDirectoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticBackupRetentionDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutomaticBackupRetentionDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTagsToBackupsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CopyTagsToBackupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dailyAutomaticBackupStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DailyAutomaticBackupStartTimeInput
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
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfManagedActiveDirectoryInput", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemSelfManagedActiveDirectory\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxWindowsFileSystemSelfManagedActiveDirectory? SelfManagedActiveDirectoryInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxWindowsFileSystemSelfManagedActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipFinalBackupInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SkipFinalBackupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageCapacityInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "throughputCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThroughputCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemTimeouts\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxWindowsFileSystemTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxWindowsFileSystemTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyMaintenanceStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WeeklyMaintenanceStartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveDirectoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "automaticBackupRetentionDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutomaticBackupRetentionDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "copyTagsToBackups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CopyTagsToBackups
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dailyAutomaticBackupStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DailyAutomaticBackupStartTime
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

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skipFinalBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SkipFinalBackup
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageCapacity
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "throughputCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThroughputCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weeklyMaintenanceStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WeeklyMaintenanceStartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
