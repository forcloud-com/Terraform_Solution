using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    [JsiiInterface(nativeType: typeof(IMqBrokerLogs), fullyQualifiedName: "aws.mq.MqBrokerLogs")]
    public interface IMqBrokerLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#audit MqBroker#audit}.</summary>
        [JsiiProperty(name: "audit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Audit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#general MqBroker#general}.</summary>
        [JsiiProperty(name: "general", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? General
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerLogs), fullyQualifiedName: "aws.mq.MqBrokerLogs")]
        internal sealed class _Proxy : DeputyBase, aws.Mq.IMqBrokerLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#audit MqBroker#audit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Audit
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#general MqBroker#general}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "general", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? General
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
