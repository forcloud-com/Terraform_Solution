using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    /// <summary>AWS DataSync.</summary>
    [JsiiInterface(nativeType: typeof(IDatasyncLocationEfsConfig), fullyQualifiedName: "aws.datasync.DatasyncLocationEfsConfig")]
    public interface IDatasyncLocationEfsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>ec2_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_efs#ec2_config DatasyncLocationEfs#ec2_config}
        /// </remarks>
        [JsiiProperty(name: "ec2Config", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationEfsEc2Config\"}")]
        aws.Datasync.IDatasyncLocationEfsEc2Config Ec2Config
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_efs#efs_file_system_arn DatasyncLocationEfs#efs_file_system_arn}.</summary>
        [JsiiProperty(name: "efsFileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
        string EfsFileSystemArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_efs#subdirectory DatasyncLocationEfs#subdirectory}.</summary>
        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subdirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_efs#tags DatasyncLocationEfs#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS DataSync.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationEfsConfig), fullyQualifiedName: "aws.datasync.DatasyncLocationEfsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Datasync.IDatasyncLocationEfsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ec2_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_efs#ec2_config DatasyncLocationEfs#ec2_config}
            /// </remarks>
            [JsiiProperty(name: "ec2Config", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationEfsEc2Config\"}")]
            public aws.Datasync.IDatasyncLocationEfsEc2Config Ec2Config
            {
                get => GetInstanceProperty<aws.Datasync.IDatasyncLocationEfsEc2Config>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_efs#efs_file_system_arn DatasyncLocationEfs#efs_file_system_arn}.</summary>
            [JsiiProperty(name: "efsFileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
            public string EfsFileSystemArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_efs#subdirectory DatasyncLocationEfs#subdirectory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Subdirectory
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_efs#tags DatasyncLocationEfs#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
