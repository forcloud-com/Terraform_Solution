using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory aws_workspaces_directory}.</summary>
    [JsiiClass(nativeType: typeof(aws.Workspaces.WorkspacesDirectory), fullyQualifiedName: "aws.workspaces.WorkspacesDirectory", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.workspaces.WorkspacesDirectoryConfig\"}}]")]
    public class WorkspacesDirectory : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory aws_workspaces_directory} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WorkspacesDirectory(Constructs.Construct scope, string id, aws.Workspaces.IWorkspacesDirectoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesDirectory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesDirectory(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSelfServicePermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspaces.WorkspacesDirectorySelfServicePermissions\"}}]")]
        public virtual void PutSelfServicePermissions(aws.Workspaces.IWorkspacesDirectorySelfServicePermissions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Workspaces.IWorkspacesDirectorySelfServicePermissions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSelfServicePermissions")]
        public virtual void ResetSelfServicePermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetIds")]
        public virtual void ResetSubnetIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Workspaces.WorkspacesDirectory))!;

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "iamRoleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRoleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "registrationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selfServicePermissions", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesDirectorySelfServicePermissionsOutputReference\"}")]
        public virtual aws.Workspaces.WorkspacesDirectorySelfServicePermissionsOutputReference SelfServicePermissions
        {
            get => GetInstanceProperty<aws.Workspaces.WorkspacesDirectorySelfServicePermissionsOutputReference>()!;
        }

        [JsiiProperty(name: "workspaceSecurityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceSecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfServicePermissionsInput", typeJson: "{\"fqn\":\"aws.workspaces.WorkspacesDirectorySelfServicePermissions\"}", isOptional: true)]
        public virtual aws.Workspaces.IWorkspacesDirectorySelfServicePermissions? SelfServicePermissionsInput
        {
            get => GetInstanceProperty<aws.Workspaces.IWorkspacesDirectorySelfServicePermissions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
