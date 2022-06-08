using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    /// <summary>AWS Secrets Manager.</summary>
    [JsiiInterface(nativeType: typeof(ISecretsmanagerSecretVersionConfig), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretVersionConfig")]
    public interface ISecretsmanagerSecretVersionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_version#secret_id SecretsmanagerSecretVersion#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_version#secret_binary SecretsmanagerSecretVersion#secret_binary}.</summary>
        [JsiiProperty(name: "secretBinary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretBinary
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_version#secret_string SecretsmanagerSecretVersion#secret_string}.</summary>
        [JsiiProperty(name: "secretString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_version#version_stages SecretsmanagerSecretVersion#version_stages}.</summary>
        [JsiiProperty(name: "versionStages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VersionStages
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Secrets Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISecretsmanagerSecretVersionConfig), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretVersionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Secretsmanager.ISecretsmanagerSecretVersionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_version#secret_id SecretsmanagerSecretVersion#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_version#secret_binary SecretsmanagerSecretVersion#secret_binary}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretBinary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretBinary
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_version#secret_string SecretsmanagerSecretVersion#secret_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_version#version_stages SecretsmanagerSecretVersion#version_stages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionStages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VersionStages
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
