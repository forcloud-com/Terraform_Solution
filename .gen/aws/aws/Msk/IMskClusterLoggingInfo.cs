using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfo), fullyQualifiedName: "aws.msk.MskClusterLoggingInfo")]
    public interface IMskClusterLoggingInfo
    {
        /// <summary>broker_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#broker_logs MskCluster#broker_logs}
        /// </remarks>
        [JsiiProperty(name: "brokerLogs", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogs\"}")]
        aws.Msk.IMskClusterLoggingInfoBrokerLogs BrokerLogs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfo), fullyQualifiedName: "aws.msk.MskClusterLoggingInfo")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterLoggingInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>broker_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#broker_logs MskCluster#broker_logs}
            /// </remarks>
            [JsiiProperty(name: "brokerLogs", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogs\"}")]
            public aws.Msk.IMskClusterLoggingInfoBrokerLogs BrokerLogs
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogs>()!;
            }
        }
    }
}
