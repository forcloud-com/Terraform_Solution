using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleErrorActionSns")]
    public class IotTopicRuleErrorActionSns : aws.Iot.IIotTopicRuleErrorActionSns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#target_arn IotTopicRule#target_arn}.</summary>
        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#message_format IotTopicRule#message_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageFormat
        {
            get;
            set;
        }
    }
}
