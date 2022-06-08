using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    #pragma warning disable CS8618

    /// <summary>AWS WorkSpaces.</summary>
    [JsiiByValue(fqn: "aws.workspaces.WorkspacesWorkspaceConfig")]
    public class WorkspacesWorkspaceConfig : aws.Workspaces.IWorkspacesWorkspaceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#bundle_id WorkspacesWorkspace#bundle_id}.</summary>
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
        public string BundleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#directory_id WorkspacesWorkspace#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public string DirectoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#user_name WorkspacesWorkspace#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#root_volume_encryption_enabled WorkspacesWorkspace#root_volume_encryption_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootVolumeEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RootVolumeEncryptionEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#tags WorkspacesWorkspace#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#user_volume_encryption_enabled WorkspacesWorkspace#user_volume_encryption_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userVolumeEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UserVolumeEncryptionEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#volume_encryption_key WorkspacesWorkspace#volume_encryption_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeEncryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeEncryptionKey
        {
            get;
            set;
        }

        /// <summary>workspace_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace#workspace_properties WorkspacesWorkspace#workspace_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workspaceProperties", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesWorkspaceWorkspaceProperties\"}", isOptional: true)]
        public aws.Workspaces.IWorkspacesWorkspaceWorkspaceProperties? WorkspaceProperties
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
