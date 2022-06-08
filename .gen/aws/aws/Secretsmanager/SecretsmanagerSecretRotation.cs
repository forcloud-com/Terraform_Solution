using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation aws_secretsmanager_secret_rotation}.</summary>
    [JsiiClass(nativeType: typeof(aws.Secretsmanager.SecretsmanagerSecretRotation), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretRotation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.secretsmanager.SecretsmanagerSecretRotationConfig\"}}]")]
    public class SecretsmanagerSecretRotation : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation aws_secretsmanager_secret_rotation} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SecretsmanagerSecretRotation(Constructs.Construct scope, string id, aws.Secretsmanager.ISecretsmanagerSecretRotationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecretsmanagerSecretRotation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecretsmanagerSecretRotation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRotationRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.secretsmanager.SecretsmanagerSecretRotationRotationRules\"}}]")]
        public virtual void PutRotationRules(aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Secretsmanager.SecretsmanagerSecretRotation))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rotationEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RotationEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "rotationRules", typeJson: "{\"fqn\":\"aws.secretsmanager.SecretsmanagerSecretRotationRotationRulesOutputReference\"}")]
        public virtual aws.Secretsmanager.SecretsmanagerSecretRotationRotationRulesOutputReference RotationRules
        {
            get => GetInstanceProperty<aws.Secretsmanager.SecretsmanagerSecretRotationRotationRulesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rotationLambdaArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RotationLambdaArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rotationRulesInput", typeJson: "{\"fqn\":\"aws.secretsmanager.SecretsmanagerSecretRotationRotationRules\"}", isOptional: true)]
        public virtual aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules? RotationRulesInput
        {
            get => GetInstanceProperty<aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "rotationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationLambdaArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
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
