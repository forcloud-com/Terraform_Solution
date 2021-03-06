using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleKinesis), fullyQualifiedName: "aws.iot.IotTopicRuleKinesis")]
    public interface IIotTopicRuleKinesis
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#stream_name IotTopicRule#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        string StreamName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#partition_key IotTopicRule#partition_key}.</summary>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartitionKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleKinesis), fullyQualifiedName: "aws.iot.IotTopicRuleKinesis")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleKinesis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#stream_name IotTopicRule#stream_name}.</summary>
            [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#partition_key IotTopicRule#partition_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartitionKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
