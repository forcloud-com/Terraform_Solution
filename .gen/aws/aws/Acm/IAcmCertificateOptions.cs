using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiInterface(nativeType: typeof(IAcmCertificateOptions), fullyQualifiedName: "aws.acm.AcmCertificateOptions")]
    public interface IAcmCertificateOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_transparency_logging_preference AcmCertificate#certificate_transparency_logging_preference}.</summary>
        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateTransparencyLoggingPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmCertificateOptions), fullyQualifiedName: "aws.acm.AcmCertificateOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Acm.IAcmCertificateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_transparency_logging_preference AcmCertificate#certificate_transparency_logging_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateTransparencyLoggingPreference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
