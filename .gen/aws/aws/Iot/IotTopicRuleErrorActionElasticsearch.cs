using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleErrorActionElasticsearch")]
    public class IotTopicRuleErrorActionElasticsearch : aws.Iot.IIotTopicRuleErrorActionElasticsearch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#endpoint IotTopicRule#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#id IotTopicRule#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#index IotTopicRule#index}.</summary>
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"string\"}")]
        public string Index
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#type IotTopicRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
