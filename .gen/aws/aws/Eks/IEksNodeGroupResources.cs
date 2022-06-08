using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupResources), fullyQualifiedName: "aws.eks.EksNodeGroupResources")]
    public interface IEksNodeGroupResources
    {

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupResources), fullyQualifiedName: "aws.eks.EksNodeGroupResources")]
        internal sealed class _Proxy : DeputyBase, aws.Eks.IEksNodeGroupResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
