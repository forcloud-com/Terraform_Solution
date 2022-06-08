using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiInterface(nativeType: typeof(IEksClusterIdentity), fullyQualifiedName: "aws.eks.EksClusterIdentity")]
    public interface IEksClusterIdentity
    {

        [JsiiTypeProxy(nativeType: typeof(IEksClusterIdentity), fullyQualifiedName: "aws.eks.EksClusterIdentity")]
        internal sealed class _Proxy : DeputyBase, aws.Eks.IEksClusterIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
