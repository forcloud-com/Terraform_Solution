using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiByValue(fqn: "aws.acm.AcmCertificateOptions")]
    public class AcmCertificateOptions : aws.Acm.IAcmCertificateOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_transparency_logging_preference AcmCertificate#certificate_transparency_logging_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateTransparencyLoggingPreference
        {
            get;
            set;
        }
    }
}
