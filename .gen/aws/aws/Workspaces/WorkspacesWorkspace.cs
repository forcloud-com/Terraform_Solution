using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace aws_workspaces_workspace}.</summary>
    [JsiiClass(nativeType: typeof(aws.Workspaces.WorkspacesWorkspace), fullyQualifiedName: "aws.workspaces.WorkspacesWorkspace", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.workspaces.WorkspacesWorkspaceConfig\"}}]")]
    public class WorkspacesWorkspace : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/workspaces_workspace aws_workspaces_workspace} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WorkspacesWorkspace(Constructs.Construct scope, string id, aws.Workspaces.IWorkspacesWorkspaceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesWorkspace(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesWorkspace(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWorkspaceProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspaces.WorkspacesWorkspaceWorkspaceProperties\"}}]")]
        public virtual void PutWorkspaceProperties(aws.Workspaces.IWorkspacesWorkspaceWorkspaceProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Workspaces.IWorkspacesWorkspaceWorkspaceProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRootVolumeEncryptionEnabled")]
        public virtual void ResetRootVolumeEncryptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserVolumeEncryptionEnabled")]
        public virtual void ResetUserVolumeEncryptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeEncryptionKey")]
        public virtual void ResetVolumeEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceProperties")]
        public virtual void ResetWorkspaceProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Workspaces.WorkspacesWorkspace))!;

        [JsiiProperty(name: "computerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceProperties", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesWorkspaceWorkspacePropertiesOutputReference\"}")]
        public virtual aws.Workspaces.WorkspacesWorkspaceWorkspacePropertiesOutputReference WorkspaceProperties
        {
            get => GetInstanceProperty<aws.Workspaces.WorkspacesWorkspaceWorkspacePropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bundleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BundleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootVolumeEncryptionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RootVolumeEncryptionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userVolumeEncryptionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UserVolumeEncryptionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeEncryptionKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeEncryptionKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspacePropertiesInput", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesWorkspaceWorkspaceProperties\"}", isOptional: true)]
        public virtual aws.Workspaces.IWorkspacesWorkspaceWorkspaceProperties? WorkspacePropertiesInput
        {
            get => GetInstanceProperty<aws.Workspaces.IWorkspacesWorkspaceWorkspaceProperties?>();
        }

        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BundleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootVolumeEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RootVolumeEncryptionEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userVolumeEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object UserVolumeEncryptionEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeEncryptionKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeEncryptionKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
