using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiByValue(fqn: "aws.msk.MskClusterClientAuthenticationTls")]
    public class MskClusterClientAuthenticationTls : aws.Msk.IMskClusterClientAuthenticationTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#certificate_authority_arns MskCluster#certificate_authority_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CertificateAuthorityArns
        {
            get;
            set;
        }
    }
}
