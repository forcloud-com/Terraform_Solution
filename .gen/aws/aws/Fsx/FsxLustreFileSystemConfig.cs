using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    #pragma warning disable CS8618

    /// <summary>AWS File System FSx.</summary>
    [JsiiByValue(fqn: "aws.fsx.FsxLustreFileSystemConfig")]
    public class FsxLustreFileSystemConfig : aws.Fsx.IFsxLustreFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#storage_capacity FsxLustreFileSystem#storage_capacity}.</summary>
        [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double StorageCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#subnet_ids FsxLustreFileSystem#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#export_path FsxLustreFileSystem#export_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exportPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExportPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#imported_file_chunk_size FsxLustreFileSystem#imported_file_chunk_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "importedFileChunkSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImportedFileChunkSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#import_path FsxLustreFileSystem#import_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "importPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImportPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#security_group_ids FsxLustreFileSystem#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#tags FsxLustreFileSystem#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#timeouts FsxLustreFileSystem#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxLustreFileSystemTimeouts\"}", isOptional: true)]
        public aws.Fsx.IFsxLustreFileSystemTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_lustre_file_system#weekly_maintenance_start_time FsxLustreFileSystem#weekly_maintenance_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeklyMaintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WeeklyMaintenanceStartTime
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
