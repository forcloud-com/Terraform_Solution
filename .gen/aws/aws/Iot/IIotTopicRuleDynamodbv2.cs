using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleDynamodbv2), fullyQualifiedName: "aws.iot.IotTopicRuleDynamodbv2")]
    public interface IIotTopicRuleDynamodbv2
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>put_item block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#put_item IotTopicRule#put_item}
        /// </remarks>
        [JsiiProperty(name: "putItem", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleDynamodbv2PutItem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleDynamodbv2PutItem? PutItem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleDynamodbv2), fullyQualifiedName: "aws.iot.IotTopicRuleDynamodbv2")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleDynamodbv2
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

            /// <summary>put_item block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#put_item IotTopicRule#put_item}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "putItem", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleDynamodbv2PutItem\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleDynamodbv2PutItem? PutItem
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleDynamodbv2PutItem?>();
            }
        }
    }
}
