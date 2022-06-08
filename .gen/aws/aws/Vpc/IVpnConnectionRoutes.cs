using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiInterface(nativeType: typeof(IVpnConnectionRoutes), fullyQualifiedName: "aws.vpc.VpnConnectionRoutes")]
    public interface IVpnConnectionRoutes
    {

        [JsiiTypeProxy(nativeType: typeof(IVpnConnectionRoutes), fullyQualifiedName: "aws.vpc.VpnConnectionRoutes")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IVpnConnectionRoutes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
