using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    [JsiiInterface(nativeType: typeof(IMqBrokerConfiguration), fullyQualifiedName: "aws.mq.MqBrokerConfiguration")]
    public interface IMqBrokerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#id MqBroker#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#revision MqBroker#revision}.</summary>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Revision
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerConfiguration), fullyQualifiedName: "aws.mq.MqBrokerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Mq.IMqBrokerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#id MqBroker#id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#revision MqBroker#revision}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Revision
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
