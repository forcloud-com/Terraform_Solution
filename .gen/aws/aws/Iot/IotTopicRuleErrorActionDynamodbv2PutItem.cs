using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleErrorActionDynamodbv2PutItem")]
    public class IotTopicRuleErrorActionDynamodbv2PutItem : aws.Iot.IIotTopicRuleErrorActionDynamodbv2PutItem
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#table_name IotTopicRule#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public string TableName
        {
            get;
            set;
        }
    }
}
