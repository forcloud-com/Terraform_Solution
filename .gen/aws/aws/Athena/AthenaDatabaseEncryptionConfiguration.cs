using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.athena.AthenaDatabaseEncryptionConfiguration")]
    public class AthenaDatabaseEncryptionConfiguration : aws.Athena.IAthenaDatabaseEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_database#encryption_option AthenaDatabase#encryption_option}.</summary>
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}")]
        public string EncryptionOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_database#kms_key AthenaDatabase#kms_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKey
        {
            get;
            set;
        }
    }
}
