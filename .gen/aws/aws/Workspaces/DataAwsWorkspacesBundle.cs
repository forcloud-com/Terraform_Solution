using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/workspaces_bundle aws_workspaces_bundle}.</summary>
    [JsiiClass(nativeType: typeof(aws.Workspaces.DataAwsWorkspacesBundle), fullyQualifiedName: "aws.workspaces.DataAwsWorkspacesBundle", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.workspaces.DataAwsWorkspacesBundleConfig\"}}]")]
    public class DataAwsWorkspacesBundle : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/workspaces_bundle aws_workspaces_bundle} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsWorkspacesBundle(Constructs.Construct scope, string id, aws.Workspaces.IDataAwsWorkspacesBundleConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesBundle(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesBundle(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBundleId")]
        public virtual void ResetBundleId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwner")]
        public virtual void ResetOwner()
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
        = GetStaticProperty<string>(typeof(aws.Workspaces.DataAwsWorkspacesBundle))!;

        [JsiiProperty(name: "computeType", typeJson: "{\"fqn\":\"aws.workspaces.DataAwsWorkspacesBundleComputeTypeList\"}")]
        public virtual aws.Workspaces.DataAwsWorkspacesBundleComputeTypeList ComputeType
        {
            get => GetInstanceProperty<aws.Workspaces.DataAwsWorkspacesBundleComputeTypeList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootStorage", typeJson: "{\"fqn\":\"aws.workspaces.DataAwsWorkspacesBundleRootStorageList\"}")]
        public virtual aws.Workspaces.DataAwsWorkspacesBundleRootStorageList RootStorage
        {
            get => GetInstanceProperty<aws.Workspaces.DataAwsWorkspacesBundleRootStorageList>()!;
        }

        [JsiiProperty(name: "userStorage", typeJson: "{\"fqn\":\"aws.workspaces.DataAwsWorkspacesBundleUserStorageList\"}")]
        public virtual aws.Workspaces.DataAwsWorkspacesBundleUserStorageList UserStorage
        {
            get => GetInstanceProperty<aws.Workspaces.DataAwsWorkspacesBundleUserStorageList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bundleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BundleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BundleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
