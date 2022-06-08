using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiInterface(nativeType: typeof(IEksClusterEncryptionConfig), fullyQualifiedName: "aws.eks.EksClusterEncryptionConfig")]
    public interface IEksClusterEncryptionConfig
    {
        /// <summary>provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#provider EksCluster#provider}
        /// </remarks>
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.eks.EksClusterEncryptionConfigProvider\"}")]
        aws.Eks.IEksClusterEncryptionConfigProvider Provider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#resources EksCluster#resources}.</summary>
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterEncryptionConfig), fullyQualifiedName: "aws.eks.EksClusterEncryptionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Eks.IEksClusterEncryptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#provider EksCluster#provider}
            /// </remarks>
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.eks.EksClusterEncryptionConfigProvider\"}")]
            public aws.Eks.IEksClusterEncryptionConfigProvider Provider
            {
                get => GetInstanceProperty<aws.Eks.IEksClusterEncryptionConfigProvider>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#resources EksCluster#resources}.</summary>
            [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Resources
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
