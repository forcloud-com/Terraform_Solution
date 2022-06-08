using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs aws_datasync_location_nfs}.</summary>
    [JsiiClass(nativeType: typeof(aws.Datasync.DatasyncLocationNfs), fullyQualifiedName: "aws.datasync.DatasyncLocationNfs", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.datasync.DatasyncLocationNfsConfig\"}}]")]
    public class DatasyncLocationNfs : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs aws_datasync_location_nfs} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatasyncLocationNfs(Constructs.Construct scope, string id, aws.Datasync.IDatasyncLocationNfsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationNfs(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationNfs(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnPremConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasync.DatasyncLocationNfsOnPremConfig\"}}]")]
        public virtual void PutOnPremConfig(aws.Datasync.IDatasyncLocationNfsOnPremConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Datasync.IDatasyncLocationNfsOnPremConfig)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Datasync.DatasyncLocationNfs))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onPremConfig", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationNfsOnPremConfigOutputReference\"}")]
        public virtual aws.Datasync.DatasyncLocationNfsOnPremConfigOutputReference OnPremConfig
        {
            get => GetInstanceProperty<aws.Datasync.DatasyncLocationNfsOnPremConfigOutputReference>()!;
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPremConfigInput", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationNfsOnPremConfig\"}", isOptional: true)]
        public virtual aws.Datasync.IDatasyncLocationNfsOnPremConfig? OnPremConfigInput
        {
            get => GetInstanceProperty<aws.Datasync.IDatasyncLocationNfsOnPremConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverHostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerHostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subdirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubdirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "serverHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerHostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subdirectory
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
