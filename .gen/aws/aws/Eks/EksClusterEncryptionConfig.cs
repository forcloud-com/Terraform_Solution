using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eks.EksClusterEncryptionConfig")]
    public class EksClusterEncryptionConfig : aws.Eks.IEksClusterEncryptionConfig
    {
        /// <summary>provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#provider EksCluster#provider}
        /// </remarks>
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.eks.EksClusterEncryptionConfigProvider\"}")]
        public aws.Eks.IEksClusterEncryptionConfigProvider Provider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#resources EksCluster#resources}.</summary>
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Resources
        {
            get;
            set;
        }
    }
}
