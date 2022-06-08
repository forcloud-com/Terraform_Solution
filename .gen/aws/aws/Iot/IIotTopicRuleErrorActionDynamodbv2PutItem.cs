using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionDynamodbv2PutItem), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionDynamodbv2PutItem")]
    public interface IIotTopicRuleErrorActionDynamodbv2PutItem
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#table_name IotTopicRule#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionDynamodbv2PutItem), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionDynamodbv2PutItem")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleErrorActionDynamodbv2PutItem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#table_name IotTopicRule#table_name}.</summary>
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
