using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.msk.MskClusterLoggingInfo")]
    public class MskClusterLoggingInfo : aws.Msk.IMskClusterLoggingInfo
    {
        /// <summary>broker_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#broker_logs MskCluster#broker_logs}
        /// </remarks>
        [JsiiProperty(name: "brokerLogs", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogs\"}")]
        public aws.Msk.IMskClusterLoggingInfoBrokerLogs BrokerLogs
        {
            get;
            set;
        }
    }
}
