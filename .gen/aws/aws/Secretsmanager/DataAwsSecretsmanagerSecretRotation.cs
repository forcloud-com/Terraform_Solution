using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_rotation aws_secretsmanager_secret_rotation}.</summary>
    [JsiiClass(nativeType: typeof(aws.Secretsmanager.DataAwsSecretsmanagerSecretRotation), fullyQualifiedName: "aws.secretsmanager.DataAwsSecretsmanagerSecretRotation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.secretsmanager.DataAwsSecretsmanagerSecretRotationConfig\"}}]")]
    public class DataAwsSecretsmanagerSecretRotation : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_rotation aws_secretsmanager_secret_rotation} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsSecretsmanagerSecretRotation(Constructs.Construct scope, string id, aws.Secretsmanager.IDataAwsSecretsmanagerSecretRotationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecretsmanagerSecretRotation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecretsmanagerSecretRotation(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(aws.Secretsmanager.DataAwsSecretsmanagerSecretRotation))!;

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

        [JsiiProperty(name: "rotationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationLambdaArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rotationRules", typeJson: "{\"fqn\":\"aws.secretsmanager.DataAwsSecretsmanagerSecretRotationRotationRulesList\"}")]
        public virtual aws.Secretsmanager.DataAwsSecretsmanagerSecretRotationRotationRulesList RotationRules
        {
            get => GetInstanceProperty<aws.Secretsmanager.DataAwsSecretsmanagerSecretRotationRotationRulesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
