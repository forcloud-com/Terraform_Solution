using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiByValue(fqn: "aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration")]
    public class AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration : aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#encryption_option AthenaWorkgroup#encryption_option}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#kms_key_arn AthenaWorkgroup#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }
    }
}
