using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfoBrokerLogsFirehose), fullyQualifiedName: "aws.msk.MskClusterLoggingInfoBrokerLogsFirehose")]
    public interface IMskClusterLoggingInfoBrokerLogsFirehose
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enabled MskCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#delivery_stream MskCluster#delivery_stream}.</summary>
        [JsiiProperty(name: "deliveryStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryStream
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfoBrokerLogsFirehose), fullyQualifiedName: "aws.msk.MskClusterLoggingInfoBrokerLogsFirehose")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#delivery_stream MskCluster#delivery_stream}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryStream
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
