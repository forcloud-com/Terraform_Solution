using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point aws_efs_access_point}.</summary>
    [JsiiClass(nativeType: typeof(aws.Efs.EfsAccessPoint), fullyQualifiedName: "aws.efs.EfsAccessPoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.efs.EfsAccessPointConfig\"}}]")]
    public class EfsAccessPoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point aws_efs_access_point} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EfsAccessPoint(Constructs.Construct scope, string id, aws.Efs.IEfsAccessPointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPosixUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.efs.EfsAccessPointPosixUser\"}}]")]
        public virtual void PutPosixUser(aws.Efs.IEfsAccessPointPosixUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Efs.IEfsAccessPointPosixUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRootDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.efs.EfsAccessPointRootDirectory\"}}]")]
        public virtual void PutRootDirectory(aws.Efs.IEfsAccessPointRootDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Efs.IEfsAccessPointRootDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPosixUser")]
        public virtual void ResetPosixUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDirectory")]
        public virtual void ResetRootDirectory()
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
        = GetStaticProperty<string>(typeof(aws.Efs.EfsAccessPoint))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "posixUser", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointPosixUserOutputReference\"}")]
        public virtual aws.Efs.EfsAccessPointPosixUserOutputReference PosixUser
        {
            get => GetInstanceProperty<aws.Efs.EfsAccessPointPosixUserOutputReference>()!;
        }

        [JsiiProperty(name: "rootDirectory", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectoryOutputReference\"}")]
        public virtual aws.Efs.EfsAccessPointRootDirectoryOutputReference RootDirectory
        {
            get => GetInstanceProperty<aws.Efs.EfsAccessPointRootDirectoryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "posixUserInput", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointPosixUser\"}", isOptional: true)]
        public virtual aws.Efs.IEfsAccessPointPosixUser? PosixUserInput
        {
            get => GetInstanceProperty<aws.Efs.IEfsAccessPointPosixUser?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDirectoryInput", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectory\"}", isOptional: true)]
        public virtual aws.Efs.IEfsAccessPointRootDirectory? RootDirectoryInput
        {
            get => GetInstanceProperty<aws.Efs.IEfsAccessPointRootDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemId
        {
            get => GetInstanceProperty<string>()!;
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
