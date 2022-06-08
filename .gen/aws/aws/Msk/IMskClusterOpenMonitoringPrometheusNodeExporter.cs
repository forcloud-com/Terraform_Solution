using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoringPrometheusNodeExporter), fullyQualifiedName: "aws.msk.MskClusterOpenMonitoringPrometheusNodeExporter")]
    public interface IMskClusterOpenMonitoringPrometheusNodeExporter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enabled_in_broker MskCluster#enabled_in_broker}.</summary>
        [JsiiProperty(name: "enabledInBroker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object EnabledInBroker
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoringPrometheusNodeExporter), fullyQualifiedName: "aws.msk.MskClusterOpenMonitoringPrometheusNodeExporter")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enabled_in_broker MskCluster#enabled_in_broker}.</summary>
            [JsiiProperty(name: "enabledInBroker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object EnabledInBroker
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
