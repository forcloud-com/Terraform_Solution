using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiByValue(fqn: "aws.acm.DataAwsAcmpcaCertificateAuthorityRevocationConfiguration")]
    public class DataAwsAcmpcaCertificateAuthorityRevocationConfiguration : aws.Acm.IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/acmpca_certificate_authority#crl_configuration DataAwsAcmpcaCertificateAuthority#crl_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.acm.DataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CrlConfiguration
        {
            get;
            set;
        }
    }
}
