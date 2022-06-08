using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventTargetSqsTarget")]
    public class CloudwatchEventTargetSqsTarget : aws.Eventbridge.ICloudwatchEventTargetSqsTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#message_group_id CloudwatchEventTarget#message_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageGroupId
        {
            get;
            set;
        }
    }
}
