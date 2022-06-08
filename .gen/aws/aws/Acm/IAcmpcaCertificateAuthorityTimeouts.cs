using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityTimeouts), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthorityTimeouts")]
    public interface IAcmpcaCertificateAuthorityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#create AcmpcaCertificateAuthority#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityTimeouts), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthorityTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Acm.IAcmpcaCertificateAuthorityTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority#create AcmpcaCertificateAuthority#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
