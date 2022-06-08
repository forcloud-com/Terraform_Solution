using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version aws_secretsmanager_secret_version}.</summary>
    [JsiiClass(nativeType: typeof(aws.Secretsmanager.DataAwsSecretsmanagerSecretVersion), fullyQualifiedName: "aws.secretsmanager.DataAwsSecretsmanagerSecretVersion", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.secretsmanager.DataAwsSecretsmanagerSecretVersionConfig\"}}]")]
    public class DataAwsSecretsmanagerSecretVersion : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version aws_secretsmanager_secret_version} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsSecretsmanagerSecretVersion(Constructs.Construct scope, string id, aws.Secretsmanager.IDataAwsSecretsmanagerSecretVersionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecretsmanagerSecretVersion(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecretsmanagerSecretVersion(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetVersionId")]
        public virtual void ResetVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionStage")]
        public virtual void ResetVersionStage()
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
        = GetStaticProperty<string>(typeof(aws.Secretsmanager.DataAwsSecretsmanagerSecretVersion))!;

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

        [JsiiProperty(name: "secretBinary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretBinary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionStages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VersionStages
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionStageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionStageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionStage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionStage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
