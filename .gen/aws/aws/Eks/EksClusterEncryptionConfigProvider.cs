using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eks.EksClusterEncryptionConfigProvider")]
    public class EksClusterEncryptionConfigProvider : aws.Eks.IEksClusterEncryptionConfigProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#key_arn EksCluster#key_arn}.</summary>
        [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyArn
        {
            get;
            set;
        }
    }
}
