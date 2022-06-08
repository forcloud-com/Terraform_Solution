using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    #pragma warning disable CS8618

    /// <summary>AWS Secrets Manager.</summary>
    [JsiiByValue(fqn: "aws.secretsmanager.SecretsmanagerSecretRotationConfig")]
    public class SecretsmanagerSecretRotationConfig : aws.Secretsmanager.ISecretsmanagerSecretRotationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#rotation_lambda_arn SecretsmanagerSecretRotation#rotation_lambda_arn}.</summary>
        [JsiiProperty(name: "rotationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RotationLambdaArn
        {
            get;
            set;
        }

        /// <summary>rotation_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#rotation_rules SecretsmanagerSecretRotation#rotation_rules}
        /// </remarks>
        [JsiiProperty(name: "rotationRules", typeJson: "{\"fqn\":\"aws.secretsmanager.SecretsmanagerSecretRotationRotationRules\"}")]
        public aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules RotationRules
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#secret_id SecretsmanagerSecretRotation#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#tags SecretsmanagerSecretRotation#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
