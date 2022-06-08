using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiInterface(nativeType: typeof(IEksClusterEncryptionConfigProvider), fullyQualifiedName: "aws.eks.EksClusterEncryptionConfigProvider")]
    public interface IEksClusterEncryptionConfigProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#key_arn EksCluster#key_arn}.</summary>
        [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
        string KeyArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterEncryptionConfigProvider), fullyQualifiedName: "aws.eks.EksClusterEncryptionConfigProvider")]
        internal sealed class _Proxy : DeputyBase, aws.Eks.IEksClusterEncryptionConfigProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#key_arn EksCluster#key_arn}.</summary>
            [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
