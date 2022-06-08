using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption")]
    public interface IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#cloudwatch_encryption_mode GlueSecurityConfiguration#cloudwatch_encryption_mode}.</summary>
        [JsiiProperty(name: "cloudwatchEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchEncryptionMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#kms_key_arn GlueSecurityConfiguration#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#cloudwatch_encryption_mode GlueSecurityConfiguration#cloudwatch_encryption_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchEncryptionMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#kms_key_arn GlueSecurityConfiguration#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
