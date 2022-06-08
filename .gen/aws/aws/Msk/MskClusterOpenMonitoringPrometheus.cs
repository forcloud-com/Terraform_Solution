using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiByValue(fqn: "aws.msk.MskClusterOpenMonitoringPrometheus")]
    public class MskClusterOpenMonitoringPrometheus : aws.Msk.IMskClusterOpenMonitoringPrometheus
    {
        /// <summary>jmx_exporter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#jmx_exporter MskCluster#jmx_exporter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jmxExporter", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusJmxExporter\"}", isOptional: true)]
        public aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter? JmxExporter
        {
            get;
            set;
        }

        /// <summary>node_exporter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#node_exporter MskCluster#node_exporter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeExporter", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusNodeExporter\"}", isOptional: true)]
        public aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter? NodeExporter
        {
            get;
            set;
        }
    }
}
