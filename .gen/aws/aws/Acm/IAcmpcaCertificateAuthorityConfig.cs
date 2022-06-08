using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    /// <summary>Amazon Certificate Manager.</summary>
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityConfig), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthorityConfig")]
    public interface IAcmpcaCertificateAuthorityConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>certificate_authority_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#certificate_authority_configuration AcmpcaCertificateAuthority#certificate_authority_configuration}
        /// </remarks>
        [JsiiProperty(name: "certificateAuthorityConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"}")]
        aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration CertificateAuthorityConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#enabled AcmpcaCertificateAuthority#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#permanent_deletion_time_in_days AcmpcaCertificateAuthority#permanent_deletion_time_in_days}.</summary>
        [JsiiProperty(name: "permanentDeletionTimeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PermanentDeletionTimeInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>revocation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#revocation_configuration AcmpcaCertificateAuthority#revocation_configuration}
        /// </remarks>
        [JsiiProperty(name: "revocationConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration? RevocationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#tags AcmpcaCertificateAuthority#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#timeouts AcmpcaCertificateAuthority#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Acm.IAcmpcaCertificateAuthorityTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#type AcmpcaCertificateAuthority#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amazon Certificate Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityConfig), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthorityConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Acm.IAcmpcaCertificateAuthorityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>certificate_authority_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#certificate_authority_configuration AcmpcaCertificateAuthority#certificate_authority_configuration}
            /// </remarks>
            [JsiiProperty(name: "certificateAuthorityConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"}")]
            public aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration CertificateAuthorityConfiguration
            {
                get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#enabled AcmpcaCertificateAuthority#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#permanent_deletion_time_in_days AcmpcaCertificateAuthority#permanent_deletion_time_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "permanentDeletionTimeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PermanentDeletionTimeInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>revocation_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#revocation_configuration AcmpcaCertificateAuthority#revocation_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "revocationConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfiguration\"}", isOptional: true)]
            public aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration? RevocationConfiguration
            {
                get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#tags AcmpcaCertificateAuthority#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#timeouts AcmpcaCertificateAuthority#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityTimeouts\"}", isOptional: true)]
            public aws.Acm.IAcmpcaCertificateAuthorityTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#type AcmpcaCertificateAuthority#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
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
