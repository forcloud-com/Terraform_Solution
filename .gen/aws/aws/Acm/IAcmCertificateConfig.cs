using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    /// <summary>Amazon Certificate Manager.</summary>
    [JsiiInterface(nativeType: typeof(IAcmCertificateConfig), fullyQualifiedName: "aws.acm.AcmCertificateConfig")]
    public interface IAcmCertificateConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_authority_arn AcmCertificate#certificate_authority_arn}.</summary>
        [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateAuthorityArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_body AcmCertificate#certificate_body}.</summary>
        [JsiiProperty(name: "certificateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_chain AcmCertificate#certificate_chain}.</summary>
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateChain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#domain_name AcmCertificate#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainName
        {
            get
            {
                return null;
            }
        }

        /// <summary>options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#options AcmCertificate#options}
        /// </remarks>
        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"aws.acm.AcmCertificateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Acm.IAcmCertificateOptions? Options
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#private_key AcmCertificate#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#subject_alternative_names AcmCertificate#subject_alternative_names}.</summary>
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubjectAlternativeNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#tags AcmCertificate#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#validation_method AcmCertificate#validation_method}.</summary>
        [JsiiProperty(name: "validationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amazon Certificate Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAcmCertificateConfig), fullyQualifiedName: "aws.acm.AcmCertificateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Acm.IAcmCertificateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_authority_arn AcmCertificate#certificate_authority_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateAuthorityArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_body AcmCertificate#certificate_body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#certificate_chain AcmCertificate#certificate_chain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateChain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#domain_name AcmCertificate#domain_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#options AcmCertificate#options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"aws.acm.AcmCertificateOptions\"}", isOptional: true)]
            public aws.Acm.IAcmCertificateOptions? Options
            {
                get => GetInstanceProperty<aws.Acm.IAcmCertificateOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#private_key AcmCertificate#private_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#subject_alternative_names AcmCertificate#subject_alternative_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubjectAlternativeNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#tags AcmCertificate#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate#validation_method AcmCertificate#validation_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
