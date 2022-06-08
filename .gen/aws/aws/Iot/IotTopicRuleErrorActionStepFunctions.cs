using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleErrorActionStepFunctions")]
    public class IotTopicRuleErrorActionStepFunctions : aws.Iot.IIotTopicRuleErrorActionStepFunctions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#state_machine_name IotTopicRule#state_machine_name}.</summary>
        [JsiiProperty(name: "stateMachineName", typeJson: "{\"primitive\":\"string\"}")]
        public string StateMachineName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#execution_name_prefix IotTopicRule#execution_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutionNamePrefix
        {
            get;
            set;
        }
    }
}
