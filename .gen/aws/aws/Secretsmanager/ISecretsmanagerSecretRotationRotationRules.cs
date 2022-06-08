using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    [JsiiInterface(nativeType: typeof(ISecretsmanagerSecretRotationRotationRules), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretRotationRotationRules")]
    public interface ISecretsmanagerSecretRotationRotationRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#automatically_after_days SecretsmanagerSecretRotation#automatically_after_days}.</summary>
        [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        double AutomaticallyAfterDays
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecretsmanagerSecretRotationRotationRules), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretRotationRotationRules")]
        internal sealed class _Proxy : DeputyBase, aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#automatically_after_days SecretsmanagerSecretRotation#automatically_after_days}.</summary>
            [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
            public double AutomaticallyAfterDays
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
