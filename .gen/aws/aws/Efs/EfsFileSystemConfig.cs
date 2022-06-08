using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    /// <summary>AWS EFS.</summary>
    [JsiiByValue(fqn: "aws.efs.EfsFileSystemConfig")]
    public class EfsFileSystemConfig : aws.Efs.IEfsFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#creation_token EfsFileSystem#creation_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "creationToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreationToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#encrypted EfsFileSystem#encrypted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Encrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#kms_key_id EfsFileSystem#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>lifecycle_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#lifecycle_policy EfsFileSystem#lifecycle_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecyclePolicy", typeJson: "{\"fqn\":\"aws.efs.EfsFileSystemLifecyclePolicy\"}", isOptional: true)]
        public aws.Efs.IEfsFileSystemLifecyclePolicy? LifecyclePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#performance_mode EfsFileSystem#performance_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "performanceMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PerformanceMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#provisioned_throughput_in_mibps EfsFileSystem#provisioned_throughput_in_mibps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provisionedThroughputInMibps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProvisionedThroughputInMibps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#reference_name EfsFileSystem#reference_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "referenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferenceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#tags EfsFileSystem#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#throughput_mode EfsFileSystem#throughput_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThroughputMode
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
