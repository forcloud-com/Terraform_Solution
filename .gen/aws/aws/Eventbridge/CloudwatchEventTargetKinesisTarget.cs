using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventTargetKinesisTarget")]
    public class CloudwatchEventTargetKinesisTarget : aws.Eventbridge.ICloudwatchEventTargetKinesisTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#partition_key_path CloudwatchEventTarget#partition_key_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PartitionKeyPath
        {
            get;
            set;
        }
    }
}
