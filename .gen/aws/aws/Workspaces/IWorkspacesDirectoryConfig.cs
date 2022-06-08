using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    /// <summary>AWS WorkSpaces.</summary>
    [JsiiInterface(nativeType: typeof(IWorkspacesDirectoryConfig), fullyQualifiedName: "aws.workspaces.WorkspacesDirectoryConfig")]
    public interface IWorkspacesDirectoryConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#directory_id WorkspacesDirectory#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryId
        {
            get;
        }

        /// <summary>self_service_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#self_service_permissions WorkspacesDirectory#self_service_permissions}
        /// </remarks>
        [JsiiProperty(name: "selfServicePermissions", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesDirectorySelfServicePermissions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Workspaces.IWorkspacesDirectorySelfServicePermissions? SelfServicePermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#subnet_ids WorkspacesDirectory#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubnetIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#tags WorkspacesDirectory#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS WorkSpaces.</summary>
        [JsiiTypeProxy(nativeType: typeof(IWorkspacesDirectoryConfig), fullyQualifiedName: "aws.workspaces.WorkspacesDirectoryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Workspaces.IWorkspacesDirectoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#directory_id WorkspacesDirectory#directory_id}.</summary>
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>self_service_permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#self_service_permissions WorkspacesDirectory#self_service_permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfServicePermissions", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesDirectorySelfServicePermissions\"}", isOptional: true)]
            public aws.Workspaces.IWorkspacesDirectorySelfServicePermissions? SelfServicePermissions
            {
                get => GetInstanceProperty<aws.Workspaces.IWorkspacesDirectorySelfServicePermissions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#subnet_ids WorkspacesDirectory#subnet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#tags WorkspacesDirectory#tags}.</summary>
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
