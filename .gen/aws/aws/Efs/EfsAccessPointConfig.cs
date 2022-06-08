using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    #pragma warning disable CS8618

    /// <summary>AWS EFS.</summary>
    [JsiiByValue(fqn: "aws.efs.EfsAccessPointConfig")]
    public class EfsAccessPointConfig : aws.Efs.IEfsAccessPointConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#file_system_id EfsAccessPoint#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemId
        {
            get;
            set;
        }

        /// <summary>posix_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#posix_user EfsAccessPoint#posix_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "posixUser", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointPosixUser\"}", isOptional: true)]
        public aws.Efs.IEfsAccessPointPosixUser? PosixUser
        {
            get;
            set;
        }

        /// <summary>root_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#root_directory EfsAccessPoint#root_directory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectory\"}", isOptional: true)]
        public aws.Efs.IEfsAccessPointRootDirectory? RootDirectory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#tags EfsAccessPoint#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
