using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    /// <summary>Amazon Certificate Manager.</summary>
    [JsiiByValue(fqn: "aws.acm.AcmCertificateConfig")]
    public class AcmCertificateConfig : aws.Acm.IAcmCertificateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_authority_arn AcmCertificate#certificate_authority_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateAuthorityArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_body AcmCertificate#certificate_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_chain AcmCertificate#certificate_chain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateChain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#domain_name AcmCertificate#domain_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainName
        {
            get;
            set;
        }

        /// <summary>options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#options AcmCertificate#options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"aws.acm.AcmCertificateOptions\"}", isOptional: true)]
        public aws.Acm.IAcmCertificateOptions? Options
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#private_key AcmCertificate#private_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#subject_alternative_names AcmCertificate#subject_alternative_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubjectAlternativeNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#tags AcmCertificate#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#validation_method AcmCertificate#validation_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValidationMethod
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
