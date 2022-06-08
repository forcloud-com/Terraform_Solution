using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/ecr_image aws_ecr_image}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecr.DataAwsEcrImage), fullyQualifiedName: "aws.ecr.DataAwsEcrImage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecr.DataAwsEcrImageConfig\"}}]")]
    public class DataAwsEcrImage : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/ecr_image aws_ecr_image} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEcrImage(Constructs.Construct scope, string id, aws.Ecr.IDataAwsEcrImageConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcrImage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcrImage(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetImageDigest")]
        public virtual void ResetImageDigest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageTag")]
        public virtual void ResetImageTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistryId")]
        public virtual void ResetRegistryId()
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
        = GetStaticProperty<string>(typeof(aws.Ecr.DataAwsEcrImage))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imagePushedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ImagePushedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "imageSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ImageSizeInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "imageTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ImageTags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageDigestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageDigestInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageTagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageTagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageTag
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
