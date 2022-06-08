using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiByValue(fqn: "aws.acm.AcmpcaCertificateAuthorityRevocationConfiguration")]
    public class AcmpcaCertificateAuthorityRevocationConfiguration : aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#crl_configuration AcmpcaCertificateAuthority#crl_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"}", isOptional: true)]
        public aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration? CrlConfiguration
        {
            get;
            set;
        }
    }
}
