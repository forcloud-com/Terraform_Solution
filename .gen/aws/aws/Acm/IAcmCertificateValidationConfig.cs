using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    /// <summary>Amazon Certificate Manager.</summary>
    [JsiiInterface(nativeType: typeof(IAcmCertificateValidationConfig), fullyQualifiedName: "aws.acm.AcmCertificateValidationConfig")]
    public interface IAcmCertificateValidationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate_validation#certificate_arn AcmCertificateValidation#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateArn
        {
            get;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate_validation#timeouts AcmCertificateValidation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.acm.AcmCertificateValidationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Acm.IAcmCertificateValidationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate_validation#validation_record_fqdns AcmCertificateValidation#validation_record_fqdns}.</summary>
        [JsiiProperty(name: "validationRecordFqdns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ValidationRecordFqdns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amazon Certificate Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAcmCertificateValidationConfig), fullyQualifiedName: "aws.acm.AcmCertificateValidationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Acm.IAcmCertificateValidationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate_validation#certificate_arn AcmCertificateValidation#certificate_arn}.</summary>
            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate_validation#timeouts AcmCertificateValidation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.acm.AcmCertificateValidationTimeouts\"}", isOptional: true)]
            public aws.Acm.IAcmCertificateValidationTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Acm.IAcmCertificateValidationTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate_validation#validation_record_fqdns AcmCertificateValidation#validation_record_fqdns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validationRecordFqdns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ValidationRecordFqdns
            {
                get => GetInstanceProperty<string[]?>();
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
