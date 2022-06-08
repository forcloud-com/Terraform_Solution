using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    [JsiiClass(nativeType: typeof(aws.Secretsmanager.SecretsmanagerSecretRotationRulesOutputReference), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretRotationRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SecretsmanagerSecretRotationRulesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SecretsmanagerSecretRotationRulesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecretsmanagerSecretRotationRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecretsmanagerSecretRotationRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticallyAfterDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutomaticallyAfterDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutomaticallyAfterDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.secretsmanager.SecretsmanagerSecretRotationRules\"}", isOptional: true)]
        public virtual aws.Secretsmanager.ISecretsmanagerSecretRotationRules? InternalValue
        {
            get => GetInstanceProperty<aws.Secretsmanager.ISecretsmanagerSecretRotationRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
