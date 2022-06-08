using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiByValue(fqn: "aws.athena.AthenaWorkgroupConfigurationResultConfiguration")]
    public class AthenaWorkgroupConfigurationResultConfiguration : aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration
    {
        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#encryption_configuration AthenaWorkgroup#encryption_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"}", isOptional: true)]
        public aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#output_location AthenaWorkgroup#output_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputLocation
        {
            get;
            set;
        }
    }
}
