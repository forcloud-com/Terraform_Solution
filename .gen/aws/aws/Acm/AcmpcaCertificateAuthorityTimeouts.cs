using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiByValue(fqn: "aws.acm.AcmpcaCertificateAuthorityTimeouts")]
    public class AcmpcaCertificateAuthorityTimeouts : aws.Acm.IAcmpcaCertificateAuthorityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#create AcmpcaCertificateAuthority#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
