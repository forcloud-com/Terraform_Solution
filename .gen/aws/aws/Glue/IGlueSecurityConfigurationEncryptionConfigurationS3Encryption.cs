using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationS3Encryption), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationEncryptionConfigurationS3Encryption")]
    public interface IGlueSecurityConfigurationEncryptionConfigurationS3Encryption
    {
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#s3_encryption_mode GlueSecurityConfiguration#s3_encryption_mode}.</summary>
        [JsiiProperty(name: "s3EncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3EncryptionMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationS3Encryption), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationEncryptionConfigurationS3Encryption")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#kms_key_arn GlueSecurityConfiguration#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#s3_encryption_mode GlueSecurityConfiguration#s3_encryption_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3EncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3EncryptionMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
