using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    /// <summary>AWS Database Migration Service.</summary>
    [JsiiInterface(nativeType: typeof(IDmsCertificateConfig), fullyQualifiedName: "aws.dms.DmsCertificateConfig")]
    public interface IDmsCertificateConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_certificate#certificate_id DmsCertificate#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_certificate#certificate_pem DmsCertificate#certificate_pem}.</summary>
        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificatePem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_certificate#certificate_wallet DmsCertificate#certificate_wallet}.</summary>
        [JsiiProperty(name: "certificateWallet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateWallet
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Database Migration Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDmsCertificateConfig), fullyQualifiedName: "aws.dms.DmsCertificateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Dms.IDmsCertificateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_certificate#certificate_id DmsCertificate#certificate_id}.</summary>
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_certificate#certificate_pem DmsCertificate#certificate_pem}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificatePem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_certificate#certificate_wallet DmsCertificate#certificate_wallet}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateWallet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateWallet
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
