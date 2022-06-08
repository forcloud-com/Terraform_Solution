using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoringPrometheus), fullyQualifiedName: "aws.msk.MskClusterOpenMonitoringPrometheus")]
    public interface IMskClusterOpenMonitoringPrometheus
    {
        /// <summary>jmx_exporter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#jmx_exporter MskCluster#jmx_exporter}
        /// </remarks>
        [JsiiProperty(name: "jmxExporter", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusJmxExporter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter? JmxExporter
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_exporter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#node_exporter MskCluster#node_exporter}
        /// </remarks>
        [JsiiProperty(name: "nodeExporter", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusNodeExporter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter? NodeExporter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoringPrometheus), fullyQualifiedName: "aws.msk.MskClusterOpenMonitoringPrometheus")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterOpenMonitoringPrometheus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>jmx_exporter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#jmx_exporter MskCluster#jmx_exporter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jmxExporter", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusJmxExporter\"}", isOptional: true)]
            public aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter? JmxExporter
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter?>();
            }

            /// <summary>node_exporter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#node_exporter MskCluster#node_exporter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeExporter", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusNodeExporter\"}", isOptional: true)]
            public aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter? NodeExporter
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter?>();
            }
        }
    }
}
