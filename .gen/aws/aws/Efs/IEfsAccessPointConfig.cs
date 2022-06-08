using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    /// <summary>AWS EFS.</summary>
    [JsiiInterface(nativeType: typeof(IEfsAccessPointConfig), fullyQualifiedName: "aws.efs.EfsAccessPointConfig")]
    public interface IEfsAccessPointConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#file_system_id EfsAccessPoint#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>posix_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#posix_user EfsAccessPoint#posix_user}
        /// </remarks>
        [JsiiProperty(name: "posixUser", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointPosixUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Efs.IEfsAccessPointPosixUser? PosixUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#root_directory EfsAccessPoint#root_directory}
        /// </remarks>
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Efs.IEfsAccessPointRootDirectory? RootDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#tags EfsAccessPoint#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EFS.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEfsAccessPointConfig), fullyQualifiedName: "aws.efs.EfsAccessPointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Efs.IEfsAccessPointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#file_system_id EfsAccessPoint#file_system_id}.</summary>
            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>posix_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#posix_user EfsAccessPoint#posix_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "posixUser", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointPosixUser\"}", isOptional: true)]
            public aws.Efs.IEfsAccessPointPosixUser? PosixUser
            {
                get => GetInstanceProperty<aws.Efs.IEfsAccessPointPosixUser?>();
            }

            /// <summary>root_directory block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#root_directory EfsAccessPoint#root_directory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootDirectory", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectory\"}", isOptional: true)]
            public aws.Efs.IEfsAccessPointRootDirectory? RootDirectory
            {
                get => GetInstanceProperty<aws.Efs.IEfsAccessPointRootDirectory?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#tags EfsAccessPoint#tags}.</summary>
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
