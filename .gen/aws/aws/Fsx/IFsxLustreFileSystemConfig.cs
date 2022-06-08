using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    /// <summary>AWS File System FSx.</summary>
    [JsiiInterface(nativeType: typeof(IFsxLustreFileSystemConfig), fullyQualifiedName: "aws.fsx.FsxLustreFileSystemConfig")]
    public interface IFsxLustreFileSystemConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#storage_capacity FsxLustreFileSystem#storage_capacity}.</summary>
        [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double StorageCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#subnet_ids FsxLustreFileSystem#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#export_path FsxLustreFileSystem#export_path}.</summary>
        [JsiiProperty(name: "exportPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExportPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#imported_file_chunk_size FsxLustreFileSystem#imported_file_chunk_size}.</summary>
        [JsiiProperty(name: "importedFileChunkSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ImportedFileChunkSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#import_path FsxLustreFileSystem#import_path}.</summary>
        [JsiiProperty(name: "importPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImportPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#security_group_ids FsxLustreFileSystem#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#tags FsxLustreFileSystem#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#timeouts FsxLustreFileSystem#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxLustreFileSystemTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Fsx.IFsxLustreFileSystemTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#weekly_maintenance_start_time FsxLustreFileSystem#weekly_maintenance_start_time}.</summary>
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
        [JsiiTypeProxy(nativeType: typeof(IFsxLustreFileSystemConfig), fullyQualifiedName: "aws.fsx.FsxLustreFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxLustreFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#storage_capacity FsxLustreFileSystem#storage_capacity}.</summary>
            [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double StorageCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#subnet_ids FsxLustreFileSystem#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#export_path FsxLustreFileSystem#export_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exportPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExportPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#imported_file_chunk_size FsxLustreFileSystem#imported_file_chunk_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "importedFileChunkSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ImportedFileChunkSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#import_path FsxLustreFileSystem#import_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "importPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImportPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#security_group_ids FsxLustreFileSystem#security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#tags FsxLustreFileSystem#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#timeouts FsxLustreFileSystem#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxLustreFileSystemTimeouts\"}", isOptional: true)]
            public aws.Fsx.IFsxLustreFileSystemTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Fsx.IFsxLustreFileSystemTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#weekly_maintenance_start_time FsxLustreFileSystem#weekly_maintenance_start_time}.</summary>
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
