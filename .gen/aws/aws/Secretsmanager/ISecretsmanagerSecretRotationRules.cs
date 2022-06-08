using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    [JsiiInterface(nativeType: typeof(ISecretsmanagerSecretRotationRules), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretRotationRules")]
    public interface ISecretsmanagerSecretRotationRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret#automatically_after_days SecretsmanagerSecret#automatically_after_days}.</summary>
        [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        double AutomaticallyAfterDays
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecretsmanagerSecretRotationRules), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretRotationRules")]
        internal sealed class _Proxy : DeputyBase, aws.Secretsmanager.ISecretsmanagerSecretRotationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret#automatically_after_days SecretsmanagerSecret#automatically_after_days}.</summary>
            [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
            public double AutomaticallyAfterDays
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
