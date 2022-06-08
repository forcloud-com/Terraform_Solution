using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration")]
    public class AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration : aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#expiration_in_days AcmpcaCertificateAuthority#expiration_in_days}.</summary>
        [JsiiProperty(name: "expirationInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double ExpirationInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#custom_cname AcmpcaCertificateAuthority#custom_cname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customCname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomCname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#enabled AcmpcaCertificateAuthority#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#s3_bucket_name AcmpcaCertificateAuthority#s3_bucket_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3BucketName
        {
            get;
            set;
        }
    }
}
