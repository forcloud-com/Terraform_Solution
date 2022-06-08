using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterClientAuthenticationTls), fullyQualifiedName: "aws.msk.MskClusterClientAuthenticationTls")]
    public interface IMskClusterClientAuthenticationTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#certificate_authority_arns MskCluster#certificate_authority_arns}.</summary>
        [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CertificateAuthorityArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterClientAuthenticationTls), fullyQualifiedName: "aws.msk.MskClusterClientAuthenticationTls")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterClientAuthenticationTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#certificate_authority_arns MskCluster#certificate_authority_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CertificateAuthorityArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
