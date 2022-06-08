using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfiguration), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationResultConfiguration")]
    public interface IAthenaWorkgroupConfigurationResultConfiguration
    {
        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#encryption_configuration AthenaWorkgroup#encryption_configuration}
        /// </remarks>
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#output_location AthenaWorkgroup#output_location}.</summary>
        [JsiiProperty(name: "outputLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfiguration), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationResultConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>encryption_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#encryption_configuration AthenaWorkgroup#encryption_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"}", isOptional: true)]
            public aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration
            {
                get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#output_location AthenaWorkgroup#output_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputLocation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
