using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    /// <summary>AWS DataSync.</summary>
    [JsiiInterface(nativeType: typeof(IDatasyncLocationSmbConfig), fullyQualifiedName: "aws.datasync.DatasyncLocationSmbConfig")]
    public interface IDatasyncLocationSmbConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#agent_arns DatasyncLocationSmb#agent_arns}.</summary>
        [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AgentArns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#password DatasyncLocationSmb#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#server_hostname DatasyncLocationSmb#server_hostname}.</summary>
        [JsiiProperty(name: "serverHostname", typeJson: "{\"primitive\":\"string\"}")]
        string ServerHostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#subdirectory DatasyncLocationSmb#subdirectory}.</summary>
        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
        string Subdirectory
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#user DatasyncLocationSmb#user}.</summary>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        string User
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#domain DatasyncLocationSmb#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>mount_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#mount_options DatasyncLocationSmb#mount_options}
        /// </remarks>
        [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationSmbMountOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Datasync.IDatasyncLocationSmbMountOptions? MountOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#tags DatasyncLocationSmb#tags}.</summary>
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
        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationSmbConfig), fullyQualifiedName: "aws.datasync.DatasyncLocationSmbConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Datasync.IDatasyncLocationSmbConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#agent_arns DatasyncLocationSmb#agent_arns}.</summary>
            [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AgentArns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#password DatasyncLocationSmb#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#server_hostname DatasyncLocationSmb#server_hostname}.</summary>
            [JsiiProperty(name: "serverHostname", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerHostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#subdirectory DatasyncLocationSmb#subdirectory}.</summary>
            [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
            public string Subdirectory
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#user DatasyncLocationSmb#user}.</summary>
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
            public string User
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#domain DatasyncLocationSmb#domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>mount_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#mount_options DatasyncLocationSmb#mount_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationSmbMountOptions\"}", isOptional: true)]
            public aws.Datasync.IDatasyncLocationSmbMountOptions? MountOptions
            {
                get => GetInstanceProperty<aws.Datasync.IDatasyncLocationSmbMountOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_smb#tags DatasyncLocationSmb#tags}.</summary>
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
