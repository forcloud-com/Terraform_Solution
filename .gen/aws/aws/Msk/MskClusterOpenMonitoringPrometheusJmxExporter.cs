using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.msk.MskClusterOpenMonitoringPrometheusJmxExporter")]
    public class MskClusterOpenMonitoringPrometheusJmxExporter : aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enabled_in_broker MskCluster#enabled_in_broker}.</summary>
        [JsiiProperty(name: "enabledInBroker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object EnabledInBroker
        {
            get;
            set;
        }
    }
}
