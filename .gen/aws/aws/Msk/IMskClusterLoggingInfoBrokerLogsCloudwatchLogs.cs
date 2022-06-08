using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfoBrokerLogsCloudwatchLogs), fullyQualifiedName: "aws.msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogs")]
    public interface IMskClusterLoggingInfoBrokerLogsCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enabled MskCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#log_group MskCluster#log_group}.</summary>
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfoBrokerLogsCloudwatchLogs), fullyQualifiedName: "aws.msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogs")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enabled MskCluster#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#log_group MskCluster#log_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
