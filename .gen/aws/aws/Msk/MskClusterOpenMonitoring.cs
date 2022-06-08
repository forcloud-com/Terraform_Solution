using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.msk.MskClusterOpenMonitoring")]
    public class MskClusterOpenMonitoring : aws.Msk.IMskClusterOpenMonitoring
    {
        /// <summary>prometheus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#prometheus MskCluster#prometheus}
        /// </remarks>
        [JsiiProperty(name: "prometheus", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheus\"}")]
        public aws.Msk.IMskClusterOpenMonitoringPrometheus Prometheus
        {
            get;
            set;
        }
    }
}
