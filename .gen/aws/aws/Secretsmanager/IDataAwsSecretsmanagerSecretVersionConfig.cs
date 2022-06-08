using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    /// <summary>AWS Secrets Manager.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsSecretsmanagerSecretVersionConfig), fullyQualifiedName: "aws.secretsmanager.DataAwsSecretsmanagerSecretVersionConfig")]
    public interface IDataAwsSecretsmanagerSecretVersionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version#secret_id DataAwsSecretsmanagerSecretVersion#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version#version_id DataAwsSecretsmanagerSecretVersion#version_id}.</summary>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version#version_stage DataAwsSecretsmanagerSecretVersion#version_stage}.</summary>
        [JsiiProperty(name: "versionStage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionStage
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Secrets Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsSecretsmanagerSecretVersionConfig), fullyQualifiedName: "aws.secretsmanager.DataAwsSecretsmanagerSecretVersionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Secretsmanager.IDataAwsSecretsmanagerSecretVersionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version#secret_id DataAwsSecretsmanagerSecretVersion#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version#version_id DataAwsSecretsmanagerSecretVersion#version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version#version_stage DataAwsSecretsmanagerSecretVersion#version_stage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionStage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionStage
            {
                get => GetInstanceProperty<string?>();
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
