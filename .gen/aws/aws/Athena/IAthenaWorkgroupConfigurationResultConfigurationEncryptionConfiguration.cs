using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration")]
    public interface IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#encryption_option AthenaWorkgroup#encryption_option}.</summary>
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#kms_key_arn AthenaWorkgroup#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#encryption_option AthenaWorkgroup#encryption_option}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionOption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#kms_key_arn AthenaWorkgroup#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
