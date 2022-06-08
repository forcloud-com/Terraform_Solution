using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleFirehose")]
    public class IotTopicRuleFirehose : aws.Iot.IIotTopicRuleFirehose
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#delivery_stream_name IotTopicRule#delivery_stream_name}.</summary>
        [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeliveryStreamName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#separator IotTopicRule#separator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Separator
        {
            get;
            set;
        }
    }
}
