using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoring), fullyQualifiedName: "aws.msk.MskClusterOpenMonitoring")]
    public interface IMskClusterOpenMonitoring
    {
        /// <summary>prometheus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#prometheus MskCluster#prometheus}
        /// </remarks>
        [JsiiProperty(name: "prometheus", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheus\"}")]
        aws.Msk.IMskClusterOpenMonitoringPrometheus Prometheus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoring), fullyQualifiedName: "aws.msk.MskClusterOpenMonitoring")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterOpenMonitoring
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>prometheus block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#prometheus MskCluster#prometheus}
            /// </remarks>
            [JsiiProperty(name: "prometheus", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheus\"}")]
            public aws.Msk.IMskClusterOpenMonitoringPrometheus Prometheus
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoringPrometheus>()!;
            }
        }
    }
}
