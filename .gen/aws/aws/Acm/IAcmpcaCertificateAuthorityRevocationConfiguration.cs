using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityRevocationConfiguration), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthorityRevocationConfiguration")]
    public interface IAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#crl_configuration AcmpcaCertificateAuthority#crl_configuration}
        /// </remarks>
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration? CrlConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityRevocationConfiguration), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthorityRevocationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>crl_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#crl_configuration AcmpcaCertificateAuthority#crl_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crlConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"}", isOptional: true)]
            public aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration? CrlConfiguration
            {
                get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration?>();
            }
        }
    }
}
