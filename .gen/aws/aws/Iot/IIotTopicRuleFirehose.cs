using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleFirehose), fullyQualifiedName: "aws.iot.IotTopicRuleFirehose")]
    public interface IIotTopicRuleFirehose
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#delivery_stream_name IotTopicRule#delivery_stream_name}.</summary>
        [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
        string DeliveryStreamName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#separator IotTopicRule#separator}.</summary>
        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Separator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleFirehose), fullyQualifiedName: "aws.iot.IotTopicRuleFirehose")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleFirehose
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#delivery_stream_name IotTopicRule#delivery_stream_name}.</summary>
            [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeliveryStreamName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#separator IotTopicRule#separator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Separator
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
