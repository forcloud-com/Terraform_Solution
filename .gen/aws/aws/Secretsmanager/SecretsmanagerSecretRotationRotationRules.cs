using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.secretsmanager.SecretsmanagerSecretRotationRotationRules")]
    public class SecretsmanagerSecretRotationRotationRules : aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#automatically_after_days SecretsmanagerSecretRotation#automatically_after_days}.</summary>
        [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public double AutomaticallyAfterDays
        {
            get;
            set;
        }
    }
}
