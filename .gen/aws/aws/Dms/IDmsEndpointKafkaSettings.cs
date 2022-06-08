using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointKafkaSettings), fullyQualifiedName: "aws.dms.DmsEndpointKafkaSettings")]
    public interface IDmsEndpointKafkaSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#broker DmsEndpoint#broker}.</summary>
        [JsiiProperty(name: "broker", typeJson: "{\"primitive\":\"string\"}")]
        string Broker
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#topic DmsEndpoint#topic}.</summary>
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Topic
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointKafkaSettings), fullyQualifiedName: "aws.dms.DmsEndpointKafkaSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Dms.IDmsEndpointKafkaSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#broker DmsEndpoint#broker}.</summary>
            [JsiiProperty(name: "broker", typeJson: "{\"primitive\":\"string\"}")]
            public string Broker
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#topic DmsEndpoint#topic}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Topic
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
