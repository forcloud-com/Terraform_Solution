using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository aws_ecr_repository}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecr.EcrRepository), fullyQualifiedName: "aws.ecr.EcrRepository", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecr.EcrRepositoryConfig\"}}]")]
    public class EcrRepository : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository aws_ecr_repository} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcrRepository(Constructs.Construct scope, string id, aws.Ecr.IEcrRepositoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrRepository(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrRepository(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImageScanningConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecr.EcrRepositoryImageScanningConfiguration\"}}]")]
        public virtual void PutImageScanningConfiguration(aws.Ecr.IEcrRepositoryImageScanningConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecr.IEcrRepositoryImageScanningConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecr.EcrRepositoryTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ecr.IEcrRepositoryTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecr.IEcrRepositoryTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetImageScanningConfiguration")]
        public virtual void ResetImageScanningConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageTagMutability")]
        public virtual void ResetImageTagMutability()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Ecr.EcrRepository))!;

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

        [JsiiProperty(name: "imageScanningConfiguration", typeJson: "{\"fqn\":\"aws.ecr.EcrRepositoryImageScanningConfigurationOutputReference\"}")]
        public virtual aws.Ecr.EcrRepositoryImageScanningConfigurationOutputReference ImageScanningConfiguration
        {
            get => GetInstanceProperty<aws.Ecr.EcrRepositoryImageScanningConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecr.EcrRepositoryTimeoutsOutputReference\"}")]
        public virtual aws.Ecr.EcrRepositoryTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ecr.EcrRepositoryTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageScanningConfigurationInput", typeJson: "{\"fqn\":\"aws.ecr.EcrRepositoryImageScanningConfiguration\"}", isOptional: true)]
        public virtual aws.Ecr.IEcrRepositoryImageScanningConfiguration? ImageScanningConfigurationInput
        {
            get => GetInstanceProperty<aws.Ecr.IEcrRepositoryImageScanningConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageTagMutabilityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageTagMutabilityInput
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ecr.EcrRepositoryTimeouts\"}", isOptional: true)]
        public virtual aws.Ecr.IEcrRepositoryTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ecr.IEcrRepositoryTimeouts?>();
        }

        [JsiiProperty(name: "imageTagMutability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageTagMutability
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
