using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    /// <summary>AWS WorkSpaces.</summary>
    [JsiiInterface(nativeType: typeof(IWorkspacesWorkspaceConfig), fullyQualifiedName: "aws.workspaces.WorkspacesWorkspaceConfig")]
    public interface IWorkspacesWorkspaceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#bundle_id WorkspacesWorkspace#bundle_id}.</summary>
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
        string BundleId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#directory_id WorkspacesWorkspace#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#user_name WorkspacesWorkspace#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#root_volume_encryption_enabled WorkspacesWorkspace#root_volume_encryption_enabled}.</summary>
        [JsiiProperty(name: "rootVolumeEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RootVolumeEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#tags WorkspacesWorkspace#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#user_volume_encryption_enabled WorkspacesWorkspace#user_volume_encryption_enabled}.</summary>
        [JsiiProperty(name: "userVolumeEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserVolumeEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#volume_encryption_key WorkspacesWorkspace#volume_encryption_key}.</summary>
        [JsiiProperty(name: "volumeEncryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeEncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>workspace_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#workspace_properties WorkspacesWorkspace#workspace_properties}
        /// </remarks>
        [JsiiProperty(name: "workspaceProperties", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesWorkspaceWorkspaceProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Workspaces.IWorkspacesWorkspaceWorkspaceProperties? WorkspaceProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS WorkSpaces.</summary>
        [JsiiTypeProxy(nativeType: typeof(IWorkspacesWorkspaceConfig), fullyQualifiedName: "aws.workspaces.WorkspacesWorkspaceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Workspaces.IWorkspacesWorkspaceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#bundle_id WorkspacesWorkspace#bundle_id}.</summary>
            [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
            public string BundleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#directory_id WorkspacesWorkspace#directory_id}.</summary>
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#user_name WorkspacesWorkspace#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#root_volume_encryption_enabled WorkspacesWorkspace#root_volume_encryption_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootVolumeEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RootVolumeEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#tags WorkspacesWorkspace#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#user_volume_encryption_enabled WorkspacesWorkspace#user_volume_encryption_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userVolumeEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UserVolumeEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#volume_encryption_key WorkspacesWorkspace#volume_encryption_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeEncryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeEncryptionKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>workspace_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#workspace_properties WorkspacesWorkspace#workspace_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceProperties", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesWorkspaceWorkspaceProperties\"}", isOptional: true)]
            public aws.Workspaces.IWorkspacesWorkspaceWorkspaceProperties? WorkspaceProperties
            {
                get => GetInstanceProperty<aws.Workspaces.IWorkspacesWorkspaceWorkspaceProperties?>();
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
